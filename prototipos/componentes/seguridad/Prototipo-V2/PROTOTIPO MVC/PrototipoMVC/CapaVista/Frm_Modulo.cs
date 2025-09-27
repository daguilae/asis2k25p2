﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Capa_Controlador_Seguridad;
using Capa_Modelo_Seguridad;

namespace Capa_Vista_Seguridad
{
    public partial class Frm_Modulo : Form
    {
        Cls_BitacoraControlador ctrlBitacora = new Cls_BitacoraControlador(); //Bitacora

        Cls_ModulosControlador cm = new Cls_ModulosControlador();

        private Frm_Reporte_modulos frmReporte = null;

        public Frm_Modulo()
        {
            InitializeComponent();
            fun_ConfigurarIdsDinamicamenteYAplicarPermisos();
        }

        private void frmModulo_Load(object sender, EventArgs e)
        {
            CargarComboBox();
        }

        private void CargarComboBox()
        {
            Cbo_busqueda.Items.Clear();
            string[] items = cm.ItemsModulos();
            foreach (var item in items)
            {
                Cbo_busqueda.Items.Add(item);
            }
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_id.Text) || string.IsNullOrEmpty(Txt_nombre.Text))
            {
                MessageBox.Show("Debe ingresar Id y Nombre.");
                return;
            }

            if (!int.TryParse(Txt_id.Text, out int Pk_Id_Modulo))
            {
                MessageBox.Show("Id debe ser un número.");
                return;
            }

            string Cmp_Nombre_Modulo = Txt_nombre.Text;
            string Cmp_Descripcion_Modulo = Txt_descripcion.Text;

            byte Cmp_Estado_Modulo = (Rdb_habilitado.Checked) ? (byte)1 : (byte)0;

            DataRow dr = cm.BuscarModulo(Pk_Id_Modulo);
            bool resultado = false;

            if (dr == null)
            {
                if (cm.BuscarModulo(Pk_Id_Modulo) != null)
                {
                    MessageBox.Show("El Id ingresado ya existe. Use otro.");
                    return;
                }

                resultado = cm.InsertarModulo(Pk_Id_Modulo, Cmp_Nombre_Modulo, Cmp_Descripcion_Modulo, Cmp_Estado_Modulo);
            }
            else
            {
                resultado = cm.ModificarModulo(Pk_Id_Modulo, Cmp_Nombre_Modulo, Cmp_Descripcion_Modulo, Cmp_Estado_Modulo);
            }

