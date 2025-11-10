using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Facturas

        // Juan Carlos Sandoval Quej 0901-22-4170 09/11/2025
{
    public class Cls_Sentencias
    {
        private readonly Cls_Conexion _cx = new Cls_Conexion();

        // 1) Productos para el combo
        public DataTable ObtenerProductosDT()
        {
            var dt = new DataTable();
            const string sql = @"
                SELECT 
                  p.Cmp_Id_Producto,
                  p.Cmp_Codigo_Producto,
                  p.Cmp_Nombre_Producto,
                  p.Cmp_PrecioUnitario
                FROM Vw_ProductoActivos p
                ORDER BY p.Cmp_Nombre_Producto;";

            using (var cn = _cx.conexion())
            using (var da = new OdbcDataAdapter(sql, cn))
            {
                da.Fill(dt);
            }
            return dt;
        }

        // DTO para recibir líneas
        public class LineaVentaDTO
        {
            public string CodigoProducto { get; set; }
            public decimal PrecioUnitario { get; set; }
            public int Cantidad { get; set; }
            public decimal TotalLinea => PrecioUnitario * Cantidad;
        }

        // 2) Guardar VENTA + DETALLES (transacción)
       
        public int GuardarVentaConDetalles(
            decimal total, decimal efectivo, decimal devolucion,
            int? idUsuario, int? idMetodoPago,
            IList<LineaVentaDTO> lineas)
        {
            if (lineas == null || lineas.Count == 0)
                throw new ArgumentException("No hay líneas para guardar.");

            using (var cn = _cx.conexion())
            using (var tx = cn.BeginTransaction())
            {
                try
                {
                    // Encabezado Venta
                    using (var cmd = new OdbcCommand(@"
                        INSERT INTO Tbl_Venta
                          (Cmp_Total, Cmp_Efectivo, Cmp_Devolucion, Cmp_Id_Usuario, Cmp_Id_Metodo_Pago)
                        VALUES (?,?,?,?,?);", cn, tx))
                    {
                        cmd.Parameters.Add(new OdbcParameter("@tot", OdbcType.Decimal) { Value = total });
                        cmd.Parameters.Add(new OdbcParameter("@efe", OdbcType.Decimal) { Value = efectivo });
                        cmd.Parameters.Add(new OdbcParameter("@dev", OdbcType.Decimal) { Value = devolucion });
                        cmd.Parameters.Add(new OdbcParameter("@usr", OdbcType.Int) { Value = (object)idUsuario ?? DBNull.Value });
                        cmd.Parameters.Add(new OdbcParameter("@mp", OdbcType.Int) { Value = (object)idMetodoPago ?? DBNull.Value });
                        cmd.ExecuteNonQuery();
                    }

                    int idVenta;
                    using (var cmdId = new OdbcCommand("SELECT LAST_INSERT_ID();", cn, tx))
                        idVenta = Convert.ToInt32(cmdId.ExecuteScalar());

                    // Cache de Id_Producto por código
                    var cache = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

                    foreach (var l in lineas)
                    {
                        if (l.Cantidad <= 0) continue;

                        int idProd;
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

                        using (var cmdDet = new OdbcCommand(@"
                            INSERT INTO Tbl_VentaDet
                              (Cmp_IdVenta, Cmp_Id_Producto, Cmp_Cantidad, Cmp_PrecioUnitario, Cmp_Total)
                            VALUES (?,?,?,?,?);", cn, tx))
                        {
                            cmdDet.Parameters.Add(new OdbcParameter("@v", OdbcType.Int) { Value = idVenta });
                            cmdDet.Parameters.Add(new OdbcParameter("@p", OdbcType.Int) { Value = idProd });
                            cmdDet.Parameters.Add(new OdbcParameter("@c", OdbcType.Decimal) { Value = l.Cantidad });
                            cmdDet.Parameters.Add(new OdbcParameter("@pu", OdbcType.Decimal) { Value = l.PrecioUnitario });
                            cmdDet.Parameters.Add(new OdbcParameter("@st", OdbcType.Decimal) { Value = l.TotalLinea });
                            cmdDet.ExecuteNonQuery();
                        }
                    }

                    tx.Commit();
                    return idVenta;
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
            }
        }

     
        // 3) Guardar FACTURA (encabezado) — ligado a una venta
     
        public int GuardarFactura(
    int idVenta,
    string tipoDoc,      // "CF" o "NIT"
    string documento,    // "CF" o el NIT
    string nombre,
    string apellido,
    DateTime fecha,
    decimal total)
        {
            using (var cn = _cx.conexion())
            {
                using (var cmd = new OdbcCommand(@"
            INSERT INTO Tbl_Factura
              (Cmp_IdVenta, Cmp_TipoDoc, Cmp_Documento, Cmp_Nombre, Cmp_Apellido, Cmp_Fecha, Cmp_Total)
            VALUES (?,?,?,?,?,?,?);", cn))
                {
                    // IMPORTANTE: ODBC ignora los nombres y usa el ORDEN. Declara tipo y tamaño.
                    cmd.Parameters.Add(new OdbcParameter("@idv", OdbcType.Int) { Value = idVenta });
                    cmd.Parameters.Add(new OdbcParameter("@td", OdbcType.VarChar, 3) { Value = tipoDoc });       // CF / NIT
                    cmd.Parameters.Add(new OdbcParameter("@doc", OdbcType.VarChar, 20) { Value = documento });     // "CF" si CF
                    cmd.Parameters.Add(new OdbcParameter("@nom", OdbcType.VarChar, 60) { Value = nombre });
                    cmd.Parameters.Add(new OdbcParameter("@ape", OdbcType.VarChar, 60)
                    {
                        Value = string.IsNullOrWhiteSpace(apellido) ? (object)DBNull.Value : apellido
                    });
                    cmd.Parameters.Add(new OdbcParameter("@fec", OdbcType.DateTime) { Value = fecha });
                    cmd.Parameters.Add(new OdbcParameter("@tot", OdbcType.Decimal) { Value = total });

                    cmd.ExecuteNonQuery();
                }

                using (var cmdId = new OdbcCommand("SELECT LAST_INSERT_ID();", cn))
                {
                    var obj = cmdId.ExecuteScalar();
                    return Convert.ToInt32(obj);
                }
            }
        }


        // 4) Listado de facturas (vista: Vw_ListadoFacturas)
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

  
        // 5) Detalle por venta 
   
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
