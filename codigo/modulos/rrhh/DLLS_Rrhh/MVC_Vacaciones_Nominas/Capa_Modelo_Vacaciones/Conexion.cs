using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Vacaciones
{
    public class Conexion
    {
        private OdbcConnection conexion;

        public OdbcConnection ConexionDB()
        {
            try
            {
                // Nombre EXACTO del DSN configurado en el administrador ODBC (32 bits)
                // Verifica que sea exactamente igual: "bd_hoteleria"
                string dsn = "DSN=bd_hoteleria;";

                conexion = new OdbcConnection(dsn);
                conexion.Open();
            }
            catch (Exception ex)
            {
                // Puedes cambiar el mensaje si deseas
                throw new Exception("Error al conectar a la base de datos ODBC: " + ex.Message, ex);
            }

            return conexion;
        }

        public void CerrarConexion()
        {
            try
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cerrar conexión: " + ex.Message);
            }
        }
    }
}