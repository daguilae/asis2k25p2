using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModeloOP;
using System.Data;

namespace CapaControladorOP
{
    public class Cls_Controlador_OP
    {
        Cls_Sentencias_OP sentencias = new Cls_Sentencias_OP();

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

        // CONTROLADOR MOBILIARIO
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

        // DETALLE DE ORDEN DE MENÚ
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

        public DataTable LlenarComboOrdenesProduccion()
        {
            return sentencias.CargarComboOrdenesProduccion();
        }

        public DataTable LlenarComboMenu()
        {
            return sentencias.CargarComboMenu();
        }

        // DETALLE DE ORDEN DE MOBILIARIO
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

        public DataTable LlenarComboMobiliario()
        {
            return sentencias.CargarComboMobiliario();
        }






    }

}
