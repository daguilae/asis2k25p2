using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_TipoDeCambio;


namespace Capa_Vista_TipoDeCambio
{
    public partial class Frm_IngresoTipoDeCambio : Form
    {
            Controlador_TipoCambio ctrl = new Controlador_TipoCambio();

            private void Frm_IngresoTipoDeCambio_Load(object sender, EventArgs e)
            {
                Cbo_Moneda.DataSource = ctrl.CargarMonedas();
                Cbo_Moneda.DisplayMember = "Cmp_NombreMoneda";
                Cbo_Moneda.ValueMember = "Pk_Id_Moneda";
            }

            private void Btn_Agregar_Click(object sender, EventArgs e)
            {
                ctrl.GuardarTipoCambio(Txt_Fecha.Text,
                                       Convert.ToDecimal(Txt_Compra.Text),
                                       Convert.ToDecimal(Txt_Venta.Text),
                                       Convert.ToInt32(Cbo_Moneda.SelectedValue));

                MessageBox.Show("Tipo de cambio agregado con éxito.");
            }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
