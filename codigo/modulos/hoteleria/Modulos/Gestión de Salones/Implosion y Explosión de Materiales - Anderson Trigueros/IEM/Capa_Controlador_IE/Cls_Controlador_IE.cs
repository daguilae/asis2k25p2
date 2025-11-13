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

        public DataTable fun_DatosMenu()
        {
            return sentencias.fun_ObtenerMenus();
        }

        public DataTable fun_DatosReceta(int codigoMenu)
        {
            return sentencias.fun_ObtenerReceta(codigoMenu);
        }

        public List<(string sCodigo, string sIngrediente, double doStock, string sUnidad)> fun_verificarInventario(List<string> ingredientes)
        {
            return sentencias.fun_ConsultarInventario(ingredientes);
        }

        public void pro_GenerarOrdenCompra(List<(int iCodigo, double doCantidad)> Listado)
        {
            sentencias.pro_GuardarOrdenCompra(Listado);
        }

        public DataTable fun_DatosOrdenes()
        {
            return sentencias.fun_ObtenerOrdenes();
        }

        public void pro_ActualizarCantidad(int iCodigoDetalle, double doCantidadNueva)
        {
            sentencias.pro_ActualizarCantidad(iCodigoDetalle, doCantidadNueva);
        }

        public void pro_EliminarOrden(int iCodigoDetalle)
        {
            sentencias.pro_EliminarOrden(iCodigoDetalle);
        }
    }
} 
