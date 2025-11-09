using System;
using System.Windows.Forms;
using Capa_Controlador_Reservas_Hotel;

namespace Capa_Vista_Reservas_Hotel
{
    public partial class Frm_Pago_Tarjeta : Form
    {
        private readonly Cls_Pago_Tarjeta_Controlador Controlador = new Cls_Pago_Tarjeta_Controlador();
        private int idPago;
        private decimal montoPago;

        // CONSTRUCTOR QUE RECIBE ID DEL PAGO Y MONTO
        
        public Frm_Pago_Tarjeta(int idPagoPrincipal, decimal monto)
        {
            InitializeComponent();
            idPago = idPagoPrincipal;
            montoPago = monto;
        }

      
        // === LIMPIAR CAMPOS ===
        
        private void LimpiarCampos()
        {
            Txt_Nombre_Titular.Clear();
            Txt_Numero_Tarjeta.Clear();
            Txt_Fecha_Vencimiento.Clear();
            Txt_Cvc.Clear();
            Txt_Codigo_Postal.Clear();
        }

       
        // === EVENTO GUARDAR ===
        
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreTitular = Txt_Nombre_Titular.Text.Trim();
                string numeroTarjeta = Txt_Numero_Tarjeta.Text.Trim();
                string fechaVencimiento = Txt_Fecha_Vencimiento.Text.Trim();
                string cvc = Txt_Cvc.Text.Trim();
                string codigoPostal = Txt_Codigo_Postal.Text.Trim();

               
                var r = Controlador.InsertarPagoTarjeta(idPago, montoPago, nombreTitular, numeroTarjeta, fechaVencimiento, cvc, codigoPostal);

                MessageBox.Show(r.mensaje,
                                r.exito ? "Éxito" : "Error",
                                MessageBoxButtons.OK,
                                r.exito ? MessageBoxIcon.Information : MessageBoxIcon.Error);

                if (r.exito)
                {
                    LimpiarCampos();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el pago con tarjeta:\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La modificación de pagos con tarjeta se implementará más adelante.",
                            "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        
        private void Txt_Nombre_Titular_TextChanged(object sender, EventArgs e) { }
        private void Txt_Cvc_TextChanged(object sender, EventArgs e) { }
        private void Txt_Numero_Tarjeta_TextChanged(object sender, EventArgs e) { }
        private void Txt_Fecha_Vencimiento_TextChanged(object sender, EventArgs e) { }
        private void Txt_Codigo_Postal_TextChanged(object sender, EventArgs e) { }
    }
}
