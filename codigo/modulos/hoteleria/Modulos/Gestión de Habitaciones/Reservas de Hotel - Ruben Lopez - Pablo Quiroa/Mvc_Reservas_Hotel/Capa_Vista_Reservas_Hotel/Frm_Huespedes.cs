using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Reservas_Hotel
{
    public partial class Frm_Huespedes : Form
    {
      

        public Frm_Huespedes()
        {
            InitializeComponent();
            // Configurar el navegador
            var config = new Capa_Controlador_Navegador.Cls_ConfiguracionDataGridView
            {
                Ancho = 1100,
                Alto = 200,
                PosX = 10,
                PosY = 300,
                ColorFondo = Color.AliceBlue,
                TipoScrollBars = ScrollBars.Both,
                Nombre = "dgv_huesped"
            };

            string[] columnas =
            {
                "Tbl_Huesped",
                "Pk_Id_Huesped",
                "Cmp_Tipo_Documento",
                "Cmp_Numero_Documento",
                "Cmp_Nombre",
                "Cmp_Apellido",
               "Cmp_Email",
               "Cmp_Telefono",
               "Cmp_Pais",
               "Cmp_Viaja_Por_Trabajo",
               "Cmp_Nombre_Empresa"
            };

            string[] etiquetas =
            {
                "Código Huesped",
                "Tipo de documento",
                "Numero de documento",
                "Nombre",
                "Apellido",
                "Email",
                "Telefono",
                "Pais",
                "Viaje por trabajo",
                "Nombre de empresa"
            };

            navegador1.IPkId_Aplicacion = 3401;
            navegador1.IPkId_Modulo = 6;
            navegador1.configurarDataGridView(config);
            navegador1.SNombreTabla = columnas[0];
            navegador1.SAlias = columnas;
            navegador1.SEtiquetas = etiquetas;
            navegador1.mostrarDatos();



        }


    }
}

    

