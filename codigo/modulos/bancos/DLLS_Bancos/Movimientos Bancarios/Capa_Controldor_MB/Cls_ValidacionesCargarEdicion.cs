using System;
using System.Data;

namespace Capa_Controldor_MB
{
    public class Cls_ValidacionesCargarEdicion
    {
        public class ResultadoCargaEdicion
        {
            public bool Exito { get; set; }
            public string Mensaje { get; set; }
            public MovimientoEdicionDTO Data { get; set; }
            public bool CuentaDestinoHabilitada { get; set; }
        }

        public class MovimientoEdicionDTO
        {
            public int FkCuentaOrigen { get; set; }
            public int FkOperacion { get; set; }
            public string NumeroDocumento { get; set; }
            public DateTime Fecha { get; set; }
            public string Concepto { get; set; }
            public decimal MontoTotal { get; set; }
            public string Beneficiario { get; set; }
            public string Estado { get; set; }
            public string Signo { get; set; }
            public int? TipoPagoId { get; set; }
            public int? MonedaId { get; set; }
            public int? CuentaDestinoId { get; set; }
        }

        public ResultadoCargaEdicion ValidarYCargarDatosEdicion(
            DataTable dtMovimiento,
            Func<int, int?> obtenerMonedaPorCuenta,
            Func<int, string> obtenerSignoOperacionPorId)
        {
            var resultado = new ResultadoCargaEdicion();

            try
            {
                // Validar DataTable
                if (dtMovimiento == null || dtMovimiento.Rows.Count == 0)
                {
                    resultado.Exito = false;
                    resultado.Mensaje = "No se encontraron datos del movimiento para editar.";
                    return resultado;
                }

                // Validar estructura del DataTable
                var validacionEstructura = ValidarEstructuraDataTable(dtMovimiento);
                if (!validacionEstructura.Exito)
                {
                    resultado.Exito = false;
                    resultado.Mensaje = validacionEstructura.Mensaje;
                    return resultado;
                }

                DataRow row = dtMovimiento.Rows[0];

                // Mapear datos con validaciones
                resultado.Data = MapearDatosMovimiento(row, obtenerMonedaPorCuenta, obtenerSignoOperacionPorId);

                resultado.Exito = true;
                resultado.Mensaje = "Datos cargados correctamente para edición.";
            }
            catch (Exception ex)
            {
                resultado.Exito = false;
                resultado.Mensaje = $"Error al validar datos de edición: {ex.Message}";
            }

            return resultado;
        }

        private (bool Exito, string Mensaje) ValidarEstructuraDataTable(DataTable dt)
        {
            try
            {
                string[] columnasRequeridas = {
                    "Fk_Id_cuenta_origen", "Fk_Id_operacion", "Cmp_numero_documento",
                    "Cmp_fecha_movimiento", "Cmp_concepto", "Cmp_valor_total",
                    "Cmp_beneficiario", "Cmp_estado"
                };

                foreach (string columna in columnasRequeridas)
                {
                    if (!dt.Columns.Contains(columna))
                    {
                        return (false, $"Falta la columna requerida: {columna}");
                    }
                }

                DataRow row = dt.Rows[0];

                // Validar tipos de datos críticos
                if (row["Fk_Id_cuenta_origen"] == DBNull.Value)
                    return (false, "La cuenta origen no puede ser nula");

                if (row["Fk_Id_operacion"] == DBNull.Value)
                    return (false, "La operación no puede ser nula");

                if (row["Cmp_valor_total"] == DBNull.Value)
                    return (false, "El monto total no puede ser nulo");

                if (row["Cmp_fecha_movimiento"] == DBNull.Value)
                    return (false, "La fecha de movimiento no puede ser nula");

                return (true, "Estructura válida");
            }
            catch (Exception ex)
            {
                return (false, $"Error en validación de estructura: {ex.Message}");
            }
        }

        private MovimientoEdicionDTO MapearDatosMovimiento(
            DataRow row,
            Func<int, int?> obtenerMonedaPorCuenta,
            Func<int, string> obtenerSignoOperacionPorId)
        {
            var dto = new MovimientoEdicionDTO();

            try
            {
                // Datos obligatorios
                dto.FkCuentaOrigen = Convert.ToInt32(row["Fk_Id_cuenta_origen"]);
                dto.FkOperacion = Convert.ToInt32(row["Fk_Id_operacion"]);
                dto.NumeroDocumento = row["Cmp_numero_documento"]?.ToString() ?? string.Empty;
                dto.Fecha = Convert.ToDateTime(row["Cmp_fecha_movimiento"]);
                dto.Concepto = row["Cmp_concepto"]?.ToString() ?? string.Empty;
                dto.MontoTotal = Convert.ToDecimal(row["Cmp_valor_total"]);
                dto.Beneficiario = row["Cmp_beneficiario"]?.ToString() ?? string.Empty;
                dto.Estado = row["Cmp_estado"]?.ToString() ?? "ACTIVO";

                // Obtener signo de la operación
                dto.Signo = obtenerSignoOperacionPorId(dto.FkOperacion);

                // Obtener moneda de la cuenta origen
                dto.MonedaId = obtenerMonedaPorCuenta(dto.FkCuentaOrigen);

                // Datos opcionales
                if (row.Table.Columns.Contains("Fk_Id_tipo_pago") && row["Fk_Id_tipo_pago"] != DBNull.Value)
                {
                    dto.TipoPagoId = Convert.ToInt32(row["Fk_Id_tipo_pago"]);
                }

                if (row.Table.Columns.Contains("Fk_Id_cuenta_destino") && row["Fk_Id_cuenta_destino"] != DBNull.Value)
                {
                    dto.CuentaDestinoId = Convert.ToInt32(row["Fk_Id_cuenta_destino"]);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en mapeo de datos: {ex.Message}", ex);
            }

            return dto;
        }

        public (bool EsValido, string Mensaje) ValidarEstadoEdicion(string estadoActual)
        {
            if (string.IsNullOrWhiteSpace(estadoActual))
                return (false, "El estado del movimiento no puede estar vacío");

            if (estadoActual.Equals("ANULADO", StringComparison.OrdinalIgnoreCase))
                return (false, "No se puede editar un movimiento anulado");

            if (estadoActual.Equals("CONCILIADO", StringComparison.OrdinalIgnoreCase))
                return (false, "No se puede editar un movimiento conciliado");

            return (true, "Estado válido para edición");
        }
    }
}