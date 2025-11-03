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
        // DTO con los datos necesarios para editar
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

        // Helpers de lectura segura
        private static bool HasCol(DataTable dt, string col) => dt?.Columns.Contains(col) == true;

        private static T Get<T>(DataRow r, string col, T def = default)
        {
            try
            {
                if (r == null || !r.Table.Columns.Contains(col) || r[col] == DBNull.Value) return def;
                return (T)Convert.ChangeType(r[col], typeof(T));
            }
            catch { return def; }
        }

        /// <summary>
        /// Valida el DataTable y construye el DTO para la UI.
        /// Delegados externos:
        ///  - obtenerMonedaPorCuenta: para fallback de moneda cuando no venga en la fila
        ///  - obtenerSignoOperacionPorId: para calcular el signo
        /// </summary>
        public ResultadoCarga MapearMovimiento(
            DataTable dt,
            Func<int, int?> obtenerMonedaPorCuenta,
            Func<int, string> obtenerSignoOperacionPorId)
        {
            if (dt == null || dt.Rows.Count == 0)
                return ResultadoCarga.Fail("No se encontró el movimiento.");

            var row = dt.Rows[0];

            // Requeridos “duros”
            if (!HasCol(dt, "Fk_Id_CuentaOrigen")) return ResultadoCarga.Fail("Falta la columna Fk_Id_CuentaOrigen.");
            if (!HasCol(dt, "Fk_Id_Operacion")) return ResultadoCarga.Fail("Falta la columna Fk_Id_Operacion.");
            if (!HasCol(dt, "Cmp_Fecha")) return ResultadoCarga.Fail("Falta la columna Cmp_Fecha.");
            if (!HasCol(dt, "Cmp_MontoTotal")) return ResultadoCarga.Fail("Falta la columna Cmp_MontoTotal.");

            var dto = new MovimientoEdicionData
            {
                FkCuentaOrigen = Get<int>(row, "Fk_Id_CuentaOrigen"),
                FkOperacion = Get<int>(row, "Fk_Id_Operacion"),
                NumeroDocumento = Get<string>(row, "Cmp_NumeroDocumento", string.Empty),
                Fecha = Get<DateTime>(row, "Cmp_Fecha", DateTime.Now),
                Concepto = Get<string>(row, "Cmp_Concepto", string.Empty),
                MontoTotal = Get<decimal>(row, "Cmp_MontoTotal", 0m),
                Beneficiario = Get<string>(row, "Cmp_Beneficiario", string.Empty),
                Estado = Get<string>(row, "Cmp_Estado", "ACTIVO"),
                TipoPagoId = HasCol(dt, "Fk_Id_TipoPago") && row["Fk_Id_TipoPago"] != DBNull.Value ? Get<int>(row, "Fk_Id_TipoPago") : (int?)null,
                CuentaDestinoId = HasCol(dt, "Fk_Id_CuentaDestino") && row["Fk_Id_CuentaDestino"] != DBNull.Value ? Get<int>(row, "Fk_Id_CuentaDestino") : (int?)null,
                MonedaId = HasCol(dt, "Fk_Id_Moneda") && row["Fk_Id_Moneda"] != DBNull.Value ? Get<int>(row, "Fk_Id_Moneda") : (int?)null
            };

            // Signo desde operación
            if (obtenerSignoOperacionPorId != null)
                dto.Signo = obtenerSignoOperacionPorId(dto.FkOperacion);

            // Si no trae moneda, usar la de la cuenta
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
