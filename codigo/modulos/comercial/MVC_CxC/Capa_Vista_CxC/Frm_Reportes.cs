using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Capa_Controlador_CxC;

namespace Capa_Vista_CxC
{
    public partial class Frm_Reportes : Form
    {
        private readonly Cls_Controlador _ctrl = new Cls_Controlador();
        private DataTable _dt;

        public Frm_Reportes()
        {
            InitializeComponent();
            Load += Frm_Reportes_Load;
            cboTipo.SelectedIndexChanged += (s, e) => ToggleParametros();
            btnVer.Click += (s, e) => Ver();
            btnExportar.Click += (s, e) => ExportarCsv();
            btnImprimir.Click += (s, e) => PrintPreview();
        }

        private void Frm_Reportes_Load(object sender, EventArgs e)
        {
            // Tipos
            cboTipo.Items.Clear();
            cboTipo.Items.Add("Antigüedad");
            cboTipo.Items.Add("Cierre de caja");
            cboTipo.SelectedIndex = 0;

            // Fechas por defecto
            dtpCorte.Value = DateTime.Today;
            dtpFechaCaja.Value = DateTime.Today;

            // Obtener clientes como DataTable
            var clientes = _ctrl.ObtenerClientes();

            // Determinar columnas (ajusta si tus nombres son otros)
            string colId = clientes.Columns.Contains("Cmp_Id_Cliente") ? "Cmp_Id_Cliente"
                           : clientes.Columns.Contains("IdCliente") ? "IdCliente"
                           : clientes.Columns[0].ColumnName;

            string colName = clientes.Columns.Contains("Cmp_Nombre_Cliente") ? "Cmp_Nombre_Cliente"
                           : clientes.Columns.Contains("Cliente") ? "Cliente"
                           : clientes.Columns[1].ColumnName;

            // Insertar opción "(Todos)" al inicio
            var filaTodos = clientes.NewRow();
            filaTodos[colId] = 0;
            filaTodos[colName] = "(Todos)";
            clientes.Rows.InsertAt(filaTodos, 0);

            // Enlazar combo
            cboCliente.DataSource = clientes;
            cboCliente.DisplayMember = colName;
            cboCliente.ValueMember = colId;
            cboCliente.SelectedIndex = 0;

        }

        private void ToggleParametros()
        {
            bool esAntig = cboTipo.SelectedItem != null && cboTipo.SelectedItem.ToString() == "Antigüedad";

            // Antigüedad visible
            lblCliente.Visible = esAntig;
            cboCliente.Visible = esAntig;
            lblCorte.Visible = esAntig;
            dtpCorte.Visible = esAntig;

            // Cierre visible
            lblFechaCaja.Visible = !esAntig;
            dtpFechaCaja.Visible = !esAntig;

            // Total (solo cierre)
            lblTotal.Text = "";
        }

        private void Ver()
        {
            if (cboTipo.SelectedItem == null) { MessageBox.Show("Seleccione un tipo de reporte."); return; }

            string tipo = cboTipo.SelectedItem.ToString();

            if (tipo == "Antigüedad")
            {
                // Validaciones mínimas
                DateTime corte = dtpCorte.Value.Date;

                string cli = null;
                if (cboCliente.SelectedIndex > 0) cli = cboCliente.SelectedItem.ToString();

                _dt = _ctrl.ObtenerAntiguedadDT(corte, cli);
                gridReporte.DataSource = _dt;

                // Headers bonitos
                if (gridReporte.Columns.Contains("0_30")) gridReporte.Columns["0_30"].HeaderText = "0–30";
                if (gridReporte.Columns.Contains("31_60")) gridReporte.Columns["31_60"].HeaderText = "31–60";
                if (gridReporte.Columns.Contains("61_90")) gridReporte.Columns["61_90"].HeaderText = "61–90";
                if (gridReporte.Columns.Contains("Mas_90")) gridReporte.Columns["Mas_90"].HeaderText = ">90";

                lblTotal.Text = ""; // no aplica
            }
            else // Cierre de caja
            {
                DateTime fecha = dtpFechaCaja.Value.Date;
                decimal total;
                _dt = _ctrl.ObtenerCajaDiaDT(fecha, out total);
                gridReporte.DataSource = _dt;
                lblTotal.Text = "Total del día: " + total.ToString("0.00");
            }
        }

        // ===== utilidades simples =====
        private void ExportarCsv()
        {
            if (_dt == null || _dt.Rows.Count == 0) { MessageBox.Show("No hay datos para exportar."); return; }
            var sfd = new SaveFileDialog { Filter = "CSV|*.csv", FileName = "reporte.csv" };
            if (sfd.ShowDialog(this) != DialogResult.OK) return;

            var sb = new StringBuilder();
            for (int c = 0; c < _dt.Columns.Count; c++)
            {
                if (c > 0) sb.Append(",");
                sb.Append("\"" + _dt.Columns[c].ColumnName.Replace("\"", "\"\"") + "\"");
            }
            sb.AppendLine();
            for (int r = 0; r < _dt.Rows.Count; r++)
            {
                for (int c = 0; c < _dt.Columns.Count; c++)
                {
                    if (c > 0) sb.Append(",");
                    string val = _dt.Rows[r][c] == null ? "" : _dt.Rows[r][c].ToString();
                    sb.Append("\"" + val.Replace("\"", "\"\"") + "\"");
                }
                sb.AppendLine();
            }
            File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
            MessageBox.Show("Exportado.");
        }

        private void PrintPreview()
        {
            if (_dt == null || _dt.Rows.Count == 0) { MessageBox.Show("No hay datos para imprimir."); return; }
            // CTRL + P
            // mantener este botón para futura integración con PrintDocument/RDLC.
            MessageBox.Show("Impresión básica pendiente (opcional).");
        }

        private void mnuRecibos_Click(object sender, EventArgs e)
        {
            Frm_AplicarPago Recibos = new Frm_AplicarPago();
            Recibos.Show();
            this.Close();
        }

        private void mnuAplicarPago_Click(object sender, EventArgs e)
        {
            Frm_AplicarPago frm = new Frm_AplicarPago();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
