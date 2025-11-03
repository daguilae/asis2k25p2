using System;
using System.Globalization;
using System.Windows.Forms;
using Capa_Controlador_Contabilidad;
//inicio del codigo- Carlo Sosa 0901-22-1106- Fecha: 01/11/2025

namespace Capa_Vista_Contabilidad
{
    public partial class Frm_Poliza_Turismo : Form
    {
        readonly Ctr_Poliza_Turismo _ctr = new Ctr_Poliza_Turismo();

        public Frm_Poliza_Turismo()
        {
            InitializeComponent();
            Btn_Aceptar.Click += Btn_Aceptar_Click;
            Btn_Cancelar.Click += Btn_Cancelar_Click;
        }

        void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (!TryParseFecha(Txt_fecha_Rango.Text, out var desde) ||
                !TryParseFecha(Txt_Fecha_Rango2.Text, out var hasta) ||
                !TryParseFecha(Txt_Fecha_Generales.Text, out var fpol))
            {
                MessageBox.Show("Fechas inválidas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string concepto = Txt_Concepto.Text?.Trim() ?? "";
            var r = _ctr.GenerarSiguiente(desde, hasta, fpol, concepto);

            if (r.ok) MessageBox.Show(r.msg, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show(r.msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void Btn_Cancelar_Click(object sender, EventArgs e) => Limpiar();

        void Limpiar()
        {
            Txt_fecha_Rango.Clear();
            Txt_Fecha_Rango2.Clear();
            Txt_Fecha_Generales.Clear();
            Txt_ID_Poliza.Clear();
            Txt_Concepto.Clear();
            Txt_fecha_Rango.Focus();
        }

        static bool TryParseFecha(string s, out DateTime dt)
        {
            string[] f = { "yyyy/MM/dd", "yyyy-MM-dd", "dd/MM/yyyy", "dd-MM-yyyy" };
            return DateTime.TryParseExact((s ?? "").Trim(), f, CultureInfo.InvariantCulture, DateTimeStyles.None, out dt);
        }
    }
}
//Fin del codigo- Carlo Sosa 0901-22-1106- Fecha: 01/11/2025
