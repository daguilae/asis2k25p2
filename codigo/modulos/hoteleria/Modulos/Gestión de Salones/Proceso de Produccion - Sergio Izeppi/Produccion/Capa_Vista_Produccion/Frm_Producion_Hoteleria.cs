using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Produccion;
using System.Linq;

namespace Capa_Vista_Produccion
{
    public partial class Frm_Produccion_Hoteleria : Form
    {
        Cls_Controlador_Produccion pControlador = new Cls_Controlador_Produccion();
        private int iIdRoomUltimo;

        public Frm_Produccion_Hoteleria()
        {
            InitializeComponent();
            Dgv_Room_Service.CellClick += pro_Dgv_Room_Service_CellContentClick;
            Dgv_Platos.CellClick += pro_Dgv_Platos_CellContentClick;
            pro_CargarEstadoCombo();
            pro_CargarTabla();
            pro_CargarMenus();

            int iIdRoomUltimo = 0;

            try
            {
                iIdRoomUltimo = pControlador.fun_ObtenerUltimoIdRoomService();
            }
            catch
            {
                iIdRoomUltimo = 0;
            }

            if (iIdRoomUltimo > 0)
            {
                pro_CargarDetalles(iIdRoomUltimo);
            }
        }

        private void pro_CargarEstadoCombo()
        {
            Cbo_Estado.Items.Clear();
            Cbo_Estado.Items.Add("Entregado");
            Cbo_Estado.Items.Add("No entregado");
            Cbo_Estado.SelectedIndex = -1;
        }

        // ✅ Cargar datos en DataGridView
        private void pro_CargarTabla()
        {
            Dgv_Room_Service.DataSource = pControlador.fun_MostrarRoomServices();
            Dgv_Room_Service.Columns["Pk_Id_Room"].HeaderText = "ID Room";
            Dgv_Room_Service.Columns["FK_Id_Huesped"].HeaderText = "ID Huesped";
            Dgv_Room_Service.Columns["Fk_Id_Habitacion"].HeaderText = "ID Habitación";
            Dgv_Room_Service.Columns["Cmp_Fecha_Orden"].HeaderText = "Fecha de Orden";
            Dgv_Room_Service.Columns["Cmp_Estado"].HeaderText = "Estado";
        }

        private void pro_Btn_guardar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(Txt_Id_Huesped.Text, out int iIdHuesped) ||
                !int.TryParse(Txt_Id_Habitacion.Text, out int iIdHabitacion) ||
                Cbo_Estado.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor complete todos los campos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime dFecha = Dtp_Fecha.Value;
            string sEstado = Cbo_Estado.SelectedItem.ToString();

