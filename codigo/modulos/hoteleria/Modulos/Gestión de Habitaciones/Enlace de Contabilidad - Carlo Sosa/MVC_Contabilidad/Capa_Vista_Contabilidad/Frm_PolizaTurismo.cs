using System;
using System.Windows.Forms;
using Capa_Controlador_Contabilidad;

namespace Capa_Vista_Contabilidad
{
    public partial class Frm_PolizaTurismo : Form
    {
        private readonly Ctr_PolizaTurismo gCtrl = new Ctr_PolizaTurismo();

        public Frm_PolizaTurismo()
        {
            InitializeComponent();

            this.Load += Frm_PolizaTurismo_Load;
            Btn_Aceptar.Click += Btn_Aceptar_Click;
            Btn_Cancelar.Click += Btn_Cancelar_Click;

            this.AcceptButton = Btn_Aceptar;
            this.CancelButton = Btn_Cancelar;
        }

        private void Frm_PolizaTurismo_Load(object sender, EventArgs e)
        {
            Txt_Fecha_Generales.Text = DateTime.Now.ToString("dd/MM/yyyy");
            fun_CargarIdPoliza();
        }

        private void fun_CargarIdPoliza()
        {
            try
            {
                int iId = gCtrl.fun_ObtenerSiguienteId(DateTime.Now);
                Txt_ID_Poliza.Text = iId.ToString();
            }
            catch
            {
                Txt_ID_Poliza.Text = string.Empty;
            }
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            bool bOk = gCtrl.fun_TrasladarPolizaTurismo(
                Txt_fecha_Rango.Text,
                Txt_Fecha_Rango2.Text,
                Txt_Concepto.Text.Trim(),
                out string sMensaje);

            MessageBox.Show(
                sMensaje,
                bOk ? "Éxito" : "Advertencia",
                MessageBoxButtons.OK,
                bOk ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            if (bOk)
            {
                Txt_fecha_Rango.Text = string.Empty;
                Txt_Fecha_Rango2.Text = string.Empty;
                Txt_Concepto.Text = string.Empty;
                Txt_Fecha_Generales.Text = DateTime.Now.ToString("dd/MM/yyyy");
                fun_CargarIdPoliza();
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
