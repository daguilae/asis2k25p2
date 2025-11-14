/* 
 * Programador: Richard Anthony De León Milian
 * Carné: 0901-22-10245
 * Fecha de modificación: 11/11/2025
 * Archivo: Cls_ControladorPoliza.cs
 * Descripción: Clase del controlador encargada de coordinar las operaciones entre
 * los modelos de Nómina y Contabilidad, generando detalles, totales y pólizas completas.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Controlador_Poliza
{
    public static class Cls_ControladorPoliza
    {
        // Genera los detalles de la póliza para mostrar en la grilla
        public static List<Cls_DetalleLineaVm> funGenerarDetallesVm(DateTime dDesde, DateTime dHasta)
        {
            var lModelo = Cls_ModeloNomina.funGenerarDetallesDesdeNomina(dDesde, dHasta);

            var lVm = lModelo.Select(x => new Cls_DetalleLineaVm
            {
                sCodigoCuenta = x.sCodigoCuenta,
                sNombreCuenta = x.sNombreCuenta,
                bTipo = x.bTipo,
                sTipoTexto = x.bTipo ? "Cargo" : "Abono",
                deValor = x.deValor
            })
            .OrderBy(v => v.sCodigoCuenta)
            .ToList();

            return lVm;
        }

        // Calcula los totales de cargos, abonos y diferencia para la vista
        public static (decimal deCargos, decimal deAbonos, decimal deDiferencia) funTotalesVm(List<Cls_DetalleLineaVm> lVm)
        {
            var lDet = lVm.Select(v => (v.sCodigoCuenta, v.sNombreCuenta, v.bTipo, v.deValor)).ToList();
            return Cls_ModeloNomina.funTotales(lDet);
        }

        // Obtiene el siguiente ID de póliza (solo previsualización)
        public static int funPrevisualizarId(DateTime dFecha)
        {
            return Cls_ModeloContabilidad.funObtenerSiguienteIdEncabezado(dFecha);
        }

        // Inserta una póliza completa con encabezado y detalles
        public static bool funInsertarPoliza(DateTime dFecha, string sConcepto, List<Cls_DetalleLineaVm> lVm, out string sMensaje)
        {
            sMensaje = "";

            if (lVm == null || lVm.Count == 0)
            {
                sMensaje = "No hay detalles para trasladar.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(sConcepto))
            {
                sMensaje = "Debe ingresar un concepto para la póliza.";
                return false;
            }

            var t = funTotalesVm(lVm);
            // Validación opcional: exigir póliza balanceada
            // if (t.deDiferencia != 0) { sMensaje = "La póliza no está balanceada."; return false; }

            var lDetalles = lVm.Select(v => (v.sCodigoCuenta, v.bTipo, v.deValor)).ToList();

            bool bOk = Cls_ModeloContabilidad.funInsertarPoliza(dFecha, sConcepto, lDetalles);
            if (!bOk) sMensaje = "No se pudo insertar la póliza.";
            return bOk;
        }

        // Genera un concepto sugerido según el rango de fechas
        public static string funConceptoSugerido(DateTime dDesde, DateTime dHasta)
        {
            return $"Póliza de nómina del {dDesde:yyyy-MM-dd} al {dHasta:yyyy-MM-dd}";
        }
    }
}
