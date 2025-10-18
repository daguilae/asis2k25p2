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
    public partial class Frm_Hoteleria : Form
    {
        public Frm_Hoteleria()
        {
            InitializeComponent();
            this.Resize += Frm_Hoteleria_Resize; //Inicio de codigo Cesar Santizo 0901-22-5215
        }


        private void Frm_Hoteleria_Resize(object sender, EventArgs e)
        {
           //Codigo comentado para unar panel y ajustar los componentes 
          //  if (Pnl_Contenedor != null)
           // {
              
             //   Pnl_Contenedor.Left = (this.ClientSize.Width - Pnl_Contenedor.Width) / 2;
            //    Pnl_Contenedor.Top = (this.ClientSize.Height - Pnl_Contenedor.Height) / 2;   //fin de codigo Cesar Santizo 0901-22-5215
            
        //}
        }
        private void Lbl_Hotel_Click(object sender, EventArgs e)
        {

        }

        
        private void salonesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


      

        private void reservacionesDeSalonesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Frm_Reservaciones nuevoFormulario = new Frm_Reservaciones();
            nuevoFormulario.Show();
            this.Hide();
        }

        private void gestionDeSalonesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            Frm_Salones nuevoFormulario = new Frm_Salones();
            nuevoFormulario.Show();
            this.Hide();
        }
    }
}
