using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Reservas_Hotel
{
    public class Cls_Sentencia_Pago_Transferencia
    {
        private readonly Cls_Conexion conexion = new Cls_Conexion();

        // ==================== INSERTAR ====================
        public void InsertarPagoTransferencia(int fkPago, string numeroTransferencia, string bancoOrigen, string cuentaOrigen)
        {
            string sSql = @"INSERT INTO tbl_pago_transferencia
                            (Fk_Id_Pago, Cmp_Numero_Transferencia, Cmp_Banco_Origen, Cmp_Cuenta_Origen)
                            VALUES (?, ?, ?, ?);";

            using (var conn = conexion.conexion())
            using (var cmd = new OdbcCommand(sSql, conn))
            {
                cmd.Parameters.Add(null, OdbcType.Int).Value = fkPago;
                cmd.Parameters.Add(null, OdbcType.VarChar, 30).Value = numeroTransferencia;
                cmd.Parameters.Add(null, OdbcType.VarChar, 50).Value = bancoOrigen;
                cmd.Parameters.Add(null, OdbcType.VarChar, 30).Value = cuentaOrigen;
                cmd.ExecuteNonQuery();
            }
        }

        // ==================== MODIFICAR ====================
        public void ModificarPagoTransferencia(int fkPago, string numeroTransferencia, string bancoOrigen, string cuentaOrigen)
        {
            string sSql = @"UPDATE tbl_pago_transferencia
                            SET Cmp_Numero_Transferencia = ?,
                                Cmp_Banco_Origen = ?,
                                Cmp_Cuenta_Origen = ?
                            WHERE Fk_Id_Pago = ?;";

            using (var conn = conexion.conexion())
            using (var cmd = new OdbcCommand(sSql, conn))
            {
                cmd.Parameters.Add(null, OdbcType.VarChar, 30).Value = numeroTransferencia;
                cmd.Parameters.Add(null, OdbcType.VarChar, 50).Value = bancoOrigen;
                cmd.Parameters.Add(null, OdbcType.VarChar, 30).Value = cuentaOrigen;
                cmd.Parameters.Add(null, OdbcType.Int).Value = fkPago;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
