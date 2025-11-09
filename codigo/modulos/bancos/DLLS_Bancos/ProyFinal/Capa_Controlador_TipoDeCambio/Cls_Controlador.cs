using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Modelo_TipoDeCambio;

namespace Capa_Controlador_TipoDeCambio
{
    public class Controlador_TipoCambio
    {
        Modelo_TipoCambio modelo = new Modelo_TipoCambio();

        public DataTable CargarMonedas()
        {
            return modelo.CargarMonedas();
        }

        public void GuardarTipoCambio(string fecha, decimal compra, decimal venta, int idMoneda)
        {
            modelo.InsertarTipoCambio(fecha, compra, venta, idMoneda);
        }

        public DataTable MostrarTodo()
        {
            return modelo.MostrarTiposCambio();
        }

        public DataTable BuscarPorFecha(string fecha)
        {
            return modelo.BuscarTipoCambio(fecha);
        }

        public DataTable MostrarTipoCambioHoy()
        {
            return modelo.MostrarTiposCambioHoy();
        }

        public DataTable CargarBancos()
        {
            return modelo.ObtenerBancos();
        }

        public DataTable CargarTiposCuenta()
        {
            return modelo.ObtenerTiposCuenta();
        }

        public DataTable BuscarDisponibilidad(string banco, string tipoCuenta, string numeroCuenta)
        {
            Modelo_TipoCambio modelo = new Modelo_TipoCambio();
            return modelo.ObtenerDisponibilidad(banco, tipoCuenta, numeroCuenta);
        }

    }
}
