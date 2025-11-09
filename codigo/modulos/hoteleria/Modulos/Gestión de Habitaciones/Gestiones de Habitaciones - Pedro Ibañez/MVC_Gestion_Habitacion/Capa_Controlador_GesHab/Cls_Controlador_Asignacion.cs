using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Modelo_GesHab;

namespace Capa_Controlador_GesHab
{
    public class Cls_Controlador_Asignacion
    {
        //===========================================================================
        //Asignación Servicios
        Cls_Dao_Asignacion_Serv dao = new Cls_Dao_Asignacion_Serv();
        public DataTable CargarServicios()
        {
            return dao.ObtenerServicios();
        }

        public DataTable CargarHabitaciones()
        {
            return dao.ObtenerHabitaciones();
        }

        public DataTable MostrarAsignaciones()
        {
            return dao.ObtenerAsignaciones();
        }

        public bool InsertarAsigancionServicios(
                int IidHabitacion,
                int IidServicio,
                out string mensaje)
        {
            mensaje = "";

            //Validaciones con mensajes personalizados
            if (IidHabitacion <= 0)
            {
                mensaje = "Debe seleccionar una habitación válida.";
                return false;
            }

            if (IidServicio <= 0)
            {
                mensaje = "Debe seleccionar un Servicio válido.";
                return false;
            }


            // Si todo está correcto, realizar inserción
            bool exito = dao.InsertarAsignacionServ(
                IidHabitacion,
                IidServicio
            );

            mensaje = exito ? "Asignación de servicio correcta." : "Ocurrió un error al realizar la asignación.";
            return exito;
        }

        public DataTable BuscarAsignacion(int idHabitacion, out string mensaje)
        {
            mensaje = "";

            if (idHabitacion <= 0)
            {
                mensaje = "Debe seleccionar una habitación válida.";
                return null;
            }

            try
            {
                DataTable resultado = dao.BuscarAsignaciones(idHabitacion);

                if (resultado != null && resultado.Rows.Count > 0)
                {
                    mensaje = "Asignación encontrada correctamente.";
                    return resultado;
                }
                else
                {
                    mensaje = "No se encontró ninguna asignación con esos datos.";
                    return null;
                }
            }
            catch (Exception ex)
            {
                mensaje = "Ocurrió un error al buscar la asignación: " + ex.Message;
                return null;
            }
        }



        public bool EliminarAsignacion(int idHabitacion, int idServicio, out string mensaje)
        {
            mensaje = "";

            if (idHabitacion <= 0)
            {
                mensaje = "Debe seleccionar una habitación válida.";
                return false;
            }

            if (idServicio <= 0)
            {
                mensaje = "Debe seleccionar un servicio válido.";
                return false;
            }

            bool exito = dao.EliminarAsignacion(idHabitacion, idServicio);
            mensaje = exito ? "Asignación eliminada correctamente." : "No se encontró la asignación o ocurrió un error al eliminarla.";
            return exito;
        }
    }
}
