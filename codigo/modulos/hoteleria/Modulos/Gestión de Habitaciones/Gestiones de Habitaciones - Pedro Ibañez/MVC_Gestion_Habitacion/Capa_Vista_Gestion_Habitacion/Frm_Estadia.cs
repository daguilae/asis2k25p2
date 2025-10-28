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
    public partial class Frm_Estadia : Form
    {
        public Frm_Estadia()
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
                        "Tbl_Estadia",
                        "PK_ID_Estadia",
                        "FK_ID_Habitaciones",
                        "FK_ID_Huespedes",
                        "Cmp_Num_Huespedes",
                        "Cmp_Fecha_Check_In",
                        "Cmp_Fecha_Check_Out",
                        "Cmp_Tiene_Reservacion",
                        "Cmp_Monto_Total_Pago"
                    };

                   string[] sEtiquetas = {
                        "Código Estadía",
                        "Código Habitación",
                        "Código Huésped",
                        "Número de Huéspedes",
                        "Fecha Check-In",
                        "Fecha Check-Out",
                        "Tiene Reservación",
                        "Monto Total Pago"
                    };


            int id_aplicacion = 100;
            int id_Modulo = 4;
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
