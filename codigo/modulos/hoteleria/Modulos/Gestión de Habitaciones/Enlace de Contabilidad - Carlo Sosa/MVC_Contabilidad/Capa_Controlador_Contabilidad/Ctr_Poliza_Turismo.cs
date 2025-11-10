using Capa_Modelo_Contabilidad;
using Capa_Controlador_Polizas;
using System;
using System.Collections.Generic;
using System.Data;
//inicio del codigo- Carlo Sosa 0901-22-1106- Fecha: 01/11/2025

namespace Capa_Controlador_Contabilidad
{
    public class Ctr_Poliza_Turismo
    {
        Dao_Estadia cEstadia = new Dao_Estadia();
        Cls_PolizaControlador cPolizaCtrl = new Cls_PolizaControlador();

        public int ObtenerSiguienteId(DateTime fecha)
        {
            return cPolizaCtrl.ObtenerSiguienteIdEncabezado(fecha);
        }

        public int ContarEstadias(DateTime fechaInicio, DateTime fechaFin)
        {
            DataTable dtEstadias = cEstadia.ObtenerEstadiasPorRango(fechaInicio, fechaFin);
            return dtEstadias.Rows.Count;
        }

        public bool TrasladarPolizaTurismo(DateTime fechaInicio, DateTime fechaFin, DateTime fechaPoliza, string concepto)
        {
            DataTable dtEstadias = cEstadia.ObtenerEstadiasPorRango(fechaInicio, fechaFin);
            if (dtEstadias.Rows.Count == 0) return false;

            decimal total = 0;
            foreach (DataRow row in dtEstadias.Rows)
                total += Convert.ToDecimal(row["Cmp_Monto_Total_Pago"]);

            decimal impuesto = total * 0.10m;

            var detalles = new List<(string sCodigoCuenta, bool bTipo, decimal dValor)>
            {
                ("1.2.1", true, impuesto),
                ("2.5.1", false, impuesto)
            };

            return cPolizaCtrl.InsertarPoliza(fechaPoliza, concepto, detalles);
        }
    }
}


//Fin del codigo- Carlo Sosa 0901-22-1106- Fecha: 01/11/2025




