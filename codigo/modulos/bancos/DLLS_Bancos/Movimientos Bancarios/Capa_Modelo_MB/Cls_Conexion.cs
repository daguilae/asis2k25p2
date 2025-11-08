using System;
using System.Data.Odbc;

namespace Capa_Modelo_MB
{
    public class Cls_Conexion
    {
        public OdbcConnection fun_conexion_bd()
        {
            OdbcConnection odcn_Conn = new OdbcConnection("Dsn=Bd_Hoteleria");
            try
            {
                odcn_Conn.Open();
                Console.WriteLine("Conexión exitosa.");
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("Error al conectar: " + ex.Message);
            }
            return odcn_Conn;
        }

        public void pro_desconexion(OdbcConnection odcn_Conn)
        {
            try
            {
                odcn_Conn.Close();
                Console.WriteLine("Conexión cerrada.");
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("Error al cerrar la conexión: " + ex.Message);
            }
        }
    }
}
