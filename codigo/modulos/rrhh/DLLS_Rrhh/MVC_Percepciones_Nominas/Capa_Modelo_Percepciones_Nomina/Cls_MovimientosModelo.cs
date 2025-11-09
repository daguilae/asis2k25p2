/* 
 * Programador: Richard Anthony De León Milian
 * Carné: 0901-22-10245
 * Fecha de modificación: 8/11/2025
 * Archivo: Cls_MovimientosModelo.cs
 * Descripción: CRUD a la base de datos
 */
using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Percepciones_Nomina
{
    public class Cls_MovimientosModelo
    {
       //Comprueba si la tabla está vacía
        public bool funEstaVaciaTabla(string sTabla)
        {
            Cls_Conexion cn = new Cls_Conexion();
            using (OdbcConnection con = cn.conexionDB())
            using (OdbcCommand cmd = new OdbcCommand($"SELECT COUNT(*) FROM `{sTabla}`;", con))
            {
                int iCount = Convert.ToInt32(cmd.ExecuteScalar());
                cn.cerrarConexion();
                return iCount == 0;
            }
        }

        // ✅ Si está vacía, reinicia AUTO_INCREMENT a 1
        public void proResetAutoIncrementIfEmpty(string sTabla)
        {
            if (funEstaVaciaTabla(sTabla))
            {
                Cls_Conexion cn = new Cls_Conexion();
                using (OdbcConnection con = cn.conexionDB())
                using (OdbcCommand cmd = new OdbcCommand($"ALTER TABLE `{sTabla}` AUTO_INCREMENT = 1;", con))
                {
                    cmd.ExecuteNonQuery();
                }
                cn.cerrarConexion();
            }
        }

        // Específico para movimientos
        public void proResetAutoIncrementIfEmptyMovimientos()
            => proResetAutoIncrementIfEmpty("Tbl_MovimientosNomina");



        // INSERT — Inserta movimiento y devuelve ID generado
        public int funInsertarMovimiento(int iIdNomina, int iIdConcepto, decimal deMonto)
        {
            // Si está vacía la tabla, el próximo ID será 1
            proResetAutoIncrementIfEmptyMovimientos();

            Cls_Conexion cn = new Cls_Conexion();
            using (OdbcConnection con = cn.conexionDB())
            using (OdbcTransaction tx = con.BeginTransaction())
            {
                try
                {
                    string sSql = @"
                        INSERT INTO `Tbl_MovimientosNomina`
                            (`Cmp_iId_Nomina`, `Cmp_iId_ConceptoNomina`, `Cmp_deMonto_MovimientoNomina`)
                        VALUES (?, ?, ?);";

                    using (var cmd = new OdbcCommand(sSql, con, tx))
                    {
                        cmd.Parameters.Add("p1", OdbcType.Int).Value = iIdNomina;
                        cmd.Parameters.Add("p2", OdbcType.Int).Value = iIdConcepto;
                        cmd.Parameters.Add("p3", OdbcType.Decimal).Value = deMonto;
                        cmd.ExecuteNonQuery();
                    }

                    int iNuevoId;
                    using (var cmdId = new OdbcCommand("SELECT LAST_INSERT_ID();", con, tx))
                        iNuevoId = Convert.ToInt32(cmdId.ExecuteScalar());

                    tx.Commit();
                    return iNuevoId;
                }
                catch
                {
                    try { tx.Rollback(); } catch { }
                    throw;
                }
                finally
                {
                    cn.cerrarConexion();
                }
            }
        }



        // SELECT — Listar movimientos por nómina
        public DataTable funObtenerMovimientosPorNomina(int iIdNomina, bool asc = true)
        {
            var dt = new DataTable();
            Cls_Conexion cn = new Cls_Conexion();
            string sOrden = asc ? "ASC" : "DESC";

            using (OdbcConnection con = cn.conexionDB())
            using (OdbcCommand cmd = new OdbcCommand($@"
                SELECT
                    m.`Cmp_iId_MovimientoNomina`     AS id_movimiento,
                    m.`Cmp_iId_Nomina`               AS id_nomina,
                    m.`Cmp_iId_ConceptoNomina`       AS id_concepto_nomina,
                    c.`Cmp_sNombre_ConceptoNomina`   AS concepto,
                    m.`Cmp_deMonto_MovimientoNomina` AS monto
                FROM `Tbl_MovimientosNomina` m
                INNER JOIN `Tbl_ConceptosNomina` c
                    ON c.`Cmp_iId_ConceptoNomina` = m.`Cmp_iId_ConceptoNomina`
                WHERE m.`Cmp_iId_Nomina` = ?
                ORDER BY m.`Cmp_iId_MovimientoNomina` {sOrden};", con))
            {
                cmd.Parameters.Add("p1", OdbcType.Int).Value = iIdNomina;
                using (var da = new OdbcDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }

            cn.cerrarConexion();
            return dt;
        }



        // DELETE — Eliminar movimiento por ID
        public void proEliminarMovimiento(int iIdMovimiento)
        {
            Cls_Conexion cn = new Cls_Conexion();
            using (OdbcConnection con = cn.conexionDB())
            using (OdbcCommand cmd = new OdbcCommand(@"
                DELETE FROM `Tbl_MovimientosNomina`
                WHERE `Cmp_iId_MovimientoNomina` = ?;", con))
            {
                cmd.Parameters.Add("p1", OdbcType.Int).Value = iIdMovimiento;
                cmd.ExecuteNonQuery();
            }
            cn.cerrarConexion();
        }

        // DELETE ALL — Vaciar tabla de movimientos
        public void proEliminarTodosMovimientos()
        {
            Cls_Conexion cn = new Cls_Conexion();
            using (OdbcConnection con = cn.conexionDB())
            using (OdbcCommand cmd = new OdbcCommand("TRUNCATE TABLE `Tbl_MovimientosNomina`;", con))
            {
                cmd.ExecuteNonQuery();
            }
            cn.cerrarConexion();
        }
    }
}
