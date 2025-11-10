using System;
using System.Data;
using System.Windows.Forms;
using Capa_Controlador_Check_In_Check_Out;
using Capa_Controlador_Seguridad;

namespace Capa_vista_Check_In_Check_out
{
    public partial class Frm_Area : Form
    {
        private readonly Cls_Area_Controlador Controlador = new Cls_Area_Controlador();
        Cls_BitacoraControlador ctrlBitacora = new Cls_BitacoraControlador();
        private bool _canIngresar, _canConsultar, _canModificar, _canEliminar, _canImprimir;


        public Frm_Area()
        {
            InitializeComponent();
            fun_CargarFolios();
            fun_AplicarPermisos();
            fun_CargarTiposMovimiento();
            fun_CargarAreas();
            fun_configuracion_inicial();
            fun_LimpiarCampos();
        }
        private void fun_AplicarPermisos()
        {
            int idUsuario = Cls_Usuario_Conectado.iIdUsuario;
            var usuarioCtrl = new Cls_Usuario_Controlador();
            var permisoUsuario = new Cls_Permiso_Usuario_Controlador();

            // Identificación del módulo y aplicación
            int idAplicacion = permisoUsuario.ObtenerIdAplicacionPorNombre("Area");
            if (idAplicacion <= 0) idAplicacion = 3404;
            int idModulo = permisoUsuario.ObtenerIdModuloPorNombre("Hoteleria");
            int idPerfil = usuarioCtrl.ObtenerIdPerfilDeUsuario(idUsuario);

            // Obtener permisos consolidados
            var permisos = Cls_Aplicacion_Permisos.ObtenerPermisosCombinados(idUsuario, idAplicacion, idModulo, idPerfil);

            // Validación
            if (!permisos.ingresar && !permisos.consultar &&
                !permisos.modificar && !permisos.eliminar &&
                !permisos.imprimir)
            {
                MessageBox.Show("El usuario no tiene permisos asignados para esta aplicación.",
                                "Permisos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Asignar permisos locales
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
            if (Btn_Buscar != null) Btn_Buscar.Enabled = _canConsultar;
            if (Btn_Reporte != null) Btn_Reporte.Enabled = _canImprimir;

            // Controles editables
            bool puedeEditar = (_canIngresar || _canModificar);
            Txt_Area.Enabled = puedeEditar;
            Txt_Descripcion.Enabled = puedeEditar;
            Txt_Montos.Enabled = puedeEditar;
            Cbo_Movimientos.Enabled = puedeEditar;
            Dtp_Fecha.Enabled = puedeEditar;
            Cbo_Folios.Enabled = _canConsultar || _canIngresar || _canModificar;
            Cbo_Areas.Enabled = _canConsultar;
        }
        private void fun_LimpiarCampos()
        {
            Txt_Idarea.Clear();
            Txt_Area.Clear();
            Txt_Descripcion.Clear();
            Txt_Montos.Clear();
            Cbo_Movimientos.SelectedIndex = -1;
            Cbo_Areas.SelectedIndex = -1;
            Dtp_Fecha.Value = DateTime.Now;

            if (Cbo_Folios.Items.Count > 0)
                Cbo_Folios.SelectedIndex = 0;
            else
                Cbo_Folios.SelectedIndex = -1;

            Cbo_Folios.BackColor = System.Drawing.Color.White;
        }
        public void fun_configuracion_inicial()
        {
            Btn_Guardar.Enabled = false;
            Btn_Modificar.Enabled = false;
            Btn_Eliminar.Enabled = false;
            Btn_Nuevo.Enabled = _canIngresar;
            Btn_Reporte.Enabled = _canImprimir;
            Btn_Buscar.Enabled = _canConsultar;
            Cbo_Areas.Enabled = _canConsultar;
            Txt_Idarea.Enabled = false;
            Txt_Area.Enabled = false;
            Txt_Descripcion.Enabled = false;
            Txt_Montos.Enabled = false;
            Cbo_Folios.Enabled = false;
            Cbo_Movimientos.Enabled = false;
            
        }

        private void fun_CargarFolios()
        {
            try
            {
            
                var dt = Controlador.fun_Obtener_Folios_Abiertos();
                Cbo_Folios.DataSource = dt;
                Cbo_Folios.DisplayMember = "DescripcionFolio";
                Cbo_Folios.ValueMember = "Pk_Id_Folio";

                if (dt.Rows.Count > 0)
                    Cbo_Folios.SelectedIndex = 0;
                else
                {
                    Cbo_Folios.SelectedIndex = -1;
                    MessageBox.Show("No hay folios abiertos disponibles.\nDebe crear o abrir un folio antes de registrar áreas.",
                                    "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar folios:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fun_CargarTiposMovimiento()
        {
            Cbo_Movimientos.Items.Clear();
            Cbo_Movimientos.Items.Add("Cargo");
            Cbo_Movimientos.Items.Add("Abono");
            Cbo_Movimientos.SelectedIndex = -1;
        }

        private void fun_CargarAreas()
        {
            try
            {
                // Método actualizado
                var dt = Controlador.fun_Obtener_Areas();
                Cbo_Areas.DataSource = dt;
                Cbo_Areas.DisplayMember = "DescripcionArea";
                Cbo_Areas.ValueMember = "Pk_Id_Area";
                Cbo_Areas.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar áreas:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cbo_Folios.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione un folio válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int iFkFolio = Convert.ToInt32(Cbo_Folios.SelectedValue);
                string sNombre = Txt_Area.Text.Trim();
                string sDescripcion = Txt_Descripcion.Text.Trim();
                string sTipo = Cbo_Movimientos.Text.Trim();
                string sMontoTexto = Txt_Montos.Text.Trim();
                DateTime dFecha = Dtp_Fecha.Value;

                // Método actualizado
                bool bOk = Controlador.bInsertar_Area(iFkFolio, sNombre, sDescripcion, sTipo, sMontoTexto, dFecha);

                if (bOk)
                {
                    MessageBox.Show("Área registrada exitosamente y vinculada al folio seleccionado.",
                                    "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fun_LimpiarCampos();
                    ctrlBitacora.RegistrarAccion(Capa_Controlador_Seguridad.Cls_Usuario_Conectado.iIdUsuario, 3404, $"Movimiento de Area Guardado: ", true);
                    fun_configuracion_inicial();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el registro:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            if (!_canModificar)
            {
                MessageBox.Show("No tiene permiso para modificar áreas.");
                return;
            }
            try
            {
                if (string.IsNullOrWhiteSpace(Txt_Idarea.Text))
                {
                    MessageBox.Show("Debe seleccionar un área para modificar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (Cbo_Folios.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar un folio válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int iIdArea = int.Parse(Txt_Idarea.Text);
                int iFkFolio = Convert.ToInt32(Cbo_Folios.SelectedValue);
                string sNombre = Txt_Area.Text.Trim();
                string sDescripcion = Txt_Descripcion.Text.Trim();
                string sTipo = Cbo_Movimientos.Text.Trim();
                string sMontoTexto = Txt_Montos.Text.Trim();
                DateTime dFecha = Dtp_Fecha.Value;

                
                bool bOk = Controlador.bActualizar_Area(iIdArea, iFkFolio, sNombre, sDescripcion, sTipo, sMontoTexto, dFecha);

                if (bOk)
                {
                    MessageBox.Show("Registro de área actualizado correctamente.",
                                    "Modificación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ctrlBitacora.RegistrarAccion(Capa_Controlador_Seguridad.Cls_Usuario_Conectado.iIdUsuario, 3404, $"Movimiento de Area Modificado ", true);
                    fun_LimpiarCampos();
                    
                    fun_configuracion_inicial();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el registro:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (!_canEliminar)
            {
                MessageBox.Show("No tiene permiso para eliminar áreas.");
                return;
            }
            try
            {
                if (string.IsNullOrWhiteSpace(Txt_Idarea.Text))
                {
                    MessageBox.Show("Debe seleccionar un registro para eliminar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int iIdArea = int.Parse(Txt_Idarea.Text);

                if (MessageBox.Show("¿Confirma eliminar el registro seleccionado?", "Confirmar eliminación",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //  Método actualizado
                    bool bOk = Controlador.bEliminar_Area(iIdArea);

                    if (bOk)
                    {
                        MessageBox.Show("Registro eliminado correctamente.",
                                        "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ctrlBitacora.RegistrarAccion(Capa_Controlador_Seguridad.Cls_Usuario_Conectado.iIdUsuario, 3404, $"Movimiento de Area Eliminado: ", true);
                        fun_LimpiarCampos();
                        fun_CargarAreas();
                        fun_configuracion_inicial();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el registro:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            if (!_canIngresar)
            {
                MessageBox.Show("No tiene permiso para crear nuevos Check-Outs.");
                return;
            }

            
            Btn_Guardar.Enabled = true;
            Btn_Modificar.Enabled = false;
            Btn_Eliminar.Enabled = false;
            Txt_Idarea.Enabled = false;
            Txt_Area.Enabled = true;
            Txt_Descripcion.Enabled = true;
            Txt_Montos.Enabled = true;
            Cbo_Folios.Enabled = true;
            Cbo_Movimientos.Enabled = true;
        }
    

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cbo_Areas.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione un área desde el listado de búsqueda.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataRowView row = (DataRowView)Cbo_Areas.SelectedItem;
                Txt_Idarea.Enabled = false;
                Txt_Area.Enabled = true;
                Txt_Descripcion.Enabled = true;
                Txt_Montos.Enabled = true;
                Cbo_Folios.Enabled = true;
                Cbo_Movimientos.Enabled = true;
                Txt_Idarea.Text = row["Pk_Id_Area"].ToString();
                Txt_Area.Text = Extraer(row, "Cmp_Nombre_Area");
                Txt_Descripcion.Text = Extraer(row, "Cmp_Descripcion");
                Cbo_Movimientos.Text = Extraer(row, "Cmp_Tipo_Movimiento");
                Txt_Montos.Text = Extraer(row, "Cmp_Monto");

                if (DateTime.TryParse(Extraer(row, "Cmp_Fecha_Movimiento"), out DateTime dFecha))
                    Dtp_Fecha.Value = dFecha;

                if (row.DataView.Table.Columns.Contains("Fk_Id_Folio"))
                    Cbo_Folios.SelectedValue = Convert.ToInt32(row["Fk_Id_Folio"]);

                MessageBox.Show($"Registro cargado correctamente:\nÁrea: {Txt_Area.Text}\nTipo: {Cbo_Movimientos.Text}\nMonto: Q{Txt_Montos.Text}",
                                "Consulta exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Btn_Modificar.Enabled = _canModificar;
                Btn_Eliminar.Enabled = _canEliminar;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la selección:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string Extraer(DataRowView row, string col)
        {
            return row.DataView.Table.Columns.Contains(col) ? row[col]?.ToString() ?? "" : "";
        }



        private void Cbo_Areas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Cbo_Areas.SelectedIndex == -1 || Cbo_Areas.SelectedValue == null)
                    return;

                DataRowView row = Cbo_Areas.SelectedItem as DataRowView;
                if (row == null)
                    return;

                Txt_Idarea.Text = row["Pk_Id_Area"].ToString();
                Txt_Area.Text = row["Cmp_Nombre_Area"].ToString();
                Txt_Descripcion.Text = row["Cmp_Descripcion"].ToString();
                Cbo_Movimientos.Text = row["Cmp_Tipo_Movimiento"].ToString();
                Txt_Montos.Text = row["Cmp_Monto"].ToString();

                if (DateTime.TryParse(row["Cmp_Fecha_Movimiento"].ToString(), out DateTime fecha))
                    Dtp_Fecha.Value = fecha;

                if (row.DataView.Table.Columns.Contains("Fk_Id_Folio"))
                    Cbo_Folios.SelectedValue = Convert.ToInt32(row["Fk_Id_Folio"]);

                Cbo_Areas.BackColor = System.Drawing.Color.LightYellow;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos del área seleccionada:\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
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
            Frm_Reporte_Area Reporte = new Frm_Reporte_Area();
            Reporte.Show();
        }
    }
}
