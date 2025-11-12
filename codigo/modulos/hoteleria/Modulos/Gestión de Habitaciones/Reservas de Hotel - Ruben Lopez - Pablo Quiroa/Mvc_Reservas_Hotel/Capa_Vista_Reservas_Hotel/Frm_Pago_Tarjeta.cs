using System;
using System.Windows.Forms;
using Capa_Controlador_Reservas_Hotel;

namespace Capa_Vista_Reservas_Hotel
{
    public partial class Frm_Pago_Tarjeta : Form
    {
        private readonly Cls_Pago_Tarjeta_Controlador gControlador = new Cls_Pago_Tarjeta_Controlador();
        private int gIdPago;
        private decimal gMonto;

        public Frm_Pago_Tarjeta(int iIdPago, decimal deMonto)
        {
            InitializeComponent();
            gIdPago = iIdPago;
            gMonto = deMonto;
        }

        private void fun_Limpiar()
        {
            Txt_Nombre_Titular.Clear();
            Txt_Numero_Tarjeta.Clear();
            Txt_Fecha_Vencimiento.Clear();
            Txt_Cvc.Clear();
            Txt_Codigo_Postal.Clear();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            var r = gControlador.funInsertarPagoTarjeta(
                gIdPago,
                gMonto,
                Txt_Nombre_Titular.Text.Trim(),
                Txt_Numero_Tarjeta.Text.Trim(),
                Txt_Fecha_Vencimiento.Text.Trim(),
                Txt_Cvc.Text.Trim(),
                Txt_Codigo_Postal.Text.Trim()
            );

            MessageBox.Show(r.mensaje, r.exito ? "Éxito" : "Error",
                            MessageBoxButtons.OK,
                            r.exito ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (r.exito)
            {
                fun_Limpiar();
                this.Close();
            }
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e) => fun_Limpiar();
        private void Btn_Limpiar_Click(object sender, EventArgs e) => fun_Limpiar();
        private void Btn_Modificar_Click(object sender, EventArgs e) =>
            MessageBox.Show("Modificación pendiente de implementación.", "Info");

        private void Txt_Nombre_Titular_TextChanged(object sender, EventArgs e) { }
        private void Txt_Numero_Tarjeta_TextChanged(object sender, EventArgs e) { }
        private void Txt_Fecha_Vencimiento_TextChanged(object sender, EventArgs e) { }
        private void Txt_Cvc_TextChanged(object sender, EventArgs e) { }
        private void Txt_Codigo_Postal_TextChanged(object sender, EventArgs e) { }
    }
}
