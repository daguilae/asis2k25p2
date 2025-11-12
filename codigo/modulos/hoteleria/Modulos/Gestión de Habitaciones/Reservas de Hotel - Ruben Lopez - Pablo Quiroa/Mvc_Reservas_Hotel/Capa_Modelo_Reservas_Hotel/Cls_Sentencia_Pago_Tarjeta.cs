using System;
using System.Data.Odbc;

namespace Capa_Modelo_Reservas_Hotel
{
    public class Cls_Sentencia_Pago_Tarjeta
    {
        private readonly Cls_Conexion gConexion = new Cls_Conexion();

       
        // INSERTAR DETALLE TARJETA
        public bool InsertarDetalleTarjeta(int iIdPago, string sNombre, string sNTarjeta,
                                           DateTime dVenc, int iCvc, int iPostal)
        {
            using (OdbcConnection conn = gConexion.conexion())
            {
                string sql = @"
                    INSERT INTO Tbl_Pago_Tarjeta
                    (Fk_Id_Pago, Cmp_Nombre_Titular, Cmp_Numero_Tarjeta, 
                     Cmp_Fecha_Vencimiento, Cmp_CVC, Cmp_Codigo_Postal)
                    VALUES (?, ?, ?, ?, ?, ?);";

                using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                {
                    cmd.Parameters.Add("Fk_Id_Pago", OdbcType.Int).Value = iIdPago;
                    cmd.Parameters.Add("Cmp_Nombre_Titular", OdbcType.VarChar).Value = sNombre;
                    cmd.Parameters.Add("Cmp_Numero_Tarjeta", OdbcType.VarChar).Value = sNTarjeta;
                    cmd.Parameters.Add("Cmp_Fecha_Vencimiento", OdbcType.VarChar).Value = dVenc.ToString("yyyy-MM-dd");
                    cmd.Parameters.Add("Cmp_CVC", OdbcType.Int).Value = iCvc;
                    cmd.Parameters.Add("Cmp_Codigo_Postal", OdbcType.Int).Value = iPostal;

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
