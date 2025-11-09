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
        Cls_Controlador_S cControlador = new Cls_Controlador_S();
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
                DataTable dtHuespedes = cControlador.ObtenerHuespedes();
                Cbo_Huesped.DataSource = dtHuespedes;
                Cbo_Huesped.DisplayMember = "Cmp_Nombre";
                Cbo_Huesped.ValueMember = "Pk_Id_Huesped";
                Cbo_Huesped.SelectedIndex = -1;

                DataTable dtSalones = cControlador.ObtenerSalonesDisponibles();
                Cbo_Salon.DataSource = dtSalones;
                Cbo_Salon.DisplayMember = "Cmp_Nombre_Salon";
                Cbo_Salon.ValueMember = "Pk_Id_Salon";
                Cbo_Salon.SelectedIndex = -1;

                DataTable dtPromociones = cControlador.ObtenerPromociones();
                Cbo_Promocion.DataSource = dtPromociones;
                Cbo_Promocion.DisplayMember = "Cmp_Nombre_Promocion";
                Cbo_Promocion.ValueMember = "Pk_Id_Promociones";
                Cbo_Promocion.SelectedIndex = -1;
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
                DataTable dtTabla = cControlador.ObtenerReservasSalones();
                Dvg_Reservaciones.DataSource = dtTabla;

                if (Dvg_Reservaciones.Columns.Count > 0)
                {
                    Dvg_Reservaciones.Columns["Pk_Id_Reserva_Salon"].HeaderText = "ID Reserva";
                    Dvg_Reservaciones.Columns["Fk_Id_Huesped"].Visible = false;
                    Dvg_Reservaciones.Columns["Fk_Id_Salon"].Visible = false;

                    if (Dvg_Reservaciones.Columns.Contains("Fk_Id_Promociones"))
                        Dvg_Reservaciones.Columns["Fk_Id_Promociones"].Visible = false;

                    Dvg_Reservaciones.Columns["Cmp_Huesped"].HeaderText = "Huésped";
                    Dvg_Reservaciones.Columns["Cmp_Salon"].HeaderText = "Salón";
                    Dvg_Reservaciones.Columns["Cmp_Fecha_Reserva"].HeaderText = "Fecha Reserva";
                    Dvg_Reservaciones.Columns["Cmp_Hora_Inicio"].HeaderText = "Hora Inicio";
                    Dvg_Reservaciones.Columns["Cmp_Hora_Fin"].HeaderText = "Hora Fin";
                    Dvg_Reservaciones.Columns["Cmp_Cantidad_Personas"].HeaderText = "Personas";
                    Dvg_Reservaciones.Columns["Cmp_Monto_Total"].HeaderText = "Monto (Q)";

                    if (Dvg_Reservaciones.Columns.Contains("Cmp_Promocion"))
                        Dvg_Reservaciones.Columns["Cmp_Promocion"].HeaderText = "Promoción";

                    if (Dvg_Reservaciones.Columns.Contains("Cmp_Fecha_Pago"))
                        Dvg_Reservaciones.Columns["Cmp_Fecha_Pago"].HeaderText = "Fecha Pago";

                    if (Dvg_Reservaciones.Columns.Contains("Cmp_Pago_Total"))
                        Dvg_Reservaciones.Columns["Cmp_Pago_Total"].HeaderText = "Pago Total (Q)";

                    if (Dvg_Reservaciones.Columns.Contains("Cmp_Estado"))
                        Dvg_Reservaciones.Columns["Cmp_Estado"].HeaderText = "Estado del Pago";

                    if (Dvg_Reservaciones.Columns.Contains("Cmp_Metodo_Pago"))
                        Dvg_Reservaciones.Columns["Cmp_Metodo_Pago"].HeaderText = "Método de Pago";
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
            if (Cbo_Promocion != null)
                Cbo_Promocion.SelectedIndex = -1;

            Dtp_Fecha.Value = DateTime.Now;
            Dtp_Inicio.Value = DateTime.Now;
            Dtp_Fin.Value = DateTime.Now;
            Txt_capacidad.Clear();
            Txt_Monto.Clear();

            if (Dtp_FechaPago != null)
                Dtp_FechaPago.Value = DateTime.Now;

            if (Txt_PagoTotal != null)
                Txt_PagoTotal.Clear();

            if (Txt_Estadopago != null)
                Txt_Estadopago.Clear();

            if (Txt_MetodoPago != null)
                Txt_MetodoPago.Clear();

            iCodigoReserva = -1;
        }

        private bool bValidarCampos()
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
                if (!bValidarCampos()) return;

                int iIdHuesped = Convert.ToInt32(Cbo_Huesped.SelectedValue);
                int iIdSalon = Convert.ToInt32(Cbo_Salon.SelectedValue);
                DateTime dFecha = Dtp_Fecha.Value;
                TimeSpan dHoraInicio = Dtp_Inicio.Value.TimeOfDay;
                TimeSpan dHoraFin = Dtp_Fin.Value.TimeOfDay;
                int iCapacidad = Convert.ToInt32(Txt_capacidad.Text);
                decimal deMonto = Convert.ToDecimal(Txt_Monto.Text);

                int iIdReservaGenerado = cControlador.GuardarReservaSalonYObtenerID(iIdHuesped, iIdSalon, dFecha, dHoraInicio, dHoraFin, iCapacidad, deMonto);

                DateTime dFechaPago = Dtp_FechaPago.Value;
                decimal dePagoTotal = Convert.ToDecimal(Txt_PagoTotal.Text);
                string sEstado = Txt_Estadopago.Text;
                string sMetodoPago = Txt_MetodoPago.Text;

                cControlador.GuardarFolioSalon(iIdReservaGenerado, dFechaPago, dePagoTotal, sEstado, sMetodoPago);

                MessageBox.Show(" Reservación y folio guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ActualizarGrid();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la reserva y el folio: " + ex.Message);
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

                if (!bValidarCampos())
                {
                    MessageBox.Show("Complete todos los campos antes de modificar la reserva.");
                    return;
                }

                if (Cbo_Huesped.SelectedValue == null || Cbo_Salon.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione un huésped y un salón válidos.");
                    return;
                }

               
                int iIdHuesped = Convert.ToInt32(Cbo_Huesped.SelectedValue);
                int iIdSalon = Convert.ToInt32(Cbo_Salon.SelectedValue);
                DateTime dFecha = Dtp_Fecha.Value.Date;
                TimeSpan dHoraInicio = Dtp_Inicio.Value.TimeOfDay;
                TimeSpan dHoraFin = Dtp_Fin.Value.TimeOfDay;
                int iCapacidad = int.TryParse(Txt_capacidad.Text, out int iCap) ? iCap : 0;
                decimal deMonto = decimal.TryParse(Txt_Monto.Text, out decimal deM) ? deM : 0;

                
                cControlador.ModificarReservaSalon(
                    iCodigoReserva, iIdHuesped, iIdSalon, dFecha, dHoraInicio, dHoraFin, iCapacidad, deMonto
                );

                DateTime dFechaPago = Dtp_FechaPago.Value;
                decimal dePagoTotal = decimal.TryParse(Txt_PagoTotal.Text, out decimal dPago) ? dPago : 0;
                string sEstado = Txt_Estadopago.Text;
                string sMetodoPago = Txt_MetodoPago.Text;

                
                cControlador.ModificarFolioSalon(iCodigoReserva, dFechaPago, dePagoTotal, sEstado, sMetodoPago);

                MessageBox.Show("Reservación y folio modificados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

                DialogResult drResult = MessageBox.Show("¿Desea eliminar esta reservación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (drResult == DialogResult.Yes)
                {
                    cControlador.EliminarReservaSalon(iCodigoReserva);
                    MessageBox.Show(" Reservación eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarGrid();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la reserva: " + ex.Message);
            }
        }

        private void Frm_Reservaciones_Load(object sender, EventArgs e)
        {
            CargarCombos();
            ActualizarGrid();
        }

        private void Dvg_Reservaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                DataGridViewRow drFila = Dvg_Reservaciones.Rows[e.RowIndex];

                if (!Dvg_Reservaciones.Columns.Contains("Pk_Id_Reserva_Salon") ||
                    drFila.Cells["Pk_Id_Reserva_Salon"].Value == null)
                {
                    MessageBox.Show(" No se pudo obtener el ID de la reserva.");
                    return;
                }

                iCodigoReserva = Convert.ToInt32(drFila.Cells["Pk_Id_Reserva_Salon"].Value);

                if (Dvg_Reservaciones.Columns.Contains("Fk_Id_Huesped"))
                    Cbo_Huesped.SelectedValue = drFila.Cells["Fk_Id_Huesped"].Value ?? -1;

                if (Dvg_Reservaciones.Columns.Contains("Fk_Id_Salon"))
                    Cbo_Salon.SelectedValue = drFila.Cells["Fk_Id_Salon"].Value ?? -1;

                if (Dvg_Reservaciones.Columns.Contains("Cmp_Fecha_Reserva") &&
                    drFila.Cells["Cmp_Fecha_Reserva"].Value != DBNull.Value)
                    Dtp_Fecha.Value = Convert.ToDateTime(drFila.Cells["Cmp_Fecha_Reserva"].Value);

                if (Dvg_Reservaciones.Columns.Contains("Cmp_Hora_Inicio") &&
                    drFila.Cells["Cmp_Hora_Inicio"].Value != DBNull.Value)
                {
                    var dHoraInicio = drFila.Cells["Cmp_Hora_Inicio"].Value;
                    Dtp_Inicio.Value = dHoraInicio is TimeSpan tsIni
                        ? DateTime.Today.Add(tsIni)
                        : Convert.ToDateTime(dHoraInicio);
                }

                if (Dvg_Reservaciones.Columns.Contains("Cmp_Hora_Fin") &&
                    drFila.Cells["Cmp_Hora_Fin"].Value != DBNull.Value)
                {
                    var dHoraFin = drFila.Cells["Cmp_Hora_Fin"].Value;
                    Dtp_Fin.Value = dHoraFin is TimeSpan tsFin
                        ? DateTime.Today.Add(tsFin)
                        : Convert.ToDateTime(dHoraFin);
                }

                Txt_capacidad.Text = drFila.Cells["Cmp_Cantidad_Personas"].Value?.ToString() ?? "";
                Txt_Monto.Text = drFila.Cells["Cmp_Monto_Total"].Value?.ToString() ?? "";

                if (Dvg_Reservaciones.Columns.Contains("Cmp_Fecha_Pago") &&
                    drFila.Cells["Cmp_Fecha_Pago"].Value != DBNull.Value)
                    Dtp_FechaPago.Value = Convert.ToDateTime(drFila.Cells["Cmp_Fecha_Pago"].Value);

                if (Dvg_Reservaciones.Columns.Contains("Cmp_Pago_Total"))
                    Txt_PagoTotal.Text = drFila.Cells["Cmp_Pago_Total"].Value?.ToString() ?? "";

                if (Dvg_Reservaciones.Columns.Contains("Cmp_Estado"))
                    Txt_Estadopago.Text = drFila.Cells["Cmp_Estado"].Value?.ToString() ?? "";

                if (Dvg_Reservaciones.Columns.Contains("Cmp_Metodo_Pago"))
                    Txt_MetodoPago.Text = drFila.Cells["Cmp_Metodo_Pago"].Value?.ToString() ?? "";

                if (Dvg_Reservaciones.Columns.Contains("Fk_Id_Promociones") &&
                    drFila.Cells["Fk_Id_Promociones"].Value != DBNull.Value)
                {
                    Cbo_Promocion.SelectedValue = drFila.Cells["Fk_Id_Promociones"].Value;
                }
                else if (Dvg_Reservaciones.Columns.Contains("Cmp_Promocion"))
                {
                    Cbo_Promocion.Text = drFila.Cells["Cmp_Promocion"].Value?.ToString() ?? "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error al seleccionar la fila: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void salonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Salones fNuevoFormulario = new Frm_Salones();
            fNuevoFormulario.Show();
        }

        private void Lbl_Capacidad_Click(object sender, EventArgs e)
        {

        }

        private void Pnl_Superior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Frm_Reservaciones_Load_1(object sender, EventArgs e)
        {

        }

        private void Btn_Reportes_Click(object sender, EventArgs e)
        {
            Frm_Reportes_Reservacion fNuevoFormulario = new Frm_Reportes_Reservacion();
            fNuevoFormulario.Show();
        }
    }
}
