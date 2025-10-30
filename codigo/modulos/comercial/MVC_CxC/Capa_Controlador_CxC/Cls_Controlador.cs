using System;
using System.ComponentModel;
using System.Data;
using Capa_Modelo_CxC;

namespace Capa_Controlador_CxC
{
    public class Cls_Controlador
    {
        private readonly IRepositorioCxC _repo;

        public Cls_Controlador() : this(new RepositorioMemoriaCxC()) { }
        public Cls_Controlador(IRepositorioCxC repo) { _repo = repo; }

        // ---------- FACTURAS (DataTable) ----------
        public DataTable ObtenerFacturasDT(string cliente, DateTime? desde, DateTime? hasta)
        {
            BindingList<FacturaPendiente> list = _repo.ListarFacturas(cliente, desde, hasta);
            var dt = new DataTable();
            dt.Columns.Add("Factura", typeof(string));
            dt.Columns.Add("Fecha", typeof(DateTime));
            dt.Columns.Add("Cliente", typeof(string));
            dt.Columns.Add("Total", typeof(decimal));
            dt.Columns.Add("Saldo", typeof(decimal));

            foreach (var f in list)
                dt.Rows.Add(f.Numero, f.Fecha, f.Cliente, f.Total, f.Saldo);

            return dt;
        }

        // ---------- RECIBOS (DataTable) ----------
        public DataTable ObtenerRecibosDT()
        {
            BindingList<Recibo> list = _repo.ListarRecibos();
            var dt = new DataTable();
            dt.Columns.Add("Recibo", typeof(int));
            dt.Columns.Add("Fecha", typeof(DateTime));
            dt.Columns.Add("Cliente", typeof(string));
            dt.Columns.Add("Monto", typeof(decimal));
            dt.Columns.Add("Observaciones", typeof(string));

            foreach (var r in list)
                dt.Rows.Add(r.Id, r.Fecha, r.Cliente, r.Monto, r.Observaciones ?? "");

            return dt;
        }

        // ---------- CRUD RECIBO ----------
        public int CrearRecibo(DateTime fecha, string cliente, decimal monto, string obs)
        {
            if (string.IsNullOrWhiteSpace(cliente)) throw new ArgumentException("Cliente requerido");
            if (monto <= 0) throw new ArgumentException("Monto debe ser mayor a 0");

            var r = _repo.CrearRecibo(new Recibo
            {
                Fecha = fecha,
                Cliente = cliente.Trim(),
                Monto = monto,
                Observaciones = (obs ?? "").Trim()
            });
            return r.Id;
        }

        public void EditarRecibo(int id, DateTime fecha, string cliente, decimal monto, string obs)
        {
            if (id <= 0) throw new ArgumentException("Id inválido");
            if (string.IsNullOrWhiteSpace(cliente)) throw new ArgumentException("Cliente requerido");
            if (monto <= 0) throw new ArgumentException("Monto debe ser mayor a 0");

            _repo.EditarRecibo(new Recibo
            {
                Id = id,
                Fecha = fecha,
                Cliente = cliente.Trim(),
                Monto = monto,
                Observaciones = (obs ?? "").Trim()
            });
        }

        public void AnularRecibo(int id)
        {
            if (id <= 0) throw new ArgumentException("Seleccione un recibo válido");
            _repo.AnularRecibo(id);
        }
    }
}
