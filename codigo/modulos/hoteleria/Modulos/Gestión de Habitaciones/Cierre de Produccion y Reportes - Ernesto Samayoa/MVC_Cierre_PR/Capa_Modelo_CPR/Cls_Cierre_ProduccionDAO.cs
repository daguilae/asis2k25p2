using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_CPR
{
    public class Cls_Cierre_ProduccionDAO
    {
        private readonly Cls_Conexion conexion = new Cls_Conexion();

        // ---------------------------
        // TOTAL INGRESOS x FECHA
        // ---------------------------
        public decimal ObtenerTotalIngresos(DateTime fecha)
        {
            decimal total = 0m;
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                // Nota:
                // - Pagos: Cmp_Monto_Total por Cmp_Fecha_Pago, estado Pagado
                // - Reservas Salones: Cmp_Monto_Total por Cmp_Fecha_Reserva
                // - Pedidos Menu: Cantidad * Precio, fecha de la reserva de salón
                // - Room Service: Cmp_Monto_Total por Cmp_Fecha_Orden
                // - Servicios Adicionales: sum(Cmp_Costo) enlazando a Tbl_Reserva para tomar la fecha (aquí uso Cmp_Fecha_Entrada)
                string query = @"
                    SELECT
                        COALESCE( (SELECT SUM(p.Cmp_Monto_Total)
                                   FROM Tbl_Pago p
                                   WHERE DATE(p.Cmp_Fecha_Pago) = ? AND p.Cmp_Estado_Pago = 'Pagado'), 0)
                      + COALESCE( (SELECT SUM(rs.Cmp_Monto_Total)
                                   FROM Tbl_Reservas_Salones rs
                                   WHERE DATE(rs.Cmp_Fecha_Reserva) = ?), 0)
                      + COALESCE( (SELECT SUM(pm.Cmp_Cantidad_Platillos * m.Cmp_Precio)
                                   FROM Tbl_Pedidos_Menu pm
                                   INNER JOIN Tbl_Menu m ON m.Pk_Id_Menu = pm.Fk_Id_Menu
                                   INNER JOIN Tbl_Reservas_Salones rsv ON rsv.Pk_Id_Reserva_Salon = pm.Fk_Id_Reserva_Salon
                                   WHERE DATE(rsv.Cmp_Fecha_Reserva) = ?), 0)
                      + COALESCE( (SELECT SUM(r.Cmp_Monto_Total)
                                   FROM Tbl_Room_Service r
                                   WHERE DATE(r.Cmp_Fecha_Orden) = ?), 0)
                      + COALESCE( (SELECT SUM(sa.Cmp_Costo)
                                   FROM Tbl_Servicio_Adicional sa
                                   INNER JOIN Tbl_Reserva re ON re.Pk_Id_Reserva = sa.Pk_Id_Reserva
                                   WHERE DATE(re.Cmp_Fecha_Entrada) = ?), 0)
                    AS TotalIngresos;";

                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    // Importante: el orden de los ? debe coincidir 1:1
                    cmd.Parameters.AddWithValue("@f1", fecha.Date);
                    cmd.Parameters.AddWithValue("@f2", fecha.Date);
                    cmd.Parameters.AddWithValue("@f3", fecha.Date);
                    cmd.Parameters.AddWithValue("@f4", fecha.Date);
                    cmd.Parameters.AddWithValue("@f5", fecha.Date);

                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                        total = Convert.ToDecimal(result);
                }
            }
            return total;
        }

        // ---------------------------
        // TOTAL EGRESOS x FECHA
        // ---------------------------
        public decimal ObtenerTotalEgresos(DateTime fecha)
        {
            decimal total = 0m;
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string query = @"
                    SELECT COALESCE(SUM(a.Cmp_Monto), 0)
                    FROM Tbl_Area a
                    WHERE a.Cmp_Tipo_Movimiento = 'Egreso'
                      AND DATE(a.Cmp_Fecha_Movimiento) = ?;";

                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@f", fecha.Date);
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                        total = Convert.ToDecimal(result);
                }
            }
            return total;
        }

        // ---------------------------
        // OBTENER SIGUIENTE ID (PK no autoincremental)
        // ---------------------------
        private int ObtenerSiguienteIdCierre(OdbcConnection conn)
        {
            using (var cmd = new OdbcCommand("SELECT COALESCE(MAX(Pk_Id_Cierre), 0) + 1 FROM Tbl_Cierre_Produccion;", conn))
            {
                object result = cmd.ExecuteScalar();
                return Convert.ToInt32(result);
            }
        }

        // ---------------------------
        // INSERTAR CIERRE
        // ---------------------------
        public bool InsertarCierre(DateTime fecha, string descripcion, int tipoCierre,
                                   decimal ingresos, decimal egresos, decimal totalCierre)
        {
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                // Si NO cambias tu tabla a AUTO_INCREMENT, generamos el ID manualmente:
                int nuevoId = ObtenerSiguienteIdCierre(conn);

                string query = @"
                    INSERT INTO Tbl_Cierre_Produccion
                        (Pk_Id_Cierre, Cmp_Fecha_Cierre, Cmp_Total_Ingresos, Cmp_Total_Egresos,
                         Cmp_Cierre_Total, Cmp_Descripcion_Cierre, Fk_Id_Tipo_Cierre)
                    VALUES (?, ?, ?, ?, ?, ?, ?);";

                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", nuevoId);
                    cmd.Parameters.AddWithValue("@fecha", fecha);
                    cmd.Parameters.AddWithValue("@ing", ingresos);
                    cmd.Parameters.AddWithValue("@egr", egresos);
                    cmd.Parameters.AddWithValue("@tot", totalCierre);
                    cmd.Parameters.AddWithValue("@desc", descripcion ?? "");
                    cmd.Parameters.AddWithValue("@tipo", tipoCierre);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // ---------------------------
        // TIPOS DE CIERRE (ComboBox)
        // ---------------------------
        public DataTable ObtenerTiposCierre()
        {
            DataTable tabla = new DataTable();
            using (OdbcConnection conn = conexion.AbrirConexion())
            using (OdbcDataAdapter da = new OdbcDataAdapter(
                "SELECT PK_Id_Tipo_Cierre, Cmp_Tipo_Cierre FROM Tbl_Tipo_Cierre;", conn))
            {
                da.Fill(tabla);
            }
            return tabla;
        }

        public bool EliminarCierre(DateTime fecha)
        {
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string query = "DELETE FROM Tbl_Cierre_Produccion WHERE DATE(Cmp_Fecha_Cierre) = ?;";

                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@fecha", fecha.Date);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
