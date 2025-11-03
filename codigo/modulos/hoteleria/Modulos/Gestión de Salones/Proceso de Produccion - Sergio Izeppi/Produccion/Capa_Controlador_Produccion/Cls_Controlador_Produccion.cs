using System;
using System.Data;
using Capa_Modelo_Produccion;  // Asumo que tu modelo está en este namespace

namespace Capa_Controlador_Produccion
{
    public class Cls_Controlador_Produccion
    {
        private Cls_Modelo_Produccion modelo = new Cls_Modelo_Produccion();

        // Obtener lista de platos para llenar ComboBox
        public DataTable ObtenerPlatos()
        {
            return modelo.ObtenerPlatos();
        }

        // Obtener precio de un plato por su id
        public decimal ObtenerPrecioPlato(int idMenu)
        {
            return modelo.ObtenerPrecioPlato(idMenu);
        }

        // Crear Room Service (encabezado) y devolver ID generado
        public int CrearRoomService(int idHuesped, int idHabitacion, DateTime fecha, string estado)
        {
            return modelo.InsertarRoomService(idHuesped, idHabitacion, fecha, estado);
        }

        // Agregar detalle al Room Service
        public void AgregarDetalle(int idRoomService, int idMenu, int cantidad, decimal precioUnitario, decimal subtotal)
        {
            modelo.InsertarDetalle(idRoomService, idMenu, cantidad, precioUnitario, subtotal);
        }

        // Obtener detalle para mostrar en DataGridView
        public DataTable ObtenerDetalle(int idRoomService)
        {
            return modelo.ObtenerDetallePorRoomService(idRoomService);
        }

        // Eliminar Room Service (encabezado y detalles)
        public void EliminarRoomService(int idRoomService)
        {
            modelo.EliminarDetallesRoomService(idRoomService);
            modelo.EliminarRoomService(idRoomService);
        }

        // Modificar Room Service (encabezado)
        public void ModificarRoomService(int idRoomService, int idHuesped, int idHabitacion, DateTime fecha, string estado)
        {
            modelo.ModificarRoomService(idRoomService, idHuesped, idHabitacion, fecha, estado);
        }
    }
}




