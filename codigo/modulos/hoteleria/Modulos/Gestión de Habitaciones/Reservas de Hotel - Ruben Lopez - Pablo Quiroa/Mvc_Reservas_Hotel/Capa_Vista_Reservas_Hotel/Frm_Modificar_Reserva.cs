using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Capa_Controlador_Reservas_Hotel;

namespace Capa_Vista_Reservas_Hotel
{
    public partial class Frm_Modificar_Reserva : Form
    {
        private readonly Controlador_Reserva controlador = new Controlador_Reserva();
        private int iDReservaSeleccionada = 0;

        // === necesarios para puntos de huésped ===
        private string sEtadoAnterior = "Pendiente";
        private int iIdHuespedActual = 0;

        // ====== VARIABLES PARA BLOQUEO VISUAL DE FECHAS ======
        private Panel popupPanel;
        private MonthCalendar mc;
        private HashSet<DateTime> _fechasOcupadas = new HashSet<DateTime>();
        private enum PickerObjetivo { Ninguno, Entrada, Salida }
        private PickerObjetivo _objetivoActual = PickerObjetivo.Ninguno;

        // ====== RANGO ACTUAL DE LA RESERVA (PARA EXCLUSIÓN) ======
        private DateTime? _rangoActualInicio = null;
        private DateTime? _rangoActualFin = null; // [inicio, fin)

        public Frm_Modificar_Reserva()
        {
            InitializeComponent();
        }

        private void Frm_Modificar_Reserva_Load(object sender, EventArgs e)
        {
            InicializarPopupCalendario();

            Cmb_Estado.Items.Clear();
            Cmb_Estado.Items.Add("Pendiente");
            Cmb_Estado.Items.Add("Confirmada");
            Cmb_Estado.Items.Add("Cancelada");
            Cmb_Estado.SelectedIndex = 0;

            Txt_Tarifa.ReadOnly = true;
            Txt_Total.ReadOnly = true;
            Txt_Capacidad_Mod.ReadOnly = true;

            CargarHabitaciones();

            Dgv_Reservas.DataSource = null;
            Dgv_Reservas.AutoGenerateColumns = true;
            Dgv_Reservas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv_Reservas.MultiSelect = false;
            Dgv_Reservas.ReadOnly = true;
            Dgv_Reservas.AllowUserToAddRows = false;
            Dgv_Reservas.AllowUserToDeleteRows = false;

            Dtp_Entrada.MouseDown += (s, ev) =>
            {
                _objetivoActual = PickerObjetivo.Entrada;
                MostrarPopupCalendarioCercaDe(Dtp_Entrada);
            };
            Dtp_Salida.MouseDown += (s, ev) =>
            {
                _objetivoActual = PickerObjetivo.Salida;
                MostrarPopupCalendarioCercaDe(Dtp_Salida);
            };

            LimpiarDetalle();
            iDReservaSeleccionada = 0;
            Txt_Buscar_Reserva.Focus();
        }

        private void CargarHabitaciones()
        {
            try
            {
                DataTable dtHabit = controlador.ObtenerHabitaciones();
                Cmb_Habitacion.DataSource = dtHabit;
                Cmb_Habitacion.DisplayMember = "Descripcion";
                Cmb_Habitacion.ValueMember = "IdHabitacion";
                Cmb_Habitacion.SelectedIndex = -1;

                Cmb_Habitacion.SelectedIndexChanged -= Cmb_Habitacion_SelectedIndexChanged;
                Cmb_Habitacion.SelectedIndexChanged += Cmb_Habitacion_SelectedIndexChanged;

                Txt_Tarifa.Text = string.Empty;
                Txt_Capacidad_Mod.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar habitaciones: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cmb_Habitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_Habitacion.SelectedValue == null) return;

            if (int.TryParse(Cmb_Habitacion.SelectedValue.ToString(), out int idHab))
            {
                Txt_Tarifa.Text = controlador.ObtenerTarifaHabitacion(idHab).ToString("F2");
                Txt_Capacidad_Mod.Text = controlador.ObtenerCapacidadHabitacion(idHab).ToString();

                CargarFechasOcupadas(idHab, _rangoActualInicio, _rangoActualFin);
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
                iIdHuespedActual = 0;
                sEtadoAnterior = "Pendiente";
                LimpiarDetalle();
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
            Txt_Capacidad_Mod.Clear();
            Dtp_Entrada.Value = DateTime.Today;
            Dtp_Salida.Value = DateTime.Today.AddDays(1);
            Txt_Peticiones.Clear();

            Cmb_Estado.Items.Clear();
            Cmb_Estado.Items.Add("Pendiente");
            Cmb_Estado.Items.Add("Confirmada");
            Cmb_Estado.Items.Add("Cancelada");
            Cmb_Estado.SelectedIndex = 0;

            Txt_Total.Clear();

            _rangoActualInicio = null;
            _rangoActualFin = null;
            _fechasOcupadas = new HashSet<DateTime>();

            DesbloquearModificacion();
        }

        private void Dgv_Reservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Dgv_Reservas.CurrentRow == null || Dgv_Reservas.CurrentRow.DataBoundItem == null)
                return;

