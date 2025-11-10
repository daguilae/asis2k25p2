using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Capa_Controlador_CxC;

namespace Capa_Vista_CxC
{
    public partial class Frm_Recibos : Form
    {
        private readonly Cls_Controlador _ctrl;
        private DataTable _dtFacturas;
        private DataTable _dtRecibos;

        public Frm_Recibos()
        {
            InitializeComponent();
            _ctrl = new Cls_Controlador();
            PrepararUi();
            CargarDatosIniciales();
        }

        private void PrepararUi()
        {
            Btn_NuevoRecibo.Enabled = true;
            Btn_EditarRecibo.Enabled = true;
            Btn_AnularRecibo.Enabled = true;
            Btn_Filtrar.Enabled = true;
            Btn_Limpiar.Enabled = true;

            // DataPropertyName para DataTable (debe coincidir con nombres de columnas)
            colFactura.DataPropertyName = "Factura";
            colFecha.DataPropertyName = "Fecha";
            colCliente.DataPropertyName = "Cliente";
            colTotal.DataPropertyName = "Total";
            colSaldo.DataPropertyName = "Saldo";

            colRecibo.DataPropertyName = "Recibo";
            colReciboFecha.DataPropertyName = "Fecha";
            colReciboCliente.DataPropertyName = "Cliente";
            colReciboMonto.DataPropertyName = "Monto";

            Dgv_Facturas.MultiSelect = false;
            gridRecibos.MultiSelect = false;

            Btn_Filtrar.Click += (s, e) => AplicarFiltro();
            Btn_Limpiar.Click += (s, e) => LimpiarFiltros();
            Btn_NuevoRecibo.Click += (s, e) => CrearRecibo();
            Btn_EditarRecibo.Click += (s, e) => EditarRecibo();
            Btn_AnularRecibo.Click += (s, e) => AnularRecibo();
            Dgv_Facturas.CellDoubleClick += (s, e) => PasarFacturaARecibo();
        }

        private void CargarDatosIniciales()
        {
            _dtFacturas = _ctrl.ObtenerFacturasDT("", null, null);
            Dgv_Facturas.DataSource = _dtFacturas;

            _dtRecibos = _ctrl.ObtenerRecibosDT();
            gridRecibos.DataSource = _dtRecibos;

            Dtp_Desde.Value = DateTime.Today.AddDays(-30);
            Dtp_Hasta.Value = DateTime.Today;
            Dtp_FechaRecibo.Value = DateTime.Today;
        }

        private void AplicarFiltro()
        {
            string cliente = (Txt_BuscarCliente.Text ?? "").Trim();
            DateTime? desde = Dtp_Desde.Value.Date;
            DateTime? hasta = Dtp_Hasta.Value.Date;

            _dtFacturas = _ctrl.ObtenerFacturasDT(cliente, desde, hasta);
            Dgv_Facturas.DataSource = _dtFacturas;
        }

        private void LimpiarFiltros()
        {
            Txt_BuscarCliente.Clear();
            Dtp_Desde.Value = DateTime.Today.AddDays(-30);
            Dtp_Hasta.Value = DateTime.Today;
            AplicarFiltro();
        }

