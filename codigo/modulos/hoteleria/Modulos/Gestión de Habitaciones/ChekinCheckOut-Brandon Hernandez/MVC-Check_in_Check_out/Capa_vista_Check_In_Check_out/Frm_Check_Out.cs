using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Capa_Controlador_Check_In_Check_Out;

namespace Capa_vista_Check_In_Check_out
{
    public partial class Frm_Check_Out : Form
    {
        private readonly Cls_Check_Out_Controlador Controlador = new Cls_Check_Out_Controlador();

        public Frm_Check_Out()
        {
            InitializeComponent();
            fun_CargarCombos();
            fun_CargarDatos();
            ConfigurarDataGrid();
        }

        private void ConfigurarDataGrid()
        {
            Dgv_Check_Out.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Check_Out.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv_Check_Out.MultiSelect = false;
            Dgv_Check_Out.ReadOnly = true;
        }

        private void LimpiarCampos()
        {
            Txt_Check_out.Clear();
            Cbo_Huesped.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.White;
            Cbo_Huesped.BackColor = System.Drawing.Color.White;
        }


        private void fun_CargarCombos()
        {
            try
            {
                DataTable dt = Controlador.datObtenerCheckIn();

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
                Dgv_Check_Out.DataSource = Controlador.MostrarCheckOut();
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
            LimpiarCampos();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cbo_Huesped.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar un Check-In válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Cbo_Huesped.BackColor = System.Drawing.Color.MistyRose;
                    return;
                }

                int idCheckIn = Convert.ToInt32(Cbo_Huesped.SelectedValue);
                DateTime fechaCheckOut = dateTimePicker1.Value;


                DataRowView filaSeleccionada = Cbo_Huesped.SelectedItem as DataRowView;
                DateTime fechaCheckIn = DateTime.MinValue;
                if (filaSeleccionada != null && filaSeleccionada.Row.Table.Columns.Contains("Cmp_Fecha_Check_In"))
                    fechaCheckIn = Convert.ToDateTime(filaSeleccionada["Cmp_Fecha_Check_In"]);

                // ✅ Validación visual
                if (fechaCheckOut < fechaCheckIn)
                {
                    dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.MistyRose;
                    MessageBox.Show(
                        $"⚠️ La fecha de Check-Out ({fechaCheckOut:dd/MM/yyyy}) no puede ser anterior al Check-In ({fechaCheckIn:dd/MM/yyyy}).",
                        "Fecha inválida",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }
                else
                {
                    dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.White;
                }


                bool exito = Controlador.RegistrarCheckOutConFolio(idCheckIn, fechaCheckOut);

                if (exito)
                {
                    fun_CargarDatos();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar Check-Out: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Txt_Check_out.Text))
                {
                    MessageBox.Show("Seleccione un registro para modificar.");
                    return;
                }

                if (Cbo_Huesped.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar un Check-In válido.");
                    return;
                }

                int idCheckOut = Convert.ToInt32(Txt_Check_out.Text);
                int idCheckIn = Convert.ToInt32(Cbo_Huesped.SelectedValue);
                DateTime fechaCheckOut = dateTimePicker1.Value;

      
                if (Controlador.bActualizarCheckOut(idCheckOut, idCheckIn, fechaCheckOut, out string mensaje))
                {
                    MessageBox.Show("✅ " + mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fun_CargarDatos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("⚠️ " + mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar Check-Out: " + ex.Message);
            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Txt_Check_out.Text))
                {
                    MessageBox.Show("Seleccione un registro para eliminar.");
                    return;
                }

                int idCheckOut = Convert.ToInt32(Txt_Check_out.Text);
                if (Controlador.bBorrarCheckOut(idCheckOut, out string mensajeError))
                {
                    MessageBox.Show("🗑️ Check-Out eliminado correctamente.");
                    fun_CargarDatos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("⚠️ " + mensajeError);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar Check-Out: " + ex.Message);
            }
        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Dgv_Check_Out_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    Txt_Check_out.Text = Dgv_Check_Out.Rows[e.RowIndex].Cells["Pk_Id_Check_out"].Value.ToString();

                    // 🔹 Verificar que el Combo esté cargado
                    if (Cbo_Huesped.DataSource == null)
                        fun_CargarCombos();

                    // 🔹 Buscar la columna que contiene el ID del Check-In
                    var colCheckIn = Dgv_Check_Out.Columns.Cast<DataGridViewColumn>()
                        .FirstOrDefault(c => c.Name.ToLower().Contains("check_in"));

                    if (colCheckIn != null)
                    {
                        object valor = Dgv_Check_Out.Rows[e.RowIndex].Cells[colCheckIn.Name].Value;
                        if (valor != null && int.TryParse(valor.ToString(), out int idCheckIn))
                        {
                            var dataSource = (Cbo_Huesped.DataSource as DataTable);
                            bool existe = dataSource.AsEnumerable()
                                .Any(r => Convert.ToInt32(r["Pk_Id_Check_in"]) == idCheckIn);

                            if (existe)
                            {
                                Cbo_Huesped.SelectedValue = idCheckIn;
                            }
                            else
                            {
                        
                                DataRow newRow = dataSource.NewRow();
                                newRow["Pk_Id_Check_in"] = idCheckIn;
                                newRow["Nombre_Huesped"] = Dgv_Check_Out.Rows[e.RowIndex].Cells["Nombre_Huesped"].Value.ToString();
                                newRow["Cmp_Fecha_Check_In"] = Dgv_Check_Out.Rows[e.RowIndex].Cells["Cmp_Fecha_Check_In"].Value;
                                newRow["Descripcion_Combo"] = $"#{idCheckIn} – {newRow["Nombre_Huesped"]} – {Convert.ToDateTime(newRow["Cmp_Fecha_Check_In"]).ToString("dd/MM/yyyy")}";
                                dataSource.Rows.Add(newRow);
                                Cbo_Huesped.SelectedValue = idCheckIn;
                            }
                        }
                    }

                    dateTimePicker1.Value = Convert.ToDateTime(Dgv_Check_Out.Rows[e.RowIndex].Cells["Cmp_Fecha_Check_Out"].Value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos del registro: " + ex.Message);
                }
            }
        }
    }
}
