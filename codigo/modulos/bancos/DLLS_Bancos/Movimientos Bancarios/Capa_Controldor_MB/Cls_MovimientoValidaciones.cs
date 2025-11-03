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
        public static (bool ok, string msg) PuedeEditar(string estado)
            => (estado != "ANULADO", "No se puede editar un movimiento anulado.");

        public static (bool ok, string msg) PuedeAnular(object id, object cuenta, object operacion, string estado, object conciliado)
        {
            if (id == null || cuenta == null || operacion == null)
                return (false, "Datos del movimiento incompletos o inválidos.");
            if (estado == "ANULADO")
                return (false, "Este movimiento ya está anulado.");
            if (conciliado != null && int.TryParse(conciliado.ToString(), out var c) && c > 0)
                return (false, "No se puede anular un movimiento conciliado.");
            return (true, null);
        }

        // =============================================
        // VALIDACIONES PARA CARGA DE MOVIMIENTOS
        // =============================================

        public static (bool tieneDatos, string mensaje) ValidarDataTableMovimientos(DataTable dt)
        {
            if (dt == null)
                return (false, "No se pudo obtener los movimientos de la base de datos.");

            if (dt.Rows.Count == 0)
                return (false, "No hay movimientos existentes. Listo para capturar nuevos movimientos.");

            return (true, "OK");
        }

        public static bool ValidarExistenciaColumna(DataTable dt, string nombreColumna)
        {
            return dt != null && dt.Columns.Contains(nombreColumna);
        }

        public static (bool esValido, decimal monto) ValidarMontoMovimiento(object valorMonto)
        {
            if (valorMonto == null || valorMonto == DBNull.Value)
                return (false, 0);

            if (decimal.TryParse(valorMonto.ToString(), out decimal monto))
                return (true, monto);

            return (false, 0);
        }

        public static (string tipoOperacion, decimal debe, decimal haber) DeterminarTipoOperacionYMonto(
            string tipoTransaccion, decimal monto)
        {
            if (string.IsNullOrWhiteSpace(tipoTransaccion))
                return ("DESCONOCIDO", 0, 0);

            string tipoUpper = tipoTransaccion.ToUpper();

            if (tipoUpper.Contains("DEPÓSITO") ||
                tipoUpper.Contains("INGRESO") ||
                tipoUpper.Contains("RECIBIDA"))
            {
                return ("DÉBITO", monto, 0);
            }
            else
            {
                return ("CRÉDITO", 0, monto);
            }
        }

        public static string ObtenerConceptoPorDefecto(object conceptoOriginal)
        {
            if (conceptoOriginal == null || conceptoOriginal == DBNull.Value ||
                string.IsNullOrWhiteSpace(conceptoOriginal.ToString()))
            {
                return "Movimiento bancario";
            }

            return conceptoOriginal.ToString();
        }

        public static (string colorFondo, string colorTexto) ObtenerEstilosPorEstado(string estado)
        {
            if (string.IsNullOrWhiteSpace(estado))
                return (null, null);

            switch (estado.ToUpper())
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

        public static (bool modoLectura, bool permitirAgregarFilas) DeterminarModoGrid(bool tieneDatos)
        {
            if (tieneDatos)
                return (true, false); // Modo lectura
            else
                return (false, true);  // Modo captura
        }

        // =============================================
        // VALIDACIONES PARA COLUMNAS OBLIGATORIAS
        // =============================================

        public static (bool todasExisten, List<string> columnasFaltantes) ValidarColumnasObligatorias(
            DataTable dt, params string[] columnasRequeridas)
        {
            var columnasFaltantes = new List<string>();

            if (dt == null)
            {
                columnasFaltantes.AddRange(columnasRequeridas);
                return (false, columnasFaltantes);
            }

            foreach (string columna in columnasRequeridas)
            {
                if (!dt.Columns.Contains(columna))
                    columnasFaltantes.Add(columna);
            }

            return (columnasFaltantes.Count == 0, columnasFaltantes);
        }

        // =============================================
        // VALIDACIONES PARA ESTADOS
        // =============================================

        public static bool EsEstadoValido(string estado)
        {
            if (string.IsNullOrWhiteSpace(estado))
                return false;

            string[] estadosValidos = { "ACTIVO", "ANULADO", "PENDIENTE", "TRASLADADO" };
            return estadosValidos.Contains(estado.ToUpper());
        }

        public static string ObtenerEstadoPorDefecto()
        {
            return "ACTIVO";
        }

        // =============================================
        // VALIDACIONES PARA TRANSACCIONES
        // =============================================

        public static bool EsTransaccionValida(string transaccion)
        {
            if (string.IsNullOrWhiteSpace(transaccion))
                return false;

            string[] transaccionesValidas = {
                "DEPÓSITO", "CHEQUE", "NOTA_CRÉDITO", "NOTA_DÉBITO",
                "TRANSFERENCIA ENVIADA", "TRANSFERENCIA RECIBIDA"
            };

            return transaccionesValidas.Any(t => transaccion.ToUpper().Contains(t));
        }
    }
}