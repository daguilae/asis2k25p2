using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace CapaModeloOP
{
    public class Cls_Sentencias_OP
    {
        public void InsertarOP(DateTime fecha_solicitud, DateTime fecha_registro)
        {
            Cls_Conexion_OP cn = new Cls_Conexion_OP();
            using (OdbcConnection con = cn.conexion())
            {
                string sql = "INSERT INTO Tbl_Ordenes_Produccion (Cmp_Fecha_Solicitud, Cmp_Fecha_Registro) VALUES (?, ?)";

                using (OdbcCommand cmd = new OdbcCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@fecha_solicitud", fecha_solicitud);
                    cmd.Parameters.AddWithValue("@fecha_registro", fecha_registro);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ACTUALIZAR
        public void EditarOP(int id, DateTime fecha_solicitud, DateTime fecha_registro)
        {
            Cls_Conexion_OP cn = new Cls_Conexion_OP();
            using (OdbcConnection con = cn.conexion())
            {
                string sql = "UPDATE Tbl_Ordenes_Produccion SET Cmp_Fecha_Solicitud=?, Cmp_Fecha_Registro=? WHERE Pk_Id_Orden_Produccion=?";

                using (OdbcCommand cmd = new OdbcCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@fecha_solicitud", fecha_solicitud);
                    cmd.Parameters.AddWithValue("@fecha_registro", fecha_registro);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ELIMINAR
        public void EliminarOP(int id)
        {
            Cls_Conexion_OP cn = new Cls_Conexion_OP();
            using (OdbcConnection con = cn.conexion())
            {
                string sql = "DELETE FROM Tbl_Ordenes_Produccion WHERE Pk_Id_Orden_Produccion=?";

                using (OdbcCommand cmd = new OdbcCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // CONSULTAR
        public DataTable CargarOrdenesProduccion()
        {
            Cls_Conexion_OP cn = new Cls_Conexion_OP();
            DataTable tabla = new DataTable();

            using (OdbcConnection con = cn.conexion())
            {
                string sql = "SELECT * FROM Tbl_Ordenes_Produccion";
                using (OdbcDataAdapter da = new OdbcDataAdapter(sql, con))
                {
                    da.Fill(tabla);
                }
            }
            return tabla;
        }




    }
}
