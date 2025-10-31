using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;


namespace Capa_Modelo_Facturas
{
    public class Cls_Sentencias
    {
        private readonly Cls_Conexion cn = new Cls_Conexion();

        // 1) Productos para el Combo
        public DataTable ObtenerProductosDT()
        {
            var dt = new DataTable();
            string sql = @"
                SELECT 
                  P.Cmp_IdProducto,
                  P.Cmp_CodigoProducto,
                  P.Cmp_NombreProducto,
                  P.Cmp_PrecioUnitario
                FROM Vw_ProductoBasico P
                ORDER BY P.Cmp_NombreProducto;";
            using (OdbcConnection conn = cn.conexion())
            using (OdbcDataAdapter da = new OdbcDataAdapter(sql, conn))
            {
                da.Fill(dt);
            }
            return dt;
        }

        // 2) Guardar venta completa en una transacción
        public int GuardarVentaConDetalles(
            decimal total, decimal efectivo, decimal devolucion,
            int idUsuario, int idMetodoPago,
            IList<LineaVentaDTO> lineas)
        {
            if (lineas == null || lineas.Count == 0) throw new ArgumentException("No hay líneas para guardar.");

            using (OdbcConnection conn = cn.conexion())
            using (OdbcTransaction tx = conn.BeginTransaction())
            {
                try
                {
                    // Insertar encabezado
                    int idVenta;
                    using (var cmd = new OdbcCommand(
                        @"INSERT INTO Tbl_Venta (Cmp_Fecha, Cmp_Total, Cmp_Efectivo, Cmp_Devolucion, Cmp_IdUsuario, Cmp_IdMetodoPago)
                          VALUES (NOW(), ?, ?, ?, ?, ?);", conn, tx))
                    {
                        // ODBC usa placeholders "?" en orden
                        cmd.Parameters.AddWithValue("@p1", total);
                        cmd.Parameters.AddWithValue("@p2", efectivo);
                        cmd.Parameters.AddWithValue("@p3", devolucion);
                        cmd.Parameters.AddWithValue("@p4", idUsuario);
                        cmd.Parameters.AddWithValue("@p5", idMetodoPago);
                        cmd.ExecuteNonQuery();
                    }
                    using (var cmdId = new OdbcCommand("SELECT LAST_INSERT_ID();", conn, tx))
                    {
                        idVenta = Convert.ToInt32(cmdId.ExecuteScalar());
                    }

                    // Cache ids de producto por código para no consultar repetido
                    var cacheIdProducto = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

                    foreach (var l in lineas)
                    {
                        if (l.Cantidad <= 0) continue;

                        int idProd;
                        if (!cacheIdProducto.TryGetValue(l.CodigoProducto, out idProd))
                        {
                            using (var cmdProd = new OdbcCommand(
                                "SELECT Cmp_IdProducto FROM Tbl_Producto WHERE Cmp_CodigoProducto = ?;", conn, tx))
                            {
                                cmdProd.Parameters.AddWithValue("@pCodigo", l.CodigoProducto);
                                var obj = cmdProd.ExecuteScalar();
                                if (obj == null) throw new Exception("Producto no encontrado: " + l.CodigoProducto);
                                idProd = Convert.ToInt32(obj);
                                cacheIdProducto[l.CodigoProducto] = idProd;
                            }
                        }

                        using (var cmdDet = new OdbcCommand(
                            @"INSERT INTO Tbl_VentaDet
                              (Cmp_IdVenta, Cmp_IdProducto, Cmp_Cantidad, Cmp_PrecioUnitario, Cmp_Total)
                              VALUES (?,?,?,?,?);", conn, tx))
                        {
                            cmdDet.Parameters.AddWithValue("@p1", idVenta);
                            cmdDet.Parameters.AddWithValue("@p2", idProd);
                            cmdDet.Parameters.AddWithValue("@p3", l.Cantidad);
                            cmdDet.Parameters.AddWithValue("@p4", l.PrecioUnitario);
                            cmdDet.Parameters.AddWithValue("@p5", l.TotalLinea);
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

        //recibe líneas desde Controlador
        public class LineaVentaDTO
        {
            public string CodigoProducto { get; set; }   
            public decimal PrecioUnitario { get; set; }
            public int Cantidad { get; set; }
            public decimal TotalLinea { get { return PrecioUnitario * Cantidad; } }
        }
    }
}