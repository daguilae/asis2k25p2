using System;

namespace Capa_Controldor_MB
{
    public static class Cls_ValidacionesAnular
    {
        public static (bool esValido, string mensaje) ValidarAnulacion(
            object cellIdMovimiento,
            object cellIdCuentaOrigen,
            object cellIdOperacion,
            object cellEstado,
            object cellConciliado)
        {
            // Verificar que las celdas necesarias no sean nulas
            if (cellIdMovimiento == null || cellIdCuentaOrigen == null || cellIdOperacion == null)
            {
                return (false, "Datos del movimiento incompletos o inválidos.");
            }

            // Obtener datos de la fila seleccionada
            int iIdMovimiento = Convert.ToInt32(cellIdMovimiento);
            int iIdCuentaOrigen = Convert.ToInt32(cellIdCuentaOrigen);
            int iIdOperacion = Convert.ToInt32(cellIdOperacion);
            string sEstado = cellEstado?.ToString();

            // Validar que no esté ya anulado
            if (sEstado == "ANULADO")
            {
                return (false, "Este movimiento ya está anulado.");
            }

            // Validar que no esté conciliado
            if (cellConciliado != null && Convert.ToInt32(cellConciliado) > 0)
            {
                return (false, "No se puede anular un movimiento conciliado.");
            }

            return (true, "OK");
        }

        public static bool ValidarSeleccionMovimiento(int selectedRowsCount)
        {
            return selectedRowsCount > 0;
        }

        public static string ObtenerMensajeConfirmacion(int idMovimiento)
        {
            return $"¿Está seguro de anular el movimiento #{idMovimiento}?\n\n" +
                   "Esta acción reversará los saldos de las cuentas afectadas.";
        }

        public static void MostrarInformacionDiagnostico(int idMovimiento, int idCuentaOrigen, int idOperacion, string estado)
        {
            Console.WriteLine($"Anulando - ID: {idMovimiento}, Cuenta: {idCuentaOrigen}, Operación: {idOperacion}, Estado: {estado}");
        }
    }
}