using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            decimal montoTotal)
        {
            // Validaciones básicas

            if (idHabitacion <= 0)
                return false;

            if (idHuesped <= 0)
                return false;

            if (numHuespedes <= 0)
                return false;

            if (montoTotal <= 0)
                return false;

            // Validar coherencia de fechas
            if (fechaActual < fechaCheckIn)
                return false;

            // Si todo está correcto, realizar inserción
            return Dao.InsertarEstadia(
                idHabitacion,
                idHuesped,
                numHuespedes,
                tieneReserva,
                fechaCheckIn,
                fechaActual,
                montoTotal
            );
        }

        public bool ModificarEstadiaVerificada(
    int idEstadia,
    int idHabitacion,
    int idHuesped,
    int numHuespedes,
    bool tieneReserva,
    DateTime fechaCheckIn,
    DateTime fechaActual,
    decimal montoTotal)
        {
            // Validaciones básicas
            if (idEstadia <= 0)
                return false;

            if (idHabitacion <= 0)
                return false;

            if (idHuesped <= 0)
                return false;

            if (numHuespedes <= 0)
                return false;

            if (montoTotal <= 0)
                return false;

            if (fechaActual < fechaCheckIn)
                return false;

            // Llamar al DAO si todo es válido
            return Dao.ModificarEstadia(
                idEstadia,
                idHabitacion,
                idHuesped,
                numHuespedes,
                tieneReserva,
                fechaCheckIn,
                fechaActual,
                montoTotal
            );
        }


        public bool EliminarEstadia(int idEstadia)
        {
            // Validación básica
            if (idEstadia <= 0)
                return false;

            // Llamada directa al DAO
            return Dao.EliminarEstadia(idEstadia);
        }
    }
}