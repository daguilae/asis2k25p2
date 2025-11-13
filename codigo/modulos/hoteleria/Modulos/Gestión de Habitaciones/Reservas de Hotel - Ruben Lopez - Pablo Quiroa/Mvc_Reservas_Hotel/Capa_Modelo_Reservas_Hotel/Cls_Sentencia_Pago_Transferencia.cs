using System;
using System.Data.Odbc;

namespace Capa_Modelo_Reservas_Hotel
{
    public class Cls_Sentencia_Pago_Transferencia
    {
        private readonly Cls_Conexion gConexion = new Cls_Conexion();

        public bool InsertarDetalleTransferencia(
            int iIdPago, string sNumero, string sBanco, string sCuenta)
        {
            using (OdbcConnection conn = gConexion.conexion())
            {
                try
                {
                    string sql = @"
                        INSERT INTO Tbl_Pago_Transferencia
                        (Fk_Id_Pago, Cmp_Numero_Transferencia, Cmp_Banco_Origen, Cmp_Cuenta_Origen)
                        VALUES (?, ?, ?, ?);";

                    using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                    {
                        cmd.Parameters.Add("Fk_Id_Pago", OdbcType.Int).Value = iIdPago;
                        cmd.Parameters.Add("Cmp_Numero_Transferencia", OdbcType.VarChar, 30).Value = sNumero;
                        cmd.Parameters.Add("Cmp_Banco_Origen", OdbcType.VarChar, 50).Value = sBanco;
                        cmd.Parameters.Add("Cmp_Cuenta_Origen", OdbcType.VarChar, 50).Value = sCuenta;

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error SQL al registrar transferencia: " + ex.Message, ex);
                }
            }
        }
    }
}
