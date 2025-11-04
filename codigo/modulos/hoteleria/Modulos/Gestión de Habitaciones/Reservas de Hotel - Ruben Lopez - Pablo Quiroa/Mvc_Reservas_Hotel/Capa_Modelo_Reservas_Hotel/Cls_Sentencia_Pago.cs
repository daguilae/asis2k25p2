using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Reservas_Hotel
{
    public class Cls_Sentencia_Pago
    {
        private readonly Cls_Conexion conexion = new Cls_Conexion();

        // ==================== CONSULTAR FOLIOS DISPONIBLES ====================
        public DataTable ObtenerFolios()
        {
            string sSql = @"SELECT Pk_Id_Folio, Cmp_Estado 
                            FROM tbl_folio 
                            WHERE Cmp_Estado IN ('Abierto', 'Pendiente', 'Activo');";

            using (var conn = conexion.conexion())
            using (var da = new OdbcDataAdapter(sSql, conn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // ==================== INSERTAR NUEVO PAGO ====================
        public void InsertarPago(int iIdFolio, string sMetodo, DateTime dFechaPago, decimal dMonto, string sEstado)
        {
            string sSql = @"INSERT INTO tbl_pago 
                            (Fk_Id_Folio, Cmp_Metodo_Pago, Cmp_Fecha_Pago, Cmp_Monto_Total, Cmp_Estado_Pago)
                            VALUES (?, ?, ?, ?, ?);";

            using (var conn = conexion.conexion())
            using (var cmd = new OdbcCommand(sSql, conn))
            {
                cmd.Parameters.Add(null, OdbcType.Int).Value = iIdFolio;
                cmd.Parameters.Add(null, OdbcType.VarChar, 20).Value = sMetodo;
                cmd.Parameters.Add(null, OdbcType.DateTime).Value = dFechaPago;
                cmd.Parameters.Add(null, OdbcType.Decimal).Value = dMonto;
                cmd.Parameters.Add(null, OdbcType.VarChar, 20).Value = sEstado;
                cmd.ExecuteNonQuery();
            }
        }

        // ==================== OBTENER ID DEL ÚLTIMO PAGO INSERTADO ====================
        public int ObtenerUltimoPagoId()
        {
            string sSql = "SELECT LAST_INSERT_ID();";
            using (var conn = conexion.conexion())
            using (var cmd = new OdbcCommand(sSql, conn))
            {
                object val = cmd.ExecuteScalar();
                return val != null ? Convert.ToInt32(val) : 0;
            }
        }

        // ==================== MODIFICAR PAGO ====================
        public void ModificarPago(int iIdPago, int iIdFolio, string sMetodo, DateTime dFecha, decimal dMonto, string sEstado)
        {
            string sSql = @"UPDATE tbl_pago
                            SET Fk_Id_Folio = ?, 
                                Cmp_Metodo_Pago = ?, 
                                Cmp_Fecha_Pago = ?, 
                                Cmp_Monto_Total = ?, 
                                Cmp_Estado_Pago = ?
                            WHERE Pk_Id_Pago = ?;";

            using (var conn = conexion.conexion())
            using (var cmd = new OdbcCommand(sSql, conn))
            {
                cmd.Parameters.Add(null, OdbcType.Int).Value = iIdFolio;
                cmd.Parameters.Add(null, OdbcType.VarChar, 20).Value = sMetodo;
                cmd.Parameters.Add(null, OdbcType.DateTime).Value = dFecha;
                cmd.Parameters.Add(null, OdbcType.Decimal).Value = dMonto;
                cmd.Parameters.Add(null, OdbcType.VarChar, 20).Value = sEstado;
                cmd.Parameters.Add(null, OdbcType.Int).Value = iIdPago;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
