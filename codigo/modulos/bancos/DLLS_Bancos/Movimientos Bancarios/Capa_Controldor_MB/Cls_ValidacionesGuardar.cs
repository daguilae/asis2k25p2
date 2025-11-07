using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Controldor_MB
{
    public class Cls_ValidacionesGuardar
    {
        public static (bool esValido, string mensaje, string campoError) fun_validar_formulario(
            object oCuentaOrigenSelectedValue,
            object oOperacionSelectedValue,
            string sNumeroDocumento,
            string sConcepto,
            string sMonto)
        {
            // Validar cuenta origen
            if (oCuentaOrigenSelectedValue == null)
            {
                return (false, "Seleccione una cuenta origen.", "cuentaOrigen");
            }

            // Validar operación
            if (oOperacionSelectedValue == null)
            {
                return (false, "Seleccione una operación.", "operacion");
            }

            // Validar número de documento
            if (string.IsNullOrWhiteSpace(sNumeroDocumento))
            {
                return (false, "Ingrese el número de documento.", "numeroDocumento");
            }

            // Validar concepto
            if (string.IsNullOrWhiteSpace(sConcepto))
            {
                return (false, "Ingrese el concepto del movimiento.", "concepto");
            }

            // Validar monto
            if (string.IsNullOrEmpty(sMonto))
            {
                return (false, "Ingrese un monto.", "monto");
            }

            // Conversión y validación de monto
            string sMontoTexto = sMonto.Trim().Replace(",", "").Replace(" ", "");
            if (!decimal.TryParse(sMontoTexto, System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out decimal deMontoPrincipal) || deMontoPrincipal <= 0)
            {
                return (false, "Ingrese un monto válido mayor a cero.\nEjemplos: 4, 4.00, 4,000.00", "monto");
            }

            return (true, "OK", "");
        }

        public static (bool esValido, string mensaje, decimal monto) fun_validar_monto(string sTextoMonto)
        {
            if (string.IsNullOrEmpty(sTextoMonto))
            {
                return (false, "Ingrese un monto.", 0);
            }

            string sMontoTexto = sTextoMonto.Trim().Replace(",", "").Replace(" ", "");
            if (!decimal.TryParse(sMontoTexto, System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out decimal deMontoPrincipal) || deMontoPrincipal <= 0)
            {
                return (false, "Ingrese un monto válido mayor a cero.\nEjemplos: 4, 4.00, 4,000.00", 0);
            }

            return (true, "OK", deMontoPrincipal);
        }

        public static (bool esValido, string mensaje) fun_validar_cuenta_destino(object oCuentaDestinoSelectedValue, bool bCuentaDestinoHabilitada)
        {
            if (bCuentaDestinoHabilitada && oCuentaDestinoSelectedValue == null)
            {
                return (false, "Cuando está habilitada, debe seleccionar una cuenta destino.");
            }
            return (true, "OK");
        }

        public static (bool ok, string msg) fun_campos_obligatorios(object oCuenta, object oOperacion, string sDoc, string sConcepto)
        {
            if (oCuenta == null) return (false, "Seleccione la cuenta origen.");
            if (oOperacion == null) return (false, "Seleccione la operación.");
            if (string.IsNullOrWhiteSpace(sDoc)) return (false, "Ingrese el número de documento.");
            if (string.IsNullOrWhiteSpace(sConcepto)) return (false, "Ingrese el concepto.");
            return (true, null);
        }

        public static (bool ok, string msg, decimal monto) fun_monto_positivo(string sTexto)
        {
            var sLimpio = (sTexto ?? "").Replace(",", "").Trim();
            if (!decimal.TryParse(sLimpio, out var deMonto) || deMonto <= 0)
                return (false, "Ingrese un monto válido mayor a cero.", 0m);
            return (true, null, deMonto);
        }
    }
}
