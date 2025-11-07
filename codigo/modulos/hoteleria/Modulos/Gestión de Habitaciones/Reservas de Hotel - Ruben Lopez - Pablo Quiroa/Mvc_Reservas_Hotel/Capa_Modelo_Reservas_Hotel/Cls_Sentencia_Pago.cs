using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Reservas_Hotel
{
    public class Cls_Sentencia_Pago
    {
        // 
        // === CONEXIÓN GENERAL ===
        // 
        private readonly Cls_Conexion conexion = new Cls_Conexion();

        // 
        // === OBTENER LISTA DE FOLIOS DISPONIBLES ===
        // 
        public DataTable datObtenerFolios()
        {
            DataTable dt = new DataTable();
            string sSql = @"
                SELECT 
                    F.Pk_Id_Folio,
                    CONCAT('Folio ', F.Pk_Id_Folio, ' | Habitación: ', H.Pk_ID_Habitaciones) AS DescripcionFolio,
                    F.Cmp_Saldo_Final
                FROM Tbl_Folio F
                INNER JOIN Tbl_Habitaciones H ON F.Fk_Id_Habitacion = H.Pk_ID_Habitaciones
                WHERE F.Cmp_Estado IN ('Abierto', 'Cerrado')
                ORDER BY F.Pk_Id_Folio DESC;";

            try
            {
                using (var conn = conexion.conexion())
                using (var da = new OdbcDataAdapter(sSql, conn))
                {
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener folios: " + ex.Message);
                throw new Exception("Error al obtener folios desde la base de datos.", ex);
            }

            return dt;
        }

        
        // === INSERTAR PAGO PRINCIPAL Y DEVOLVER SU ID ===
        
        public int funInsertarPago(int fkFolio, string metodo, DateTime fecha, decimal monto, string estado)
        {
            int idPagoGenerado = 0;

            using (var conn = conexion.conexion())
            {
                try
                {
                    string insertSql = @"
                        INSERT INTO tbl_pago
                        (Fk_Id_Folio, Cmp_Metodo_Pago, Cmp_Fecha_Pago, Cmp_Monto_Total, Cmp_Estado_Pago)
                        VALUES (?, ?, ?, ?, ?);";

                    using (var cmd = new OdbcCommand(insertSql, conn))
                    {
                        
                        cmd.Parameters.Add("Fk_Id_Folio", OdbcType.Int).Value = fkFolio;

                        // ENUMs se manejan como texto (VARCHAR)
                        cmd.Parameters.Add("Cmp_Metodo_Pago", OdbcType.VarChar, 20).Value = metodo;
                        cmd.Parameters.Add("Cmp_Fecha_Pago", OdbcType.VarChar, 19).Value = fecha.ToString("yyyy-MM-dd HH:mm:ss");

                        
                        cmd.Parameters.Add("Cmp_Monto_Total", OdbcType.Double).Value = Convert.ToDouble(monto);

                        // ENUM del estado también es texto
                        cmd.Parameters.Add("Cmp_Estado_Pago", OdbcType.VarChar, 20).Value = estado;

                        // Ejecutar la inserción
                        cmd.ExecuteNonQuery();
                    }

                    
                    string selectIdSql = "SELECT LAST_INSERT_ID();";
                    using (var cmdId = new OdbcCommand(selectIdSql, conn))
                    {
                        object result = cmdId.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                            idPagoGenerado = Convert.ToInt32(result);
                    }
                }
                catch (OdbcException odbcEx)
                {
                    Console.WriteLine("Error ODBC en funInsertarPago: " + odbcEx.Message);
                    Console.WriteLine("StackTrace: " + odbcEx.StackTrace);
                    throw new Exception("Error SQL en funInsertarPago: " + odbcEx.Message, odbcEx);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error general en funInsertarPago: " + ex.Message);
                    Console.WriteLine("StackTrace: " + ex.StackTrace);
                    throw new Exception("Error en funInsertarPago: " + ex.Message, ex);
                }
            }

            return idPagoGenerado;
        }
    }
}
