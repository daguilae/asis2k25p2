using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Reservas_Hotel
{
    public class Cls_Sentencia_Pago_Efectivo
    {
        private readonly Cls_Conexion conexion = new Cls_Conexion();

        // ==================== INSERTAR ====================
        public void InsertarPagoEfectivo(int fkPago, string numeroRecibo, string observaciones)
        {
            string sSql = @"INSERT INTO tbl_pago_efectivo 
                            (Fk_Id_Pago, Cmp_Numero_Recibo, Cmp_Observaciones)
                            VALUES (?, ?, ?);";

            using (var conn = conexion.conexion())
            using (var cmd = new OdbcCommand(sSql, conn))
            {
                cmd.Parameters.Add(null, OdbcType.Int).Value = fkPago;
                cmd.Parameters.Add(null, OdbcType.VarChar, 20).Value = numeroRecibo;
                cmd.Parameters.Add(null, OdbcType.VarChar, 100).Value = observaciones ?? string.Empty;
                cmd.ExecuteNonQuery();
            }
        }

        // ==================== MODIFICAR ====================
        public void ModificarPagoEfectivo(int fkPago, string numeroRecibo, string observaciones)
        {
            string sSql = @"UPDATE tbl_pago_efectivo
                            SET Cmp_Numero_Recibo = ?, 
                                Cmp_Observaciones = ?
                            WHERE Fk_Id_Pago = ?;";

            using (var conn = conexion.conexion())
            using (var cmd = new OdbcCommand(sSql, conn))
            {
                cmd.Parameters.Add(null, OdbcType.VarChar, 20).Value = numeroRecibo;
                cmd.Parameters.Add(null, OdbcType.VarChar, 100).Value = observaciones ?? string.Empty;
                cmd.Parameters.Add(null, OdbcType.Int).Value = fkPago;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
