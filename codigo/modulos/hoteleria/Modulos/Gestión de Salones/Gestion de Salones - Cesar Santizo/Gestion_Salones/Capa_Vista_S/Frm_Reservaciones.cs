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

               
                DataTable dtMenu = cControlador.ObtenerMenusDisponibles();
                Cbo_Menu.DataSource = dtMenu;
                Cbo_Menu.DisplayMember = "Cmp_Nombre_Platillo";
                Cbo_Menu.ValueMember = "Pk_Id_Menu";
                Cbo_Menu.SelectedIndex = -1;

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

                  
                    if (Dvg_Reservaciones.Columns.Contains("Cmp_Menu"))
                        Dvg_Reservaciones.Columns["Cmp_Menu"].HeaderText = "Menú";

                    if (Dvg_Reservaciones.Columns.Contains("Cmp_Cantidad_Platillos"))
                        Dvg_Reservaciones.Columns["Cmp_Cantidad_Platillos"].HeaderText = "Cantidad Platillos";
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

                // 🔹 Guardar la reservación y obtener el ID
                int iIdReservaGenerado = cControlador.GuardarReservaSalonYObtenerID(
                    iIdHuesped, iIdSalon, dFecha, dHoraInicio, dHoraFin, iCapacidad, deMonto
                );

                if (Cbo_Menu.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(Txt_Cantidad.Text))
                {
                    int iIdMenu = Convert.ToInt32(Cbo_Menu.SelectedValue);
                    int iCantidad = Convert.ToInt32(Txt_Cantidad.Text);
                    cControlador.GuardarPedidoMenu(iIdReservaGenerado, iIdMenu, iCantidad);
                }


                MessageBox.Show("Reservación y pedido guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarGrid();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la reserva: " + ex.Message);
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

                if (!bValidarCampos()) return;

                int iIdHuesped = Convert.ToInt32(Cbo_Huesped.SelectedValue);
                int iIdSalon = Convert.ToInt32(Cbo_Salon.SelectedValue);
                DateTime dFecha = Dtp_Fecha.Value;
                TimeSpan dHoraInicio = Dtp_Inicio.Value.TimeOfDay;
                TimeSpan dHoraFin = Dtp_Fin.Value.TimeOfDay;
                int iCapacidad = Convert.ToInt32(Txt_capacidad.Text);
                decimal deMonto = Convert.ToDecimal(Txt_Monto.Text);

                cControlador.ModificarReservaSalon(iCodigoReserva, iIdHuesped, iIdSalon, dFecha, dHoraInicio, dHoraFin, iCapacidad, deMonto);

                // 🔹 Actualizar pedido del menú
                if (Cbo_Menu.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(Txt_Cantidad.Text))
                {
                    int iIdMenu = Convert.ToInt32(Cbo_Menu.SelectedValue);
                    int iCantidad = Convert.ToInt32(Txt_Cantidad.Text);
                    cControlador.ModificarPedidoMenu(iCodigoReserva, iIdMenu, iCantidad);
                }

                MessageBox.Show("Reservación y pedido actualizados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                DialogResult dr = MessageBox.Show("¿Desea eliminar esta reservación y su pedido?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    cControlador.EliminarPedidoMenu(iCodigoReserva);
                    cControlador.EliminarReservaSalon(iCodigoReserva);
                    MessageBox.Show("Reservación y pedido eliminados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarGrid();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la reserva: " + ex.Message);
            }
        }



        private void Dvg_Reservaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                DataGridViewRow drFila = Dvg_Reservaciones.Rows[e.RowIndex];

                iCodigoReserva = Convert.ToInt32(drFila.Cells["Pk_Id_Reserva_Salon"].Value);
                Cbo_Huesped.SelectedValue = drFila.Cells["Fk_Id_Huesped"].Value ?? -1;
                Cbo_Salon.SelectedValue = drFila.Cells["Fk_Id_Salon"].Value ?? -1;
                Dtp_Fecha.Value = Convert.ToDateTime(drFila.Cells["Cmp_Fecha_Reserva"].Value);
                Dtp_Inicio.Value = DateTime.Today.Add(TimeSpan.Parse(drFila.Cells["Cmp_Hora_Inicio"].Value.ToString()));
                Dtp_Fin.Value = DateTime.Today.Add(TimeSpan.Parse(drFila.Cells["Cmp_Hora_Fin"].Value.ToString()));
                Txt_capacidad.Text = drFila.Cells["Cmp_Cantidad_Personas"].Value?.ToString() ?? "";
                Txt_Monto.Text = drFila.Cells["Cmp_Monto_Total"].Value?.ToString() ?? "";
                if (Dvg_Reservaciones.Columns.Contains("Fk_Id_Promociones"))
                    Cbo_Promocion.SelectedValue = drFila.Cells["Fk_Id_Promociones"].Value ?? -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar la fila: " + ex.Message);
            }
        }

        

        private void folioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_FolioRes fNuevoFormulario = new Frm_FolioRes();
            fNuevoFormulario.Show();
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

        private void Btn_Reportes_Click(object sender, EventArgs e)
        {
            Frm_Reportes_Reservacion nuevo = new Frm_Reportes_Reservacion();
            nuevo.Show();
        }

        private void salonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Salones fNuevoFormulario = new Frm_Salones();
            fNuevoFormulario.Show();
        }

        private void Lbl_Capacidad_Click(object sender, EventArgs e)
        {

        }

     
        

    }
}
