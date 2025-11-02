using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;
using Capa_Controlador_Reservas_Hotel;

namespace Capa_Vista_Reservas_Hotel
{
    public partial class Frm_Modificar_Reserva : Form
    {

        private readonly Controlador_Reserva controlador = new Controlador_Reserva();
        private int iDReservaSeleccionada = 0;



        public Frm_Modificar_Reserva()
        {
            InitializeComponent();
        }

        private void Frm_Modificar_Reserva_Load(object sender, EventArgs e)
        {
            Cmb_Estado.Items.Clear();
            Cmb_Estado.Items.Add("Pendiente");
            Cmb_Estado.Items.Add("Cancelada");
            Cmb_Estado.SelectedIndex = 0;

            Txt_Tarifa.ReadOnly = true;
            Txt_Total.ReadOnly = true;

            CargarHabitaciones();

            Dgv_Reservas.DataSource = null;
            Dgv_Reservas.AutoGenerateColumns = true;
            Dgv_Reservas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv_Reservas.MultiSelect = false;
            Dgv_Reservas.ReadOnly = true;
            Dgv_Reservas.AllowUserToAddRows = false;
            Dgv_Reservas.AllowUserToDeleteRows = false;

            LimpiarDetalle();
            iDReservaSeleccionada = 0;
            Txt_Buscar_Reserva.Focus();
        }

        private void CargarHabitaciones()
        {
            try
            {
                DataTable dtHabit = controlador.ObtenerHabitaciones();
                MessageBox.Show($"Habitaciones cargadas: {dtHabit.Rows.Count}"); // 👈 Prueba rápida
                Cmb_Habitacion.DataSource = dtHabit;
                Cmb_Habitacion.DisplayMember = "Descripcion";
                Cmb_Habitacion.ValueMember = "IdHabitacion";
                Cmb_Habitacion.SelectedIndex = -1;
                Txt_Tarifa.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar habitaciones: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Txt_Buscar_Reserva_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sFiltro = Txt_Buscar_Reserva.Text.Trim();
                DataTable dt = controlador.BuscarReservas(sFiltro);

                Dgv_Reservas.Columns.Clear();
                Dgv_Reservas.DataSource = dt;

                if (dt != null)
                {
                    Dgv_Reservas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    foreach (DataGridViewColumn col in Dgv_Reservas.Columns)
                        col.SortMode = DataGridViewColumnSortMode.NotSortable;

                    if (Dgv_Reservas.Columns.Contains("Pk_Id_Huesped"))
                        Dgv_Reservas.Columns["Pk_Id_Huesped"].Visible = false;
                }

                iDReservaSeleccionada = 0;
                LimpiarDetalle(); // esta deja estado en “Pendiente/Cancelada” por defecto
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar reservas: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Btn_Recalcular_Total_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cmb_Habitacion.SelectedValue == null) return;
                if (!decimal.TryParse(Txt_Tarifa.Text, out decimal tarifa)) return;

                decimal dTotal = controlador.CalcularTotalReserva(
                    tarifa,
                    Dtp_Entrada.Value.Date,
                    Dtp_Salida.Value.Date
                );

                Txt_Total.Text = dTotal.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al recalcular total: {ex.Message}");
            }
        }

        private void LimpiarDetalle()
        {
            Cmb_Habitacion.SelectedIndex = -1;
            Txt_Tarifa.Clear();
            Dtp_Entrada.Value = DateTime.Today;
            Dtp_Salida.Value = DateTime.Today.AddDays(1);
            Num_Cantidad_Huespedes.Value = 1;
            Txt_Peticiones.Clear();

            // Fallback: si no hay selección del grid, deja un combo válido
            Cmb_Estado.Items.Clear();
            Cmb_Estado.Items.Add("Pendiente");
            Cmb_Estado.Items.Add("Cancelada");
            Cmb_Estado.SelectedIndex = 0;

            Txt_Total.Clear();
        }

