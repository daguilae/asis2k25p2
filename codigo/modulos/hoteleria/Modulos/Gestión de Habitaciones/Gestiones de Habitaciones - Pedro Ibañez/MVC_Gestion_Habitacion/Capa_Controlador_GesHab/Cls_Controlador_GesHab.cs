using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Modelo_GesHab;
using Capa_Controlador_Seguridad;

namespace Capa_Controlador_GesHab
{
    public class Cls_Controlador_GesHab
    {
        private Cls_Dao_Estadia oDaoEstadia = new Cls_Dao_Estadia();
        private Cls_BitacoraControlador oCtrlBitacora = new Cls_BitacoraControlador();

        // ==========================================================================================
        // Insertar estadía verificada
        public bool InsertarEstadiaVerificada(
            int iIdHabitacion,
            int iIdHuesped,
            int iNumHuespedes,
            bool bTieneReserva,
            DateTime dFechaCheckIn,
            DateTime dFechaActual,
            decimal deMontoTotal,
            out string sMensaje)
        {
            sMensaje = "";

            int iCapacidadHabitacion = oDaoEstadia.ObtenerCapacidadHabitacion(iIdHabitacion);

            // Validaciones con mensajes personalizados
            if (iIdHabitacion <= 0)
            {
                sMensaje = "Debe seleccionar una habitación válida.";
                return false;
            }

            if (iIdHuesped <= 0)
            {
                sMensaje = "Debe seleccionar un huésped válido.";
                return false;
            }

            if (iNumHuespedes <= 0)
            {
                sMensaje = "Debe ingresar un número válido de huéspedes.";
                return false;
            }

            if (iNumHuespedes > iCapacidadHabitacion)
            {
                sMensaje = "Debe ingresar un número de huéspedes menor a la capacidad máxima del cuarto.";
                return false;
            }

            if (deMontoTotal <= 0)
            {
                sMensaje = "El monto total debe ser mayor que 0. Verifique las fechas o la habitación seleccionada.";
                return false;
            }

            if (dFechaActual < dFechaCheckIn)
            {
                sMensaje = "La fecha de salida no puede ser anterior a la fecha de entrada.";
                return false;
            }

            // Si todo está correcto, realizar inserción
            bool bExito = oDaoEstadia.InsertarEstadia(
                iIdHabitacion,
                iIdHuesped,
                iNumHuespedes,
                bTieneReserva,
                dFechaCheckIn,
                dFechaActual,
                deMontoTotal
            );

            // Registrar en bitácora
            oCtrlBitacora.RegistrarAccion(
                Cls_Usuario_Conectado.iIdUsuario,
                3045,
                $"Insertó un nuevo registro en la tabla 'Tbl_Estadia' para la habitación '{iIdHabitacion}' y el huésped '{iIdHuesped}'",
                true
            );

            sMensaje = bExito
                ? "Nuevo registro de estadía guardado correctamente."
                : "Ocurrió un error al registrar la estadía.";

            return bExito;
        }

        // ==========================================================================================
        // Modificar estadía verificada
        public bool ModificarEstadiaVerificada(
            int iIdEstadia,
            int iIdHabitacion,
            int iIdHuesped,
            int iNumHuespedes,
            bool bTieneReserva,
            DateTime dFechaCheckIn,
            DateTime dFechaActual,
            decimal deMontoTotal,
            out string sMensaje)
        {
            sMensaje = "";

            int iCapacidadHabitacion = oDaoEstadia.ObtenerCapacidadHabitacion(iIdHabitacion);

            if (iIdEstadia <= 0)
            {
                sMensaje = "Debe seleccionar una estadía existente para modificar.";
                return false;
            }

            if (iIdHabitacion <= 0)
            {
                sMensaje = "Debe seleccionar una habitación válida.";
                return false;
            }

            if (iIdHuesped <= 0)
            {
                sMensaje = "Debe seleccionar un huésped válido.";
                return false;
            }

            if (iNumHuespedes <= 0)
            {
                sMensaje = "Debe ingresar un número válido de huéspedes.";
                return false;
            }

            if (iNumHuespedes > iCapacidadHabitacion)
            {
                sMensaje = "Debe ingresar un número de huéspedes menor a la capacidad máxima del cuarto.";
                return false;
            }

            if (deMontoTotal <= 0)
            {
                sMensaje = "El monto total debe ser mayor que 0.";
                return false;
            }

            if (dFechaActual < dFechaCheckIn)
            {
                sMensaje = "La fecha de salida no puede ser anterior a la fecha de entrada.";
                return false;
            }

            bool bExito = oDaoEstadia.ModificarEstadia(
                iIdEstadia,
                iIdHabitacion,
                iIdHuesped,
                iNumHuespedes,
                bTieneReserva,
                dFechaCheckIn,
                dFechaActual,
                deMontoTotal
            );

            oCtrlBitacora.RegistrarAccion(
                Cls_Usuario_Conectado.iIdUsuario,
                3045,
                $"Modificó en la tabla 'Tbl_Estadia' el registro con llave '{iIdEstadia}'",
                true
            );

            sMensaje = bExito
                ? "Registro actualizado correctamente."
                : "No se pudo actualizar la estadía.";

            return bExito;
        }

        // ==========================================================================================
        // Eliminar estadía
        public bool EliminarEstadia(int iIdEstadia)
        {
            if (iIdEstadia <= 0)
                return false;

            oCtrlBitacora.RegistrarAccion(
                Cls_Usuario_Conectado.iIdUsuario,
                3045,
                $"Eliminó en la tabla 'Tbl_Estadia' el registro con llave '{iIdEstadia}'",
                true
            );

            return oDaoEstadia.EliminarEstadia(iIdEstadia);
        }

        // ==========================================================================================
        // Métodos auxiliares para combos y consultas
        private Cls_Dao_Estadia oDaoAuxiliar = new Cls_Dao_Estadia();

        public DataTable CargarIdsEstadia()
        {
            return oDaoAuxiliar.ObtenerIdsEstadia();
        }

        public DataTable CargarHabitaciones()
        {
            return oDaoAuxiliar.ObtenerHabitaciones();
        }

        public DataTable CargarHuespedes()
        {
            return oDaoAuxiliar.ObtenerHuespedes();
        }

        public double ObtenerTarifaHabitacion(int iIdHabitacion)
        {
            return oDaoAuxiliar.ObtenerTarifaPorNoche(iIdHabitacion);
        }

        public int ObtenerCapacidadHabitacion(int iIdHabitacion)
        {
            return oDaoAuxiliar.ObtenerCapacidadHabitacion(iIdHabitacion);
        }

        // ==========================================================================================
        // Buscar estadía por ID
        public DataTable BuscarEstadiaPorIdVerificada(int iIdEstadia, out string sMensaje)
        {
            sMensaje = "";

            if (iIdEstadia <= 0)
            {
                sMensaje = "Debe seleccionar un ID de estadía válido.";
                return null;
            }

            DataTable dtResultado = oDaoAuxiliar.ObtenerEstadiaPorId(iIdEstadia);

            if (dtResultado == null || dtResultado.Rows.Count == 0)
            {
                sMensaje = "No se encontró ninguna estadía con el ID especificado.";
                return null;
            }

            sMensaje = "Datos de estadía cargados correctamente.";
            return dtResultado;
        }
    }
}