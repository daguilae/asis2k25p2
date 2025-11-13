/* 
 * Programador: Richard Anthony De León Milian
 * Carné: 0901-22-10245
 * Fecha de modificación: 11/11/2025
 * Archivo: Cls_ModeloNomina.cs
 * Descripción: Clase que maneja los cálculos y consultas de la nómina, 
 * obteniendo resúmenes por cuenta contable y generando datos listos para
 * trasladar a contabilidad.
 */

using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;

public static class Cls_ModeloNomina
{
    // Consulta SQL que resume la nómina por cuenta contable
    private const string sSQL_ResumenNominaPorCuenta = @"
        SELECT
            c.Fk_Codigo_Cuenta                   AS CodigoCuenta,
            cc.Cmp_CtaNombre                     AS NombreCuenta,
            cc.Cmp_CtaNaturaleza                 AS Naturaleza,  -- 1=Deudor, 0=Acreedor
            SUM(m.Cmp_deMonto_MovimientoNomina)  AS Monto
        FROM Tbl_Nomina n
        JOIN Tbl_MovimientosNomina m
             ON m.Cmp_iId_Nomina = n.Cmp_iId_Nomina
        JOIN Tbl_ConceptosNomina c
             ON c.Cmp_iId_ConceptoNomina = m.Cmp_iId_ConceptoNomina
        JOIN Tbl_Catalogo_Cuentas cc
             ON cc.Pk_Codigo_Cuenta = c.Fk_Codigo_Cuenta
        WHERE NOT (n.Cmp_dPeriodoFin_Nomina < ? OR n.Cmp_dPeriodoInicio_Nomina > ?)
        GROUP BY c.Fk_Codigo_Cuenta, cc.Cmp_CtaNombre, cc.Cmp_CtaNaturaleza
        HAVING c.Fk_Codigo_Cuenta IS NOT NULL;";

    // Obtiene un resumen de la nómina agrupado por cuenta (código, nombre, naturaleza, monto)
    public static List<(string sCodigoCuenta, string sNombreCuenta, int iNaturaleza, decimal deMonto)>
        funResumenNominaPorCuenta(DateTime dDesde, DateTime dHasta)
    {
        var lResultado = new List<(string, string, int, decimal)>();

        using (var cConn = Cls_Conexion.funAbrirConexion())
        using (var cCmd = new OdbcCommand(sSQL_ResumenNominaPorCuenta, cConn))
        {
            // Se asignan las fechas de inicio y fin como parámetros
            cCmd.Parameters.Add("p1", OdbcType.Date).Value = dDesde.Date;
            cCmd.Parameters.Add("p2", OdbcType.Date).Value = dHasta.Date;

            // Se ejecuta la consulta y se leen los resultados
            using (var dr = cCmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    lResultado.Add((
                        dr.GetString(0),                     // Código de cuenta
                        dr.GetString(1),                     // Nombre de cuenta
                        dr.GetInt32(2),                      // Naturaleza (1 deudor, 0 acreedor)
                        Convert.ToDecimal(dr.GetValue(3))    // Monto total
                    ));
                }
            }
        }
        return lResultado;
    }

    // Genera una lista de detalles consolidados para mostrar en la vista o enviar a contabilidad
    public static List<(string sCodigoCuenta, string sNombreCuenta, bool bTipo, decimal deValor)>
        funGenerarDetallesDesdeNomina(DateTime dDesde, DateTime dHasta)
    {
        var lBase = funResumenNominaPorCuenta(dDesde, dHasta);

        var lDet = lBase
            .Select(f => (
                sCodigoCuenta: f.sCodigoCuenta,
                sNombreCuenta: f.sNombreCuenta,
                bTipo: f.iNaturaleza == 1,    // Si es deudor, se trata como cargo
                deValor: f.deMonto
            ))
            .GroupBy(x => new { x.sCodigoCuenta, x.sNombreCuenta, x.bTipo })
            .Select(g => (
                g.Key.sCodigoCuenta,
                g.Key.sNombreCuenta,
                g.Key.bTipo,
                deValor: g.Sum(z => z.deValor)
            ))
            .OrderBy(x => x.sCodigoCuenta)
            .ToList();

        return lDet;
    }

    // Calcula los totales de cargos, abonos y su diferencia
    public static (decimal deCargos, decimal deAbonos, decimal deDiferencia)
        funTotales(List<(string sCodigoCuenta, string sNombreCuenta, bool bTipo, decimal deValor)> lDet)
    {
        decimal deCargos = lDet.Where(x => x.bTipo).Sum(x => x.deValor);
        decimal deAbonos = lDet.Where(x => !x.bTipo).Sum(x => x.deValor);
        return (deCargos, deAbonos, deCargos - deAbonos);
    }
}
