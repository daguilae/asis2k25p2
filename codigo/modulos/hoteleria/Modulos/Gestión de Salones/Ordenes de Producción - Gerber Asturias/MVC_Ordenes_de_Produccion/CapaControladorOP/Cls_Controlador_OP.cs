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
            sentencias.pro_insertarOP(fecha_solicitud, fecha_registro);
        }

        public void ActualizarOP(int id, DateTime fecha_solicitud, DateTime fecha_registro)
        {
            sentencias.pro_editarOP(id, fecha_solicitud, fecha_registro);
        }

        public void BorrarOP(int id)
        {
            sentencias.pro_eliminarOP(id);
        }

        public DataTable MostrarOP()
        {
            return sentencias.fun_cargarOrdenesProduccion();
        }

        public DataTable LlenarComboOrdenesProduccion()
        {
            return sentencias.fun_cargarComboOrdenesProduccion();
        }

        public bool TieneRelaciones(int idOrden)
        {
            return sentencias.fun_tieneRelaciones(idOrden);
        }


        // -------------------- MENÚ --------------------
        public void GuardarMenu(string nombre, string descripcion, decimal precio, int idTipoMenu)
        {
            sentencias.fun_insertarMenu(nombre, descripcion, precio, idTipoMenu);
        }

        public void ActualizarMenu(int id, string nombre, string descripcion, decimal precio, int idTipoMenu)
        {
            sentencias.fun_editarMenu(id, nombre, descripcion, precio, idTipoMenu);
        }

        public void BorrarMenu(int id)
        {
            sentencias.fun_eliminarMenu(id);
        }

        public DataTable MostrarMenu()
        {
            return sentencias.fun_CargarMenu();
        }

        public DataTable LlenarComboMenu()
        {
            return sentencias.fun_cargarComboMenu();
        }

        // -------------------- MOBILIARIO --------------------
        public void GuardarMobiliario(string mobiliario)
        {
            sentencias.pro_insertarMobiliario(mobiliario);
        }

        public void ActualizarMobiliario(int id, string mobiliario)
        {
            sentencias.pro_editarMobiliario(id, mobiliario);
        }

        public void BorrarMobiliario(int id)
        {
            sentencias.pro_eliminarMobiliario(id);
        }

        public DataTable MostrarMobiliario()
        {
            return sentencias.fun_cargarMobiliario();
        }

        public DataTable LlenarComboMobiliario()
        {
            return sentencias.fun_cargarComboMobiliario();
        }

        // -------------------- DETALLE ORDEN DE MENÚ --------------------
        public void GuardarDetalleOrdenMenu(int idOrdenProduccion, int idMenu, int cantidad)
        {
            sentencias.pro_insertarDetalleOrdenMenu(idOrdenProduccion, idMenu, cantidad);
        }

        public void ActualizarDetalleOrdenMenu(int idDetalle, int idOrdenProduccion, int idMenu, int cantidad)
        {
            sentencias.pro_editarDetalleOrdenMenu(idDetalle, idOrdenProduccion, idMenu, cantidad);
        }

        public void BorrarDetalleOrdenMenu(int idDetalle)
        {
            sentencias.pro_eliminarDetalleOrdenMenu(idDetalle);
        }

        public DataTable MostrarDetalleOrdenMenu()
        {
            return sentencias.fun_cargarDetalleOrdenMenu();
        }

        // -------------------- DETALLE ORDEN DE MOBILIARIO --------------------
        public void GuardarDetalleOrdenMobiliario(int idOrdenProduccion, int idMobiliario, int cantidad)
        {
            sentencias.pro_insertarDetalleOrdenMobiliario(idOrdenProduccion, idMobiliario, cantidad);
        }

        public void ActualizarDetalleOrdenMobiliario(int idDetalle, int idOrdenProduccion, int idMobiliario, int cantidad)
        {
            sentencias.pro_editarDetalleOrdenMobiliario(idDetalle, idOrdenProduccion, idMobiliario, cantidad);
        }

        public void BorrarDetalleOrdenMobiliario(int idDetalle)
        {
            sentencias.pro_eliminarDetalleOrdenMobiliario(idDetalle);
        }

        public DataTable MostrarDetalleOrdenMobiliario()
        {
            return sentencias.fun_cargarDetalleOrdenMobiliario();
        }

    }
}
