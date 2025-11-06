using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Modelo_GesHab;


namespace Capa_Controlador_GesHab
{

    public class Cls_Controlador_GesHab
    {
        Cls_Dao_Estadia Dao = new Cls_Dao_Estadia();

        public bool InsertarEstadiaVerificada(
    int idHabitacion,
    int idHuesped,
    int numHuespedes,
    bool tieneReserva,
    DateTime fechaCheckIn,
    DateTime fechaActual,
    decimal montoTotal,
    out string mensaje)
        {
            mensaje = "";
            int ICapacidadHabitacion = Dao.ObtenerCapacidadHabitacion(idHabitacion);
      
            //Validaciones con mensajes personalizados
            if (idHabitacion <= 0)
            {
                mensaje = "Debe seleccionar una habitación válida.";
                return false;
            }

            if (idHuesped <= 0)
            {
                mensaje = "Debe seleccionar un huésped válido.";
                return false;
            }

            if (numHuespedes <= 0)
            {
                mensaje = "Debe ingresar un número válido de huéspedes.";
                return false;
            }

            if (numHuespedes > ICapacidadHabitacion)
            {
                mensaje = "Debe ingresar un número de huéspedes menor a la capacidad maxima del cuarto.";
                return false;
            }


            if (montoTotal <= 0)
            {
                mensaje = "El monto total debe ser mayor que 0. Verifique las fechas o la habitación seleccionada.";
                return false;
            }

            if (fechaActual < fechaCheckIn)
            {
                mensaje = "La fecha de salida no puede ser anterior a la fecha de entrada.";
                return false;
            }

            // Si todo está correcto, realizar inserción
            bool exito = Dao.InsertarEstadia(
                idHabitacion,
                idHuesped,
                numHuespedes,
                tieneReserva,
                fechaCheckIn,
                fechaActual,
                montoTotal
            );

            mensaje = exito ? "Nuevo Registro de Estadía registrado correctamente." : "Ocurrió un error al registrar la estadía.";
            return exito;
        }


        public bool ModificarEstadiaVerificada(
            int idEstadia,
            int idHabitacion,
            int idHuesped,
            int numHuespedes,
            bool tieneReserva,
            DateTime fechaCheckIn,
            DateTime fechaActual,
            decimal montoTotal,
            out string mensaje)
        {
            mensaje = "";
            int ICapacidadHabitacion = Dao.ObtenerCapacidadHabitacion(idHabitacion);

            if (idEstadia <= 0)
            {
                mensaje = "Debe seleccionar una estadía existente para modificar.";
                return false;
            }

            if (idHabitacion <= 0)
            {
                mensaje = "Debe seleccionar una habitación válida.";
                return false;
            }

            if (idHuesped <= 0)
            {
                mensaje = "Debe seleccionar un huésped válido.";
                return false;
            }

            if (numHuespedes <= 0)
            {
                mensaje = "Debe ingresar un número válido de huéspedes.";
                return false;
            }

            if (numHuespedes > ICapacidadHabitacion)
            {
                mensaje = "Debe ingresar un número de huéspedes menor a la capacidad maxima del cuarto.";
                return false;
            }
            if (montoTotal <= 0)
            {
                mensaje = "El monto total debe ser mayor que 0.";
                return false;
            }

            if (fechaActual < fechaCheckIn)
            {
                mensaje = "La fecha de salida no puede ser anterior a la de entrada.";
                return false;
            }

            bool exito = Dao.ModificarEstadia(
                idEstadia,
                idHabitacion,
                idHuesped,
                numHuespedes,
                tieneReserva,
                fechaCheckIn,
                fechaActual,
                montoTotal
            );

            mensaje = exito ? "Registro actualizado correctamente." : "No se pudo actualizar la estadía.";
            return exito;
        }



        public bool EliminarEstadia(int idEstadia)
        {
            // Validación básica
            if (idEstadia <= 0)
                return false;

            // Llamada directa al DAO
            return Dao.EliminarEstadia(idEstadia);
        }

        Cls_Dao_Estadia daoEstadia = new Cls_Dao_Estadia();

        public DataTable CargarIdsEstadia()
        {
            return daoEstadia.ObtenerIdsEstadia();
        }

        public DataTable CargarHabitaciones()
        {
            return daoEstadia.ObtenerHabitaciones();
        }

        public DataTable CargarHuespedes()
        {
            return daoEstadia.ObtenerHuespedes();
        }

        public double ObtenerTarifaHabitacion(int idHabitacion)
        {
            return daoEstadia.ObtenerTarifaPorNoche(idHabitacion);
        }

        public int ObtenerCapacidadHabitacion(int idHabitacion)
        {
            return daoEstadia.ObtenerCapacidadHabitacion(idHabitacion);
        }

        public DataTable BuscarEstadiaPorIdVerificada(int idEstadia, out string mensaje)
        {
            mensaje = "";

            if (idEstadia <= 0)
            {
                mensaje = "Debe seleccionar un ID de estadía válido.";
                return null;
            }

            DataTable dt = daoEstadia.ObtenerEstadiaPorId(idEstadia);

            if (dt == null || dt.Rows.Count == 0)
            {
                mensaje = "No se encontró ninguna estadía con el ID especificado.";
                return null;
            }

            mensaje = "Datos de estadía cargados correctamente.";
            return dt;
        }


    }
}