        private void Dgv_Reservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Dgv_Reservas.CurrentRow == null || Dgv_Reservas.CurrentRow.DataBoundItem == null)
                return;

            try
            {
                var rowView = Dgv_Reservas.CurrentRow.DataBoundItem as DataRowView;
                if (rowView == null) return;

                // ID de la reserva
                if (!int.TryParse(rowView["Pk_Id_Reserva"]?.ToString(), out iDReservaSeleccionada))
                    iDReservaSeleccionada = 0;

                // Habitación + tarifa
                if (int.TryParse(rowView["Fk_Id_Habitacion"]?.ToString(), out int idHab))
                {
                    Cmb_Habitacion.SelectedValue = idHab;
                    Txt_Tarifa.Text = controlador.ObtenerTarifaHabitacion(idHab).ToString("F2");
                }
                else
                {
                    Cmb_Habitacion.SelectedIndex = -1;
                    Txt_Tarifa.Clear();
                }

                // Fechas
                if (DateTime.TryParse(rowView["Cmp_Fecha_Entrada"]?.ToString(), out DateTime fIn))
                    Dtp_Entrada.Value = fIn;
                else
                    Dtp_Entrada.Value = DateTime.Today;

                if (DateTime.TryParse(rowView["Cmp_Fecha_Salida"]?.ToString(), out DateTime fOut))
                    Dtp_Salida.Value = fOut;
                else
                    Dtp_Salida.Value = DateTime.Today.AddDays(1);

                // Cantidad huéspedes
                if (int.TryParse(rowView["Cmp_Num_Huespedes"]?.ToString(), out int cant))
                    Num_Cantidad_Huespedes.Value = Math.Max(1, Math.Min(cant, (int)Num_Cantidad_Huespedes.Maximum));
                else
                    Num_Cantidad_Huespedes.Value = 1;

                // Peticiones
                Txt_Peticiones.Text = rowView["Cmp_Peticiones_Especiales"]?.ToString() ?? "";

                // Estado actual de la reserva (viene de la BD)
                string estadoActual = rowView["Cmp_Estado_Reserva"]?.ToString() ?? "Pendiente";
                CargarOpcionesEstado(estadoActual); // ← aquí armamos el combo con las 2 opciones válidas

                // Total
                if (decimal.TryParse(rowView["Cmp_Total_Reserva"]?.ToString(), out decimal total))
                    Txt_Total.Text = total.ToString("F2");
                else
                    Txt_Total.Text = "0.00";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar detalle: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                iDReservaSeleccionada = 0;
            }
        }

        private void CargarOpcionesEstado(string sEstadoActual)
        {
            Cmb_Estado.Items.Clear();
            switch ((sEstadoActual ?? "").Trim())
            {
                case "Pendiente":
                    Cmb_Estado.Items.Add("Confirmada");
                    Cmb_Estado.Items.Add("Cancelada");
                    break;
                case "Confirmada":
                    Cmb_Estado.Items.Add("Pendiente");
                    Cmb_Estado.Items.Add("Cancelada");
                    break;
                case "Cancelada":
                    Cmb_Estado.Items.Add("Pendiente");
                    Cmb_Estado.Items.Add("Confirmada");
                    break;
                default:
                    // Si por alguna razón viene vacío o desconocido, deja las 3 como fallback
                    Cmb_Estado.Items.Add("Pendiente");
                    Cmb_Estado.Items.Add("Confirmada");
                    Cmb_Estado.Items.Add("Cancelada");
                    break;
            }
            if (Cmb_Estado.Items.Count > 0) Cmb_Estado.SelectedIndex = 0;
        }

        private void Btn_Guardar_Reserva_Click(object sender, EventArgs e)
        {
            try
            {
                if (iDReservaSeleccionada <= 0)
                {
                    MessageBox.Show("Seleccione una reserva del listado.", "Aviso");
                    return;
                }

                if (Cmb_Habitacion.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione una habitación.", "Aviso");
                    return;
                }

                if (Dtp_Entrada.Value.Date >= Dtp_Salida.Value.Date)
                {
                    MessageBox.Show("La fecha de entrada debe ser menor a la de salida.", "Aviso");
                    return;
                }

                if (!decimal.TryParse(Txt_Total.Text, out decimal total))
                {
                    MessageBox.Show("Calcule el total antes de actualizar.", "Aviso");
                    return;
                }

                string estado = Cmb_Estado.SelectedItem?.ToString() ?? "Pendiente";

                controlador.ActualizarReserva(
                    iDReservaSeleccionada,
                    Convert.ToInt32(Cmb_Habitacion.SelectedValue),
                    Dtp_Entrada.Value.Date,
                    Dtp_Salida.Value.Date,
                    (int)Num_Cantidad_Huespedes.Value,
                    Txt_Peticiones.Text.Trim(),
                    estado,
                    total
                );

                MessageBox.Show("Reserva actualizada correctamente.");
                Txt_Buscar_Reserva_TextChanged(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"ERROR:\n{ex}\n\nSTACK TRACE:\n{ex.StackTrace}",
                    "Debug Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        
    }
}
