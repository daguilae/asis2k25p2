using System;
using Capa_Modelo_Reservas_Hotel;

namespace Capa_Controlador_Reservas_Hotel
{
    public class Cls_Pago_Cheque_Controlador
    {
        private readonly Cls_Sentencia_Pago_Cheque modelo = new Cls_Sentencia_Pago_Cheque();

        
        // === REGISTRAR DETALLE DE PAGO CON CHEQUE ===========
        public (bool exito, string mensaje) InsertarPagoCheque(int idPago, decimal monto, string numeroCheque,
                                                              string bancoEmisor, string nombreTitular,
                                                              DateTime fechaEmision, DateTime fechaCobro,
                                                              string estadoCheque)
        {
            try
            {
                // Validaciones básicas
                if (idPago <= 0)
                    return (false, "El ID del pago principal no es válido.");

                if (string.IsNullOrWhiteSpace(numeroCheque))
                    return (false, "Ingrese el número del cheque.");

                if (string.IsNullOrWhiteSpace(bancoEmisor))
                    return (false, "Ingrese el banco emisor.");

                if (string.IsNullOrWhiteSpace(nombreTitular))
                    return (false, "Ingrese el nombre del titular.");

                if (string.IsNullOrWhiteSpace(estadoCheque))
                    return (false, "Seleccione un estado del cheque.");

                // === Guardar detalle en Tbl_Pago_Cheque ===
                bool ok = modelo.InsertarDetalleCheque(idPago, numeroCheque.Trim(), bancoEmisor.Trim(),
                                                       nombreTitular.Trim(), fechaEmision, fechaCobro, estadoCheque.Trim());

                if (ok)
                    return (true, "Pago con cheque registrado correctamente.");
                else
                    return (false, "Error al guardar los detalles del cheque.");
            }
            catch (Exception ex)
            {
                return (false, "Error inesperado al registrar el pago con cheque: " + ex.Message);
            }
        }
    }
}
