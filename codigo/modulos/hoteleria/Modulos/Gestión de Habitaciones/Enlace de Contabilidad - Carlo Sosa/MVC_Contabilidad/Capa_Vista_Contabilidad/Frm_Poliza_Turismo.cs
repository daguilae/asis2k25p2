using Capa_Controlador_Contabilidad;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace Capa_Vista_Contabilidad
{
    public partial class Frm_Poliza_Turismo : Form
    {
        Ctr_Poliza_Turismo cControlador = new Ctr_Poliza_Turismo();

        public Frm_Poliza_Turismo()
        {
            InitializeComponent();
            CargarIdPoliza();
            Txt_Fecha_Generales.Text = DateTime.Now.ToString("dd/MM/yyyy");
            Btn_Aceptar.Click += Btn_Aceptar_Click;
            Btn_Cancelar.Click += Btn_Cancelar_Click;
        }

        private void CargarIdPoliza()
        {
            try
            {
                int nuevoId = cControlador.ObtenerSiguienteId(DateTime.Now);
                Txt_ID_Poliza.Text = nuevoId.ToString();
            }
            catch
            {
                Txt_ID_Poliza.Text = "0";
            }
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaInicio = DateTime.ParseExact(Txt_fecha_Rango.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime fechaFin = DateTime.ParseExact(Txt_Fecha_Rango2.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime fechaPoliza = DateTime.Now;
                string concepto = Txt_Concepto.Text.Trim();

                if (fechaInicio > fechaFin)
                {
                    MessageBox.Show("La fecha inicial no puede ser mayor a la final.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(concepto))
                {
                    MessageBox.Show("Debe ingresar un concepto para la póliza.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int filas = cControlador.ContarEstadias(fechaInicio, fechaFin);
                if (filas == 0)
                {
                    MessageBox.Show("No hay estadías registradas en el rango seleccionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                bool resultado = cControlador.TrasladarPolizaTurismo(fechaInicio, fechaFin, fechaPoliza, concepto);

                if (resultado)
                {
                    MessageBox.Show("Póliza trasladada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Txt_fecha_Rango.Text = "";
                    Txt_Fecha_Rango2.Text = "";
                    Txt_Fecha_Generales.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    Txt_Concepto.Text = "";

                    int nuevoId = cControlador.ObtenerSiguienteId(DateTime.Now);
                    Txt_ID_Poliza.Text = nuevoId.ToString();
                }
                else
                {
                    MessageBox.Show("No hay datos para trasladar o ocurrió un error.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al trasladar póliza: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


