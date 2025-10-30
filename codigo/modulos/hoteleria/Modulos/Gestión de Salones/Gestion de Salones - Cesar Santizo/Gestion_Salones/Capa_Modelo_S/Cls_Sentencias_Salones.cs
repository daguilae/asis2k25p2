using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_S
{
    public class Cls_Sentencias_Salones
    {
        // ==========================
        // MÉTODOS DE CREACIÓN
        // ==========================
        public void InsertarSalon(string nombre, string ubicacion, int capacidad, int disponibilidad)
        {
            Cls_Conexion_Hoteleria cn = new Cls_Conexion_Hoteleria();
            using (OdbcConnection con = cn.conexion())
            {
                string sql = "INSERT INTO Tbl_Salones (Cmp_Nombre_Salon, Cmp_Ubicacion, Cmp_Capacidad, Cmp_Disponibilidad) VALUES (?,?,?,?)";
                OdbcCommand cmd = new OdbcCommand(sql, con);
                cmd.Parameters.AddWithValue("", nombre);
                cmd.Parameters.AddWithValue("", ubicacion);
                cmd.Parameters.AddWithValue("", capacidad);
                cmd.Parameters.AddWithValue("", disponibilidad);
                cmd.ExecuteNonQuery();
            }
        }

        // ==========================
        // MÉTODOS DE MODIFICACIÓN
        // ==========================

        public int VerificarSalon(string sNombreSalon)
        {
            Cls_Conexion_Hoteleria cn = new Cls_Conexion_Hoteleria();

            using (OdbcConnection con = cn.conexion())
            {
                string sql = "SELECT COUNT(*) FROM Tbl_Salones WHERE Cmp_Nombre_Salon = ?";
                OdbcCommand cmd = new OdbcCommand(sql, con);
                cmd.Parameters.AddWithValue("", sNombreSalon);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count;
            }
        }
        public void ModificarSalon(int id, string nombre, string ubicacion, int capacidad, int disponibilidad)
        {
            Cls_Conexion_Hoteleria cn = new Cls_Conexion_Hoteleria();
            using (OdbcConnection con = cn.conexion())
            {
                string sql = "UPDATE Tbl_Salones SET Cmp_Nombre_Salon=?, Cmp_Ubicacion=?, Cmp_Capacidad=?, Cmp_Disponibilidad=? WHERE Pk_Id_Salon=?";
                OdbcCommand cmd = new OdbcCommand(sql, con);
                cmd.Parameters.AddWithValue("", nombre);
                cmd.Parameters.AddWithValue("", ubicacion);
                cmd.Parameters.AddWithValue("", capacidad);
                cmd.Parameters.AddWithValue("", disponibilidad);
                cmd.Parameters.AddWithValue("", id);
                cmd.ExecuteNonQuery();
            }
        }

        // ==========================
        // MÉTODOS DE ELIMINACIÓN
        // ==========================
        public void EliminarSalon(int id)
        {
            Cls_Conexion_Hoteleria cn = new Cls_Conexion_Hoteleria();
            using (OdbcConnection con = cn.conexion())
            {
                string sql = "DELETE FROM Tbl_Salones WHERE Pk_Id_Salon=?";
                OdbcCommand cmd = new OdbcCommand(sql, con);
                cmd.Parameters.AddWithValue("", id);
                cmd.ExecuteNonQuery();
            }
        }

        // ==========================
        // MÉTODOS DE CONSULTA
        // ==========================
        public DataTable ObtenerSalones()
        {
            DataTable tabla = new DataTable();
            Cls_Conexion_Hoteleria cn = new Cls_Conexion_Hoteleria();
            using (OdbcConnection con = cn.conexion())
            {
                string sql = "SELECT * FROM Tbl_Salones";
                OdbcDataAdapter da = new OdbcDataAdapter(sql, con);
                da.Fill(tabla);
            }
            return tabla;
        }

        // ==========================
        // MÉTODOS DE VERIFICACIÓN
        // ==========================
        
    }
}
