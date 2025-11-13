using System;
using System.Windows.Forms;

namespace Capa_Vista_Hoteleria
{
    public partial class Frm_Splash : Form
    {
        public Frm_Splash()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;

            timer1.Interval = 50;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            Lbl_Carga.Text = progressBar1.Value.ToString() + "%";

            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                this.Hide();

                Frm_Login_Hoteleria login = new Frm_Login_Hoteleria();
                login.ShowDialog();

                this.Close(); // Cierra el splash solo cuando el login se cierre
            }
        }
    }
}
