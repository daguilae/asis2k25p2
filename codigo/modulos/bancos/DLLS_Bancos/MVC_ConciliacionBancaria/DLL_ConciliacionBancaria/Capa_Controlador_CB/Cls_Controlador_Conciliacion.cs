using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Odbc;
using Capa_Modelo_CB;

// ==========================================================
// Capa Controlador: Cls_Controlador_Conciliacion
// AUTORA: Paula Daniela Leonardo Paredes
// ==========================================================

namespace Capa_Controlador_CB
{
    public class Cls_Controlador_Conciliacion
    {
        // Instancia de la capa modelo
        Cls_Sentencias_Conciliacion gSentencias = new Cls_Sentencias_Conciliacion();

        // ==========================================================
        // fun_cargar_bancos:
        // Retorna los bancos activos para llenar el ComboBox.
        // ==========================================================
        public DataTable fun_cargar_bancos()
        {
            OdbcDataAdapter data = gSentencias.fun_obtener_bancos();
            DataTable dtBancos = new DataTable();
            data.Fill(dtBancos);
            return dtBancos;
        }

        // ==========================================================
        // fun_cargar_cuentas:
        // Retorna las cuentas asociadas a un banco.
        // ==========================================================
        public DataTable fun_cargar_cuentas(int iIdBanco)
        {
            OdbcDataAdapter data = gSentencias.fun_obtener_cuentas(iIdBanco);
            DataTable dtCuentas = new DataTable();
            data.Fill(dtCuentas);
            return dtCuentas;
        }

        // ==========================================================
        // fun_cargar_movimientos:
        // Retorna los movimientos bancarios disponibles (no conciliados).
        // ==========================================================
        public DataTable fun_cargar_movimientos(int iIdCuenta)
        {
            OdbcDataAdapter data = gSentencias.fun_obtener_movimientos(iIdCuenta);
            DataTable dtMov = new DataTable();
            data.Fill(dtMov);
            return dtMov;
        }

        // ==========================================================
        // fun_cargar_conciliaciones:
        // Retorna todas las conciliaciones registradas.
        // ==========================================================
        public DataTable fun_cargar_conciliaciones()
        {
            OdbcDataAdapter data = gSentencias.fun_mostrar_conciliaciones();
            DataTable dtConciliaciones = new DataTable();
            data.Fill(dtConciliaciones);
            return dtConciliaciones;
        }

        // ==========================================================
        // pro_guardar_conciliacion:
        // Valida los datos e inserta una nueva conciliación bancaria.
        // ==========================================================
        public string pro_guardar_conciliacion(
            int iAnio,
            int iMes,
            int iCuenta,
            string dFecha,
            decimal deSaldoBanco,
            decimal deSaldoSistema,
            string sObservaciones,
            int bEstado)
        {
            try
            {
                // ===== VALIDACIONES =====
                if (iCuenta <= 0)
                    return "⚠️ Debe seleccionar una cuenta bancaria.";

                if (deSaldoBanco < 0 || deSaldoSistema < 0)
                    return "⚠️ Los saldos no pueden ser negativos.";

                if (string.IsNullOrWhiteSpace(dFecha))
                    return "⚠️ La fecha de conciliación es obligatoria.";

                // ===== INSERCIÓN =====
                gSentencias.pro_insertar_conciliacion(
                    iAnio, iMes, iCuenta, dFecha, deSaldoBanco, deSaldoSistema, sObservaciones, bEstado);

                return "✅ Conciliación guardada correctamente.";
            }
            catch (Exception ex)
            {
                return "❌ Error al guardar conciliación: " + ex.Message;
            }
        }

        // ==========================================================
        // pro_actualizar_conciliacion:
        // Valida y actualiza una conciliación existente.
        // ==========================================================
        public string pro_actualizar_conciliacion(
            int iIdConciliacion,
            int iAnio,
            int iMes,
            string dFecha,
            decimal deSaldoBanco,
            decimal deSaldoSistema,
            string sObservaciones,
            int bEstado)
        {
            try
            {
                if (iIdConciliacion <= 0)
                    return "⚠️ Debe seleccionar una conciliación para modificar.";

                if (deSaldoBanco < 0 || deSaldoSistema < 0)
                    return "⚠️ Los saldos no pueden ser negativos.";

                gSentencias.pro_actualizar_conciliacion(
                    iIdConciliacion, iAnio, iMes, dFecha, deSaldoBanco, deSaldoSistema, sObservaciones, bEstado);

                return "✅ Conciliación actualizada correctamente.";
            }
            catch (Exception ex)
            {
                return "❌ Error al actualizar conciliación: " + ex.Message;
            }
        }

        // ==========================================================
        // pro_eliminar_conciliacion:
        // Elimina una conciliación seleccionada.
        // ==========================================================
        public string pro_eliminar_conciliacion(int iIdConciliacion)
        {
            try
            {
                if (iIdConciliacion <= 0)
                    return "⚠️ Debe seleccionar una conciliación válida.";

                gSentencias.pro_eliminar_conciliacion(iIdConciliacion);
                return "️Conciliación eliminada correctamente.";
            }
            catch (Exception ex)
            {
                return "❌ Error al eliminar conciliación: " + ex.Message;
            }
        }

        // ==========================================================
        // fun_calcular_diferencia:
        // Calcula la diferencia entre el saldo del banco y el del sistema.
        // ==========================================================
        public decimal fun_calcular_diferencia(decimal deSaldoBanco, decimal deSaldoSistema)
        {
            return deSaldoBanco - deSaldoSistema;
        }

        // ==========================================================
        // fun_validar_campos_vacios:
        // Revisa si hay campos obligatorios vacíos.
        // ==========================================================
        public bool fun_validar_campos_vacios(string sBanco, string sCuenta, string sFecha)
        {
            return !(string.IsNullOrWhiteSpace(sBanco) ||
                     string.IsNullOrWhiteSpace(sCuenta) ||
                     string.IsNullOrWhiteSpace(sFecha));
        }
    }
}