        private void CrearRecibo()
        {
            try
            {
                string cliente = "";
                decimal montoSugerido = 0m;

                if (Dgv_Facturas.CurrentRow != null)
                {
                    var row = (Dgv_Facturas.CurrentRow.DataBoundItem as DataRowView).Row;
                    cliente = Convert.ToString(row["Cliente"]);
                    decimal saldo = Convert.ToDecimal(row["Saldo"]);
                    decimal total = Convert.ToDecimal(row["Total"]);
                    montoSugerido = (saldo < total) ? saldo : total;
                }

                if (string.IsNullOrWhiteSpace(cliente))
                    cliente = InputBox("Cliente", "Ingrese el nombre del cliente:", cliente);

                string montoStr = InputBox("Monto", "Ingrese el monto del recibo:",
                                            montoSugerido.ToString("0.00", CultureInfo.InvariantCulture));

                decimal monto;
                if (!decimal.TryParse(montoStr, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out monto) || monto <= 0)
                    throw new ArgumentException("Monto inválido");

                int nuevoId = _ctrl.CrearRecibo(Dtp_FechaRecibo.Value.Date, cliente, monto, Txt_Obs.Text);

                // refrescar grilla de recibos
                _dtRecibos = _ctrl.ObtenerRecibosDT();
                gridRecibos.DataSource = _dtRecibos;

                // limpiar obs y seleccionar el nuevo si lo ves necesario
                Txt_Obs.Clear();

                MessageBox.Show("Recibo creado correctamente (#" + nuevoId + ").", "OK",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al crear", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EditarRecibo()
        {
            try
            {
                if (gridRecibos.CurrentRow == null)
                    throw new ArgumentException("Seleccione un recibo para editar");

                var row = (gridRecibos.CurrentRow.DataBoundItem as DataRowView).Row;
                int id = Convert.ToInt32(row["Recibo"]);
                string clienteActual = Convert.ToString(row["Cliente"]);
                decimal montoActual = Convert.ToDecimal(row["Monto"]);
                string obsActual = row.Table.Columns.Contains("Observaciones")
                    ? Convert.ToString(row["Observaciones"]) : "";

                string nuevoCliente = InputBox("Cliente", "Actualice el cliente:", clienteActual);
                string nuevoMontoStr = InputBox("Monto", "Actualice el monto:",
                    montoActual.ToString("0.00", CultureInfo.InvariantCulture));

                decimal nuevoMonto;
                if (!decimal.TryParse(nuevoMontoStr, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out nuevoMonto) || nuevoMonto <= 0)
                    throw new ArgumentException("Monto inválido");

                string nuevasObs = InputBox("Observaciones", "Actualice las observaciones:", obsActual);

                _ctrl.EditarRecibo(id, Dtp_FechaRecibo.Value.Date, nuevoCliente, nuevoMonto, nuevasObs);

                // refrescar
                _dtRecibos = _ctrl.ObtenerRecibosDT();
                gridRecibos.DataSource = _dtRecibos;

                MessageBox.Show("Recibo actualizado.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al editar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AnularRecibo()
        {
            try
            {
                if (gridRecibos.CurrentRow == null)
                    throw new ArgumentException("Seleccione un recibo para anular");

                var row = (gridRecibos.CurrentRow.DataBoundItem as DataRowView).Row;
                int id = Convert.ToInt32(row["Recibo"]);

                if (MessageBox.Show("¿Anular el recibo #" + id + "?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _ctrl.AnularRecibo(id);
                    _dtRecibos = _ctrl.ObtenerRecibosDT();
                    gridRecibos.DataSource = _dtRecibos;
                    MessageBox.Show("Recibo anulado.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al anular", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PasarFacturaARecibo()
        {
            if (Dgv_Facturas.CurrentRow == null) return;
            var row = (Dgv_Facturas.CurrentRow.DataBoundItem as DataRowView).Row;
            string numero = Convert.ToString(row["Factura"]);
            Txt_NumeroRecibo.Text = ""; // lo genera el repo
            Dtp_FechaRecibo.Value = DateTime.Today;
            Txt_Obs.Text = "Pago relacionado a " + numero;
        }

        // InputBox simple
        private string InputBox(string titulo, string prompt, string valorPorDefecto)
        {
            var form = new Form();
            form.Width = 420;
            form.Height = 160;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.Text = titulo;
            form.StartPosition = FormStartPosition.CenterParent;

            var label = new Label();
            label.Left = 10; label.Top = 10; label.Width = 380; label.Text = prompt;

            var tb = new TextBox();
            tb.Left = 10; tb.Top = 35; tb.Width = 380; tb.Text = valorPorDefecto ?? "";

            var ok = new Button();
            ok.Text = "OK"; ok.Left = 230; ok.Width = 75; ok.Top = 70; ok.DialogResult = DialogResult.OK;

            var cancel = new Button();
            cancel.Text = "Cancelar"; cancel.Left = 315; cancel.Width = 75; cancel.Top = 70; cancel.DialogResult = DialogResult.Cancel;

            form.Controls.Add(label);
            form.Controls.Add(tb);
            form.Controls.Add(ok);
            form.Controls.Add(cancel);
            form.AcceptButton = ok;
            form.CancelButton = cancel;

            return form.ShowDialog(this) == DialogResult.OK ? tb.Text : (valorPorDefecto ?? "");
        }

        private void mnuAplicarPago_Click(object sender, EventArgs e)
        {
            Frm_AplicarPago frm = new Frm_AplicarPago();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void mnuReportes_Click(object sender, EventArgs e)
        {
            Frm_Reportes repo = new Frm_Reportes();
            this.Hide();
            repo.ShowDialog();
            this.Show();
        }
    }
}
