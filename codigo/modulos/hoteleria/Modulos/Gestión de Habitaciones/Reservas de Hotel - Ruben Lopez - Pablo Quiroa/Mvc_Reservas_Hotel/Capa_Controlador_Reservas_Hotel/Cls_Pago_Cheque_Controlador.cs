using System;
using System.Text.RegularExpressions;
using Capa_Modelo_Reservas_Hotel;

namespace Capa_Controlador_Reservas_Hotel
{
    public class Cls_Pago_Cheque_Controlador
    {
        private readonly Cls_Sentencia_Pago_Cheque gModelo = new Cls_Sentencia_Pago_Cheque();

        private readonly string[] gEstadosPermitidos = { "Emitido", "Cobrado", "Devuelto" };

        // ================================
        // VALIDACIONES
        // ================================
        private bool fun_SoloNumeros(string s) =>
            Regex.IsMatch(s, @"^[0-9]+$");

        private bool fun_SoloLetras(string s) =>
            Regex.IsMatch(s, @"^[a-zA-ZñÑáéíóúÁÉÍÓÚ ]+$");

        // ================================
        // INSERTAR CHEQUE
        // ================================
        public (bool exito, string mensaje) funInsertarPagoCheque(
            int iIdPago,
            decimal deMonto,
            string sNumeroCheque,
            string sBanco,
            string sTitular,
            string sEstado,
            DateTime dEmision,
            DateTime dCobro)
        {
            // -------- Validaciones --------

            if (iIdPago <= 0)
                return (false, "ID de pago principal inválido.");

            if (string.IsNullOrWhiteSpace(sNumeroCheque) || !fun_SoloNumeros(sNumeroCheque))
                return (false, "El número de cheque solo puede contener números.");

            if (string.IsNullOrWhiteSpace(sBanco) || !fun_SoloLetras(sBanco))
                return (false, "El banco emisor solo puede contener letras.");

            if (string.IsNullOrWhiteSpace(sTitular) || !fun_SoloLetras(sTitular))
                return (false, "El nombre del titular solo puede contener letras.");

            if (string.IsNullOrWhiteSpace(sEstado))
                return (false, "Debe seleccionar un estado del cheque.");

            if (Array.IndexOf(gEstadosPermitidos, sEstado) == -1)
                return (false, "Estado de cheque no válido.");

            if (dCobro < dEmision)
                return (false, "La fecha de cobro no puede ser anterior a la de emisión.");

            // -------- Guardar BD --------

            bool ok = gModelo.InsertarDetalleCheque(
                iIdPago,
                sNumeroCheque.Trim(),
                sBanco.Trim(),
                sTitular.Trim(),
                sEstado.Trim(),
                dEmision,
                dCobro
            );

            return ok
                ? (true, "Pago con cheque registrado correctamente.")
                : (false, "Error al guardar el pago con cheque.");
        }
    }
}
