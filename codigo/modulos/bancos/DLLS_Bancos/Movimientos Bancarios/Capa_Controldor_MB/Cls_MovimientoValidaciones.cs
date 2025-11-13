using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Capa_Controldor_MB
{
    public static class Cls_MovimientoValidaciones
    {
        public static (bool ok, string msg) fun_puede_editar(string sEstado)
            => (sEstado != "ANULADO", "No se puede editar un movimiento anulado.");

        public static (bool ok, string msg) fun_puede_anular(object oId, object oCuenta, object oOperacion, string sEstado, object oConciliado)
        {
            if (oId == null || oCuenta == null || oOperacion == null)
                return (false, "Datos del movimiento incompletos o inválidos.");
            if (sEstado == "ANULADO")
                return (false, "Este movimiento ya está anulado.");
            if (oConciliado != null && int.TryParse(oConciliado.ToString(), out var iConc) && iConc > 0)
                return (false, "No se puede anular un movimiento conciliado.");
            return (true, null);
        }

        // =============================================
        // VALIDACIONES PARA CARGA DE MOVIMIENTOS
        // =============================================

        public static (bool tieneDatos, string mensaje) fun_validar_datatable_movimientos(DataTable dt_Datos)
        {
            if (dt_Datos == null)
                return (false, "No se pudo obtener los movimientos de la base de datos.");

            if (dt_Datos.Rows.Count == 0)
                return (false, "No hay movimientos existentes. Listo para capturar nuevos movimientos.");

            return (true, "OK");
        }

        public static bool fun_validar_existencia_columna(DataTable dt_Datos, string sNombre_Columna)
        {
            return dt_Datos != null && dt_Datos.Columns.Contains(sNombre_Columna);
        }

        public static (bool esValido, decimal monto) fun_validar_monto_movimiento(object oValor_Monto)
        {
            if (oValor_Monto == null || oValor_Monto == DBNull.Value)
                return (false, 0);

            if (decimal.TryParse(oValor_Monto.ToString(), out decimal deMonto))
                return (true, deMonto);

            return (false, 0);
        }

        public static (string tipoOperacion, decimal debe, decimal haber) fun_determinar_tipo_operacion_y_monto(
            string sTipo_Transaccion, decimal deMonto)
        {
            if (string.IsNullOrWhiteSpace(sTipo_Transaccion))
                return ("DESCONOCIDO", 0, 0);

            string sTipo_Upper = sTipo_Transaccion.ToUpper();

            if (sTipo_Upper.Contains("DEPÓSITO") ||
                sTipo_Upper.Contains("INGRESO") ||
                sTipo_Upper.Contains("RECIBIDA"))
            {
                return ("DÉBITO", deMonto, 0);
            }
            else
            {
                return ("CRÉDITO", 0, deMonto);
            }
        }

        public static string fun_obtener_concepto_por_defecto(object oConcepto_Original)
        {
            if (oConcepto_Original == null || oConcepto_Original == DBNull.Value ||
                string.IsNullOrWhiteSpace(oConcepto_Original.ToString()))
            {
                return "Movimiento bancario";
            }

            return oConcepto_Original.ToString();
        }

        public static (string colorFondo, string colorTexto) fun_obtener_estilos_por_estado(string sEstado)
        {
            if (string.IsNullOrWhiteSpace(sEstado))
                return (null, null);

            switch (sEstado.ToUpper())
            {
                case "ANULADO":
                    return ("LightCoral", "DarkRed");
                case "ACTIVO":
                    return ("LightGreen", "DarkGreen");
                case "PENDIENTE":
                case "TRASLADADO":
                default:
                    return ("LightYellow", "DarkOrange");
            }
        }

        public static (bool modoLectura, bool permitirAgregarFilas) fun_determinar_modo_grid(bool bTiene_Datos)
        {
            if (bTiene_Datos)
                return (true, false); // Modo lectura
            else
                return (false, true);  // Modo captura
        }

        // =============================================
        // VALIDACIONES PARA COLUMNAS OBLIGATORIAS
        // =============================================

        public static (bool todasExisten, List<string> columnasFaltantes) fun_validar_columnas_obligatorias(
            DataTable dt_Datos, params string[] aColumnas_Requeridas)
        {
            var lst_Columnas_Faltantes = new List<string>();

            if (dt_Datos == null)
            {
                lst_Columnas_Faltantes.AddRange(aColumnas_Requeridas);
                return (false, lst_Columnas_Faltantes);
            }

            foreach (string sCol in aColumnas_Requeridas)
            {
                if (!dt_Datos.Columns.Contains(sCol))
                    lst_Columnas_Faltantes.Add(sCol);
            }

            return (lst_Columnas_Faltantes.Count == 0, lst_Columnas_Faltantes);
        }

        // =============================================
        // VALIDACIONES PARA ESTADOS
        // =============================================

        public static bool fun_es_estado_valido(string sEstado)
        {
            if (string.IsNullOrWhiteSpace(sEstado))
                return false;

            string[] aEstados_Validos = { "ACTIVO", "ANULADO", "PENDIENTE", "TRASLADADO" };
            return aEstados_Validos.Contains(sEstado.ToUpper());
        }

        public static string fun_obtener_estado_por_defecto()
        {
            return "ACTIVO";
        }

        // =============================================
        // VALIDACIONES PARA TRANSACCIONES
        // =============================================

        public static bool fun_es_transaccion_valida(string sTransaccion)
        {
            if (string.IsNullOrWhiteSpace(sTransaccion))
                return false;

            string[] aTransacciones_Validas = {
                "DEPÓSITO", "CHEQUE", "NOTA_CRÉDITO", "NOTA_DÉBITO",
                "TRANSFERENCIA ENVIADA", "TRANSFERENCIA RECIBIDA"
            };

            return aTransacciones_Validas.Any(t => sTransaccion.ToUpper().Contains(t));
        }
    }
}
