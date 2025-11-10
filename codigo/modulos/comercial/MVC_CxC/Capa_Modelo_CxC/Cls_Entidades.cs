using System;
using System.ComponentModel;

namespace Capa_Modelo_CxC
{
    public class FacturaPendiente
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public decimal Total { get; set; }
        public decimal Saldo { get; set; }
        public int IdCliente { get; set; }
    }

    public class Recibo
    {
        public int Id { get; set; }
        public System.DateTime Fecha { get; set; }
        public int IdCliente { get; set; }
        public string Cliente { get; set; }
        public decimal Monto { get; set; }
        public string Observaciones { get; set; }
        public int IdUsuario { get; set; }
    }

    public class LineaPago
    {
        public int IdMetodoPago { get; set; }
        public decimal Monto { get; set; }
    }

    public class AplicacionPago
    {
        public int IdDocumento { get; set; }
        public decimal MontoAplicado { get; set; }
    }
}

