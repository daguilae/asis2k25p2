using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
namespace Capa_Modelo_GesHab
{
   public class Cls_Dao_Asignacion_Serv
    {
        Cls_conexionMYSQL conexion = new Cls_conexionMYSQL();
        public DataTable ObtenerServicios()
        {
            string query = "SELECT PK_ID_Servicio_habitacion, Cmp_Nombre_Servicio FROM tbl_servicios_habitacion;";
            OdbcConnection conn = conexion.conexion();
            DataTable tabla = new DataTable();

            try
            {
                OdbcCommand cmd = new OdbcCommand(query, conn);
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(tabla);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener servicios: " + ex.Message);
            }
            finally
            {
                conexion.desconexion(conn);
            }
            return tabla;
        }

        public DataTable ObtenerHabitaciones()
        {
            string query = "SELECT PK_ID_Habitaciones, Cmp_Descripcion_Habitacion FROM tbl_habitaciones;";
            OdbcConnection conn = conexion.conexion();
            DataTable tabla = new DataTable();

            try
            {
                OdbcCommand cmd = new OdbcCommand(query, conn);
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(tabla);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener habitaciones: " + ex.Message);
            }
            finally
            {
                conexion.desconexion(conn);
            }
            return tabla;
        }

        public bool InsertarAsignacionServ(
            int IidHabitacion,
            int IidServicio)
        {
            try
            {
                using (OdbcConnection conn = conexion.conexion())
                {
                    conn.Open();

                    string query = "INSERT INTO tbl_asignacion_habitacion_servicio " +
                                   "(Fk_ID_Habitacion, Fk_Id_Servicio) " +
                                   "VALUES (?,?)";

                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Fk_ID_Habitacion", IidHabitacion);
                        cmd.Parameters.AddWithValue("@Fk_Id_Servicio", IidServicio);

                        cmd.ExecuteNonQuery();
                    }

                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al asignar servicios: " + ex.Message);
                return false;
            }
        }
        public bool EliminarAsignacion(int idHabitacion, int idServicio)
        {
            string query = "DELETE FROM tbl_asignacion_habitacion_servicio " +
                           "WHERE Fk_ID_Habitacion = ? AND Fk_Id_Servicio = ?;";

            using (OdbcConnection conn = conexion.conexion())
            {
                try
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@hab", idHabitacion);
                        cmd.Parameters.AddWithValue("@serv", idServicio);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al eliminar asignación: {ex.Message}");
                    return false;
                }
            }
        }


        public DataTable ObtenerAsignaciones()
        {
            string query = @"
              SELECT 
                    a.Fk_ID_Habitacion AS Habitacion,
                    h.Cmp_Descripcion_Habitacion AS Descripcion,
                    a.Fk_Id_Servicio AS IdServicio,
                    s.Cmp_Nombre_Servicio AS Servicio
                FROM tbl_asignacion_habitacion_servicio a
                INNER JOIN tbl_habitaciones h ON a.Fk_ID_Habitacion = h.PK_ID_Habitaciones
                INNER JOIN tbl_servicios_habitacion s ON a.Fk_Id_Servicio = s.PK_ID_Servicio_habitacion
                ORDER BY a.Fk_ID_Habitacion;

            ";

            OdbcConnection conn = conexion.conexion();
            DataTable tabla = new DataTable();

            try
            {
                OdbcCommand cmd = new OdbcCommand(query, conn);
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(tabla);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener asignaciones: " + ex.Message);
            }
            finally
            {
                conexion.desconexion(conn);
            }

            return tabla;
        }

        public DataTable BuscarAsignaciones(int IidHabitacion)
        {
            string query = @"
        SELECT 
            a.Fk_ID_Habitacion AS Habitacion,
            h.Cmp_Descripcion_Habitacion AS Descripcion,
            a.Fk_Id_Servicio AS IdServicio,
            s.Cmp_Nombre_Servicio AS Servicio
        FROM tbl_asignacion_habitacion_servicio a
        INNER JOIN tbl_habitaciones h ON a.Fk_ID_Habitacion = h.PK_ID_Habitaciones
        INNER JOIN tbl_servicios_habitacion s ON a.Fk_Id_Servicio = s.PK_ID_Servicio_habitacion
        WHERE a.Fk_ID_Habitacion = ? 
        ORDER BY a.Fk_ID_Habitacion;
    ";

            OdbcConnection conn = conexion.conexion();
            DataTable tabla = new DataTable();

            try
            {
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    // En ODBC el orden importa, no el nombre del parámetro
                    cmd.Parameters.AddWithValue("@habitacion", IidHabitacion);

                    using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                    {
                        da.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener asignaciones: " + ex.Message);
            }
            finally
            {
                conexion.desconexion(conn);
            }

            return tabla;
        }

    }
}
