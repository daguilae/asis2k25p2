using System;
using System.Windows.Forms;
using Capa_Controlador_Reservas_Hotel;

namespace Capa_Vista_Reservas_Hotel
{
    public partial class Frm_Pago_Efectivo : Form
    {
        private readonly Cls_Pago_Efectivo_Controlador controlador = new Cls_Pago_Efectivo_Controlador();
        private readonly int idPago; // viene desde Frm_Pago

        // ==================== CONSTRUCTOR ====================
        public Frm_Pago_Efectivo(int idPago)
        {
            InitializeComponent();
            this.idPago = idPago;
        }

        // ==================== EVENTOS DEL DESIGNER ====================
        private void Txt_Numero_Recibo_TextChanged(object sender, EventArgs e) { }
        private void Txt_Observaciones_TextChanged(object sender, EventArgs e) { }

        // ==================== BOTONES ====================
        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                controlador.GuardarPagoEfectivo(
                    idPago,
                    Txt_Numero_Recibo.Text,
                    Txt_Observaciones.Text
                );

                MessageBox.Show("Pago en efectivo registrado correctamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el pago en efectivo: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                controlador.ModificarPagoEfectivo(
                    idPago,
                    Txt_Numero_Recibo.Text,
                    Txt_Observaciones.Text
                );

                MessageBox.Show("Pago en efectivo modificado correctamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el pago en efectivo: " + ex.Message,
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
            Txt_Numero_Recibo.Clear();
            Txt_Observaciones.Clear();
        }
    }
}
