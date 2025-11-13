using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Facturas
{
    // Juan Carlos Sandoval Quej 0901-22-4170 12/11/2025
    public class Cls_Sentencias
    {
        // objeto para abrir/cerrar la conexión ODBC
        private readonly Cls_Conexion _cx = new Cls_Conexion();

        // devuelve los productos activos en un DataTable (para combos o grids)
        public DataTable ObtenerProductosDT()
        {
            var dt = new DataTable();

            // consulta a la vista de productos activos
            const string sql = @"
                SELECT 
                  p.Cmp_Id_Producto,
                  p.Cmp_Codigo_Producto,
                  p.Cmp_Nombre_Producto,
                  p.Cmp_PrecioUnitario
                FROM Vw_ProductoActivos p
                ORDER BY p.Cmp_Nombre_Producto;";

            // abrir conexión y llenar el DataTable
            using (var cn = _cx.conexion())
            using (var da = new OdbcDataAdapter(sql, cn))
            {
                da.Fill(dt);
            }
            return dt;
        }

        // estructura simple para enviar líneas de venta a BD
        public class LineaVentaDTO
        {
            public string CodigoProducto { get; set; }    // código (ej. LIM-001)
            public decimal PrecioUnitario { get; set; }   // precio del producto
            public int Cantidad { get; set; }             // cantidad vendida
            public decimal TotalLinea => PrecioUnitario * Cantidad; // subtotal
        }

        // guarda la venta y sus detalles en una transacción
        public int GuardarVentaConDetalles(
            decimal total, decimal efectivo, decimal devolucion,
            int? idUsuario, int? idMetodoPago,
            IList<LineaVentaDTO> lineas)
        {
            // validar que existan líneas
            if (lineas == null || lineas.Count == 0)
                throw new ArgumentException("No hay líneas para guardar.");

            // abrir conexión y comenzar transacción
            using (var cn = _cx.conexion())
            using (var tx = cn.BeginTransaction())
            {
                try
                {
                    // insertar encabezado de la venta
                    using (var cmd = new OdbcCommand(@"
                        INSERT INTO Tbl_Venta
                          (Cmp_Total, Cmp_Efectivo, Cmp_Devolucion, Cmp_Id_Usuario, Cmp_Id_Metodo_Pago)
                        VALUES (?,?,?,?,?);", cn, tx))
                    {
                        // parámetros decimales con precisión/escala
                        var pTot = new OdbcParameter("@tot", OdbcType.Decimal) { Value = total };
                        pTot.Precision = 12; pTot.Scale = 2; cmd.Parameters.Add(pTot);

                        var pEfe = new OdbcParameter("@efe", OdbcType.Decimal) { Value = efectivo };
                        pEfe.Precision = 12; pEfe.Scale = 2; cmd.Parameters.Add(pEfe);

                        var pDev = new OdbcParameter("@dev", OdbcType.Decimal) { Value = devolucion };
                        pDev.Precision = 12; pDev.Scale = 2; cmd.Parameters.Add(pDev);

                        // parámetros opcionales (pueden ir nulos)
                        cmd.Parameters.Add(new OdbcParameter("@usr", OdbcType.Int) { Value = (object)idUsuario ?? DBNull.Value });
                        cmd.Parameters.Add(new OdbcParameter("@mp", OdbcType.Int) { Value = (object)idMetodoPago ?? DBNull.Value });

                        cmd.ExecuteNonQuery();
                    }

                    // obtener el id de la venta guardada
                    int idVenta;
                    using (var cmdId = new OdbcCommand("SELECT LAST_INSERT_ID();", cn, tx))
                        idVenta = Convert.ToInt32(cmdId.ExecuteScalar());

                    // cache de código→id de producto (evita repetir SELECT)
                    var cache = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

                    // recorrer cada línea de la venta
                    foreach (var l in lineas)
                    {
                        if (l.Cantidad <= 0) continue; // no insertar cantidades inválidas

                        int idProd;

                        // buscar el id del producto por código (usa cache)
                        if (!cache.TryGetValue(l.CodigoProducto, out idProd))
                        {
                            using (var cmdProd = new OdbcCommand(
                                "SELECT Cmp_Id_Producto FROM Tbl_Producto WHERE Cmp_Codigo_Producto = ?;", cn, tx))
                            {
                                cmdProd.Parameters.Add(new OdbcParameter("@cod", OdbcType.VarChar) { Value = l.CodigoProducto });
                                var obj = cmdProd.ExecuteScalar();
                                if (obj == null) throw new Exception("Producto no encontrado: " + l.CodigoProducto);
                                idProd = Convert.ToInt32(obj);
                                cache[l.CodigoProducto] = idProd;
                            }
                        }

                        // insertar el detalle de la venta
                        using (var cmdDet = new OdbcCommand(@"
                            INSERT INTO Tbl_VentaDet
                              (Cmp_IdVenta, Cmp_Id_Producto, Cmp_Cantidad, Cmp_PrecioUnitario, Cmp_Total)
                            VALUES (?,?,?,?,?);", cn, tx))
                        {
                            cmdDet.Parameters.Add(new OdbcParameter("@v", OdbcType.Int) { Value = idVenta });
                            cmdDet.Parameters.Add(new OdbcParameter("@p", OdbcType.Int) { Value = idProd });

                            // cantidad como decimal por si manejas fracciones (escala 4)
                            var pCant = new OdbcParameter("@c", OdbcType.Decimal) { Value = l.Cantidad };
                            pCant.Precision = 12; pCant.Scale = 4; cmdDet.Parameters.Add(pCant);

                            var pPU = new OdbcParameter("@pu", OdbcType.Decimal) { Value = l.PrecioUnitario };
                            pPU.Precision = 12; pPU.Scale = 2; cmdDet.Parameters.Add(pPU);

                            var pSub = new OdbcParameter("@st", OdbcType.Decimal) { Value = l.TotalLinea };
                            pSub.Precision = 12; pSub.Scale = 2; cmdDet.Parameters.Add(pSub);

                            cmdDet.ExecuteNonQuery();
                        }
                    }

                    // si todo salió bien, confirmar cambios
                    tx.Commit();
                    return idVenta;
                }
                catch
                {
                    // ante cualquier error, deshacer todo
                    tx.Rollback();
                    throw;
                }
            }
        }

        // guarda la factura (encabezado) con fecha y total
        public int GuardarFactura(int idVenta, string tipoDoc, string documento,
                          string nombre, string apellido, DateTime fecha, decimal total)
        {
            using (var cn = _cx.conexion())
            {
                // inserción del encabezado de la factura
                using (var cmd = new OdbcCommand(@"
                    INSERT INTO Tbl_Factura
                      (Cmp_IdVenta, Cmp_TipoDoc, Cmp_Documento, Cmp_Nombre, Cmp_Apellido, Cmp_Fecha, Cmp_Total)
                    VALUES
                      (?,?,?,?,?, STR_TO_DATE(?, '%Y-%m-%d'), ?);", cn))
                {
                    // orden de parámetros igual al SQL
                    cmd.Parameters.Add(new OdbcParameter("@idv", OdbcType.Int) { Value = idVenta });
                    cmd.Parameters.Add(new OdbcParameter("@td", OdbcType.VarChar, 3) { Value = tipoDoc });
                    cmd.Parameters.Add(new OdbcParameter("@doc", OdbcType.VarChar, 20) { Value = documento });
                    cmd.Parameters.Add(new OdbcParameter("@nom", OdbcType.VarChar, 60) { Value = nombre });
                    cmd.Parameters.Add(new OdbcParameter("@ape", OdbcType.VarChar, 60)
                    { Value = string.IsNullOrWhiteSpace(apellido) ? (object)DBNull.Value : apellido });

                    // se envía la fecha como cadena yyyy-MM-dd y se convierte en MySQL
                    string fechaSql = fecha.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                    cmd.Parameters.Add(new OdbcParameter("@fec", OdbcType.VarChar, 10) { Value = fechaSql });

                    // total como double por compatibilidad con algunos drivers ODBC
                    cmd.Parameters.Add(new OdbcParameter("@tot", OdbcType.Double) { Value = Convert.ToDouble(total) });

                    cmd.ExecuteNonQuery();
                }

                // devolver el id de factura generado
                using (var cmdId = new OdbcCommand("SELECT LAST_INSERT_ID();", cn))
                    return Convert.ToInt32(cmdId.ExecuteScalar());
            }
        }

        // devuelve el listado de facturas desde la vista (para el grid)
        public DataTable ListadoFacturasDT()
        {
            var dt = new DataTable();
            using (var cn = _cx.conexion())
            using (var da = new OdbcDataAdapter("SELECT * FROM Vw_ListadoFacturas;", cn))
            {
                da.Fill(dt);
            }
            return dt;
        }

        // devuelve el detalle de una venta/factura por IdVenta
        public DataTable DetalleFacturaPorVenta(int idVenta)
        {
            var dt = new DataTable();
            using (var cn = _cx.conexion())
            using (var da = new OdbcDataAdapter("SELECT * FROM Vw_Venta_Detalle WHERE Cmp_IdVenta = ?;", cn))
            {
                da.SelectCommand.Parameters.Add(new OdbcParameter("@idv", OdbcType.Int) { Value = idVenta });
                da.Fill(dt);
            }
            return dt;
        }
    }
}
