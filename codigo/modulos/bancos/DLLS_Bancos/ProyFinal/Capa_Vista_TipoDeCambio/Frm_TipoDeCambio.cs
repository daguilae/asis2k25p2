using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_TipoDeCambio;

namespace Capa_Vista_TipoDeCambio
{
    public partial class Frm_TipoDeCambio : Form
    {
        Controlador_TipoCambio ctrl = new Controlador_TipoCambio();

        private void Frm_TipoDeCambio_Load(object sender, EventArgs e)
        {
            Dgv_TipoDeCambio.DataSource = ctrl.MostrarTodo();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {

            Dgv_TipoDeCambio.DataSource = ctrl.BuscarPorFecha(Txt_Fecha.Text);
        }

        public Frm_TipoDeCambio()
        {
            InitializeComponent();
        }

    }
}
