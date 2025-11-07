using System;

namespace Capa_Controldor_MB
{
    public static class Cls_ValidacionesAnular
    {
        public static (bool esValido, string mensaje) fun_validar_anulacion(
            object oCell_Id_Movimiento,
            object oCell_Id_Cuenta_Origen,
            object oCell_Id_Operacion,
            object oCell_Estado,
            object oCell_Conciliado)
        {
            // Verificar que las celdas necesarias no sean nulas
            if (oCell_Id_Movimiento == null || oCell_Id_Cuenta_Origen == null || oCell_Id_Operacion == null)
            {
                return (false, "Datos del movimiento incompletos o inválidos.");
            }

            // Obtener datos de la fila seleccionada
            int iId_Movimiento = Convert.ToInt32(oCell_Id_Movimiento);
            int iId_Cuenta_Origen = Convert.ToInt32(oCell_Id_Cuenta_Origen);
            int iId_Operacion = Convert.ToInt32(oCell_Id_Operacion);
            string sEstado = oCell_Estado?.ToString();

            // Validar que no esté ya anulado
            if (sEstado == "ANULADO")
            {
                return (false, "Este movimiento ya está anulado.");
            }

            // Validar que no esté conciliado
            if (oCell_Conciliado != null && Convert.ToInt32(oCell_Conciliado) > 0)
            {
                return (false, "No se puede anular un movimiento conciliado.");
            }

            return (true, "OK");
        }

        public static bool fun_validar_seleccion_movimiento(int iSelected_Rows_Count)
        {
            return iSelected_Rows_Count > 0;
        }

        public static string fun_obtener_mensaje_confirmacion(int iId_Movimiento)
        {
            return $"¿Está seguro de anular el movimiento #{iId_Movimiento}?\n\n" +
                   "Esta acción reversará los saldos de las cuentas afectadas.";
        }

        public static void pro_mostrar_informacion_diagnostico(int iId_Movimiento, int iId_Cuenta_Origen, int iId_Operacion, string sEstado)
        {
            Console.WriteLine($"Anulando - ID: {iId_Movimiento}, Cuenta: {iId_Cuenta_Origen}, Operación: {iId_Operacion}, Estado: {sEstado}");
        }
    }
}