            try
            {
                pControlador.pro_GuardarRoomService(iIdHuesped, iIdHabitacion, dFecha, sEstado);

                MessageBox.Show("✅ Room Service guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pro_LimpiarCampos();
                pro_CargarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // ✅ Modificar registro
        private void pro_Btn_modificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_ID_Pedido.Text))
            {
                MessageBox.Show("Seleccione un registro para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(Txt_Id_Huesped.Text, out int iIdHuesped) ||
                !int.TryParse(Txt_Id_Habitacion.Text, out int iIdHabitacion) ||
                Cbo_Estado.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor complete todos los campos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int iIdRoom = Convert.ToInt32(Txt_ID_Pedido.Text);
            DateTime dFecha = Dtp_Fecha.Value;
            string sEstado = Cbo_Estado.SelectedItem.ToString();

            pControlador.pro_ActualizarRoomService(iIdRoom, iIdHuesped, iIdHabitacion, dFecha, sEstado);

            MessageBox.Show("Room Service actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            pro_LimpiarCampos();
            pro_CargarTabla();
        }

        // ✅ Eliminar registro
        private void pro_Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_ID_Pedido.Text))
            {
                MessageBox.Show("Seleccione un registro para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int iIdRoom = Convert.ToInt32(Txt_ID_Pedido.Text);

            var dConfirm = MessageBox.Show("¿Seguro que desea eliminar este Room Service?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dConfirm == DialogResult.Yes)
            {
                pControlador.pro_EliminarRoomService(iIdRoom);
                MessageBox.Show("Room Service eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pro_LimpiarCampos();
                pro_CargarTabla();
            }
        }

        // ✅ Al hacer clic en una fila del DataGridView
        private void pro_Dgv_Room_Service_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                if (int.TryParse(Txt_ID_Pedido.Text, out int iIdRoom))
                {
                    pro_CargarDetalles(iIdRoom);
                }
            }
        }

        // ✅ Limpiar los campos del formulario
        private void pro_LimpiarCampos()
        {
            Txt_ID_Pedido.Text = "";
            Txt_Id_Huesped.Text = "";
            Txt_Id_Habitacion.Text = "";
            Cbo_Estado.SelectedIndex = -1;
            Dtp_Fecha.Value = DateTime.Now;
        }

        private void pro_pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pro_CargarMenus()
        {
            DataTable dPlatos = pControlador.fun_ObtenerPlatos();

            Cbo_Menu.DataSource = dPlatos;
            Cbo_Menu.DisplayMember = "Cmp_Nombre_Platillo";
            Cbo_Menu.ValueMember = "Pk_Id_Menu";
            Cbo_Menu.SelectedIndex = -1;
        }

        // ✅ Cargar detalles en DataGridView
        private void pro_CargarDetalles(int iIdRoom)
        {
            // Traemos solo los detalles del Room Service específico
            DataTable dTabla = pControlador.fun_MostrarDetallesPorRoom(iIdRoom);

            // Agregar columna extra para el total general del cliente
            if (!dTabla.Columns.Contains("Total_Cliente"))
                dTabla.Columns.Add("Total_Cliente", typeof(decimal));

            // Calcular total del cliente
            decimal deTotalCliente = dTabla.AsEnumerable().Sum(row => row.Field<decimal>("Cmp_Subtotal"));

            // Llenar la columna "Total_Cliente" con el mismo total para cada fila
            foreach (DataRow dRow in dTabla.Rows)
            {
                dRow["Total_Cliente"] = deTotalCliente;
            }

            // Asignar al DataGridView
            Dgv_Platos.DataSource = dTabla;

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
        private void pro_Cbo_Menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_Menu.SelectedIndex == -1) return;
            if (Cbo_Menu.SelectedValue == null) return;

            if (int.TryParse(Cbo_Menu.SelectedValue.ToString(), out int iIdMenu))
            {
                decimal dePrecio = pControlador.fun_ObtenerPrecio(iIdMenu);
                Txt_PrecioUni.Text = dePrecio.ToString("0.00");
                pro_CalcularSubtotal();
            }
        }

        // ✅ Calcular subtotal automático
        private void pro_Txt_Cantidad_TextChanged(object sender, EventArgs e)
        {
            pro_CalcularSubtotal();
        }

        private void pro_CalcularSubtotal()
        {
            if (int.TryParse(Txt_Cantidad.Text, out int iCantidad) &&
                decimal.TryParse(Txt_PrecioUni.Text, out decimal dePrecio))
            {
                decimal deSubtotal = iCantidad * dePrecio;
                Txt_Subtotal.Text = deSubtotal.ToString("0.00");
            }
            else
            {
                Txt_Subtotal.Text = "";
            }
        }

        // ✅ GUARDAR
        private void pro_Btn_Guardar_Plato_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(Txt_ID_Pedido.Text, out int iIdRoom))
            {
                MessageBox.Show("Debe ingresar el ID del Room Service.");
                return;
            }

            if (Cbo_Menu.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un platillo.");
                return;
            }

            if (!int.TryParse(Txt_Cantidad.Text, out int iCantidad) || iCantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida.");
                return;
            }

