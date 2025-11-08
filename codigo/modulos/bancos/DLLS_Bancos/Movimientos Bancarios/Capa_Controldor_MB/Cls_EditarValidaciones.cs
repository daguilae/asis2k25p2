using System;
using System.Data;

namespace Capa_Controldor_MB
{
    /// <summary>
    /// Valida y mapea el DataTable devuelto por fun_ObtenerMovimientoPorId
    /// hacia un DTO fuertemente tipado listo para pintar en UI.
    /// No toca controles ni hace MessageBox.
    /// </summary>
    public class Cls_EditarValidaciones
    {
        // =============================================
        // DTO con los datos necesarios para editar
        // =============================================
        public class MovimientoEdicionData
        {
            public int FkCuentaOrigen { get; set; }
            public int FkOperacion { get; set; }
            public string NumeroDocumento { get; set; }
            public DateTime Fecha { get; set; }
            public string Concepto { get; set; }
            public decimal MontoTotal { get; set; }
            public string Beneficiario { get; set; }
            public string Estado { get; set; }
            public int? TipoPagoId { get; set; }
            public int? MonedaId { get; set; }
            public int? CuentaDestinoId { get; set; }
            public string Signo { get; set; }
        }

        public class ResultadoCarga
        {
            public bool Exito { get; set; }
            public string Mensaje { get; set; }
            public MovimientoEdicionData Data { get; set; }

            public static ResultadoCarga Ok(MovimientoEdicionData d) => new ResultadoCarga { Exito = true, Data = d };
            public static ResultadoCarga Fail(string m) => new ResultadoCarga { Exito = false, Mensaje = m };
        }

        // =============================================
        // Helpers de lectura segura (privados)
        // =============================================
        private static bool fun_has_col(DataTable dt_Datos, string sColumna)
            => dt_Datos?.Columns.Contains(sColumna) == true;

        private static T fun_get<T>(DataRow dr_Fila, string sColumna, T tDefault = default)
        {
            try
            {
                if (dr_Fila == null || !dr_Fila.Table.Columns.Contains(sColumna) || dr_Fila[sColumna] == DBNull.Value)
                    return tDefault;

                return (T)Convert.ChangeType(dr_Fila[sColumna], typeof(T));
            }
            catch
            {
                return tDefault;
            }
        }

        /// <summary>
        /// Valida el DataTable y construye el DTO para la UI.
        /// Delegados externos:
        ///  - obtenerMonedaPorCuenta: para fallback de moneda cuando no venga en la fila
        ///  - obtenerSignoOperacionPorId: para calcular el signo
        /// </summary>
        public ResultadoCarga MapearMovimiento(
            DataTable dt_Datos,
            Func<int, int?> obtenerMonedaPorCuenta,
            Func<int, string> obtenerSignoOperacionPorId)
        {
            // Validaciones iniciales
            if (dt_Datos == null || dt_Datos.Rows.Count == 0)
                return ResultadoCarga.Fail("No se encontró el movimiento.");

            DataRow dr_Row = dt_Datos.Rows[0];

            // Requeridos “duros”
            if (!fun_has_col(dt_Datos, "Fk_Id_CuentaOrigen")) return ResultadoCarga.Fail("Falta la columna Fk_Id_CuentaOrigen.");
            if (!fun_has_col(dt_Datos, "Fk_Id_Operacion")) return ResultadoCarga.Fail("Falta la columna Fk_Id_Operacion.");
            if (!fun_has_col(dt_Datos, "Cmp_Fecha")) return ResultadoCarga.Fail("Falta la columna Cmp_Fecha.");
            if (!fun_has_col(dt_Datos, "Cmp_MontoTotal")) return ResultadoCarga.Fail("Falta la columna Cmp_MontoTotal.");

            // Construcción del DTO
            var dto = new MovimientoEdicionData
            {
                FkCuentaOrigen = fun_get<int>(dr_Row, "Fk_Id_CuentaOrigen"),
                FkOperacion = fun_get<int>(dr_Row, "Fk_Id_Operacion"),
                NumeroDocumento = fun_get<string>(dr_Row, "Cmp_NumeroDocumento", string.Empty),
                Fecha = fun_get<DateTime>(dr_Row, "Cmp_Fecha", DateTime.Now),
                Concepto = fun_get<string>(dr_Row, "Cmp_Concepto", string.Empty),
                MontoTotal = fun_get<decimal>(dr_Row, "Cmp_MontoTotal", 0m),
                Beneficiario = fun_get<string>(dr_Row, "Cmp_Beneficiario", string.Empty),
                Estado = fun_get<string>(dr_Row, "Cmp_Estado", "ACTIVO"),
                TipoPagoId = fun_has_col(dt_Datos, "Fk_Id_TipoPago") && dr_Row["Fk_Id_TipoPago"] != DBNull.Value ? fun_get<int>(dr_Row, "Fk_Id_TipoPago") : (int?)null,
                CuentaDestinoId = fun_has_col(dt_Datos, "Fk_Id_CuentaDestino") && dr_Row["Fk_Id_CuentaDestino"] != DBNull.Value ? fun_get<int>(dr_Row, "Fk_Id_CuentaDestino") : (int?)null,
                MonedaId = fun_has_col(dt_Datos, "Fk_Id_Moneda") && dr_Row["Fk_Id_Moneda"] != DBNull.Value ? fun_get<int>(dr_Row, "Fk_Id_Moneda") : (int?)null
            };

            // Signo desde operación
            if (obtenerSignoOperacionPorId != null)
                dto.Signo = obtenerSignoOperacionPorId(dto.FkOperacion);

            // Si no trae moneda, usar la de la cuenta (fallback)
            if (!dto.MonedaId.HasValue && obtenerMonedaPorCuenta != null)
                dto.MonedaId = obtenerMonedaPorCuenta(dto.FkCuentaOrigen);

            // Validaciones finales
            if (dto.FkCuentaOrigen <= 0) return ResultadoCarga.Fail("Cuenta origen inválida.");
            if (dto.FkOperacion <= 0) return ResultadoCarga.Fail("Operación inválida.");
            if (dto.MontoTotal < 0) return ResultadoCarga.Fail("El monto total no puede ser negativo.");

            return ResultadoCarga.Ok(dto);
        }
    }
}
