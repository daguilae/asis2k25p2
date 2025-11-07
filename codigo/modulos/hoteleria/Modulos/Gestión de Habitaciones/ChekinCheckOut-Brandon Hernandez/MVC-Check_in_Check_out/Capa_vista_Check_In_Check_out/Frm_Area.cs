using System;
using System.Data;
using System.Windows.Forms;
using Capa_Controlador_Check_In_Check_Out;

namespace Capa_vista_Check_In_Check_out
{
    public partial class Frm_Area : Form
    {
        private readonly Cls_Area_Controlador Controlador = new Cls_Area_Controlador();

        public Frm_Area()
        {
            InitializeComponent();
            CargarFolios();
            CargarTiposMovimiento();
            CargarAreas();
        }


        private void CargarFolios()
        {
            try
            {
                var dt = Controlador.datObtenerFolio();
                Cbo_Folios.DataSource = dt;
                Cbo_Folios.DisplayMember = "DescripcionFolio";
                Cbo_Folios.ValueMember = "Pk_Id_Folio";

                if (dt.Rows.Count > 0)
                    Cbo_Folios.SelectedIndex = 0;
                else
                {
                    Cbo_Folios.SelectedIndex = -1;
                    MessageBox.Show(" No hay folios abiertos disponibles.\nDebe crear o abrir un folio antes de registrar áreas.",
                                    "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error al cargar folios:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarTiposMovimiento()
        {
            Cbo_Movimientos.Items.Clear();
            Cbo_Movimientos.Items.Add("Cargo");
            Cbo_Movimientos.Items.Add("Abono");
            Cbo_Movimientos.SelectedIndex = -1;
        }

        private void CargarAreas()
        {
            try
            {
                var dt = Controlador.datObtenerAreas();
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

        // ===================================================
        // === BOTÓN GUARDAR ===
        // ===================================================
        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cbo_Folios.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione un folio válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int fkFolio = Convert.ToInt32(Cbo_Folios.SelectedValue);
                string nombre = Txt_Area.Text.Trim();
                string descripcion = Txt_Descripcion.Text.Trim();
                string tipo = Cbo_Movimientos.Text.Trim();
                string montoTexto = Txt_Montos.Text.Trim();
                DateTime fecha = Dtp_Fecha.Value;

                bool ok = Controlador.bInsertarArea(fkFolio, nombre, descripcion, tipo, montoTexto, fecha);
                if (ok)
                {
                    MessageBox.Show("Área registrada exitosamente y vinculada al folio seleccionado.",
                                    "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarCampos();
                    CargarAreas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al guardar el registro:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
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

                int id = int.Parse(Txt_Idarea.Text);
                int fkFolio = Convert.ToInt32(Cbo_Folios.SelectedValue);
                string nombre = Txt_Area.Text.Trim();
                string descripcion = Txt_Descripcion.Text.Trim();
                string tipo = Cbo_Movimientos.Text.Trim();
                string montoTexto = Txt_Montos.Text.Trim();
                DateTime fecha = Dtp_Fecha.Value;

                bool ok = Controlador.bActualizarArea(id, fkFolio, nombre, descripcion, tipo, montoTexto, fecha);
                if (ok)
                {
                    MessageBox.Show("Registro de área actualizado correctamente.",
                                    "Modificación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarCampos();
                    CargarAreas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el registro:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Txt_Idarea.Text))
                {
                    MessageBox.Show("Debe seleccionar un registro para eliminar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = int.Parse(Txt_Idarea.Text);

                if (MessageBox.Show("¿Confirma eliminar el registro seleccionado?", "Confirmar eliminación",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool ok = Controlador.bEliminarArea(id);
                    if (ok)
                    {
                        MessageBox.Show("Registro eliminado correctamente.",
                                        "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        CargarAreas();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al eliminar el registro:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
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

                Txt_Idarea.Text = row["Pk_Id_Area"].ToString();
                Txt_Area.Text = Extraer(row, "Cmp_Nombre_Area");
                Txt_Descripcion.Text = Extraer(row, "Cmp_Descripcion");
                Cbo_Movimientos.Text = Extraer(row, "Cmp_Tipo_Movimiento");
                Txt_Montos.Text = Extraer(row, "Cmp_Monto");

                if (DateTime.TryParse(Extraer(row, "Cmp_Fecha_Movimiento"), out DateTime f))
                    Dtp_Fecha.Value = f;

                if (row.DataView.Table.Columns.Contains("Fk_Id_Folio"))
                    Cbo_Folios.SelectedValue = Convert.ToInt32(row["Fk_Id_Folio"]);

                MessageBox.Show($" Registro cargado correctamente:\nÁrea: {Txt_Area.Text}\nTipo: {Cbo_Movimientos.Text}\nMonto: Q{Txt_Montos.Text}",
                                "Consulta exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error al cargar la selección:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private string Extraer(DataRowView row, string col)
        {
            return row.DataView.Table.Columns.Contains(col) ? row[col]?.ToString() ?? "" : "";
        }

        private void LimpiarCampos()
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

        private void Cbo_Areas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Cbo_Areas.SelectedIndex == -1 || Cbo_Areas.SelectedValue == null)
                    return;

                DataRowView row = Cbo_Areas.SelectedItem as DataRowView;
                if (row == null)
                    return;

                // Cargar datos en los campos
                Txt_Idarea.Text = row["Pk_Id_Area"].ToString();
                Txt_Area.Text = row["Cmp_Nombre_Area"].ToString();
                Txt_Descripcion.Text = row["Cmp_Descripcion"].ToString();
                Cbo_Movimientos.Text = row["Cmp_Tipo_Movimiento"].ToString();
                Txt_Montos.Text = row["Cmp_Monto"].ToString();

                if (DateTime.TryParse(row["Cmp_Fecha_Movimiento"].ToString(), out DateTime fecha))
                    Dtp_Fecha.Value = fecha;

                if (row.DataView.Table.Columns.Contains("Fk_Id_Folio"))
                    Cbo_Folios.SelectedValue = Convert.ToInt32(row["Fk_Id_Folio"]);

                // Cambio visual opcional
                Cbo_Areas.BackColor = System.Drawing.Color.LightYellow;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos del área seleccionada:\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
