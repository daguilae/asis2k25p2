using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Reservas_Hotel
{
    public class Cls_Sentencia_Pago_Tarjeta
    {
        private readonly Cls_Conexion conexion = new Cls_Conexion();

        // ==================== INSERTAR ====================
        public void InsertarPagoTarjeta(int fkPago, string nombreTitular, string numeroTarjeta, DateTime fechaVencimiento, int cvc, int codigoPostal)
        {
            string sSql = @"INSERT INTO tbl_pago_tarjeta 
                            (Fk_Id_Pago, Cmp_Nombre_Titular, Cmp_Numero_Tarjeta, Cmp_Fecha_Vencimiento, Cmp_CVC, Cmp_Codigo_Postal)
                            VALUES (?, ?, ?, ?, ?, ?);";

            using (var conn = conexion.conexion())
            using (var cmd = new OdbcCommand(sSql, conn))
            {
                cmd.Parameters.Add(null, OdbcType.Int).Value = fkPago;
                cmd.Parameters.Add(null, OdbcType.VarChar, 50).Value = nombreTitular;
                cmd.Parameters.Add(null, OdbcType.VarChar, 20).Value = numeroTarjeta;
                cmd.Parameters.Add(null, OdbcType.Date).Value = fechaVencimiento;
                cmd.Parameters.Add(null, OdbcType.Int).Value = cvc;
                cmd.Parameters.Add(null, OdbcType.Int).Value = codigoPostal;
                cmd.ExecuteNonQuery();
            }
        }

        // ==================== MODIFICAR ====================
        public void ModificarPagoTarjeta(int fkPago, string nombreTitular, string numeroTarjeta, DateTime fechaVencimiento, int cvc, int codigoPostal)
        {
            string sSql = @"UPDATE tbl_pago_tarjeta
                            SET Cmp_Nombre_Titular = ?, 
                                Cmp_Numero_Tarjeta = ?, 
                                Cmp_Fecha_Vencimiento = ?, 
                                Cmp_CVC = ?, 
                                Cmp_Codigo_Postal = ?
                            WHERE Fk_Id_Pago = ?;";

            using (var conn = conexion.conexion())
            using (var cmd = new OdbcCommand(sSql, conn))
            {
                cmd.Parameters.Add(null, OdbcType.VarChar, 50).Value = nombreTitular;
                cmd.Parameters.Add(null, OdbcType.VarChar, 20).Value = numeroTarjeta;
                cmd.Parameters.Add(null, OdbcType.Date).Value = fechaVencimiento;
                cmd.Parameters.Add(null, OdbcType.Int).Value = cvc;
                cmd.Parameters.Add(null, OdbcType.Int).Value = codigoPostal;
                cmd.Parameters.Add(null, OdbcType.Int).Value = fkPago;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
