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
        public int Estado_Crud = 1;
        
        Cls_Controlador_GesHab controlador = new Cls_Controlador_GesHab();



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
            DataTable dtEstadias = controlador.CargarIdsEstadia();
            Cbo_PK_Id_Estadia.DataSource = dtEstadias;
            Cbo_PK_Id_Estadia.DisplayMember = "Pk_Id_Estadia"; 
            Cbo_PK_Id_Estadia.ValueMember = "Pk_Id_Estadia";  
            Cbo_PK_Id_Estadia.SelectedIndex = -1;

            // --- ComboBox Habitaciones ---
            DataTable dtHabitaciones = controlador.CargarHabitaciones();
            cbo_fk_id_Habitacion.DataSource = dtHabitaciones;
            cbo_fk_id_Habitacion.DisplayMember = "PK_ID_Habitaciones";
            cbo_fk_id_Habitacion.ValueMember = "PK_ID_Habitaciones";
            cbo_fk_id_Habitacion.SelectedIndex = -1;

            // --- ComboBox Huéspedes ---
            DataTable dtHuespedes = controlador.CargarHuespedes();
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
                    int.TryParse(cbo_fk_id_Habitacion.SelectedValue.ToString(), out int idHabitacion))
                {
                    int capacidad = controlador.ObtenerCapacidadHabitacion(idHabitacion);
                    lbl_maxima_capacidad.Text = $"Capacidad Máx: {capacidad} Persona/s";
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
                DateTime fechaCheckIn = DTP_Check_in.Value.Date;
                DateTime fechaActual = DTP_CheckOut.Value.Date;

                if (fechaActual < fechaCheckIn)
                {
                    lbl_montoTotal.Text = "----";
                    return;
                }

                int diasEstadia = (fechaActual - fechaCheckIn).Days;
                if (diasEstadia == 0)
                    diasEstadia = 1;

                if (cbo_fk_id_Habitacion.SelectedValue != null && int.TryParse(  cbo_fk_id_Habitacion.SelectedValue.ToString(), out int idHabitacion))
                {

                    double tarifaPorNoche = controlador.ObtenerTarifaHabitacion(idHabitacion);
                    double montoTotal = diasEstadia * tarifaPorNoche;
                    lbl_Precio_Unitario.Text = $"Q {tarifaPorNoche:N2}";
                    lbl_montoTotal.Text = $"Q {montoTotal:N2}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular monto total: " + ex.Message);
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            int idEstadia = 0;
            int.TryParse(Cbo_PK_Id_Estadia.SelectedValue?.ToString(), out idEstadia);
            int idHabitacion = 0;
            int.TryParse(cbo_fk_id_Habitacion.SelectedValue?.ToString(), out idHabitacion);
            int idHuesped = 0;
            int.TryParse(cbo_Fk_Id_Huesped.SelectedValue?.ToString(), out idHuesped);
            int numHuespedes = 0;
            int.TryParse(txt_Num_Huespedes.Text, out numHuespedes);
            bool tieneReserva = Chk_TieneReservación.Checked;
            DateTime fechaCheckIn = DTP_Check_in.Value;
            DateTime fechaActual = DTP_CheckOut.Value;
            decimal montoTotal = 0;
            decimal.TryParse(lbl_montoTotal.Text.Replace("Q", "").Trim(), out montoTotal);

            Cls_Controlador_GesHab controlador = new Cls_Controlador_GesHab();

            if (Estado_Crud == 1)
            {
                string mensaje;
                bool exito = controlador.InsertarEstadiaVerificada(
                    idHabitacion,
                    idHuesped,
                    numHuespedes,
                    tieneReserva,
                    fechaCheckIn,
                    fechaActual,
                    montoTotal,
                    out mensaje
                );

                MessageBox.Show(mensaje, exito ? "Éxito" : "Advertencia",
                    MessageBoxButtons.OK, exito ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

                if (exito)
                {
                    limpiar_controles();
                    Estado_Crud = 1;
                    btn_modificar.Enabled = true;
                }
            }
            else
            {
                string mensaje;
                bool exito = controlador.ModificarEstadiaVerificada(
                    idEstadia,
                    idHabitacion,
                    idHuesped,
                    numHuespedes,
                    tieneReserva,
                    fechaCheckIn,
                    fechaActual,
                    montoTotal,
                    out mensaje
                );

                MessageBox.Show(mensaje, exito ? "Éxito" : "Advertencia",
                    MessageBoxButtons.OK, exito ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

                if (exito)
                {
                    limpiar_controles();
                    Estado_Crud = 1;
                    btn_modificar.Enabled = true;
                }
            }
        }




        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Estado_Crud = 2;
            btn_modificar.Enabled = false;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Cls_Controlador_GesHab controlador = new Cls_Controlador_GesHab();
            int idEstadia = 0;
            int.TryParse(Cbo_PK_Id_Estadia.SelectedValue?.ToString(), out idEstadia);

            DialogResult confirmacion = MessageBox.Show(
                  "¿Está seguro de que desea eliminar esta estadía?",
                  "Confirmar eliminación",
                  MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question
                );

            if (confirmacion == DialogResult.Yes)
            {
                bool exito = controlador.EliminarEstadia(idEstadia);
                if (exito)
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
            this.Close();
        }

        void limpiar_controles()
        {
            Cbo_PK_Id_Estadia.SelectedItem = null;
            cbo_fk_id_Habitacion.SelectedItem = null;
            cbo_Fk_Id_Huesped.SelectedItem  = null;
            txt_Num_Huespedes.Text = "";
            Chk_TieneReservación.Checked = false;
            DTP_Check_in.Value = DateTime.Today;
            DTP_CheckOut.Value = DateTime.Today;
            lbl_montoTotal.Text = "----";
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar_controles();
            btn_modificar.Enabled = true;
            Estado_Crud = 1;
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            int idEstadia = 0;
            int.TryParse(Cbo_PK_Id_Estadia.SelectedValue?.ToString(), out idEstadia);

            string mensaje;
            DataTable dt = controlador.BuscarEstadiaPorIdVerificada(idEstadia, out mensaje);

            if (dt == null)
            {
                MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- Cargar los datos en los controles ---
            DataRow row = dt.Rows[0];

            cbo_fk_id_Habitacion.SelectedValue = row["Fk_Id_Habitaciones"].ToString();
            cbo_Fk_Id_Huesped.SelectedValue = row["Fk_Id_Huesped_Checkin"].ToString();
            txt_Num_Huespedes.Text = row["Cmp_Num_Huespedes"].ToString();
            Chk_TieneReservación.Checked = Convert.ToBoolean(row["Cmp_Tiene_Reservacion"]);
            DTP_Check_in.Value = Convert.ToDateTime(row["Cmp_Fecha_Check_In"]);
            DTP_CheckOut.Value = Convert.ToDateTime(row["Cmp_Fecha_Check_Out"]);

            // --- Mostrar monto total ---
            decimal monto = 0;
            decimal.TryParse(row["Cmp_Monto_Total_Pago"].ToString(), out monto);
            lbl_montoTotal.Text = $"Q {monto:N2}";

            // --- Mostrar tarifa por noche ---
            if (int.TryParse(row["Fk_Id_Habitaciones"].ToString(), out int idHabitacion))
            {
                double tarifa = controlador.ObtenerTarifaHabitacion(idHabitacion);
                lbl_Precio_Unitario.Text = $"Q {tarifa:N2}";
            }
        }
    }
}
