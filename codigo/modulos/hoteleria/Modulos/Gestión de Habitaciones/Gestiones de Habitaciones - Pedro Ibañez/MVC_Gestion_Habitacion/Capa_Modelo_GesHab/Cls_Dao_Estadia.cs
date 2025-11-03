using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
namespace Capa_Modelo_GesHab
{
    public class Cls_Dao_Estadia
    {
        Cls_conexionMYSQL conexion = new Cls_conexionMYSQL();
        public bool InsertarEstadia(
            int idHabitacion,
            int idHuesped,
            int numHuespedes,
            bool tieneReserva,
            DateTime fechaCheckIn,
            DateTime fechaActual,
            decimal montoTotal)
        {
            try
            {
                using (OdbcConnection conn = conexion.conexion())
                {
                    conn.Open();

                    string query = "INSERT INTO tbl_estadia " +
                                   "(FK_ID_Habitaciones, Fk_Id_Huesped_Checkin, Cmp_Num_Huespedes, " +
                                   "Cmp_Fecha_Check_In, Cmp_Fecha_Check_Out, Cmp_Tiene_Reservacion, Cmp_Monto_Total_Pago) " +
                                   "VALUES (?,?,?,?,?,?,?)";

                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FK_ID_Habitaciones", idHabitacion);
                        cmd.Parameters.AddWithValue("@Fk_Id_Huesped_Checkin", idHuesped);
                        cmd.Parameters.AddWithValue("@Cmp_Num_Huespedes", numHuespedes);
                        cmd.Parameters.AddWithValue("@Cmp_Fecha_Check_In", fechaCheckIn);
                        cmd.Parameters.AddWithValue("@Cmp_Fecha_Check_Out", fechaActual);
                        cmd.Parameters.AddWithValue("@Cmp_Tiene_Reservacion", tieneReserva ? 1 : 0);
                        cmd.Parameters.AddWithValue("@Cmp_Monto_Total_Pago", montoTotal);

                        cmd.ExecuteNonQuery();
                    }

                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar estadía: " + ex.Message);
                return false;
            }
        }

        public bool EliminarEstadia(int idEstadia)
        {
            try
            {
                using (OdbcConnection conn = conexion.conexion())
                {
                    conn.Open();

                    string query = "DELETE FROM tbl_estadia WHERE PK_ID_Estadia = ?";

                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PK_ID_Estadia", idEstadia);
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        conn.Close();

                        // Devuelve true solo si se eliminó algo
                        return filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar estadía: " + ex.Message);
                return false;
            }
        }


        public bool ModificarEstadia(
    int idEstadia,
    int idHabitacion,
    int idHuesped,
    int numHuespedes,
    bool tieneReserva,
    DateTime fechaCheckIn,
    DateTime fechaActual,
    decimal montoTotal)
        {
            try
            {
                using (OdbcConnection conn = conexion.conexion())
                {
                    conn.Open();

                    string query = "UPDATE tbl_estadia SET " +
                                   "FK_ID_Habitaciones = ?, " +
                                   "Fk_Id_Huesped_Checkin = ?, " +
                                   "Cmp_Num_Huespedes = ?, " +
                                   "Cmp_Fecha_Check_In = ?, " +
                                   "Cmp_Fecha_Check_Out = ?, " +
                                   "Cmp_Tiene_Reservacion = ?, " +
                                   "Cmp_Monto_Total_Pago = ? " +
                                   "WHERE PK_ID_Estadia = ?";

                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FK_ID_Habitaciones", idHabitacion);
                        cmd.Parameters.AddWithValue("@Fk_Id_Huesped_Checkin", idHuesped);
                        cmd.Parameters.AddWithValue("@Cmp_Num_Huespedes", numHuespedes);
                        cmd.Parameters.AddWithValue("@Cmp_Fecha_Check_In", fechaCheckIn);
                        cmd.Parameters.AddWithValue("@Cmp_Fecha_Check_Out", fechaActual);
                        cmd.Parameters.AddWithValue("@Cmp_Tiene_Reservacion", tieneReserva ? 1 : 0);
                        cmd.Parameters.AddWithValue("@Cmp_Monto_Total_Pago", montoTotal);
                        cmd.Parameters.AddWithValue("@PK_ID_Estadia", idEstadia);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        conn.Close();

                        return filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al modificar estadía: " + ex.Message);
                return false;
            }
        }

    }
}
