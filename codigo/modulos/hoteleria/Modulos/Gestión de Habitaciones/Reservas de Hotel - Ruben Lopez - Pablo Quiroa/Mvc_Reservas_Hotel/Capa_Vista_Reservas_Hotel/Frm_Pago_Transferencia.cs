using System;
using System.Windows.Forms;
using Capa_Controlador_Reservas_Hotel;

namespace Capa_Vista_Reservas_Hotel
{
    public partial class Frm_Pago_Transferencia : Form
    {
        private readonly Cls_Pago_Transferencia_Controlador controlador = new Cls_Pago_Transferencia_Controlador();
        private readonly int idPago; // viene desde Frm_Pago

        // ==================== CONSTRUCTOR ====================
        public Frm_Pago_Transferencia(int idPago)
        {
            InitializeComponent();
            this.idPago = idPago;
        }

        // ==================== EVENTOS DEL DESIGNER ====================
        private void Txt_Numero_Transferencia_TextChanged(object sender, EventArgs e) { }
        private void Txt_Banco_Origen_TextChanged(object sender, EventArgs e) { }
        private void Txt_Cuenta_Origen_TextChanged(object sender, EventArgs e) { }

        // ==================== BOTONES ====================
        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                controlador.GuardarPagoTransferencia(
                    idPago,
                    Txt_Numero_Transferencia.Text,
                    Txt_Banco_Origen.Text,
                    Txt_Cuenta_Origen.Text
                );

                MessageBox.Show("Pago por transferencia registrado correctamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el pago por transferencia: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                controlador.ModificarPagoTransferencia(
                    idPago,
                    Txt_Numero_Transferencia.Text,
                    Txt_Banco_Origen.Text,
                    Txt_Cuenta_Origen.Text
                );

                MessageBox.Show("Pago por transferencia modificado correctamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el pago por transferencia: " + ex.Message,
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
            Txt_Numero_Transferencia.Clear();
            Txt_Banco_Origen.Clear();
            Txt_Cuenta_Origen.Clear();
        }
    }
}
