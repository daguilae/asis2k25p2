using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_MH;

namespace Capa_Vista_MH
{
    public partial class Frm_Mantenimiento_hoteleria : Form
    {
        Cls_Controlador_MH controlador = new Cls_Controlador_MH();

        public Frm_Mantenimiento_hoteleria()
        {
            InitializeComponent();
        }

        private void Frm_Mantenimiento_hoteleria_Load(object sender, EventArgs e)
        {
            MostrarMantenimientos();

        }


        private void Pic_Guardar_Click(object sender, EventArgs e)
        {

            try
            {
                // Inserta un nuevo registro en la BD
                controlador.GuardarMantenimiento(
                    Cbo_Id_Salon.Text,
                    Cbo_Id_Habitacion.Text,
                    Cbo_Id_Empleado.Text,
                    Txt_Tipo_Mantenimiento.Text,
                    Txt_Descripcion_Mantenimiento.Text,
                    Txt_Estado.Text,
                    Txt_Fecha_inicio.Text,
                    Txt_Fecha_Fin.Text
                );

                MessageBox.Show("Registro guardado correctamente.", "Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarMantenimientos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void Pic_Editar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Cbo_Id_Mantenimiento.Text))
                {
                    MessageBox.Show("Por favor selecciona un ID de mantenimiento para modificar.",
                                    "Modificar Registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "¿Deseas actualizar el mantenimiento con ID " + Cbo_Id_Mantenimiento.Text + "?",
                    "Confirmar modificación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    controlador.ActualizarMantenimiento(
                        Cbo_Id_Mantenimiento.Text,
                        Cbo_Id_Salon.Text,
                        Cbo_Id_Habitacion.Text,
                        Cbo_Id_Empleado.Text,
                        Txt_Tipo_Mantenimiento.Text,
                        Txt_Descripcion_Mantenimiento.Text,
                        Txt_Estado.Text,
                        Txt_Fecha_inicio.Text,
                        Txt_Fecha_Fin.Text
                    );

                    MessageBox.Show("Registro actualizado correctamente.", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarMantenimientos();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }
        }

        private void Pic_Cancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void Cbo_Id_Mantenimiento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cbo_Id_Salon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cbo_Id_Habitacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cbo_Id_Empleado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Tipo_Mantenimiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Descripcion_Mantenimiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Estado_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Fecha_inicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Fecha_Fin_TextChanged(object sender, EventArgs e)
        {

        }


        void MostrarMantenimientos()
        {
            try
            {
                DataTable tabla = controlador.MostrarMantenimientos();

                Dgv_Mantenimiento_hoteleria.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar datos: " + ex.Message);
            }
        }

        void LimpiarCampos()
        {
            Cbo_Id_Mantenimiento.Text = "";
            Cbo_Id_Salon.Text = "";
            Cbo_Id_Habitacion.Text = "";
            Cbo_Id_Empleado.Text = "";
            Txt_Tipo_Mantenimiento.Clear();
            Txt_Descripcion_Mantenimiento.Clear();
            Txt_Estado.Clear();
            Txt_Fecha_inicio.Clear();
            Txt_Fecha_Fin.Clear();
        }

        private void Pic_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Cbo_Id_Mantenimiento.Text))
                {
                    MessageBox.Show("Por favor selecciona o ingresa un ID de mantenimiento para eliminar.",
                                    "Eliminar Registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "¿Estás seguro de eliminar el mantenimiento con ID " + Cbo_Id_Mantenimiento.Text + "?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    controlador.EliminarMantenimiento(Cbo_Id_Mantenimiento.Text);
                    MessageBox.Show("Registro eliminado correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarMantenimientos();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void Pic_Salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pic_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Cbo_Id_Mantenimiento.Text))
                {
                    MessageBox.Show("Por favor ingresa o selecciona un ID de mantenimiento para buscar.",
                                    "Buscar Registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataTable resultado = controlador.BuscarMantenimientoPorId(Cbo_Id_Mantenimiento.Text);

                if (resultado.Rows.Count > 0)
                {
                    DataRow fila = resultado.Rows[0];

                    Cbo_Id_Salon.Text = fila["Fk_Id_Salon"].ToString();
                    Cbo_Id_Habitacion.Text = fila["Fk_Id_Habitacion"].ToString();
                    Cbo_Id_Empleado.Text = fila["Fk_Id_Empleado"].ToString();
                    Txt_Tipo_Mantenimiento.Text = fila["Cmp_Tipo_Mantenimiento"].ToString();
                    Txt_Descripcion_Mantenimiento.Text = fila["Cmp_Descripcion_Mantenimiento"].ToString();
                    Txt_Estado.Text = fila["Cmp_Estado"].ToString();
                    Txt_Fecha_inicio.Text = fila["Cmp_Fecha_Inicio"].ToString();
                    Txt_Fecha_Fin.Text = fila["Cmp_Fecha_Fin"].ToString();
                }
                else
                {
                    MessageBox.Show("No se encontró ningún registro con ese ID.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }
    }
}
