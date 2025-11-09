using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_CB
{
    public partial class Frm_BuscarConciliacion : Form
    {
        public Frm_BuscarConciliacion()
        {
            InitializeComponent();
        }

        private void Btn_AyudaBC_Click(object sender, EventArgs e)
        {

        }

        private void Btn_SalirBuscarCB_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_ConciliacionBancaria frmConciliacionBancaria = new Frm_ConciliacionBancaria();
            frmConciliacionBancaria.Show();
        }

        private void Cbo_BancosBuscarCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cbo_MesBuscarCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cbo_AnioBuscarCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_BuscarCB_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Reporte_Click(object sender, EventArgs e)
        {

        }

        private void Btn_ModificarSeleccion_Click(object sender, EventArgs e)
        {

        }

        private void Btn_EliminarCB_Click(object sender, EventArgs e)
        {

        }

        private void Dgv_Conciliaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
