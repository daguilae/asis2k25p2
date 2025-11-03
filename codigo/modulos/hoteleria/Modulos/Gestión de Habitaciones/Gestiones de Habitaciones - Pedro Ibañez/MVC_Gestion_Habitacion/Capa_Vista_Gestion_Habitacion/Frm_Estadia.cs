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
        private decimal tarifaPorNoche = 350.00m; // Valor fijo

        public Frm_Estadia()
        {
            InitializeComponent(); 

            // Asociar eventos a los DateTimePicker
            DTP_Check_in.ValueChanged += new EventHandler(CalcularMontoTotal);
            DTP_CheckOut.ValueChanged += new EventHandler(CalcularMontoTotal);
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

                decimal montoTotal = diasEstadia * tarifaPorNoche;
                lbl_montoTotal.Text = $"Q {montoTotal:N2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular monto total: " + ex.Message);
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            int idEstadia = int.Parse(txt_pk_id_estadia.Text);
            //int idHabitacion = int.Parse(Cbo_fk_Id_Habitacion.Text.ToString());
            //int idHuesped = int.Parse(Cbo_Id_Huesped.Text.ToString());
            int idHabitacion = int.Parse(txt_Id_Habitacion.Text);
            int idHuesped = int.Parse(txt_ID_Huesped.Text);

            int numHuespedes = int.Parse(txt_Num_Huespedes.Text);
            bool tieneReserva = Chk_TieneReservación.Checked;
            DateTime fechaCheckIn = DTP_Check_in.Value;
            DateTime fechaActual = DTP_CheckOut.Value;
            decimal montoTotal = decimal.Parse(lbl_montoTotal.Text.Replace("Q", "").Trim());

            Cls_Controlador_GesHab controlador = new Cls_Controlador_GesHab();

            if (Estado_Crud == 1)
            {
                bool exito = controlador.InsertarEstadiaVerificada(
                    idHabitacion,
                    idHuesped,
                    numHuespedes,
                    tieneReserva,
                    fechaCheckIn,
                    fechaActual,
                    montoTotal
                );

                if (exito)
                {
                    MessageBox.Show(" Estadía registrada correctamente.", "Éxito");
                }
                else
                {
                    MessageBox.Show(" Error al registrar la estadía. Verifique los datos.", "Advertencia");
                }
                Estado_Crud = 1;
                btn_modificar.Enabled = true;
            }
            else
            {
              bool exito = controlador.ModificarEstadiaVerificada(
                idEstadia,
                idHabitacion,
                idHuesped,
                numHuespedes,
                tieneReserva,
                fechaCheckIn,
                fechaActual,
                montoTotal
            );

                if (exito)
                {
                    MessageBox.Show(" Registro actualizado correctamente.", "Éxito");
                }
                else
                {
                    MessageBox.Show(" No se pudo actualizar la estadía.", "Advertencia");
                }
                Estado_Crud = 1;
                btn_modificar.Enabled = true;
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
            int idEstadia = int.Parse(txt_pk_id_estadia.Text.Trim());
            bool exito = controlador.EliminarEstadia(idEstadia);
            if (exito)
            {
                MessageBox.Show("Registro eliminado correctamente.", "Éxito");
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el registro o no existe.", "Advertencia");
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Owner.Close();
        }
    }
}
