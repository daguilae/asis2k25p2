using System;
using System.Data;
using CapaModeloProduccion;  // Asumo que tu modelo está en este namespace

namespace CapaControladorProduccion
{
    public class Cls_Controlador_Produccion
    {
        Cls_Sentencias_Produccion sentencias = new Cls_Sentencias_Produccion();

        public void GuardarRoomService(int idHuesped, int idHabitacion, DateTime fechaOrden, string estado)
        {
            sentencias.InsertarRoomService(idHuesped, idHabitacion, fechaOrden, estado);
        }

        // ACTUALIZAR (Editar registro existente)
        public void ActualizarRoomService(int idRoom, int idHuesped, int idHabitacion, DateTime fechaOrden, string estado)
        {
            sentencias.EditarRoomService(idRoom, idHuesped, idHabitacion, fechaOrden, estado);
        }

        // ELIMINAR
        public void EliminarRoomService(int idRoom)
        {
            sentencias.EliminarRoomService(idRoom);
        }

        // MOSTRAR TODOS LOS ROOM SERVICES
        public DataTable MostrarRoomServices()
        {
            return sentencias.CargarRoomServices();
        }

        public void GuardarDetalle(int idRoom, int idMenu, int cantidad)
        {
            // Obtenemos el precio desde el modelo automáticamente
            decimal precioUnitario = sentencias.ObtenerPrecioUnitario(idMenu);
            sentencias.InsertarDetalle(idRoom, idMenu, cantidad);
        }

        // ✅ ACTUALIZAR
        public void ActualizarDetalle(int idDetalle, int idRoom, int idMenu, int cantidad)
        {
            decimal precioUnitario = sentencias.ObtenerPrecioUnitario(idMenu);
            sentencias.EditarDetalle(idDetalle, idRoom, idMenu, cantidad);
        }

        // ✅ ELIMINAR
        public void BorrarDetalle(int idDetalle)
        {
            sentencias.EliminarDetalle(idDetalle);
        }

        // ✅ MOSTRAR TODOS LOS DETALLES
        public DataTable MostrarDetalles()
        {
            return sentencias.CargarDetalles();
        }

        // ✅ MOSTRAR DETALLES POR ROOM SERVICE
        public DataTable MostrarDetallesPorRoom(int idRoom)
        {
            return sentencias.CargarDetallesPorRoom(idRoom);
        }

        // ✅ OBTENER PRECIO UNITARIO (para llenar automáticamente en la vista)
        public decimal ObtenerPrecio(int idMenu)
        {
            return sentencias.ObtenerPrecioUnitario(idMenu);
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
        public void GuardarReserva(int idHuesped, int idHabitacion, int idSalon, DateTime fecha, TimeSpan hora, int numComensales, int estado)
        {
            sentencias.InsertarReservaAlacarta(idHuesped, idHabitacion, idSalon, fecha, hora, numComensales, estado);
        }

        // ACTUALIZAR reserva existente
        public void ActualizarReserva(int idReserva, int idHuesped, int idHabitacion, int idSalon, DateTime fecha, TimeSpan hora, int numComensales, int estado)
        {
            sentencias.EditarReservaAlacarta(idReserva, idHuesped, idHabitacion, idSalon, fecha, hora, numComensales, estado);
        }

        // ELIMINAR reserva
        public void EliminarReserva(int idReserva)
        {
            sentencias.EliminarReservaAlacarta(idReserva);
        }

        // CONSULTAR todas las reservas
        public DataTable MostrarReservas()
        {
            return sentencias.CargarReservasAlacarta();
        }


    }

}




