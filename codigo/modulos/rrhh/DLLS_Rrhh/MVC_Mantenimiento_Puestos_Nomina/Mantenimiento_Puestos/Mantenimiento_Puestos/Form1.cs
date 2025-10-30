using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mantenimiento_Puestos
{
    public partial class Form1 : Form
    {
        public Form1()
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
                Nombre = "dgv_puestos"
            };

            string[] columnas = {
                "tbl_puestos",
                "Cmp_iPuesto",
                "Cmp_vNombrePuesto",
                "Cmp_vDescripcionPuesto",
                "Cmp_iDepartamento",
            };

            string[] sEtiquetas = {
                "Código Puesto",
                "Código Nombre",
                "Descripcion",
                "Departamento"
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
