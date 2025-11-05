using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
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

        //id de estadia
        public DataTable ObtenerIdsEstadia()
        {
            DataTable dt = new DataTable();
            string query = "SELECT Pk_Id_Estadia FROM Tbl_Estadia;";

            try
            {
                using (OdbcConnection conn = conexion.conexion())
                {
                    conn.Open();
                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los IDs de estadía: " + ex.Message);
            }

            return dt;
        }

        // --- Obtener IDs de habitaciones ---
        public DataTable ObtenerHabitaciones()
        {
            DataTable dt = new DataTable();
            string query = "SELECT PK_ID_Habitaciones FROM Tbl_Habitaciones WHERE Cmp_Estado_Habitacion = 1 ;"; // 0 = disponible
            try
            {
                using (OdbcConnection conn = conexion.conexion())
                {
                    conn.Open();
                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener habitaciones: " + ex.Message);
            }
            return dt;
        }

        // --- Obtener IDs y nombres de huéspedes ---
        public DataTable ObtenerHuespedes()
        {
            DataTable dt = new DataTable();
            string query = "SELECT Pk_Id_Huesped, CONCAT(Cmp_Nombre, ' ', Cmp_Apellido) AS NombreCompleto FROM Tbl_Huesped;";
            try
            {
                using (OdbcConnection conn = conexion.conexion())
                {
                    conn.Open();
                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener huéspedes: " + ex.Message);
            }
            return dt;
        }

        public double ObtenerTarifaPorNoche(int idHabitacion)
        {
            double tarifa = 0.0;
            string query = "SELECT Cmp_Tarifa_Noche FROM Tbl_Habitaciones WHERE PK_ID_Habitaciones = ?;";

            try
            {
                using (OdbcConnection conn = conexion.conexion())
                {
                    conn.Open();
                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idHabitacion);

                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            tarifa = Convert.ToDouble(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener tarifa por noche: " + ex.Message);
            }

            return tarifa;
        }

        public int ObtenerCapacidadHabitacion(int idHabitacion)
        {
            int capacidad = 0;
            string query = "SELECT Cmp_Capacidad_Habitacion FROM Tbl_Habitaciones WHERE PK_ID_Habitaciones = ?;";

            try
            {
                using (OdbcConnection conn = conexion.conexion())
                {
                    conn.Open();
                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idHabitacion);

                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            capacidad = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener capacidad de habitación: " + ex.Message);
            }

            return capacidad;
        }

        public DataTable ObtenerEstadiaPorId(int idEstadia)
        {
            DataTable dt = new DataTable();
            string query = @"
        SELECT 
            E.Pk_Id_Estadia,
            E.Fk_Id_Habitaciones,
            E.Fk_Id_Huesped_Checkin,
            E.Cmp_Num_Huespedes,
            E.Cmp_Tiene_Reservacion,
            E.Cmp_Fecha_Check_In,
            E.Cmp_Fecha_Check_Out,
            E.Cmp_Monto_Total_Pago
        FROM Tbl_Estadia E
        WHERE E.Pk_Id_Estadia = ?;";

            try
            {
                using (OdbcConnection conn = conexion.conexion())
                {
                    conn.Open();
                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idEstadia);
                        using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener estadía: " + ex.Message);
            }

            return dt;
        }


    }
}
