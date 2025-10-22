using System;
using System.Data.Odbc;

namespace Capa_Modelo_MB
{
    public class Conexion
    {
        public OdbcConnection ConexionBD()
        {
            OdbcConnection conn = new OdbcConnection("Dsn=bd_hoteleria");
            try
            {
                conn.Open();
                Console.WriteLine("Conexión exitosa.");
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("Error al conectar: " + ex.Message);
            }
            return conn;
        }

        public void Desconexion(OdbcConnection conn)
        {
            try
            {
                conn.Close();
                Console.WriteLine("Conexión cerrada.");
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("Error al cerrar la conexión: " + ex.Message);
            }
        }
    }
}

