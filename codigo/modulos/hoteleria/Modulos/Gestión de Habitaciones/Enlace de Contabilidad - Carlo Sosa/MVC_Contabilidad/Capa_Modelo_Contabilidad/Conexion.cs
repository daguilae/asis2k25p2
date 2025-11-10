// Carlo Sosa
// 0901-22-1106
// Fecha: 01/11/2025
// Descripción: Conexión ODBC a HoteleriaDB
// Carlo Sosa 0901-22-1106 2025-11-01
using System.Data;
using System.Data.Odbc;

//inicio del codigo- Carlo Sosa 0901-22-1106- Fecha: 01/11/2025

namespace Capa_Modelo_Contabilidad
{
    public class Conexion
    {
        private string Cadena => "Dsn=bd_hoteleria";

        public OdbcConnection Abrir()
        {
            var c = new OdbcConnection(Cadena);
            c.Open();
            return c;
        }

        public void Cerrar(OdbcConnection c)
        {
            if (c != null && c.State != ConnectionState.Closed)
            {
                c.Close();
            }
        }
    }
}


//Fin del codigo- Carlo Sosa 0901-22-1106- Fecha: 01/11/2025
