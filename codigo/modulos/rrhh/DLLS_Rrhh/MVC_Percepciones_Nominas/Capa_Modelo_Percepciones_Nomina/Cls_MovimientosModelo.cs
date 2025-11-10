using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Percepciones_Nomina
{
    public class Cls_MovimientosModelo
    {
        // ---------------------------------------------------------------------
        // Comprueba si la tabla está vacía
        // ---------------------------------------------------------------------
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

        // ---------------------------------------------------------------------
        // Reinicia AUTO_INCREMENT si la tabla está vacía
        // ---------------------------------------------------------------------
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

        public void proResetAutoIncrementIfEmptyMovimientos()
            => proResetAutoIncrementIfEmpty("Tbl_MovimientosNomina");

        // ---------------------------------------------------------------------
        // INSERT: Inserta movimiento (Nómina + Empleado + Concepto + Monto)
        // ---------------------------------------------------------------------
        public int funInsertarMovimiento(int iIdNomina, int iIdEmpleado, int iIdConcepto, decimal deMonto)
        {
            proResetAutoIncrementIfEmptyMovimientos();

            Cls_Conexion cn = new Cls_Conexion();
            using (OdbcConnection con = cn.conexionDB())
            using (OdbcTransaction tx = con.BeginTransaction())
            {
                try
                {
                    // Validar existencia del empleado
                    string sValidaEmpleado = "SELECT COUNT(*) FROM Tbl_Empleados WHERE Cmp_iId_Empleado = ?";
                    using (var cmdEmp = new OdbcCommand(sValidaEmpleado, con, tx))
                    {
                        cmdEmp.Parameters.Add("p1", OdbcType.Int).Value = iIdEmpleado;
                        if (Convert.ToInt32(cmdEmp.ExecuteScalar()) == 0)
                            throw new Exception($"El empleado #{iIdEmpleado} no existe en Tbl_Empleados.");
                    }

                    // Validar existencia del concepto
                    string sValidaConcepto = "SELECT COUNT(*) FROM Tbl_ConceptosNomina WHERE Cmp_iId_ConceptoNomina = ?";
                    using (var cmdCon = new OdbcCommand(sValidaConcepto, con, tx))
                    {
                        cmdCon.Parameters.Add("p1", OdbcType.Int).Value = iIdConcepto;
                        if (Convert.ToInt32(cmdCon.ExecuteScalar()) == 0)
                            throw new Exception($"El concepto #{iIdConcepto} no existe en Tbl_ConceptosNomina.");
                    }

                    // Insertar el movimiento
                    string sSql = @"
                        INSERT INTO Tbl_MovimientosNomina
                            (Cmp_iId_Nomina, Cmp_iId_Empleado, Cmp_iId_ConceptoNomina, Cmp_deMonto_MovimientoNomina)
                        VALUES (?, ?, ?, ?);";

                    using (var cmd = new OdbcCommand(sSql, con, tx))
                    {
                        cmd.Parameters.Add("p1", OdbcType.Int).Value = iIdNomina;
                        cmd.Parameters.Add("p2", OdbcType.Int).Value = iIdEmpleado;
                        cmd.Parameters.Add("p3", OdbcType.Int).Value = iIdConcepto;
                        cmd.Parameters.Add("p4", OdbcType.Decimal).Value = deMonto;
                        cmd.ExecuteNonQuery();
                    }

                    // Obtener el ID generado
                    int iNuevoId;
                    using (var cmdId = new OdbcCommand("SELECT LAST_INSERT_ID();", con, tx))
                        iNuevoId = Convert.ToInt32(cmdId.ExecuteScalar());

                    tx.Commit();
                    return iNuevoId;
                }
                catch (Exception ex)
                {
                    try { tx.Rollback(); } catch { }
                    throw new Exception("Error al insertar movimiento: " + ex.Message);
                }
                finally
                {
                    cn.cerrarConexion();
                }
            }
        }

        // ---------------------------------------------------------------------
        // SELECT: Listar movimientos por nómina
        // ---------------------------------------------------------------------
        public DataTable funObtenerMovimientosPorNomina(int iIdNomina, bool asc = true)
        {
            var dt = new DataTable();
            Cls_Conexion cn = new Cls_Conexion();
            string sOrden = asc ? "ASC" : "DESC";

            using (OdbcConnection con = cn.conexionDB())
            using (OdbcCommand cmd = new OdbcCommand($@"
                SELECT
                    m.Cmp_iId_MovimientoNomina     AS id_movimiento,
                    m.Cmp_iId_Nomina               AS id_nomina,
                    m.Cmp_iId_Empleado             AS id_empleado,
                    e.Cmp_sNombre_Empleado         AS empleado,
                    c.Cmp_sNombre_ConceptoNomina   AS concepto,
                    m.Cmp_deMonto_MovimientoNomina AS monto
                FROM Tbl_MovimientosNomina m
                INNER JOIN Tbl_Empleados e
                    ON e.Cmp_iId_Empleado = m.Cmp_iId_Empleado
                INNER JOIN Tbl_ConceptosNomina c
                    ON c.Cmp_iId_ConceptoNomina = m.Cmp_iId_ConceptoNomina
                WHERE m.Cmp_iId_Nomina = ?
                ORDER BY m.Cmp_iId_MovimientoNomina {sOrden};", con))
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

        // ---------------------------------------------------------------------
        // DELETE: Eliminar movimiento
        // ---------------------------------------------------------------------
        public void proEliminarMovimiento(int iIdMovimiento)
        {
            Cls_Conexion cn = new Cls_Conexion();
            using (OdbcConnection con = cn.conexionDB())
            using (OdbcCommand cmd = new OdbcCommand(@"
                DELETE FROM Tbl_MovimientosNomina
                WHERE Cmp_iId_MovimientoNomina = ?;", con))
            {
                cmd.Parameters.Add("p1", OdbcType.Int).Value = iIdMovimiento;
                cmd.ExecuteNonQuery();
            }
            cn.cerrarConexion();
        }

        // ---------------------------------------------------------------------
        // DELETE ALL: Vaciar tabla
        // ---------------------------------------------------------------------
        public void proEliminarTodosMovimientos()
        {
            Cls_Conexion cn = new Cls_Conexion();
            using (OdbcConnection con = cn.conexionDB())
            using (OdbcCommand cmd = new OdbcCommand("TRUNCATE TABLE Tbl_MovimientosNomina;", con))
            {
                cmd.ExecuteNonQuery();
            }
            cn.cerrarConexion();
        }
    }
}
