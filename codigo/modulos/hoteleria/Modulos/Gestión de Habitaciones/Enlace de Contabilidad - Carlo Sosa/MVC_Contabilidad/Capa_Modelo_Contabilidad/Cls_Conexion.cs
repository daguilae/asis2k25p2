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
    public class Cls_Conexion
    {
        private readonly string sCadena = "Dsn=bd_hoteleria";

        public OdbcConnection fun_AbrirConexion()
        {
            var c = new OdbcConnection(sCadena);
            c.Open();
            return c;
        }

        public void fun_CerrarConexion(OdbcConnection c)
        {
            if (c != null && c.State != ConnectionState.Closed)
                c.Close();
        }
    }
}

//Fin del codigo- Carlo Sosa 0901-22-1106- Fecha: 01/11/2025
