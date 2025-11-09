using System;
using System.Data.Odbc;

namespace Capa_Modelo_Percepciones_Nomina
{
    public class Conexion
    {
        private OdbcConnection conexion;

        public OdbcConnection conexionDB()
        {
            try
            {
                // Nombre del DSN configurado en el ODBC
                string dsn = "DSN=bd_hoteleria";
                conexion = new OdbcConnection(dsn);
                conexion.Open();
                Console.WriteLine("Conexión exitosa a la base de datos.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
            }

            return conexion;
        }

        public void cerrarConexion()
        {
            try
            {
                if (conexion != null)
                {
                    conexion.Close();
                    Console.WriteLine("Conexión cerrada correctamente.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cerrar conexión: " + ex.Message);
            }
        }
    }
}
