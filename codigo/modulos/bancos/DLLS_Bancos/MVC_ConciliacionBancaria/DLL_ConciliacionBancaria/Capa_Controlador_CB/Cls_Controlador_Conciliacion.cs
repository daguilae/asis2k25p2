using System;
using System.Data;
using System.Globalization;
using System.Text.RegularExpressions;
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

        // ------------------ CRUD ------------------

        public int GuardarConciliacion(int iAnio, int iMes, DateTime dFecha,
                                       int iIdBanco, int iIdCuenta,
                                       decimal deSaldoBanco, decimal deSaldoSistema,
                                       string sObservaciones, bool bActiva)
        {
            if (iAnio < 1900 || iAnio > 2100) throw new Exception("Año inválido.");
            if (iMes < 1 || iMes > 12) throw new Exception("Mes inválido.");
            if (iIdBanco <= 0) throw new Exception("Seleccione un banco válido.");
            if (iIdCuenta <= 0) throw new Exception("Seleccione una cuenta válida.");

            if (gSentencias.ExisteConciliacionPeriodoCuenta(iAnio, iMes, iIdCuenta))
                throw new Exception("Ya existe una conciliación para ese período y cuenta.");

            return gSentencias.InsertarConciliacion(iAnio, iMes, dFecha,
                                                    iIdBanco, iIdCuenta,
                                                    deSaldoBanco, deSaldoSistema,
                                                    sObservaciones, bActiva);
        }

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

            if (gSentencias.ExisteConciliacionPeriodoCuentaExceptoId(iAnio, iMes, iIdCuenta, iIdConciliacion))
                throw new Exception("Ya existe una conciliación para ese período y cuenta.");

            gSentencias.ActualizarConciliacion(iIdConciliacion,
                                               iAnio, iMes, dFecha,
                                               iIdBanco, iIdCuenta,
                                               deSaldoBanco, deSaldoSistema,
                                               sObservaciones, bActiva);
        }

        public void EliminarConciliacion(int iIdConciliacion)
        {
            if (iIdConciliacion <= 0) throw new Exception("ID de conciliación inválido.");
            gSentencias.EliminarConciliacion(iIdConciliacion);
        }

        // ------------------ Consultas ------------------

        public DataTable ObtenerConciliaciones() => gSentencias.ObtenerConciliaciones();

        public DataTable ObtenerConciliacionPorId(int iIdConciliacion)
        {
            if (iIdConciliacion <= 0) throw new Exception("ID de conciliación inválido.");
            return gSentencias.ObtenerConciliacionPorId(iIdConciliacion);
        }

        // ------------------ Catálogos ------------------

        public DataTable ObtenerBancos() => gSentencias.ObtenerBancos();

        public DataTable ObtenerCuentasPorBanco(int iIdBanco)
        {
            if (iIdBanco <= 0) throw new Exception("Banco inválido.");
            return gSentencias.ObtenerCuentasPorBanco(iIdBanco);
        }

        // ------------------ Util ------------------

        public decimal CalcularDiferencia(decimal deSaldoBanco, decimal deSaldoSistema)
            => deSaldoBanco - deSaldoSistema;

        // ------------------ Validaciones (centralizadas) ------------------

        private string NormalizarMonto(string sValor) => (sValor ?? string.Empty).Trim().Replace(',', '.');

        public bool EsMontoCon2Dec(string sValor)
        {
            string s = NormalizarMonto(sValor);
            return Regex.IsMatch(s, @"^\d+(\.\d{1,2})?$");
        }

        public decimal? TryParseMonto2Dec(string sValor)
        {
            string s = NormalizarMonto(sValor);
            if (!EsMontoCon2Dec(s)) return null;

            decimal de;
            if (decimal.TryParse(s, NumberStyles.Number, CultureInfo.InvariantCulture, out de))
                return de;

            return null;
        }


        public decimal ParseMonto2DecOrThrow(string sValor, string sNombreCampo)
        {
            string s = NormalizarMonto(sValor);
            if (!EsMontoCon2Dec(s))
                throw new Exception($"{sNombreCampo}: solamente se pueden poner números y dos decimales (ej. 1234.56).");
            return decimal.Parse(s, CultureInfo.InvariantCulture);
        }

        public (decimal deBanco, decimal deLibros) ValidarYParsearSaldosOrThrow(string sBanco, string sLibros)
        {
            var deBanco = ParseMonto2DecOrThrow(sBanco, "Saldo de banco");
            var deLibros = ParseMonto2DecOrThrow(sLibros, "Saldo de libros");
            return (deBanco, deLibros);
        }

        // Observaciones: solo texto y puntuación básica, sin ';' ni palabras SQL comunes.
        private static readonly Regex reObsSeguro = new Regex(
            @"^(?!.*\b(drop|delete|truncate|alter|create|update|insert|exec|execute|call|union|select)\b)[A-Za-zÁÉÍÓÚáéíóúÜüÑñ\s\.,:¡!¿\?""'\-\(\)]+$",
            RegexOptions.Compiled | RegexOptions.IgnoreCase
        );

        public string ValidarObservacionesSoloTextoOrThrow(string sObs, int iMaxLen = 500)
        {
            if (string.IsNullOrWhiteSpace(sObs)) return null;
            string s = sObs.Trim();
            if (s.Length > iMaxLen) throw new Exception($"Observaciones: máximo {iMaxLen} caracteres.");
            if (!reObsSeguro.IsMatch(s))
                throw new Exception("Observaciones: solo texto y puntuación básica (sin punto y coma ni palabras SQL).");
            return s;
        }
    }
}
