using System;
using System.Windows.Forms;
using Capa_Vista_Percepciones_Nomina; // <-- donde está Form_Percep

namespace Exe_Percepciones
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            CargarModuloPercepciones();

        }

        private void CargarModuloPercepciones()
        {
            try
            {
                // Limpia el panel por si había otro control
                panelContenedor.Controls.Clear();

                // Instancia del UserControl
                var uc = new Form_Percep();      // Debe ser public y sin parámetros
                uc.Dock = DockStyle.Fill;

                // Agrega al panel y lo trae al frente
                panelContenedor.Controls.Add(uc);
                uc.BringToFront();
                uc.Visible = true;               // por si estaba false
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar el módulo: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
