using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Capa_Modelo_CxC
{
    public interface IRepositorioCxC
    {
        BindingList<FacturaPendiente> ListarFacturas(string cliente, DateTime? desde, DateTime? hasta);
        BindingList<Recibo> ListarRecibos();
        Recibo CrearRecibo(Recibo r);
        void EditarRecibo(Recibo r);
        void AnularRecibo(int id);
        Recibo ObtenerRecibo(int id);
    }

    public class RepositorioMemoriaCxC : IRepositorioCxC
    {
        private readonly BindingList<FacturaPendiente> _facturas;
        private readonly BindingList<Recibo> _recibos;
        private int _seq = 1000;

        public RepositorioMemoriaCxC()
        {
            _facturas = new BindingList<FacturaPendiente>(new List<FacturaPendiente>
            {
                new FacturaPendiente{ Seleccionar=false, Numero="F-0001", Fecha=DateTime.Today.AddDays(-2), Cliente="Hotel San Carlos", Total=1250m, Saldo=450m },
                new FacturaPendiente{ Seleccionar=false, Numero="F-0002", Fecha=DateTime.Today.AddDays(-15), Cliente="Bonanza Tecpán", Total=980m, Saldo=980m },
                new FacturaPendiente{ Seleccionar=false, Numero="F-0003", Fecha=DateTime.Today.AddDays(-33), Cliente="Cliente Contado", Total=300m, Saldo=120m },
            });

            _recibos = new BindingList<Recibo>(new List<Recibo>
            {
                new Recibo{ Id=GenId(), Fecha=DateTime.Today.AddDays(-1), Cliente="Hotel San Carlos", Monto=800m, Observaciones="Abono reserva" }
            });
        }

        private int GenId() { _seq++; return _seq; }

        public BindingList<FacturaPendiente> ListarFacturas(string cliente, DateTime? desde, DateTime? hasta)
        {
            IEnumerable<FacturaPendiente> q = _facturas;
            if (!string.IsNullOrWhiteSpace(cliente))
                q = q.Where(f => f.Cliente != null && f.Cliente.IndexOf(cliente, StringComparison.OrdinalIgnoreCase) >= 0);
            if (desde.HasValue)
                q = q.Where(f => f.Fecha.Date >= desde.Value.Date);
            if (hasta.HasValue)
                q = q.Where(f => f.Fecha.Date <= hasta.Value.Date);

            return new BindingList<FacturaPendiente>(q.ToList());
        }

        public BindingList<Recibo> ListarRecibos() { return _recibos; }

        public Recibo CrearRecibo(Recibo r)
        {
            r.Id = GenId();
            _recibos.Add(r);
            return r;
        }

        public void EditarRecibo(Recibo r)
        {
            int idx = -1;
            for (int i = 0; i < _recibos.Count; i++)
                if (_recibos[i].Id == r.Id) { idx = i; break; }

            if (idx >= 0)
            {
                _recibos[idx].Fecha = r.Fecha;
                _recibos[idx].Cliente = r.Cliente;
                _recibos[idx].Monto = r.Monto;
                _recibos[idx].Observaciones = r.Observaciones;
                _recibos[idx].Raise("Monto");
            }
        }

        public void AnularRecibo(int id)
        {
            Recibo r = null;
            foreach (var x in _recibos) { if (x.Id == id) { r = x; break; } }
            if (r != null) _recibos.Remove(r);
        }

        public Recibo ObtenerRecibo(int id)
        {
            foreach (var x in _recibos) if (x.Id == id) return x;
            return null;
        }
    }
}
