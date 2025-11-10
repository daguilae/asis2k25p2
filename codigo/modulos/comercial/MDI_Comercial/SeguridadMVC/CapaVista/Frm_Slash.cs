using System;
using System.Drawing;
using System.Windows.Forms;

namespace Capa_Vista_Comercial
{
    public partial class Frm_Slash : Form
    {
        public Frm_Slash()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void Frm_Slash_Load(object sender, EventArgs e)
        {
            // ===== Configuración general =====
            this.BackColor = Color.FromArgb(192, 192, 0);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;

            // ===== Logo del módulo comercial =====
            try
            {
                Pic_Logo_Modulo_Comercial.Image = Properties.Resources.Logo_Modulo_Comercial;
            }
            catch { /* ignora si no existe el recurso */ }

            Pic_Logo_Modulo_Comercial.SizeMode = PictureBoxSizeMode.Zoom;
            Pic_Logo_Modulo_Comercial.BackColor = Color.Transparent;
            Pic_Logo_Modulo_Comercial.Anchor = AnchorStyles.Top;  // permanece centrado arriba

            // ===== Logo de la empresa =====
            try
            {
                Pic_Logo_Empresa.Image = Properties.Resources.Logo_Empresa_General;
            }
            catch { }

            Pic_Logo_Empresa.SizeMode = PictureBoxSizeMode.Zoom;
            Pic_Logo_Empresa.BackColor = Color.Transparent;
            Pic_Logo_Empresa.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // ===== Barra de progreso =====
            Pgb_Carga.Style = ProgressBarStyle.Continuous;
            Pgb_Carga.Minimum = 0;
            Pgb_Carga.Maximum = 100;
            Pgb_Carga.Value = 0;

            // ===== Texto del porcentaje =====
            Lbl_Porcentaje.Text = "0%";
            Lbl_Porcentaje.Font = new Font("Rockwell", 18, FontStyle.Bold);
            Lbl_Porcentaje.ForeColor = Color.Black;
            Lbl_Porcentaje.TextAlign = ContentAlignment.MiddleCenter;
            Lbl_Porcentaje.Anchor = AnchorStyles.Top;

            // ===== Timer =====
            Tmr_Carga.Interval = 50; // velocidad del progreso
            Tmr_Carga.Enabled = true;
            Tmr_Carga.Start();
        }

        private void Tmr_Carga_Tick(object sender, EventArgs e)
        {
            if (Pgb_Carga.Value < Pgb_Carga.Maximum)
            {
                Pgb_Carga.Increment(2);
                Lbl_Porcentaje.Text = Pgb_Carga.Value + "%";
            }
            else
            {
                Tmr_Carga.Stop();
                this.Hide();
                // Aquí puedes abrir tu formulario principal, ejemplo:
                // new Frm_Login().Show();
            }
        }
    }
}
