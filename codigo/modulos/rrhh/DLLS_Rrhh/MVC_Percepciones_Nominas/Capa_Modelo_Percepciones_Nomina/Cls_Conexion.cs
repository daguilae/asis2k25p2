/* 
 * Programador: Richard Anthony De León Milian
 * Carné: 0901-22-10245
 * Fecha de modificación: 8/11/2025
 * Archivo: Cls_Conexion.cs
 * Descripción: COnexión a la base de datos de nómina
 */
using System;
using System.Data.Odbc;

namespace Capa_Modelo_Percepciones_Nomina
{
    public class Cls_Conexion
    {
        private OdbcConnection conexion;

        public OdbcConnection conexionDB()
        {
            try
            {
                // Nombre del DSN configurado en el ODBC
                string dsn = "DSN=bd_nomina";
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
