using System;
using System.Data;
using System.Windows.Forms;
using Capa_Controlador_Reservas_Hotel;

namespace Capa_Vista_Reservas_Hotel
{
    public partial class Frm_Pago : Form
    {
        private readonly Cls_Pago_Controlador controlador = new Cls_Pago_Controlador();
        private int idPagoSeleccionado = 0;

        public Frm_Pago()
        {
            InitializeComponent();
            this.Load += Frm_Pago_Load;
        }

        // ==================== EVENTO LOAD ====================
        private void Frm_Pago_Load(object sender, EventArgs e)
        {
            CargarFolios();
            CargarCombos();
            Dtp_Fecha_Pago.Value = DateTime.Today;
        }

        private void CargarFolios()
        {
            try
            {
                DataTable dt = controlador.ObtenerFolios();
                Cbo_Folio.DataSource = dt;
                Cbo_Folio.DisplayMember = "Cmp_Estado";
                Cbo_Folio.ValueMember = "Pk_Id_Folio";
                Cbo_Folio.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar folios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCombos()
        {
            Cbo_MetodoPago.Items.Clear();
            Cbo_MetodoPago.Items.AddRange(new[] { "Tarjeta", "Efectivo", "Transferencia", "Cheque" });

            Cbo_Estado.Items.Clear();
            Cbo_Estado.Items.AddRange(new[] { "Pagado", "Pendiente", "Cancelado" });

            Cbo_MetodoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbo_Estado.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        // ==================== BOTÓN NUEVO ====================
        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // ==================== BOTÓN GUARDAR ====================
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cbo_MetodoPago.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un método de pago.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int folio = Convert.ToInt32(Cbo_Folio.SelectedValue);
                string metodo = Cbo_MetodoPago.Text.Trim();
                DateTime fecha = Dtp_Fecha_Pago.Value;
                string monto = Txt_Monto.Text.Trim();
                string estado = Cbo_Estado.Text.Trim();

                controlador.GuardarPago(folio, metodo, fecha, monto, estado);
                MessageBox.Show("Pago registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Obtener el ID del pago recién insertado
                int idGenerado = controlador.ObtenerUltimoPagoId();

                // Limpiar el formulario principal
                LimpiarCampos();

                // Abrir el formulario específico del método seleccionado
                AbrirFormularioMetodo(metodo, idGenerado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==================== BOTÓN MODIFICAR ====================
        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idPagoSeleccionado == 0)
                {
                    MessageBox.Show("Seleccione un pago para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int folio = Convert.ToInt32(Cbo_Folio.SelectedValue);
                string metodo = Cbo_MetodoPago.Text.Trim();
                DateTime fecha = Dtp_Fecha_Pago.Value;
                string monto = Txt_Monto.Text.Trim();
                string estado = Cbo_Estado.Text.Trim();

                controlador.ModificarPago(idPagoSeleccionado, folio, metodo, fecha, monto, estado);
                MessageBox.Show("Pago actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==================== BOTÓN LIMPIAR ====================
        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            Cbo_Folio.SelectedIndex = -1;
            Cbo_MetodoPago.SelectedIndex = -1;
            Cbo_Estado.SelectedIndex = -1;
            Txt_Monto.Clear();
            Dtp_Fecha_Pago.Value = DateTime.Today;
            idPagoSeleccionado = 0;
        }

        // ==================== EVENTOS DE CONTROLES ====================
        private void Cbo_Folio_SelectedIndexChanged(object sender, EventArgs e) { }
        private void Cbo_Estado_SelectedIndexChanged(object sender, EventArgs e) { }
        private void Cbo_MetodoPago_SelectedIndexChanged(object sender, EventArgs e) { }
        private void Dtp_Fecha_Pago_ValueChanged(object sender, EventArgs e) { }
        private void Txt_Monto_TextChanged(object sender, EventArgs e) { }

        // ==================== ABRIR FORMULARIO SEGÚN MÉTODO ====================
        private void AbrirFormularioMetodo(string metodo, int idPago)
        {
            Form formulario = null;

            switch (metodo)
            {
                case "Tarjeta":
                    formulario = new Frm_Pago_Tarjeta(idPago);
                    break;

                case "Efectivo":
                    formulario = new Frm_Pago_Efectivo(idPago);
                    break;

                case "Transferencia":
                    formulario = new Frm_Pago_Transferencia(idPago);
                    break;

                case "Cheque":
                    formulario = new Frm_Pago_Cheque(idPago);
                    break;
            }

            if (formulario != null)
            {
                // Mostrar el formulario correspondiente al tipo de pago
                formulario.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se encontró el formulario correspondiente al método seleccionado.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
