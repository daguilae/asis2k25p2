using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_CxP
{
    public partial class Frm_CxP_Pagos : Form
    {
        // Campos de trabajo (se actualizan al elegir factura)
        private decimal _totalFactura = 0m;
        private decimal _saldoPendiente = 0m;
        private object _facturaId = null; // puedes cambiar a int/string según tu modelo

        public Frm_CxP_Pagos()
        {
            InitializeComponent();
            this.Load += Frm_CxP_Pagos_Load;
        }

        private void Frm_CxP_Pagos_Load(object sender, EventArgs e)
        {
            // TODO: Llenar combo con facturas pendientes desde tu Controlador/Repositorio
            // Ejemplo de cómo debería venir cada item:
            // cboFactura.ValueMember = "Id";
            // cboFactura.DisplayMember = "Descripcion";
            // cboFactura.DataSource = _controlador.ListarFacturasPendientes();

            // Estado inicial
            nudMontoPagar.Enabled = rdbPagoParcial.Checked;
            errorProvider1.Clear();
        }

        // =============== Eventos del Designer ===============

        private void cboFactura_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            // TODO: recuperar totales reales según SelectedValue
            // _facturaId = cboFactura.SelectedValue;
            // var datos = _controlador.ObtenerResumenFactura(_facturaId);
            // _totalFactura = datos.Total;
            // _saldoPendiente = datos.Pendiente;

            // Mientras integras el controlador, deja valores seguros:
            _facturaId = cboFactura.SelectedValue;
            _totalFactura = _totalFactura <= 0 ? 0m : _totalFactura;      // placeholder
            _saldoPendiente = _saldoPendiente <= 0 ? _totalFactura : _saldoPendiente;

            lblTotalFacturaV.Text = _totalFactura.ToString("N2");
            lblPendienteV.Text = _saldoPendiente.ToString("N2");

            // Si es pago total, fija el monto = pendiente
            if (rdbPagoTotal.Checked)
            {
                nudMontoPagar.Value = ToNumericUpDownValue(_saldoPendiente);
                nudMontoPagar.Enabled = false;
            }
            else
            {
                nudMontoPagar.Enabled = true;
                // Ajusta máximos mínimos para evitar overflow
                nudMontoPagar.Maximum = ToNumericUpDownValue(Math.Max(0m, _saldoPendiente));
            }
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            if (_facturaId == null)
            {
                errorProvider1.SetError(cboFactura, "Seleccione una factura.");
                return;
            }
            // TODO: abrir un modal con el detalle de la factura (_facturaId)
            MessageBox.Show("Detalle de factura (pendiente de implementar).", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void rdbPagoTotal_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPagoTotal.Checked)
            {
                nudMontoPagar.Enabled = false;
                nudMontoPagar.Value = ToNumericUpDownValue(_saldoPendiente);
                errorProvider1.Clear();
            }
        }

        private void rdbPagoParcial_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPagoParcial.Checked)
            {
                nudMontoPagar.Enabled = true;
                nudMontoPagar.Maximum = ToNumericUpDownValue(Math.Max(0m, _saldoPendiente));
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

            if (_facturaId == null)
            {
                errorProvider1.SetError(cboFactura, "Seleccione una factura.");
                return;
            }

            decimal monto = nudMontoPagar.Value;
            if (rdbPagoParcial.Checked && (monto <= 0 || monto > _saldoPendiente))
            {
                errorProvider1.SetError(nudMontoPagar, "Monto inválido para pago parcial.");
                return;
            }

            // En pago total, forzamos monto = saldo
            if (rdbPagoTotal.Checked) monto = _saldoPendiente;

            // TODO: Invocar al Controlador para registrar el pago:
            // var pagoId = _controlador.RegistrarPagoCxP(_facturaId, monto, dtpFechaPago.Value, rdbPagoTotal.Checked);
            // if (pagoId != null) { ... }

            MessageBox.Show("Pago registrado (stub). Integra Controlador y persiste.", "OK",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Refrescar saldo (simulado)
            _saldoPendiente = Math.Max(0m, _saldoPendiente - monto);
            lblPendienteV.Text = _saldoPendiente.ToString("N2");

            if (_saldoPendiente == 0m) rdbPagoTotal.Checked = true;
        }

        private void btnIrReporte_Click(object sender, EventArgs e)
        {
            if (_facturaId == null)
            {
                errorProvider1.SetError(cboFactura, "Seleccione una factura para ver el reporte.");
                return;
            }

            // TODO: Abrir el formulario de CrystalReport y pasar parámetros (facturaId / pagoId)
            MessageBox.Show("Crystal Report (pendiente de implementar).", "Reporte",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // =============== Helpers ===============
        private static decimal SafeParseLabel(string text)
        {
            return decimal.TryParse(text, out var d) ? d : 0m;
        }

        private static decimal ToNumericUpDownValue(decimal v)
        {
            // NumericUpDown usa decimal con 2 decimales por configuración aquí.
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