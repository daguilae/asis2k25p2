using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Odbc;
using Capa_Modelo_CB;


namespace Capa_Controlador_CB
{
    // ==========================================================
    // Capa Controlador: Cls_Controlador_Conciliacion
    // Autora: Paula Daniela Leonardo Paredes
    // ==========================================================
    public class Cls_Controlador_Conciliacion
    {
        private readonly Cls_Sentencias_Conciliacion gSentencias = new Cls_Sentencias_Conciliacion();

        // ==========================
        // Crear
        // ==========================
        public int GuardarConciliacion(int iAnio, int iMes, DateTime dFecha, int iIdCuenta,
                                       decimal deSaldoBanco, decimal deSaldoSistema,
                                       string sObservaciones, bool bActiva)
        {
            if (iAnio < 1900 || iAnio > 2100) throw new Exception("Año inválido.");
            if (iMes < 1 || iMes > 12) throw new Exception("Mes inválido.");

            // Evitar duplicados por período/cuenta
            if (gSentencias.ExisteConciliacionPeriodoCuenta(iAnio, iMes, iIdCuenta))
                throw new Exception("Ya existe una conciliación para ese período y cuenta.");

            return gSentencias.InsertarConciliacion(iAnio, iMes, dFecha, iIdCuenta,
                                                    deSaldoBanco, deSaldoSistema,
                                                    sObservaciones, bActiva);
        }

        // ==========================
        // Eliminar
        // ==========================
        public void EliminarConciliacion(int iIdConciliacion)
            => gSentencias.EliminarConciliacion(iIdConciliacion);

        // ==========================
        // Consultas
        // ==========================
        public DataTable ObtenerConciliaciones()
            => gSentencias.ObtenerConciliaciones();

        public DataTable ObtenerConciliacionPorId(int iIdConciliacion)
            => gSentencias.ObtenerConciliacionPorId(iIdConciliacion);

        // ==========================
        // Catálogos
        // ==========================
        public DataTable ObtenerBancos()
            => gSentencias.ObtenerBancos();

        public DataTable ObtenerCuentasPorBanco(int iIdBanco)
            => gSentencias.ObtenerCuentasPorBanco(iIdBanco);

        // ==========================
        // Util
        // ==========================
        public decimal CalcularDiferencia(decimal deSaldoBanco, decimal deSaldoSistema)
            => deSaldoBanco - deSaldoSistema;
    }
}


