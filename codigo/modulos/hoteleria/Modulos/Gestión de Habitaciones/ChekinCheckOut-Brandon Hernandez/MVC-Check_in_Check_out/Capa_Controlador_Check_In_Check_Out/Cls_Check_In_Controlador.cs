using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Modelo_Check_In_Check_Out;

namespace Capa_Controlador_Check_In_Check_Out
{
    public class Cls_Check_In_Controlador
    {
        private Cls_Check_In_Dao DAO = new Cls_Check_In_Dao();
        public DataTable datObtenerHuespedes()
        {
            return DAO.datObtenerHuespedes();
        }
        public DataTable datObtenerReservaPorHuesped(int idHuesped)
        {
            return DAO.datObtenerReservaPorHuesped(idHuesped);
        }
        public bool ValidarCheckIn(int iFkHuesped, int iFkReserva, DateTime dFecha, string sEstado, out string mensaje)
        {
            if (iFkHuesped <= 0 || iFkReserva <= 0)
            {
                mensaje = "Debe seleccionar un huésped y una reserva válidos.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(sEstado))
            {
                mensaje = "Debe especificar un estado para el Check-In.";
                return false;
            }
            if (dFecha == default(DateTime))
            {
                mensaje = "Debe ingresar una fecha válida para el Check-In.";
                return false;
            }

            mensaje = "";
            return true;
        }
        public bool bInsertarCheckIn(int iFkHuesped, int iFkReserva, DateTime dFecha, string sEstado, out string mensaje)
        {
            if (!ValidarCheckIn(iFkHuesped, iFkReserva, dFecha, sEstado, out mensaje))
                return false;

            var nuevoCheckIn = new Cls_CheckIn
            {
                iFk_Id_Huesped = iFkHuesped,
                iFk_Id_Reserva = iFkReserva,
                dCmp_Fecha_CheckIn = dFecha,
                sCmp_Estado = sEstado
            };

            bool exito = DAO.bInsertarCheckIn(nuevoCheckIn);
            if (!exito)
                mensaje = "Error al guardar el Check-In en la base de datos.";
            return exito;
        }

      
        public bool bActualizarCheckIn(int iIdCheckIn, int iFkHuesped, int iFkReserva, DateTime dFecha, string sEstado, out string mensaje)
        {
            if (iIdCheckIn <= 0)
            {
                mensaje = "El ID del Check-In no es válido.";
                return false;
            }

            if (!ValidarCheckIn(iFkHuesped, iFkReserva, dFecha, sEstado, out mensaje))
                return false;

            var checkInActualizado = new Cls_CheckIn
            {
                iPk_Id_CheckIn = iIdCheckIn,
                iFk_Id_Huesped = iFkHuesped,
                iFk_Id_Reserva = iFkReserva,
                dCmp_Fecha_CheckIn = dFecha,
                sCmp_Estado = sEstado
            };

            bool exito = DAO.bActualizarCheckIn(checkInActualizado);
            if (!exito)
                mensaje = "Error al modificar el Check-In en la base de datos.";
            return exito;
        }

        public bool bBorrarCheckIn(int iIdCheckIn, out string sMensajeError)
        {
            return DAO.bEliminarCheckIn(iIdCheckIn, out sMensajeError);
        }

        public DataTable MostrarCheckIn()
        {
            return DAO.bMostrarCheckIn();
        }
    }
}