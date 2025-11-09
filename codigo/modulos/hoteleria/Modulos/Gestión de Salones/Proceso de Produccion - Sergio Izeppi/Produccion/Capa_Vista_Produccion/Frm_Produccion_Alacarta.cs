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
            CargarSalones();
            CargarTabla();
        }

        private void CargarEstadoCombo()
        {
            var estados = new List<KeyValuePair<int, string>>()
    {
        new KeyValuePair<int, string>(1, "Activa"),
        new KeyValuePair<int, string>(0, "Cancelada")
    };

            Cbo_Estado.DataSource = estados;
            Cbo_Estado.DisplayMember = "Value";  // lo que se muestra al usuario
            Cbo_Estado.ValueMember = "Key";      // el valor real que se guarda en BD
            Cbo_Estado.SelectedIndex = -1;
        }

        // Cargar datos de la tabla
        /* private void CargarTabla()
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
         }*/

        private void CargarTabla()
        {
            Dgv_Reservas.DataSource = controlador.MostrarReservas();

            if (Dgv_Reservas.Columns.Contains("PK_Id_Reserva"))
                Dgv_Reservas.Columns["PK_Id_Reserva"].HeaderText = "ID Reserva";

            if (Dgv_Reservas.Columns.Contains("Fk_Id_Huessed"))
                Dgv_Reservas.Columns["Fk_Id_Huessed"].HeaderText = "ID Huésped";

            if (Dgv_Reservas.Columns.Contains("Fk_Id_Habitacion"))
                Dgv_Reservas.Columns["Fk_Id_Habitacion"].HeaderText = "ID Habitación";

            if (Dgv_Reservas.Columns.Contains("SalonNombre"))
                Dgv_Reservas.Columns["SalonNombre"].HeaderText = "Salón";

            if (Dgv_Reservas.Columns.Contains("Cmp_Fecha_Reserva"))
                Dgv_Reservas.Columns["Cmp_Fecha_Reserva"].HeaderText = "Fecha";

            if (Dgv_Reservas.Columns.Contains("Cmp_Hora_reserva"))
                Dgv_Reservas.Columns["Cmp_Hora_reserva"].HeaderText = "Hora";

            if (Dgv_Reservas.Columns.Contains("Cmp_Numero_Comensales"))
                Dgv_Reservas.Columns["Cmp_Numero_Comensales"].HeaderText = "Comensales";

            if (Dgv_Reservas.Columns.Contains("Cmp_Estado"))
                Dgv_Reservas.Columns["Cmp_Estado"].HeaderText = "Estado";
        }


        // GUARDAR nueva reserva
        private void Btn_Guardar_Reserva_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(Txt_Id_Huesped.Text, out int iHuesped) ||
                !int.TryParse(Txt_Id_Habitacion.Text, out int iHabitacion) ||
                !int.TryParse(Txt_Cantidad.Text, out int iNumComensales) ||
                Cbo_Estado.SelectedIndex == -1 ||
                Cbo_Salon.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor complete todos los campos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int iSalon = Convert.ToInt32(Cbo_Salon.SelectedValue);
            DateTime fecha = Dtp_Fecha_Reserva.Value;
            TimeSpan hora = Dtp_Hora_Reserva.Value.TimeOfDay;
            int estado = Convert.ToInt32(Cbo_Estado.SelectedValue);

            controlador.GuardarReserva(iHuesped, iHabitacion, iSalon, fecha, hora, iNumComensales, estado);

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
                !int.TryParse(Txt_Cantidad.Text, out int numComensales) ||
                Cbo_Estado.SelectedIndex == -1 ||
                Cbo_Salon.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor complete todos los campos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idSalon = Convert.ToInt32(Cbo_Salon.SelectedValue);
            DateTime fecha = Dtp_Fecha_Reserva.Value;
            TimeSpan hora = Dtp_Hora_Reserva.Value.TimeOfDay;
            int estado = Convert.ToInt32(Cbo_Estado.SelectedValue);

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
        /* private void Dgv_Reservas_CellClick(object sender, DataGridViewCellEventArgs e)
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
                 string estadoTexto = Dgv_Reservas.Rows[e.RowIndex].Cells["Cmp_Estado"].Value.ToString();
                 if (estadoTexto == "Activa")
                     Cbo_Estado.SelectedValue = 1;
                 else if (estadoTexto == "Cancelada")
                     Cbo_Estado.SelectedValue = 0;
                 else
                     Cbo_Estado.SelectedIndex = -1;
             }
         }*/

        private void Dgv_Reservas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = Dgv_Reservas.Rows[e.RowIndex];

            if (row.Cells["PK_Id_Reserva"].Value == null) return;

            idReservaSeleccionada = Convert.ToInt32(row.Cells["PK_Id_Reserva"].Value);

            Txt_Id_Huesped.Text = row.Cells["Fk_Id_Huessed"].Value.ToString();
            Txt_Id_Habitacion.Text = row.Cells["Fk_Id_Habitacion"].Value.ToString();

            // Para el combo de salón
            if (row.Cells["Fk_Id_Salon"].Value != DBNull.Value &&
                int.TryParse(row.Cells["Fk_Id_Salon"].Value.ToString(), out int idSalon))
            {
                Cbo_Salon.SelectedValue = idSalon;
            }
            else
            {
                Cbo_Salon.SelectedIndex = -1;
            }

            Dtp_Fecha_Reserva.Value = Convert.ToDateTime(row.Cells["Cmp_Fecha_Reserva"].Value);
            Dtp_Hora_Reserva.Value = DateTime.Today.Add((TimeSpan)row.Cells["Cmp_Hora_reserva"].Value);
            Txt_Cantidad.Text = row.Cells["Cmp_Numero_Comensales"].Value.ToString();

            string estadoTexto = row.Cells["Cmp_Estado"].Value.ToString();
            if (estadoTexto == "Activa")
                Cbo_Estado.SelectedValue = 1;
            else if (estadoTexto == "Cancelada")
                Cbo_Estado.SelectedValue = 0;
            else
                Cbo_Estado.SelectedIndex = -1;
        }



        // Limpiar los campos
        /*private void LimpiarCampos()
        {
            idReservaSeleccionada = null;
            Txt_Id_Huesped.Text = "";
            Txt_Id_Habitacion.Text = "";
            Cbo_Salon.SelectedIndex = -1;
            Txt_Cantidad.Text = "";
            Dtp_Fecha_Reserva.Value = DateTime.Now;
            Dtp_Hora_Reserva.Value = DateTime.Now;
            Cbo_Estado.SelectedIndex = -1;
        }*/

        private void LimpiarCampos()
        {
            idReservaSeleccionada = null;
            Txt_Id_Huesped.Text = "";
            Txt_Id_Habitacion.Text = "";
            // quitar Txt_Id_Salon si lo vas a eliminar
            Cbo_Salon.SelectedIndex = -1;
            Txt_Cantidad.Text = "";
            Dtp_Fecha_Reserva.Value = DateTime.Now;
            Dtp_Hora_Reserva.Value = DateTime.Now;
            Cbo_Estado.SelectedIndex = -1;
        }


        private void CargarSalones()
        {
            DataTable salones = controlador.ObtenerSalones();

            if (salones != null && salones.Rows.Count > 0)
            {
                Cbo_Salon.DataSource = salones;
                Cbo_Salon.DisplayMember = "Cmp_Nombre_Salon"; // lo que se muestra al usuario
                Cbo_Salon.ValueMember = "Pk_Id_Salon";        // el valor interno
                Cbo_Salon.SelectedIndex = -1;                 // ninguno seleccionado al inicio
            }
            else
            {
                MessageBox.Show("No se encontraron salones disponibles.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Reporte_Click(object sender, EventArgs e)
        {
            Frm_Reportes_Alacarta frm = new Frm_Reportes_Alacarta();
            frm.Show();
        }
    }
}

