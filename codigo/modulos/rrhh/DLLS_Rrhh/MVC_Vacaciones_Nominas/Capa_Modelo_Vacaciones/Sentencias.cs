using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Vacaciones
{
    public class Sentencias
    {
        private readonly Conexion con = new Conexion();

        // Obtener vacaciones por empleado
        public DataTable ObtenerVacaciones(int idEmpleado)
        {
            var dt = new DataTable();
            const string query = @"
                SELECT  Cmp_iId_Vacacion,
                        Cmp_iId_Empleado,
                        Cmp_dFechaInicio_Vacacion,
                        Cmp_dFechaFin_Vacacion,
                        Cmp_iDias_Vacacion,
                        Cmp_bAprobada_Vacacion
                FROM tbl_vacaciones
                WHERE Cmp_iId_Empleado = ?;";

            try
            {
                using (var conexion = con.ConexionDB())
                using (var cmd = new OdbcCommand(query, conexion))
                using (var da = new OdbcDataAdapter(cmd))
                {
                    cmd.Parameters.Add(new OdbcParameter { OdbcType = OdbcType.Int, Value = idEmpleado });
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ObtenerVacaciones: " + ex.Message);
            }
            return dt;
        }

        // Insertar nueva solicitud
        public bool InsertarSolicitud(int idEmpleado, DateTime fechaInicio, DateTime fechaFin, int dias)
        {
            const string query = @"
                INSERT INTO tbl_vacaciones
                    (Cmp_iId_Empleado, Cmp_dFechaInicio_Vacacion, Cmp_dFechaFin_Vacacion, Cmp_iDias_Vacacion, Cmp_bAprobada_Vacacion)
                VALUES
                    (?, ?, ?, ?, 0);";

            try
            {
                using (var conexion = con.ConexionDB())
                using (var cmd = new OdbcCommand(query, conexion))
                {
                    cmd.Parameters.Add(new OdbcParameter { OdbcType = OdbcType.Int, Value = idEmpleado });
                    cmd.Parameters.Add(new OdbcParameter { OdbcType = OdbcType.DateTime, Value = fechaInicio });
                    cmd.Parameters.Add(new OdbcParameter { OdbcType = OdbcType.DateTime, Value = fechaFin });
                    cmd.Parameters.Add(new OdbcParameter { OdbcType = OdbcType.Int, Value = dias });

                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar: " + ex.Message);
                return false;
            }
        }

        // Actualizar vacación
        public bool ActualizarVacacion(int idVacacion, DateTime fechaInicio, DateTime fechaFin, int dias)
        {
            const string query = @"
                UPDATE tbl_vacaciones
                SET Cmp_dFechaInicio_Vacacion = ?, 
                    Cmp_dFechaFin_Vacacion   = ?, 
                    Cmp_iDias_Vacacion       = ?
                WHERE Cmp_iId_Vacacion     = ?;";

            try
            {
                using (var conexion = con.ConexionDB())
                using (var cmd = new OdbcCommand(query, conexion))
                {
                    cmd.Parameters.Add(new OdbcParameter { OdbcType = OdbcType.DateTime, Value = fechaInicio });
                    cmd.Parameters.Add(new OdbcParameter { OdbcType = OdbcType.DateTime, Value = fechaFin });
                    cmd.Parameters.Add(new OdbcParameter { OdbcType = OdbcType.Int, Value = dias });
                    cmd.Parameters.Add(new OdbcParameter { OdbcType = OdbcType.Int, Value = idVacacion });

                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar: " + ex.Message);
                return false;
            }
        }

        // Obtener una vacación por ID
        public DataRow ObtenerVacacionPorId(int idVacacion)
        {
            var dt = new DataTable();
            const string query = "SELECT * FROM tbl_vacaciones WHERE Cmp_iId_Vacacion = ?;";

            try
            {
                using (var conexion = con.ConexionDB())
                using (var cmd = new OdbcCommand(query, conexion))
                using (var da = new OdbcDataAdapter(cmd))
                {
                    cmd.Parameters.Add(new OdbcParameter { OdbcType = OdbcType.Int, Value = idVacacion });
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener vacación: " + ex.Message);
            }

            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        // Eliminar vacación
        public bool EliminarVacacion(int idVacacion)
        {
            const string query = "DELETE FROM tbl_vacaciones WHERE Cmp_iId_Vacacion = ?;";

            try
            {
                using (var conexion = con.ConexionDB())
                using (var cmd = new OdbcCommand(query, conexion))
                {
                    cmd.Parameters.Add(new OdbcParameter { OdbcType = OdbcType.Int, Value = idVacacion });
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar: " + ex.Message);
                return false;
            }
        }
    }
}