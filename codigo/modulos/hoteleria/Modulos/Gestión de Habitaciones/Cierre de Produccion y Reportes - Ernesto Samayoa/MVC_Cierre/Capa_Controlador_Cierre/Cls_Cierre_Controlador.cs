//Ernesto Samayoa
using System;
using System.Data;
using Capa_Modelo_Cierre;

namespace Capa_Controlador_Cierre
{
    public class Cls_Cierre_Controlador
    {
        private readonly Cls_Cierre_DiarioDAO dao = new Cls_Cierre_DiarioDAO();

        // ======================================================
        // 🔹 ESTRUCTURA DE RESULTADOS
        // ======================================================
        public class CierreResultado
        {
            public DataTable Detalle { get; set; } = new DataTable();
            public double Ingresos { get; set; }
            public double Egresos { get; set; }
            public double Saldo { get; set; }
        }

        // ======================================================
        // 🔹 RESULTADO PARA CONSULTA (incluye encabezado)
        // ======================================================
        public class CierreConsultaResultado : CierreResultado
        {
            public DateTime Fecha { get; set; }
            public string Descripcion { get; set; } = string.Empty;
        }

        // ======================================================
        // 🔹 OBTENER FOLIOS POR FECHA (Habitaciones + Salones)
        // ======================================================
        public DataTable ObtenerFolios(DateTime fechaCorte)
        {
            try
            {
                var data = dao.ObtenerFoliosPorFecha(fechaCorte);
                if (data == null || data.Rows.Count == 0)
                    Console.WriteLine($"⚠️ No se encontraron folios para la fecha {fechaCorte:dd/MM/yyyy}");
                return data ?? new DataTable();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error en ObtenerFolios: {ex.Message}");
                return new DataTable();
            }
        }

        // ======================================================
        // 🔹 CALCULAR TOTALES (Habitaciones + Salones)
        // ======================================================
        public (double ingresos, double egresos, double saldo) CalcularTotales(DateTime fechaCorte)
        {
            try
            {
                return dao.CalcularTotales(fechaCorte);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error en CalcularTotales: {ex.Message}");
                return (0, 0, 0);
            }
        }

        // ======================================================
        // 🔹 GENERAR CIERRE (simula cálculo previo)
        // ======================================================
        public CierreResultado GenerarCierre(DateTime fechaCorte, string descripcion)
        {
            if (string.IsNullOrWhiteSpace(descripcion))
                descripcion = $"Cierre automático del día {fechaCorte:dd/MM/yyyy}";

            try
            {
                var detalle = ObtenerFolios(fechaCorte);
                var (ingresos, egresos, saldo) = CalcularTotales(fechaCorte);

                // Fallback: si la consulta de totales devuelve 0 pero hay filas, recalcular desde el detalle
                if (detalle != null && detalle.Rows.Count > 0 && ingresos == 0 && egresos == 0)
                {
                    double ingresosCalc = 0, egresosCalc = 0;
                    foreach (DataRow row in detalle.Rows)
                    {
                        if (row["Ingresos"] != DBNull.Value)
                            ingresosCalc += Convert.ToDouble(row["Ingresos"]);
                        if (row["Egresos"] != DBNull.Value)
                            egresosCalc += Convert.ToDouble(row["Egresos"]);
                    }
                    ingresos = ingresosCalc;
                    egresos = egresosCalc;
                    saldo = ingresos - egresos;
                }

                return new CierreResultado
                {
                    Detalle = detalle,
                    Ingresos = ingresos,
                    Egresos = egresos,
                    Saldo = saldo
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error en GenerarCierre: {ex.Message}");
                return new CierreResultado();
            }
        }

        // ======================================================
        // 🔹 CARGAR CIERRE EXISTENTE (Detalle + Totales + Encabezado)
        // ======================================================
        public CierreConsultaResultado CargarCierreExistente(int idCierre)
        {
            try
            {
                var resultado = new CierreConsultaResultado();

                // Detalle del cierre
                var detalle = dao.ObtenerDetalleCierre(idCierre) ?? new DataTable();
                resultado.Detalle = detalle;

                // Calcular totales en el controlador (la vista no calcula)
                double ingresos = 0, egresos = 0;
                foreach (DataRow row in detalle.Rows)
                {
                    if (row["Ingresos"] != DBNull.Value)
                        ingresos += Convert.ToDouble(row["Ingresos"]);
                    if (row["Egresos"] != DBNull.Value)
                        egresos += Convert.ToDouble(row["Egresos"]);
                }
                resultado.Ingresos = ingresos;
                resultado.Egresos = egresos;
                resultado.Saldo = ingresos - egresos;

                // Encabezado (fecha y descripción)
                var encabezado = dao.ObtenerEncabezadoCierre(idCierre);
                if (encabezado.HasValue)
                {
                    resultado.Fecha = encabezado.Value.fecha;
                    resultado.Descripcion = encabezado.Value.descripcion ?? string.Empty;
                }

                return resultado;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"⚠️ Error en CargarCierreExistente: {ex.Message}");
                return new CierreConsultaResultado();
            }
        }

