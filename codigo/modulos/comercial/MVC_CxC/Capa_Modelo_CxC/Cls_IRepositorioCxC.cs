using System;
using System.ComponentModel;
using System.Data;

namespace Capa_Modelo_CxC
{
    public interface Cls_IRepositorioCxC
    {
        BindingList<FacturaPendiente> ListarFacturas(string clienteLike, DateTime? desde, DateTime? hasta);

        BindingList<Recibo> ListarRecibos();
        Recibo CrearRecibo(Recibo r, LineaPago[] detalles, AplicacionPago[] apps);
        void EditarRecibo(Recibo r);
        void AnularRecibo(int idRecibo);

        DataTable AntiguedadDT(DateTime fechaCorte, int? idCliente);
        DataTable CajaDiaDT(DateTime fecha, out decimal totalDia);

        DataTable ClientesDT();
    }
}
