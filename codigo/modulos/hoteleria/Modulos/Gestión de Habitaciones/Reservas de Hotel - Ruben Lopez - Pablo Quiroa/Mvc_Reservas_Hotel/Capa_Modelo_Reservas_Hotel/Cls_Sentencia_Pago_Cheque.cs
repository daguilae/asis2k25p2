using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Reservas_Hotel
{
    public class Cls_Sentencia_Pago_Cheque
    {
        private readonly Cls_Conexion conexion = new Cls_Conexion();

        
        // INSERTAR DETALLE EN TBL_PAGO_CHEQUE
        
        public bool InsertarDetalleCheque(int idPago, string numero, string banco, string titular,
                                          DateTime fechaEmision, DateTime fechaCobro, string estadoCheque)
        {
            using (OdbcConnection conn = conexion.conexion())
            {
                try
                {
                    string sql = @"
                        INSERT INTO tbl_pago_cheque
                        (Fk_Id_Pago, Cmp_Numero_Cheque, Cmp_Banco_Emisor, Cmp_Nombre_Titular,
                         Cmp_Fecha_Emision, Cmp_Fecha_Cobro, Cmp_Estado_Cheque)
                        VALUES (?, ?, ?, ?, ?, ?, ?);";

                    using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                    {
                        cmd.Parameters.Add("Fk_Id_Pago", OdbcType.Int).Value = idPago;
                        cmd.Parameters.Add("Cmp_Numero_Cheque", OdbcType.VarChar, 30).Value = numero;
                        cmd.Parameters.Add("Cmp_Banco_Emisor", OdbcType.VarChar, 50).Value = banco;
                        cmd.Parameters.Add("Cmp_Nombre_Titular", OdbcType.VarChar, 50).Value = titular;
                        cmd.Parameters.Add("Cmp_Fecha_Emision", OdbcType.VarChar, 19).Value = fechaEmision.ToString("yyyy-MM-dd HH:mm:ss");
                        cmd.Parameters.Add("Cmp_Fecha_Cobro", OdbcType.VarChar, 19).Value = fechaCobro.ToString("yyyy-MM-dd HH:mm:ss");
                        cmd.Parameters.Add("Cmp_Estado_Cheque", OdbcType.VarChar, 20).Value = estadoCheque;

                        int filas = cmd.ExecuteNonQuery();
                        return filas > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error SQL en InsertarDetalleCheque: " + ex.Message);
                    throw new Exception("Error al registrar el detalle del cheque: " + ex.Message, ex);
                }
            }
        }
    }
}
