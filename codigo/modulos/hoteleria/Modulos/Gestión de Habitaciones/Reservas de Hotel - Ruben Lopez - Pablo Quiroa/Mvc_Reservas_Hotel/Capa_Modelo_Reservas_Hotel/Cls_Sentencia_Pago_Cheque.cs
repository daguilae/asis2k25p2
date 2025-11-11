using System;
using System.Data.Odbc;

namespace Capa_Modelo_Reservas_Hotel
{
    public class Cls_Sentencia_Pago_Cheque
    {
        private readonly Cls_Conexion gConexion = new Cls_Conexion();

        public bool InsertarDetalleCheque(
            int iIdPago,
            string sNumCheque,
            string sBanco,
            string sTitular,
            string sEstado,
            DateTime dEmision,
            DateTime dCobro)
        {
            using (OdbcConnection conn = gConexion.conexion())
            {
                try
                {
                    string sSql = @"
                        INSERT INTO Tbl_Pago_Cheque
                        (Fk_Id_Pago, Cmp_Numero_Cheque, Cmp_Banco_Emisor, 
                         Cmp_Nombre_Titular, Cmp_Estado_Cheque, 
                         Cmp_Fecha_Emision, Cmp_Fecha_Cobro)
                        VALUES (?, ?, ?, ?, ?, ?, ?);";

                    using (OdbcCommand cmd = new OdbcCommand(sSql, conn))
                    {
                        cmd.Parameters.Add("Fk_Id_Pago", OdbcType.Int).Value = iIdPago;
                        cmd.Parameters.Add("Cmp_Numero_Cheque", OdbcType.VarChar, 20).Value = sNumCheque;
                        cmd.Parameters.Add("Cmp_Banco_Emisor", OdbcType.VarChar, 50).Value = sBanco;
                        cmd.Parameters.Add("Cmp_Nombre_Titular", OdbcType.VarChar, 50).Value = sTitular;
                        cmd.Parameters.Add("Cmp_Estado_Cheque", OdbcType.VarChar, 20).Value = sEstado;
                        cmd.Parameters.Add("Cmp_Fecha_Emision", OdbcType.Date).Value = dEmision;
                        cmd.Parameters.Add("Cmp_Fecha_Cobro", OdbcType.Date).Value = dCobro;

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al registrar pago con cheque: " + ex.Message, ex);
                }
            }
        }
    }
}
