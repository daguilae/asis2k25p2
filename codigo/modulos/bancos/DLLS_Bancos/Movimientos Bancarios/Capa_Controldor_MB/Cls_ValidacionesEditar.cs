using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Capa_Controldor_MB
{
    public static class Cls_ValidacionesEditar
    {
        public static (bool ok, string msg) CamposObligatorios(
            object cuentaOrigenVal,
            object operacionVal,
            string numeroDocumento,
            string concepto)
        {
            if (cuentaOrigenVal == null)
                return (false, "Seleccione la cuenta origen.");
            if (operacionVal == null)
                return (false, "Seleccione la operación.");
            if (string.IsNullOrWhiteSpace(numeroDocumento))
                return (false, "Ingrese el número de documento.");
            if (string.IsNullOrWhiteSpace(concepto))
                return (false, "Ingrese el concepto.");
            return (true, string.Empty);
        }

        /// <summary>
        /// Acepta texto con separadores comunes y valida que sea decimal > 0.
        /// </summary>
        public static (bool ok, string msg, decimal monto) MontoPositivo(string textoMonto)
        {
            if (string.IsNullOrWhiteSpace(textoMonto))
                return (false, "Ingrese un monto.", 0m);

            // Normaliza espacios y separadores
            string t = textoMonto.Trim();

            // Intenta con cultura invariante y con cultura actual
            if (TryParseMonto(t, CultureInfo.InvariantCulture, out decimal m) ||
                TryParseMonto(t, CultureInfo.CurrentCulture, out m))
            {
                if (m > 0m) return (true, string.Empty, m);
                return (false, "Ingrese un monto válido mayor a cero.", 0m);
            }

            // Fallback: quitar separadores de miles frecuentes y reintentar
            t = t.Replace(" ", "").Replace(",", "").Replace(".", ","); // deja coma como decimal
            if (decimal.TryParse(t, NumberStyles.Number, new CultureInfo("es-GT"), out m))
            {
                if (m > 0m) return (true, string.Empty, m);
                return (false, "Ingrese un monto válido mayor a cero.", 0m);
            }

            return (false, "Formato de monto no válido.", 0m);
        }

        private static bool TryParseMonto(string input, CultureInfo ci, out decimal value)
        {
            return decimal.TryParse(input, NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, ci, out value);
        }

        public static string EstadoSeleccionado(object estadoItem)
        {
            string estado = estadoItem?.ToString()?.Trim();
            return string.IsNullOrEmpty(estado) ? "ACTIVO" : estado;
        }

        public static int? IntNullable(object selectedValue)
        {
            if (selectedValue == null || selectedValue == DBNull.Value) return null;
            try { return Convert.ToInt32(selectedValue); }
            catch { return null; }
        }

        public static int? CuentaDestinoNullable(bool comboHabilitado, object selectedValue)
        {
            if (!comboHabilitado) return null;
            return IntNullable(selectedValue);
        }

        public static bool CambioClave(int nuevaCuentaOrigen, int cuentaOrigenOriginal, int nuevaOperacion, int operacionOriginal)
        {
            return (nuevaCuentaOrigen != cuentaOrigenOriginal) || (nuevaOperacion != operacionOriginal);
        }
    }
}

