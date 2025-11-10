using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_CB
{
    // ==========================================================
    // Capa Modelo: Cls_Sentencias_Conciliacion (solo SQL)
    // Paula Daniela Leonardo Paredes
    // ==========================================================
    public class Cls_Sentencias_Conciliacion
    {
        // INSERT (NO usa Fk_Id_Banco porque no existe en la tabla)
        public int InsertarConciliacion(
            int iAnio, int iMes, DateTime dFechaConciliacion,
            int iIdBanco /*no usado*/, int iIdCuentaBancaria,
            decimal deSaldoBanco, decimal deSaldoSistema,
            string sObservaciones, bool bActiva)
        {
            var gConexion = new Cls_Conexion();
            using (OdbcConnection oCon = gConexion.conexion())
            {
                const string sSql = @"
                    INSERT INTO Tbl_ConciliacionBancaria
                        (Fk_Id_CuentaBancaria,
                         Cmp_AnioConciliacion, Cmp_MesConciliacion, Cmp_FechaConciliacion,
                         Cmp_SaldoBanco, Cmp_SaldoSistema,
                         Cmp_Observaciones, Cmp_EstadoConciliacion)
                    VALUES (?,?,?,?,?,?,?,?)";

                using (var oCmd = new OdbcCommand(sSql, oCon))
                {
                    oCmd.Parameters.AddWithValue("", iIdCuentaBancaria);
                    oCmd.Parameters.AddWithValue("", iAnio);
                    oCmd.Parameters.AddWithValue("", iMes);
                    oCmd.Parameters.AddWithValue("", dFechaConciliacion);
                    oCmd.Parameters.AddWithValue("", deSaldoBanco);
                    oCmd.Parameters.AddWithValue("", deSaldoSistema);
                    oCmd.Parameters.AddWithValue("", (object)sObservaciones ?? DBNull.Value);
                    oCmd.Parameters.AddWithValue("", bActiva ? 1 : 0);
                    oCmd.ExecuteNonQuery();
                }

                using (var oCmdId = new OdbcCommand("SELECT LAST_INSERT_ID()", oCon))
                {
                    object oResult = oCmdId.ExecuteScalar();
                    return (oResult != null && oResult != DBNull.Value) ? Convert.ToInt32(oResult) : 0;
                }
            }
        }

        // UPDATE (NO toca Fk_Id_Banco porque no existe en la tabla)
        public void ActualizarConciliacion(
            int iIdConciliacion,
            int iAnio, int iMes, DateTime dFechaConciliacion,
            int iIdBanco /*no usado*/, int iIdCuentaBancaria,
            decimal deSaldoBanco, decimal deSaldoSistema,
            string sObservaciones, bool bActiva)
        {
            var gConexion = new Cls_Conexion();
            using (OdbcConnection oCon = gConexion.conexion())
            {
                const string sSql = @"
                    UPDATE Tbl_ConciliacionBancaria
                       SET Fk_Id_CuentaBancaria = ?,
                           Cmp_AnioConciliacion = ?,
                           Cmp_MesConciliacion  = ?,
                           Cmp_FechaConciliacion = ?,
                           Cmp_SaldoBanco = ?,
                           Cmp_SaldoSistema = ?,
                           Cmp_Observaciones = ?,
                           Cmp_EstadoConciliacion = ?
                     WHERE Pk_Id_Conciliacion = ?";

                using (var oCmd = new OdbcCommand(sSql, oCon))
                {
                    oCmd.Parameters.AddWithValue("", iIdCuentaBancaria);
                    oCmd.Parameters.AddWithValue("", iAnio);
                    oCmd.Parameters.AddWithValue("", iMes);
                    oCmd.Parameters.AddWithValue("", dFechaConciliacion);
                    oCmd.Parameters.AddWithValue("", deSaldoBanco);
                    oCmd.Parameters.AddWithValue("", deSaldoSistema);
                    oCmd.Parameters.AddWithValue("", (object)sObservaciones ?? DBNull.Value);
                    oCmd.Parameters.AddWithValue("", bActiva ? 1 : 0);
                    oCmd.Parameters.AddWithValue("", iIdConciliacion);
                    oCmd.ExecuteNonQuery();
                }
            }
        }

        // DELETE
        public void EliminarConciliacion(int iIdConciliacion)
        {
            var gConexion = new Cls_Conexion();
            using (OdbcConnection oCon = gConexion.conexion())
            {
                const string sSql = "DELETE FROM Tbl_ConciliacionBancaria WHERE Pk_Id_Conciliacion = ?";
                using (var oCmd = new OdbcCommand(sSql, oCon))
                {
                    oCmd.Parameters.AddWithValue("", iIdConciliacion);
                    oCmd.ExecuteNonQuery();
                }
            }
        }

        // QUERIES (unimos por Cuenta -> Banco para obtener nombres)
        public DataTable ObtenerConciliaciones()
        {
            var dt = new DataTable();
            var gConexion = new Cls_Conexion();
            using (OdbcConnection oCon = gConexion.conexion())
            {
                const string sSql = @"
            SELECT cb.Pk_Id_Conciliacion,
                   c.Fk_Id_Banco,
                   b.Cmp_NombreBanco     AS Banco,
                   cb.Fk_Id_CuentaBancaria,
                   c.Cmp_NumeroCuenta    AS Cuenta,
                   cb.Cmp_AnioConciliacion,
                   cb.Cmp_MesConciliacion,
                   cb.Cmp_FechaConciliacion,
                   cb.Cmp_SaldoBanco,
                   cb.Cmp_SaldoSistema,
                   cb.Cmp_Diferencia,
                   cb.Cmp_Observaciones,
                   cb.Cmp_EstadoConciliacion
              FROM Tbl_ConciliacionBancaria cb
        INNER JOIN Tbl_CuentasBancarias c
                ON c.Pk_Id_CuentaBancaria = cb.Fk_Id_CuentaBancaria
        INNER JOIN Tbl_Bancos b
                ON b.Pk_Id_Banco = c.Fk_Id_Banco
          ORDER BY cb.Cmp_AnioConciliacion DESC,
                   cb.Cmp_MesConciliacion  DESC,
                   cb.Pk_Id_Conciliacion   DESC";
                using (var oDa = new OdbcDataAdapter(sSql, oCon))
                {
                    oDa.Fill(dt);
                }
            }
            return dt;
        }

        public DataTable ObtenerConciliacionPorId(int iIdConciliacion)
        {
            var dt = new DataTable();
            var gConexion = new Cls_Conexion();
            using (OdbcConnection oCon = gConexion.conexion())
            {
                const string sSql = @"
            SELECT cb.Pk_Id_Conciliacion,
                   c.Fk_Id_Banco,
                   b.Cmp_NombreBanco     AS Banco,
                   cb.Fk_Id_CuentaBancaria,
                   c.Cmp_NumeroCuenta    AS Cuenta,
                   cb.Cmp_AnioConciliacion,
                   cb.Cmp_MesConciliacion,
                   cb.Cmp_FechaConciliacion,
                   cb.Cmp_SaldoBanco,
                   cb.Cmp_SaldoSistema,
                   cb.Cmp_Diferencia,
                   cb.Cmp_Observaciones,
                   cb.Cmp_EstadoConciliacion
              FROM Tbl_ConciliacionBancaria cb
        INNER JOIN Tbl_CuentasBancarias c
                ON c.Pk_Id_CuentaBancaria = cb.Fk_Id_CuentaBancaria
        INNER JOIN Tbl_Bancos b
                ON b.Pk_Id_Banco = c.Fk_Id_Banco
             WHERE cb.Pk_Id_Conciliacion = ?";
                using (var oDa = new OdbcDataAdapter(sSql, oCon))
                {
                    oDa.SelectCommand.Parameters.AddWithValue("", iIdConciliacion);
                    oDa.Fill(dt);
                }
            }
            return dt;
        }

        // Duplicados (por período + cuenta)
        public bool ExisteConciliacionPeriodoCuenta(int iAnio, int iMes, int iIdCuentaBancaria)
        {
            var gConexion = new Cls_Conexion();
            using (OdbcConnection oCon = gConexion.conexion())
            {
                const string sSql = @"
                    SELECT 1
                      FROM Tbl_ConciliacionBancaria
                     WHERE Cmp_AnioConciliacion = ?
                       AND Cmp_MesConciliacion  = ?
                       AND Fk_Id_CuentaBancaria = ?
                     LIMIT 1";
                using (var oCmd = new OdbcCommand(sSql, oCon))
                {
                    oCmd.Parameters.AddWithValue("", iAnio);
                    oCmd.Parameters.AddWithValue("", iMes);
                    oCmd.Parameters.AddWithValue("", iIdCuentaBancaria);
                    object oResult = oCmd.ExecuteScalar();
                    return oResult != null;
                }
            }
        }

        public bool ExisteConciliacionPeriodoCuentaExceptoId(
            int iAnio, int iMes, int iIdCuentaBancaria, int iIdExcluir)
        {
            var gConexion = new Cls_Conexion();
            using (OdbcConnection oCon = gConexion.conexion())
            {
                const string sSql = @"
                    SELECT 1
                      FROM Tbl_ConciliacionBancaria
                     WHERE Cmp_AnioConciliacion = ?
                       AND Cmp_MesConciliacion  = ?
                       AND Fk_Id_CuentaBancaria = ?
                       AND Pk_Id_Conciliacion  <> ?
                     LIMIT 1";
                using (var oCmd = new OdbcCommand(sSql, oCon))
                {
                    oCmd.Parameters.AddWithValue("", iAnio);
                    oCmd.Parameters.AddWithValue("", iMes);
                    oCmd.Parameters.AddWithValue("", iIdCuentaBancaria);
                    oCmd.Parameters.AddWithValue("", iIdExcluir);
                    object oRes = oCmd.ExecuteScalar();
                    return oRes != null;
                }
            }
        }

        // Catálogos
        public DataTable ObtenerBancos()
        {
            var dt = new DataTable();
            var gConexion = new Cls_Conexion();
            using (OdbcConnection oCon = gConexion.conexion())
            {
                const string sSql = @"
                    SELECT Pk_Id_Banco, Cmp_NombreBanco
                      FROM Tbl_Bancos
                     WHERE Cmp_Estado = 1
                  ORDER BY Cmp_NombreBanco";
                using (var oDa = new OdbcDataAdapter(sSql, oCon))
                {
                    oDa.Fill(dt);
                }
            }
            return dt;
        }

        public DataTable ObtenerCuentasPorBanco(int iIdBanco)
        {
            var dt = new DataTable();
            var gConexion = new Cls_Conexion();
            using (OdbcConnection oCon = gConexion.conexion())
            {
                const string sSql = @"
                    SELECT Pk_Id_CuentaBancaria, Cmp_NumeroCuenta
                      FROM Tbl_CuentasBancarias
                     WHERE Fk_Id_Banco = ?
                       AND (Cmp_Estado = 1 OR Cmp_Estado IS NULL)
                  ORDER BY Cmp_NumeroCuenta";
                using (var oDa = new OdbcDataAdapter(sSql, oCon))
                {
                    oDa.SelectCommand.Parameters.AddWithValue("", iIdBanco);
                    oDa.Fill(dt);
                }
            }
            return dt;
        }
    }
}
