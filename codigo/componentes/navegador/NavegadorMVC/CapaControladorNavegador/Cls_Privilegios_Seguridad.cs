using System;
using System.Drawing;
using System.Windows.Forms;

namespace Capa_vista_Check_In_Check_out
{
    public partial class Frm_Areas : Form
    {
        // 🔹 Variables para almacenar el usuario actual
        private int idUsuarioActual;
        private string nombreUsuarioActual;

        public Frm_Areas()
        {
            InitializeComponent();

            // =====================================
            // ✅ Obtener datos del usuario conectado
            // =====================================
            idUsuarioActual = Capa_Modelo_Seguridad.Cls_Usuario_Conectado.iIdUsuario;
            nombreUsuarioActual = Capa_Modelo_Seguridad.Cls_Usuario_Conectado.sNombreUsuario;

            // ✅ Mostrar usuario conectado en el label
            lblUsuario.Text = $"Usuario conectado: {nombreUsuarioActual} (ID: {idUsuarioActual})";

            // =====================================
            // ⚙️ Configurar el Navegador
            // =====================================
            ConfigurarNavegador();
        }

        private void ConfigurarNavegador()
        {
            Capa_Controlador_Navegador.Cls_ConfiguracionDataGridView config =
                new Capa_Controlador_Navegador.Cls_ConfiguracionDataGridView
                {
                    Ancho = 1100,
                    Alto = 200,
                    PosX = 10,
                    PosY = 300,
                    ColorFondo = Color.AliceBlue,
                    TipoScrollBars = ScrollBars.Both,
                    Nombre = "dgv_empleados"
                };

            string[] columnas =
            {
                "Tbl_Perfil",
                "Pk_Id_Perfil",
                "Cmp_Puesto_Perfil",
                "Cmp_Descripcion_Perfil",
                "Cmp_Estado_Perfil",
                "Cmp_Tipo_Perfil"
            };

            string[] sEtiquetas =
            {
                "Código Perfil",
                "Puesto del Perfil",
                "Descripción del Perfil",
                "Estado del Perfil",
                "Tipo de Perfil"
            };

            // ✅ IDs asociados al módulo
            int id_aplicacion = 303;
            int id_modulo = 4;

            navegador1.IPkId_Aplicacion = id_aplicacion;
            navegador1.IPkId_Modulo = id_modulo;
            navegador1.configurarDataGridView(config);
            navegador1.SNombreTabla = columnas[0];
            navegador1.SAlias = columnas;
            navegador1.SEtiquetas = sEtiquetas;

            // ✅ Cargar datos y permisos según Seguridad
            navegador1.ObtenerIdAplicacion(id_aplicacion.ToString());
            navegador1.ObtenerIdModulo(id_modulo.ToString());
            navegador1.ObtenerPermisos();
            navegador1.ObtenerBitacora();

            navegador1.mostrarDatos();
        }
    }
}
