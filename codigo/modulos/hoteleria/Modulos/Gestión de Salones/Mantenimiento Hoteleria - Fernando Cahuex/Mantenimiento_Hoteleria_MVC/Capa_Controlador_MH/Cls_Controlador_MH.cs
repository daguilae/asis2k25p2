using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_MH;
using System.Data.Odbc;
using System.Data;
namespace Capa_Controlador_MH
{
    public class Cls_Controlador_MH
    {
        Cls_Mantenimiento modelo = new Cls_Mantenimiento();

        public DataTable MostrarMantenimientos()
        {
            OdbcDataAdapter adapter = modelo.MostrarMantenimientos();
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            return tabla;
        }

        public void GuardarMantenimiento(string salon, string habitacion, string empleado,
                                         string tipo, string descripcion, string estado,
                                         string fechaInicio, string fechaFin)
        {
            modelo.InsertarMantenimiento(salon, habitacion, empleado, tipo, descripcion, estado, fechaInicio, fechaFin);
        }
        public void EliminarMantenimiento(string idMantenimiento)
        {
            modelo.EliminarMantenimiento(idMantenimiento);
        }
        public void ActualizarMantenimiento(string idMantenimiento, string salon, string habitacion, string empleado,
                                    string tipo, string descripcion, string estado,
                                    string fechaInicio, string fechaFin)
        {
            modelo.ActualizarMantenimiento(idMantenimiento, salon, habitacion, empleado, tipo, descripcion, estado, fechaInicio, fechaFin);
        }
        public DataTable BuscarMantenimientoPorId(string idMantenimiento)
        {
            return modelo.BuscarMantenimientoPorId(idMantenimiento);
        }

    }
}