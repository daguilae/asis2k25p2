using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Capa_Modelo_CPR;

namespace Capa_Controlador_CPR
{
    public class Cls_Cierre_Produccion_Controlador
    {
        private Cls_Cierre_ProduccionDAO daoCierre = new Cls_Cierre_ProduccionDAO();

        // ============================================================
        // MÉTODO 1: Calcular totales del cierre (ingresos, egresos, total)
        // ============================================================
        public (decimal ingresos, decimal egresos, decimal total) CalcularTotales(DateTime fecha)
        {
            try
            {
                decimal ingresos = daoCierre.ObtenerTotalIngresos(fecha);
                decimal egresos = daoCierre.ObtenerTotalEgresos(fecha);
                decimal total = ingresos - egresos;

                return (ingresos, egresos, total);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al calcular totales del cierre: {ex.Message}");
                return (0, 0, 0);
            }
        }

        // ============================================================
        // MÉTODO 2: Guardar un cierre general en la base de datos
        // ============================================================
        public (bool exito, string mensaje) GuardarCierre(
            DateTime fechaCierre,
            string descripcion,
            int tipoCierre,
            decimal ingresos,
            decimal egresos,
            decimal total)
        {
            try
            {
                bool ok = daoCierre.InsertarCierre(fechaCierre, descripcion, tipoCierre, ingresos, egresos, total);
                if (ok)
                    return (true, "Cierre registrado correctamente.");
                else
                    return (false, "No se pudo registrar el cierre.");
            }
            catch (Exception ex)
            {
                return (false, $"Error al guardar cierre: {ex.Message}");
            }
        }

        // ============================================================
        // MÉTODO 3: Obtener lista de tipos de cierre (para ComboBox)
        // ============================================================
        public DataTable ObtenerTiposCierre()
        {
            try
            {
                return daoCierre.ObtenerTiposCierre();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar tipos de cierre: {ex.Message}");
                return new DataTable();
            }
        }

        // ============================================================
        // MÉTODO 4: Generar resumen detallado por módulo
        // ============================================================
        public List<Dictionary<string, object>> GenerarDetallePorModulo(DateTime fecha)
        {
            var lista = new List<Dictionary<string, object>>();

            try
            {
                // Ejemplo: puedes ampliar con más módulos
                decimal totalPagos = daoCierre.ObtenerTotalIngresos(fecha);
                decimal totalEgresos = daoCierre.ObtenerTotalEgresos(fecha);

                lista.Add(new Dictionary<string, object>
                {
                    { "Modulo", "Ingresos Generales" },
                    { "Monto", totalPagos }
                });
                lista.Add(new Dictionary<string, object>
                {
                    { "Modulo", "Egresos Generales" },
                    { "Monto", totalEgresos }
                });
                lista.Add(new Dictionary<string, object>
                {
                    { "Modulo", "Resultado Total" },
                    { "Monto", totalPagos - totalEgresos }
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al generar detalle: {ex.Message}");
            }

            return lista;
        }

        // ============================================================
        // MÉTODO 5: Validación básica antes de registrar un cierre
        // ============================================================
        public bool ValidarCamposCierre(DateTime fecha, string descripcion, int tipoCierre, out string mensaje)
        {
            mensaje = string.Empty;

            if (tipoCierre <= 0)
            {
                mensaje = "Debe seleccionar un tipo de cierre válido.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(descripcion))
            {
                mensaje = "Debe ingresar una descripción para el cierre.";
                return false;
            }

            if (fecha == DateTime.MinValue)
            {
                mensaje = "Debe seleccionar una fecha válida.";
                return false;
            }

            return true;
        }

        // ============================================================
        // MÉTODO 6: Eliminar cierre desde la capa controlador
        // ============================================================
        public (bool exito, string mensaje) EliminarCierre(DateTime fecha)
        {
            try
            {
                bool ok = daoCierre.EliminarCierre(fecha);
                if (ok)
                    return (true, "Cierre eliminado correctamente.");
                else
                    return (false, "No se encontró ningún cierre en esa fecha.");
            }
            catch (Exception ex)
            {
                return (false, "Error al eliminar cierre: " + ex.Message);
            }
        }

    }
}
