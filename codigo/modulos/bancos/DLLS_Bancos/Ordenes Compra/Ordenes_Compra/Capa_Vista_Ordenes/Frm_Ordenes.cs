using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Ordenes;

namespace Capa_Vista_Ordenes
{
    public partial class Frm_Ordenes : Form
    {


        string sAuto = "Tbl_Orden_Compra_Autorizada";

        Cls_Controlador_Ordenes cn = new Cls_Controlador_Ordenes();
        public Frm_Ordenes()
        {
            InitializeComponent();
        }

        public void actualizardatagriew()
        {
            DataTable dt = cn.llenarTbl(sAuto);
            Dgv_Auto_Ordenes.DataSource = dt;

        }

        private void Btn_Consultar_Autorizaciones_Click(object sender, EventArgs e)
        {
            actualizardatagriew();
        }
    }
}
