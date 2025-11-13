using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_GesHab;

namespace Capa_Vista_Gestion_Habitacion
{
    public partial class Frm_Estadia : Form
    {
        public int iEstadoCrud = 1;
        Cls_Controlador_GesHab oControlador = new Cls_Controlador_GesHab();

        public Frm_Estadia()
        {
            InitializeComponent();
            CargarCombos();
            cbo_fk_id_Habitacion.SelectedValueChanged += cbo_fk_id_Habitacion_SelectedValueChanged;

            // Asociar eventos a los DateTimePicker
            DTP_Check_in.ValueChanged += new EventHandler(CalcularMontoTotal);
            DTP_CheckOut.ValueChanged += new EventHandler(CalcularMontoTotal);
            cbo_fk_id_Habitacion.SelectedValueChanged += new EventHandler(CalcularMontoTotal);
        }

        private void CargarCombos()
        {
            // --- ComboBox de Estadías ---
            DataTable dtEstadias = oControlador.CargarIdsEstadia();
            Cbo_PK_Id_Estadia.DataSource = dtEstadias;
            Cbo_PK_Id_Estadia.DisplayMember = "Pk_Id_Estadia";
            Cbo_PK_Id_Estadia.ValueMember = "Pk_Id_Estadia";
            Cbo_PK_Id_Estadia.SelectedIndex = -1;

            // --- ComboBox Habitaciones ---
            DataTable dtHabitaciones = oControlador.CargarHabitaciones();
            cbo_fk_id_Habitacion.DataSource = dtHabitaciones;
            cbo_fk_id_Habitacion.DisplayMember = "PK_ID_Habitaciones";
            cbo_fk_id_Habitacion.ValueMember = "PK_ID_Habitaciones";
            cbo_fk_id_Habitacion.SelectedIndex = -1;

            // --- ComboBox Huéspedes ---
            DataTable dtHuespedes = oControlador.CargarHuespedes();
            cbo_Fk_Id_Huesped.DataSource = dtHuespedes;
            cbo_Fk_Id_Huesped.DisplayMember = "NombreCompleto";
            cbo_Fk_Id_Huesped.ValueMember = "Pk_Id_Huesped";
            cbo_Fk_Id_Huesped.SelectedIndex = -1;
        }

