using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Linq;

namespace Capa_Controlador_Facturas
{
    public class Cls_Controlador
    {
        private OdbcConnection Conexion()
        {
            var conn = new OdbcConnection("Dsn=Bd_hoteleria_prueba");
            try { conn.Open(); }
            catch (Exception ex) { throw new Exception("No se pudo abrir la conexión ODBC. " + ex.Message); }
            return conn;
        }
        public class Cls_LineaVenta
        {
            public string Codigo { get; set; }   
            public string Producto { get; set; }  
            public decimal Precio { get; set; }
            public int Cantidad { get; set; }
            public decimal Total { get { return Precio * Cantidad; } }
        }

        public BindingList<Cls_LineaVenta> Lineas { get; private set; } = new BindingList<Cls_LineaVenta>();

        // PRODUCTOS PARA EL COMBO
        public DataTable ObtenerProductos()
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

            using (var conn = Conexion())
            using (var da = new OdbcDataAdapter(sql, conn))
            {
                da.Fill(dt);
            }
            return dt;
        }

        // AGREGAR / ELIMINAR Fila en DataGridView
        public void AgregarLinea(string codigo, string nombre, decimal precio, int cantidad)
        {
            if (cantidad <= 0) return;

            var existente = Lineas.FirstOrDefault(l => l.Codigo == codigo);
            if (existente != null)
            {
                existente.Cantidad += cantidad;
                int idx = Lineas.IndexOf(existente);
                Lineas.ResetItem(idx);
            }
            else
            {
                Lineas.Add(new Cls_LineaVenta
                {
                    Codigo = codigo,
                    Producto = nombre,
                    Precio = precio,
                    Cantidad = cantidad
                });
            }
        }

        public void EliminarLinea(int index)
        {
            if (index >= 0 && index < Lineas.Count) Lineas.RemoveAt(index);
        }

   
        // CÁLCULOS
        public decimal CalcularTotal()
        {
            decimal t = 0m;
            for (int i = 0; i < Lineas.Count; i++) t += Lineas[i].Total;
            return t;
        }

        public decimal CalcularDevolucion(decimal efectivo, decimal total) => efectivo - total;

        // GUARDAR VENTA EN BD
        public int GuardarVenta(decimal efectivo, int idUsuario, int idMetodoPago)
        {
            if (Lineas.Count == 0) throw new Exception("No hay productos para vender.");

            decimal total = CalcularTotal();
            decimal devolucion = CalcularDevolucion(efectivo, total);

            using (var conn = Conexion())
            using (var tx = conn.BeginTransaction())
            {
                try
                {
                    // Encabezado
                    string sqlVenta = @"
                        INSERT INTO Tbl_Venta
                        (Cmp_Fecha, Cmp_Total, Cmp_Efectivo, Cmp_Devolucion, Cmp_IdUsuario, Cmp_IdMetodoPago)
                        VALUES (NOW(), ?, ?, ?, ?, ?);";

                    using (var cmd = new OdbcCommand(sqlVenta, conn, tx))
                    {
                        cmd.Parameters.AddWithValue("@p1", total);
                        cmd.Parameters.AddWithValue("@p2", efectivo);
                        cmd.Parameters.AddWithValue("@p3", devolucion);
                        cmd.Parameters.AddWithValue("@p4", idUsuario);
                        cmd.Parameters.AddWithValue("@p5", idMetodoPago);
                        cmd.ExecuteNonQuery();
                    }

                    int idVenta;
                    using (var cmdId = new OdbcCommand("SELECT LAST_INSERT_ID();", conn, tx))
                    {
                        idVenta = Convert.ToInt32(cmdId.ExecuteScalar());
                    }
                    var cacheIdProd = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

                    // Detalles
                    foreach (var l in Lineas)
                    {
                        int idProd;
                        if (!cacheIdProd.TryGetValue(l.Codigo, out idProd))
                        {
                            using (var cmdProd = new OdbcCommand(
                                "SELECT Cmp_IdProducto FROM Tbl_Producto WHERE Cmp_CodigoProducto = ?;", conn, tx))
                            {
                                cmdProd.Parameters.AddWithValue("@codigo", l.Codigo);
                                var obj = cmdProd.ExecuteScalar();
                                if (obj == null) throw new Exception("Producto no encontrado: " + l.Codigo);
                                idProd = Convert.ToInt32(obj);
                                cacheIdProd[l.Codigo] = idProd;
                            }
                        }

                        using (var cmdDet = new OdbcCommand(@"
                            INSERT INTO Tbl_VentaDet
                            (Cmp_IdVenta, Cmp_IdProducto, Cmp_Cantidad, Cmp_PrecioUnitario, Cmp_Total)
                            VALUES (?, ?, ?, ?, ?);", conn, tx))
                        {
                            cmdDet.Parameters.AddWithValue("@p1", idVenta);
                            cmdDet.Parameters.AddWithValue("@p2", idProd);
                            cmdDet.Parameters.AddWithValue("@p3", l.Cantidad);
                            cmdDet.Parameters.AddWithValue("@p4", l.Precio);
                            cmdDet.Parameters.AddWithValue("@p5", l.Total);
                            cmdDet.ExecuteNonQuery();
                        }
                    }

                    tx.Commit();
                    return idVenta;
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    throw new Exception("Error al guardar la venta: " + ex.Message);
                }
            }
        }

        public void LimpiarLineas() => Lineas.Clear();
    }
}