            if (resultado)
            {
                MessageBox.Show("Guardado correctamente!");
                CargarComboBox();
                ctrlBitacora.RegistrarAccion(Cls_UsuarioConectado.iIdUsuario, 1, "Guardar módulo", true);
                LimpiarCampos();
                Txt_id.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error al guardar el módulo.");
            }
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            Txt_id.Clear();
            Txt_nombre.Clear();
            Txt_descripcion.Clear();
            Rdb_habilitado.Checked = false;
            Rdb_inabilitado.Checked = false;
            Txt_id.Enabled = true;
            MessageBox.Show("Campos listos para nuevo registro");
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_id.Text))
            {
                MessageBox.Show("Ingrese el Id del módulo a eliminar.");
                return;
            }

            if (!int.TryParse(Txt_id.Text, out int Pk_Id_Modulo))
            {
                MessageBox.Show("Id debe ser un número.");
                return;
            }

            if (cm.ModuloEnUso(Pk_Id_Modulo))
            {
                MessageBox.Show("No se puede eliminar el módulo porque está siendo utilizado en una aplicación.");
                return;
            }

            bool resultado = cm.EliminarModulo(Pk_Id_Modulo);
            if (resultado)
            {
                MessageBox.Show("Módulo eliminado correctamente.");
                CargarComboBox();
                ctrlBitacora.RegistrarAccion(Cls_UsuarioConectado.iIdUsuario, 1, "Eliminar módulo", true);
                LimpiarCampos();
                Txt_id.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error al eliminar módulo.");
            }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            if (Cbo_busqueda.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un módulo para buscar.");
                return;
            }

            string seleccionado = Cbo_busqueda.SelectedItem.ToString();
            int Pk_Id_Modulo = int.Parse(seleccionado.Split('-')[0].Trim());

            DataRow dr = cm.BuscarModulo(Pk_Id_Modulo);
            if (dr != null)
            {
                Txt_id.Text = dr["Pk_Id_Modulo"].ToString();
                Txt_nombre.Text = dr["Cmp_Nombre_Modulo"].ToString();
                Txt_descripcion.Text = dr["Cmp_Descripcion_Modulo"].ToString();

                bool estado = Convert.ToBoolean(dr["Cmp_Estado_Modulo"]);
                Rdb_habilitado.Checked = estado;
                Rdb_inabilitado.Checked = !estado;

                Txt_id.Enabled = false;
                Cbo_busqueda.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Módulo no encontrado.");
            }
        }

        private void LimpiarCampos()
        {
            Txt_id.Clear();
            Txt_nombre.Clear();
            Txt_descripcion.Clear();
            Rdb_habilitado.Checked = false;
            Rdb_inabilitado.Checked = false;
            Cbo_busqueda.SelectedIndex = -1;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void Pic_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pnl_Superior_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void Btn_reporte_Click(object sender, EventArgs e)
        {
            if (frmReporte == null || frmReporte.IsDisposed)
            {
                frmReporte = new Frm_Reporte_modulos();
                frmReporte.FormClosed += (s, args) => frmReporte = null;
                frmReporte.Show();
            }
            else
            {
                frmReporte.BringToFront();
            }
        }

        private Cls_PermisoUsuario gPermisoUsuario = new Cls_PermisoUsuario();

        private List<(int iModuloId, int iAplicacionId)> gParesModuloAplicacion = new List<(int, int)>();

        private Dictionary<(int moduloId, int aplicacionId), (bool bIngresar, bool bConsultar, bool bModificar, bool bEliminar, bool bImprimir)> gPermisosPorModuloApp
            = new Dictionary<(int, int), (bool, bool, bool, bool, bool)>();

<<<<<<< HEAD
        private void ConfigurarIdsDinamicamenteYAplicarPermisos()
=======

        private void fun_ConfigurarIdsDinamicamenteYAplicarPermisos()
>>>>>>> main
        {
            int usuarioId = Cls_sesion.iUsuarioId;

            var sParesNombres = new List<(string sModulo, string sAplicacion)>
            {
                ("Seguridad", "Empleados"),
                ("Seguridad", "Gestion de empleado"),
                ("Seguridad", "Administracion"),
            };

            foreach (var (sNombreModulo, sNombreAplicacion) in sParesNombres)
            {
                int idModulo = gPermisoUsuario.ObtenerIdModuloPorNombre(sNombreModulo);
                int idAplicacion = gPermisoUsuario.ObtenerIdAplicacionPorNombre(sNombreAplicacion);

                if (idModulo != -1 && idAplicacion != -1)
                {
                    gParesModuloAplicacion.Add((idModulo, idAplicacion));
                }
            }

            fun_AplicarPermisosUsuario(usuarioId);
        }

        private void fun_AplicarPermisosUsuario(int usuarioId)
        {
            foreach (var (moduloId, aplicacionId) in gParesModuloAplicacion)
            {
                var bPermisos = gPermisoUsuario.ConsultarPermisos(usuarioId, aplicacionId, moduloId);

                if (bPermisos != null)
                {
                    gPermisosPorModuloApp[(moduloId, aplicacionId)] = bPermisos.Value;
                }
            }

            fun_CombinarPermisosYActualizarBotones();
        }

        private void fun_CombinarPermisosYActualizarBotones()
        {
            bool bIngresar = false;
            bool bConsultar = false;
            bool bModificar = false;
            bool bEliminar = false;

            foreach (var bPermiso in gPermisosPorModuloApp.Values)
            {
                bIngresar |= bPermiso.bIngresar;
                bConsultar |= bPermiso.bConsultar;
                bModificar |= bPermiso.bModificar;
                bEliminar |= bPermiso.bEliminar;
            }

            Btn_buscar.Enabled = bConsultar;
            Btn_reporte.Enabled = bConsultar;
            Btn_guardar.Enabled = bIngresar;
            Btn_eliminar.Enabled = bEliminar;
            Btn_nuevo.Enabled = bIngresar;
        }
    }
}
