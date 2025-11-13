using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Gestion_Habitacion
{
    public partial class Frm_Mantenimiento_Tipo_Habitaciones : Form
    {
        public Frm_Mantenimiento_Tipo_Habitaciones()
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
                    "Tbl_Tipo_Habitacion",
                    "Pk_ID_Tipo_Habitaciones",
                    "Cmp_Tipo_Habitacion",
                    "Cmp_Descripcion_Tipo_Habitacion"
                };

                string[] sEtiquetas = {
                    "Código Tipo Habitación",
                    "Tipo de Habitación",
                    "Descripción del Tipo"
                };


            int id_aplicacion = 3042;
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
