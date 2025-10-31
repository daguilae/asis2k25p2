using System;
using System.Collections.Generic;
using System.Data; // Necesitas este 'using' para manejar el DataTable
using Capa_Modelo_Inventario; // ¡La referencia a tu capa Modelo!

namespace Capa_Controlador_Inventario
{
    public class Cls_Controlador_Inventario
    {
        private Cls_Modelo_Inventario modelo;

        // Constructor: Inicializa el modelo
        public Cls_Controlador_Inventario()
        {
            modelo = new Cls_Modelo_Inventario();
        }

        public DataTable Ctr_ObtenerHistorico(
            string tipoMovimiento,
            int? idAlmacen,
            int? idEstado,
            bool usarRangoFechas,
            DateTime fechaInicio,
            DateTime fechaFin,
            string ordenarPor)
        {
            try
            {
                // Simplemente llama al método del modelo y retorna los datos
                return modelo.Mdl_ObtenerHistorico(
                    tipoMovimiento, idAlmacen, idEstado,
                    usarRangoFechas, fechaInicio, fechaFin,
                    ordenarPor
                );
            }
            catch (Exception ex)
            {
                // Si el modelo lanzó un error, el controlador lo atrapa y lo vuelve a lanzar para que la VISTA lo maneje.
                throw new Exception("Error en Capa Controlador: " + ex.Message);
            }
        }

        // --- MÉTODOS PARA CARGAR COMBOS ---
        public DataTable Ctr_CargarAlmacenes()
        {
            try
            {
                return modelo.Mdl_CargarAlmacenes();
            }
            catch (Exception ex)
            {
                // Pasa el error a la Vista
                throw new Exception("Error en Controlador al cargar almacenes: " + ex.Message);
            }
        }

        public DataTable Ctr_CargarEstadosProducto()
        {
            try
            {
                return modelo.Mdl_CargarEstadosProducto();
            }
            catch (Exception ex)
            {
                // Pasa el error a la Vista
                throw new Exception("Error en Controlador al cargar estados: " + ex.Message);
            }
        }

        public DataTable Ctr_CargarTodosLosCierres()
        {
            try
            {
                return modelo.Mdl_CargarTodosLosCierres();
            }
            catch (Exception ex)
            {
                throw new Exception("Error en Controlador (Ctr_CargarTodosLosCierres): " + ex.Message);
            }
        }

        // (Agrega estos métodos DENTRO de tu clase Cls_Controlador_Inventario)

        // Para el ComboBox (Error 1)
        public DataTable Ctr_CargarTiposMovimiento()
        {
            try
            {
                return modelo.Mdl_CargarTiposMovimiento();
            }
            catch (Exception ex)
            {
                throw new Exception("Error en Controlador al cargar tipos de movimiento: " + ex.Message);
            }
        }

        // Para el DGV al inicio (Error 2)
        public DataTable Ctr_CargarHistoricoDefault()
        {
            try
            {
                return modelo.Mdl_CargarHistoricoDefault();
            }
            catch (Exception ex)
            {
                throw new Exception("Error en Controlador al cargar histórico default: " + ex.Message);
            }
        }

    }
}