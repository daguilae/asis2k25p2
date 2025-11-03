using System;
using System.Collections.Generic;
using Capa_Modelo_Contabilidad;
//inicio del codigo- Carlo Sosa 0901-22-1106- Fecha: 01/11/2025

namespace Capa_Controlador_Contabilidad
{
    public class Ctr_Poliza_Turismo
    {
        readonly Dao_Estadia _daoE = new Dao_Estadia();
        readonly Dao_CuentasTurismo _daoCfg = new Dao_CuentasTurismo();

        public (bool ok, string msg) GenerarSiguiente(DateTime desde, DateTime hasta, DateTime fechaPoliza, string conceptoBase)
        {
            var cfg = _daoCfg.ObtenerConfig();
            if (cfg.Debe == 0 || cfg.Haber == 0) return (false, "Configura las cuentas de turismo.");

            var lista = _daoE.ListarEnRango(desde, hasta);
            lista.Sort((a, b) =>
            {
                int c = a.CheckOut.CompareTo(b.CheckOut);
                return c != 0 ? c : a.Id.CompareTo(b.Id);
            });

            foreach (var e in lista)
            {
                if (_daoE.ExistePolizaParaEstadia(e.Id)) continue;

                var impuesto = Math.Round(e.Monto * 0.10m, 2, MidpointRounding.AwayFromZero);

                string concepto = string.IsNullOrWhiteSpace(conceptoBase)
                    ? "Turismo Estadia " + e.Id
                    : conceptoBase.Trim() + " - Turismo Estadia " + e.Id;

                int encId = _daoE.InsertarPoliza(fechaPoliza, concepto, impuesto, cfg.Debe, cfg.Haber);
                return (true, "Póliza " + encId + " creada para estadía " + e.Id);
            }

            return (false, "Ya no hay más pólizas por trasladar en ese rango.");
        }
    }
}

//Fin del codigo- Carlo Sosa 0901-22-1106- Fecha: 01/11/2025









