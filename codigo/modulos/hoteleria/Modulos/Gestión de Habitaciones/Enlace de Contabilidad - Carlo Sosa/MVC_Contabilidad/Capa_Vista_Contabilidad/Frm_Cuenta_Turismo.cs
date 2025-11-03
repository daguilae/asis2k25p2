using System;
using System.Data;
using System.Windows.Forms;
using Capa_Controlador_Contabilidad;
//inicio del codigo- Carlo Sosa 0901-22-1106- Fecha: 01/11/2025

namespace Capa_Vista_Contabilidad
{
    public partial class Frm_Cuenta_Turismo : Form
    {
        readonly Ctr_CuentasTurismo _ctr = new Ctr_CuentasTurismo();

        public Frm_Cuenta_Turismo()
        {
            InitializeComponent();
            Load += (_, __) => CargarCatalogo();
            Btn_Buscar.Click += (_, __) => CargarConfig();
            Btn_modificar.Click += (_, __) => Guardar();
            Btn_Limpiar.Click += (_, __) => Limpiar();
        }

        void CargarCatalogo()
        {
            DataTable dt = _ctr.ListarCatalogo();
            Cbo_Cuenta_Debe.DataSource = dt.Copy();
            Cbo_Cuenta_Debe.DisplayMember = "Cmp_CtaNombre";
            Cbo_Cuenta_Debe.ValueMember = "Pk_Codigo_Cuenta";

            Cbo_Cuenta_Haber.DataSource = dt;
            Cbo_Cuenta_Haber.DisplayMember = "Cmp_CtaNombre";
            Cbo_Cuenta_Haber.ValueMember = "Pk_Codigo_Cuenta";
        }

        void CargarConfig()
        {
            var cfg = _ctr.LeerConfig();
            if (cfg.Debe > 0)
            {
                Cbo_Cuenta_Debe.SelectedValue = cfg.Debe;
                Cbo_Cuenta_Haber.SelectedValue = cfg.Haber;
            }
        }

        void Guardar()
        {
            var codDebe = Convert.ToInt32(Cbo_Cuenta_Debe.SelectedValue);
            var nomDebe = Cbo_Cuenta_Debe.Text;
            var codHaber = Convert.ToInt32(Cbo_Cuenta_Haber.SelectedValue);
            var nomHaber = Cbo_Cuenta_Haber.Text;

            _ctr.Guardar(codDebe, nomDebe, codHaber, nomHaber);
            MessageBox.Show("Tabla modificada", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void Limpiar()
        {
            Cbo_Cuenta_Debe.SelectedIndex = -1;
            Cbo_Cuenta_Haber.SelectedIndex = -1;
        }
    }
}

//Fin del codigo- Carlo Sosa 0901-22-1106- Fecha: 01/11/2025
