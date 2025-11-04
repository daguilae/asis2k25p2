using System;
using System.Globalization;
using Capa_Modelo_Reservas_Hotel;

namespace Capa_Controlador_Reservas_Hotel
{
    public class Cls_Pago_Tarjeta_Controlador
    {
        private readonly Cls_Sentencia_Pago_Tarjeta modelo = new Cls_Sentencia_Pago_Tarjeta();

        // ==================== MÉTODO AUXILIAR ====================
        private bool TryParseFechaVencimiento(string input, out DateTime fecha)
        {
            fecha = DateTime.MinValue;
            if (string.IsNullOrWhiteSpace(input)) return false;

            string[] formatos = { "MM/yy", "M/yy", "MM/yyyy", "M/yyyy", "yyyy-MM-dd", "yyyy/MM/dd" };

            return DateTime.TryParseExact(input.Trim(), formatos, CultureInfo.InvariantCulture, DateTimeStyles.None, out fecha);
        }

        // ==================== GUARDAR ====================
        public void GuardarPagoTarjeta(int fkPago, string nombreTitular, string numeroTarjeta, string fechaVencimientoTexto, string cvc, string codigoPostal)
        {
            if (fkPago <= 0)
                throw new ArgumentException("No se recibió el ID del pago principal.");

            if (string.IsNullOrWhiteSpace(nombreTitular))
                throw new ArgumentException("Debe ingresar el nombre del titular.");

            if (string.IsNullOrWhiteSpace(numeroTarjeta))
                throw new ArgumentException("Debe ingresar el número de la tarjeta.");

            if (!TryParseFechaVencimiento(fechaVencimientoTexto, out DateTime fechaVenc))
                throw new ArgumentException("Fecha de vencimiento inválida. Use formato MM/YY o MM/YYYY.");

            if (!int.TryParse(cvc, out int iCvc) || iCvc <= 0)
                throw new ArgumentException("CVC inválido. Debe ser un número positivo.");

            if (!int.TryParse(codigoPostal, out int iCodigoPostal) || iCodigoPostal <= 0)
                throw new ArgumentException("Código postal inválido.");

            modelo.InsertarPagoTarjeta(fkPago, nombreTitular.Trim(), numeroTarjeta.Trim(), fechaVenc, iCvc, iCodigoPostal);
        }

        // ==================== MODIFICAR ====================
        public void ModificarPagoTarjeta(int fkPago, string nombreTitular, string numeroTarjeta, string fechaVencimientoTexto, string cvc, string codigoPostal)
        {
            if (fkPago <= 0)
                throw new ArgumentException("Debe existir un ID de pago para modificar.");

            if (!TryParseFechaVencimiento(fechaVencimientoTexto, out DateTime fechaVenc))
                throw new ArgumentException("Fecha de vencimiento inválida.");

            int.TryParse(cvc, out int iCvc);
            int.TryParse(codigoPostal, out int iCodigoPostal);

            modelo.ModificarPagoTarjeta(fkPago, nombreTitular.Trim(), numeroTarjeta.Trim(), fechaVenc, iCvc, iCodigoPostal);
        }
    }
}
