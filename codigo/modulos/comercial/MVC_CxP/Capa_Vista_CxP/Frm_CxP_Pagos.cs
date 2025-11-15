using System;
using System.Data;
using System.Windows.Forms;
using Capa_Modelo_CxP;

namespace Capa_Vista_CxP
{
    public partial class Frm_CxP_Pagos : Form
    {
        // ---- Modelo CxP ----
        private readonly Cls_Sentencias_CxP_Pagos _mdlPagos = new Cls_Sentencias_CxP_Pagos();

        // Ajusta estos valores al usuario/metodo real
        private const int ID_USUARIO = 1;
        private const int ID_METODO_PAGO_EFECTIVO = 1;

        // Campos de trabajo (se actualizan al elegir factura)
        private int _idDocumento = 0;
        private int _idProveedor = 0;
        private decimal _totalFactura = 0m;
        private decimal _saldoPendiente = 0m;

        public Frm_CxP_Pagos()
        {
            InitializeComponent();
            this.Load += Frm_CxP_Pagos_Load;
        }

        private void Frm_CxP_Pagos_Load(object sender, EventArgs e)
        {
            // SOLO usamos el método que ya hiciste
            CargarFacturasPendientes();

            nudMontoPagar.Enabled = rdbPagoParcial.Checked;
            errorProvider1.Clear();
        }

        // ===========================================
        //  CARGA DE FACTURAS PENDIENTES AL COMBO
        // ===========================================
        private void CargarFacturasPendientes()
        {
            errorProvider1.Clear();

            DataTable dt = _mdlPagos.FacturasPendientes_Listar();

            cboFactura.DataSource = dt;

            // IMPORTANTE: este nombre debe coincidir con el alias del SELECT
            // en Cls_Sentencias_CxP_Pagos.FacturasPendientes_Listar()
            // Ejemplo en el modelo:
            //   CONCAT('[', d.Cmp_Serie, '] ', d.Cmp_Numero, ' - Q', ...) AS FacturaTexto
            cboFactura.DisplayMember = "FacturaTexto";
            cboFactura.ValueMember = "Cmp_Id_CxP_Documento";

            if (dt.Rows.Count > 0)
            {
                cboFactura.SelectedIndex = 0;
            }
            else
            {
                cboFactura.SelectedIndex = -1;
                LimpiarDatosFactura();
            }
        }

        private void LimpiarDatosFactura()
        {
            _idDocumento = 0;
            _idProveedor = 0;
            _totalFactura = 0m;
            _saldoPendiente = 0m;

            lblTotalFacturaV.Text = "0.00";
            lblPendienteV.Text = "0.00";
            nudMontoPagar.Value = 0;
        }

        private void AjustarMontoSegunTipoPago()
        {
            if (_saldoPendiente <= 0)
            {
                nudMontoPagar.Enabled = false;
                nudMontoPagar.Value = 0;
                return;
            }

            nudMontoPagar.Maximum = ToNumericUpDownValue(Math.Max(0m, _saldoPendiente));

            if (rdbPagoTotal.Checked)
            {
                nudMontoPagar.Enabled = false;
                nudMontoPagar.Value = ToNumericUpDownValue(_saldoPendiente);
            }
            else // parcial
            {
                nudMontoPagar.Enabled = true;

                if (nudMontoPagar.Value <= 0 || nudMontoPagar.Value > _saldoPendiente)
                    nudMontoPagar.Value = ToNumericUpDownValue(_saldoPendiente);
            }
        }

        // =============== Eventos del Designer ===============

        private void cboFactura_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (cboFactura.SelectedItem == null)
            {
                LimpiarDatosFactura();
                return;
            }

            DataRowView fila = (DataRowView)cboFactura.SelectedItem;

            _idDocumento = Convert.ToInt32(fila["Cmp_Id_CxP_Documento"]);
            _idProveedor = Convert.ToInt32(fila["Cmp_Id_Proveedor"]);
            _totalFactura = Convert.ToDecimal(fila["Cmp_Total_Documento"]);
            _saldoPendiente = Convert.ToDecimal(fila["Cmp_Saldo_Pendiente"]);

            lblTotalFacturaV.Text = _totalFactura.ToString("N2");
            lblPendienteV.Text = _saldoPendiente.ToString("N2");

            AjustarMontoSegunTipoPago();
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            if (_idDocumento == 0)
            {
                errorProvider1.SetError(cboFactura, "Seleccione una factura.");
                return;
            }

            // TODO: abrir un modal con el detalle de la factura (_idDocumento)
            MessageBox.Show("Detalle de factura (pendiente de implementar).", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void rdbPagoTotal_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPagoTotal.Checked)
            {
                AjustarMontoSegunTipoPago();
                errorProvider1.Clear();
            }
        }

        private void rdbPagoParcial_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPagoParcial.Checked)
            {
                AjustarMontoSegunTipoPago();
            }
        }

        private void nudMontoPagar_ValueChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            decimal monto = nudMontoPagar.Value;
            if (monto <= 0)
            {
                errorProvider1.SetError(nudMontoPagar, "Ingrese un monto mayor a 0.");
            }
            else if (monto > _saldoPendiente)
            {
                errorProvider1.SetError(nudMontoPagar, "El monto excede el saldo pendiente.");
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (_idDocumento == 0 || _idProveedor == 0)
            {
                errorProvider1.SetError(cboFactura, "Seleccione una factura válida.");
                return;
            }

            decimal monto = nudMontoPagar.Value;

            if (rdbPagoParcial.Checked)
            {
                if (monto <= 0 || monto > _saldoPendiente)
                {
                    errorProvider1.SetError(nudMontoPagar, "Monto inválido para pago parcial.");
                    return;
                }
            }
            else // pago total
            {
                monto = _saldoPendiente; // forzamos monto = saldo
            }

            try
            {
                _mdlPagos.Pago_RegistrarSimple(
                    _idDocumento,
                    _idProveedor,
                    monto,
                    dtpFechaPago.Value.Date,
                    ID_USUARIO,
                    ID_METODO_PAGO_EFECTIVO
                );

                MessageBox.Show("Pago registrado correctamente.", "CxP",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Recargar combo y datos
                CargarFacturasPendientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el pago:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIrReporte_Click(object sender, EventArgs e)
        {
            if (_idDocumento == 0)
            {
                errorProvider1.SetError(cboFactura, "Seleccione una factura para ver el reporte.");
                return;
            }

            // TODO: Abrir el formulario de CrystalReport y pasar parámetros
            MessageBox.Show("Crystal Report (pendiente de implementar).", "Reporte",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // =============== Helpers ===============

        private static decimal ToNumericUpDownValue(decimal v)
        {
            if (v < 0m) v = 0m;
            if (v > 100000000m) v = 100000000m;
            return Math.Round(v, 2, MidpointRounding.AwayFromZero);
        }

        private void Btn_Historial_Click(object sender, EventArgs e)
        {
            Frm_CxP_Pagos_Historial frmHistorial = new Frm_CxP_Pagos_Historial();
            frmHistorial.Show();
            this.Hide();
        }
    }
}
