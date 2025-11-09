// Nombre: Jose Pablo Medina González
// Carné: 0901-22-2592
// Fecha de modificación: 2025-11-09
// Descripción: Conexión ODBC vía DSN (MySQL ODBC 8.0 ANSI 32-bit) a bd_nomina.

using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Vacaciones
{
    public class Conexion
    {
        private OdbcConnection _conexion;

        /// <summary>Abre y devuelve una conexión ODBC usando el DSN del sistema.</summary>
        public OdbcConnection ConexionDB()
        {
            try
            {
                // Debe existir como DSN de sistema (32-bit, ANSI)
                string dsn = "DSN=bd_hoteleria;";
                _conexion = new OdbcConnection(dsn);
                _conexion.Open();
                return _conexion;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al conectar a la base de datos ODBC: " + ex.Message, ex);
            }
        }

        /// <summary>Cierra la conexión si está abierta.</summary>
        public void CerrarConexion()
        {
            try
            {
                if (_conexion != null && _conexion.State == ConnectionState.Open)
                    _conexion.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cerrar conexión: " + ex.Message);
            }
        }
    }
}