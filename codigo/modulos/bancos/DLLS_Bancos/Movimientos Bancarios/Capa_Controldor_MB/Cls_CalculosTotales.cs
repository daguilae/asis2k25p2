using System;
using System.Collections.Generic;

namespace Capa_Controldor_MB
{
    public static class Cls_ValidacionesTotales
    {
        public static (bool esValido, string mensaje) ValidarGridParaCalculos(int columnCount, bool contieneDebe, bool contieneHaber)
        {
            if (columnCount == 0)
                return (false, "El grid no tiene columnas configuradas.");

            if (!contieneDebe)
                return (false, "No se encontró la columna 'Debe'.");

            if (!contieneHaber)
                return (false, "No se encontró la columna 'Haber'.");

            return (true, "OK");
        }

        public static (bool esValido, decimal valor) ObtenerValorDecimalDeCelda(object valorCelda)
        {
            if (valorCelda == null || valorCelda == DBNull.Value || string.IsNullOrEmpty(valorCelda.ToString()))
                return (false, 0);

            if (decimal.TryParse(valorCelda.ToString(), out decimal valor))
                return (true, valor);

            return (false, 0);
        }

        public static bool EsFilaValidaParaCalculo(bool esNuevaFila, string estado = "ACTIVO")
        {
            if (esNuevaFila)
                return false;

            // Si se proporciona estado, validar que no esté anulado
            if (!string.IsNullOrEmpty(estado) && estado == "ANULADO")
                return false;

            return true;
        }

        public static (decimal totalDebe, decimal totalHaber, int filasProcesadas) CalcularTotalesBasicos(
            List<(decimal debe, decimal haber)> movimientos)
        {
            decimal totalDebe = 0;
            decimal totalHaber = 0;
            int filasProcesadas = 0;

            foreach (var movimiento in movimientos)
            {
                totalDebe += movimiento.debe;
                totalHaber += movimiento.haber;
                filasProcesadas++;
            }

            return (totalDebe, totalHaber, filasProcesadas);
        }

        public static (decimal totalDebe, decimal totalHaber, int filasProcesadas) CalcularTotalesSoloActivos(
            List<(decimal debe, decimal haber, string estado)> movimientos)
        {
            decimal totalDebe = 0;
            decimal totalHaber = 0;
            int filasProcesadas = 0;

            foreach (var movimiento in movimientos)
            {
                // Solo sumar si el estado no es "ANULADO"
                if (movimiento.estado != "ANULADO")
                {
                    totalDebe += movimiento.debe;
                    totalHaber += movimiento.haber;
                    filasProcesadas++;
                }
            }

            return (totalDebe, totalHaber, filasProcesadas);
        }

        public static (decimal diferencia, string textoDiferencia, string color) CalcularDiferencia(
            decimal totalDebe, decimal totalHaber)
        {
            decimal diferencia = totalDebe - totalHaber;

            string textoDiferencia = $"Diferencia: {diferencia:N2}";
            string color = "Black";

            if (diferencia > 0)
            {
                color = "DarkRed";
                textoDiferencia = $"Diferencia: +{diferencia:N2}";
            }
            else if (diferencia < 0)
            {
                color = "DarkGreen";
                textoDiferencia = $"Diferencia: {diferencia:N2}";
            }

            return (diferencia, textoDiferencia, color);
        }

        public static string FormatearTextoTotal(string tipo, decimal valor)
        {
            return $"{tipo}: {valor:N2}";
        }

        public static void MostrarLogCalculo(string metodo, decimal totalDebe, decimal totalHaber, int filasProcesadas)
        {
            Console.WriteLine($"{metodo} - Débito: {totalDebe:N2}, Crédito: {totalHaber:N2}, Filas procesadas: {filasProcesadas}");
        }
    }
}