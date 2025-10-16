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
           
            if (Pnl_Contenedor != null)
            {
              
                Pnl_Contenedor.Left = (this.ClientSize.Width - Pnl_Contenedor.Width) / 2;
                Pnl_Contenedor.Top = (this.ClientSize.Height - Pnl_Contenedor.Height) / 2;   //fin de codigo Cesar Santizo 0901-22-5215
            
        }
        }
        private void Lbl_Hotel_Click(object sender, EventArgs e)
        {

        }

        private void Pnl_Contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_Salones_Click(object sender, EventArgs e)
        {
            Frm_Salones nuevoFormulario = new Frm_Salones();
            nuevoFormulario.Show();
            this.Hide();
        }
    }
}
