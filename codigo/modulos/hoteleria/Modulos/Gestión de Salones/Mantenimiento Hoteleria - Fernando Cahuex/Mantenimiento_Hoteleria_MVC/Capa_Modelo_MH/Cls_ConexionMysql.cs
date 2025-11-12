using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Capa_Modelo_MH
{
    class Cls_ConexionMysql
    {
        private readonly string ConexionODBC = "Dsn=bd_hoteleria"; // DSN de odbc

  
        public OdbcConnection fun_Conexion()
        {
            return new OdbcConnection(ConexionODBC);
        }
        public void desconexion(OdbcConnection conn)
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }


    }
}
