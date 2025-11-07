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
    public partial class Frm_M_Bancos : Form
    {
        public Frm_M_Bancos()
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
                Nombre = "dgv_Bancos"
            };

            string[] columnas = {
                "Tbl_Bancos",
                "Pk_Id_Banco",
                "Cmp_CodigoBanco",
                "Cmp_NombreBanco",
                "Cmp_Direccion",
                "Cmp_Telefono",
                "Cmp_Estado"
            };

            string[] sEtiquetas = {
                "ID Banco",
                "Código Banco",
                "Nombre Banco",
                "Dirección",
                "Teléfono",
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
