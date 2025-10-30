using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Ordenes
{
    public class Cls_Sentencias_Ordenes
    {
        Cls_Conexion_Ordenes con = new Cls_Conexion_Ordenes();


        public OdbcDataAdapter LlenarTbl(string tabla)
        {
            string sql = "SELECT * FROM " + tabla + ";";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }


        public bool AgregarAutorizacion(
    int idAutorizacion, int idOrden, int idBanco, string fecha, string autorizadoPor, decimal monto, int estado)
        {
            try
            {
                OdbcConnection conn = con.conexion();

                string sql = "INSERT INTO Tbl_Orden_Compra_Autorizada " +
                             "(Pk_Id_Autorizacion, Fk_Id_Orden_Compra, Fk_Id_Banco, Cmp_Fecha_Autorizacion, Cmp_Autorizado_Por, Cmp_Monto_Autorizado, Fk_Id_Estado_Autorizacion) " +
                             "VALUES (?, ?, ?, ?, ?, ?, ?)";

                OdbcCommand cmd = new OdbcCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Pk_Id_Autorizacion", idAutorizacion);
                cmd.Parameters.AddWithValue("@Fk_Id_Orden_Compra", idOrden);
                cmd.Parameters.AddWithValue("@Fk_Id_Banco", idBanco);
                cmd.Parameters.AddWithValue("@Cmp_Fecha_Autorizacion", fecha);
                cmd.Parameters.AddWithValue("@Cmp_Autorizado_Por", autorizadoPor);
                cmd.Parameters.AddWithValue("@Cmp_Monto_Autorizado", monto);
                cmd.Parameters.AddWithValue("@Fk_Id_Estado_Autorizacion", estado);

                int filas = cmd.ExecuteNonQuery(); 

                con.desconexion(conn);

                return filas > 0; 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar autorización: " + ex.Message);
                return false;
            }
        }



    }
}
