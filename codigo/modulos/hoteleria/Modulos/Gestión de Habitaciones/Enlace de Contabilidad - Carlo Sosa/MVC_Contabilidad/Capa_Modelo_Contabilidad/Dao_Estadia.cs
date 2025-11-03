using System;
using System.Collections.Generic;
using System.Data.Odbc;

//inicio del codigo- Carlo Sosa 0901-22-1106- Fecha: 01/11/2025

namespace Capa_Modelo_Contabilidad
{
    public class Dao_Estadia
    {
        readonly Conexion _cx = new Conexion();

        public List<(int Id, DateTime CheckIn, DateTime CheckOut, decimal Monto)> ListarEnRango(DateTime desde, DateTime hasta)
        {
            var list = new List<(int, DateTime, DateTime, decimal)>();
            var c = _cx.Abrir();
            try
            {
                using (var cmd = new OdbcCommand(
                    "SELECT Pk_Id_Estadia, Cmp_Fecha_Check_In, Cmp_Fecha_Check_Out, Cmp_Monto_Total_Pago " +
                    "FROM tbl_estadia " +
                    "WHERE Cmp_Fecha_Check_Out BETWEEN ? AND ? " +
                    "ORDER BY Cmp_Fecha_Check_Out", c))
                {
                    cmd.Parameters.Add("@p1", OdbcType.Date).Value = desde.Date;
                    cmd.Parameters.Add("@p2", OdbcType.Date).Value = hasta.Date;

                    using (var rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            int id = rd.GetInt32(0);
                            DateTime ci = rd.GetDateTime(1);
                            DateTime co = rd.GetDateTime(2);
                            decimal monto = rd.IsDBNull(3) ? 0m : Convert.ToDecimal(rd.GetValue(3));
                            list.Add((id, ci, co, monto));
                        }
                    }
                }
                return list;
            }
            finally { _cx.Cerrar(c); }
        }

        public bool ExistePolizaParaEstadia(int idEstadia)
        {
            var c = _cx.Abrir();
            try
            {
                using (var cmd = new OdbcCommand(
                    "SELECT COUNT(*) " +
                    "FROM tbl_encabezadopoliza " +
                    "WHERE Cmp_Concepto_Poliza LIKE ?", c))
                {
                    cmd.Parameters.Add("@p1", OdbcType.VarChar, 255).Value = "%Turismo Estadia " + idEstadia + "%";
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
            finally { _cx.Cerrar(c); }
        }

        public int InsertarPoliza(DateTime fecha, string concepto, decimal valor, int codDebe, int codHaber)
        {
            using (var c = _cx.Abrir())
            using (var tx = c.BeginTransaction())
            {
                string ctx = "";
                try
                {
                    int encId;

                    ctx = "INSERT encabezado";
                    using (var enc = new OdbcCommand(
                        "INSERT INTO tbl_encabezadopoliza " +
                        "(Cmp_Fecha_Poliza, Cmp_Concepto_Poliza, Cmp_Valor_Poliza) " +
                        "VALUES (?,?,CAST(? AS DECIMAL(12,2)))", c, tx))
                    {
                        enc.Parameters.Add("@p1", OdbcType.Date).Value = fecha.Date;
                        enc.Parameters.Add("@p2", OdbcType.VarChar, 255).Value = concepto ?? string.Empty;
                        enc.Parameters.Add("@p3", OdbcType.VarChar, 50).Value = valor.ToString(System.Globalization.CultureInfo.InvariantCulture);
                        enc.ExecuteNonQuery();
                    }

                    using (var idCmd = new OdbcCommand("SELECT LAST_INSERT_ID()", c, tx))
                        encId = Convert.ToInt32(idCmd.ExecuteScalar());

                    ctx = "INSERT detalle Debe";
                    using (var detD = new OdbcCommand(
                        "INSERT INTO tbl_detallepoliza " +
                        "(Fk_EncCodigo_Poliza, Fk_Codigo_Cuenta, Cmp_Tipo_Poliza, Cmp_Valor_Poliza) " +
                        "VALUES (?,?,?,CAST(? AS DECIMAL(12,2)))", c, tx))
                    {
                        detD.Parameters.Add("@d1", OdbcType.Int).Value = encId;
                        detD.Parameters.Add("@d2", OdbcType.Int).Value = codDebe;
                        detD.Parameters.Add("@d3", OdbcType.Char, 1).Value = "D";
                        detD.Parameters.Add("@d4", OdbcType.VarChar, 50).Value = valor.ToString(System.Globalization.CultureInfo.InvariantCulture);
                        detD.ExecuteNonQuery();
                    }

                    ctx = "INSERT detalle Haber";
                    using (var detH = new OdbcCommand(
                        "INSERT INTO tbl_detallepoliza " +
                        "(Fk_EncCodigo_Poliza, Fk_Codigo_Cuenta, Cmp_Tipo_Poliza, Cmp_Valor_Poliza) " +
                        "VALUES (?,?,?,CAST(? AS DECIMAL(12,2)))", c, tx))
                    {
                        detH.Parameters.Add("@h1", OdbcType.Int).Value = encId;
                        detH.Parameters.Add("@h2", OdbcType.Int).Value = codHaber;
                        detH.Parameters.Add("@h3", OdbcType.Char, 1).Value = "H";
                        detH.Parameters.Add("@h4", OdbcType.VarChar, 50).Value = valor.ToString(System.Globalization.CultureInfo.InvariantCulture);
                        detH.ExecuteNonQuery();
                    }

                    tx.Commit();
                    return encId;
                }
                catch (OdbcException ex)
                {
                    tx.Rollback();
                    throw new Exception(BuildOdbcDebug(ctx, ex));
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
            }
        }

        static string BuildOdbcDebug(string etapa, OdbcException ex)
        {
            var sb = new System.Text.StringBuilder();
            sb.Append(etapa).Append('\n');
            if (!string.IsNullOrWhiteSpace(ex.Message)) sb.Append(ex.Message).Append('\n');
            if (ex.Errors != null && ex.Errors.Count > 0)
                for (int i = 0; i < ex.Errors.Count; i++)
                    sb.Append(ex.Errors[i].SQLState).Append(" - ").Append(ex.Errors[i].Message).Append('\n');
            return sb.ToString();
        }
    }
}


//Fin del codigo- Carlo Sosa 0901-22-1106- Fecha: 01/11/2025
