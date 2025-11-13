using System;
using System.Data.Odbc;

namespace Capa_Modelo_Check_In_Check_Out
{
    public class Cls_Conexion
    {

        public string ObtenerCadenaConexion()
        {
            return "Dsn=bd_hoteleria";
        }

        public OdbcConnection conexion()
        {
            OdbcConnection conn = new OdbcConnection(ObtenerCadenaConexion());
            try
            {
                conn.Open();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No Conectó");
            }
            return conn;
        }

      
        public OdbcConnection AbrirConexion()
        {
            OdbcConnection conn = new OdbcConnection(ObtenerCadenaConexion());
            conn.Open();
            return conn;
        }


        public void desconexion(OdbcConnection conn)
        {
            try
            {
                conn.Close();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No se pudo cerrar la conexión");
            }
        }
    }
}
