using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
// CARLO ANDREE BARQUERO BOCHE 0901-22-601  29-11-2025
namespace Capa_Modelo_Anticipos_Nomina
{
    public class Cls_Conexion_Anticipos_Nomina
    {
        private readonly string ConexionODBC = "Dsn=bd_hoteleria"; 

        //retorna conexion cerrada para que el DAO la abra y cierre cuando sea necesario
        public OdbcConnection conexion()
        {
            return new OdbcConnection(ConexionODBC); // crea una nueva conexión
        }

        // Cierra la conexión si está abierta
        public void desconexion(OdbcConnection conn)
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }

    }
}
