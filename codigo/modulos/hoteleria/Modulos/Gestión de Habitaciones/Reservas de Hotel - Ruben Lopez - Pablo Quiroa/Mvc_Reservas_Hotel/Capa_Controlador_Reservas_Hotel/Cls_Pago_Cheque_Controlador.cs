using System;
using Capa_Modelo_Reservas_Hotel;

namespace Capa_Controlador_Reservas_Hotel
{
    public class Cls_Pago_Cheque_Controlador
    {
        private readonly Cls_Sentencia_Pago_Cheque modelo = new Cls_Sentencia_Pago_Cheque();

        // ==================== GUARDAR ====================
        public void GuardarPagoCheque(int fkPago, string numeroCheque, string bancoEmisor,
                                      string nombreTitular, DateTime fechaEmision,
                                      DateTime fechaCobro, string estadoCheque)
        {
            if (fkPago <= 0)
                throw new ArgumentException("No se recibió el ID del pago principal.");

            if (string.IsNullOrWhiteSpace(numeroCheque))
                throw new ArgumentException("Debe ingresar el número de cheque.");

            if (string.IsNullOrWhiteSpace(bancoEmisor))
                throw new ArgumentException("Debe ingresar el banco emisor.");

            if (string.IsNullOrWhiteSpace(nombreTitular))
                throw new ArgumentException("Debe ingresar el nombre del titular.");

            if (string.IsNullOrWhiteSpace(estadoCheque))
                throw new ArgumentException("Debe seleccionar un estado para el cheque.");

            modelo.InsertarPagoCheque(fkPago, numeroCheque.Trim(), bancoEmisor.Trim(),
                                      nombreTitular.Trim(), fechaEmision, fechaCobro,
                                      estadoCheque.Trim());
        }

        // ==================== MODIFICAR ====================
        public void ModificarPagoCheque(int fkPago, string numeroCheque, string bancoEmisor,
                                        string nombreTitular, DateTime fechaEmision,
                                        DateTime fechaCobro, string estadoCheque)
        {
            if (fkPago <= 0)
                throw new ArgumentException("Debe existir un ID de pago para modificar.");

            modelo.ModificarPagoCheque(fkPago, numeroCheque.Trim(), bancoEmisor.Trim(),
                                       nombreTitular.Trim(), fechaEmision, fechaCobro,
                                       estadoCheque.Trim());
        }
    }
}
