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

        // --- Obtener servicios disponibles ---
        public DataTable fun_ObtenerServicios()
        {
            string sQuery = "SELECT PK_ID_Servicio_habitacion, Cmp_Nombre_Servicio FROM Tbl_Servicios_habitacion;";
            OdbcConnection conn = conexion.conexion();
            DataTable tabla = new DataTable();

            try
            {
                OdbcCommand cmd = new OdbcCommand(sQuery, conn);
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

        // --- Obtener habitaciones ---
        public DataTable fun_ObtenerHabitaciones()
        {
            string sQuery = "SELECT PK_ID_Habitaciones, Cmp_Descripcion_Habitacion FROM Tbl_Habitaciones;";
            OdbcConnection conn = conexion.conexion();
            DataTable tabla = new DataTable();

            try
            {
                OdbcCommand cmd = new OdbcCommand(sQuery, conn);
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

        // --- Insertar asignación habitación-servicio ---
        public bool pro_InsertarAsignacionServ(int IidHabitacion, int IidServicio)
        {
            try
            {
                using (OdbcConnection conn = conexion.conexion())
                {
                    conn.Open();

                    string sQuery = "INSERT INTO Tbl_Asignacion_habitacion_Servicio " +
                                   "(Fk_ID_Habitacion, Fk_Id_Servicio) " +
                                   "VALUES (?,?)";

                    using (OdbcCommand cmd = new OdbcCommand(sQuery, conn))
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
                Console.WriteLine("Error al asignar servicio: " + ex.Message);
                return false;
            }
        }

        // --- Eliminar asignación habitación-servicio ---
        public bool pro_EliminarAsignacion(int IidHabitacion, int IidServicio)
        {
            string sQuery = "DELETE FROM Tbl_Asignacion_habitacion_Servicio " +
                           "WHERE Fk_ID_Habitacion = ? AND Fk_Id_Servicio = ?;";

            using (OdbcConnection conn = conexion.conexion())
            {
                try
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    using (OdbcCommand cmd = new OdbcCommand(sQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Fk_ID_Habitacion", IidHabitacion);
                        cmd.Parameters.AddWithValue("@Fk_Id_Servicio", IidServicio);

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

        // --- Obtener todas las asignaciones ---
        public DataTable fun_ObtenerAsignaciones()
        {
            string sQuery = @"
                SELECT 
                    a.Fk_ID_Habitacion AS Habitacion,
                    h.Cmp_Descripcion_Habitacion AS Descripcion,
                    a.Fk_Id_Servicio AS IdServicio,
                    s.Cmp_Nombre_Servicio AS Servicio
                FROM Tbl_Asignacion_habitacion_Servicio a
                INNER JOIN Tbl_Habitaciones h ON a.Fk_ID_Habitacion = h.PK_ID_Habitaciones
                INNER JOIN Tbl_Servicios_habitacion s ON a.Fk_Id_Servicio = s.PK_ID_Servicio_habitacion
                ORDER BY a.Fk_ID_Habitacion;
            ";

            OdbcConnection conn = conexion.conexion();
            DataTable tabla = new DataTable();

            try
            {
                OdbcCommand cmd = new OdbcCommand(sQuery, conn);
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

        // --- Buscar asignaciones por habitación ---
        public DataTable fun_BuscarAsignaciones(int IidHabitacion)
        {
            string sQuery = @"
                SELECT 
                    a.Fk_ID_Habitacion AS Habitacion,
                    h.Cmp_Descripcion_Habitacion AS Descripcion,
                    a.Fk_Id_Servicio AS IdServicio,
                    s.Cmp_Nombre_Servicio AS Servicio
                FROM Tbl_Asignacion_habitacion_Servicio a
                INNER JOIN Tbl_Habitaciones h ON a.Fk_ID_Habitacion = h.PK_ID_Habitaciones
                INNER JOIN Tbl_Servicios_habitacion s ON a.Fk_Id_Servicio = s.PK_ID_Servicio_habitacion
                WHERE a.Fk_ID_Habitacion = ? 
                ORDER BY a.Fk_ID_Habitacion;
            ";

            OdbcConnection conn = conexion.conexion();
            DataTable tabla = new DataTable();

            try
            {
                using (OdbcCommand cmd = new OdbcCommand(sQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Fk_ID_Habitacion", IidHabitacion);

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