        private void cbo_fk_id_Habitacion_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbo_fk_id_Habitacion.SelectedValue != null &&
                    int.TryParse(cbo_fk_id_Habitacion.SelectedValue.ToString(), out int iIdHabitacion))
                {
                    int iCapacidad = oControlador.ObtenerCapacidadHabitacion(iIdHabitacion);
                    lbl_maxima_capacidad.Text = $"Capacidad Máx: {iCapacidad} Persona/s";
                }
                else
                {
                    lbl_maxima_capacidad.Text = "Capacidad Máx: ----";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener la capacidad del cuarto: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalcularMontoTotal(object sender, EventArgs e)
        {
            try
            {
                DateTime dFechaCheckIn = DTP_Check_in.Value.Date;
                DateTime dFechaCheckOut = DTP_CheckOut.Value.Date;

                if (dFechaCheckOut < dFechaCheckIn)
                {
                    lbl_montoTotal.Text = "----";
                    return;
                }

                int iDiasEstadia = (dFechaCheckOut - dFechaCheckIn).Days;
                if (iDiasEstadia == 0)
                    iDiasEstadia = 1;

                if (cbo_fk_id_Habitacion.SelectedValue != null &&
                    int.TryParse(cbo_fk_id_Habitacion.SelectedValue.ToString(), out int iIdHabitacion))
                {
                    double doTarifaPorNoche = oControlador.ObtenerTarifaHabitacion(iIdHabitacion);
                    double doMontoTotal = iDiasEstadia * doTarifaPorNoche;

                    lbl_Precio_Unitario.Text = $"Q {doTarifaPorNoche:N2}";
                    lbl_montoTotal.Text = $"Q {doMontoTotal:N2}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular monto total: " + ex.Message);
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            int iIdEstadia = 0;
            int.TryParse(Cbo_PK_Id_Estadia.SelectedValue?.ToString(), out iIdEstadia);

            int iIdHabitacion = 0;
            int.TryParse(cbo_fk_id_Habitacion.SelectedValue?.ToString(), out iIdHabitacion);

            int iIdHuesped = 0;
            int.TryParse(cbo_Fk_Id_Huesped.SelectedValue?.ToString(), out iIdHuesped);

            int iNumHuespedes = 0;
            int.TryParse(txt_Num_Huespedes.Text, out iNumHuespedes);

            bool bTieneReserva = Chk_TieneReservación.Checked;
            DateTime dFechaCheckIn = DTP_Check_in.Value;
            DateTime dFechaCheckOut = DTP_CheckOut.Value;

            decimal deMontoTotal = 0;
            decimal.TryParse(lbl_montoTotal.Text.Replace("Q", "").Trim(), out deMontoTotal);

            string sMensaje;
            bool bExito;

            if (iEstadoCrud == 1)
            {
                bExito = oControlador.InsertarEstadiaVerificada(
                    iIdHabitacion,
                    iIdHuesped,
                    iNumHuespedes,
                    bTieneReserva,
                    dFechaCheckIn,
                    dFechaCheckOut,
                    deMontoTotal,
                    out sMensaje
                );
            }
            else
            {
                bExito = oControlador.ModificarEstadiaVerificada(
                    iIdEstadia,
                    iIdHabitacion,
                    iIdHuesped,
                    iNumHuespedes,
                    bTieneReserva,
                    dFechaCheckIn,
                    dFechaCheckOut,
                    deMontoTotal,
                    out sMensaje
                );
            }

            MessageBox.Show(sMensaje, bExito ? "Éxito" : "Advertencia",
                MessageBoxButtons.OK, bExito ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            if (bExito)
            {
                limpiar_controles();
                iEstadoCrud = 1;
                btn_modificar.Enabled = true;
                CargarCombos();
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            iEstadoCrud = 2;
            btn_modificar.Enabled = false;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            int iIdEstadia = 0;
            int.TryParse(Cbo_PK_Id_Estadia.SelectedValue?.ToString(), out iIdEstadia);

            DialogResult drConfirmacion = MessageBox.Show(
                "¿Está seguro de que desea eliminar esta estadía?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (drConfirmacion == DialogResult.Yes)
            {
                bool bExito = oControlador.EliminarEstadia(iIdEstadia);

                if (bExito)
                {
                    MessageBox.Show("Registro eliminado correctamente.", "Éxito");
                    limpiar_controles();
                    CargarCombos();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el registro o no existe.", "Advertencia");
                }
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            //this.Close();
        }

        void limpiar_controles()
        {
            Cbo_PK_Id_Estadia.SelectedItem = null;
            cbo_fk_id_Habitacion.SelectedItem = null;
            cbo_Fk_Id_Huesped.SelectedItem = null;
            txt_Num_Huespedes.Text = "";
            Chk_TieneReservación.Checked = false;
            DTP_Check_in.Value = DateTime.Today;
            DTP_CheckOut.Value = DateTime.Today;
            lbl_montoTotal.Text = "----";
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar_controles();
            CargarCombos();
            btn_modificar.Enabled = true;
            lbl_maxima_capacidad.Text ="";
            lbl_montoTotal.Text = "";
            lbl_Precio_Unitario.Text = "";
            iEstadoCrud = 1;
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            int iIdEstadia = 0;
            int.TryParse(Cbo_PK_Id_Estadia.SelectedValue?.ToString(), out iIdEstadia);

            string sMensaje;
            DataTable dtResultado = oControlador.BuscarEstadiaPorIdVerificada(iIdEstadia, out sMensaje);

            if (dtResultado == null)
            {
                MessageBox.Show(sMensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRow drFila = dtResultado.Rows[0];

            cbo_fk_id_Habitacion.SelectedValue = drFila["Fk_Id_Habitaciones"].ToString();
            cbo_Fk_Id_Huesped.SelectedValue = drFila["Fk_Id_Huesped_Checkin"].ToString();
            txt_Num_Huespedes.Text = drFila["Cmp_Num_Huespedes"].ToString();
            Chk_TieneReservación.Checked = Convert.ToBoolean(drFila["Cmp_Tiene_Reservacion"]);
            DTP_Check_in.Value = Convert.ToDateTime(drFila["Cmp_Fecha_Check_In"]);
            DTP_CheckOut.Value = Convert.ToDateTime(drFila["Cmp_Fecha_Check_Out"]);

            decimal deMonto = 0;
            decimal.TryParse(drFila["Cmp_Monto_Total_Pago"].ToString(), out deMonto);
            lbl_montoTotal.Text = $"Q {deMonto:N2}";

            if (int.TryParse(drFila["Fk_Id_Habitaciones"].ToString(), out int iIdHabitacion))
            {
                double doTarifa = oControlador.ObtenerTarifaHabitacion(iIdHabitacion);
                lbl_Precio_Unitario.Text = $"Q {doTarifa:N2}";
            }
        }

        private void btn_Reportes_Click(object sender, EventArgs e)
        {
            Frm_Reportes_Estadia frmRpt = new Frm_Reportes_Estadia();
            frmRpt.Show();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
