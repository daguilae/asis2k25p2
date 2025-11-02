using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Check_In_Check_Out;

namespace Capa_vista_Check_In_Check_out
{
    public partial class Frm_Check_In : Form
    {
        private readonly Cls_Check_In_Controlador Controlador = new Cls_Check_In_Controlador();
        private int idHabitacionSeleccionada = 0;
        public Frm_Check_In()
        {
            InitializeComponent();
            fun_CargarCombos();
            fun_CargarEstados();
            fun_CargarTabla();
            fun_configuracion_inicial();
        }

        public void fun_configuracion_inicial()
        {
            Btn_guardar.Enabled = false; ;
            Btn_Modificar.Enabled = false;
          
            Btn_Nuevo.Enabled = true;
        }
        private void fun_CargarCombos()
        {
            try
            {
                // ComboBox de Huéspedes
                Cbo_Huesped.DataSource = Controlador.datObtenerHuespedes();
                Cbo_Huesped.DisplayMember = "NombreCompleto";
                Cbo_Huesped.ValueMember = "Pk_Id_Huesped";
                Cbo_Huesped.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combos: " + ex.Message);
            }
        }


        private void fun_CargarEstados()
        {
            Cbo_Estado.Items.Clear();
            Cbo_Estado.Items.Add("Activo");
            Cbo_Estado.Items.Add("Finalizado");
            Cbo_Estado.Items.Add("Cancelado");
            Cbo_Estado.SelectedIndex = 0;
        }

        private void fun_CargarTabla()
        {
            try
            {
                Dgv_Check_In.DataSource = Controlador.MostrarCheckIn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tabla: " + ex.Message);
            }
        }





        private void fun_LimpiarCampos()
        {
            Txt_Id_Check_In.Clear();
            Cbo_Huesped.SelectedIndex = -1;
            Cbo_Reservas.SelectedIndex = -1;
            Cbo_Estado.SelectedIndex = 0;
            Dtp_Fecha.Value = DateTime.Now;
        }

        private void Cbo_Huesped_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Cbo_Huesped.SelectedValue == null || Cbo_Huesped.SelectedValue is DataRowView)
                return;

            try
            {

                Cbo_Reservas.DataSource = null;
                Cbo_Reservas.Items.Clear();
                Cbo_Reservas.Text = string.Empty;

                int idHuesped = Convert.ToInt32(Cbo_Huesped.SelectedValue);

                DataTable dtReservas = Controlador.datObtenerReservaPorHuesped(idHuesped);


                Cbo_Reservas.DataSource = dtReservas;
                Cbo_Reservas.DisplayMember = "DescripcionReserva";
                Cbo_Reservas.ValueMember = "Pk_Id_Reserva";
                Cbo_Reservas.SelectedIndex = dtReservas.Rows.Count > 0 ? 0 : -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar reservas del huésped: " + ex.Message);
            }
        }

        private void Dgv_Check_In_CellClick(object sender, DataGridViewCellEventArgs e)

        {
            Btn_guardar.Enabled = false; ;
            Btn_Modificar.Enabled = true;
           
            Btn_Nuevo.Enabled = false;
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow fila = Dgv_Check_In.Rows[e.RowIndex];

                    Txt_Id_Check_In.Text = fila.Cells["Pk_Id_Check_in"].Value.ToString();


                    if (fila.Cells["Fk_Id_Huesped"].Value != null)
                        Cbo_Huesped.SelectedValue = Convert.ToInt32(fila.Cells["Fk_Id_Huesped"].Value);


                    if (Cbo_Huesped.SelectedValue != null && !(Cbo_Huesped.SelectedValue is DataRowView))
                    {
                        int idHuesped = Convert.ToInt32(Cbo_Huesped.SelectedValue);
                        DataTable dtReservas = Controlador.datObtenerReservaPorHuesped(idHuesped);
                        Cbo_Reservas.DataSource = dtReservas;
                        Cbo_Reservas.DisplayMember = "DescripcionReserva";
                        Cbo_Reservas.ValueMember = "Pk_Id_Reserva";
                    }


                    if (fila.Cells["Fk_Id_Reserva"].Value != null)
                        Cbo_Reservas.SelectedValue = Convert.ToInt32(fila.Cells["Fk_Id_Reserva"].Value);

                    Dtp_Fecha.Value = Convert.ToDateTime(fila.Cells["Cmp_Fecha_Check_In"].Value);
                    Cbo_Estado.SelectedItem = fila.Cells["Cmp_Estado"].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos desde la tabla: " + ex.Message);
                }
            }
        }



        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    
                    if (Cbo_Huesped.SelectedIndex == -1 || Cbo_Reservas.SelectedIndex == -1)
                    {
                        MessageBox.Show("Debe seleccionar un huésped y una reserva válida.",
                                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                   
                    int idHuesped = Convert.ToInt32(Cbo_Huesped.SelectedValue);
                    int idReserva = Convert.ToInt32(Cbo_Reservas.SelectedValue);
                    DateTime fecha = Dtp_Fecha.Value;
                    string estado = Cbo_Estado.SelectedItem.ToString();

                   
                    if (idHabitacionSeleccionada == 0)
                    {
                        MessageBox.Show("No se encontró una habitación asociada a esta reserva.",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                   
                    bool exito = Controlador.RegistrarCheckInConFolio(
                        idHuesped,
                        idReserva,
                        fecha,
                        estado,
                        idHabitacionSeleccionada
                    );

                   
                    if (exito)
                    {
                       
                                       
                        fun_CargarTabla();
                        fun_LimpiarCampos();
                        idHabitacionSeleccionada = 0;
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al registrar el Check-In con Folio.",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar: " + ex.Message,
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
            



        

        private void Btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Txt_Id_Check_In.Text))
                {
                    MessageBox.Show("Seleccione un registro para modificar.");
                    return;
                }

                int idCheckIn = Convert.ToInt32(Txt_Id_Check_In.Text);
                int idHuesped = Convert.ToInt32(Cbo_Huesped.SelectedValue);
                int idReserva = Convert.ToInt32(Cbo_Reservas.SelectedValue);
                DateTime fecha = Dtp_Fecha.Value;
                string estado = Cbo_Estado.SelectedItem.ToString();

                if (Controlador.bActualizarCheckIn(idCheckIn, idHuesped, idReserva, fecha, estado, out string mensaje))
                {
                    MessageBox.Show("check-In modificado correctamente");
                    fun_CargarTabla();
                    fun_LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(" " + mensaje);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex.Message);
            }
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            fun_LimpiarCampos();
            Btn_guardar.Enabled = true; ;
            Btn_Modificar.Enabled = false;
   
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            fun_LimpiarCampos();
            fun_configuracion_inicial();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cbo_Reservas_SelectedIndexChanged(object sender, EventArgs e)
        {

            {
                if (Cbo_Reservas.SelectedValue == null || Cbo_Reservas.SelectedValue is DataRowView)
                    return;

                try
                {
                    int idReserva = Convert.ToInt32(Cbo_Reservas.SelectedValue);


                    idHabitacionSeleccionada = Controlador.ObtenerHabitacionPorReserva(idReserva);

                    if (idHabitacionSeleccionada > 0)
                    {
                        Console.WriteLine($"Habitación vinculada a la reserva: {idHabitacionSeleccionada}");
                    }
                    else
                    {
                        MessageBox.Show("Esta reserva no tiene una habitación asignada.",
                                        "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener la habitación: " + ex.Message);
                }
            }

        }
    }
}
    
    


