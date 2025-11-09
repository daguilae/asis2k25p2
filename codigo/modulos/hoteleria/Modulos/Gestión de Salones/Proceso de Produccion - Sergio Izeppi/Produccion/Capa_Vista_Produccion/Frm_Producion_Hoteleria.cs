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
using Capa_Vista_Produccion;
using System.Linq;


namespace CapaVistaProduccion
{
    public partial class Frm_Produccion_Hoteleria : Form
    {
        Cls_Controlador_Produccion controlador = new Cls_Controlador_Produccion();
        private int idRoomUltimo;

        public Frm_Produccion_Hoteleria()
        {
            InitializeComponent();
            Dgv_Room_Service.CellClick += Dgv_Room_Service_CellContentClick;
            Dgv_Platos.CellClick += Dgv_Platos_CellContentClick;
            CargarEstadoCombo();
            CargarTabla();
            CargarMenus();

            int idRoomUltimo = 0;

            try
            {
                idRoomUltimo = controlador.ObtenerUltimoIdRoomService();
            }
            catch
            {
                idRoomUltimo = 0;
            }

            if (idRoomUltimo > 0)
            {
                CargarDetalles(idRoomUltimo);
            }
        }

        private void CargarEstadoCombo()
        {
            Cbo_Estado.Items.Clear();
            Cbo_Estado.Items.Add("Entregado");
            Cbo_Estado.Items.Add("No entregado");
            Cbo_Estado.SelectedIndex = -1;
        }

        // ✅ Cargar datos en DataGridView
        private void CargarTabla()
        {
            Dgv_Room_Service.DataSource = controlador.MostrarRoomServices();
            Dgv_Room_Service.Columns["Pk_Id_Room"].HeaderText = "ID Room";
            Dgv_Room_Service.Columns["FK_Id_Huesped"].HeaderText = "ID Huesped";
            Dgv_Room_Service.Columns["Fk_Id_Habitacion"].HeaderText = "ID Habitación";
            Dgv_Room_Service.Columns["Cmp_Fecha_Orden"].HeaderText = "Fecha de Orden";
            Dgv_Room_Service.Columns["Cmp_Estado"].HeaderText = "Estado";
        }

        // ✅ Guardar nuevo registro
        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(Txt_Id_Huesped.Text, out int idHuesped) ||
                !int.TryParse(Txt_Id_Habitacion.Text, out int idHabitacion) ||
                Cbo_Estado.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor complete todos los campos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime fecha = Dtp_Fecha.Value;
            string estado = Cbo_Estado.SelectedItem.ToString();

            controlador.GuardarRoomService(idHuesped, idHabitacion, fecha, estado);

            MessageBox.Show("Room Service guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCampos();
            CargarTabla();
        }

