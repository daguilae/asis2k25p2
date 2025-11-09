using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Reservas_Hotel
{
    public class Cls_Sentencia_Pago_Transferencia
    {
        private readonly Cls_Conexion conexion = new Cls_Conexion();

     
        // INSERTAR DETALLE EN TBL_PAGO_TRANSFERENCIA
       
        public bool InsertarDetalleTransferencia(int idPago, string numeroTransferencia, string bancoOrigen, string cuentaOrigen)
        {
            using (OdbcConnection conn = conexion.conexion())
            {
                try
                {
                    string sql = @"
                        INSERT INTO tbl_pago_transferencia
                        (Fk_Id_Pago, Cmp_Numero_Transferencia, Cmp_Banco_Origen, Cmp_Cuenta_Origen)
                        VALUES (?, ?, ?, ?);";

                    using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                    {
                        cmd.Parameters.Add("Fk_Id_Pago", OdbcType.Int).Value = idPago;
                        cmd.Parameters.Add("Cmp_Numero_Transferencia", OdbcType.VarChar, 30).Value = numeroTransferencia;
                        cmd.Parameters.Add("Cmp_Banco_Origen", OdbcType.VarChar, 50).Value = bancoOrigen;
                        cmd.Parameters.Add("Cmp_Cuenta_Origen", OdbcType.VarChar, 50).Value = cuentaOrigen;

                        int filas = cmd.ExecuteNonQuery();
                        return filas > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error SQL en InsertarDetalleTransferencia: " + ex.Message);
                    throw new Exception("Error al registrar el detalle del pago por transferencia: " + ex.Message, ex);
                }
            }
        }
    }
}
