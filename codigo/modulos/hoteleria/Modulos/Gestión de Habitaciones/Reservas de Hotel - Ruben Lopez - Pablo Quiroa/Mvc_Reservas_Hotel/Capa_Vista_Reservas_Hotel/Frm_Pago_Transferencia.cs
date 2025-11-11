using System;
using System.Windows.Forms;
using Capa_Controlador_Reservas_Hotel;

namespace Capa_Vista_Reservas_Hotel
{
    public partial class Frm_Pago_Transferencia : Form
    {
        private readonly Cls_Pago_Transferencia_Controlador gControlador = new Cls_Pago_Transferencia_Controlador();
        private int gIdPago;
        private decimal gMonto;

     
        public Frm_Pago_Transferencia(int idPagoPrincipal, decimal monto)
        {
            InitializeComponent();
            gIdPago = idPagoPrincipal;
            gMonto = monto;
        }

      
        private void fun_LimpiarCampos()
        {
            Txt_Numero_Transferencia.Clear();
            Txt_Banco_Origen.Clear();
            Txt_Cuenta_Origen.Clear();
        }

     
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                string sNumero = Txt_Numero_Transferencia.Text.Trim();
                string sBanco = Txt_Banco_Origen.Text.Trim();
                string sCuenta = Txt_Cuenta_Origen.Text.Trim();

                var r = gControlador.fun_InsertarPagoTransferencia(gIdPago, gMonto, sNumero, sBanco, sCuenta);

                MessageBox.Show(r.mensaje,
                    r.exito ? "Éxito" : "Error",
                    MessageBoxButtons.OK,
                    r.exito ? MessageBoxIcon.Information : MessageBoxIcon.Error);

                if (r.exito)
                {
                    fun_LimpiarCampos();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el pago por transferencia:\n" + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }


        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            fun_LimpiarCampos();
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            fun_LimpiarCampos();
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La modificación de pagos por transferencia se implementará más adelante.",
                            "Información",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void Txt_Numero_Transferencia_TextChanged(object sender, EventArgs e) { }
        private void Txt_Banco_Origen_TextChanged(object sender, EventArgs e) { }
        private void Txt_Cuenta_Origen_TextChanged(object sender, EventArgs e) { }
    }
}
