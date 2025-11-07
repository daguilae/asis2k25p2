using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Navegador;

namespace Capa_Vista_Bancos
{
    public partial class Frm_Mantenimiento_Prueba : Form
    {
        public Frm_Mantenimiento_Prueba()
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
                "Tbl_Monedas",
                "Pk_Id_Moneda",
                "Cmp_CodigoMoneda",
                "Cmp_NombreMoneda",
                "Cmp_Simbolo",
                "Cmp_Estado"
            };

            string[] sEtiquetas = {
                "ID Moneda",
                "Código Moneda",
                "Nombre Moneda",
                "Simbolo",
                "Estado"
            };



            int id_aplicacion = 1401;
            int id_modulo = 6;
            navegador1.IPkId_Aplicacion = id_aplicacion;
            navegador1.IPkId_Modulo = id_modulo;
            navegador1.configurarDataGridView(config);
            navegador1.SNombreTabla = columnas[0];
            navegador1.SAlias = columnas;
            navegador1.SEtiquetas = sEtiquetas;
            navegador1.mostrarDatos();
        }
    }
}
