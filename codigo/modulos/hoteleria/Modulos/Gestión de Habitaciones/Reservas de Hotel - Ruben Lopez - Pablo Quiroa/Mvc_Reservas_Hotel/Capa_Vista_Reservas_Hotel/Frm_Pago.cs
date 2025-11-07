using System;
using System.Data;
using System.Windows.Forms;
using Capa_Controlador_Reservas_Hotel;

namespace Capa_Vista_Reservas_Hotel
{
    public partial class Frm_Pago : Form
    {
        private readonly Cls_Pago_Controlador Controlador = new Cls_Pago_Controlador();

        public Frm_Pago()
        {
            InitializeComponent();
            CargarFolios();
            CargarMetodosPago();
            CargarEstadosPago();
        }

    
        // === MÉTODOS DE APOYO ===
    
        private void CargarFolios()
        {
            try
            {
                DataTable dt = Controlador.datObtenerFolios();
                Cbo_Folio.DataSource = dt;
                Cbo_Folio.DisplayMember = "DescripcionFolio";
                Cbo_Folio.ValueMember = "Pk_Id_Folio";
                Cbo_Folio.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar folios: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarMetodosPago()
        {
            Cbo_MetodoPago.Items.Clear();
            Cbo_MetodoPago.Items.Add("Tarjeta");
            Cbo_MetodoPago.Items.Add("Efectivo");
            Cbo_MetodoPago.Items.Add("Transferencia");
            Cbo_MetodoPago.Items.Add("Cheque");
            Cbo_MetodoPago.SelectedIndex = -1;
        }

        private void CargarEstadosPago()
        {
            Cbo_Estado.Items.Clear();
            Cbo_Estado.Items.Add("Pendiente");
            Cbo_Estado.Items.Add("Pagado");
            Cbo_Estado.Items.Add("Cancelado");
            Cbo_Estado.SelectedIndex = -1;
        }

        private void LimpiarCampos()
        {
            Cbo_Folio.SelectedIndex = -1;
            Cbo_MetodoPago.SelectedIndex = -1;
            Cbo_Estado.SelectedIndex = -1;
            Txt_Monto.Clear();
            Dtp_Fecha_Pago.Value = DateTime.Now;
        }

       
        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cbo_Folio.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar un folio asociado.", "Advertencia",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (Cbo_MetodoPago.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un método de pago.", "Advertencia",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (Cbo_Estado.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un estado del pago.", "Advertencia",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idFolio = Convert.ToInt32(Cbo_Folio.SelectedValue);
                string metodo = Cbo_MetodoPago.SelectedItem.ToString();
                string estado = Cbo_Estado.SelectedItem.ToString();
                DateTime fecha = Dtp_Fecha_Pago.Value;
                decimal monto = decimal.TryParse(Txt_Monto.Text, out decimal val) ? val : 0;

               
                int idPago = Controlador.funInsertarPago(idFolio, metodo, fecha, monto, estado);

                if (idPago <= 0)
                {
                    MessageBox.Show("No se pudo registrar el pago principal.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Pago registrado correctamente. Complete los detalles en el subformulario.",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                AbrirSubformulario(metodo, idPago, monto);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el pago: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La modificación de pagos se gestionará en módulos de detalle.",
                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void Cbo_Folio_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Cbo_Folio.SelectedItem is DataRowView row &&
                    row.DataView.Table.Columns.Contains("Cmp_Saldo_Final"))
                {
                    Txt_Monto.Text = Convert.ToDecimal(row["Cmp_Saldo_Final"]).ToString("0.00");
                }
            }
            catch
            {
                Txt_Monto.Clear();
            }
        }

        private void Cbo_Estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Validación dentro de cada subformulario
        }

        private void Cbo_MetodoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ya no abrimos el subformulario aquí, solo lo hacemos después de guardar
        }

        private void Dtp_Fecha_Pago_ValueChanged(object sender, EventArgs e)
        {
            // Sin lógica adicional
        }

        private void Txt_Monto_TextChanged(object sender, EventArgs e)
        {
            // Sin validación adicional
        }

     
        // === MÉTODO: ABRIR SUBFORMULARIOS (con monto)
        
        private void AbrirSubformulario(string metodo, int idPago, decimal monto)
        {
            switch (metodo)
            {
                case "Tarjeta":
                    new Frm_Pago_Tarjeta(idPago, monto).ShowDialog();
                    break;

                case "Efectivo":
                    new Frm_Pago_Efectivo(idPago, monto).ShowDialog();
                    break;

                case "Transferencia":
                    new Frm_Pago_Transferencia(idPago, monto).ShowDialog();
                    break;

                case "Cheque":
                    new Frm_Pago_Cheque(idPago, monto).ShowDialog();
                    break;
            }
        }
    }
}
