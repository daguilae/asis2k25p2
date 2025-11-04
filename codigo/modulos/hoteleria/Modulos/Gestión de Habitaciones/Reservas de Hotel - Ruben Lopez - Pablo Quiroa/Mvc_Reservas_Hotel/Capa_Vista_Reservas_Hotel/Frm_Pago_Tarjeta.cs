using System;
using System.Windows.Forms;
using Capa_Controlador_Reservas_Hotel;

namespace Capa_Vista_Reservas_Hotel
{
    public partial class Frm_Pago_Tarjeta : Form
    {
        private readonly Cls_Pago_Tarjeta_Controlador controlador = new Cls_Pago_Tarjeta_Controlador();
        private readonly int idPago; // viene desde Frm_Pago

        // ==================== CONSTRUCTOR ====================
        public Frm_Pago_Tarjeta(int idPago)
        {
            InitializeComponent();
            this.idPago = idPago;
        }

        // ==================== EVENTOS DE TEXTBOX (del Designer) ====================
        private void Txt_Nombre_Titular_TextChanged(object sender, EventArgs e) { }
        private void Txt_Cvc_TextChanged(object sender, EventArgs e) { }
        private void Txt_Numero_Tarjeta_TextChanged(object sender, EventArgs e) { }
        private void Txt_Fecha_Vencimiento_TextChanged(object sender, EventArgs e) { }
        private void Txt_Codigo_Postal_TextChanged(object sender, EventArgs e) { }

        // ==================== BOTONES ====================
        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                controlador.GuardarPagoTarjeta(
                    idPago,
                    Txt_Nombre_Titular.Text,
                    Txt_Numero_Tarjeta.Text,
                    Txt_Fecha_Vencimiento.Text,
                    Txt_Cvc.Text,
                    Txt_Codigo_Postal.Text
                );

                MessageBox.Show("Pago con tarjeta registrado correctamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el pago con tarjeta: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                controlador.ModificarPagoTarjeta(
                    idPago,
                    Txt_Nombre_Titular.Text,
                    Txt_Numero_Tarjeta.Text,
                    Txt_Fecha_Vencimiento.Text,
                    Txt_Cvc.Text,
                    Txt_Codigo_Postal.Text
                );

                MessageBox.Show("Pago con tarjeta modificado correctamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el pago con tarjeta: " + ex.Message,
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
            Txt_Nombre_Titular.Clear();
            Txt_Numero_Tarjeta.Clear();
            Txt_Fecha_Vencimiento.Clear();
            Txt_Cvc.Clear();
            Txt_Codigo_Postal.Clear();
        }
    }
}
