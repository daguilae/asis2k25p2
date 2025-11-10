// Nombre: Diego Andre Monterroso Rabarique
// Carné: 0901-22-1369
// Fecha de modificación: 2025-11-09
// Descripción: Lógica de negocio para CRUD de Horas_Extras.
using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_HorasExtra
{
    public class Sentencia
    {
        Conexion cn = new Conexion();

        // =============================
        // MOSTRAR HORAS EXTRA
        // =============================
        public DataTable ObtenerHorasExtra()
        {
            string query = @"
                SELECT 
                    he.Cmp_iId_HoraExtra AS IdHoraExtra,
                    CONCAT(e.Cmp_sNombre_Empleado, ' ', e.Cmp_sApellido_Empleado) AS Empleado,
                    DATE_FORMAT(he.Cmp_dFecha_HoraExtra, '%d/%m/%Y') AS Fecha,
                    he.Cmp_iCantidad_HoraExtra AS Horas,
                    he.Cmp_sMotivo_HoraExtra AS Motivo,
                    CASE 
                        WHEN he.Cmp_bAprobado_HoraExtra = 1 THEN 'Aprobado'
                        ELSE 'No aprobado'
                    END AS Estado
                FROM Tbl_HorasExtra he
                INNER JOIN Tbl_Empleados e 
                    ON he.Cmp_iId_Empleado = e.Cmp_iId_Empleado
                ORDER BY he.Cmp_dFecha_HoraExtra DESC;";

            using (OdbcDataAdapter da = new OdbcDataAdapter(query, cn.ConexionDB()))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // =============================
        // BUSCAR POR EMPLEADO
        // =============================
        public DataTable BuscarPorEmpleado(string nombre)
        {
            string query = @"
                SELECT 
                    he.Cmp_iId_HoraExtra AS IdHoraExtra,
                    CONCAT(e.Cmp_sNombre_Empleado, ' ', e.Cmp_sApellido_Empleado) AS Empleado,
                    DATE_FORMAT(he.Cmp_dFecha_HoraExtra, '%d/%m/%Y') AS Fecha,
                    he.Cmp_iCantidad_HoraExtra AS Horas,
                    he.Cmp_sMotivo_HoraExtra AS Motivo,
                    CASE 
                        WHEN he.Cmp_bAprobado_HoraExtra = 1 THEN 'Aprobado'
                        ELSE 'No aprobado'
                    END AS Estado
                FROM Tbl_HorasExtra he
                INNER JOIN Tbl_Empleados e ON he.Cmp_iId_Empleado = e.Cmp_iId_Empleado
                WHERE CONCAT(e.Cmp_sNombre_Empleado, ' ', e.Cmp_sApellido_Empleado) LIKE ?
                ORDER BY he.Cmp_dFecha_HoraExtra DESC";

            using (OdbcCommand cmd = new OdbcCommand(query, cn.ConexionDB()))
            {
                cmd.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // =============================
        // OBTENER EMPLEADOS ACTIVOS
        // =============================
        public DataTable ObtenerEmpleados()
        {
            string query = @"
                SELECT 
                    Cmp_iId_Empleado AS IdEmpleado,
                    CONCAT(Cmp_sNombre_Empleado, ' ', Cmp_sApellido_Empleado) AS NombreEmpleado
                FROM Tbl_Empleados
                WHERE Cmp_bEstado_Empleado = 1
                ORDER BY Cmp_sNombre_Empleado";

            OdbcDataAdapter da = new OdbcDataAdapter(query, cn.ConexionDB());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // =============================
        // INSERTAR HORA EXTRA
        // =============================
        public void InsertarHoraExtra(int idEmpleado, DateTime fecha, int horas, string motivo, bool aprobado)
        {
            string query = @"
                INSERT INTO Tbl_HorasExtra 
                (Cmp_iId_Empleado, Cmp_dFecha_HoraExtra, Cmp_iCantidad_HoraExtra, Cmp_sMotivo_HoraExtra, Cmp_bAprobado_HoraExtra)
                VALUES (?, ?, ?, ?, ?)";

            using (OdbcCommand cmd = new OdbcCommand(query, cn.ConexionDB()))
            {
                cmd.Parameters.AddWithValue("?", idEmpleado);
                cmd.Parameters.AddWithValue("?", fecha);
                cmd.Parameters.AddWithValue("?", horas);
                cmd.Parameters.AddWithValue("?", motivo ?? (object)DBNull.Value);
                cmd.Parameters.Add("?", OdbcType.Bit).Value = aprobado; // ✅ CORREGIDO
                cmd.ExecuteNonQuery();
            }
        }

        // =============================
        // MODIFICAR HORA EXTRA
        // =============================
        public void ModificarHoraExtra(int id, int idEmpleado, DateTime fecha, int horas, string motivo, bool aprobado)
        {
            string query = @"
                UPDATE Tbl_HorasExtra SET
                    Cmp_iId_Empleado = ?,
                    Cmp_dFecha_HoraExtra = ?,
                    Cmp_iCantidad_HoraExtra = ?,
                    Cmp_sMotivo_HoraExtra = ?,
                    Cmp_bAprobado_HoraExtra = ?
                WHERE Cmp_iId_HoraExtra = ?";

            using (OdbcCommand cmd = new OdbcCommand(query, cn.ConexionDB()))
            {
                cmd.Parameters.AddWithValue("?", idEmpleado);
                cmd.Parameters.AddWithValue("?", fecha);
                cmd.Parameters.AddWithValue("?", horas);
                cmd.Parameters.AddWithValue("?", motivo ?? (object)DBNull.Value);
                cmd.Parameters.Add("?", OdbcType.Bit).Value = aprobado; // ✅ CORREGIDO
                cmd.Parameters.AddWithValue("?", id);
                cmd.ExecuteNonQuery();
            }
        }

        // =============================
        // ELIMINAR HORA EXTRA
        // =============================
        public void EliminarHoraExtra(int id)
        {
            string query = "DELETE FROM Tbl_HorasExtra WHERE Cmp_iId_HoraExtra = ?";
            using (OdbcCommand cmd = new OdbcCommand(query, cn.ConexionDB()))
            {
                cmd.Parameters.AddWithValue("?", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}