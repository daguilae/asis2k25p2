using System;
using System.Windows.Forms;
using Capa_Controlador_Reservas_Hotel;

namespace Capa_Vista_Reservas_Hotel
{
    public partial class Frm_Pago_Cheque : Form
    {
        private readonly Cls_Pago_Cheque_Controlador controlador = new Cls_Pago_Cheque_Controlador();
        private readonly int idPago; // viene desde Frm_Pago

        // ==================== CONSTRUCTOR ====================
        public Frm_Pago_Cheque(int idPago)
        {
            InitializeComponent();
            this.idPago = idPago;
        }

        // ==================== EVENTOS DESIGNER ====================
        private void Txt_Numero_Cheque_TextChanged(object sender, EventArgs e) { }
        private void Txt_Banco_Emisor_TextChanged(object sender, EventArgs e) { }
        private void Txt_Nombre_Titular_TextChanged(object sender, EventArgs e) { }
        private void Dtp_Fecha_Emision_ValueChanged(object sender, EventArgs e) { }
        private void Dtp_Fecha_Cobro_ValueChanged(object sender, EventArgs e) { }
        private void Cbo_Estado_Cheque_SelectedIndexChanged(object sender, EventArgs e) { }

        // ==================== BOTONES ====================
        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                controlador.GuardarPagoCheque(
                    idPago,
                    Txt_Numero_Cheque.Text,
                    Txt_Banco_Emisor.Text,
                    Txt_Nombre_Titular.Text,
                    Dtp_Fecha_Emision.Value,
                    Dtp_Fecha_Cobro.Value,
                    Cbo_Estado_Cheque.Text
                );

                MessageBox.Show("Pago con cheque registrado correctamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el pago con cheque: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                controlador.ModificarPagoCheque(
                    idPago,
                    Txt_Numero_Cheque.Text,
                    Txt_Banco_Emisor.Text,
                    Txt_Nombre_Titular.Text,
                    Dtp_Fecha_Emision.Value,
                    Dtp_Fecha_Cobro.Value,
                    Cbo_Estado_Cheque.Text
                );

                MessageBox.Show("Pago con cheque modificado correctamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el pago con cheque: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // ==================== MÉTODO AUXILIAR ====================
        private void LimpiarCampos()
        {
            Txt_Numero_Cheque.Clear();
            Txt_Banco_Emisor.Clear();
            Txt_Nombre_Titular.Clear();
            Cbo_Estado_Cheque.SelectedIndex = -1;
            Dtp_Fecha_Emision.Value = DateTime.Now;
            Dtp_Fecha_Cobro.Value = DateTime.Now;
        }
    }
}
