using System;
using System.Data;
using System.Data.Odbc;

//Inicio del codigo - Carlo Sosa 0901-22-1106 - Fecha: 01/11/2025
namespace Capa_Modelo_Contabilidad
{
    public class Cls_EstadiaDao
    {
        private readonly Cls_Conexion gCnn = new Cls_Conexion();

        public DataTable fun_ObtenerEstadiasPorRango(DateTime dInicio, DateTime dFin)
        {
            var dt = new DataTable();

            using (var c = gCnn.fun_AbrirConexion())
            {
                const string sSql = @"
                    SELECT Cmp_Monto_Total_Pago
                    FROM Tbl_Estadia
                    WHERE Cmp_Fecha_Check_In BETWEEN ? AND ?;";

                using (var cmd = new OdbcCommand(sSql, c))
                {
                    cmd.Parameters.Add("p1", OdbcType.Date).Value = dInicio.Date;
                    cmd.Parameters.Add("p2", OdbcType.Date).Value = dFin.Date;

                    using (var da = new OdbcDataAdapter(cmd))
                        da.Fill(dt);
                }
            }

            return dt;
        }
    }
}
//Final del codigo - Carlo Sosa 0901-22-1106 - Fecha: 01/11/2025




