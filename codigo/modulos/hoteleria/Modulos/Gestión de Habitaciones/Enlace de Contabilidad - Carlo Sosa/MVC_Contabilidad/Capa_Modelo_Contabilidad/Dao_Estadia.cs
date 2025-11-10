using System;
using System.Data;
using System.Data.Odbc;
//inicio del codigo- Carlo Sosa 0901-22-1106- Fecha: 01/11/2025

namespace Capa_Modelo_Contabilidad
{
    public class Dao_Estadia
    {
        Conexion cConexion = new Conexion();

        public DataTable ObtenerEstadiasPorRango(DateTime fechaInicio, DateTime fechaFin)
        {
            DataTable dt = new DataTable();
            using (OdbcConnection conn = cConexion.Abrir())
            {
                string query = "SELECT Cmp_Monto_Total_Pago FROM Tbl_Estadia WHERE Cmp_Fecha_Check_In BETWEEN ? AND ?";
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    cmd.Parameters.Add("p1", OdbcType.Date).Value = fechaInicio;
                    cmd.Parameters.Add("p2", OdbcType.Date).Value = fechaFin;
                    using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }
    }
}

//Fin del codigo- Carlo Sosa 0901-22-1106- Fecha: 01/11/2025



