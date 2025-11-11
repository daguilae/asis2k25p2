using System;
using System.Text.RegularExpressions;
using Capa_Modelo_Reservas_Hotel;

namespace Capa_Controlador_Reservas_Hotel
{
    public class Cls_Pago_Transferencia_Controlador
    {
        private readonly Cls_Sentencia_Pago_Transferencia gModelo = new Cls_Sentencia_Pago_Transferencia();

        // Validar solo números
        private bool ValidarSoloNumeros(string valor)
        {
            return Regex.IsMatch(valor, @"^[0-9]+$");
        }

        // Validar solo letras
        private bool ValidarSoloLetras(string valor)
        {
            return Regex.IsMatch(valor, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ ]+$");
        }

        // Validación principal
        public (bool exito, string mensaje) fun_InsertarPagoTransferencia(
            int iIdPago, decimal deMonto, string sNumero, string sBanco, string sCuenta)
        {
            try
            {
                if (iIdPago <= 0)
                    return (false, "El ID del pago principal no es válido.");

                if (string.IsNullOrWhiteSpace(sNumero))
                    return (false, "Ingrese el número de transferencia.");

                if (!ValidarSoloNumeros(sNumero))
                    return (false, "El número de transferencia solo puede contener números.");

                if (sNumero.Length < 5)
                    return (false, "El número de transferencia es demasiado corto.");

                if (string.IsNullOrWhiteSpace(sBanco))
                    return (false, "Ingrese el nombre del banco de origen.");

                if (!ValidarSoloLetras(sBanco))
                    return (false, "El banco de origen solo puede contener letras.");

                if (string.IsNullOrWhiteSpace(sCuenta))
                    return (false, "Ingrese la cuenta de origen.");

                if (!ValidarSoloNumeros(sCuenta))
                    return (false, "La cuenta de origen solo puede contener números.");

                if (sCuenta.Length < 6)
                    return (false, "La cuenta de origen es demasiado corta.");

                bool ok = gModelo.InsertarDetalleTransferencia(
                    iIdPago,
                    sNumero.Trim(),
                    sBanco.Trim(),
                    sCuenta.Trim()
                );

                return ok
                    ? (true, "Pago por transferencia registrado correctamente.")
                    : (false, "Ocurrió un error al guardar el detalle.");
            }
            catch (Exception ex)
            {
                return (false, "Error inesperado: " + ex.Message);
            }
        }
    }
}
