using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Capa_Controlador_CPR;

namespace Capa_Vista_CPR
{
    public partial class Frm_Cierre_Produccion : Form
    {
        // Controlador principal
        private Cls_Cierre_Produccion_Controlador controlador = new Cls_Cierre_Produccion_Controlador();

        public Frm_Cierre_Produccion()
        {
            InitializeComponent();
            CargarTiposCierre(); // 🔹 Llenar ComboBox al iniciar
        }

        // ===============================================================
        // 🔹 CARGAR DATOS INICIALES
        // ===============================================================
        private void CargarTiposCierre()
        {
            try
            {
                DataTable tipos = controlador.ObtenerTiposCierre();
                Cbo_Tipo_Cierre.DataSource = tipos;
                Cbo_Tipo_Cierre.DisplayMember = "Cmp_Tipo_Cierre";
                Cbo_Tipo_Cierre.ValueMember = "PK_Id_Tipo_Cierre";
                Cbo_Tipo_Cierre.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tipos de cierre: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===============================================================
        // 🔹 BOTÓN: GENERAR CIERRE AUTOMÁTICO
        // ===============================================================
        private void Btn_Generar_Cierre_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaSeleccionada = Dtp_Fecha_cierre.Value.Date;

                decimal ingresos, egresos, total;
                (ingresos, egresos, total) = controlador.CalcularTotales(fechaSeleccionada);

                Txt_ingresos.Text = "Q " + ingresos.ToString("N2");
                Txt_egresos.Text = "Q " + egresos.ToString("N2");
                Txt_cierre_total.Text = "Q " + total.ToString("N2");

                // 🔍 debug opcional
                // MessageBox.Show($"Ingresos: {ingresos}\nEgresos: {egresos}\nTotal: {total}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falló el cálculo del cierre:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // ===============================================================
        //BOTÓN: GUARDAR CIERRE EN BD
        // ===============================================================
        private void Btn_guardar_cierre_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos
                if (!controlador.ValidarCamposCierre(Dtp_Fecha_cierre.Value, Txt_Descripcion.Text,
                    Cbo_Tipo_Cierre.SelectedIndex + 1, out string mensaje))
                {
                    MessageBox.Show(mensaje, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener valores limpios (sin 'Q ')
                decimal ingresos = decimal.Parse(Txt_ingresos.Text.Replace("Q", "").Trim());
                decimal egresos = decimal.Parse(Txt_egresos.Text.Replace("Q", "").Trim());
                decimal total = decimal.Parse(Txt_cierre_total.Text.Replace("Q", "").Trim());

                var resultado = controlador.GuardarCierre(
                    Dtp_Fecha_cierre.Value,
                    Txt_Descripcion.Text.Trim(),
                    Convert.ToInt32(Cbo_Tipo_Cierre.SelectedValue),
                    ingresos,
                    egresos,
                    total
                );

                if (resultado.exito)
                {
                    MessageBox.Show(resultado.mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(resultado.mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Debe generar el cierre antes de guardarlo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el cierre: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===============================================================
        // 🔹 MÉTODO: LIMPIAR CAMPOS DEL FORMULARIO
        // ===============================================================
        private void LimpiarCampos()
        {
            Dtp_Fecha_cierre.Value = DateTime.Today;
            Cbo_Tipo_Cierre.SelectedIndex = -1;
            Txt_Descripcion.Clear();
            Txt_ingresos.Clear();
            Txt_egresos.Clear();
            Txt_cierre_total.Clear();
        }

        // ===============================================================
        // 🔹 EVENTOS OPCIONALES (por ahora vacíos, los completaremos luego)
        // ===============================================================
        private void Dtp_Fecha_cierre_ValueChanged(object sender, EventArgs e) { }

        private void Cbo_Tipo_Cierre_SelectedIndexChanged(object sender, EventArgs e) { }

        private void Txt_Descripcion_TextChanged(object sender, EventArgs e) { }

        private void Txt_ingresos_TextChanged(object sender, EventArgs e) { }

        private void Txt_egresos_TextChanged(object sender, EventArgs e) { }

        private void Txt_cierre_total_TextChanged(object sender, EventArgs e) { }

        private void Btn_agregar_Cierre_Click(object sender, EventArgs e) { }

        private void Btn_eliminar_cierre_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaCierre = Dtp_Fecha_cierre.Value.Date;

                DialogResult confirmacion = MessageBox.Show(
                    "¿Está seguro de que desea eliminar el cierre del día " + fechaCierre.ToString("dd/MM/yyyy") + "?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacion == DialogResult.Yes)
                {
                    var resultado = controlador.EliminarCierre(fechaCierre);

                    if (resultado.exito)
                    {
                        MessageBox.Show(resultado.mensaje, "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 🔄 Limpia los campos en pantalla
                        Txt_ingresos.Text = "Q 0.00";
                        Txt_egresos.Text = "Q 0.00";
                        Txt_cierre_total.Text = "Q 0.00";
                        Txt_Descripcion.Text = "";
                    }
                    else
                    {
                        MessageBox.Show(resultado.mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar eliminar el cierre: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Btn_limpiar_cierre_Click(object sender, EventArgs e)
        {

        }
    }
}

