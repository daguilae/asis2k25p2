using System;
using System.Data;
using System.Windows.Forms;
using Capa_Controlador_Reservas_Hotel;

namespace Capa_Vista_Reservas_Hotel
{
    public partial class Frm_Pago : Form
    {
        private readonly Cls_Pago_Controlador gControlador = new Cls_Pago_Controlador();

        public Frm_Pago()
        {
            InitializeComponent();

            fun_CargarFolios();
            fun_CargarMetodosPago();
            fun_CargarEstadosPago();

            // Bloquear escritura (Vista)
            Cbo_Folio.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbo_MetodoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbo_Estado.DropDownStyle = ComboBoxStyle.DropDownList;

            Cbo_Folio.KeyPress += (s, e) => e.Handled = true;
            Cbo_MetodoPago.KeyPress += (s, e) => e.Handled = true;
            Cbo_Estado.KeyPress += (s, e) => e.Handled = true;

            Txt_Monto.ReadOnly = true;
            Txt_Monto.KeyPress += (s, e) => e.Handled = true;
        }


        private void fun_CargarFolios()
        {
            try
            {
                DataTable dt = gControlador.funObtenerFolios();
                Cbo_Folio.DataSource = dt;
                Cbo_Folio.DisplayMember = "DescripcionFolio";
                Cbo_Folio.ValueMember = "Pk_Id_Folio";
                Cbo_Folio.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar folios: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fun_CargarMetodosPago()
        {
            Cbo_MetodoPago.Items.Clear();
            Cbo_MetodoPago.Items.Add("Tarjeta");
            Cbo_MetodoPago.Items.Add("Efectivo");
            Cbo_MetodoPago.Items.Add("Transferencia");
            Cbo_MetodoPago.Items.Add("Cheque");
            Cbo_MetodoPago.SelectedIndex = -1;
        }

        private void fun_CargarEstadosPago()
        {
            Cbo_Estado.Items.Clear();
            Cbo_Estado.Items.Add("Pendiente");
            Cbo_Estado.Items.Add("Pagado");
            Cbo_Estado.Items.Add("Cancelado");
            Cbo_Estado.SelectedIndex = -1;
        }

        private void fun_LimpiarCampos()
        {
            Cbo_Folio.SelectedIndex = -1;
            Cbo_MetodoPago.SelectedIndex = -1;
            Cbo_Estado.SelectedIndex = -1;
            Txt_Monto.Clear();
            Dtp_Fecha_Pago.Value = DateTime.Now;
        }

       
        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            fun_LimpiarCampos();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                int iFolio = (Cbo_Folio.SelectedValue != null) ? Convert.ToInt32(Cbo_Folio.SelectedValue) : 0;
                string sMet = Cbo_MetodoPago.SelectedItem?.ToString();
                string sEst = Cbo_Estado.SelectedItem?.ToString();
                string sMon = Txt_Monto.Text.Trim();
                DateTime dF = Dtp_Fecha_Pago.Value;

                var r = gControlador.funInsertarPagoValidado(iFolio, sMet, dF, sMon, sEst);

                if (!r.exito)
                {
                    MessageBox.Show(r.mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show("Pago registrado correctamente. Complete los detalles en el subformulario.",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Abre subformulario con el ID del PAGO y el monto
                AbrirSubformulario(sMet, r.idPago, Convert.ToDecimal(sMon));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el pago: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La modificación de pagos se gestionará en módulos de detalle.",
                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            fun_LimpiarCampos();
        }

        private void Cbo_Folio_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Cbo_Folio.SelectedItem is DataRowView row &&
                    row.DataView.Table.Columns.Contains("Cmp_Saldo_Final"))
                {
                    Txt_Monto.Text = Convert.ToDecimal(row["Cmp_Saldo_Final"]).ToString("0.00");
                }
            }
            catch
            {
                Txt_Monto.Clear();
            }
        }

        private void Cbo_Estado_SelectedIndexChanged(object sender, EventArgs e) { }
        private void Cbo_MetodoPago_SelectedIndexChanged(object sender, EventArgs e) { }
        private void Dtp_Fecha_Pago_ValueChanged(object sender, EventArgs e) { }
        private void Txt_Monto_TextChanged(object sender, EventArgs e) { }

        // =======================
        // Subformularios
        // =======================
        private void AbrirSubformulario(string sMetodo, int iIdPago, decimal deMonto)
        {
            switch (sMetodo)
            {
                case "Tarjeta":
                    new Frm_Pago_Tarjeta(iIdPago, deMonto).ShowDialog();
                    break;
                case "Efectivo":
                    new Frm_Pago_Efectivo(iIdPago, deMonto).ShowDialog();
                    break;
                case "Transferencia":
                    new Frm_Pago_Transferencia(iIdPago, deMonto).ShowDialog();
                    break;
                case "Cheque":
                    new Frm_Pago_Cheque(iIdPago, deMonto).ShowDialog();
                    break;
            }
        }
    }
}
