/* 
 * Programador: Richard Anthony De León Milian
 * Carné: 0901-22-10245
 * Fecha de modificación: 11/11/2025
 * Archivo: Cls_Conexion.cs
 * Descripción: Clase encargada de establecer la conexión ODBC con la base de datos "bd_nomina y parte de contabilidad".
 */

using System;
using System.Data.Odbc;

public static class Cls_Conexion
{
    // Cadena de conexión ODBC configurada en el sistema (DSN debe existir en el Administrador ODBC)
    private const string sCadena = "DSN=bd_hoteleria;";

    /// <summary>
    /// Método que abre y devuelve una conexión ODBC lista para ejecutar comandos SQL.
    /// </summary>
    /// <returns>Objeto OdbcConnection ya abierto.</returns>
    public static OdbcConnection funAbrirConexion()
    {
        try
        {
            // Se crea la conexión usando la cadena ODBC definida arriba
            var cConn = new OdbcConnection(sCadena);

            // Se intenta abrir la conexión
            cConn.Open();

            // Se retorna la conexión abierta al método que la invocó
            return cConn;
        }
        catch (OdbcException ex)
        {
            // Excepción específica de ODBC (error de DSN, credenciales, etc.)
            throw new Exception("Error al conectar con la base de datos (ODBC bd_nomina): " + ex.Message);
        }
        catch (Exception ex)
        {
            // Excepción general para cualquier otro tipo de error
            throw new Exception("Error general de conexión: " + ex.Message);
        }
    }
}
