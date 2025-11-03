using System;
using System.Data;
using System.Collections.Generic;
using Capa_Modelo_Cierre;

namespace Capa_Controlador_Cierre
{
    public class Cls_Cierre_Controlador
    {
        private readonly Cls_Cierre_DiarioDAO dao = new Cls_Cierre_DiarioDAO();

        public class CierreResultado
        {
            public DataTable Detalle { get; set; } = new DataTable();
            public double Ingresos { get; set; }
            public double Egresos { get; set; }
            public double Saldo { get; set; }
        }

        //OBTENER LISTADO DE FOLIOS CERRADOS POR FECHA
        public DataTable ObtenerFolios(DateTime fechaCorte)
        {
            try
            {
                return dao.ObtenerFoliosPorFecha(fechaCorte);
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Error en ObtenerFolios: " + ex.Message);
                return new DataTable();
            }
        }

        //CALCULAR TOTALES (INGRESOS, EGRESOS, SALDO)
        public (double ingresos, double egresos, double saldo) CalcularTotales(DateTime fechaCorte)
        {
            try
            {
                return dao.CalcularTotales(fechaCorte);
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Error en CalcularTotales: " + ex.Message);
                return (0, 0, 0);
            }
        }

        //GENERAR CIERRE (Valida insumos + obtiene detalle + totales)
        public CierreResultado GenerarCierre(DateTime fechaCorte, string descripcion)
        {
            if (string.IsNullOrWhiteSpace(descripcion))
                throw new ArgumentException("Debe ingresar una descripción para generar el cierre.");

            var detalle = ObtenerFolios(fechaCorte);
            var (ing, egr, sal) = CalcularTotales(fechaCorte);
            return new CierreResultado
            {
                Detalle = detalle,
                Ingresos = ing,
                Egresos = egr,
                Saldo = sal
            };
        }

        // GUARDAR CIERRE COMPLETO (Encabezado + Detalle)
        public bool GuardarCierre(DateTime fechaCorte, string descripcion, double ingresos, double egresos, double saldo, DataTable detalle)
        {
            try
            {
                if (detalle == null || detalle.Rows.Count == 0)
                {
                    Console.WriteLine("No hay detalle para guardar.");
                    return false;
                }

                if (string.IsNullOrWhiteSpace(descripcion))
                {
                    descripcion = $"Cierre automático del día {fechaCorte:dd/MM/yyyy}";
                }

                // 1️⃣ Insertar el encabezado del cierre con descripción
                int idCierre = dao.InsertarCierre(fechaCorte, descripcion, ingresos, egresos, saldo);
                if (idCierre <= 0)
                {
                    Console.WriteLine("⚠️ No se pudo insertar el encabezado del cierre.");
                    return false;
                }

                // 2️⃣ Insertar detalles (folios)
                foreach (DataRow row in detalle.Rows)
                {
                    int idFolio = Convert.ToInt32(row["ID Folio"]);
                    double monto = Convert.ToDouble(row["Saldo"]);
                    dao.InsertarDetalle(idCierre, idFolio, monto);
                }

                Console.WriteLine("✅ Cierre guardado correctamente (con descripción).");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Error en GuardarCierre: " + ex.Message);
                return false;
            }
        }
        //OBTENER LISTA DE CIERRES (para ComboBox de búsqueda)
        public DataTable ObtenerListaCierres()
        {
            try
            {
                return dao.ObtenerListaCierres();
            }
            catch (Exception ex)
            {
                Console.WriteLine("⚠️ Error en ObtenerListaCierres: " + ex.Message);
                return new DataTable();
            }
        }

        //OBTENER DETALLE DE UN CIERRE SELECCIONADO
        public DataTable ObtenerDetalleCierre(int idCierre)
        {
            try
            {
                return dao.ObtenerDetalleCierre(idCierre);
            }
            catch (Exception ex)
            {
                Console.WriteLine("⚠️ Error en ObtenerDetalleCierre: " + ex.Message);
                return new DataTable();
            }
        }

        //OBTENER ENCABEZADO DE UN CIERRE (Fecha + Descripción)
        public (DateTime fecha, string descripcion)? ObtenerEncabezadoCierre(int idCierre)
        {
            try
            {
                return dao.ObtenerEncabezadoCierre(idCierre);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ObtenerEncabezadoCierre: " + ex.Message);
                return null;
            }
        }
    }
}