        // ======================================================
        // 🔹 GUARDAR CIERRE COMPLETO (Encabezado + Detalle)
        // ======================================================
        public bool GuardarCierre(DateTime fechaCorte, string descripcion, double ingresos, double egresos, double saldo, DataTable detalle)
        {
            try
            {
                if (detalle == null || detalle.Rows.Count == 0)
                {
                    Console.WriteLine("⚠️ No hay detalle para guardar.");
                    return false;
                }

                if (string.IsNullOrWhiteSpace(descripcion))
                    descripcion = $"Cierre del día {fechaCorte:dd/MM/yyyy}";

                // 1️⃣ Insertar encabezado del cierre
                int idCierre = dao.InsertarCierre(fechaCorte, descripcion, ingresos, egresos, saldo);
                if (idCierre <= 0)
                {
                    Console.WriteLine("⚠️ No se pudo insertar el encabezado del cierre.");
                    return false;
                }

                // 2️⃣ Insertar cada folio del detalle (habitaciones o salones)
                foreach (DataRow row in detalle.Rows)
                {
                    if (row["ID Folio"] == DBNull.Value || row["Tipo_Folio"] == DBNull.Value)
                        continue;

                    int idFolio = Convert.ToInt32(row["ID Folio"]);
                    string tipo = row["Tipo_Folio"].ToString();

                    dao.InsertarDetalle(idCierre, idFolio, tipo);
                }

                Console.WriteLine($"✅ Cierre #{idCierre} guardado correctamente ({fechaCorte:dd/MM/yyyy}).");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error en GuardarCierre: {ex.Message}");
                return false;
            }
        }

        // ======================================================
        // 🔹 OBTENER LISTA DE CIERRES (para ComboBox)
        // ======================================================
        public DataTable ObtenerListaCierres()
        {
            try
            {
                return dao.ObtenerListaCierres();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"⚠️ Error en ObtenerListaCierres: {ex.Message}");
                return new DataTable();
            }
        }

        // ======================================================
        // 🔹 OBTENER DETALLE COMPLETO DE UN CIERRE
        // ======================================================
        public DataTable ObtenerDetalleCierre(int idCierre)
        {
            try
            {
                return dao.ObtenerDetalleCierre(idCierre);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"⚠️ Error en ObtenerDetalleCierre: {ex.Message}");
                return new DataTable();
            }
        }

        // ======================================================
        // 🔹 OBTENER ENCABEZADO DE UN CIERRE (Fecha + Descripción)
        // ======================================================
        public (DateTime fecha, string descripcion)? ObtenerEncabezadoCierre(int idCierre)
        {
            try
            {
                return dao.ObtenerEncabezadoCierre(idCierre);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"⚠️ Error en ObtenerEncabezadoCierre: {ex.Message}");
                return null;
            }
        }

        // 🔹 ELIMINAR CIERRE DESDE CONTROLADOR
        public bool EliminarCierre(int idCierre)
        {
            try
            {
                return dao.EliminarCierre(idCierre);
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Error en EliminarCierre: " + ex.Message);
                return false;
            }
        }

    }
}