            int iIdMenu = Convert.ToInt32(Cbo_Menu.SelectedValue);
            pControlador.pro_GuardarDetalle(iIdRoom, iIdMenu, iCantidad);

            MessageBox.Show("Detalle guardado correctamente.");
            pro_CargarDetalles(iIdRoomUltimo);
            pro_LimpiarCampos2();
        }

        // ✅ EDITAR
        private void pro_Btn_editar_plato_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(Txt_ID_Pedido.Text, out int iIdRoom))
            {
                MessageBox.Show("Debe ingresar el ID del Room Service.");
                return;
            }

            if (string.IsNullOrEmpty(Txt_ID_Pedido.Text))
            {
                MessageBox.Show("Seleccione un detalle para editar.");
                return;
            }

            if (!int.TryParse(Txt_Cantidad.Text, out int iCantidad) || iCantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida.");
                return;
            }

            int iIdDetalle = Convert.ToInt32(Txt_ID_Pedido.Text);
            int iIdMenu = Convert.ToInt32(Cbo_Menu.SelectedValue);

            pControlador.pro_ActualizarDetalle(iIdDetalle, iIdRoom, iIdMenu, iCantidad);

            MessageBox.Show("Detalle actualizado correctamente.");
            pro_CargarDetalles(iIdRoomUltimo);
            pro_LimpiarCampos2();
        }

        // ✅ ELIMINAR
        private void pro_Btn_eliminar_Plato_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_ID_Pedido.Text))
            {
                MessageBox.Show("Seleccione un detalle para eliminar.");
                return;
            }

            int iIdDetalle = Convert.ToInt32(Txt_ID_Pedido.Text);
            pControlador.pro_BorrarDetalle(iIdDetalle);

            MessageBox.Show("Detalle eliminado correctamente.");
            pro_CargarDetalles(iIdRoomUltimo);
            pro_LimpiarCampos2();
        }

        // ✅ Cargar datos del DataGridView en los controles
        private void pro_Dgv_Platos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignorar clics en encabezado
            if (e.RowIndex < 0) return;

            var dRow = Dgv_Platos.Rows[e.RowIndex];

            // Comprobar que la celda no sea nula
            if (dRow.Cells["Cmp_Nombre_Platillo"].Value != null)
                Cbo_Menu.Text = dRow.Cells["Cmp_Nombre_Platillo"].Value.ToString();

            if (dRow.Cells["Cmp_Cantidad"].Value != null)
                Txt_Cantidad.Text = dRow.Cells["Cmp_Cantidad"].Value.ToString();

            if (dRow.Cells["Cmp_Precio_Unitario"].Value != null)
                Txt_PrecioUni.Text = dRow.Cells["Cmp_Precio_Unitario"].Value.ToString();

            if (dRow.Cells["Cmp_Subtotal"].Value != null)
                Txt_Subtotal.Text = dRow.Cells["Cmp_Subtotal"].Value.ToString();
        }

        // ✅ Limpiar
        private void pro_LimpiarCampos2()
        {
            Txt_ID_Pedido.Text = "";
            Cbo_Menu.SelectedIndex = -1;
            Txt_Cantidad.Text = "";
            Txt_PrecioUni.Text = "";
            Txt_Subtotal.Text = "";
        }

        private void pro_Txt_ID_Pedido_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(Txt_ID_Pedido.Text, out int iIdRoomUltimo))
            {
                pro_CargarDetalles(iIdRoomUltimo);
            }
        }

        private void pro_button1_Click(object sender, EventArgs e)
        {
            Frm_Produccion_Alacarta frmNuevo = new Frm_Produccion_Alacarta();
            frmNuevo.Show();
        }

        private void pro_Btn_Reporte_Click(object sender, EventArgs e)
        {
            Frm_Reporte frm = new Frm_Reporte();
            frm.Show();
        }

        private void Txt_Id_Huesped_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números en este campo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Txt_Id_Habitacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números en este campo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Txt_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números en este campo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Txt_ID_Pedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números en este campo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

