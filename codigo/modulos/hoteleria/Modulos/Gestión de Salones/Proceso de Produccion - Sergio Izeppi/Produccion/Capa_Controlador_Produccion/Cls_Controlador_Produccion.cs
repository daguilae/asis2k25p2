using System;
using System.Data;
using CapaModeloProduccion; 

namespace CapaControladorProduccion
{
    public class Cls_Controlador_Produccion
    {
        Cls_Sentencias_Produccion sentencias = new Cls_Sentencias_Produccion();

        // GUARDAR (Insertar registro nuevo)
        public void GuardarRoomService(int iIdHuesped, int iIdHabitacion, DateTime dFechaOrden, string sEstado)
        {
            sentencias.InsertarRoomService(iIdHuesped, iIdHabitacion, dFechaOrden, sEstado);
        }

        // ACTUALIZAR (Editar registro existente)
        public void ActualizarRoomService(int iIdRoom, int iIdHuesped, int iIdHabitacion, DateTime dFechaOrden, string sEstado)
        {
            sentencias.EditarRoomService(iIdRoom, iIdHuesped, iIdHabitacion, dFechaOrden, sEstado);
        }

        // ELIMINAR
        public void EliminarRoomService(int iIdRoom)
        {
            sentencias.EliminarRoomService(iIdRoom);
        }

        // MOSTRAR TODOS LOS ROOM SERVICES
        public DataTable MostrarRoomServices()
        {
            return sentencias.CargarRoomServices();
        }

        public void GuardarDetalle(int iIdRoom, int iIdMenu, int iCantidad)
        {
            // Obtenemos el precio desde el modelo automáticamente
            decimal dePrecioUnitario = sentencias.ObtenerPrecioUnitario(iIdMenu);
            sentencias.InsertarDetalle(iIdRoom, iIdMenu, iCantidad);
        }

        // ✅ ACTUALIZAR
        public void ActualizarDetalle(int iIdDetalle, int iIdRoom, int iIdMenu, int iCantidad)
        {
            decimal dePrecioUnitario = sentencias.ObtenerPrecioUnitario(iIdMenu);
            sentencias.EditarDetalle(iIdDetalle, iIdRoom, iIdMenu, iCantidad);
        }

        // ✅ ELIMINAR
        public void BorrarDetalle(int iIdDetalle)
        {
            sentencias.EliminarDetalle(iIdDetalle);
        }

        // ✅ MOSTRAR TODOS LOS DETALLES
        public DataTable MostrarDetalles()
        {
            return sentencias.CargarDetalles();
        }

        // ✅ MOSTRAR DETALLES POR ROOM SERVICE
        public DataTable MostrarDetallesPorRoom(int iIdRoom)
        {
            return sentencias.CargarDetallesPorRoom(iIdRoom);
        }

        // ✅ OBTENER PRECIO UNITARIO (para llenar automáticamente en la vista)
        public decimal ObtenerPrecio(int iIdMenu)
        {
            return sentencias.ObtenerPrecioUnitario(iIdMenu);
        }

        public DataTable ObtenerPlatos()
        {
            return sentencias.CargarMenu(); // Esto debería traer Id y Nombre del menú
        }

        public int ObtenerUltimoIdRoomService()
        {
            return sentencias.ObtenerUltimoIdRoomService();
        }

        // INSERTAR nueva reserva
        public void GuardarReserva(int iIdHuesped, int iIdHabitacion, int iIdSalon, DateTime dFecha, TimeSpan tHora, int iNumComensales, int iEstado)
        {
            sentencias.InsertarReservaAlacarta(iIdHuesped, iIdHabitacion, iIdSalon, dFecha, tHora, iNumComensales, iEstado);
        }

        // ACTUALIZAR reserva existente
        public void ActualizarReserva(int iIdReserva, int iIdHuesped, int iIdHabitacion, int iIdSalon, DateTime dFecha, TimeSpan tHora, int iNumComensales, int iEstado)
        {
            sentencias.EditarReservaAlacarta(iIdReserva, iIdHuesped, iIdHabitacion, iIdSalon, dFecha, tHora, iNumComensales, iEstado);
        }

        // ELIMINAR reserva
        public void EliminarReserva(int iIdReserva)
        {
            sentencias.EliminarReservaAlacarta(iIdReserva);
        }

        // CONSULTAR todas las reservas
        public DataTable MostrarReservas()
        {
            return sentencias.CargarReservasAlacarta();
        }

        public DataTable ObtenerSalones()
        {
            return sentencias.CargarSalones();
        }

    }

}




