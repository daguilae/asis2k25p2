using System;
using System.Data;
using System.Windows.Forms;
using Capa_Modelo_CxP;

namespace Capa_Vista_CxP
{
    public partial class Frm_CxP_Pagos_Historial : Form
    {
        // Modelo CxP
        private readonly Cls_Sentencias_CxP_Pagos _mdlPagos = new Cls_Sentencias_CxP_Pagos();

        public Frm_CxP_Pagos_Historial()
        {
            InitializeComponent();

            this.Load += Frm_CxP_Pagos_Historial_Load;
            btnBuscar.Click += btnBuscar_Click;
            btnLimpiar.Click += btnLimpiar_Click;
            btnExportar.Click += btnExportar_Click;
        }

        // ================== LOAD ==================
        private void Frm_CxP_Pagos_Historial_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Today.AddMonths(-1);
            dtpHasta.Value = DateTime.Today;

            nudMontoDesde.Value = 0;
            nudMontoHasta.Value = 0;

            cboOrdenar.Items.Clear();
            cboOrdenar.Items.Add("FechaDesc");   // 0
            cboOrdenar.Items.Add("FechaAsc");    // 1
            cboOrdenar.Items.Add("MontoDesc");   // 2
            cboOrdenar.Items.Add("MontoAsc");    // 3
            cboOrdenar.SelectedIndex = 0;

            CargarHistorial();
        }

        // ================== CARGAR DATOS ==================
        private void CargarHistorial()
        {
            DateTime desde = dtpDesde.Value.Date;
            DateTime hasta = dtpHasta.Value.Date;
            if (hasta < desde)
                hasta = desde;

            string ordenar = "";
            switch (cboOrdenar.SelectedIndex)
            {
                case 0: ordenar = "FechaDesc"; break;
                case 1: ordenar = "FechaAsc"; break;
                case 2: ordenar = "MontoDesc"; break;
                case 3: ordenar = "MontoAsc"; break;
            }

            DataTable dt = _mdlPagos.Pagos_Historial(desde, hasta, ordenar);

            dgvPagos.DataSource = dt;
            dgvPagos.AutoResizeColumns();

            // Registros
            lblRegistros.Text = $"Registros: {dt.Rows.Count}";

            // Total pagado
            decimal total = 0m;
            foreach (DataRow row in dt.Rows)
            {
                if (row["TotalPago"] != DBNull.Value)
                    total += Convert.ToDecimal(row["TotalPago"]);
            }
            lblTotalPagado.Text = $"Total pagado: {total:N2}";
        }


        // ================== BOTONES ==================
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarHistorial();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Today.AddMonths(-1);
            dtpHasta.Value = DateTime.Today;

            nudMontoDesde.Value = 0;
            nudMontoHasta.Value = 0;

            cboOrdenar.SelectedIndex = 0;

            CargarHistorial();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dgvPagos.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "CxP",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("Función de exportar pendiente de implementar.", "CxP",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
