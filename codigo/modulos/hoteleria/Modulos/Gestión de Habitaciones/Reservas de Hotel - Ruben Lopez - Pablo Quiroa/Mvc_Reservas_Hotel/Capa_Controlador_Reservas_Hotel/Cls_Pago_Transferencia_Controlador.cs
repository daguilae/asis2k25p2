using System;
using Capa_Modelo_Reservas_Hotel;

namespace Capa_Controlador_Reservas_Hotel
{
    public class Cls_Pago_Transferencia_Controlador
    {
        private readonly Cls_Sentencia_Pago_Transferencia modelo = new Cls_Sentencia_Pago_Transferencia();

        // ==================== GUARDAR ====================
        public void GuardarPagoTransferencia(int fkPago, string numeroTransferencia, string bancoOrigen, string cuentaOrigen)
        {
            if (fkPago <= 0)
                throw new ArgumentException("No se recibió el ID del pago principal.");

            if (string.IsNullOrWhiteSpace(numeroTransferencia))
                throw new ArgumentException("Debe ingresar el número de transferencia.");

            if (string.IsNullOrWhiteSpace(bancoOrigen))
                throw new ArgumentException("Debe ingresar el banco de origen.");

            if (string.IsNullOrWhiteSpace(cuentaOrigen))
                throw new ArgumentException("Debe ingresar la cuenta de origen.");

            modelo.InsertarPagoTransferencia(fkPago, numeroTransferencia.Trim(), bancoOrigen.Trim(), cuentaOrigen.Trim());
        }

        // ==================== MODIFICAR ====================
        public void ModificarPagoTransferencia(int fkPago, string numeroTransferencia, string bancoOrigen, string cuentaOrigen)
        {
            if (fkPago <= 0)
                throw new ArgumentException("Debe existir un ID de pago para modificar.");

            if (string.IsNullOrWhiteSpace(numeroTransferencia))
                throw new ArgumentException("Debe ingresar el número de transferencia.");

            modelo.ModificarPagoTransferencia(fkPago, numeroTransferencia.Trim(), bancoOrigen.Trim(), cuentaOrigen.Trim());
        }
    }
}
