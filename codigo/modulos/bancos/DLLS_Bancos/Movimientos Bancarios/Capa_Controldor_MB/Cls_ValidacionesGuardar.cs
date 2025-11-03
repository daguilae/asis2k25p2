using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Controldor_MB
{
    public class Cls_ValidacionesGuardar
    {
        public static (bool esValido, string mensaje, string campoError) ValidarFormulario(
            object cuentaOrigenSelectedValue,
            object operacionSelectedValue,
            string numeroDocumento,
            string concepto,
            string monto)
        {
            // Validar cuenta origen
            if (cuentaOrigenSelectedValue == null)
            {
                return (false, "Seleccione una cuenta origen.", "cuentaOrigen");
            }

            // Validar operación
            if (operacionSelectedValue == null)
            {
                return (false, "Seleccione una operación.", "operacion");
            }

            // Validar número de documento
            if (string.IsNullOrWhiteSpace(numeroDocumento))
            {
                return (false, "Ingrese el número de documento.", "numeroDocumento");
            }

            // Validar concepto
            if (string.IsNullOrWhiteSpace(concepto))
            {
                return (false, "Ingrese el concepto del movimiento.", "concepto");
            }

            // Validar monto
            if (string.IsNullOrEmpty(monto))
            {
                return (false, "Ingrese un monto.", "monto");
            }

            // Conversión y validación de monto
            string sMontoTexto = monto.Trim().Replace(",", "").Replace(" ", "");
            if (!decimal.TryParse(sMontoTexto, System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out decimal deMontoPrincipal) || deMontoPrincipal <= 0)
            {
                return (false, "Ingrese un monto válido mayor a cero.\nEjemplos: 4, 4.00, 4,000.00", "monto");
            }

            return (true, "OK", "");
        }

        public static (bool esValido, string mensaje, decimal monto) ValidarMonto(string textoMonto)
        {
            if (string.IsNullOrEmpty(textoMonto))
            {
                return (false, "Ingrese un monto.", 0);
            }

            string sMontoTexto = textoMonto.Trim().Replace(",", "").Replace(" ", "");
            if (!decimal.TryParse(sMontoTexto, System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out decimal deMontoPrincipal) || deMontoPrincipal <= 0)
            {
                return (false, "Ingrese un monto válido mayor a cero.\nEjemplos: 4, 4.00, 4,000.00", 0);
            }

            return (true, "OK", deMontoPrincipal);
        }

        public static (bool esValido, string mensaje) ValidarCuentaDestino(object cuentaDestinoSelectedValue, bool cuentaDestinoHabilitada)
        {
            if (cuentaDestinoHabilitada && cuentaDestinoSelectedValue == null)
            {
                return (false, "Cuando está habilitada, debe seleccionar una cuenta destino.");
            }
            return (true, "OK");
        }

        public static (bool ok, string msg) CamposObligatorios(object cuenta, object operacion, string doc, string concepto)
        {
            if (cuenta == null) return (false, "Seleccione la cuenta origen.");
            if (operacion == null) return (false, "Seleccione la operación.");
            if (string.IsNullOrWhiteSpace(doc)) return (false, "Ingrese el número de documento.");
            if (string.IsNullOrWhiteSpace(concepto)) return (false, "Ingrese el concepto.");
            return (true, null);
        }

        public static (bool ok, string msg, decimal monto) MontoPositivo(string texto)
        {
            var limpio = (texto ?? "").Replace(",", "").Trim();
            if (!decimal.TryParse(limpio, out var m) || m <= 0)
                return (false, "Ingrese un monto válido mayor a cero.", 0m);
            return (true, null, m);
        }
    }
}