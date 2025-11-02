using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Mantenimientos
{
    public partial class Frm_M_CuentasBancarias : Form
    {
        public Frm_M_CuentasBancarias()
        {
            InitializeComponent();
            Capa_Controlador_Navegador.Cls_ConfiguracionDataGridView config = new Capa_Controlador_Navegador.Cls_ConfiguracionDataGridView
            {
                Ancho = 1100,
                Alto = 200,
                PosX = 10,
                PosY = 300,
                ColorFondo = Color.AliceBlue,
                TipoScrollBars = ScrollBars.Both,
                Nombre = "dgv_Monedas"
            };

            string[] columnas = {
                "Tbl_CuentasBancarias",
                "Pk_Id_CuentaBancaria",
                "Fk_Id_Banco",
                "Cmp_NumeroCuenta",
                "Cmp_TipoCuenta",
                "Cmp_Moneda"
            };

            string[] sEtiquetas = {
                "ID Moneda",
                "Código Moneda",
                "Nombre Moneda",
                "Simbolo",
                "Estado"
            };



            int id_aplicacion = 100;
            navegador1.IPkId_Aplicacion = id_aplicacion;
            navegador1.configurarDataGridView(config);
            navegador1.SNombreTabla = columnas[0];
            navegador1.SAlias = columnas;
            navegador1.SEtiquetas = sEtiquetas;
            navegador1.mostrarDatos();
        }
    }
}
