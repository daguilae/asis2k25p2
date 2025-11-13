using System;
using System.Data;
using Capa_Modelo_Produccion;

namespace Capa_Controlador_Produccion
{
    public class Cls_Controlador_Produccion
    {
        Cls_Sentencias_Produccion sentencias = new Cls_Sentencias_Produccion();

        // ✅ ROOM SERVICE - PROCEDIMIENTOS (void)
        public void pro_GuardarRoomService(int iIdHuesped, int iIdHabitacion, DateTime dFechaOrden, string sEstado)
        {
            Cls_Sentencias_Produccion sentencias = new Cls_Sentencias_Produccion();

            if (!sentencias.fun_ExisteHuesped(iIdHuesped))
                throw new Exception($"El huésped con ID {iIdHuesped} no existe.");

            if (!sentencias.fun_ExisteHabitacion(iIdHabitacion))
                throw new Exception($"La habitación con ID {iIdHabitacion} no existe.");

            sentencias.pro_InsertarRoomService(iIdHuesped, iIdHabitacion, dFechaOrden, sEstado);
        }


        public void pro_ActualizarRoomService(int iIdRoom, int iIdHuesped, int iIdHabitacion, DateTime dFechaOrden, string sEstado)
        {
            sentencias.pro_EditarRoomService(iIdRoom, iIdHuesped, iIdHabitacion, dFechaOrden, sEstado);
        }

        public void pro_EliminarRoomService(int iIdRoom)
        {
            sentencias.pro_EliminarRoomService(iIdRoom);
        }

        // ✅ DETALLES ROOM SERVICE - PROCEDIMIENTOS (void)
        public void pro_GuardarDetalle(int iIdRoom, int iIdMenu, int iCantidad)
        {
            decimal dePrecioUnitario = sentencias.fun_ObtenerPrecioUnitario(iIdMenu);
            sentencias.pro_InsertarDetalle(iIdRoom, iIdMenu, iCantidad);
        }

        public void pro_ActualizarDetalle(int iIdDetalle, int iIdRoom, int iIdMenu, int iCantidad)
        {
            decimal dePrecioUnitario = sentencias.fun_ObtenerPrecioUnitario(iIdMenu);
            sentencias.pro_EditarDetalle(iIdDetalle, iIdRoom, iIdMenu, iCantidad);
        }

        public void pro_BorrarDetalle(int iIdDetalle)
        {
            sentencias.pro_EliminarDetalle(iIdDetalle);
        }

        // ✅ RESERVAS A LA CARTA - PROCEDIMIENTOS (void)
        public void pro_GuardarReserva(int iIdHuesped, int iIdHabitacion, int iIdSalon, DateTime dFecha, TimeSpan tHora, int iNumComensales, int iEstado)
        {
            if (!sentencias.fun_ExisteHuesped(iIdHuesped))
                throw new Exception($"El huésped con ID {iIdHuesped} no existe.");

            if (!sentencias.fun_ExisteHabitacion(iIdHabitacion))
                throw new Exception($"La habitación con ID {iIdHabitacion} no existe.");

            if (!sentencias.fun_ExisteSalon(iIdSalon))
                throw new Exception($"El salón con ID {iIdSalon} no existe.");

            sentencias.pro_InsertarReservaAlacarta(iIdHuesped, iIdHabitacion, iIdSalon, dFecha, tHora, iNumComensales, iEstado);
        }


        public void pro_ActualizarReserva(int iIdReserva, int iIdHuesped, int iIdHabitacion, int iIdSalon, DateTime dFecha, TimeSpan tHora, int iNumComensales, int iEstado)
        {
            sentencias.pro_EditarReservaAlacarta(iIdReserva, iIdHuesped, iIdHabitacion, iIdSalon, dFecha, tHora, iNumComensales, iEstado);
        }

        public void pro_EliminarReserva(int iIdReserva)
        {
            sentencias.pro_EliminarReservaAlacarta(iIdReserva);
        }

        // ✅ FUNCIONES QUE RETORNAN VALORES (DataTable)
        public DataTable fun_MostrarRoomServices()
        {
            return sentencias.fun_CargarRoomServices();
        }

        public DataTable fun_MostrarDetalles()
        {
            return sentencias.fun_CargarDetalles();
        }

        public DataTable fun_MostrarDetallesPorRoom(int iIdRoom)
        {
            return sentencias.fun_CargarDetallesPorRoom(iIdRoom);
        }

        public DataTable fun_MostrarReservas()
        {
            return sentencias.fun_CargarReservasAlacarta();
        }

        public DataTable fun_ObtenerPlatos()
        {
            return sentencias.fun_CargarMenu();
        }

        public DataTable fun_ObtenerSalones()
        {
            return sentencias.fun_CargarSalones();
        }

        // ✅ FUNCIONES QUE RETORNAN VALORES (otros tipos)
        public decimal fun_ObtenerPrecio(int iIdMenu)
        {
            return sentencias.fun_ObtenerPrecioUnitario(iIdMenu);
        }

        public int fun_ObtenerUltimoIdRoomService()
        {
            return sentencias.fun_ObtenerUltimoIdRoomService();
        }

    }
}



