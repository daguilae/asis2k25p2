using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_S;

namespace Capa_Vista_S
{
    public partial class Frm_Reservaciones : Form
    {
        Cls_Controlador_S controlador = new Cls_Controlador_S();
        private int iCodigoReserva = -1;

        public Frm_Reservaciones()
        {
            InitializeComponent();
            CargarCombos();
            ActualizarGrid();
        }

        private void CargarCombos()
        {
            try
            {
                DataTable huespedes = controlador.ObtenerHuespedes();
                Cbo_Huesped.DataSource = huespedes;
                Cbo_Huesped.DisplayMember = "Cmp_Nombre";
                Cbo_Huesped.ValueMember = "Pk_Id_Huesped";
                Cbo_Huesped.SelectedIndex = -1;

                DataTable salones = controlador.ObtenerSalonesDisponibles();
                Cbo_Salon.DataSource = salones;
                Cbo_Salon.DisplayMember = "Cmp_Nombre_Salon";
                Cbo_Salon.ValueMember = "Pk_Id_Salon";
                Cbo_Salon.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los combos: " + ex.Message);
            }
        }

        private void ActualizarGrid()
        {
            try
            {
                DataTable tabla = controlador.ObtenerReservasSalones();
                Dvg_Reservaciones.DataSource = tabla;

                if (Dvg_Reservaciones.Columns.Count > 0)
                {
                    Dvg_Reservaciones.Columns["Pk_Id_Reserva_Salon"].HeaderText = "ID Reserva";
                    Dvg_Reservaciones.Columns["Fk_Id_Huesped"].Visible = false;
                    Dvg_Reservaciones.Columns["Fk_Id_Salon"].Visible = false;
                    Dvg_Reservaciones.Columns["Cmp_Huesped"].HeaderText = "Huésped";
                    Dvg_Reservaciones.Columns["Cmp_Salon"].HeaderText = "Salón";
                    Dvg_Reservaciones.Columns["Cmp_Fecha_Reserva"].HeaderText = "Fecha";
                    Dvg_Reservaciones.Columns["Cmp_Hora_Inicio"].HeaderText = "Hora Inicio";
                    Dvg_Reservaciones.Columns["Cmp_Hora_Fin"].HeaderText = "Hora Fin";
                    Dvg_Reservaciones.Columns["Cmp_Cantidad_Personas"].HeaderText = "Personas";
                    Dvg_Reservaciones.Columns["Cmp_Monto_Total"].HeaderText = "Monto (Q)";
                }

                Dvg_Reservaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                Dvg_Reservaciones.MultiSelect = false;
                Dvg_Reservaciones.ReadOnly = true;
                Dvg_Reservaciones.AllowUserToAddRows = false;
                Dvg_Reservaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tabla: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            Cbo_Huesped.SelectedIndex = -1;
            Cbo_Salon.SelectedIndex = -1;
            Dtp_Fecha.Value = DateTime.Now;
            Dtp_Inicio.Value = DateTime.Now;
            Dtp_Fin.Value = DateTime.Now;
            Txt_capacidad.Clear();
            Txt_Monto.Clear();
            iCodigoReserva = -1;
        }

        private bool ValidarCampos()
        {
            if (Cbo_Huesped.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un huésped.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (Cbo_Salon.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un salón.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(Txt_capacidad.Text))
            {
                MessageBox.Show("Ingrese la cantidad de personas.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(Txt_Monto.Text))
            {
                MessageBox.Show("Ingrese el monto total.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void GuardarReserva()
        {
            try
            {
                if (!ValidarCampos()) return;

                int idHuesped = Convert.ToInt32(Cbo_Huesped.SelectedValue);
                int idSalon = Convert.ToInt32(Cbo_Salon.SelectedValue);
                DateTime fecha = Dtp_Fecha.Value;
                TimeSpan horaInicio = Dtp_Inicio.Value.TimeOfDay;
                TimeSpan horaFin = Dtp_Fin.Value.TimeOfDay;
                int capacidad = Convert.ToInt32(Txt_capacidad.Text);
                decimal monto = Convert.ToDecimal(Txt_Monto.Text);

                controlador.GuardarReservaSalon(idHuesped, idSalon, fecha, horaInicio, horaFin, capacidad, monto);
                MessageBox.Show("✅ Reservación guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ActualizarGrid();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la reserva: " + ex.Message);
            }
        }

        private void ModificarReserva()
        {
            try
            {
                if (iCodigoReserva < 0)
                {
                    MessageBox.Show("Seleccione una reservación para modificar.");
                    return;
                }

                if (!ValidarCampos())
                {
                    MessageBox.Show("Complete todos los campos antes de modificar la reserva.");
                    return;
                }

                if (Cbo_Huesped.SelectedValue == null || Cbo_Salon.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione un huésped y un salón válidos.");
                    return;
                }

                int idHuesped = Convert.ToInt32(Cbo_Huesped.SelectedValue);
                int idSalon = Convert.ToInt32(Cbo_Salon.SelectedValue);
                DateTime fecha = Dtp_Fecha.Value.Date;
                TimeSpan horaInicio = Dtp_Inicio.Value.TimeOfDay;
                TimeSpan horaFin = Dtp_Fin.Value.TimeOfDay;
                int capacidad = int.TryParse(Txt_capacidad.Text, out int cap) ? cap : 0;
                decimal monto = decimal.TryParse(Txt_Monto.Text, out decimal m) ? m : 0;

                controlador.ModificarReservaSalon(
                    iCodigoReserva, idHuesped, idSalon, fecha, horaInicio, horaFin, capacidad, monto
                );

                MessageBox.Show("✏️ Reservación modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarGrid();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar la reserva: " + ex.Message);
            }
        }

        private void EliminarReserva()
        {
            try
            {
                if (iCodigoReserva < 0)
                {
                    MessageBox.Show("Seleccione una reservación para eliminar.");
                    return;
                }

                DialogResult result = MessageBox.Show("¿Desea eliminar esta reservación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    controlador.EliminarReservaSalon(iCodigoReserva);
                    MessageBox.Show("🗑️ Reservación eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarGrid();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la reserva: " + ex.Message);
            }
        }

        // ==========================
        // EVENTOS
        // ==========================

        private void Frm_Reservaciones_Load(object sender, EventArgs e)
        {
            CargarCombos();
            ActualizarGrid();
        }
        private void Dvg_Reservaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = Dvg_Reservaciones.Rows[e.RowIndex];

                // 🔹 Asigna correctamente el código de reserva
                iCodigoReserva = Convert.ToInt32(fila.Cells["Pk_Id_Reserva_Salon"].Value);

                // 🔹 Llena los demás campos
                Cbo_Huesped.SelectedValue = fila.Cells["Fk_Id_Huesped"].Value;
                Cbo_Salon.SelectedValue = fila.Cells["Fk_Id_Salon"].Value;

                Dtp_Fecha.Value = Convert.ToDateTime(fila.Cells["Cmp_Fecha_Reserva"].Value);
                Dtp_Inicio.Value = Convert.ToDateTime(fila.Cells["Cmp_Hora_Inicio"].Value);
                Dtp_Fin.Value = Convert.ToDateTime(fila.Cells["Cmp_Hora_Fin"].Value);

                Txt_capacidad.Text = fila.Cells["Cmp_Cantidad_Personas"].Value.ToString();
                Txt_Monto.Text = fila.Cells["Cmp_Monto_Total"].Value.ToString();
            }
        }



        private void Btn_guardar_Click_1(object sender, EventArgs e)
        {
            GuardarReserva();
        }

        private void Btn_eliminar_Click_1(object sender, EventArgs e)
        {
            EliminarReserva();
        }

        private void Btn_modificar_Click_1(object sender, EventArgs e)
        {
            ModificarReserva();
        }

        private void Dvg_Reservaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void salonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Salones nuevoFormulario = new Frm_Salones();
            nuevoFormulario.Show();
        }
    }
}