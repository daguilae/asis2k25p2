// =============================================================
// Capa_Controlador_Movimientos_Nomina
// Clase: Cls_Controlador_Movimientos_Nomina
// Autor: Fredy Reyes Sabán
// Carné: 0901-22-9800
// Fecha: 31/10/2025
// =============================================================

using System;
using System.Data;
using Capa_Modelo_Deducciones_Nomina;

namespace Capa_Controlador_Movimientos_Nomina
{
    public class Cls_Controlador_Movimientos_Nomina
    {
        // ==========================================================
        // Instancia del DAO
        // ==========================================================
        private readonly Cls_Dao_Deducciones_Nomina daoMovimientos = new Cls_Dao_Deducciones_Nomina();

        // ==========================================================
        // MÉTODOS DE CONSULTA PARA COMBOS
        // ==========================================================
        public DataTable funObtenerNominas()
        {
            try
            {
                return daoMovimientos.funObtenerNominas();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en controlador al obtener nóminas: " + ex.Message);
                return null;
            }
        }

        public DataTable funObtenerEmpleados()
        {
            try
            {
                return daoMovimientos.funObtenerEmpleados();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en controlador al obtener empleados: " + ex.Message);
                return null;
            }
        }

        public DataTable funObtenerConceptos()
        {
            try
            {
                return daoMovimientos.funObtenerConceptos();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en controlador al obtener conceptos: " + ex.Message);
                return null;
            }
        }

        // ==========================================================
        // MÉTODOS DE CREACIÓN
        // ==========================================================
        public void proInsertarMovimientoNomina(int iIdNomina, int iIdEmpleado, int iIdConceptoNomina, decimal dMontoMovimiento)
        {
            try
            {
                daoMovimientos.proInsertarMovimientoNomina(iIdNomina, iIdEmpleado, iIdConceptoNomina, dMontoMovimiento);
                Console.WriteLine("Movimiento insertado correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en controlador al insertar movimiento: " + ex.Message);
            }
        }


        // ==========================================================
        // MÉTODOS DE ACTUALIZACIÓN
        // ==========================================================
        public void proActualizarMovimientoNomina(int iIdMovimiento, int iIdNomina, int iIdConceptoNomina, decimal dMontoMovimiento)
        {
            try
            {
                daoMovimientos.proActualizarMovimientoNomina(iIdMovimiento, iIdNomina, iIdConceptoNomina, dMontoMovimiento);
                Console.WriteLine("Movimiento actualizado correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en controlador al actualizar movimiento: " + ex.Message);
            }
        }

        // ==========================================================
        // MÉTODOS DE ELIMINACIÓN
        // ==========================================================
        public void proEliminarMovimientoNomina(int iIdMovimiento)
        {
            try
            {
                daoMovimientos.proEliminarMovimientoNomina(iIdMovimiento);
                Console.WriteLine("Movimiento eliminado correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en controlador al eliminar movimiento: " + ex.Message);
            }
        }

        // ==========================================================
        // MÉTODOS DE CONSULTA
        // ==========================================================
        public DataTable funObtenerMovimientoPorId(int iIdMovimiento)
        {
            try
            {
                return daoMovimientos.funObtenerMovimientoPorId(iIdMovimiento);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en controlador al obtener movimiento por ID: " + ex.Message);
                return null;
            }
        }

        public DataTable funObtenerTodosMovimientos()
        {
            try
            {
                return daoMovimientos.funObtenerTodosMovimientos();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en controlador al obtener todos los movimientos: " + ex.Message);
                return null;
            }
        }

        public DataTable funObtenerMovimientosPorNomina(int iIdNomina)
        {
            try
            {
                return daoMovimientos.funObtenerMovimientosPorNomina(iIdNomina);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en controlador al obtener movimientos por nómina: " + ex.Message);
                return null;
            }
        }

        public DataTable funObtenerMovimientosPorNominaYEmpleado(int iIdNomina, int iIdEmpleado)
        {
            try
            {
                return daoMovimientos.funObtenerMovimientosPorNominaYEmpleado(iIdNomina, iIdEmpleado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en controlador al obtener movimientos por nómina y empleado: " + ex.Message);
                return null;
            }
        }

        public string funObtenerEstadoNomina(int iIdNomina)
        {
            try
            {
                return daoMovimientos.funObtenerEstadoNomina(iIdNomina);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en controlador al obtener estado de nómina: " + ex.Message);
                return string.Empty;
            }
        }


        // ==========================================================
        // MÉTODOS DE CÁLCULO Y VERIFICACIÓN
        // ==========================================================
        public decimal funSumarMovimientosPorTipo(int iIdNomina, string sTipoConcepto)
        {
            try
            {
                return daoMovimientos.funSumarMovimientosPorTipo(iIdNomina, sTipoConcepto);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en controlador al sumar movimientos por tipo: " + ex.Message);
                return 0;
            }
        }

        public bool funExisteMovimiento(int iIdMovimiento)
        {
            try
            {
                return daoMovimientos.funVerificarExistenciaMovimiento(iIdMovimiento) == 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en controlador al verificar existencia: " + ex.Message);
                return false;
            }
        }
    }
}
