using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Capa_Modelo_TipoDeCambio
{
    public class Cls_Conexion
    {
        public OdbcConnection Conexion()
        {
            OdbcConnection odConn = new OdbcConnection("Dsn=bd_hoteleria");
            try
            {
                odConn.Open();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No conectó a la base de datos.");
            }
            return odConn;
        }

        public void Desconexion(OdbcConnection odConn)
        {
            try
            {
                if (odConn != null)
                    odConn.Close();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No se pudo cerrar la conexión.");
            }
        }
    }
}
