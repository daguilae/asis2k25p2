using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Reservas_Hotel
{
    public class Cls_Sentencia_Pago_Efectivo
    {
        private readonly Cls_Conexion conexion = new Cls_Conexion();

      
        // === INSERTAR DETALLE EN TBL_PAGO_EFECTIVO =========
       
        public bool InsertarDetalleEfectivo(int idPago, string numeroRecibo, string observaciones)
        {
            using (OdbcConnection conn = conexion.conexion())
            {
                try
                {
                    string sql = @"
                        INSERT INTO tbl_pago_efectivo
                        (Fk_Id_Pago, Cmp_Numero_Recibo, Cmp_Observaciones)
                        VALUES (?, ?, ?);";

                    using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                    {
                        cmd.Parameters.Add("Fk_Id_Pago", OdbcType.Int).Value = idPago;
                        cmd.Parameters.Add("Cmp_Numero_Recibo", OdbcType.VarChar, 30).Value = numeroRecibo;
                        cmd.Parameters.Add("Cmp_Observaciones", OdbcType.VarChar, 200).Value = observaciones ?? string.Empty;

                        int filas = cmd.ExecuteNonQuery();
                        return filas > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error SQL en InsertarDetalleEfectivo: " + ex.Message);
                    throw new Exception("Error al registrar el detalle del pago en efectivo: " + ex.Message, ex);
                }
            }
        }
    }
}
