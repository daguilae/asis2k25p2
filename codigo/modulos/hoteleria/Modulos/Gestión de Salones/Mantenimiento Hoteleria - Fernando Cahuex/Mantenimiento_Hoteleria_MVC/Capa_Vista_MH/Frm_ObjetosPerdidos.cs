using System;
using System.Data;
using System.Windows.Forms;
using Capa_Controlador_MH;

namespace Capa_Vista_MH
{
    public partial class Frm_ObjetosPerdidos : Form
    {
        private readonly Cls_Controlador_OP controlador = new Cls_Controlador_OP();

        public Frm_ObjetosPerdidos()
        {
            InitializeComponent();
        }

        private void Frm_ObjetosPerdidos_Load(object sender, EventArgs e)
        {
            controlador.fun_LlenarCombos(this);
            Dgv_Objeto_Perdido.DataSource = controlador.fun_MostrarObjetos();
        }

        // ============================================================
        // BOTONES CRUD
        // ============================================================
        private void Pic_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                int entregado = Chk_Entregado.Checked ? 1 : 0;

                controlador.fun_InsertarObjeto(
                    Cbo_Id_Mantenimiento.SelectedValue?.ToString(),
                    Cbo_Id_FolioSalon.SelectedValue?.ToString(),
                    Cbo_Id_FolioHabitacion.SelectedValue?.ToString(),
                    Cbo_Id_Huesped.SelectedValue?.ToString(),
                    Txt_Nombre_Objeto.Text,
                    Txt_Descripcion_Objeto.Text,
                    Txt_Tipo_Objeto.Text,
                    Dtp_Fecha_Encontrado.Value.ToString("yyyy-MM-dd"),
                    entregado
                );

                Dgv_Objeto_Perdido.DataSource = controlador.fun_MostrarObjetos();
                controlador.fun_LlenarCombos(this);
                controlador.fun_LimpiarCampos(this);

                MessageBox.Show("Registro guardado correctamente.", "Objetos Perdidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Pic_Editar_Click(object sender, EventArgs e)
        {
            try
            {
                string idObjeto = Cbo_Id_Objeto.SelectedValue?.ToString();
                if (string.IsNullOrWhiteSpace(idObjeto))
                {
                    MessageBox.Show("Seleccione el código del objeto a actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int entregado = Chk_Entregado.Checked ? 1 : 0;

                controlador.fun_ActualizarObjeto(
                    idObjeto,
                    Cbo_Id_Mantenimiento.SelectedValue?.ToString(),
                    Cbo_Id_FolioSalon.SelectedValue?.ToString(),
                    Cbo_Id_FolioHabitacion.SelectedValue?.ToString(),
                    Cbo_Id_Huesped.SelectedValue?.ToString(),
                    Txt_Nombre_Objeto.Text,
                    Txt_Descripcion_Objeto.Text,
                    Txt_Tipo_Objeto.Text,
                    Dtp_Fecha_Encontrado.Value.ToString("yyyy-MM-dd"),
                    entregado
                );

                Dgv_Objeto_Perdido.DataSource = controlador.fun_MostrarObjetos();
                controlador.fun_LlenarCombos(this);
                MessageBox.Show("Registro actualizado correctamente.", "Objetos Perdidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Pic_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string idObjeto = Cbo_Id_Objeto.SelectedValue?.ToString();
                if (string.IsNullOrWhiteSpace(idObjeto))
                {
                    MessageBox.Show("Seleccione el código del objeto que desea eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("¿Está seguro de eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    controlador.fun_EliminarObjeto(idObjeto);
                    Dgv_Objeto_Perdido.DataSource = controlador.fun_MostrarObjetos();
                    controlador.fun_LlenarCombos(this);
                    controlador.fun_LimpiarCampos(this);
                    MessageBox.Show("Registro eliminado correctamente.", "Objetos Perdidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Pic_Buscar_Click(object sender, EventArgs e)
        {
            controlador.fun_BuscarObjeto(this);
        }

        private void Pic_Cancelar_Click(object sender, EventArgs e)
        {
            controlador.fun_LimpiarCampos(this);
        }

        private void Pic_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 
        private void Cbo_Id_Objeto_SelectedIndexChanged(object sender, EventArgs e) { }
        private void Cbo_Id_FolioSalon_SelectedIndexChanged(object sender, EventArgs e) { }
        private void Cbo_Id_FolioHabitacion_SelectedIndexChanged(object sender, EventArgs e) { }
        private void Cbo_Id_Mantenimiento_SelectedIndexChanged(object sender, EventArgs e) { }
        private void Cbo_Id_Huesped_SelectedIndexChanged(object sender, EventArgs e) { }
        private void Txt_Nombre_Objeto_TextChanged(object sender, EventArgs e) { }
        private void Txt_Descripcion_Objeto_TextChanged(object sender, EventArgs e) { }
        private void Txt_Tipo_Objeto_TextChanged(object sender, EventArgs e) { }
        private void Dtp_Fecha_Encontrado_ValueChanged(object sender, EventArgs e) { }
        private void Chk_Entregado_CheckedChanged(object sender, EventArgs e) { }
        private void Dgv_Objeto_Perdido_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
