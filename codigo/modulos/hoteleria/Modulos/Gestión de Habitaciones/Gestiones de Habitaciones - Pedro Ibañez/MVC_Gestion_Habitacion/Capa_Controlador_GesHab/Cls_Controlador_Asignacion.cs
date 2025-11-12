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
    public class Cls_Controlador_Asignacion
    {
        //============================================================================
        // --- Asignación de Servicios ---
        private Cls_Dao_Asignacion_Serv oDaoAsignacion = new Cls_Dao_Asignacion_Serv();
        private Cls_BitacoraControlador oCtrlBitacora = new Cls_BitacoraControlador();

        // Cargar servicios
        public DataTable fun_CargarServicios()
        {
            return oDaoAsignacion.fun_ObtenerServicios();
        }

        // Cargar habitaciones
        public DataTable fun_CargarHabitaciones()
        {
            return oDaoAsignacion.fun_ObtenerHabitaciones();
        }

        // Mostrar asignaciones existentes
        public DataTable pro_MostrarAsignaciones()
        {
            return oDaoAsignacion.fun_ObtenerAsignaciones();
        }

        // Insertar asignación de servicio a habitación
        public bool pro_InsertarAsigancionServicios(
            int iIdHabitacion,
            int iIdServicio,
            out string sMensaje)
        {
            sMensaje = "";

            // Validaciones
            if (iIdHabitacion <= 0)
            {
                sMensaje = "Debe seleccionar una habitación válida.";
                return false;
            }

            if (iIdServicio <= 0)
            {
                sMensaje = "Debe seleccionar un servicio válido.";
                return false;
            }

            // Realizar inserción
            bool bExito = oDaoAsignacion.pro_InsertarAsignacionServ(
                iIdHabitacion,
                iIdServicio
            );

            // Registrar acción en bitácora
            oCtrlBitacora.RegistrarAccion(
                Cls_Usuario_Conectado.iIdUsuario,
                3046,
                $"Se asignó al cuarto '{iIdHabitacion}' el servicio '{iIdServicio}'",
                true
            );

            sMensaje = bExito
                ? "Asignación de servicio correcta."
                : "Ocurrió un error al realizar la asignación.";

            return bExito;
        }

        // Buscar asignaciones por habitación
        public DataTable fun_BuscarAsignacion(int iIdHabitacion, out string sMensaje)
        {
            sMensaje = "";

            if (iIdHabitacion <= 0)
            {
                sMensaje = "Debe seleccionar una habitación válida.";
                return null;
            }

            try
            {
                DataTable dtResultado = oDaoAsignacion.fun_BuscarAsignaciones(iIdHabitacion);

                if (dtResultado != null && dtResultado.Rows.Count > 0)
                {
                    sMensaje = "Asignación encontrada correctamente.";
                    return dtResultado;
                }
                else
                {
                    sMensaje = "No se encontró ninguna asignación con esos datos.";
                    return null;
                }
            }
            catch (Exception ex)
            {
                sMensaje = "Ocurrió un error al buscar la asignación: " + ex.Message;
                return null;
            }
        }

        // Eliminar asignación existente
        public bool pro_EliminarAsignacion(int iIdHabitacion, int iIdServicio, out string sMensaje)
        {
            sMensaje = "";

            if (iIdHabitacion <= 0)
            {
                sMensaje = "Debe seleccionar una habitación válida.";
                return false;
            }

            if (iIdServicio <= 0)
            {
                sMensaje = "Debe seleccionar un servicio válido.";
                return false;
            }

            bool bExito = oDaoAsignacion.pro_EliminarAsignacion(iIdHabitacion, iIdServicio);

            sMensaje = bExito
                ? "Asignación eliminada correctamente."
                : "No se encontró la asignación o ocurrió un error al eliminarla.";

            // Registrar acción en bitácora
            oCtrlBitacora.RegistrarAccion(
                Cls_Usuario_Conectado.iIdUsuario,
                3046,
                $"Al cuarto con número '{iIdHabitacion}' se le removió el servicio '{iIdServicio}'",
                true
            );

            return bExito;
        }
    }
}
