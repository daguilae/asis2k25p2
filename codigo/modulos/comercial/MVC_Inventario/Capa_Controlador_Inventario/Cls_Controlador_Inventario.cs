using System;
using System.Collections.Generic;
using System.Data;
using Capa_Modelo_Inventario;

namespace Capa_Controlador_Inventario
{
    // ==================== Stevens Cambranes 01/11/2025 ====================
    // ==================== Clase Controlador Inventario ====================
    // (Esta clase actúa como intermediario entre la Vista y el Modelo)
    public class Cls_Controlador_Inventario
    {
        // (Instancia global de la capa Modelo para acceder a la BD)
        private Cls_Modelo_Inventario modelo;

        // ==================== Stevens Cambranes 01/11/2025 ====================
        // ==================== Constructor ====================
        // (Inicializa el objeto 'modelo' al crear el controlador)
        public Cls_Controlador_Inventario()
        {
            modelo = new Cls_Modelo_Inventario();
        }

        // ==================== Stevens Cambranes 01/11/2025 ====================
        // ==================== Obtener Histórico (Movimientos) ====================
        // (Pasa la solicitud de la Vista al Modelo para buscar Movimientos filtrados)
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
                // Llama al método correspondiente en el Modelo
                return modelo.Mdl_ObtenerHistorico(
                    tipoMovimiento, idAlmacen, idEstado,
                    usarRangoFechas, fechaInicio, fechaFin,
                    ordenarPor
                );
            }
            catch (Exception ex)
            {
                // Captura y relanza el error para que la Vista lo muestre
                throw new Exception("Error en Capa Controlador: " + ex.Message);
            }
        }

        // ==================== Stevens Cambranes 01/11/2025 ====================
        // ==================== Cargar ComboBox Almacenes ====================
        // (Pide al Modelo los datos de Tbl_Almacenes para llenar el ComboBox)
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

        // ==================== Stevens Cambranes 01/11/2025 ====================
        // ==================== Cargar ComboBox Estados ====================
        // (Pide al Modelo los datos de Tbl_EstadoProducto para llenar el ComboBox)
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

        // ==================== Stevens Cambranes 01/11/2025 ====================
        // ==================== Cargar Todos los Cierres ====================
        // (Pide al Modelo todos los registros de Tbl_CierresInventario)
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

        // ==================== Stevens Cambranes 01/11/2025 ====================
        // ==================== Cargar ComboBox Tipo Movimiento ====================
        // (Pide al Modelo los datos de Tbl_TipoMovimiento para llenar el ComboBox)
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

        // ==================== Stevens Cambranes 01/11/2025 ====================
        // ==================== Cargar DGV por Defecto ====================
        // (Pide al Modelo los 100 movimientos más recientes para el DGV)
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