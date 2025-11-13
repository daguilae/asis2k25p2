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
    public partial class Frm_FolioRes : Form
    {
        Cls_Controlador_S cControlador = new Cls_Controlador_S();
        private int iIdFolio = -1;

        public Frm_FolioRes()
        {
            InitializeComponent();
            CargarCombos();
            ActualizarGrid();
        }

        private void CargarCombos()
        {
            try
            {
                // 🔹 Cargar Reservas
                DataTable dtReservas = cControlador.ObtenerReservasSalones();
                Cbo_Reservacion.DataSource = dtReservas;
                Cbo_Reservacion.DisplayMember = "Cmp_Salon"; // O puedes mostrar más datos concatenados
                Cbo_Reservacion.ValueMember = "Pk_Id_Reserva_Salon";
                Cbo_Reservacion.SelectedIndex = -1;

                // 🔹 Cargar Estados
                Cbo_Estado.Items.Clear();
                Cbo_Estado.Items.AddRange(new string[] { "Pendiente", "Pagado", "Cancelado" });

                // 🔹 Cargar Métodos de pago
                Cbo_Metodo.Items.Clear();
                Cbo_Metodo.Items.AddRange(new string[] { "Efectivo", "Tarjeta", "Transferencia" });
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
                DataTable dtFolios = cControlador.ObtenerFoliosSalones(); // 🔸 lo agregamos en el controlador
                Dvg_Folios.DataSource = dtFolios;

                if (Dvg_Folios.Columns.Count > 0)
                {
                    Dvg_Folios.Columns["Pk_Id_Folio_Salones"].HeaderText = "ID Folio";
                    Dvg_Folios.Columns["Fk_Id_Reserva_Salon"].HeaderText = "Reserva";
                    Dvg_Folios.Columns["Cmp_Fecha_Pago"].HeaderText = "Fecha de Pago";
                    Dvg_Folios.Columns["Cmp_Pago_Total"].HeaderText = "Pago Total (Q)";
                    Dvg_Folios.Columns["Cmp_Estado"].HeaderText = "Estado";
                    Dvg_Folios.Columns["Cmp_Metodo_Pago"].HeaderText = "Método de Pago";
                }

                Dvg_Folios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                Dvg_Folios.MultiSelect = false;
                Dvg_Folios.ReadOnly = true;
                Dvg_Folios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el grid: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            Cbo_Reservacion.SelectedIndex = -1;
            Dtp_FechaPago.Value = DateTime.Now;
            Txt_PagoTotal.Clear();
            Cbo_Estado.SelectedIndex = -1;
            Cbo_Metodo.SelectedIndex = -1;
            iIdFolio = -1;
        }

        private bool bValidarCampos()
        {
            if (Cbo_Reservacion.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una reservación.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(Txt_PagoTotal.Text))
            {
                MessageBox.Show("Ingrese o confirme el pago total.");
                return false;
            }
            if (Cbo_Estado.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el estado del pago.");
                return false;
            }
            if (Cbo_Metodo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el método de pago.");
                return false;
            }
            return true;
        }

        private void GuardarFolio()
        {
            try
            {
                if (!bValidarCampos()) return;

                int iIdReserva = Convert.ToInt32(Cbo_Reservacion.SelectedValue);
                DateTime dFechaPago = Dtp_FechaPago.Value;
                decimal dePagoTotal = Convert.ToDecimal(Txt_PagoTotal.Text);
                string sEstado = Cbo_Estado.Text;
                string sMetodo = Cbo_Metodo.Text;

                cControlador.GuardarFolioSalon(iIdReserva, dFechaPago, dePagoTotal, sEstado, sMetodo);
                MessageBox.Show("Folio guardado correctamente.");

                ActualizarGrid();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el folio: " + ex.Message);
            }
        }

        private void ModificarFolio()
        {
            try
            {
                if (iIdFolio < 0)
                {
                    MessageBox.Show("Seleccione un folio para modificar.");
                    return;
                }

                if (!bValidarCampos()) return;

                DateTime dFechaPago = Dtp_FechaPago.Value;
                decimal dePagoTotal = Convert.ToDecimal(Txt_PagoTotal.Text);
                string sEstado = Cbo_Estado.Text;
                string sMetodo = Cbo_Metodo.Text;

                cControlador.ModificarFolioSalon(iIdFolio, dFechaPago, dePagoTotal, sEstado, sMetodo);
                MessageBox.Show("Folio modificado correctamente.");

                ActualizarGrid();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el folio: " + ex.Message);
            }
        }


        private void EliminarFolio()
        {
            try
            {
                if (iIdFolio < 0)
                {
                    MessageBox.Show("Seleccione un folio para eliminar.");
                    return;
                }

                DialogResult dr = MessageBox.Show("¿Desea eliminar este folio?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    cControlador.EliminarFolioSalon(iIdFolio);
                    MessageBox.Show("Folio eliminado correctamente.");
                    ActualizarGrid();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el folio: " + ex.Message);
            }
        }

        private void Cbo_Reservacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_Reservacion.SelectedValue != null && Cbo_Reservacion.SelectedValue is int)
            {
                int iIdReserva = Convert.ToInt32(Cbo_Reservacion.SelectedValue);
                decimal deMonto = cControlador.ObtenerMontoReserva(iIdReserva);
                Txt_PagoTotal.Text = deMonto.ToString("0.00");
            }
        }

        private void Dvg_Folios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = Dvg_Folios.Rows[e.RowIndex];
            Cbo_Reservacion.SelectedValue = fila.Cells["Fk_Id_Reserva_Salon"].Value;
            Dtp_FechaPago.Value = Convert.ToDateTime(fila.Cells["Cmp_Fecha_Pago"].Value);
            Txt_PagoTotal.Text = fila.Cells["Cmp_Pago_Total"].Value.ToString();
            Cbo_Estado.Text = fila.Cells["Cmp_Estado"].Value.ToString();
            Cbo_Metodo.Text = fila.Cells["Cmp_Metodo_Pago"].Value.ToString();
            iIdFolio = Convert.ToInt32(fila.Cells["Pk_Id_Folio_Salones"].Value);

        }


        private void Btn_guardar_Click_1(object sender, EventArgs e)
        {
            GuardarFolio();
        }

        private void Btn_eliminar_Click_1(object sender, EventArgs e)
        {
            EliminarFolio();
        }

        private void Btn_modificar_Click_1(object sender, EventArgs e)
        {
            ModificarFolio();
        }

        private void salonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Reservaciones fNuevoFormulario = new Frm_Reservaciones();
            fNuevoFormulario.Show();
        }
    }
}