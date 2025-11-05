// =============================================================
// Capa_Vista_Creacion_Nomina
// Clase: Frm_Creacion_Nomina
// Autor: Fredy Reyes Sabán
// Carné: 0901-22-9800
// Fecha: 29/10/2025
// =============================================================

using System;
using System.Windows.Forms;
using Capa_Controlador_Creacion_Nomina;

namespace Capa_Vista_Creacion_Nomina
{
    public partial class Frm_Creacion_Nomina : Form
    {
        // Instancia del controlador
        private Cls_Controlador_Creacion_Nomina clsControlador = new Cls_Controlador_Creacion_Nomina();

        public Frm_Creacion_Nomina()
        {
            InitializeComponent();
        }

        // ==========================================================
        // EVENTOS DEL FORMULARIO
        // ==========================================================

        private void Frm_Creacion_Nomina_Load(object sender, EventArgs e)
        {
            // Cargar tipos de nómina en el ComboBox al iniciar
            Cbo_tipo.Items.Add("Mensual");
            Cbo_tipo.Items.Add("Quincenal");
            Cbo_tipo.Items.Add("Semanal");
            Cbo_tipo.SelectedIndex = 0; // Selecciona la primera opción
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e) { }

        // ==========================================================
        // EVENTO DEL BOTÓN: CREAR NÓMINA
        // ==========================================================

        // Inicio de código de: Fredy Reyes Sabán en la fecha de: 29/10/2025
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Captura de valores desde el formulario
                DateTime dPeriodoInicio = Dtp_fecha_inicio.Value;
                DateTime dPeriodoFin = Dtp_fecha_fin.Value;
                string sTipo = Cbo_tipo.SelectedItem.ToString();
                DateTime dFechaGeneracion = DateTime.Now;

                // Validación simple
                if (dPeriodoFin < dPeriodoInicio)
                {
                    MessageBox.Show(
                        "La fecha final no puede ser menor a la fecha inicial.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                // Llamada al controlador

                try
                {
                    string sEstado = "PENDIENTE";
                    clsControlador.proInsertarNomina(dPeriodoInicio, dPeriodoFin, sTipo, sEstado);
                    MessageBox.Show("Nómina creada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo crear la nómina: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al crear la nómina: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        // Fin de código de: Fredy Reyes Sabán en la fecha de: 29/10/2025
    }
}
