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

    }

}
