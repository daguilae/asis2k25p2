using System;
using System.Data;
using Capa_Modelo_Reservas_Hotel;

namespace Capa_Controlador_Reservas_Hotel
{
    public class Cls_Pago_Controlador
    {
        private readonly Cls_Sentencia_Pago modelo = new Cls_Sentencia_Pago();

        // ==================== CARGAR FOLIOS ====================
        public DataTable ObtenerFolios() => modelo.ObtenerFolios();

        // ==================== VALIDAR Y GUARDAR PAGO ====================
        public void GuardarPago(int iIdFolio, string sMetodo, DateTime dFecha, string sMonto, string sEstado)
        {
            if (iIdFolio <= 0) throw new ArgumentException("Seleccione un folio válido.");
            if (string.IsNullOrWhiteSpace(sMetodo)) throw new ArgumentException("Seleccione un método de pago.");
            if (string.IsNullOrWhiteSpace(sMonto)) throw new ArgumentException("Ingrese el monto total.");

            if (!decimal.TryParse(sMonto, out decimal dMonto))
                throw new ArgumentException("El monto debe ser numérico.");

            if (dMonto <= 0)
                throw new ArgumentException("El monto debe ser mayor que cero.");

            if (string.IsNullOrWhiteSpace(sEstado)) throw new ArgumentException("Seleccione el estado del pago.");

            // ✅ Inserta en base de datos
            modelo.InsertarPago(iIdFolio, sMetodo, dFecha, dMonto, sEstado);
        }

        // ==================== MODIFICAR PAGO ====================
        public void ModificarPago(int iIdPago, int iIdFolio, string sMetodo, DateTime dFecha, string sMonto, string sEstado)
        {
            if (iIdPago <= 0) throw new ArgumentException("Debe seleccionar un pago para modificar.");
            if (!decimal.TryParse(sMonto, out decimal dMonto)) throw new ArgumentException("Monto inválido.");

            modelo.ModificarPago(iIdPago, iIdFolio, sMetodo, dFecha, dMonto, sEstado);
        }

        // ==================== OBTENER ID DEL ÚLTIMO PAGO ====================
        public int ObtenerUltimoPagoId() => modelo.ObtenerUltimoPagoId();
    }
}
