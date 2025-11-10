using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_Receta;

namespace Capa_Controlador_Receta
{
    public class Cls_Controlador_Receta
    {
        Cls_Sentencias_Receta sentencias = new Cls_Sentencias_Receta();

        public DataTable fun_DatosMenu()
        {
            return sentencias.fun_ObtenerMenus();
        }

        public DataTable fun_DatosReceta(int codigoMenu)
        {
            return sentencias.fun_ObtenerReceta(codigoMenu);
        }

        public void pro_GuardarReceta(int iCodigoMenu, string sIngrediente, string sUnidad, double doCantidad)
        {
            sentencias.pro_GuardarReceta(iCodigoMenu, sIngrediente, sUnidad, doCantidad);
        }

        public void pro_ActualizarIngrediente(string sIngredienteOriginal, string sIngrediente)
        {
            sentencias.pro_ActualizarIngrediente(sIngredienteOriginal, sIngrediente);
        }

        public void pro_ActualizarReceta(int iCodigoReceta, string sUnidad, double doValorIngresado)
        {
            sentencias.pro_ActualizarReceta(iCodigoReceta, sUnidad, doValorIngresado);
        }

        public void pro_EliminarReceta(int iCodigoReceta)
        {
            sentencias.pro_EliminarReceta(iCodigoReceta);
        }
    }
}
