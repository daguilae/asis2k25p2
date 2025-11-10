using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Capa_Controlador_CxC;

namespace Capa_Vista_CxC
{
    public partial class Frm_AplicarPago : Form
    {
        private readonly Cls_Controlador _ctrl = new Cls_Controlador();
        private DataTable _dt;   // datasource de la grilla
        public Frm_AplicarPago()
        {
            InitializeComponent();

            // 1) Asegurar que el botón existe y habilitarlo
            // (si tu nombre es distinto, cambia "Btn_AgregarLineaPago")
            Control[] hits = this.Controls.Find("Btn_AgregarLineaPago", true);
            if (hits.Length > 0 && hits[0] is Button)
            {
                var b = (Button)hits[0];
                b.Enabled = true;
                // 2) Conectar el evento si no lo está
                b.Click -= Btn_AgregarLineaPago_Click;   // evita doble suscripción
                b.Click += Btn_AgregarLineaPago_Click;
            }

            // Haz lo mismo para Guardar/Cancelar si están grises:
            hits = this.Controls.Find("Btn_GuardarPago", true);
            if (hits.Length > 0 && hits[0] is Button) ((Button)hits[0]).Enabled = true;

            hits = this.Controls.Find("Btn_CancelarPago", true);
            if (hits.Length > 0 && hits[0] is Button) ((Button)hits[0]).Enabled = true;

            PrepararUi();
            RefrescarGrid();
        }

        // -------------------- UI / Binding --------------------
        private void PrepararUi()
        {
            // Asegurar columna oculta "Id" para editar/eliminar por Id
            if (!gridLineasPago.Columns.Contains("colLPId"))
            {
                var colId = new DataGridViewTextBoxColumn();
                colId.Name = "colLPId";
                colId.HeaderText = "Id";
                colId.DataPropertyName = "Id";
                colId.Visible = false;
                gridLineasPago.Columns.Insert(0, colId);
            }

            // Mapear columnas del Designer a nombres de DataTable
            if (gridLineasPago.Columns.Contains("colLPFactura")) colLPFactura.DataPropertyName = "Factura";
            if (gridLineasPago.Columns.Contains("colLPCliente")) colLPCliente.DataPropertyName = "Cliente";
            if (gridLineasPago.Columns.Contains("colLPSaldo")) colLPSaldo.DataPropertyName = "Saldo";
            if (gridLineasPago.Columns.Contains("colLPMonto")) colLPMonto.DataPropertyName = "Monto";
            if (gridLineasPago.Columns.Contains("colLPMetodo")) colLPMetodo.DataPropertyName = "Método";
            if (gridLineasPago.Columns.Contains("colLPRef")) colLPRef.DataPropertyName = "Referencia";

            // Valores por defecto
            if (Cbo_Metodo.Items.Count == 0)
            {
                Cbo_Metodo.Items.Add("Efectivo");
                Cbo_Metodo.Items.Add("Tarjeta");
                Cbo_Metodo.Items.Add("Transferencia");
                Cbo_Metodo.Items.Add("Cheque");
            }
            if (Cbo_Metodo.SelectedIndex < 0) Cbo_Metodo.SelectedIndex = 0;

            Dtp_FechaPago.Value = DateTime.Today;

            // Eventos
            Btn_AgregarLineaPago.Click += Btn_AgregarLineaPago_Click;
            Btn_GuardarPago.Click += Btn_GuardarPago_Click;
            Btn_CancelarPago.Click += Btn_CancelarPago_Click;

            gridLineasPago.CellDoubleClick += GridLineasPago_CellDoubleClick; // editar
            gridLineasPago.KeyDown += GridLineasPago_KeyDown;                 // eliminar con Supr
        }


        private void RefrescarGrid()
        {
            _dt = _ctrl.ObtenerLineasPagoDT();
            gridLineasPago.AutoGenerateColumns = false;
            gridLineasPago.DataSource = _dt;

            Txt_TotalPago.Text = _ctrl.TotalLineasPago()
                                   .ToString("0.00", CultureInfo.InvariantCulture);
        }

