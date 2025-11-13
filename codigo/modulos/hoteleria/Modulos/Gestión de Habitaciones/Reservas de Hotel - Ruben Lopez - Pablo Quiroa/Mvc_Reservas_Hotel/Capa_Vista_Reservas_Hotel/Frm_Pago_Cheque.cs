using System;
using System.Windows.Forms;
using Capa_Controlador_Reservas_Hotel;

namespace Capa_Vista_Reservas_Hotel
{
    public partial class Frm_Pago_Cheque : Form
    {
        private readonly Cls_Pago_Cheque_Controlador gControlador = new Cls_Pago_Cheque_Controlador();

        private int iIdPago;
        private decimal deMontoPago;

   
        public Frm_Pago_Cheque(int idPago, decimal monto)
        {
            InitializeComponent();
            iIdPago = idPago;
            deMontoPago = monto;

            fun_CargarEstadosCheque();

            // Bloquear escritura en ComboBox
            Cbo_Estado_Cheque.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbo_Estado_Cheque.KeyPress += (s, e) => e.Handled = true;
        }

        // =====================================================
        // CARGAR ESTADOS
        // =====================================================
        private void fun_CargarEstadosCheque()
        {
            Cbo_Estado_Cheque.Items.Clear();
            Cbo_Estado_Cheque.Items.Add("Emitido");
            Cbo_Estado_Cheque.Items.Add("Cobrado");
            Cbo_Estado_Cheque.Items.Add("Devuelto");
            Cbo_Estado_Cheque.SelectedIndex = -1;
        }

        // =====================================================
        // LIMPIAR CAMPOS
        // =====================================================
        private void fun_LimpiarCampos()
        {
            Txt_Numero_Cheque.Clear();
            Txt_Banco_Emisor.Clear();
            Txt_Nombre_Titular.Clear();
            Cbo_Estado_Cheque.SelectedIndex = -1;

            Dtp_Fecha_Emision.Value = DateTime.Now;
            Dtp_Fecha_Cobro.Value = DateTime.Now;
        }

       
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                string sNumCheque = Txt_Numero_Cheque.Text.Trim();
                string sBanco = Txt_Banco_Emisor.Text.Trim();
                string sTitular = Txt_Nombre_Titular.Text.Trim();
                string sEstado = Cbo_Estado_Cheque.Text.Trim();

                DateTime dEmision = Dtp_Fecha_Emision.Value;
                DateTime dCobro = Dtp_Fecha_Cobro.Value;

                var r = gControlador.funInsertarPagoCheque(
                    iIdPago,
                    deMontoPago,
                    sNumCheque,
                    sBanco,
                    sTitular,
                    sEstado,
                    dEmision,
                    dCobro
                );

                MessageBox.Show(
                    r.mensaje,
                    r.exito ? "Éxito" : "Error",
                    MessageBoxButtons.OK,
                    r.exito ? MessageBoxIcon.Information : MessageBoxIcon.Error
                );

                if (r.exito)
                {
                    fun_LimpiarCampos();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el pago con cheque:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     
        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            fun_LimpiarCampos();
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La modificación de pagos con cheque se implementará más adelante.",
                "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            fun_LimpiarCampos();
        }

       
        private void Dtp_Fecha_Cobro_ValueChanged(object sender, EventArgs e) { }
        private void Dtp_Fecha_Emision_ValueChanged(object sender, EventArgs e) { }
        private void Txt_Numero_Cheque_TextChanged(object sender, EventArgs e) { }
        private void Txt_Banco_Emisor_TextChanged(object sender, EventArgs e) { }
        private void Txt_Nombre_Titular_TextChanged(object sender, EventArgs e) { }
        private void Cbo_Estado_Cheque_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}
