using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Seguridad;
using Capa_Vista_Seguridad;

namespace Capa_Vista_Hoteleria
{
    public partial class Frm_Login_Hoteleria : Form
    {
        private Cls_BitacoraControlador ctrlBitacora = new Cls_BitacoraControlador(); // Bitácora
        private Cls_ControladorLogin cn = new Cls_ControladorLogin();
        private Cls_Usuario_Controlador gUsuarioControlador = new Cls_Usuario_Controlador();

        public Frm_Login_Hoteleria()
        {
            InitializeComponent();
            txtContrasena.UseSystemPasswordChar = true;
            this.FormClosing += Frm_Login_FormClosing;
        }

        private void Frm_Login_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

  
        private void frmLogin_Load(object sender, EventArgs e) { }


        //public const int WM_NCLBUTTONDOWN = 0xA1;
        //public const int HTCAPTION = 0x2;


        private void btnIniciarSesion_Click_1(object sender, EventArgs e)
        {

            string sUsuario = txtUsuario.Text.Trim();
            string sContrasena = txtContrasena.Text.Trim();
            string sNombreUsuarioReal = "";

            string sMensaje;
            bool bLoginExitoso = cn.bAutenticarUsuario(sUsuario, sContrasena, out sMensaje, out int iIdUsuario, out sNombreUsuarioReal);

            MessageBox.Show(sMensaje);

            if (bLoginExitoso)
            {
                int iIdPerfil = gUsuarioControlador.ObtenerIdPerfilDeUsuario(iIdUsuario);

                // Guardar sesión
                Cls_Usuario_Conectado.IniciarSesion(iIdUsuario, sNombreUsuarioReal, iIdPerfil);


                // Registrar inicio en bitácora
                ctrlBitacora.RegistrarInicioSesion(iIdUsuario);

                // Abrir Frm_Principal
                this.Hide();
                Frm_MDI_Hoteleria frmHoteleria = new Frm_MDI_Hoteleria();
                frmHoteleria.ShowDialog();
                this.Close();
            }
            else
            {
                txtContrasena.Clear();
                txtContrasena.Focus();
            }
        }

        private void lblkRecuperarContrasena_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_Recuperar_Contrasena frmRecuperar = new Frm_Recuperar_Contrasena();
            frmRecuperar.Show();
            this.Hide();
        }

        private void chkMostrarContrasena_CheckedChanged_1(object sender, EventArgs e)
        {
            txtContrasena.UseSystemPasswordChar = !chkMostrarContrasena.Checked;
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
