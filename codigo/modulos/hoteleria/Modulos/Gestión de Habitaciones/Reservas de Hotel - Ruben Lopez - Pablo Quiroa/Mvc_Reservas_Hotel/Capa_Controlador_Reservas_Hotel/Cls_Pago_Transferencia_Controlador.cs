using System;
using Capa_Modelo_Reservas_Hotel;

namespace Capa_Controlador_Reservas_Hotel
{
    public class Cls_Pago_Transferencia_Controlador
    {
        private readonly Cls_Sentencia_Pago_Transferencia modelo = new Cls_Sentencia_Pago_Transferencia();

        // 
        // REGISTRAR DETALLE DE PAGO POR TRANSFERENCIA 
        // 
        public (bool exito, string mensaje) InsertarPagoTransferencia(int idPago, decimal monto,
                                                                      string numeroTransferencia,
                                                                      string bancoOrigen,
                                                                      string cuentaOrigen)
        {
            try
            {
                if (idPago <= 0)
                    return (false, "El ID del pago principal no es válido.");

                if (string.IsNullOrWhiteSpace(numeroTransferencia))
                    return (false, "Ingrese el número de transferencia.");

                if (string.IsNullOrWhiteSpace(bancoOrigen))
                    return (false, "Ingrese el banco de origen.");

                if (string.IsNullOrWhiteSpace(cuentaOrigen))
                    return (false, "Ingrese la cuenta de origen.");

                // Guardar detalle en Tbl_Pago_Transferencia 
                bool ok = modelo.InsertarDetalleTransferencia(idPago, numeroTransferencia.Trim(), bancoOrigen.Trim(), cuentaOrigen.Trim());

                if (ok)
                    return (true, "Pago por transferencia registrado correctamente.");
                else
                    return (false, "Error al guardar el detalle del pago por transferencia.");
            }
            catch (Exception ex)
            {
                return (false, "Error inesperado al registrar el pago por transferencia: " + ex.Message);
            }
        }
    }
}
