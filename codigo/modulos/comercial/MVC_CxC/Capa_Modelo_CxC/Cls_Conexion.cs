using System;
using System.Data.Odbc;

namespace Capa_Modelo_CxC
{
    public class Cls_Conexion
    {
        private readonly string _dsn = "bd_hoteleria"; 

        public OdbcConnection conexion()
        {
            try
            {
                string cadena = "DSN=" + _dsn + ";";
                OdbcConnection conn = new OdbcConnection(cadena);
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al conectar con el ODBC '" + _dsn + "': " + ex.Message);
            }
        }
    }
}