        // ✅ Modificar registro
        private void Btn_modificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_ID_Pedido.Text))
            {
                MessageBox.Show("Seleccione un registro para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(Txt_Id_Huesped.Text, out int idHuesped) ||
                !int.TryParse(Txt_Id_Habitacion.Text, out int idHabitacion) ||
                Cbo_Estado.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor complete todos los campos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idRoom = Convert.ToInt32(Txt_ID_Pedido.Text);
            DateTime fecha = Dtp_Fecha.Value;
            string estado = Cbo_Estado.SelectedItem.ToString();

            controlador.ActualizarRoomService(idRoom, idHuesped, idHabitacion, fecha, estado);

            MessageBox.Show("Room Service actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCampos();
            CargarTabla();
        }

        // ✅ Eliminar registro
        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_ID_Pedido.Text))
            {
                MessageBox.Show("Seleccione un registro para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idRoom = Convert.ToInt32(Txt_ID_Pedido.Text);

            var confirm = MessageBox.Show("¿Seguro que desea eliminar este Room Service?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                controlador.EliminarRoomService(idRoom);
                MessageBox.Show("Room Service eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarTabla();
            }
        }

        // ✅ Al hacer clic en una fila del DataGridView
        private void Dgv_Room_Service_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && Dgv_Room_Service.Rows[e.RowIndex].Cells["Pk_Id_Room"].Value != null)
            {
                // Rellenar los campos del formulario principal
                Txt_ID_Pedido.Text = Dgv_Room_Service.Rows[e.RowIndex].Cells["Pk_Id_Room"].Value.ToString();
                Txt_Id_Huesped.Text = Dgv_Room_Service.Rows[e.RowIndex].Cells["FK_Id_Huesped"].Value.ToString();
                Txt_Id_Habitacion.Text = Dgv_Room_Service.Rows[e.RowIndex].Cells["Fk_Id_Habitacion"].Value.ToString();
                Dtp_Fecha.Value = Convert.ToDateTime(Dgv_Room_Service.Rows[e.RowIndex].Cells["Cmp_Fecha_Orden"].Value);
                Cbo_Estado.SelectedItem = Dgv_Room_Service.Rows[e.RowIndex].Cells["Cmp_Estado"].Value.ToString();

                // ✅ Cargar automáticamente los detalles del Room seleccionado
                if (int.TryParse(Txt_ID_Pedido.Text, out int idRoom))
                {
                    CargarDetalles(idRoom);
                }
            }
        }

        // ✅ Limpiar los campos del formulario
        private void LimpiarCampos()
        {
            Txt_ID_Pedido.Text = "";
            Txt_Id_Huesped.Text = "";
            Txt_Id_Habitacion.Text = "";
            Cbo_Estado.SelectedIndex = -1;
            Dtp_Fecha.Value = DateTime.Now;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarMenus()
        {
            DataTable dtMenus = controlador.MostrarDetallesPorRoom(0); // o método que obtenga menús
            // O mejor: puedes usar el modelo de menús que ya tienes
            var model = new Cls_Controlador_Produccion();
            DataTable platos = controlador.ObtenerPlatos();

            Cbo_Menu.DataSource = platos;
            Cbo_Menu.DisplayMember = "Cmp_Nombre_Platillo"; // el campo exacto de la tabla Tbl_Menu
            Cbo_Menu.ValueMember = "Pk_Id_Menu";       // el ID del menú
            Cbo_Menu.SelectedIndex = -1;
        }

        // ✅ Cargar detalles en DataGridView
        private void CargarDetalles(int idRoom)
        {
            // Traemos solo los detalles del Room Service específico
            DataTable dt = controlador.MostrarDetallesPorRoom(idRoom);

            // Agregar columna extra para el total general del cliente
            if (!dt.Columns.Contains("Total_Cliente"))
                dt.Columns.Add("Total_Cliente", typeof(decimal));

            // Calcular total del cliente
            decimal totalCliente = dt.AsEnumerable().Sum(row => row.Field<decimal>("Cmp_Subtotal"));

            // Llenar la columna "Total_Cliente" con el mismo total para cada fila
            foreach (DataRow row in dt.Rows)
            {
                row["Total_Cliente"] = totalCliente;
            }

            // Asignar al DataGridView
            Dgv_Platos.DataSource = dt;

            // Configurar columnas visibles y encabezados
            if (Dgv_Platos.Columns.Contains("Pk_Id_Detalle"))
                Dgv_Platos.Columns["Pk_Id_Detalle"].Visible = false;

            if (Dgv_Platos.Columns.Contains("Plato"))
                Dgv_Platos.Columns["Plato"].HeaderText = "Nombre del Plato";

            if (Dgv_Platos.Columns.Contains("Cmp_Cantidad"))
                Dgv_Platos.Columns["Cmp_Cantidad"].HeaderText = "Cantidad";

            if (Dgv_Platos.Columns.Contains("Cmp_Precio_Unitario"))
                Dgv_Platos.Columns["Cmp_Precio_Unitario"].HeaderText = "Precio Unitario";

            if (Dgv_Platos.Columns.Contains("Cmp_Subtotal"))
                Dgv_Platos.Columns["Cmp_Subtotal"].HeaderText = "Subtotal";

            if (Dgv_Platos.Columns.Contains("Total_Cliente"))
                Dgv_Platos.Columns["Total_Cliente"].HeaderText = "Total Cliente";
        }



        // ✅ Cuando se seleccione un menú, llenar precio unitario automáticamente
        private void Cbo_Menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_Menu.SelectedIndex == -1) return;
            if (Cbo_Menu.SelectedValue == null) return;

            if (int.TryParse(Cbo_Menu.SelectedValue.ToString(), out int idMenu))
            {
                decimal precio = controlador.ObtenerPrecio(idMenu);
                Txt_PrecioUni.Text = precio.ToString("0.00");
                CalcularSubtotal();
            }
        }

        // ✅ Calcular subtotal automático
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

        // ✅ GUARDAR
        private void Btn_Guardar_Plato_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(Txt_ID_Pedido.Text, out int idRoom))
            {
                MessageBox.Show("Debe ingresar el ID del Room Service.");
                return;
            }

            if (Cbo_Menu.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un platillo.");
                return;
            }

            if (!int.TryParse(Txt_Cantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida.");
                return;
            }

            int idMenu = Convert.ToInt32(Cbo_Menu.SelectedValue);
            controlador.GuardarDetalle(idRoom, idMenu, cantidad);

            MessageBox.Show("Detalle guardado correctamente.");
            CargarDetalles(idRoomUltimo);
            LimpiarCampos2();
        }

        // ✅ EDITAR
        private void Btn_editar_plato_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(Txt_ID_Pedido.Text, out int idRoom))
            {
                MessageBox.Show("Debe ingresar el ID del Room Service.");
                return;
            }

            if (string.IsNullOrEmpty(Txt_ID_Pedido.Text))
            {
                MessageBox.Show("Seleccione un detalle para editar.");
                return;
            }

            if (!int.TryParse(Txt_Cantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida.");
                return;
            }

            int idDetalle = Convert.ToInt32(Txt_ID_Pedido.Text);
            int idMenu = Convert.ToInt32(Cbo_Menu.SelectedValue);

            controlador.ActualizarDetalle(idDetalle, idRoom, idMenu, cantidad);

            MessageBox.Show("Detalle actualizado correctamente.");
            CargarDetalles(idRoomUltimo);
            LimpiarCampos2();
        }

        // ✅ ELIMINAR
        private void Btn_eliminar_Plato_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_ID_Pedido.Text))
            {
                MessageBox.Show("Seleccione un detalle para eliminar.");
                return;
            }

            int idDetalle = Convert.ToInt32(Txt_ID_Pedido.Text);
            controlador.BorrarDetalle(idDetalle);

            MessageBox.Show("Detalle eliminado correctamente.");
            CargarDetalles(idRoomUltimo);
            LimpiarCampos2();
        }

        // ✅ Cargar datos del DataGridView en los controles
        private void Dgv_Platos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignorar clics en encabezado
            if (e.RowIndex < 0) return;

            var row = Dgv_Platos.Rows[e.RowIndex];

            // Comprobar que la celda no sea nula
            if (row.Cells["Cmp_Nombre_Platillo"].Value != null)
                Cbo_Menu.Text = row.Cells["Cmp_Nombre_Platillo"].Value.ToString();

            if (row.Cells["Cmp_Cantidad"].Value != null)
                Txt_Cantidad.Text = row.Cells["Cmp_Cantidad"].Value.ToString();

            if (row.Cells["Cmp_Precio_Unitario"].Value != null)
                Txt_PrecioUni.Text = row.Cells["Cmp_Precio_Unitario"].Value.ToString();

            if (row.Cells["Cmp_Subtotal"].Value != null)
                Txt_Subtotal.Text = row.Cells["Cmp_Subtotal"].Value.ToString();
        }



        // ✅ Limpiar
        private void LimpiarCampos2()
        {
            Txt_ID_Pedido.Text = "";
            Cbo_Menu.SelectedIndex = -1;
            Txt_Cantidad.Text = "";
            Txt_PrecioUni.Text = "";
            Txt_Subtotal.Text = "";
        }

        private void Txt_ID_Pedido_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(Txt_ID_Pedido.Text, out int idRoomUltimo))
            {
                CargarDetalles(idRoomUltimo);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Produccion_Alacarta nuevoFormulario = new Frm_Produccion_Alacarta();
            nuevoFormulario.Show();
        }
    }
}


