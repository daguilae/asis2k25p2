using System;
using System.Globalization;
using Capa_Modelo_Reservas_Hotel;

namespace Capa_Controlador_Reservas_Hotel
{
    public class Cls_Pago_Tarjeta_Controlador
    {
        private readonly Cls_Sentencia_Pago_Tarjeta modelo = new Cls_Sentencia_Pago_Tarjeta();

        // 
        //  MÉTODO PARA VALIDAR Y PARSEAR FECHA DE VENC. 
        // 
        private bool TryParseFechaVencimiento(string input, out DateTime fecha)
        {
            fecha = DateTime.MinValue;
            if (string.IsNullOrWhiteSpace(input)) return false;

            string[] formatos = { "MM/yy", "M/yy", "MM/yyyy", "M/yyyy", "yyyy-MM-dd", "yyyy/MM/dd" };
            return DateTime.TryParseExact(input.Trim(), formatos, CultureInfo.InvariantCulture, DateTimeStyles.None, out fecha);
        }

        // 
        // === REGISTRAR DETALLE DE PAGO CON TARJETA =========
        // 
        public (bool exito, string mensaje) InsertarPagoTarjeta(int idPago, decimal monto,
                                                                string nombreTitular, string numeroTarjeta,
                                                                string fechaVencimientoTexto, string cvc, string codigoPostal)
        {
            try
            {
                // Validaciones básicas 
                if (idPago <= 0)
                    return (false, "El ID del pago principal no es válido.");

                if (string.IsNullOrWhiteSpace(nombreTitular))
                    return (false, "Ingrese el nombre del titular.");

                if (string.IsNullOrWhiteSpace(numeroTarjeta))
                    return (false, "Ingrese el número de tarjeta.");

                if (!TryParseFechaVencimiento(fechaVencimientoTexto, out DateTime fechaVenc))
                    return (false, "Fecha de vencimiento inválida. Formatos válidos: MM/YY, MM/YYYY o YYYY-MM-DD.");

                if (!int.TryParse(cvc, out int iCvc) || iCvc <= 0)
                    return (false, "Ingrese un CVC válido (solo números).");

                if (!int.TryParse(codigoPostal, out int iCodigoPostal) || iCodigoPostal <= 0)
                    return (false, "Ingrese un código postal válido.");

                // Guardar detalle en Tbl_Pago_Tarjeta 
                bool ok = modelo.InsertarDetalleTarjeta(idPago, nombreTitular.Trim(), numeroTarjeta.Trim(), fechaVenc, iCvc, iCodigoPostal);

                if (ok)
                    return (true, "Pago con tarjeta registrado correctamente.");
                else
                    return (false, "Error al guardar los datos de la tarjeta.");
            }
            catch (Exception ex)
            {
                return (false, "Error inesperado al registrar el pago con tarjeta: " + ex.Message);
            }
        }
    }
}
