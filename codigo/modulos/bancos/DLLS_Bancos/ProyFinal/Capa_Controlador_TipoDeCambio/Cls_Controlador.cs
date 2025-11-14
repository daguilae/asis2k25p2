using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Modelo_TipoDeCambio;


namespace Capa_Controlador_TipoDeCambio
{
    public class Capa_Controlador_TipoCambio
    {
        private Modelo_TipoCambio gModelo = new Modelo_TipoCambio();

        public DataTable CargarMonedas()
        {
            return gModelo.CargarMonedas();
        }

        public void GuardarTipoCambio(string sFecha, decimal deCompra, decimal deVenta, int iIdMoneda)
        {
            gModelo.InsertarTipoCambio(sFecha, deCompra, deVenta, iIdMoneda);
        }

        public DataTable MostrarTodo()
        {
            return gModelo.MostrarTiposCambio();
        }

        public DataTable BuscarPorFecha(string sFecha)
        {
            return gModelo.BuscarTipoCambio(sFecha);
        }

        public DataTable MostrarTipoCambioHoy()
        {
            return gModelo.MostrarTiposCambioHoy();
        }

        public DataTable CargarBancos()
        {
            return gModelo.ObtenerBancos();
        }

        public DataTable CargarTiposCuenta()
        {
            return gModelo.ObtenerTiposCuenta();
        }

        public DataTable BuscarDisponibilidad(string sBanco, string sTipoCuenta, string sNumeroCuenta)
        {
            return gModelo.ObtenerDisponibilidad(sBanco, sTipoCuenta, sNumeroCuenta);
        }
    }
}

