using System;
using System.Globalization;
using System.Text.RegularExpressions;
using Capa_Modelo_Reservas_Hotel;

namespace Capa_Controlador_Reservas_Hotel
{
    public class Cls_Pago_Tarjeta_Controlador
    {
        private readonly Cls_Sentencia_Pago_Tarjeta gModelo = new Cls_Sentencia_Pago_Tarjeta();

        
        // VALIDADORES INTERNOS 
        

        // Validar letras y espacios
        private bool funValidarSoloLetras(string sTexto)
        {
            return Regex.IsMatch(sTexto, @"^[a-zA-ZÁÉÍÓÚáéíóúÑñ ]+$");
        }

        // Validar números únicamente
        private bool funValidarSoloNumeros(string sTexto)
        {
            return Regex.IsMatch(sTexto, @"^[0-9]+$");
        }

        // Validar fecha de vencimiento
        private bool funTryParseFecha(string sInput, out DateTime dFecha)
        {
            dFecha = DateTime.MinValue;
            if (string.IsNullOrWhiteSpace(sInput)) return false;

            string[] formatos =
            {
                "MM/yy", "M/yy",
                "MM/yyyy", "M/yyyy",
                "yyyy-MM-dd",
                "yyyy/MM/dd"
            };

            return DateTime.TryParseExact(
                sInput.Trim(),
                formatos,
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out dFecha
            );
        }

       
        // INSERTAR PAGO TARJETA (validado)
        
        public (bool exito, string mensaje) funInsertarPagoTarjeta(int iIdPago, decimal deMonto,
                                                                  string sTitular, string sNumTarjeta,
                                                                  string sFechaVenc, string sCvc,
                                                                  string sCodPostal)
        {
            try
            {
                // Validación de ID
                if (iIdPago <= 0)
                    return (false, "El ID del pago principal no es válido.");

                // Validación Nombre Titular
                if (string.IsNullOrWhiteSpace(sTitular))
                    return (false, "Debe ingresar el nombre del titular.");

                if (!funValidarSoloLetras(sTitular))
                    return (false, "El nombre del titular solo puede contener letras y espacios.");

                // Validación Número tarjeta
                if (!funValidarSoloNumeros(sNumTarjeta))
                    return (false, "El número de tarjeta solo puede contener dígitos.");

                if (sNumTarjeta.Length < 13 || sNumTarjeta.Length > 19)
                    return (false, "El número de tarjeta debe contener entre 13 y 19 dígitos.");

                //  Validación CVC
                if (!funValidarSoloNumeros(sCvc))
                    return (false, "El CVC solo puede contener números.");

                if (sCvc.Length < 3 || sCvc.Length > 4)
                    return (false, "El CVC debe tener 3 o 4 dígitos.");

                // Validación Código postal
                if (!funValidarSoloNumeros(sCodPostal))
                    return (false, "El código postal solo puede contener números.");

                // Fecha vencimiento
                if (!funTryParseFecha(sFechaVenc, out DateTime dFechaVenc))
                    return (false, "Fecha de vencimiento inválida. Use MM/YY o MM/YYYY.");

                if (dFechaVenc < DateTime.Now.Date)
                    return (false, "La tarjeta está vencida.");

               
                bool lOK = gModelo.InsertarDetalleTarjeta(
                    iIdPago,
                    sTitular.Trim(),
                    sNumTarjeta.Trim(),
                    dFechaVenc,
                    Convert.ToInt32(sCvc),
                    Convert.ToInt32(sCodPostal)
                );

                return lOK
                    ? (true, "Pago con tarjeta registrado correctamente.")
                    : (false, "Ocurrió un error al guardar los datos del pago.");
            }
            catch (Exception ex)
            {
                return (false, "Error inesperado: " + ex.Message);
            }
        }
    }
}
