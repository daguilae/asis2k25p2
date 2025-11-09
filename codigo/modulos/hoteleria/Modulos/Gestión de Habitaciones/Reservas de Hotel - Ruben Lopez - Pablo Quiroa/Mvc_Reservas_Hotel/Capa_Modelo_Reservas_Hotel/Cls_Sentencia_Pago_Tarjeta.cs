using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Reservas_Hotel
{
    public class Cls_Sentencia_Pago_Tarjeta
    {
        private readonly Cls_Conexion conexion = new Cls_Conexion();

        
        // INSERTAR EN TBL_PAGO Y DEVOLVER ID
        
        public int InsertarPagoYObtenerId(int fkFolio, string metodo, DateTime fecha, decimal monto, string estado)
        {
            int idPagoGenerado = -1;

            using (OdbcConnection conn = conexion.conexion())
            {
                try
                {
                    string sql = @"
                        INSERT INTO tbl_pago
                        (Fk_Id_Folio, Cmp_Metodo_Pago, Cmp_Fecha_Pago, Cmp_Monto_Total, Cmp_Estado_Pago)
                        VALUES (?, ?, ?, ?, ?);";

                    using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                    {
                        // Definimos tipos seguros para ODBC
                        cmd.Parameters.Add("Fk_Id_Folio", OdbcType.Int).Value = fkFolio;
                        cmd.Parameters.Add("Cmp_Metodo_Pago", OdbcType.VarChar, 20).Value = metodo;
                        cmd.Parameters.Add("Cmp_Fecha_Pago", OdbcType.VarChar, 19).Value = fecha.ToString("yyyy-MM-dd HH:mm:ss");
                        cmd.Parameters.Add("Cmp_Monto_Total", OdbcType.Double).Value = Convert.ToDouble(monto);
                        cmd.Parameters.Add("Cmp_Estado_Pago", OdbcType.VarChar, 20).Value = estado;

                        cmd.ExecuteNonQuery();
                    }

                    
                    string selectIdSql = "SELECT LAST_INSERT_ID();";
                    using (OdbcCommand cmdId = new OdbcCommand(selectIdSql, conn))
                    {
                        object result = cmdId.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                            idPagoGenerado = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error SQL en InsertarPagoYObtenerId: " + ex.Message);
                    throw new Exception("Error al registrar el pago principal: " + ex.Message, ex);
                }
            }

            return idPagoGenerado;
        }

        
        // INSERTAR DETALLE EN TBL_PAGO_TARJETA
        
        public bool InsertarDetalleTarjeta(int idPago, string nombreTitular, string numeroTarjeta, DateTime fechaVencimiento, int cvc, int codigoPostal)
        {
            using (OdbcConnection conn = conexion.conexion())
            {
                try
                {
                    string sql = @"
                        INSERT INTO tbl_pago_tarjeta
                        (Fk_Id_Pago, Cmp_Nombre_Titular, Cmp_Numero_Tarjeta, Cmp_Fecha_Vencimiento, Cmp_CVC, Cmp_Codigo_Postal)
                        VALUES (?, ?, ?, ?, ?, ?);";

                    using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                    {
                     
                        cmd.Parameters.Add("Fk_Id_Pago", OdbcType.Int).Value = idPago;
                        cmd.Parameters.Add("Cmp_Nombre_Titular", OdbcType.VarChar, 50).Value = nombreTitular;
                        cmd.Parameters.Add("Cmp_Numero_Tarjeta", OdbcType.VarChar, 20).Value = numeroTarjeta;

                        
                        cmd.Parameters.Add("Cmp_Fecha_Vencimiento", OdbcType.VarChar, 10).Value = fechaVencimiento.ToString("yyyy-MM-dd");

                        cmd.Parameters.Add("Cmp_CVC", OdbcType.Int).Value = cvc;
                        cmd.Parameters.Add("Cmp_Codigo_Postal", OdbcType.Int).Value = codigoPostal;

                        int filas = cmd.ExecuteNonQuery();
                        return filas > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error SQL en InsertarDetalleTarjeta: " + ex.Message);
                    throw new Exception("Error al registrar el detalle del pago con tarjeta: " + ex.Message, ex);
                }
            }
        }
    }
}
