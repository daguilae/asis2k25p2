using System;
using System.Data;
using Capa_Modelo_Reservas_Hotel;

namespace Capa_Controlador_Reservas_Hotel
{
    public class Cls_Pago_Controlador
    {
        private readonly Cls_Sentencia_Pago gModelo = new Cls_Sentencia_Pago();

        // Listas permitidas 
        private readonly string[] gMetodosPermitidos = { "Tarjeta", "Efectivo", "Transferencia", "Cheque" };
        private readonly string[] gEstadosPermitidos = { "Pendiente", "Pagado", "Cancelado" };

        //obtenerfolios
        public DataTable funObtenerFolios()
        {
            return gModelo.funObtenerFolios();
        }

        //insertar pagos validos
        public (bool exito, string mensaje, int idPago) funInsertarPagoValidado(
            int iFkFolio, string sMetodo, DateTime dFecha, string sMontoTexto, string sEstado)
        {
            // Folio
            if (iFkFolio <= 0)
                return (false, "Debe seleccionar un folio válido.", 0);

            // Método
            if (string.IsNullOrWhiteSpace(sMetodo))
                return (false, "Debe seleccionar un método de pago.", 0);

            if (Array.IndexOf(gMetodosPermitidos, sMetodo) == -1)
                return (false, "Método de pago no permitido.", 0);

            // Estado
            if (string.IsNullOrWhiteSpace(sEstado))
                return (false, "Debe seleccionar un estado del pago.", 0);

            if (Array.IndexOf(gEstadosPermitidos, sEstado) == -1)
                return (false, "Estado de pago inválido.", 0);

            // Monto
            if (!decimal.TryParse(sMontoTexto, out decimal deMonto))
                return (false, "El monto total es inválido.", 0);

            if (deMonto <= 0)
                return (false, "El monto debe ser mayor a 0.", 0);

            // Fecha (opcional)
            if (dFecha > DateTime.Now.AddYears(1))
                return (false, "La fecha de pago no puede ser extremadamente futura.", 0);

            // Insertar
            int iIdPago = gModelo.funInsertarPago(iFkFolio, sMetodo, dFecha, deMonto, sEstado);
            if (iIdPago <= 0)
                return (false, "Error al registrar el pago principal.", 0);

            return (true, "Pago registrado correctamente.", iIdPago);
        }

        // Compatibilidad (si algo antiguo lo llama)
        public int funInsertarPago(int fkFolio, string sMetodo, DateTime dFecha, decimal deMonto, string sEstado)
        {
            return gModelo.funInsertarPago(fkFolio, sMetodo, dFecha, deMonto, sEstado);
        }
    }
}
