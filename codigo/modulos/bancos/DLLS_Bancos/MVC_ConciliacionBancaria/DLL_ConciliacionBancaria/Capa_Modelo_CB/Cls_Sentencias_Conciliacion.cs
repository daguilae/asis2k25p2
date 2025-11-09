using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;


    namespace Capa_Modelo_CB
    {
        // ==========================================================
        // Capa Modelo: Cls_Sentencias_Conciliacion
        // Paula Daniela Leonardo Paredes
        // ==========================================================
        public class Cls_Sentencias_Conciliacion
        {
            // ==========================
            // Crear
            // ==========================
            public int InsertarConciliacion(
                int iAnio, int iMes, DateTime dFechaConciliacion,
                int iIdCuentaBancaria,
                decimal deSaldoBanco, decimal deSaldoSistema,
                string sObservaciones, bool bActiva)
            {
                Cls_Conexion gConexion = new Cls_Conexion();
                using (OdbcConnection oCon = gConexion.conexion())
                {
                    string sSql = @"
                    INSERT INTO Tbl_ConciliacionBancaria
                        (Cmp_AnioConciliacion, Cmp_MesConciliacion, Cmp_FechaConciliacion,
                         Fk_Id_CuentaBancaria, Cmp_SaldoBanco, Cmp_SaldoSistema,
                         Cmp_Observaciones, Cmp_EstadoConciliacion)
                    VALUES (?,?,?,?,?,?,?,?)";

                    using (OdbcCommand oCmd = new OdbcCommand(sSql, oCon))
                    {
                        oCmd.Parameters.AddWithValue("", iAnio);
                        oCmd.Parameters.AddWithValue("", iMes);
                        oCmd.Parameters.AddWithValue("", dFechaConciliacion);
                        oCmd.Parameters.AddWithValue("", iIdCuentaBancaria);
                        oCmd.Parameters.AddWithValue("", deSaldoBanco);
                        oCmd.Parameters.AddWithValue("", deSaldoSistema);
                        oCmd.Parameters.AddWithValue("", (object)sObservaciones ?? DBNull.Value);
                        oCmd.Parameters.AddWithValue("", bActiva ? 1 : 0);
                        oCmd.ExecuteNonQuery();
                    }

                    using (OdbcCommand oCmdId = new OdbcCommand("SELECT LAST_INSERT_ID()", oCon))
                    {
                        object oResult = oCmdId.ExecuteScalar();
                        return (oResult != null && oResult != DBNull.Value) ? Convert.ToInt32(oResult) : 0;
                    }
                }
            }

            // ==========================
            // Eliminar
            // ==========================
            public void EliminarConciliacion(int iIdConciliacion)
            {
                Cls_Conexion gConexion = new Cls_Conexion();
                using (OdbcConnection oCon = gConexion.conexion())
                {
                    string sSql = "DELETE FROM Tbl_ConciliacionBancaria WHERE Pk_Id_Conciliacion = ?";
                    using (OdbcCommand oCmd = new OdbcCommand(sSql, oCon))
                    {
                        oCmd.Parameters.AddWithValue("", iIdConciliacion);
                        oCmd.ExecuteNonQuery();
                    }
                }
            }

            // ==========================
            // Consultas
            // ==========================
            public DataTable ObtenerConciliaciones()
            {
                DataTable dtConciliaciones = new DataTable();
                Cls_Conexion gConexion = new Cls_Conexion();
                using (OdbcConnection oCon = gConexion.conexion())
                {
                    string sSql = @"
                    SELECT Pk_Id_Conciliacion,
                           Cmp_AnioConciliacion,
                           Cmp_MesConciliacion,
                           Cmp_FechaConciliacion,
                           Fk_Id_CuentaBancaria,
                           Cmp_SaldoBanco,
                           Cmp_SaldoSistema,
                           Cmp_Diferencia,
                           Cmp_Observaciones,
                           Cmp_EstadoConciliacion
                      FROM Tbl_ConciliacionBancaria
                  ORDER BY Cmp_AnioConciliacion DESC, Cmp_MesConciliacion DESC, Pk_Id_Conciliacion DESC";
                    using (OdbcDataAdapter oDa = new OdbcDataAdapter(sSql, oCon))
                    {
                        oDa.Fill(dtConciliaciones);
                    }
                }
                return dtConciliaciones;
            }

            public DataTable ObtenerConciliacionPorId(int iIdConciliacion)
            {
                DataTable dtConciliacion = new DataTable();
                Cls_Conexion gConexion = new Cls_Conexion();
                using (OdbcConnection oCon = gConexion.conexion())
                {
                    string sSql = @"
                    SELECT Pk_Id_Conciliacion,
                           Cmp_AnioConciliacion,
                           Cmp_MesConciliacion,
                           Cmp_FechaConciliacion,
                           Fk_Id_CuentaBancaria,
                           Cmp_SaldoBanco,
                           Cmp_SaldoSistema,
                           Cmp_Diferencia,
                           Cmp_Observaciones,
                           Cmp_EstadoConciliacion
                      FROM Tbl_ConciliacionBancaria
                     WHERE Pk_Id_Conciliacion = ?";
                    using (OdbcDataAdapter oDa = new OdbcDataAdapter(sSql, oCon))
                    {
                        oDa.SelectCommand.Parameters.AddWithValue("", iIdConciliacion);
                        oDa.Fill(dtConciliacion);
                    }
                }
                return dtConciliacion;
            }

            public bool ExisteConciliacionPeriodoCuenta(int iAnio, int iMes, int iIdCuentaBancaria)
            {
                Cls_Conexion gConexion = new Cls_Conexion();
                using (OdbcConnection oCon = gConexion.conexion())
                {
                    string sSql = @"
                    SELECT 1
                      FROM Tbl_ConciliacionBancaria
                     WHERE Cmp_AnioConciliacion = ?
                       AND Cmp_MesConciliacion  = ?
                       AND Fk_Id_CuentaBancaria = ?
                     LIMIT 1";
                    using (OdbcCommand oCmd = new OdbcCommand(sSql, oCon))
                    {
                        oCmd.Parameters.AddWithValue("", iAnio);
                        oCmd.Parameters.AddWithValue("", iMes);
                        oCmd.Parameters.AddWithValue("", iIdCuentaBancaria);
                        object oResult = oCmd.ExecuteScalar();
                        return oResult != null;
                    }
                }
            }

            // ==========================
            // Catálogos (para combos)
            // *Ajusta nombres de columnas si tus tablas difieren*
            // ==========================
            public DataTable ObtenerBancos()
            {
                DataTable dtBancos = new DataTable();
                Cls_Conexion gConexion = new Cls_Conexion();
                using (OdbcConnection oCon = gConexion.conexion())
                {
                    string sSql = @"SELECT Pk_Id_Banco, Cmp_Nombre_Banco
                                  FROM Tbl_Bancos
                                 WHERE Cmp_Estado_Banco = 1
                              ORDER BY Cmp_Nombre_Banco";
                    using (OdbcDataAdapter oDa = new OdbcDataAdapter(sSql, oCon))
                    {
                        oDa.Fill(dtBancos);
                    }
                }
                return dtBancos;
            }

            public DataTable ObtenerCuentasPorBanco(int iIdBanco)
            {
                DataTable dtCuentas = new DataTable();
                Cls_Conexion gConexion = new Cls_Conexion();
                using (OdbcConnection oCon = gConexion.conexion())
                {
                    string sSql = @"
                    SELECT Pk_Id_CuentaBancaria, Cmp_NumeroCuenta
                      FROM Tbl_CuentasBancarias
                     WHERE Fk_Id_Banco = ?
                       AND (Cmp_Estado_Cuenta = 1 OR Cmp_Estado_Cuenta IS NULL)
                  ORDER BY Cmp_NumeroCuenta";
                    using (OdbcDataAdapter oDa = new OdbcDataAdapter(sSql, oCon))
                    {
                        oDa.SelectCommand.Parameters.AddWithValue("", iIdBanco);
                        oDa.Fill(dtCuentas);
                    }
                }
                return dtCuentas;
            }
        }
    }


