using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;

//inicio del codigo- Carlo Sosa 0901-22-1106- Fecha: 01/11/2025

namespace Capa_Modelo_Contabilidad
{
    public class Dao_Contabilidad
    {
        readonly Conexion cnn = new Conexion();

        public int InsertarEncabezado(DateTime fechaPoliza, string concepto, decimal total)
        {
            const string sql =
                "INSERT INTO tbl_encabezadopoliza (Cmp_Fecha_Poliza, Cmp_Concepto_Poliza, Cmp_Valor_Poliza, Cmp_Estado_Poliza) " +
                "VALUES (?, ?, ?, 'A'); SELECT LAST_INSERT_ID();";

            using (var c = cnn.Abrir())
            using (var cmd = new OdbcCommand(sql, c))
            {
                cmd.Parameters.Add("p1", OdbcType.Date).Value = fechaPoliza;
                cmd.Parameters.Add("p2", OdbcType.VarChar).Value = concepto;
                cmd.Parameters.Add("p3", OdbcType.Decimal).Value = total;
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public void InsertarDetalle(int idEnc, int codCuenta, string tipo, decimal valor)
        {
            const string sql =
                "INSERT INTO tbl_detallepoliza (Fk_EncCodigo_Poliza, Fk_Codigo_Cuenta, Cmp_Tipo_Poliza, Cmp_Valor_Poliza) " +
                "VALUES (?, ?, ?, ?)";

            using (var c = cnn.Abrir())
            using (var cmd = new OdbcCommand(sql, c))
            {
                cmd.Parameters.Add("p1", OdbcType.Int).Value = idEnc;
                cmd.Parameters.Add("p2", OdbcType.Int).Value = codCuenta;
                cmd.Parameters.Add("p3", OdbcType.Char).Value = tipo; // 'D' o 'H'
                cmd.Parameters.Add("p4", OdbcType.Decimal).Value = valor;
                cmd.ExecuteNonQuery();
            }
        }

        public bool ExistePolizaParaEstadiaYConfig(int idEstadia, int codDebe, int codHaber)
        {
            const string sql =
            "SELECT COUNT(*) " +
            "FROM tbl_detallepoliza d " +
            "JOIN tbl_encabezadopoliza e ON e.Pk_EncCodigo_Poliza = d.Fk_EncCodigo_Poliza " +
            "JOIN tbl_estadia s ON s.Cmp_Valor_Poliza IS NOT NULL " + // ancla débil: si no guardas idEstadia en contabilidad, evitamos duplicar por monto/fecha
            "WHERE e.Cmp_Fecha_Poliza = s.Cmp_Fecha_Check_Out " +
            "AND EXISTS(SELECT 1 FROM tbl_detallepoliza d2 WHERE d2.Fk_EncCodigo_Poliza = e.Pk_EncCodigo_Poliza AND d2.Fk_Codigo_Cuenta = ? ) " +
            "AND EXISTS(SELECT 1 FROM tbl_detallepoliza d3 WHERE d3.Fk_EncCodigo_Poliza = e.Pk_EncCodigo_Poliza AND d3.Fk_Codigo_Cuenta = ? ) " +
            "AND s.Pk_Id_Estadia = ?";

            using (var c = cnn.Abrir())
            using (var cmd = new OdbcCommand(sql, c))
            {
                cmd.Parameters.Add("p1", OdbcType.Int).Value = codDebe;
                cmd.Parameters.Add("p2", OdbcType.Int).Value = codHaber;
                cmd.Parameters.Add("p3", OdbcType.Int).Value = idEstadia;
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }
    }
}

//Fin del codigo- Carlo Sosa 0901-22-1106- Fecha: 01/11/2025




