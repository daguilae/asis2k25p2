using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorProduccion;

namespace Capa_Vista_Produccion
{
    public partial class Frm_Produccion_Alacarta : Form
    {
        Cls_Controlador_Produccion controlador = new Cls_Controlador_Produccion();
        private int? idReservaSeleccionada = null; // variable interna para guardar el ID seleccionado

        public Frm_Produccion_Alacarta()
        {
            InitializeComponent();
            Dgv_Reservas.CellClick += Dgv_Reservas_CellClick;
            CargarEstadoCombo();
            CargarTabla();
        }

        // Cargar opciones en el combo Estado
        private void CargarEstadoCombo()
        {
            Cbo_Estado.Items.Clear();
            Cbo_Estado.Items.Add("1"); // Activo
            Cbo_Estado.Items.Add("0"); // Cancelado o Inactivo
            Cbo_Estado.SelectedIndex = -1;
        }

        // Cargar datos de la tabla
        private void CargarTabla()
        {
            Dgv_Reservas.DataSource = controlador.MostrarReservas();
            Dgv_Reservas.Columns["PK_Id_Reserva"].HeaderText = "ID Reserva";
            Dgv_Reservas.Columns["Fk_Id_Huessed"].HeaderText = "ID Huésped";
            Dgv_Reservas.Columns["Fk_Id_Habitacion"].HeaderText = "ID Habitación";
            Dgv_Reservas.Columns["Fk_Id_Salon"].HeaderText = "ID Salón";
            Dgv_Reservas.Columns["Cmp_Fecha_Reserva"].HeaderText = "Fecha";
            Dgv_Reservas.Columns["Cmp_Hora_reserva"].HeaderText = "Hora";
            Dgv_Reservas.Columns["Cmp_Numero_Comensales"].HeaderText = "Comensales";
            Dgv_Reservas.Columns["Cmp_Estado"].HeaderText = "Estado";
        }

        // GUARDAR nueva reserva
        private void Btn_Guardar_Reserva_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(Txt_Id_Huesped.Text, out int idHuesped) ||
                !int.TryParse(Txt_Id_Habitacion.Text, out int idHabitacion) ||
                !int.TryParse(Txt_Id_Salon.Text, out int idSalon) ||
                !int.TryParse(Txt_Cantidad.Text, out int numComensales) ||
                Cbo_Estado.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor complete todos los campos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime fecha = Dtp_Fecha_Reserva.Value;
            TimeSpan hora = Dtp_Hora_Reserva.Value.TimeOfDay;
            int estado = Convert.ToInt32(Cbo_Estado.SelectedItem);

            controlador.GuardarReserva(idHuesped, idHabitacion, idSalon, fecha, hora, numComensales, estado);

            MessageBox.Show("Reserva guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCampos();
            CargarTabla();
        }

        // EDITAR reserva existente
        private void Btn_editar_reserva_Click(object sender, EventArgs e)
        {
            if (idReservaSeleccionada == null)
            {
                MessageBox.Show("Seleccione una reserva para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(Txt_Id_Huesped.Text, out int idHuesped) ||
                !int.TryParse(Txt_Id_Habitacion.Text, out int idHabitacion) ||
                !int.TryParse(Txt_Id_Salon.Text, out int idSalon) ||
                !int.TryParse(Txt_Cantidad.Text, out int numComensales) ||
                Cbo_Estado.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor complete todos los campos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime fecha = Dtp_Fecha_Reserva.Value;
            TimeSpan hora = Dtp_Hora_Reserva.Value.TimeOfDay;
            int estado = Convert.ToInt32(Cbo_Estado.SelectedItem);

            controlador.ActualizarReserva(idReservaSeleccionada.Value, idHuesped, idHabitacion, idSalon, fecha, hora, numComensales, estado);

            MessageBox.Show("Reserva actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCampos();
            CargarTabla();
        }

        // ELIMINAR reserva
        private void Btn_eliminar_Reserva_Click(object sender, EventArgs e)
        {
            if (idReservaSeleccionada == null)
            {
                MessageBox.Show("Seleccione una reserva para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("¿Seguro que desea eliminar esta reserva?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                controlador.EliminarReserva(idReservaSeleccionada.Value);
                MessageBox.Show("Reserva eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarTabla();
            }
        }

        // Cargar datos al seleccionar una fila
        private void Dgv_Reservas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && Dgv_Reservas.Rows[e.RowIndex].Cells["PK_Id_Reserva"].Value != null)
            {
                idReservaSeleccionada = Convert.ToInt32(Dgv_Reservas.Rows[e.RowIndex].Cells["PK_Id_Reserva"].Value);
                Txt_Id_Huesped.Text = Dgv_Reservas.Rows[e.RowIndex].Cells["Fk_Id_Huessed"].Value.ToString();
                Txt_Id_Habitacion.Text = Dgv_Reservas.Rows[e.RowIndex].Cells["Fk_Id_Habitacion"].Value.ToString();
                Txt_Id_Salon.Text = Dgv_Reservas.Rows[e.RowIndex].Cells["Fk_Id_Salon"].Value.ToString();
                Dtp_Fecha_Reserva.Value = Convert.ToDateTime(Dgv_Reservas.Rows[e.RowIndex].Cells["Cmp_Fecha_Reserva"].Value);
                Dtp_Hora_Reserva.Value = DateTime.Today.Add((TimeSpan)Dgv_Reservas.Rows[e.RowIndex].Cells["Cmp_Hora_reserva"].Value);
                Txt_Cantidad.Text = Dgv_Reservas.Rows[e.RowIndex].Cells["Cmp_Numero_Comensales"].Value.ToString();
                Cbo_Estado.SelectedItem = Dgv_Reservas.Rows[e.RowIndex].Cells["Cmp_Estado"].Value.ToString();
            }
        }

        // Limpiar los campos
        private void LimpiarCampos()
        {
            idReservaSeleccionada = null;
            Txt_Id_Huesped.Text = "";
            Txt_Id_Habitacion.Text = "";
            Txt_Id_Salon.Text = "";
            Txt_Cantidad.Text = "";
            Dtp_Fecha_Reserva.Value = DateTime.Now;
            Dtp_Hora_Reserva.Value = DateTime.Now;
            Cbo_Estado.SelectedIndex = -1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

