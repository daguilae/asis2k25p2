using System;
using System.Data.Odbc;

namespace Capa_Modelo_Reservas_Hotel
{
    public class Cls_Sentencia_Pago_Efectivo
    {
        private readonly Cls_Conexion gConexion = new Cls_Conexion();

        public bool InsertarDetalleEfectivo(int iIdPago, string sRecibo, string sObs)
        {
            using (OdbcConnection conn = gConexion.conexion())
            {
                try
                {
                    string sSql = @"
                        INSERT INTO Tbl_Pago_Efectivo
                        (Fk_Id_Pago, Cmp_Numero_Recibo, Cmp_Observaciones)
                        VALUES (?, ?, ?);";

                    using (OdbcCommand cmd = new OdbcCommand(sSql, conn))
                    {
                        cmd.Parameters.Add("Fk_Id_Pago", OdbcType.Int).Value = iIdPago;
                        cmd.Parameters.Add("Cmp_Numero_Recibo", OdbcType.VarChar, 30).Value = sRecibo;
                        cmd.Parameters.Add("Cmp_Observaciones", OdbcType.VarChar, 200).Value = sObs ?? string.Empty;

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al registrar el detalle del pago en efectivo: " + ex.Message, ex);
                }
            }
        }
    }
}
