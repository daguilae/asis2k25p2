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
        // =======================================================
        // ===============  APLICAR PAGO (BUFFER)  ===============
        // =======================================================

        #region AplicarPago (buffer local en memoria)
        // Buffer de líneas de pago (en memoria, sin tocar el Modelo aún)
        private DataTable _bufferLineasPago;
        private int _seqLineaPago = 0;

        private void EnsureBuffer()
        {
            if (_bufferLineasPago != null) return;

            _bufferLineasPago = new DataTable("BufferLineasPago");
            _bufferLineasPago.Columns.Add("Id", typeof(int));          // ocultable en la Vista
            _bufferLineasPago.Columns.Add("Factura", typeof(string));
            _bufferLineasPago.Columns.Add("Cliente", typeof(string));
            _bufferLineasPago.Columns.Add("Saldo", typeof(decimal));
            _bufferLineasPago.Columns.Add("Monto", typeof(decimal));
            _bufferLineasPago.Columns.Add("Método", typeof(string));
            _bufferLineasPago.Columns.Add("Referencia", typeof(string));
        }

        // Devuelve el DataTable que consume la Vista (grilla)
        public DataTable ObtenerLineasPagoDT()
        {
            EnsureBuffer();
            return _bufferLineasPago;
        }

        // Agregar línea
        public int AgregarLineaPago(string factura, string cliente, decimal saldo, decimal monto, string metodo, string referencia)
        {
            if (string.IsNullOrWhiteSpace(cliente))
                throw new ArgumentException("Cliente requerido.");
            if (monto <= 0)
                throw new ArgumentException("El monto debe ser mayor a 0.");

            EnsureBuffer();

            _seqLineaPago++;
            _bufferLineasPago.Rows.Add(
                _seqLineaPago,
                string.IsNullOrWhiteSpace(factura) ? "SIN-FACTURA" : factura.Trim(),
                cliente.Trim(),
                saldo < 0 ? 0m : saldo,
                monto,
                (metodo ?? "").Trim(),
                (referencia ?? "").Trim()
            );

            return _seqLineaPago;
        }

        // Editar línea (por Id)
        public void EditarLineaPago(int id, string factura, string cliente, decimal saldo, decimal monto, string metodo, string referencia)
        {
            if (id <= 0) throw new ArgumentException("Id de línea inválido.");
            if (string.IsNullOrWhiteSpace(cliente)) throw new ArgumentException("Cliente requerido.");
            if (monto <= 0) throw new ArgumentException("El monto debe ser mayor a 0.");

            EnsureBuffer();

            DataRow target = null;
            foreach (DataRow r in _bufferLineasPago.Rows)
                if (Convert.ToInt32(r["Id"]) == id) { target = r; break; }

            if (target == null) throw new ArgumentException("Línea no encontrada.");

            target["Factura"] = string.IsNullOrWhiteSpace(factura) ? "SIN-FACTURA" : factura.Trim();
            target["Cliente"] = cliente.Trim();
            target["Saldo"] = saldo < 0 ? 0m : saldo;
            target["Monto"] = monto;
            target["Método"] = (metodo ?? "").Trim();
            target["Referencia"] = (referencia ?? "").Trim();
        }

        // Eliminar línea (por Id)
        public void EliminarLineaPago(int id)
        {
            if (id <= 0) throw new ArgumentException("Id de línea inválido");

            EnsureBuffer();

            DataRow target = null;
            foreach (DataRow r in _bufferLineasPago.Rows)
                if (Convert.ToInt32(r["Id"]) == id) { target = r; break; }

            if (target != null) _bufferLineasPago.Rows.Remove(target);
        }

        // Limpiar todas las líneas
        public void LimpiarLineasPago()
        {
            EnsureBuffer();
            _bufferLineasPago.Clear();
            _seqLineaPago = 0;
        }

        // Total del pago (suma de Monto)
        public decimal TotalLineasPago()
        {
            EnsureBuffer();
            decimal total = 0m;
            foreach (DataRow r in _bufferLineasPago.Rows)
                total += Convert.ToDecimal(r["Monto"]);
            return total;
        }

        // Guardar pago: genera Recibo usando el total y limpia buffer
        public int GuardarPagoAplicado(DateTime fecha, string cliente, string metodo, string referencia)
        {
            EnsureBuffer();

            if (_bufferLineasPago.Rows.Count == 0)
                throw new ArgumentException("No hay líneas de pago para guardar.");

            if (string.IsNullOrWhiteSpace(cliente))
                throw new ArgumentException("Cliente requerido.");

            decimal total = TotalLineasPago();

            // Persistimos solo el encabezado de recibo usando el repositorio existente:
            int nuevoId = CrearRecibo(fecha, cliente.Trim(), total, "Pago aplicado. " + (referencia ?? "").Trim());

            // (Más adelante, cuando movamos esto al Modelo, aquí guardaremos el detalle y afectaremos saldos)
            LimpiarLineasPago();
            return nuevoId;
        }
        #endregion

    }
}