            try
            {
                var rowView = Dgv_Reservas.CurrentRow.DataBoundItem as DataRowView;
                if (rowView == null) return;

                if (!int.TryParse(rowView["Pk_Id_Reserva"]?.ToString(), out iDReservaSeleccionada))
                    iDReservaSeleccionada = 0;

                iIdHuespedActual = 0;
                if (rowView.DataView.Table.Columns.Contains("Pk_Id_Huesped"))
                    int.TryParse(rowView["Pk_Id_Huesped"]?.ToString(), out iIdHuespedActual);

                int idHab = -1;
                if (int.TryParse(rowView["Fk_Id_Habitacion"]?.ToString(), out idHab))
                {
                    Cmb_Habitacion.SelectedValue = idHab;
                    Txt_Tarifa.Text = controlador.ObtenerTarifaHabitacion(idHab).ToString("F2");
                    Txt_Capacidad_Mod.Text = controlador.ObtenerCapacidadHabitacion(idHab).ToString();
                }
                else
                {
                    Cmb_Habitacion.SelectedIndex = -1;
                    Txt_Tarifa.Clear();
                    Txt_Capacidad_Mod.Clear();
                }

                DateTime fIn = DateTime.Today;
                DateTime fOut = DateTime.Today.AddDays(1);

                if (DateTime.TryParse(rowView["Cmp_Fecha_Entrada"]?.ToString(), out DateTime tmpIn)) fIn = tmpIn;
                if (DateTime.TryParse(rowView["Cmp_Fecha_Salida"]?.ToString(), out DateTime tmpOut)) fOut = tmpOut;

                Dtp_Entrada.Value = fIn;
                Dtp_Salida.Value = fOut;

                _rangoActualInicio = fIn.Date;
                _rangoActualFin = fOut.Date;

                Txt_Peticiones.Text = rowView["Cmp_Peticiones_Especiales"]?.ToString() ?? "";

                string sEstadoActual = rowView["Cmp_Estado_Reserva"]?.ToString() ?? "Pendiente";
                sEtadoAnterior = sEstadoActual;
                CargarOpcionesEstado(sEstadoActual);

                if (decimal.TryParse(rowView["Cmp_Total_Reserva"]?.ToString(), out decimal total))
                    Txt_Total.Text = total.ToString("F2");
                else
                    Txt_Total.Text = "0.00";

                if (idHab > 0)
                    CargarFechasOcupadas(idHab, _rangoActualInicio, _rangoActualFin);

                if (sEstadoActual.Equals("Finalizada", StringComparison.OrdinalIgnoreCase))
                    BloquearModificacion();
                else
                    DesbloquearModificacion();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar detalle: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                iDReservaSeleccionada = 0;
                iIdHuespedActual = 0;
                sEtadoAnterior = "Pendiente";
            }
        }

        private void CargarOpcionesEstado(string estadoActual)
        {
            Cmb_Estado.Items.Clear();
            Cmb_Estado.Items.Add("Pendiente");
            Cmb_Estado.Items.Add("Confirmada");
            Cmb_Estado.Items.Add("Cancelada");

            int iIndex = Cmb_Estado.Items.IndexOf(estadoActual);
            Cmb_Estado.SelectedIndex = (iIndex >= 0) ? iIndex : 0;
        }

        private void BloquearModificacion()
        {
            Cmb_Habitacion.Enabled = false;
            Dtp_Entrada.Enabled = false;
            Dtp_Salida.Enabled = false;
            Txt_Peticiones.ReadOnly = true;
            Cmb_Estado.Enabled = false;
            Btn_Recalcular_Total.Enabled = false;
            Btn_Guardar_Reserva.Enabled = false;
        }

