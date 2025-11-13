using System;
using System.Data;
using System.Windows.Forms;
using Capa_Controlador_Cierre;

namespace Capa_Vista_Cierre
{
    public partial class Frm_Cierre : Form
    {
        private readonly Cls_Cierre_Controlador ctrl = new Cls_Cierre_Controlador();
        private Cls_Cierre_Controlador.CierreResultado ultimoResultado;

        public Frm_Cierre()
        {
            InitializeComponent();
            // Centrar el formulario en la pantalla al iniciar
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Frm_Cierre_Load(object sender, EventArgs e)
        {
            fun_BloquearControles();
            Txt_ingresos.Text = Txt_egresos.Text = Txt_Saldo_total.Text = "Q 0.00";
        }

        // BOTÓN AGREGAR (NUEVO CIERRE)
        private void Btn_Agregar_cierre_Click(object sender, EventArgs e)
        {
            fun_HabilitarControles();
            Btn_Agregar_cierre.Enabled = false; // Evita reiniciar mientras se edita

            Txt_Descripcion_Cierre.Clear();
            Txt_ingresos.Text = "Q 0.00";
            Txt_egresos.Text = "Q 0.00";
            Txt_Saldo_total.Text = "Q 0.00";
            Dgv_Cierre_general.DataSource = null;
            ultimoResultado = null;

            Dtp_Fecha_Cierre.Value = DateTime.Now;
            Txt_Descripcion_Cierre.Focus();
        }

        //BOTÓN GENERAR CIERRE
        private void Btn_generar_Click(object sender, EventArgs e)
        {
            try
            {
                string sDescripcion = Txt_Descripcion_Cierre.Text.Trim();
                DateTime dFechaCorte = Dtp_Fecha_Cierre.Value.Date;

                ultimoResultado = ctrl.fun_GenerarCierre(dFechaCorte, sDescripcion);

                if (ultimoResultado == null || ultimoResultado.Detalle.Rows.Count == 0)
                {
                    MessageBox.Show("No existen folios cerrados ni pagos de salones para esta fecha.",
                                    "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fun_LimpiarTodo();
                    return;
                }

                Dgv_Cierre_general.DataSource = ultimoResultado.Detalle;
                Txt_ingresos.Text = $"Q {ultimoResultado.doIngresos:N2}";
                Txt_egresos.Text = $"Q {ultimoResultado.doEgresos:N2}";
                Txt_Saldo_total.Text = $"Q {ultimoResultado.doSaldo:N2}";

                MessageBox.Show("Cierre generado correctamente. Revise los totales antes de guardar.",
                                "Generar Cierre", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al generar cierre: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // BOTÓN GUARDAR CIERRE
        private void Btn_guardar_cierre_Click(object sender, EventArgs e)
        {
            try
            {
                if (ultimoResultado == null || ultimoResultado.Detalle == null || ultimoResultado.Detalle.Rows.Count == 0)
                {
                    MessageBox.Show("Debe generar el cierre antes de guardarlo.",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime dFecha = Dtp_Fecha_Cierre.Value.Date;
                string sDescripcion = Txt_Descripcion_Cierre.Text.Trim();

                bool exito = ctrl.fun_GuardarCierre(
                    dFecha, sDescripcion,
                    ultimoResultado.doIngresos,
                    ultimoResultado.doEgresos,
                    ultimoResultado.doSaldo,
                    ultimoResultado.Detalle
                );

                if (exito)
                {
                    MessageBox.Show("Cierre guardado correctamente.",
                                    "Guardar Cierre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fun_LimpiarTodo();
                }
                else
                {
                    MessageBox.Show("No se puede guardar el cierre.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar cierre: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //BOTÓN BUSCAR CIERRE
        private void Btn_Buscar_cierre_Click(object sender, EventArgs e)
        {
            try
            {
                // Limpia vista previa anterior
                Dgv_Cierre_general.DataSource = null;
                Cbo_buscar.Enabled = true;

                // Obtiene la lista de cierres disponibles
                DataTable lista = ctrl.fun_ObtenerListaCierres();

                if (lista == null || lista.Rows.Count == 0)
                {
                    MessageBox.Show("No existen cierres registrados en la base de datos.",
                                    "Sin registros",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                // Asignar datos al ComboBox
                Cbo_buscar.DataSource = lista;
                Cbo_buscar.DisplayMember = "Etiqueta";  // (Ej: 3 - 05/11/2025)
                Cbo_buscar.ValueMember = "ID_Cierre";
                Cbo_buscar.SelectedIndex = -1;

                //Mostrar texto guía dentro del ComboBox
                Cbo_buscar.Text = "— Seleccione un cierre —";

                //Mostrar mensaje informativo al usuario
                MessageBox.Show("Seleccione el cierre que desea consultar (ID - Fecha).",
                                "Buscar Cierre",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                //Bloquear los demás botones mientras el usuario elige
                Btn_generar.Enabled = false;
                Btn_guardar_cierre.Enabled = false;
                Btn_Agregar_cierre.Enabled = false;
                Btn_eliminar_cierre.Enabled = false;
                Btn_cancelar.Enabled = true;
                Btn_Imprimir_cierre_general.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al cargar lista de cierres: " + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        //COMBOBOX: SELECCIONAR CIERRE
        private void Cbo_buscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_buscar.SelectedIndex < 0) return;

            var value = Cbo_buscar.SelectedValue;
            if (value == null || value is DataRowView) return;

            if (!int.TryParse(value.ToString(), out int iIdCierre))
                return;
            try
            {
                // Usar nuevo método del controlador que encapsula todo
                var resultadoConsulta = ctrl.fun_CargarCierreExistente(iIdCierre);
                Dgv_Cierre_general.DataSource = resultadoConsulta.Detalle;

                if (resultadoConsulta.Detalle.Rows.Count == 0)
                {
                    MessageBox.Show("No hay folios asociados a este cierre.",
                                    "Detalle vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Dtp_Fecha_Cierre.Value = resultadoConsulta.dFecha == default ? DateTime.Now : resultadoConsulta.dFecha;
                Txt_Descripcion_Cierre.Text = resultadoConsulta.sDescripcion;

                Txt_ingresos.Text = $"Q {resultadoConsulta.doIngresos:N2}";
                Txt_egresos.Text = $"Q {resultadoConsulta.doEgresos:N2}";
                Txt_Saldo_total.Text = $"Q {resultadoConsulta.doSaldo:N2}";

                // Modo lectura
                Dtp_Fecha_Cierre.Enabled = false;
                Txt_Descripcion_Cierre.Enabled = false;
                Btn_generar.Enabled = false;
                Btn_guardar_cierre.Enabled = false;
                Btn_Agregar_cierre.Enabled = false;
                Btn_eliminar_cierre.Enabled = true;
                Btn_cancelar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al cargar cierre: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //UTILIDADES
        private void fun_BloquearControles()
        {
            Dtp_Fecha_Cierre.Enabled = false;
            Txt_Descripcion_Cierre.Enabled = false;
            Txt_ingresos.Enabled = false;
            Txt_egresos.Enabled = false;
            Txt_Saldo_total.Enabled = false;
            Cbo_buscar.Enabled = false;

            Btn_generar.Enabled = false;
            Btn_guardar_cierre.Enabled = false;
            Btn_eliminar_cierre.Enabled = false;
            Btn_Buscar_cierre.Enabled = false;
            Btn_cancelar.Enabled = false;
            Btn_Imprimir_cierre_general.Enabled = false;
        }

        private void fun_HabilitarControles()
        {
            Dtp_Fecha_Cierre.Enabled = true;
            Txt_Descripcion_Cierre.Enabled = true;
            Btn_generar.Enabled = true;
            Btn_guardar_cierre.Enabled = true;
            Btn_eliminar_cierre.Enabled = true;
            Btn_Buscar_cierre.Enabled = true;
            Btn_cancelar.Enabled = true;
            Btn_Imprimir_cierre_general.Enabled = true;
        }

        private void fun_LimpiarFormulario()
        {
            Txt_Descripcion_Cierre.Clear();
            Txt_ingresos.Text = Txt_egresos.Text = Txt_Saldo_total.Text = "Q 0.00";
            Dgv_Cierre_general.DataSource = null;
            ultimoResultado = null;
        }

        //BOTÓN ELIMINAR CIERRE
        private void Btn_eliminar_cierre_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cbo_buscar.SelectedValue == null || Cbo_buscar.SelectedValue is DataRowView)
                {
                    MessageBox.Show("Seleccione un cierre para eliminar.", "Aviso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int iIdCierre = Convert.ToInt32(Cbo_buscar.SelectedValue);

                var confirm = MessageBox.Show(
                    $"¿Está seguro que desea eliminar el cierre #{iIdCierre}?\n\n",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.No)
                    return;

                bool exito = ctrl.fun_EliminarCierre(iIdCierre);

                if (exito)
                {
                    MessageBox.Show("✅ Cierre eliminado correctamente.",
                                    "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fun_LimpiarTodo();
                }
                else
                {
                    MessageBox.Show("⚠️ No se pudo eliminar el cierre seleccionado.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al eliminar cierre: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // BOTÓN CANCELAR
        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            fun_LimpiarTodo();
        }

        //LIMPIAR TODO
        private void fun_LimpiarTodo()
        {
            Txt_Descripcion_Cierre.Clear();
            Txt_ingresos.Text = "Q 0.00";
            Txt_egresos.Text = "Q 0.00";
            Txt_Saldo_total.Text = "Q 0.00";
            Dtp_Fecha_Cierre.Value = DateTime.Now;
            Dgv_Cierre_general.DataSource = null;
            Cbo_buscar.DataSource = null;
            Cbo_buscar.Items.Clear();
            Cbo_buscar.Text = string.Empty;
            Cbo_buscar.Enabled = false;
            ultimoResultado = null;

            fun_BloquearControles();

            Btn_Agregar_cierre.Enabled = true;
        }

        // BOTÓN IMPRIMIR CIERRE GENERAL
        private void Btn_Imprimir_cierre_general_Click_1(object sender, EventArgs e)
        {
            Frm_Reporte_CD frm = new Frm_Reporte_CD();
            frm.ShowDialog();
        }
    }
}