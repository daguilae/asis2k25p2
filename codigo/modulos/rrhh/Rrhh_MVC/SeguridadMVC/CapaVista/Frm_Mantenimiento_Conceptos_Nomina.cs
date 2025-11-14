using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Seguridad
{
    public partial class Frm_Mantenimiento_Conceptos_Nomina : Form
    {
        public Frm_Mantenimiento_Conceptos_Nomina()
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
                "tbl_conceptosnomina",
                "Cmp_iId_ConceptoNomina",
                "Cmp_sNombre_ConceptoNomina",
                "Cmp_sDescripcion_ConceptoNomina",
                "Cmp_sTipo_ConceptoNomina",
                "Cmp_sTipoCalculo_ConceptoNomina",
                "Cmp_deValor_ConceptoNomina",
                "Cmp_bAplicaAutomatico_ConceptoNomina",
                "Fk_Codigo_Cuenta"

            };

            string[] sEtiquetas = {
                "Código ConceptoN",
                "Nombre",
                "Descripcion",
                "Tipo",
                "Tipo Calculo",
                "Valor",
                "Automatico",
                "Codigo Cuenta"

            };



            int id_aplicacion = 403;
            int id_Modulo = 5;
            navegador1.IPkId_Modulo = id_Modulo;
            navegador1.IPkId_Aplicacion = id_aplicacion;
            navegador1.configurarDataGridView(config);
            navegador1.SNombreTabla = columnas[0];
            navegador1.SAlias = columnas;
            navegador1.SEtiquetas = sEtiquetas;
            navegador1.mostrarDatos();
        }
    }
}
