using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_vista_Check_In_Check_out
{
    public partial class Frm_Promociones : Form
    {
        public Frm_Promociones()
        {
            InitializeComponent();
            //parametros para navegador
            Capa_Controlador_Navegador.Cls_ConfiguracionDataGridView config = new Capa_Controlador_Navegador.Cls_ConfiguracionDataGridView
            {
                Ancho = 1100,
                Alto = 200,
                PosX = 10,
                PosY = 300,
                ColorFondo = Color.AliceBlue,
                TipoScrollBars = ScrollBars.Both,
                Nombre = "dgv_empleados"
            };

            string[] columnas = {
                    "Tbl_Promociones",
                    "Pk_ID_Promociones",
                    "Cmp_Nombre_Promocion",
                    "Cmp_Descripcion",
                    "Cmp_Porcentaje_Descuento",
                    "Cmp_Fecha_Inicio",
                     "Cmp_Fecha_Final"
            };

            string[] sEtiquetas = {
                    "Código Promocion",
                    "Nombre de la promocion",
                    "Descripción",
                    "Porcentaje de descuento",
                    "Fecha de Inicio",
                    "Fecha Final"
                };


            int id_aplicacion = 3412;
           int id_Modulo = 6;
            navegador1.IPkId_Aplicacion = id_aplicacion;
            navegador1.IPkId_Modulo = id_Modulo;
            navegador1.configurarDataGridView(config);
            navegador1.SNombreTabla = columnas[0];
            navegador1.SAlias = columnas;
            navegador1.SEtiquetas = sEtiquetas;
            navegador1.mostrarDatos();
        }
    }
}