using System;
using System.Data;
using System.Data.Odbc;

//Inicio del codigo - Carlo Sosa 0901-22-1106 - Fecha: 01/11/2025
namespace Capa_Modelo_Contabilidad
{
    public class Cls_ContabilidadDao
    {
        private readonly Cls_Conexion gCnn = new Cls_Conexion();

        public int fun_InsertarEncabezado(DateTime dFechaPoliza, string sConcepto, decimal deTotal)
        {
            const string sSql = @"
                INSERT INTO tbl_encabezadopoliza
                (Cmp_Fecha_Poliza, Cmp_Concepto_Poliza, Cmp_Valor_Poliza, Cmp_Estado_Poliza)
                VALUES (?, ?, ?, 'A'); SELECT LAST_INSERT_ID();";

            using (var c = gCnn.fun_AbrirConexion())
            using (var cmd = new OdbcCommand(sSql, c))
            {
                cmd.Parameters.Add("p1", OdbcType.Date).Value = dFechaPoliza;
                cmd.Parameters.Add("p2", OdbcType.VarChar).Value = sConcepto;
                cmd.Parameters.Add("p3", OdbcType.Decimal).Value = deTotal;
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public void fun_InsertarDetalle(int iIdEnc, int iCodCuenta, string sTipo, decimal deValor)
        {
            const string sSql = @"
                INSERT INTO tbl_detallepoliza
                (Fk_EncCodigo_Poliza, Fk_Codigo_Cuenta, Cmp_Tipo_Poliza, Cmp_Valor_Poliza)
                VALUES (?, ?, ?, ?)";

            using (var c = gCnn.fun_AbrirConexion())
            using (var cmd = new OdbcCommand(sSql, c))
            {
                cmd.Parameters.Add("p1", OdbcType.Int).Value = iIdEnc;
                cmd.Parameters.Add("p2", OdbcType.Int).Value = iCodCuenta;
                cmd.Parameters.Add("p3", OdbcType.Char).Value = sTipo; // 'D' o 'H'
                cmd.Parameters.Add("p4", OdbcType.Decimal).Value = deValor;
                cmd.ExecuteNonQuery();
            }
        }

        public bool fun_ExistePolizaParaEstadiaYConfig(int iIdEstadia, int iCodDebe, int iCodHaber)
        {
            const string sSql = @"
                SELECT COUNT(*)
                FROM tbl_detallepoliza d
                JOIN tbl_encabezadopoliza e ON e.Pk_EncCodigo_Poliza = d.Fk_EncCodigo_Poliza
                JOIN tbl_estadia s ON s.Cmp_Valor_Poliza IS NOT NULL
                WHERE e.Cmp_Fecha_Poliza = s.Cmp_Fecha_Check_Out
                  AND EXISTS(SELECT 1 FROM tbl_detallepoliza d2
                             WHERE d2.Fk_EncCodigo_Poliza = e.Pk_EncCodigo_Poliza
                               AND d2.Fk_Codigo_Cuenta = ?)
                  AND EXISTS(SELECT 1 FROM tbl_detallepoliza d3
                             WHERE d3.Fk_EncCodigo_Poliza = e.Pk_EncCodigo_Poliza
                               AND d3.Fk_Codigo_Cuenta = ?)
                  AND s.Pk_Id_Estadia = ?";

            using (var c = gCnn.fun_AbrirConexion())
            using (var cmd = new OdbcCommand(sSql, c))
            {
                cmd.Parameters.Add("p1", OdbcType.Int).Value = iCodDebe;
                cmd.Parameters.Add("p2", OdbcType.Int).Value = iCodHaber;
                cmd.Parameters.Add("p3", OdbcType.Int).Value = iIdEstadia;
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }
    }
}
//Final del codigo - Carlo Sosa 0901-22-1106 - Fecha: 01/11/2025




