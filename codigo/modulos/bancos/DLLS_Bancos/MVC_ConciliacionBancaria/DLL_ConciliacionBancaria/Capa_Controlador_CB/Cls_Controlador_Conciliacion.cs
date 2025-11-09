using System;
using System.Data;
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
        // Crear (INSERT)
        // ==========================
        public int GuardarConciliacion(int iAnio, int iMes, DateTime dFecha,
                                       int iIdBanco, int iIdCuenta,
                                       decimal deSaldoBanco, decimal deSaldoSistema,
                                       string sObservaciones, bool bActiva)
        {
            if (iAnio < 1900 || iAnio > 2100) throw new Exception("Año inválido.");
            if (iMes < 1 || iMes > 12) throw new Exception("Mes inválido.");
            if (iIdBanco <= 0) throw new Exception("Seleccione un banco válido.");
            if (iIdCuenta <= 0) throw new Exception("Seleccione una cuenta válida.");

            // Duplicado por período/cuenta
            if (gSentencias.ExisteConciliacionPeriodoCuenta(iAnio, iMes, iIdCuenta))
                throw new Exception("Ya existe una conciliación para ese período y cuenta.");

            return gSentencias.InsertarConciliacion(iAnio, iMes, dFecha,
                                                    iIdBanco, iIdCuenta,
                                                    deSaldoBanco, deSaldoSistema,
                                                    sObservaciones, bActiva);
        }

        // ==========================
        // Modificar (UPDATE)
        // ==========================
        public void ModificarConciliacion(int iIdConciliacion,
                                          int iAnio, int iMes, DateTime dFecha,
                                          int iIdBanco, int iIdCuenta,
                                          decimal deSaldoBanco, decimal deSaldoSistema,
                                          string sObservaciones, bool bActiva)
        {
            if (iIdConciliacion <= 0) throw new Exception("ID de conciliación inválido.");
            if (iAnio < 1900 || iAnio > 2100) throw new Exception("Año inválido.");
            if (iMes < 1 || iMes > 12) throw new Exception("Mes inválido.");
            if (iIdBanco <= 0) throw new Exception("Seleccione un banco válido.");
            if (iIdCuenta <= 0) throw new Exception("Seleccione una cuenta válida.");

            // Duplicado por período/cuenta EXCLUYENDO este registro
            if (gSentencias.ExisteConciliacionPeriodoCuentaExceptoId(iAnio, iMes, iIdCuenta, iIdConciliacion))
                throw new Exception("Ya existe una conciliación para ese período y cuenta.");

            gSentencias.ActualizarConciliacion(iIdConciliacion,
                                               iAnio, iMes, dFecha,
                                               iIdBanco, iIdCuenta,
                                               deSaldoBanco, deSaldoSistema,
                                               sObservaciones, bActiva);
        }

        // ==========================
        // Eliminar
        // ==========================
        public void EliminarConciliacion(int iIdConciliacion)
        {
            if (iIdConciliacion <= 0) throw new Exception("ID de conciliación inválido.");
            gSentencias.EliminarConciliacion(iIdConciliacion);
        }

        // ==========================
        // Consultas
        // ==========================
        public DataTable ObtenerConciliaciones() => gSentencias.ObtenerConciliaciones();

        public DataTable ObtenerConciliacionPorId(int iIdConciliacion)
        {
            if (iIdConciliacion <= 0) throw new Exception("ID de conciliación inválido.");
            return gSentencias.ObtenerConciliacionPorId(iIdConciliacion);
        }

        // ==========================
        // Catálogos
        // ==========================
        public DataTable ObtenerBancos() => gSentencias.ObtenerBancos();

        public DataTable ObtenerCuentasPorBanco(int iIdBanco)
        {
            if (iIdBanco <= 0) throw new Exception("Banco inválido.");
            return gSentencias.ObtenerCuentasPorBanco(iIdBanco);
        }

        // ==========================
        // Util
        // ==========================
        public decimal CalcularDiferencia(decimal deSaldoBanco, decimal deSaldoSistema)
            => deSaldoBanco - deSaldoSistema;
    }
}



