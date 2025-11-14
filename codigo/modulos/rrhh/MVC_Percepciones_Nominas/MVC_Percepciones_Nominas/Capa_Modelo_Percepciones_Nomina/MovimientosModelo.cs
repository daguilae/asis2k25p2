using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;


namespace Capa_Modelo_Percepciones_Nomina
{
    // 📂 Capa_Modelo_Percepciones_Nomina / MovimientosModelo.cs
    public class MovimientosModelo
    {
        /// <summary>
        /// Inserta un registro en Tbl_MovimientosNomina y retorna el ID generado.
        /// </summary>
        public int InsertarMovimiento(int idNomina, int idConcepto, decimal monto)
        {
            Conexion cn = new Conexion();
            using (OdbcConnection con = cn.conexionDB())
            using (OdbcTransaction tx = con.BeginTransaction())
            {
                try
                {
                    // Insert
                    using (var cmd = new OdbcCommand(@"
                        INSERT INTO `Tbl_MovimientosNomina`
                            (`Cmp_iId_Nomina`, `Cmp_iId_ConceptoNomina`, `Cmp_deMonto_MovimientoNomina`)
                        VALUES (?, ?, ?);", con, tx))
                    {
                        cmd.Parameters.Add("p1", OdbcType.Int).Value = idNomina;
                        cmd.Parameters.Add("p2", OdbcType.Int).Value = idConcepto;
                        cmd.Parameters.Add("p3", OdbcType.Decimal).Value = monto;
                        cmd.ExecuteNonQuery();
                    }

                    // Obtener ID generado
                    int nuevoId;
                    using (var cmdId = new OdbcCommand("SELECT LAST_INSERT_ID();", con, tx))
                    {
                        nuevoId = Convert.ToInt32(cmdId.ExecuteScalar());
                    }

                    tx.Commit();
                    return nuevoId;
                }
                catch
                {
                    try { tx.Rollback(); } catch { /* ignore */ }
                    throw;
                }
                finally
                {
                    cn.cerrarConexion();
                }
            }
        }

        /// <summary>
        /// Lista movimientos de una nómina, incluyendo el nombre del concepto.
        /// Usa 'asc = true' para verlos en orden 1,2,3...
        /// </summary>
        public DataTable ObtenerMovimientosPorNomina(int idNomina, bool asc = true)
        {
            DataTable dt = new DataTable();
            Conexion cn = new Conexion();
            string orden = asc ? "ASC" : "DESC";

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
                ORDER BY m.`Cmp_iId_MovimientoNomina` {orden};", con))
            {
                cmd.Parameters.Add("p1", OdbcType.Int).Value = idNomina;
                using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }

            cn.cerrarConexion();
            return dt;
        }
    }
}
