//Ernesto Samayoa Nuevo Estandarizado
using System;
using System.Data;
using Capa_Modelo_Cierre;

namespace Capa_Controlador_Cierre
{
    public class Cls_Cierre_Controlador
    {
        private readonly Cls_Cierre_DiarioDAO dao = new Cls_Cierre_DiarioDAO();

        //ESTRUCTURA DE RESULTADOS
        public class CierreResultado
        {
            public DataTable Detalle { get; set; } = new DataTable();
            public double doIngresos { get; set; }
            public double doEgresos { get; set; }
            public double doSaldo { get; set; }
        }

        //RESULTADO PARA CONSULTA (incluye encabezado)
        public class CierreConsultaResultado : CierreResultado
        {
            public DateTime dFecha { get; set; }
            public string sDescripcion { get; set; } = string.Empty;
        }

        //OBTENER FOLIOS POR FECHA (Habitaciones + Salones)
        public DataTable fun_ObtenerFolios(DateTime fechaCorte)
        {
            try
            {
                var data = dao.fun_ObtenerFoliosPorFecha(fechaCorte);
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

        //CALCULAR TOTALES (Habitaciones + Salones)
        public (double doIngresos, double doEgresos, double doSaldo) fun_CalcularTotales(DateTime dFechaCorte)
        {
            try
            {
                return dao.fun_CalcularTotales(dFechaCorte);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error en CalcularTotales: {ex.Message}");
                return (0, 0, 0);
            }
        }

        // GENERAR CIERRE (simula cálculo previo)
        public CierreResultado fun_GenerarCierre(DateTime dFechaCorte, string sDescripcion)
        {
            if (string.IsNullOrWhiteSpace(sDescripcion))
                sDescripcion = $"Cierre automático del día {dFechaCorte:dd/MM/yyyy}";

            try
            {
                var detalle = fun_ObtenerFolios(dFechaCorte);
                var (doIngresos, doEgresos, doSaldo) = fun_CalcularTotales(dFechaCorte);

                // Fallback: si la consulta de totales devuelve 0 pero hay filas, recalcular desde el detalle
                if (detalle != null && detalle.Rows.Count > 0 && doIngresos == 0 && doEgresos == 0)
                {
                    double ingresosCalc = 0, egresosCalc = 0;
                    foreach (DataRow row in detalle.Rows)
                    {
                        if (row["Ingresos"] != DBNull.Value)
                            ingresosCalc += Convert.ToDouble(row["Ingresos"]);
                        if (row["Egresos"] != DBNull.Value)
                            egresosCalc += Convert.ToDouble(row["Egresos"]);
                    }
                    doIngresos = ingresosCalc;
                    doEgresos = egresosCalc;
                    doSaldo = doIngresos - doEgresos;
                }

                return new CierreResultado
                {
                    Detalle = detalle,
                    doIngresos = doIngresos,
                    doEgresos = doEgresos,
                    doSaldo = doSaldo
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error en GenerarCierre: {ex.Message}");
                return new CierreResultado();
            }
        }

        //CARGAR CIERRE EXISTENTE (Detalle + Totales + Encabezado)
        public CierreConsultaResultado fun_CargarCierreExistente(int iIdCierre)
        {
            try
            {
                var resultado = new CierreConsultaResultado();

                // Detalle del cierre
                var detalle = dao.fun_ObtenerDetalleCierre(iIdCierre) ?? new DataTable();
                resultado.Detalle = detalle;

                // Calcular totales en el controlador (la vista no calcula)
                double doIngresos = 0, doEgresos = 0;
                foreach (DataRow row in detalle.Rows)
                {
                    if (row["Ingresos"] != DBNull.Value)
                        doIngresos += Convert.ToDouble(row["Ingresos"]);
                    if (row["Egresos"] != DBNull.Value)
                        doEgresos += Convert.ToDouble(row["Egresos"]);
                }
                resultado.doIngresos = doIngresos;
                resultado.doEgresos = doEgresos;
                resultado.doSaldo = doIngresos - doEgresos;

                // Encabezado (fecha y descripción)
                var encabezado = dao.fun_ObtenerEncabezadoCierre(iIdCierre);
                if (encabezado.HasValue)
                {
                    resultado.dFecha = encabezado.Value.dFecha;
                    resultado.sDescripcion = encabezado.Value.sDescripcion ?? string.Empty;
                }

                return resultado;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"⚠️ Error en CargarCierreExistente: {ex.Message}");
                return new CierreConsultaResultado();
            }
        }

        // GUARDAR CIERRE COMPLETO (Encabezado + Detalle)
        public bool fun_GuardarCierre(DateTime dFechaCorte, string sDescripcion, double doIngresos, double doEgresos, double doSaldo, DataTable detalle)
        {
            try
            {
                if (detalle == null || detalle.Rows.Count == 0)
                {
                    Console.WriteLine("⚠️ No hay detalle para guardar.");
                    return false;
                }

                if (string.IsNullOrWhiteSpace(sDescripcion))
                    sDescripcion = $"Cierre del día {dFechaCorte:dd/MM/yyyy}";

                // 1️ Insertar encabezado del cierre
                int iIdCierre = dao.fun_InsertarCierre(dFechaCorte, sDescripcion, doIngresos, doEgresos, doSaldo);
                if (iIdCierre <= 0)
                {
                    Console.WriteLine("⚠️ No se pudo insertar el encabezado del cierre.");
                    return false;
                }

                // 2️ Insertar cada folio del detalle (habitaciones o salones)
                foreach (DataRow row in detalle.Rows)
                {
                    if (row["ID Folio"] == DBNull.Value || row["Tipo_Folio"] == DBNull.Value)
                        continue;

                    int iIdFolio = Convert.ToInt32(row["ID Folio"]);
                    string sTipo = row["Tipo_Folio"].ToString();

                    dao.fun_InsertarDetalle(iIdCierre, iIdFolio, sTipo);
                }

                Console.WriteLine($"✅ Cierre #{iIdCierre} guardado correctamente ({dFechaCorte:dd/MM/yyyy}).");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error en GuardarCierre: {ex.Message}");
                return false;
            }
        }

        //OBTENER LISTA DE CIERRES (para ComboBox)
        public DataTable fun_ObtenerListaCierres()
        {
            try
            {
                return dao.fun_ObtenerListaCierres();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"⚠️ Error en ObtenerListaCierres: {ex.Message}");
                return new DataTable();
            }
        }

        // OBTENER DETALLE COMPLETO DE UN CIERRE
        public DataTable fun_ObtenerDetalleCierre(int iIdCierre)
        {
            try
            {
                return dao.fun_ObtenerDetalleCierre(iIdCierre);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"⚠️ Error en ObtenerDetalleCierre: {ex.Message}");
                return new DataTable();
            }
        }

        //OBTENER ENCABEZADO DE UN CIERRE (Fecha + Descripción)
        public (DateTime dFecha, string sDescripcion)? fun_ObtenerEncabezadoCierre(int iIdCierre)
        {
            try
            {
                return dao.fun_ObtenerEncabezadoCierre(iIdCierre);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"⚠️ Error en ObtenerEncabezadoCierre: {ex.Message}");
                return null;
            }
        }

        //ELIMINAR CIERRE DESDE CONTROLADOR
        public bool fun_EliminarCierre(int idCierre)
        {
            try
            {
                return dao.fun_EliminarCierre(idCierre);
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Error en EliminarCierre: " + ex.Message);
                return false;
            }
        }

    }
}
