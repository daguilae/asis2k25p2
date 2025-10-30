using System;
using System.ComponentModel;

namespace Capa_Modelo_CxC
{
    public class FacturaPendiente
    {
        public bool Seleccionar { get; set; }
        public string Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public decimal Total { get; set; }
        public decimal Saldo { get; set; }
    }

    public class Recibo : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }  // inicialízalo en la vista
        public string Cliente { get; set; }
        public decimal Monto { get; set; }
        public string Observaciones { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void Raise(string prop)
        {
            var h = PropertyChanged;
            if (h != null) h(this, new PropertyChangedEventArgs(prop));
        }
    }
}
