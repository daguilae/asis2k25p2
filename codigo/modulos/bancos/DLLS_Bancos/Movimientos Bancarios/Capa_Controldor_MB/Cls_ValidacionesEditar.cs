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
        public static (bool ok, string msg) fun_campos_obligatorios(
            object oCuentaOrigenVal,
            object oOperacionVal,
            string sNumeroDocumento,
            string sConcepto)
        {
            if (oCuentaOrigenVal == null)
                return (false, "Seleccione la cuenta origen.");
            if (oOperacionVal == null)
                return (false, "Seleccione la operación.");
            if (string.IsNullOrWhiteSpace(sNumeroDocumento))
                return (false, "Ingrese el número de documento.");
            if (string.IsNullOrWhiteSpace(sConcepto))
                return (false, "Ingrese el concepto.");
            return (true, string.Empty);
        }

        /// <summary>
        /// Acepta texto con separadores comunes y valida que sea decimal > 0.
        /// </summary>
        public static (bool ok, string msg, decimal monto) fun_monto_positivo(string sTextoMonto)
        {
            if (string.IsNullOrWhiteSpace(sTextoMonto))
                return (false, "Ingrese un monto.", 0m);

            // Normaliza espacios y separadores
            string sTexto = sTextoMonto.Trim();

            // Intenta con cultura invariante y con cultura actual
            if (fun_try_parse_monto(sTexto, CultureInfo.InvariantCulture, out decimal deMonto) ||
                fun_try_parse_monto(sTexto, CultureInfo.CurrentCulture, out deMonto))
            {
                if (deMonto > 0m) return (true, string.Empty, deMonto);
                return (false, "Ingrese un monto válido mayor a cero.", 0m);
            }

            // Fallback: quitar separadores de miles frecuentes y reintentar
            sTexto = sTexto.Replace(" ", "").Replace(",", "").Replace(".", ","); // deja coma como decimal
            if (decimal.TryParse(sTexto, NumberStyles.Number, new CultureInfo("es-GT"), out deMonto))
            {
                if (deMonto > 0m) return (true, string.Empty, deMonto);
                return (false, "Ingrese un monto válido mayor a cero.", 0m);
            }

            return (false, "Formato de monto no válido.", 0m);
        }

        private static bool fun_try_parse_monto(string sInput, CultureInfo oCulture, out decimal deValue)
        {
            return decimal.TryParse(
                sInput,
                NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign,
                oCulture,
                out deValue
            );
        }

        public static string fun_estado_seleccionado(object oEstadoItem)
        {
            string sEstado = oEstadoItem?.ToString()?.Trim();
            return string.IsNullOrEmpty(sEstado) ? "ACTIVO" : sEstado;
        }

        public static int? fun_int_nullable(object oSelectedValue)
        {
            if (oSelectedValue == null || oSelectedValue == DBNull.Value) return null;
            try { return Convert.ToInt32(oSelectedValue); }
            catch { return null; }
        }

        public static int? fun_cuenta_destino_nullable(bool bComboHabilitado, object oSelectedValue)
        {
            if (!bComboHabilitado) return null;
            return fun_int_nullable(oSelectedValue);
        }

        public static bool fun_cambio_clave(int iNuevaCuentaOrigen, int iCuentaOrigenOriginal, int iNuevaOperacion, int iOperacionOriginal)
        {
            return (iNuevaCuentaOrigen != iCuentaOrigenOriginal) || (iNuevaOperacion != iOperacionOriginal);
        }
    }
}
