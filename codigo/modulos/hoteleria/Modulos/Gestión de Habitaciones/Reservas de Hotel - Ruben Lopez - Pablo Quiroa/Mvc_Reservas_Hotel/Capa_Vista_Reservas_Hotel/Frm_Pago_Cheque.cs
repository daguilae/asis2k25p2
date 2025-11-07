using System;
using System.Windows.Forms;
using Capa_Controlador_Reservas_Hotel;

namespace Capa_Vista_Reservas_Hotel
{
    public partial class Frm_Pago_Cheque : Form
    {
        private readonly Cls_Pago_Cheque_Controlador Controlador = new Cls_Pago_Cheque_Controlador();

       
        private int idPago;
        private decimal montoPago;

        
        // CONSTRUCTOR QUE RECIBE ID DEL PAGO Y MONTO
        
        public Frm_Pago_Cheque(int idPagoPrincipal, decimal monto)
        {
            InitializeComponent();
            idPago = idPagoPrincipal;
            montoPago = monto;
            CargarEstadosCheque();
        }

        private void CargarEstadosCheque()
        {
            // Mantiene el nombre del ComboBox del designer
            Cbo_Estado_Cheque.Items.Clear();
            Cbo_Estado_Cheque.Items.Add("Emitido");
            Cbo_Estado_Cheque.Items.Add("Cobrado");
            Cbo_Estado_Cheque.Items.Add("Devuelto");
            Cbo_Estado_Cheque.SelectedIndex = -1;
        }

        private void LimpiarCampos()
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
                string numero = Txt_Numero_Cheque.Text.Trim();
                string banco = Txt_Banco_Emisor.Text.Trim();
                string titular = Txt_Nombre_Titular.Text.Trim();
                DateTime emision = Dtp_Fecha_Emision.Value;
                DateTime cobro = Dtp_Fecha_Cobro.Value;
                string estado = Cbo_Estado_Cheque.Text.Trim();

                
                var r = Controlador.InsertarPagoCheque(
                    idPago,               
                    montoPago,
                    numero,
                    banco,
                    titular,
                    emision,
                    cobro,
                    estado
                );

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
                MessageBox.Show("Error al guardar el pago con cheque:\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La modificación de cheques se implementará más adelante.",
                            "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

     
        private void Txt_Numero_Cheque_TextChanged(object sender, EventArgs e) { }
        private void Cbo_Estado_Cheque_SelectedIndexChanged(object sender, EventArgs e) { }
        private void Txt_Banco_Emisor_TextChanged(object sender, EventArgs e) { }
        private void Txt_Nombre_Titular_TextChanged(object sender, EventArgs e) { }
        private void Dtp_Fecha_Emision_ValueChanged(object sender, EventArgs e) { }
        private void Dtp_Fecha_Cobro_ValueChanged(object sender, EventArgs e) { }
    }
}
