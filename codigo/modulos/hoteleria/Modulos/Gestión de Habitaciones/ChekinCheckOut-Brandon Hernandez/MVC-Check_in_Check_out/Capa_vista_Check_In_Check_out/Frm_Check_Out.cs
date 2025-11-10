using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Capa_Controlador_Check_In_Check_Out;
using Capa_Controlador_Seguridad;

namespace Capa_vista_Check_In_Check_out
{
    public partial class Frm_Check_Out : Form
    {
        private readonly Cls_Check_Out_Controlador Controlador = new Cls_Check_Out_Controlador();
        Cls_BitacoraControlador ctrlBitacora = new Cls_BitacoraControlador();
        private bool _canIngresar, _canConsultar, _canModificar, _canEliminar, _canImprimir;

        public Frm_Check_Out()
        {
            InitializeComponent();
            fun_AplicarPermisos();
            fun_CargarCombos();
            fun_CargarDatos();
            fun_ConfigurarDataGrid();
            fun_configuracion_inicial();
        }
        private void fun_AplicarPermisos()
        {
            int idUsuario = Cls_Usuario_Conectado.iIdUsuario;
            var usuarioCtrl = new Cls_Usuario_Controlador();
            var permisoUsuario = new Cls_Permiso_Usuario_Controlador();

            // Identificadores específicos
            int idAplicacion = permisoUsuario.ObtenerIdAplicacionPorNombre("Check Out");
            if (idAplicacion <= 0) idAplicacion = 3403;
            int idModulo = permisoUsuario.ObtenerIdModuloPorNombre("Hoteleria");
            int idPerfil = usuarioCtrl.ObtenerIdPerfilDeUsuario(idUsuario);

            var permisos = Cls_Aplicacion_Permisos.ObtenerPermisosCombinados(idUsuario, idAplicacion, idModulo, idPerfil);

            // Validar si el usuario no tiene permisos
            if (!permisos.ingresar && !permisos.consultar &&
                !permisos.modificar && !permisos.eliminar &&
                !permisos.imprimir)
            {
                MessageBox.Show("El usuario no tiene permisos asignados para esta aplicación.",
                                "Permisos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Asignar permisos
            _canIngresar = permisos.ingresar;
            _canConsultar = permisos.consultar;
            _canModificar = permisos.modificar;
            _canEliminar = permisos.eliminar;
            _canImprimir = permisos.imprimir;

            // Aplicar permisos a los controles
            if (Btn_Nuevo != null) Btn_Nuevo.Enabled = _canIngresar;
            if (Btn_Guardar != null) Btn_Guardar.Enabled = _canIngresar;
            if (Btn_Modificar != null) Btn_Modificar.Enabled = _canModificar;
            if (Btn_Eliminar != null) Btn_Eliminar.Enabled = _canEliminar;
            if (Btn_Reporte != null) Btn_Reporte.Enabled = _canImprimir;

            // Tabla y combos según permiso de consulta
            Dgv_Check_Out.Enabled = _canConsultar;
            Cbo_Huesped.Enabled = _canConsultar || _canIngresar || _canModificar;
            Dtp_Fecha_CheckOut.Enabled = _canIngresar || _canModificar;
        }
        public void fun_configuracion_inicial()
        {
            Cbo_Huesped.Enabled = false;
            Txt_Check_out.Enabled = false;
            Dtp_Fecha_CheckOut.Enabled = false;
            Btn_Guardar.Enabled = false;
            Btn_Modificar.Enabled = false;
            Btn_Eliminar.Enabled = false;
            Btn_Nuevo.Enabled = _canIngresar;
            Btn_Reporte.Enabled = _canImprimir;
        }

        private void fun_ConfigurarDataGrid()
        {
            Dgv_Check_Out.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Check_Out.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv_Check_Out.MultiSelect = false;
            Dgv_Check_Out.ReadOnly = true;
        }

        private void fun_LimpiarCampos()
        {
            Txt_Check_out.Clear();
            Cbo_Huesped.SelectedIndex = -1;
            Dtp_Fecha_CheckOut.Value = DateTime.Now;
            Dtp_Fecha_CheckOut.CalendarMonthBackground = System.Drawing.Color.White;
            Cbo_Huesped.BackColor = System.Drawing.Color.White;
        }

        private void fun_CargarCombos()
        {
            try
            {
                DataTable dt = Controlador.fun_Obtener_CheckIn();

                if (!dt.Columns.Contains("Descripcion_Combo"))
                    dt.Columns.Add("Descripcion_Combo", typeof(string));

                foreach (DataRow row in dt.Rows)
                {
                    int id = Convert.ToInt32(row["Pk_Id_Check_in"]);
                    string nombre = row["Nombre_Huesped"].ToString();
                    string fecha = Convert.ToDateTime(row["Cmp_Fecha_Check_In"]).ToString("dd/MM/yyyy");
                    row["Descripcion_Combo"] = $"#{id} – {nombre} – {fecha}";
                }

                Cbo_Huesped.DataSource = dt;
                Cbo_Huesped.DisplayMember = "Descripcion_Combo";
                Cbo_Huesped.ValueMember = "Pk_Id_Check_in";
                Cbo_Huesped.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar Check-In disponibles: " + ex.Message);
            }
        }

        private void fun_CargarDatos()
        {
            try
            {
                Dgv_Check_Out.DataSource = Controlador.fun_Mostrar_CheckOut();

                if (Dgv_Check_Out.Columns.Contains("Fk_Id_Check_In"))
                    Dgv_Check_Out.Columns["Fk_Id_Check_In"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tabla de Check-Outs: " + ex.Message);
            }
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            if (!_canIngresar)
            {
                MessageBox.Show("No tiene permiso para crear nuevos Check-Outs.");
                return;
            }

            fun_LimpiarCampos();
            Btn_Guardar.Enabled = true;
            Btn_Modificar.Enabled = false;
            Btn_Eliminar.Enabled = false;
            Cbo_Huesped.Enabled = true;
            Txt_Check_out.Enabled = false;
            Dtp_Fecha_CheckOut.Enabled = true;
        }

    

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cbo_Huesped.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar un Check-In válido.",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Cbo_Huesped.BackColor = System.Drawing.Color.MistyRose;
                    return;
                }

                Cbo_Huesped.BackColor = System.Drawing.Color.White;

                int iIdCheckIn = Convert.ToInt32(Cbo_Huesped.SelectedValue);
                DateTime dFechaCheckOut = Dtp_Fecha_CheckOut.Value;

                // Llama al método estandarizado
                bool bExito = Controlador.pro_Registrar_CheckOut_Con_Folio(iIdCheckIn, dFechaCheckOut);

                if (bExito)
                {
                    fun_CargarDatos();
                    fun_LimpiarCampos();
                    fun_configuracion_inicial();

                    MessageBox.Show("Check-Out registrado correctamente.",
                        "Proceso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ctrlBitacora.RegistrarAccion(Capa_Controlador_Seguridad.Cls_Usuario_Conectado.iIdUsuario, 3403, $"Check Out Guardado ", true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar Check-Out: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Txt_Check_out.Text))
                {
                    MessageBox.Show("Seleccione un registro para modificar.",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (Cbo_Huesped.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar un Check-In válido.",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int iIdCheckOut = Convert.ToInt32(Txt_Check_out.Text);
                int iIdCheckIn = Convert.ToInt32(Cbo_Huesped.SelectedValue);
                DateTime dFechaCheckOut = Dtp_Fecha_CheckOut.Value;

                // Usa el método estandarizado correcto
                if (Controlador.bActualizar_CheckOut(iIdCheckOut, iIdCheckIn, dFechaCheckOut, out string sMensaje))
                {
                    MessageBox.Show(sMensaje);
                    fun_CargarDatos();
                    fun_LimpiarCampos();
                    fun_configuracion_inicial();
                    ctrlBitacora.RegistrarAccion(Capa_Controlador_Seguridad.Cls_Usuario_Conectado.iIdUsuario, 3403, $"Check Out Modificado ", true);
                }
                else
                {
                    MessageBox.Show(sMensaje);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar Check-Out: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Txt_Check_out.Text))
                {
                    MessageBox.Show("Seleccione un registro para eliminar.",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int iIdCheckOut = Convert.ToInt32(Txt_Check_out.Text);

                // Usa el método estandarizado correcto
                if (Controlador.bEliminar_CheckOut(iIdCheckOut, out string sMensajeError))
                {
                    MessageBox.Show("Check-Out eliminado correctamente.",
                        "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fun_CargarDatos();
                    fun_LimpiarCampos();
                    fun_configuracion_inicial();
                    ctrlBitacora.RegistrarAccion(Capa_Controlador_Seguridad.Cls_Usuario_Conectado.iIdUsuario, 3403, $"Check Out Eliminado ", true);
                }
                else
                {
                    MessageBox.Show(sMensajeError);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar Check-Out: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            fun_LimpiarCampos();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dgv_Check_Out_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!_canConsultar) return;

            Btn_Modificar.Enabled = _canModificar;
            Btn_Eliminar.Enabled = _canEliminar;
            Btn_Guardar.Enabled = false;
            Cbo_Huesped.Enabled = true;
            Txt_Check_out.Enabled = false;
            Dtp_Fecha_CheckOut.Enabled = true;

            if (e.RowIndex >= 0)
            {
                try
                {
                    Txt_Check_out.Text = Dgv_Check_Out.Rows[e.RowIndex].Cells["Pk_Id_Check_out"].Value.ToString();

                    if (Cbo_Huesped.DataSource == null)
                        fun_CargarCombos();

                    var colCheckIn = Dgv_Check_Out.Columns.Cast<DataGridViewColumn>()
                        .FirstOrDefault(c => c.Name.ToLower().Contains("check_in"));

                    if (colCheckIn != null)
                    {
                        object valor = Dgv_Check_Out.Rows[e.RowIndex].Cells[colCheckIn.Name].Value;
                        if (valor != null && int.TryParse(valor.ToString(), out int iIdCheckIn))
                        {
                            var dtSource = (Cbo_Huesped.DataSource as DataTable);
                            bool existe = dtSource.AsEnumerable()
                                .Any(r => Convert.ToInt32(r["Pk_Id_Check_in"]) == iIdCheckIn);

                            if (existe)
                            {
                                Cbo_Huesped.SelectedValue = iIdCheckIn;
                            }
                            else
                            {
                                DataRow newRow = dtSource.NewRow();
                                newRow["Pk_Id_Check_in"] = iIdCheckIn;
                                newRow["Nombre_Huesped"] = Dgv_Check_Out.Rows[e.RowIndex].Cells["Nombre_Huesped"].Value.ToString();
                                newRow["Cmp_Fecha_Check_In"] = Dgv_Check_Out.Rows[e.RowIndex].Cells["Cmp_Fecha_Check_In"].Value;
                                newRow["Descripcion_Combo"] = $"#{iIdCheckIn} – {newRow["Nombre_Huesped"]} – {Convert.ToDateTime(newRow["Cmp_Fecha_Check_In"]).ToString("dd/MM/yyyy")}";
                                dtSource.Rows.Add(newRow);
                                Cbo_Huesped.SelectedValue = iIdCheckIn;
                            }
                        }
                    }

                    Dtp_Fecha_CheckOut.Value = Convert.ToDateTime(Dgv_Check_Out.Rows[e.RowIndex].Cells["Cmp_Fecha_Check_Out"].Value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos del registro: " + ex.Message);
                }
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            fun_configuracion_inicial();
            fun_LimpiarCampos();
        }

        private void Btn_Reporte_Click(object sender, EventArgs e)
        {
            if (!_canImprimir)
            {
                MessageBox.Show("No tiene permiso para generar reportes.");
                return;
            }
            Frm_Reporte_Check_Out Reporte = new Frm_Reporte_Check_Out();
            Reporte.Show();
        }
    }
}
