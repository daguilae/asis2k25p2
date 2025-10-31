using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_IE;

namespace Capa_Controlador_IE
{
    public class Cls_Controlador_IE
    {
        Cls_Sentencias_IE sentencias = new Cls_Sentencias_IE();

        public DataTable DatosMenu()
        {
            return sentencias.fun_ObtenerMenus();
        }

        public DataTable DatosReceta(int codigoMenu)
        {
            return sentencias.fun_ObtenerReceta(codigoMenu);
        }
    }
}
