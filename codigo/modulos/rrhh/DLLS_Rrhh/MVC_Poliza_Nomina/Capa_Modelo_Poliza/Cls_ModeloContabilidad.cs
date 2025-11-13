/* 
 * Programador: Richard Anthony De León Milian
 * Carné: 0901-22-10245
 * Fecha de modificación: 11/11/2025
 * Archivo: Cls_ModeloContabilidad.cs
 * Descripción: Clase que maneja las operaciones principales del módulo de Contabilidad,
 *               como insertar pólizas (encabezado y detalle) y obtener el siguiente ID
 *               correlativo por mes y año desde la base de datos.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

public class Cls_ModeloContabilidad
{
    // --- CONSULTAS SQL utilizadas dentro de esta clase ---
    // Obtiene el siguiente código de póliza según el mes y año de la fecha
    private const string sSQL_ObtenerSiguienteIdEnc = @"
    SELECT IFNULL(MAX(Pk_EncCodigo_Poliza) + 1, 1)
    FROM Tbl_EncabezadoPoliza
    WHERE YEAR(Pk_Fecha_Poliza) = YEAR(?)
        AND MONTH(Pk_Fecha_Poliza) = MONTH(?);";

    // Inserta un nuevo registro en el encabezado de pólizas
    private const string sSQL_InsertarEncabezado = @"
    INSERT INTO Tbl_EncabezadoPoliza
        (Pk_EncCodigo_Poliza, Pk_Fecha_Poliza, Cmp_Concepto_Poliza, Cmp_Valor_Poliza, Cmp_Estado_Poliza)
    VALUES ( ?, ?, ?, 0, 1 );";

    // Inserta los detalles (cuentas contables, tipo y valor) de una póliza
    private const string sSQL_InsertarDetalle = @"
    INSERT INTO Tbl_DetallePoliza
        (PkFk_EncCodigo_Poliza, PkFk_Fecha_Poliza, PkFk_Codigo_Cuenta, Cmp_Tipo_Poliza, Cmp_Valor_Poliza)
    VALUES ( ?, ?, ?, ?, ? );";

    // Actualiza el valor total del encabezado sumando los montos de los detalles
    private const string sSQL_ActualizarTotalEnc = @"
    UPDATE Tbl_EncabezadoPoliza e
    SET e.Cmp_Valor_Poliza = (
        SELECT IFNULL(SUM(d.Cmp_Valor_Poliza),0)
        FROM Tbl_DetallePoliza d
        WHERE d.PkFk_EncCodigo_Poliza = e.Pk_EncCodigo_Poliza
            AND d.PkFk_Fecha_Poliza   = e.Pk_Fecha_Poliza
    )
    WHERE e.Pk_EncCodigo_Poliza = ?
        AND e.Pk_Fecha_Poliza     = ?;";

    // ---------------------------------------------------------
    // 1) Obtiene el siguiente ID de encabezado de póliza (autonumérico por mes/año)
    // ---------------------------------------------------------
    public static int funObtenerSiguienteIdEncabezado(DateTime dFecha)
    {
        using (var cConn = Cls_Conexion.funAbrirConexion())
        using (var cCmd = new OdbcCommand(sSQL_ObtenerSiguienteIdEnc, cConn))
        {
            // Parámetros: la fecha se usa dos veces (para comparar mes y año)
            cCmd.Parameters.Add("p1", OdbcType.Date).Value = dFecha.Date;
            cCmd.Parameters.Add("p2", OdbcType.Date).Value = dFecha.Date;

            // Ejecuta la consulta y obtiene el siguiente número correlativo
            object oResult = cCmd.ExecuteScalar();
            int iNext = (oResult != null && oResult != DBNull.Value) ? Convert.ToInt32(oResult) : 1;

            return iNext;
        }
    }

    // ---------------------------------------------------------
    // 2) Inserta una póliza completa (encabezado + detalles + total)
    // ---------------------------------------------------------
    public static bool funInsertarPoliza(
        DateTime dFecha,
        string sConcepto,
        List<(string sCodigoCuenta, bool bTipo, decimal deValor)> lDetalles)
    {
        using (var cConn = Cls_Conexion.funAbrirConexion())
        using (var cTran = cConn.BeginTransaction()) // Se inicia transacción para asegurar atomicidad
        {
            try
            {
                // Se obtiene el ID correlativo del encabezado
                int iId = funObtenerSiguienteIdEncabezado(dFecha);

                // -----------------------------
                // Inserción del Encabezado
                // -----------------------------
                using (var cCmdEnc = new OdbcCommand(sSQL_InsertarEncabezado, cConn, cTran))
                {
                    cCmdEnc.Parameters.Add("p1", OdbcType.Int).Value = iId;
                    cCmdEnc.Parameters.Add("p2", OdbcType.Date).Value = dFecha.Date;
                    cCmdEnc.Parameters.Add("p3", OdbcType.VarChar, 200).Value = sConcepto ?? string.Empty;
                    cCmdEnc.ExecuteNonQuery();
                }

                // -----------------------------
                // Inserción de los Detalles
                // -----------------------------
                foreach (var det in lDetalles)
                {
                    using (var cCmdDet = new OdbcCommand(sSQL_InsertarDetalle, cConn, cTran))
                    {
                        cCmdDet.Parameters.Add("p1", OdbcType.Int).Value = iId;
                        cCmdDet.Parameters.Add("p2", OdbcType.Date).Value = dFecha.Date;
                        cCmdDet.Parameters.Add("p3", OdbcType.VarChar, 20).Value = det.sCodigoCuenta;
                        cCmdDet.Parameters.Add("p4", OdbcType.Bit).Value = det.bTipo;     // 1 = Cargo, 0 = Abono
                        cCmdDet.Parameters.Add("p5", OdbcType.Double).Value = Convert.ToDouble(det.deValor);
                        cCmdDet.ExecuteNonQuery();
                    }
                }

                // -----------------------------
                // Actualización del total del Encabezado
                // -----------------------------
                using (var cCmdTot = new OdbcCommand(sSQL_ActualizarTotalEnc, cConn, cTran))
                {
                    cCmdTot.Parameters.Add("p1", OdbcType.Int).Value = iId;
                    cCmdTot.Parameters.Add("p2", OdbcType.Date).Value = dFecha.Date;
                    cCmdTot.ExecuteNonQuery();
                }

                // Confirma la transacción (se guardan los cambios)
                cTran.Commit();
                return true;
            }
            catch
            {
                // En caso de error, se deshacen los cambios
                cTran.Rollback();
                throw;
            }
        }
    }
}
