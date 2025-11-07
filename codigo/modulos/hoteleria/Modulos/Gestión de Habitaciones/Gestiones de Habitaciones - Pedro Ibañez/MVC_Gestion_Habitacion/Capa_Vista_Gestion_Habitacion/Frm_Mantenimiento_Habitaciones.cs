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
    public partial class Frm_Mantenimiento_Habitaciones : Form
    {
        public Frm_Mantenimiento_Habitaciones()
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
                        "Tbl_Habitaciones",
                        "PK_ID_Habitaciones",
                        "FK_ID_Tipo_Habitaciones",
                        "Cmp_Piso_Habitacion",
                        "Cmp_Descripcion_Habitacion",
                        "Cmp_Tamaño_Habitacion_m2",
                        "Cmp_Capacidad_Habitacion",
                        "Cmp_Estado_Habitacion",
                        "Cmp_Tarifa_Noche"

                    };

                                string[] sEtiquetas = {
                        "Código Habitación",
                        "Código Tipo Habitación",
                        "Piso de Habitación",
                        "Descripción de Habitación",
                        "Tamaño Habitación (m²)",
                        "Capacidad Habitaciones",
                        "Estado de Habitación",
                        "Tarifa por Noche"
                    };


            int id_aplicacion = 3043;
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
