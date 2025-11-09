using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_CB;

namespace Capa_Vista_CB
{
    public partial class Frm_ConciliacionBancaria : Form
    {

        private void Frm_ConciliacionBancaria_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Ayuda_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_BuscarConciliacion_Click(object sender, EventArgs e)
        {
            Frm_BuscarConciliacion frmBuscar = new Frm_BuscarConciliacion();
            frmBuscar.Show();
            this.Hide();
        }

        private void Btn_LimpiarCampos_Click(object sender, EventArgs e)
        {

        }

        private void Cbo_Bancos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cbo_Cuenta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Dtp_FechaConciliacion_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Cbo_Mes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Anio_TextChanged(object sender, EventArgs e)
        {

        }


        private void Txt_SaldoBanco_TextChanged(object sender, EventArgs e)
        {
        }

        private void Txt_SaldoLibros_TextChanged(object sender, EventArgs e)
        {
        }

        private void Txt_Diferencias_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Observaciones_TextChanged(object sender, EventArgs e)
        {

        }

        private void Chk_Estado_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}

