using System;
using System.Data;
using CapaModeloOP;

namespace CapaControladorOP
{
    public class Cls_Controlador_OP
    {
        Cls_Sentencias_OP sentencias = new Cls_Sentencias_OP();

        // -------------------- ORDENES DE PRODUCCIÓN --------------------
        public void GuardarOP(DateTime fecha_solicitud, DateTime fecha_registro)
        {
            sentencias.InsertarOP(fecha_solicitud, fecha_registro);
        }

        public void ActualizarOP(int id, DateTime fecha_solicitud, DateTime fecha_registro)
        {
            sentencias.EditarOP(id, fecha_solicitud, fecha_registro);
        }

        public void BorrarOP(int id)
        {
            sentencias.EliminarOP(id);
        }

        public DataTable MostrarOP()
        {
            return sentencias.CargarOrdenesProduccion();
        }

        public DataTable LlenarComboOrdenesProduccion()
        {
            return sentencias.CargarComboOrdenesProduccion();
        }

        public bool TieneRelaciones(int idOrden)
        {
            return sentencias.TieneRelaciones(idOrden);
        }


        // -------------------- MENÚ --------------------
        public void GuardarMenu(string nombre, string descripcion, decimal precio, int idTipoMenu)
        {
            sentencias.InsertarMenu(nombre, descripcion, precio, idTipoMenu);
        }

        public void ActualizarMenu(int id, string nombre, string descripcion, decimal precio, int idTipoMenu)
        {
            sentencias.EditarMenu(id, nombre, descripcion, precio, idTipoMenu);
        }

        public void BorrarMenu(int id)
        {
            sentencias.EliminarMenu(id);
        }

        public DataTable MostrarMenu()
        {
            return sentencias.CargarMenu();
        }

        public DataTable LlenarComboMenu()
        {
            return sentencias.CargarComboMenu();
        }

        // -------------------- MOBILIARIO --------------------
        public void GuardarMobiliario(string mobiliario)
        {
            sentencias.InsertarMobiliario(mobiliario);
        }

        public void ActualizarMobiliario(int id, string mobiliario)
        {
            sentencias.EditarMobiliario(id, mobiliario);
        }

        public void BorrarMobiliario(int id)
        {
            sentencias.EliminarMobiliario(id);
        }

        public DataTable MostrarMobiliario()
        {
            return sentencias.CargarMobiliario();
        }

        public DataTable LlenarComboMobiliario()
        {
            return sentencias.CargarComboMobiliario();
        }

        // -------------------- DETALLE ORDEN DE MENÚ --------------------
        public void GuardarDetalleOrdenMenu(int idOrdenProduccion, int idMenu, int cantidad)
        {
            sentencias.InsertarDetalleOrdenMenu(idOrdenProduccion, idMenu, cantidad);
        }

        public void ActualizarDetalleOrdenMenu(int idDetalle, int idOrdenProduccion, int idMenu, int cantidad)
        {
            sentencias.EditarDetalleOrdenMenu(idDetalle, idOrdenProduccion, idMenu, cantidad);
        }

        public void BorrarDetalleOrdenMenu(int idDetalle)
        {
            sentencias.EliminarDetalleOrdenMenu(idDetalle);
        }

        public DataTable MostrarDetalleOrdenMenu()
        {
            return sentencias.CargarDetalleOrdenMenu();
        }

        // -------------------- DETALLE ORDEN DE MOBILIARIO --------------------
        public void GuardarDetalleOrdenMobiliario(int idOrdenProduccion, int idMobiliario, int cantidad)
        {
            sentencias.InsertarDetalleOrdenMobiliario(idOrdenProduccion, idMobiliario, cantidad);
        }

        public void ActualizarDetalleOrdenMobiliario(int idDetalle, int idOrdenProduccion, int idMobiliario, int cantidad)
        {
            sentencias.EditarDetalleOrdenMobiliario(idDetalle, idOrdenProduccion, idMobiliario, cantidad);
        }

        public void BorrarDetalleOrdenMobiliario(int idDetalle)
        {
            sentencias.EliminarDetalleOrdenMobiliario(idDetalle);
        }

        public DataTable MostrarDetalleOrdenMobiliario()
        {
            return sentencias.CargarDetalleOrdenMobiliario();
        }

    }
}
