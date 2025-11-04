using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Reservas_Hotel
{
    public class Cls_Sentencia_Pago_Cheque
    {
        private readonly Cls_Conexion conexion = new Cls_Conexion();

        // ==================== INSERTAR ====================
        public void InsertarPagoCheque(int fkPago, string numeroCheque, string bancoEmisor,
                                       string nombreTitular, DateTime fechaEmision,
                                       DateTime fechaCobro, string estadoCheque)
        {
            string sSql = @"INSERT INTO tbl_pago_cheque
                            (Fk_Id_Pago, Cmp_Numero_Cheque, Cmp_Banco_Emisor,
                             Cmp_Nombre_Titular, Cmp_Fecha_Emision,
                             Cmp_Fecha_Cobro, Cmp_Estado_Cheque)
                            VALUES (?, ?, ?, ?, ?, ?, ?);";

            using (var conn = conexion.conexion())
            using (var cmd = new OdbcCommand(sSql, conn))
            {
                cmd.Parameters.Add(null, OdbcType.Int).Value = fkPago;
                cmd.Parameters.Add(null, OdbcType.VarChar, 30).Value = numeroCheque;
                cmd.Parameters.Add(null, OdbcType.VarChar, 50).Value = bancoEmisor;
                cmd.Parameters.Add(null, OdbcType.VarChar, 50).Value = nombreTitular;
                cmd.Parameters.Add(null, OdbcType.Date).Value = fechaEmision;
                cmd.Parameters.Add(null, OdbcType.Date).Value = fechaCobro;
                cmd.Parameters.Add(null, OdbcType.VarChar, 20).Value = estadoCheque;
                cmd.ExecuteNonQuery();
            }
        }

        // ==================== MODIFICAR ====================
        public void ModificarPagoCheque(int fkPago, string numeroCheque, string bancoEmisor,
                                        string nombreTitular, DateTime fechaEmision,
                                        DateTime fechaCobro, string estadoCheque)
        {
            string sSql = @"UPDATE tbl_pago_cheque
                            SET Cmp_Numero_Cheque = ?,
                                Cmp_Banco_Emisor = ?,
                                Cmp_Nombre_Titular = ?,
                                Cmp_Fecha_Emision = ?,
                                Cmp_Fecha_Cobro = ?,
                                Cmp_Estado_Cheque = ?
                            WHERE Fk_Id_Pago = ?;";

            using (var conn = conexion.conexion())
            using (var cmd = new OdbcCommand(sSql, conn))
            {
                cmd.Parameters.Add(null, OdbcType.VarChar, 30).Value = numeroCheque;
                cmd.Parameters.Add(null, OdbcType.VarChar, 50).Value = bancoEmisor;
                cmd.Parameters.Add(null, OdbcType.VarChar, 50).Value = nombreTitular;
                cmd.Parameters.Add(null, OdbcType.Date).Value = fechaEmision;
                cmd.Parameters.Add(null, OdbcType.Date).Value = fechaCobro;
                cmd.Parameters.Add(null, OdbcType.VarChar, 20).Value = estadoCheque;
                cmd.Parameters.Add(null, OdbcType.Int).Value = fkPago;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
