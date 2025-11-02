using System;
using System.Data;
using System.Windows.Forms;
using Capa_Controlador_Reservas_Hotel;


namespace Capa_Vista_Reservas_Hotel
{
    public partial class Frm_Reservas : Form
    {
        private readonly Controlador_Reserva controlador = new Controlador_Reserva();
        public Frm_Reservas()
        {
            InitializeComponent();
            this.Load += Frm_Reservas_Load;
        }

        private void Frm_Reservas_Load(object sender, EventArgs e)
        {
            // Combos estáticos
            Cmb_Tipo_Documento.DropDownStyle = ComboBoxStyle.DropDownList;
            Cmb_Tipo_Documento.Items.Clear();
            Cmb_Tipo_Documento.Items.Add("DPI");
            Cmb_Tipo_Documento.Items.Add("Pasaporte");
            Cmb_Tipo_Documento.SelectedIndex = 0;

            Cmb_Estado_Reserva.DropDownStyle = ComboBoxStyle.DropDownList;
            Cmb_Estado_Reserva.Items.Clear();
            Cmb_Estado_Reserva.Items.AddRange(new[] { "Pendiente", "Confirmada", "Cancelada" });
            Cmb_Estado_Reserva.SelectedIndex = 0;

            // Datos dinámicos
            CargarHabitaciones();
            CargarBuffet();

        }

        private void CargarHabitaciones()
        {
            DataTable tabla = controlador.ObtenerHabitaciones();
            Cmb_Habitacion.DataSource = tabla;
            Cmb_Habitacion.DisplayMember = "Descripcion";
            Cmb_Habitacion.ValueMember = "IdHabitacion";
            Cmb_Habitacion.SelectedIndexChanged -= Cmb_Habitacion_SelectedIndexChanged;
            Cmb_Habitacion.SelectedIndexChanged += Cmb_Habitacion_SelectedIndexChanged;
        }

        private void CargarBuffet()
        {
            try
            {
                string descripcion = controlador.ObtenerBuffetDescripcion();
                Txt_Buffet_Descripcion.Text = descripcion ?? string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar buffet: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cmb_Habitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_Habitacion.SelectedValue == null) return;
            if (int.TryParse(Cmb_Habitacion.SelectedValue.ToString(), out int idHabitacion))
            {
                decimal tarifa = controlador.ObtenerTarifaHabitacion(idHabitacion);
                Txt_Tarifa.Text = tarifa.ToString("F2");
            }
        }

        private void Btn_Calcular_Total_Click(object sender, EventArgs e)
        {
            try
            {
                if (!decimal.TryParse(Txt_Tarifa.Text, out decimal dTarifa))
                {
                    MessageBox.Show("Seleccione una habitación válida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DateTime dEntrada = Dtp_Entrada.Value.Date;
                DateTime dSalida = Dtp_Salida.Value.Date;

                decimal total = controlador.CalcularTotalReserva(dTarifa, dEntrada, dSalida);
                Txt_Total_Reserva.Text = total.ToString("F2");

                // Canje de puntos (la decisión de UI se toma aquí; la lógica y actualización en el controlador)
                if (!string.IsNullOrWhiteSpace(Txt_Puntos_Huesped.Text) &&
                    int.TryParse(Txt_Puntos_Huesped.Text, out int puntos) &&
                    puntos > 0)
                {
                    var opcion = MessageBox.Show(
                        $"El huésped tiene {puntos} puntos.\n¿Desea canjearlos como descuento?",
                        "Canje de Puntos",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (opcion == DialogResult.Yes)
                    {
                        int idHuesped = ObtenerIdHuesped();
                        var resultado = controlador.CanjearPuntos(idHuesped, total, puntos);
                        Txt_Total_Reserva.Text = resultado.dTotalFinal.ToString("F2");
                        Txt_Puntos_Huesped.Text = resultado.iPuntosRestantes.ToString();
                        MessageBox.Show(
                            $"Se han canjeado {resultado.iPuntosUsados} puntos. Nuevo total: Q{resultado.dTotalFinal:F2}.",
                            "Descuento aplicado",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al calcular el total: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                int idHuesped = ObtenerIdHuesped();
                int idHabitacion = Convert.ToInt32(Cmb_Habitacion.SelectedValue);
                int idBuffet = controlador.ObtenerBuffetIdIncluido(); // buffet incluido
                DateTime dEntrada = Dtp_Entrada.Value.Date;
                DateTime dSalida = Dtp_Salida.Value.Date;
                int NumHuespedes = (int)Num_Huespedes.Value;
                string sPeticiones = Txt_Peticiones.Text?.Trim();
                string sEstado = Cmb_Estado_Reserva.Text;
                if (!decimal.TryParse(Txt_Total_Reserva.Text, out decimal total))
                {
                    MessageBox.Show("Calcule el total antes de guardar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                controlador.InsertarReserva(idHuesped, idHabitacion, idBuffet, dEntrada, dSalida, NumHuespedes, sPeticiones, sEstado, total);
                MessageBox.Show("Reserva registrada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar reservas:\n\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Buscar_Huesped_Click(object sender, EventArgs e)
        {
            try
            {
                string sTipo = Cmb_Tipo_Documento.Text.Trim();
                string sNumero = Txt_Numero_Documento.Text.Trim();

                if (string.IsNullOrEmpty(sTipo) || string.IsNullOrEmpty(sNumero))
                {
                    MessageBox.Show("Seleccione el tipo de documento e ingrese el número.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DataRow dr = controlador.ObtenerHuesped(sTipo, sNumero);
                if (dr != null)
                {
                    Txt_Nombre_Huesped.Text = Convert.ToString(dr["Cmp_Nombre"]);
                    Txt_Apellido_Huesped.Text = Convert.ToString(dr["Cmp_Apellido"]);
                    int iDHuesped = Convert.ToInt32(dr["Pk_Id_Huesped"]);
                    int iPuntos = controlador.ObtenerPuntosHuesped(iDHuesped);
                    Txt_Puntos_Huesped.Text = iPuntos.ToString();
                }
                else
                {
                    MessageBox.Show("No se encontró ningún huésped con esos datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Txt_Nombre_Huesped.Clear();
                    Txt_Apellido_Huesped.Clear();
                    Txt_Puntos_Huesped.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar huésped: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int ObtenerIdHuesped()
        {
            string sTipo = Cmb_Tipo_Documento.Text.Trim();
            string sNumero = Txt_Numero_Documento.Text.Trim();
            DataRow dr = controlador.ObtenerHuesped(sTipo, sNumero);
            if (dr == null) throw new Exception("Huésped no encontrado.");
            return Convert.ToInt32(dr["Pk_Id_Huesped"]);
        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            Txt_Numero_Documento.Clear();
            Txt_Nombre_Huesped.Clear();
            Txt_Apellido_Huesped.Clear();
            Txt_Tarifa.Clear();
            Txt_Total_Reserva.Clear();
            Txt_Peticiones.Clear();
            Txt_Buffet_Descripcion.Clear();
            Txt_Puntos_Huesped.Clear();

            Num_Huespedes.Value = 1;

            Cmb_Tipo_Documento.SelectedIndex = 0;
            if (Cmb_Habitacion.Items.Count > 0) Cmb_Habitacion.SelectedIndex = 0;
            Cmb_Estado_Reserva.SelectedIndex = 0;

            Dtp_Entrada.Value = DateTime.Today;
            Dtp_Salida.Value = DateTime.Today.AddDays(1);
            Txt_Numero_Documento.Focus();
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            Frm_Modificar_Reserva modificar = new Frm_Modificar_Reserva();
            modificar.Show();
        }
    }
}