        // -------------------- Handlers --------------------
        private void Btn_AgregarLineaPago_Click(object sender, EventArgs e)
        {
            try
            {
                // Para el prototipo: pedimos datos mínimos que aún no están en UI
                string factura = InputBox("Factura", "Número de factura (opcional):", "");
                string cliente = InputBox("Cliente", "Nombre del cliente:", "");
                if (string.IsNullOrWhiteSpace(cliente))
                    throw new ArgumentException("Cliente requerido.");

                string sSaldo = InputBox("Saldo", "Saldo actual (opcional):", "0.00");
                decimal saldo;
                if (!decimal.TryParse(sSaldo, NumberStyles.Any, CultureInfo.InvariantCulture, out saldo)) saldo = 0m;

                decimal monto;
                if (!decimal.TryParse(Txt_Monto.Text.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out monto) || monto <= 0)
                    throw new ArgumentException("Monto inválido.");

                string metodo = Cbo_Metodo.SelectedItem == null ? "" : Cbo_Metodo.SelectedItem.ToString();
                string referencia = Txt_Referencia.Text.Trim();

                _ctrl.AgregarLineaPago(factura, cliente, saldo, monto, metodo, referencia);

                // limpiar inputs de encabezado
                Txt_Monto.Clear();
                Txt_Referencia.Clear();
                Txt_Monto.Focus();

                RefrescarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No se pudo agregar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void GridLineasPago_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridLineasPago.CurrentRow == null) return;
            var drv = gridLineasPago.CurrentRow.DataBoundItem as DataRowView;
            if (drv == null) return;

            int id = Convert.ToInt32(drv.Row["Id"]);
            string factura = Convert.ToString(drv.Row["Factura"]);
            string cliente = Convert.ToString(drv.Row["Cliente"]);
            decimal saldo = Convert.ToDecimal(drv.Row["Saldo"]);
            decimal monto = Convert.ToDecimal(drv.Row["Monto"]);
            string metodo = Convert.ToString(drv.Row["Método"]);
            string referencia = Convert.ToString(drv.Row["Referencia"]);

            // pedir nuevos valores
            factura = InputBox("Editar factura", "Factura:", factura);
            cliente = InputBox("Editar cliente", "Cliente:", cliente);

            string sSaldo = InputBox("Editar saldo", "Saldo:", saldo.ToString("0.00", CultureInfo.InvariantCulture));
            decimal nSaldo;
            if (!decimal.TryParse(sSaldo, NumberStyles.Any, CultureInfo.InvariantCulture, out nSaldo)) nSaldo = 0m;

            string sMonto = InputBox("Editar monto", "Monto:", monto.ToString("0.00", CultureInfo.InvariantCulture));
            decimal nMonto;
            if (!decimal.TryParse(sMonto, NumberStyles.Any, CultureInfo.InvariantCulture, out nMonto) || nMonto <= 0)
            {
                MessageBox.Show("Monto inválido.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            metodo = InputBox("Editar método", "Método:", metodo);
            referencia = InputBox("Editar referencia", "Referencia:", referencia);

            try
            {
                _ctrl.EditarLineaPago(id, factura, cliente, nSaldo, nMonto, metodo, referencia);
                RefrescarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No se pudo editar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void GridLineasPago_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && gridLineasPago.CurrentRow != null)
            {
                var drv = gridLineasPago.CurrentRow.DataBoundItem as DataRowView;
                if (drv == null) return;
                int id = Convert.ToInt32(drv.Row["Id"]);

                if (MessageBox.Show("¿Eliminar la línea seleccionada?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _ctrl.EliminarLineaPago(id);
                    RefrescarGrid();
                }
            }
        }

        private void Btn_GuardarPago_Click(object sender, EventArgs e)
        {
            try
            {
                string cliente = InputBox("Cliente", "Cliente del pago:", "");
                if (string.IsNullOrWhiteSpace(cliente)) throw new ArgumentException("Cliente requerido.");

                string metodo = Cbo_Metodo.SelectedItem == null ? "" : Cbo_Metodo.SelectedItem.ToString();
                string referencia = Txt_Referencia.Text.Trim();

                int noRecibo = _ctrl.GuardarPagoAplicado(Dtp_FechaPago.Value.Date, cliente, metodo, referencia);

                MessageBox.Show("Pago guardado. Recibo #" + noRecibo, "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefrescarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No se pudo guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Btn_CancelarPago_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Cancelar y limpiar todas las líneas?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _ctrl.LimpiarLineasPago();
                RefrescarGrid();
            }
        }

        // -------------------- Utilitario --------------------
        private string InputBox(string titulo, string prompt, string valorPorDefecto)
        {
            var f = new Form();
            f.Width = 420; f.Height = 160; f.FormBorderStyle = FormBorderStyle.FixedDialog;
            f.Text = titulo; f.StartPosition = FormStartPosition.CenterParent;

            var lbl = new Label(); lbl.Left = 10; lbl.Top = 10; lbl.Width = 380; lbl.Text = prompt;
            var tb = new TextBox(); tb.Left = 10; tb.Top = 35; tb.Width = 380; tb.Text = valorPorDefecto ?? "";
            var ok = new Button(); ok.Text = "OK"; ok.Left = 230; ok.Width = 75; ok.Top = 70; ok.DialogResult = DialogResult.OK;
            var cancel = new Button(); cancel.Text = "Cancelar"; cancel.Left = 315; cancel.Width = 75; cancel.Top = 70; cancel.DialogResult = DialogResult.Cancel;

            f.Controls.Add(lbl); f.Controls.Add(tb); f.Controls.Add(ok); f.Controls.Add(cancel);
            f.AcceptButton = ok; f.CancelButton = cancel;

            return f.ShowDialog(this) == DialogResult.OK ? tb.Text : (valorPorDefecto ?? "");
        }
        private void mnuRecibos_Click(object sender, EventArgs e)
        {
            Frm_AplicarPago Recibos = new Frm_AplicarPago();
            Recibos.Show();
            this.Close();
        }
        private void Frm_AplicarPago_Load(object sender, EventArgs e)
        {
            Btn_AgregarLineaPago.Enabled = true;
            Btn_GuardarPago.Enabled = true;
            Btn_CancelarPago.Enabled = true;
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