        private void DesbloquearModificacion()
        {
            Cmb_Habitacion.Enabled = true;
            Dtp_Entrada.Enabled = true;
            Dtp_Salida.Enabled = true;
            Txt_Peticiones.ReadOnly = false;
            Cmb_Estado.Enabled = true;
            Btn_Recalcular_Total.Enabled = true;
            Btn_Guardar_Reserva.Enabled = true;
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

                string sEstadoNuevo = Cmb_Estado.SelectedItem?.ToString() ?? "Pendiente";

                if (iIdHuespedActual <= 0)
                {
                    MessageBox.Show("No se pudo determinar el huésped de la reserva. Seleccione nuevamente la fila.", "Aviso");
                    return;
                }

                controlador.ActualizarReserva(
                    iDReservaSeleccionada,
                    Convert.ToInt32(Cmb_Habitacion.SelectedValue),
                    Dtp_Entrada.Value.Date,
                    Dtp_Salida.Value.Date,
                    Txt_Peticiones.Text.Trim(),
                    sEstadoNuevo,
                    total,
                    sEtadoAnterior,
                    iIdHuespedActual
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

        private void InicializarPopupCalendario()
        {
            popupPanel = new Panel
            {
                Visible = false,
                BorderStyle = BorderStyle.FixedSingle,
                Width = 250,
                Height = 190
            };
            mc = new MonthCalendar
            {
                MaxSelectionCount = 1,
                Dock = DockStyle.Fill,
            };

            mc.DateSelected += Mc_DateSelected;
            mc.DateChanged += Mc_DateChangedBloquearVisual;

            popupPanel.Controls.Add(mc);
            this.Controls.Add(popupPanel);

            mc.Leave += (s, e) => popupPanel.Visible = false;
            popupPanel.Leave += (s, e) => popupPanel.Visible = false;
        }

        private void MostrarPopupCalendarioCercaDe(Control ancla)
        {
            if (popupPanel == null || mc == null) return;

            var p = ancla.PointToScreen(new System.Drawing.Point(0, ancla.Height));
            p = this.PointToClient(p);
            popupPanel.Location = p;

            mc.RemoveAllBoldedDates();
            foreach (var d in _fechasOcupadas)
                mc.AddBoldedDate(d);
            mc.UpdateBoldedDates();

            DateTime baseDate = (_objetivoActual == PickerObjetivo.Entrada)
                                ? Dtp_Entrada.Value.Date
                                : Dtp_Salida.Value.Date;

            mc.SetDate(baseDate);

            popupPanel.BringToFront();
            popupPanel.Visible = true;
            mc.Focus();
        }

        private void Mc_DateChangedBloquearVisual(object sender, DateRangeEventArgs e)
        {
            if (_fechasOcupadas == null || _fechasOcupadas.Count == 0) return;

            DateTime seleccionado = e.Start.Date;
            if (_fechasOcupadas.Contains(seleccionado))
            {
                DateTime fallback = (_objetivoActual == PickerObjetivo.Entrada)
                                    ? Dtp_Entrada.Value.Date
                                    : Dtp_Salida.Value.Date;

                if (_fechasOcupadas.Contains(fallback))
                    fallback = DateTime.Today;

                mc.SetDate(fallback);
            }
        }

        private void Mc_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime seleccionado = e.Start.Date;
            if (_fechasOcupadas.Contains(seleccionado))
                return;

            if (_objetivoActual == PickerObjetivo.Entrada)
                Dtp_Entrada.Value = seleccionado;
            else if (_objetivoActual == PickerObjetivo.Salida)
                Dtp_Salida.Value = seleccionado;

            popupPanel.Visible = false;
            _objetivoActual = PickerObjetivo.Ninguno;
        }

        private void CargarFechasOcupadas(int iIdHabitacion, DateTime? excluirInicio, DateTime? excluirFin)
        {
            try
            {
                _fechasOcupadas = controlador.ExpandirFechasOcupadas(iIdHabitacion) ?? new HashSet<DateTime>();

                if (excluirInicio.HasValue && excluirFin.HasValue)
                {
                    for (DateTime d = excluirInicio.Value.Date; d < excluirFin.Value.Date; d = d.AddDays(1))
                        _fechasOcupadas.Remove(d);
                }

                if (popupPanel != null && mc != null && popupPanel.Visible)
                {
                    mc.RemoveAllBoldedDates();
                    foreach (var d in _fechasOcupadas)
                        mc.AddBoldedDate(d);
                    mc.UpdateBoldedDates();
                }
            }
            catch
            {
                _fechasOcupadas = new HashSet<DateTime>();
            }
        }
    }
}
