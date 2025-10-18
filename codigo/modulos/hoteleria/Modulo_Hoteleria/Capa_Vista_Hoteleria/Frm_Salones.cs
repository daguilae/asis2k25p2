using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Hoteleria
{
    public partial class Frm_Salones : Form
    {
        public Frm_Salones()
        {
            InitializeComponent();
         //   ConfigurarPaneles(); //Inicio codigo Cesar Santizo 0901-22-5215
        }


       //// private void ConfigurarPaneles()
     ///   {

           /// Pnl_Contenedor.Dock = DockStyle.Left;

           
        ///    Pnl_Contenedor.Width = 230;
            //fin  codigo Cesar Santizo 0901-22-5215

    ////    }

        private void Pic_Produccion_Click(object sender, EventArgs e)
        {

        }

        private void Pnl_Contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dvg_Salones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

     


        private void menuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Frm_Hoteleria nuevoFormulario = new Frm_Hoteleria();
            nuevoFormulario.Show();
            this.Hide();
        }

        private void reservacionesDeSalonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Reservaciones nuevoFormulario = new Frm_Reservaciones();
            nuevoFormulario.Show();
            this.Hide();
        }
    }
}
