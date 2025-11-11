using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Reservas_Hotel
{
    public class Cls_Sentencia_Pago
    {
     
        private readonly Cls_Conexion gConexion = new Cls_Conexion();

       
        // funObtenerFolios: devuelve Pk_Id_Folio, DescripcionFolio y Cmp_Saldo_Final
       
        public DataTable funObtenerFolios()
        {
            var dt = new DataTable();

            const string sSql = @"
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
                using (var conn = gConexion.conexion())
                using (var da = new OdbcDataAdapter(sSql, conn))
                {
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener folios: " + ex.Message, ex);
            }

            return dt;
        }

       
        // funInsertarPago: inserta y devuelve el Pk_Id_Pago generado
    
        public int funInsertarPago(int fkFolio, string sMetodo, DateTime dFecha, decimal deMonto, string sEstado)
        {
            int iIdPagoGenerado = 0;

            using (var conn = gConexion.conexion())
            {
                try
                {
                    const string sInsert = @"
                        INSERT INTO Tbl_Pago
                        (Fk_Id_Folio, Cmp_Metodo_Pago, Cmp_Fecha_Pago, Cmp_Monto_Total, Cmp_Estado_Pago)
                        VALUES (?, ?, ?, ?, ?);";

                    using (var cmd = new OdbcCommand(sInsert, conn))
                    {
                        cmd.Parameters.Add("Fk_Id_Folio", OdbcType.Int).Value = fkFolio;
                        cmd.Parameters.Add("Cmp_Metodo_Pago", OdbcType.VarChar, 20).Value = sMetodo;                         // ENUM como texto
                        cmd.Parameters.Add("Cmp_Fecha_Pago", OdbcType.VarChar, 19).Value = dFecha.ToString("yyyy-MM-dd HH:mm:ss");
                        cmd.Parameters.Add("Cmp_Monto_Total", OdbcType.Double).Value = Convert.ToDouble(deMonto);
                        cmd.Parameters.Add("Cmp_Estado_Pago", OdbcType.VarChar, 20).Value = sEstado;                          // ENUM como texto

                        cmd.ExecuteNonQuery();
                    }

                    const string sLastId = "SELECT LAST_INSERT_ID();";
                    using (var cmdId = new OdbcCommand(sLastId, conn))
                    {
                        object o = cmdId.ExecuteScalar();
                        if (o != null && o != DBNull.Value) iIdPagoGenerado = Convert.ToInt32(o);
                    }
                }
                catch (OdbcException ex)
                {
                    throw new Exception("Error SQL en funInsertarPago: " + ex.Message, ex);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en funInsertarPago: " + ex.Message, ex);
                }
            }

            return iIdPagoGenerado;
        }
    }
}
