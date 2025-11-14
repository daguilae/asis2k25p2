using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using Capa_Modelo_S;

namespace Capa_Controlador_S
{
    public class Cls_Controlador_S
    {
        Cls_Sentencias_Salones cSentencias = new Cls_Sentencias_Salones();
        Cls_Sentencias_Reservacion cSentenciasReservas = new Cls_Sentencias_Reservacion();



        // Insertar salón
        public void GuardarSalon(string sNombre, string sUbicacion, int iCapacidad, int iDisponibilidad)
        {
            cSentencias.InsertarSalon(sNombre, sUbicacion, iCapacidad, iDisponibilidad);
        }

        public int VerificarSalon(string sNombreSalon)
        {
            return cSentencias.VerificarSalon(sNombreSalon);
        }
     //menu
        public void GuardarPedidoMenu(int iIdReserva, int iIdMenu, int iCantidadPlatillos)
        {
            cSentenciasReservas.InsertarPedidoMenu(iIdReserva, iIdMenu, iCantidadPlatillos);
        }

        public void ModificarPedidoMenu(int iIdReserva, int iIdMenu, int iCantidad)
        {
            cSentenciasReservas.ModificarPedidoMenu(iIdReserva, iIdMenu, iCantidad);
        }

        public void EliminarPedidoMenu(int iIdReserva)
        {
            cSentenciasReservas.EliminarPedidoMenu(iIdReserva);
        }

        public DataTable ObtenerMenusDisponibles()
        {
            return cSentenciasReservas.ObtenerMenusDisponibles();
        }


        // Folio
        public void GuardarFolioSalon(int iIdReserva, DateTime dFechaPago, decimal dePagoTotal, string sEstado, string sMetodoPago)
        {
            cSentenciasReservas.InsertarFolioSalon(iIdReserva, dFechaPago, dePagoTotal, sEstado, sMetodoPago);
        }
        //Folio
        public void ModificarFolioSalon(int iIdFolio, DateTime dFechaPago, decimal dePagoTotal, string sEstado, string sMetodoPago)
        {
            cSentenciasReservas.ModificarFolioSalon(iIdFolio, dFechaPago, dePagoTotal, sEstado, sMetodoPago);
        }


        public DataTable ObtenerFoliosSalones()
        {
            return cSentenciasReservas.ObtenerFoliosSalones();
        }

        public void EliminarFolioSalon(int iIdFolio)
        {
            cSentenciasReservas.EliminarFolioSalon(iIdFolio);
        }

        public decimal ObtenerMontoReserva(int iIdReserva)
        {
            return cSentenciasReservas.ObtenerMontoReserva(iIdReserva);
        }

        public int GuardarReservaSalonYObtenerID(int iIdHuesped, int iIdSalon, DateTime dFecha, TimeSpan dHoraInicio, TimeSpan dHoraFin, int iCantidadPersonas, decimal deMontoTotal)
        {
            return cSentenciasReservas.InsertarReservaSalonYObtenerID(iIdHuesped, iIdSalon, dFecha, dHoraInicio, dHoraFin, iCantidadPersonas, deMontoTotal);
        }

        // Consultar salones
        public DataTable ObtenerSalones()
        {
            return cSentencias.ObtenerSalones();
        }

        // Modificar salones
        public void ModificarSalon(int iId, string sNombre, string sUbicacion, int iCapacidad, int iDisponibilidad)
        {
            cSentencias.ModificarSalon(iId, sNombre, sUbicacion, iCapacidad, iDisponibilidad);
        }

        // Eliminar salones
        public void EliminarSalon(int iId)
        {
            cSentencias.EliminarSalon(iId);
        }

        //Reservaciones 
        public void GuardarReservaSalon(int iIdHuesped, int iIdSalon, DateTime dFecha, TimeSpan dHoraInicio, TimeSpan dHoraFin, int iCantidadPersonas, decimal deMontoTotal)
        {
            cSentenciasReservas.InsertarReservaSalon(iIdHuesped, iIdSalon, dFecha, dHoraInicio, dHoraFin, iCantidadPersonas, deMontoTotal);
        }

        public void ModificarReservaSalon(int iIdReserva, int iIdHuesped, int iIdSalon, DateTime dFecha, TimeSpan dHoraInicio, TimeSpan dHoraFin, int iCantidadPersonas, decimal deMontoTotal)
        {
            cSentenciasReservas.ModificarReservaSalon(iIdReserva, iIdHuesped, iIdSalon, dFecha, dHoraInicio, dHoraFin, iCantidadPersonas, deMontoTotal);
        }

        public void EliminarReservaSalon(int iIdReserva)
        {
            cSentenciasReservas.EliminarReservaSalon(iIdReserva);
        }

        public DataTable ObtenerReservasSalones()
        {
            return cSentenciasReservas.ObtenerReservasSalones();
        }

        public DataTable ObtenerHuespedes()
        {
            return cSentenciasReservas.ObtenerHuespedes();
        }

        public DataTable ObtenerSalonesDisponibles()
        {
            return cSentenciasReservas.ObtenerSalonesDisponibles();
        }

        public DataTable ObtenerPromociones()
        {
            return cSentenciasReservas.ObtenerPromociones();
        }






    }
}
