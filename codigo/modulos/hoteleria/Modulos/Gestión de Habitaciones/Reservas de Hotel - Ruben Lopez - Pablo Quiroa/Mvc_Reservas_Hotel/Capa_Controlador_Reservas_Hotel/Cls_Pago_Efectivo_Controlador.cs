using System;
using Capa_Modelo_Reservas_Hotel;

namespace Capa_Controlador_Reservas_Hotel
{
    public class Cls_Pago_Efectivo_Controlador
    {
        private readonly Cls_Sentencia_Pago_Efectivo modelo = new Cls_Sentencia_Pago_Efectivo();

       
        // === REGISTRAR DETALLE DE PAGO EN EFECTIVO =========
        
        public (bool exito, string mensaje) InsertarPagoEfectivo(int idPago, decimal monto,
                                                                string numeroRecibo, string observaciones)
        {
            try
            {
                // Validaciones básicas 
                if (idPago <= 0)
                    return (false, "El ID del pago principal no es válido.");

                if (string.IsNullOrWhiteSpace(numeroRecibo))
                    return (false, "Ingrese el número de recibo.");

                // Guardar detalle en Tbl_Pago_Efectivo 
                bool ok = modelo.InsertarDetalleEfectivo(idPago, numeroRecibo.Trim(), observaciones?.Trim());

                if (ok)
                    return (true, "Pago en efectivo registrado correctamente.");
                else
                    return (false, "Error al guardar el detalle del pago en efectivo.");
            }
            catch (Exception ex)
            {
                return (false, "Error inesperado al registrar el pago en efectivo: " + ex.Message);
            }
        }
    }
}
