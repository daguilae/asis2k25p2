using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;

namespace Capa_Modelo_MH
{
    public class Cls_Mantenimiento
    {
        Cls_ConexionMysql conexion = new Cls_ConexionMysql();

        public OdbcDataAdapter MostrarMantenimientos()
        {
            string query = "SELECT * FROM Tbl_mantenimiento;";
            OdbcConnection conn = conexion.conexion();
            OdbcDataAdapter data = new OdbcDataAdapter(query, conn);
            return data;
        }

        public void InsertarMantenimiento(string Fk_Id_Salon, string Fk_Id_Habitacion, string Fk_Id_Empleado,
                                          string Cmp_Tipo_Mantenimiento, string Cmp_Descripcion_Mantenimiento,
                                          string Cmp_Estado, string Cmp_Fecha_Inicio, string Cmp_Fecha_Fin)
        {
            string sql = "INSERT INTO Tbl_mantenimiento (Fk_Id_Salon, Fk_Id_Habitacion, Fk_Id_Empleado, " +
                         "Cmp_Tipo_Mantenimiento, Cmp_Descripcion_Mantenimiento, Cmp_Estado, Cmp_Fecha_Inicio, Cmp_Fecha_Fin) " +
                         "VALUES (?,?,?,?,?,?,?,?);";

            using (OdbcConnection conn = conexion.conexion())
            {
                conn.Open();
                using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Fk_Id_Salon", Fk_Id_Salon);
                    cmd.Parameters.AddWithValue("@Fk_Id_Habitacion", Fk_Id_Habitacion);
                    cmd.Parameters.AddWithValue("@Fk_Id_Empleado", Fk_Id_Empleado);
                    cmd.Parameters.AddWithValue("@Cmp_Tipo_Mantenimiento", Cmp_Tipo_Mantenimiento);
                    cmd.Parameters.AddWithValue("@Cmp_Descripcion_Mantenimiento", Cmp_Descripcion_Mantenimiento);
                    cmd.Parameters.AddWithValue("@Cmp_Estado", Cmp_Estado);
                    cmd.Parameters.AddWithValue("@Cmp_Fecha_Inicio", Cmp_Fecha_Inicio);
                    cmd.Parameters.AddWithValue("@Cmp_Fecha_Fin", Cmp_Fecha_Fin);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void EliminarMantenimiento(string idMantenimiento)
        {
            string sql = "DELETE FROM Tbl_mantenimiento WHERE Pk_Id_Mantenimiento = ?;";

            using (OdbcConnection conn = conexion.conexion())
            {
                conn.Open();
                using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Pk_Id_Mantenimiento", idMantenimiento);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void ActualizarMantenimiento(string idMantenimiento, string Fk_Id_Salon, string Fk_Id_Habitacion, string Fk_Id_Empleado,
                                    string Cmp_Tipo_Mantenimiento, string Cmp_Descripcion_Mantenimiento,
                                    string Cmp_Estado, string Cmp_Fecha_Inicio, string Cmp_Fecha_Fin)
        {
            string sql = "UPDATE Tbl_mantenimiento SET " +
                         "Fk_Id_Salon = ?, Fk_Id_Habitacion = ?, Fk_Id_Empleado = ?, " +
                         "Cmp_Tipo_Mantenimiento = ?, Cmp_Descripcion_Mantenimiento = ?, " +
                         "Cmp_Estado = ?, Cmp_Fecha_Inicio = ?, Cmp_Fecha_Fin = ? " +
                         "WHERE Pk_Id_Mantenimiento = ?;";

            using (OdbcConnection conn = conexion.conexion())
            {
                conn.Open();
                using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Fk_Id_Salon", Fk_Id_Salon);
                    cmd.Parameters.AddWithValue("@Fk_Id_Habitacion", Fk_Id_Habitacion);
                    cmd.Parameters.AddWithValue("@Fk_Id_Empleado", Fk_Id_Empleado);
                    cmd.Parameters.AddWithValue("@Cmp_Tipo_Mantenimiento", Cmp_Tipo_Mantenimiento);
                    cmd.Parameters.AddWithValue("@Cmp_Descripcion_Mantenimiento", Cmp_Descripcion_Mantenimiento);
                    cmd.Parameters.AddWithValue("@Cmp_Estado", Cmp_Estado);
                    cmd.Parameters.AddWithValue("@Cmp_Fecha_Inicio", Cmp_Fecha_Inicio);
                    cmd.Parameters.AddWithValue("@Cmp_Fecha_Fin", Cmp_Fecha_Fin);
                    cmd.Parameters.AddWithValue("@Pk_Id_Mantenimiento", idMantenimiento);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable BuscarMantenimientoPorId(string idMantenimiento)
        {
            string sql = "SELECT * FROM Tbl_mantenimiento WHERE Pk_Id_Mantenimiento = ?;";
            OdbcConnection conn = conexion.conexion();
            OdbcCommand cmd = new OdbcCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Pk_Id_Mantenimiento", idMantenimiento);

            OdbcDataAdapter adapter = new OdbcDataAdapter(cmd);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            return tabla;
        }


    }
}