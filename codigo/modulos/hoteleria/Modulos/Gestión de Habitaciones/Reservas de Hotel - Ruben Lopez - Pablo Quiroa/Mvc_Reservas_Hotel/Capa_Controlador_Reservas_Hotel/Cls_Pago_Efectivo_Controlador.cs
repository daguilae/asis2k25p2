using System;
using System.Text.RegularExpressions;
using Capa_Modelo_Reservas_Hotel;

namespace Capa_Controlador_Reservas_Hotel
{
    public class Cls_Pago_Efectivo_Controlador
    {
        private readonly Cls_Sentencia_Pago_Efectivo gModelo = new Cls_Sentencia_Pago_Efectivo();

        // ================================
        // VALIDACIONES
        // ================================

        private bool fun_ValidarSoloNumeros(string sTexto)
        {
            return Regex.IsMatch(sTexto, @"^[0-9]+$");
        }

        private bool fun_ValidarLetrasYNumeros(string sTexto)
        {
            return Regex.IsMatch(sTexto, @"^[a-zA-Z0-9ñÑáéíóúÁÉÍÓÚ ]*$");
        }

        
        // INSERTAR PAGO EFECTIVO
       
        public (bool exito, string mensaje) funInsertarPagoEfectivo(
            int iIdPago, decimal deMonto, string sRecibo, string sObs)
        {
            try
            {
                // -------- VALIDACIONES --------

                if (iIdPago <= 0)
                    return (false, "El ID del pago principal no es válido.");

                if (string.IsNullOrWhiteSpace(sRecibo))
                    return (false, "Debe ingresar el número de recibo.");

                if (!fun_ValidarSoloNumeros(sRecibo))
                    return (false, "El número de recibo solo puede contener números.");

                if (!string.IsNullOrEmpty(sObs) && !fun_ValidarLetrasYNumeros(sObs))
                    return (false, "Las observaciones solo permiten letras y números. No se permiten caracteres especiales.");

                // -------- ENVÍO A BD --------
                bool ok = gModelo.InsertarDetalleEfectivo(iIdPago, sRecibo.Trim(), sObs?.Trim());

                if (ok)
                    return (true, "Pago en efectivo registrado correctamente.");
                else
                    return (false, "Error al guardar los datos del pago en efectivo.");
            }
            catch (Exception ex)
            {
                return (false, "Error inesperado al registrar el pago en efectivo: " + ex.Message);
            }
        }
    }
}
