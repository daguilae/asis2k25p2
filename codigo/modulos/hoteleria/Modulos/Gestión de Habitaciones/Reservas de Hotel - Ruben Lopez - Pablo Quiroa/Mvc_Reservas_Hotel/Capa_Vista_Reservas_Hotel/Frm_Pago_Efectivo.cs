using System;
using System.Windows.Forms;
using Capa_Controlador_Reservas_Hotel;

namespace Capa_Vista_Reservas_Hotel
{
    public partial class Frm_Pago_Efectivo : Form
    {
        private readonly Cls_Pago_Efectivo_Controlador gControlador = new Cls_Pago_Efectivo_Controlador();

        private int gIdPago;
        private decimal gMontoPago;

 
        public Frm_Pago_Efectivo(int idPagoPrincipal, decimal monto)
        {
            InitializeComponent();
            gIdPago = idPagoPrincipal;
            gMontoPago = monto;
        }

 
        private void fun_LimpiarCampos()
        {
            Txt_Numero_Recibo.Clear();
            Txt_Observaciones.Clear();
        }

     
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                string sRecibo = Txt_Numero_Recibo.Text.Trim();
                string sObs = Txt_Observaciones.Text.Trim();

                var r = gControlador.funInsertarPagoEfectivo(gIdPago, gMontoPago, sRecibo, sObs);

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
                MessageBox.Show("Error al guardar el pago en efectivo:\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e) => fun_LimpiarCampos();

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La modificación de pagos en efectivo se implementará más adelante.",
                            "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn_Limpiar_Click(object sender, EventArgs e) => fun_LimpiarCampos();

        private void Txt_Numero_Recibo_TextChanged(object sender, EventArgs e) { }
        private void Txt_Observaciones_TextChanged(object sender, EventArgs e) { }
    }
}
