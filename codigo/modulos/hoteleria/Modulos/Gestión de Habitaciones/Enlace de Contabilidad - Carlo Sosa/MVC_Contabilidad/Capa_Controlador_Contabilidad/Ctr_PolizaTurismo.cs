using Capa_Modelo_Contabilidad;
using Capa_Controlador_Polizas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;

//Inicio del codigo - Carlo Sosa 0901-22-1106 - Fecha: 01/11/2025
namespace Capa_Controlador_Contabilidad
{
    public class Ctr_PolizaTurismo
    {
        private readonly Cls_EstadiaDao gDaoEstadia = new Cls_EstadiaDao();
        private readonly Cls_PolizaControlador gPolizaCtrl = new Cls_PolizaControlador();

        // Cuentas de detalle válidas
        private const string sCtaDebeTurismo = "1.2.1";  // Impuesto por cobrar
        private const string sCtaHaberTurismo = "2.5.1";  // Impuesto por pagar

        public int fun_ObtenerSiguienteId(DateTime dFecha)
        {
            return gPolizaCtrl.ObtenerSiguienteIdEncabezado(dFecha);
        }

        public bool fun_TrasladarPolizaTurismo(string sFechaInicio, string sFechaFin, string sConcepto, out string sMensaje)
        {
            sMensaje = string.Empty;

            if (string.IsNullOrWhiteSpace(sFechaInicio) || string.IsNullOrWhiteSpace(sFechaFin))
            {
                sMensaje = "Debe ingresar ambas fechas de rango.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(sConcepto))
            {
                sMensaje = "Debe ingresar un concepto para la póliza.";
                return false;
            }

            if (!DateTime.TryParseExact(sFechaInicio, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var dInicio) ||
                !DateTime.TryParseExact(sFechaFin, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var dFin))
            {
                sMensaje = "Las fechas deben tener el formato dd/MM/yyyy.";
                return false;
            }

            if (dInicio > dFin)
            {
                sMensaje = "La fecha inicial no puede ser mayor a la fecha final.";
                return false;
            }

            DataTable dt = gDaoEstadia.fun_ObtenerEstadiasPorRango(dInicio, dFin);
            if (dt.Rows.Count == 0)
            {
                sMensaje = "No hay estadías registradas en el rango seleccionado.";
                return false;
            }

            decimal deTotal = 0m;
            foreach (DataRow dr in dt.Rows)
                deTotal += Convert.ToDecimal(dr["Cmp_Monto_Total_Pago"]);

            decimal deImpuesto = Math.Round(deTotal * 0.10m, 2);
            DateTime dFechaPoliza = DateTime.Now;

            var lDetalles = new List<(string sCodigoCuenta, bool bTipo, decimal dValor)>
            {
                (sCtaDebeTurismo,  true,  deImpuesto),  // Debe
                (sCtaHaberTurismo, false, deImpuesto)   // Haber
            };

            bool bOk = gPolizaCtrl.InsertarPoliza(dFechaPoliza, sConcepto, lDetalles);

            sMensaje = bOk
                ? "Póliza trasladada correctamente."
                : "No hay datos para trasladar o ocurrió un error al insertar la póliza.";

            return bOk;
        }
    }
}
//Final del codigo - Carlo Sosa 0901-22-1106 - Fecha: 01/11/2025





