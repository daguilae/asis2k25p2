using System;
using Capa_Modelo_Reservas_Hotel;

namespace Capa_Controlador_Reservas_Hotel
{
    public class Cls_Pago_Efectivo_Controlador
    {
        private readonly Cls_Sentencia_Pago_Efectivo modelo = new Cls_Sentencia_Pago_Efectivo();

        // ==================== GUARDAR ====================
        public void GuardarPagoEfectivo(int fkPago, string numeroRecibo, string observaciones)
        {
            if (fkPago <= 0)
                throw new ArgumentException("No se recibió el ID del pago principal.");

            if (string.IsNullOrWhiteSpace(numeroRecibo))
                throw new ArgumentException("Debe ingresar el número de recibo.");

            modelo.InsertarPagoEfectivo(fkPago, numeroRecibo.Trim(), observaciones?.Trim());
        }

        // ==================== MODIFICAR ====================
        public void ModificarPagoEfectivo(int fkPago, string numeroRecibo, string observaciones)
        {
            if (fkPago <= 0)
                throw new ArgumentException("Debe existir un ID de pago para modificar.");

            if (string.IsNullOrWhiteSpace(numeroRecibo))
                throw new ArgumentException("Debe ingresar el número de recibo.");

            modelo.ModificarPagoEfectivo(fkPago, numeroRecibo.Trim(), observaciones?.Trim());
        }
    }
}
