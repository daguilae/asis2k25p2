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
      
        public void InsertarSalon(string sNombre, string sUbicacion, int iCapacidad, int iDisponibilidad)
        {
            Cls_Conexion_Hoteleria cConexion = new Cls_Conexion_Hoteleria();
            using (OdbcConnection cConexionODBC = cConexion.conexion())
            {
                string sSql = "INSERT INTO Tbl_Salones (Cmp_Nombre_Salon, Cmp_Ubicacion, Cmp_Capacidad, Cmp_Disponibilidad) VALUES (?,?,?,?)";
                OdbcCommand cCmd = new OdbcCommand(sSql, cConexionODBC);
                cCmd.Parameters.AddWithValue("", sNombre);
                cCmd.Parameters.AddWithValue("", sUbicacion);
                cCmd.Parameters.AddWithValue("", iCapacidad);
                cCmd.Parameters.AddWithValue("", iDisponibilidad);
                cCmd.ExecuteNonQuery();
            }
        }

           public int VerificarSalon(string sNombreSalon)
        {
            Cls_Conexion_Hoteleria cConexion = new Cls_Conexion_Hoteleria();

            using (OdbcConnection cConexionODBC = cConexion.conexion())
            {
                string sSql = "SELECT COUNT(*) FROM Tbl_Salones WHERE Cmp_Nombre_Salon = ?";
                OdbcCommand cCmd = new OdbcCommand(sSql, cConexionODBC);
                cCmd.Parameters.AddWithValue("", sNombreSalon);

                int iCount = Convert.ToInt32(cCmd.ExecuteScalar());
                return iCount;
            }
        }

        public void ModificarSalon(int iId, string sNombre, string sUbicacion, int iCapacidad, int iDisponibilidad)
        {
            Cls_Conexion_Hoteleria cConexion = new Cls_Conexion_Hoteleria();
            using (OdbcConnection cConexionODBC = cConexion.conexion())
            {
                string sSql = "UPDATE Tbl_Salones SET Cmp_Nombre_Salon=?, Cmp_Ubicacion=?, Cmp_Capacidad=?, Cmp_Disponibilidad=? WHERE Pk_Id_Salon=?";
                OdbcCommand cCmd = new OdbcCommand(sSql, cConexionODBC);
                cCmd.Parameters.AddWithValue("", sNombre);
                cCmd.Parameters.AddWithValue("", sUbicacion);
                cCmd.Parameters.AddWithValue("", iCapacidad);
                cCmd.Parameters.AddWithValue("", iDisponibilidad);
                cCmd.Parameters.AddWithValue("", iId);
                cCmd.ExecuteNonQuery();
            }
        }

     
        public void EliminarSalon(int iId)
        {
            Cls_Conexion_Hoteleria cConexion = new Cls_Conexion_Hoteleria();
            using (OdbcConnection cConexionODBC = cConexion.conexion())
            {
                string sSql = "DELETE FROM Tbl_Salones WHERE Pk_Id_Salon=?";
                OdbcCommand cCmd = new OdbcCommand(sSql, cConexionODBC);
                cCmd.Parameters.AddWithValue("", iId);
                cCmd.ExecuteNonQuery();
            }
        }

        public DataTable ObtenerSalones()
        {
            DataTable dTabla = new DataTable();
            Cls_Conexion_Hoteleria cConexion = new Cls_Conexion_Hoteleria();
            using (OdbcConnection cConexionODBC = cConexion.conexion())
            {
                string sSql = "SELECT * FROM Tbl_Salones";
                OdbcDataAdapter cAdapter = new OdbcDataAdapter(sSql, cConexionODBC);
                cAdapter.Fill(dTabla);
            }
            return dTabla;
        }

    

    }
}
