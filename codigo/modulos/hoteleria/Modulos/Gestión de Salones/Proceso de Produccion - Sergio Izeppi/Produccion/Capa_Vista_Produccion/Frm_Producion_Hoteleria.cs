using System;
using System.Data;
using System.Windows.Forms;
using Capa_Controlador_Produccion;

namespace Capa_Vista_Produccion
{
    public partial class Frm_Produccion_Hoteleria : Form
    {
        private Cls_Controlador_Produccion controlador = new Cls_Controlador_Produccion();
        private int idRoomActual = 0;

        public Frm_Produccion_Hoteleria()
        {
            InitializeComponent();
            CargarEstadoCombo();
            CargarPlatosCombo();
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            idRoomActual = 0;
            Txt_ID_Pedido.Text = "";
            Txt_Id_Huesped.Text = "";
            Txt_Id_Habitacion.Text = "";
            Cbo_Estado.SelectedIndex = -1;
            Dtp_Fecha.Value = DateTime.Now;

            LimpiarDetalleCampos();
            Dgv_Platos.DataSource = null;
        }

        private void LimpiarDetalleCampos()
        {
            Cbo_Menu.SelectedIndex = -1;
            Txt_Cantidad.Text = "";
            Txt_PrecioUni.Text = "";
            Txt_Subtotal.Text = "";
        }

        private void CargarEstadoCombo()
        {
            Cbo_Estado.Items.Clear();
            Cbo_Estado.Items.Add("Entregado");
            Cbo_Estado.Items.Add("No entregado");
        }

        private void CargarPlatosCombo()
        {
            DataTable dtPlatos = controlador.ObtenerPlatos();
            Cbo_Menu.DataSource = dtPlatos;
            Cbo_Menu.DisplayMember = "Cmp_Nombre_Platillo"; // Nombre correcto en Tbl_Menu
            Cbo_Menu.ValueMember = "Pk_Id_Menu";
            Cbo_Menu.SelectedIndex = -1;
        }

        private void Cbo_Menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_Menu.SelectedIndex == -1) return;

            // Asegurarse de que SelectedValue no sea DataRowView
            if (Cbo_Menu.SelectedValue == null) return;

            if (int.TryParse(Cbo_Menu.SelectedValue.ToString(), out int idMenu))
            {
                decimal precio = controlador.ObtenerPrecioPlato(idMenu);
                Txt_PrecioUni.Text = precio.ToString("0.00");
                CalcularSubtotal();
            }
        }


        private void Txt_Cantidad_TextChanged(object sender, EventArgs e)
        {
            CalcularSubtotal();
        }

        private void CalcularSubtotal()
        {
            if (int.TryParse(Txt_Cantidad.Text, out int cantidad) &&
                decimal.TryParse(Txt_PrecioUni.Text, out decimal precio))
            {
                decimal subtotal = cantidad * precio;
                Txt_Subtotal.Text = subtotal.ToString("0.00");
            }
            else
            {
                Txt_Subtotal.Text = "";
            }
        }

        // Crear nuevo Room Service
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(Txt_Id_Huesped.Text, out int idHuesped) ||
                !int.TryParse(Txt_Id_Habitacion.Text, out int idHabitacion) ||
                Cbo_Estado.SelectedIndex == -1)
            {
                MessageBox.Show("Complete todos los campos correctamente.");
                return;
            }

            DateTime fecha = Dtp_Fecha.Value;
            string estado = Cbo_Estado.SelectedItem.ToString();

            idRoomActual = controlador.CrearRoomService(idHuesped, idHabitacion, fecha, estado);

            Txt_ID_Pedido.Text = idRoomActual.ToString();
            MessageBox.Show("Room Service creado con ID: " + idRoomActual);

            CargarDetalle();
        }

        // Agregar detalle al Room Service actual
        private void Btn_AgregarDetalle_Click(object sender, EventArgs e)
        {
            if (idRoomActual == 0)
            {
                MessageBox.Show("Primero debe crear el Room Service.");
                return;
            }

            if (Cbo_Menu.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un plato.");
                return;
            }

            if (!int.TryParse(Txt_Cantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida.");
                return;
            }

            int idMenu = Convert.ToInt32(Cbo_Menu.SelectedValue);
            decimal precioUnitario = controlador.ObtenerPrecioPlato(idMenu);
            decimal subtotal = cantidad * precioUnitario;

            controlador.AgregarDetalle(idRoomActual, idMenu, cantidad, precioUnitario, subtotal);

            CargarDetalle();
            LimpiarDetalleCampos();
        }

        private void CargarDetalle()
        {
            if (idRoomActual == 0) return;

            DataTable dtDetalle = controlador.ObtenerDetalle(idRoomActual);
            Dgv_Platos.DataSource = dtDetalle;

            // Ajustar columnas según nombres de Tbl_Room_Service_Detalle y Tbl_Menu
            if (Dgv_Platos.Columns.Contains("Pk_Id_Detalle"))
                Dgv_Platos.Columns["Pk_Id_Detalle"].Visible = false;

            if (Dgv_Platos.Columns.Contains("FK_Id_Menu"))
                Dgv_Platos.Columns["FK_Id_Menu"].Visible = false;

            if (Dgv_Platos.Columns.Contains("Cmp_Nombre_Platillo"))
                Dgv_Platos.Columns["Cmp_Nombre_Platillo"].HeaderText = "Nombre del Plato";

            if (Dgv_Platos.Columns.Contains("Cmp_Cantidad"))
                Dgv_Platos.Columns["Cmp_Cantidad"].HeaderText = "Cantidad";

            if (Dgv_Platos.Columns.Contains("Cmp_Precio_Unitario"))
                Dgv_Platos.Columns["Cmp_Precio_Unitario"].HeaderText = "Precio Unitario";

            if (Dgv_Platos.Columns.Contains("Cmp_Subtotal"))
                Dgv_Platos.Columns["Cmp_Subtotal"].HeaderText = "Subtotal";
        }

        // Modificar Room Service
        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            if (idRoomActual == 0)
            {
                MessageBox.Show("No hay Room Service para modificar.");
                return;
            }

            if (!int.TryParse(Txt_Id_Huesped.Text, out int idHuesped) ||
                !int.TryParse(Txt_Id_Habitacion.Text, out int idHabitacion) ||
                Cbo_Estado.SelectedIndex == -1)
            {
                MessageBox.Show("Complete todos los campos correctamente.");
                return;
            }

            DateTime fecha = Dtp_Fecha.Value;
            string estado = Cbo_Estado.SelectedItem.ToString();

            controlador.ModificarRoomService(idRoomActual, idHuesped, idHabitacion, fecha, estado);
            MessageBox.Show("Room Service modificado.");

            CargarDetalle();
        }

        // Eliminar Room Service
        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (idRoomActual == 0)
            {
                MessageBox.Show("No hay Room Service seleccionado para eliminar.");
                return;
            }

            controlador.EliminarRoomService(idRoomActual);
            MessageBox.Show("Room Service eliminado.");
            LimpiarFormulario();
        }
    }
}


