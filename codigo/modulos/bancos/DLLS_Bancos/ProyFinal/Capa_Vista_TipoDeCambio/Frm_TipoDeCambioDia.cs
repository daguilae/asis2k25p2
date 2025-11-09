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
    public partial class Frm_TipoDeCambioDia : Form
    {
        Controlador_TipoCambio ctrl = new Controlador_TipoCambio();

        public Frm_TipoDeCambioDia()
        {
            InitializeComponent();
        }

        private void Frm_TipoDeCambioDia_Load(object sender, EventArgs e)
        {
                Dgv_TipoDeCambioDia.AutoGenerateColumns = false; // Muy importante

            Dgv_TipoDeCambioDia.Columns["Moneda"].DataPropertyName = "Moneda";
            Dgv_TipoDeCambioDia.Columns["Compra"].DataPropertyName = "Compra";
            Dgv_TipoDeCambioDia.Columns["Venta"].DataPropertyName = "Venta";

            Dgv_TipoDeCambioDia.DataSource = ctrl.MostrarTipoCambioHoy();

        }


    }
    }
