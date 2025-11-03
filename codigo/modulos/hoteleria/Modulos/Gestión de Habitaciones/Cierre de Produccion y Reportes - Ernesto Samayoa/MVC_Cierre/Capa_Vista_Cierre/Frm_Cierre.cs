using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Cierre;

namespace Capa_Vista_Cierre
{
    public partial class Frm_Cierre : Form
    {
        // Controlador principal
        private readonly Cls_Cierre_Controlador ctrl = new Cls_Cierre_Controlador();
        private DataTable tablaFolios;
        private Cls_Cierre_Controlador.CierreResultado ultimoResultado;

        public Frm_Cierre()
        {
            InitializeComponent();
        }

        private void Btn_generar_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Delegar la lógica al controlador (MVC)
                string descripcion = Txt_Descripcion_Cierre.Text.Trim();
                DateTime fechaCorte = Dtp_Fecha_Cierre.Value;

                ultimoResultado = ctrl.GenerarCierre(fechaCorte, descripcion);

                // La vista solo presenta los datos devueltos y emite mensajes
                tablaFolios = ultimoResultado.Detalle;
                Dgv_Cierre_general.DataSource = tablaFolios;

                Txt_ingresos.Text = $"Q {ultimoResultado.Ingresos:N2}";
                Txt_egresos.Text = $"Q {ultimoResultado.Egresos:N2}";
                Txt_Saldo_total.Text = $"Q {ultimoResultado.Saldo:N2}";

                MessageBox.Show("Método GenerarCierre ejecutado correctamente.",
                                "Generar Cierre",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar cierre: " + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void Btn_guardar_cierre_Click(object sender, EventArgs e)
        {
            try
            {
                if (ultimoResultado == null || ultimoResultado.Detalle == null || ultimoResultado.Detalle.Rows.Count == 0)
                {
                    MessageBox.Show("Debe generar el cierre antes de guardarlo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime fecha = Dtp_Fecha_Cierre.Value;
                string descripcion = Txt_Descripcion_Cierre.Text.Trim();

                bool exito = ctrl.GuardarCierre(
                    fecha,
                    descripcion,
                    ultimoResultado.Ingresos,
                    ultimoResultado.Egresos,
                    ultimoResultado.Saldo,
                    ultimoResultado.Detalle
                );

                if (exito)
                {
                    MessageBox.Show("Método GuardarCierre ejecutado correctamente.", "Guardar Cierre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Txt_Descripcion_Cierre.Clear();
                    Txt_ingresos.Text = Txt_egresos.Text = Txt_Saldo_total.Text = "Q 0.00";
                    Dgv_Cierre_general.DataSource = null;
                    ultimoResultado = null;
                }
                else
                {
                    MessageBox.Show("Error al guardar cierre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("⚠Error al guardar cierre: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Agregar_cierre_Click(object sender, EventArgs e)
        {
            // Habilitar campos y botones
            HabilitarControles();

            // Limpiar datos previos (opcional)
            Txt_Descripcion_Cierre.Clear();
            Txt_ingresos.Text = "Q 0.00";
            Txt_egresos.Text = "Q 0.00";
            Txt_Saldo_total.Text = "Q 0.00";
            Dgv_Cierre_general.DataSource = null;

            // Colocar el foco en el campo descripción
            Txt_Descripcion_Cierre.Focus();
        }

        private void Frm_Cierre_Load(object sender, EventArgs e)
        {
            BloquearControles();
        }

        private void BloquearControles()
        {
            Dtp_Fecha_Cierre.Enabled = false;
            Txt_Descripcion_Cierre.Enabled = false;
            Txt_ingresos.Enabled = false;
            Txt_egresos.Enabled = false;
            Txt_Saldo_total.Enabled = false;
            Cbo_buscar.Enabled = false;

            Btn_generar.Enabled = false;
            Btn_guardar_cierre.Enabled = false;
            Btn_eliminar_cierre.Enabled = false;
            Btn_Buscar_cierre.Enabled = false;
            Btn_Imprimir_cierre_general.Enabled = false;
        }

 
        //HABILITAR CAMPOS Y BOTONES
        private void HabilitarControles()
        {
            Dtp_Fecha_Cierre.Enabled = true;
            Txt_Descripcion_Cierre.Enabled = true;
            Btn_generar.Enabled = true;
            Btn_guardar_cierre.Enabled = true;
            Btn_eliminar_cierre.Enabled = true;
            Btn_Buscar_cierre.Enabled = true;
            Btn_Imprimir_cierre_general.Enabled = true;
        }

        private void Btn_eliminar_cierre_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Buscar_cierre_Click(object sender, EventArgs e)
        {
            try
            {
                Cbo_buscar.Enabled = true;
                Dgv_Cierre_general.DataSource = null;

                DataTable lista = ctrl.ObtenerListaCierres();

                if (lista.Rows.Count == 0)
                {
                    MessageBox.Show("⚠️ No existen cierres registrados.",
                                    "Sin registros",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                // Asignar el ComboBox con formato (ID - Fecha)
                Cbo_buscar.DataSource = lista;
                Cbo_buscar.DisplayMember = "Etiqueta";   // lo que se ve
                Cbo_buscar.ValueMember = "ID_Cierre";    // el valor real
                Cbo_buscar.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error al buscar cierres: " + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void Btn_Imprimir_cierre_general_Click(object sender, EventArgs e)
        {

        }

        private void Cbo_buscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_buscar.SelectedIndex < 0)
                return;

            var selectedValue = Cbo_buscar.SelectedValue;
            if (selectedValue == null || selectedValue is DataRowView)
                return;

            try
            {
                int idCierre;
                if (!int.TryParse(selectedValue.ToString(), out idCierre))
                    return;

                // Obtener detalle del cierre
                DataTable detalle = ctrl.ObtenerDetalleCierre(idCierre);
                Dgv_Cierre_general.DataSource = detalle;

                if (detalle.Rows.Count == 0)
                {
                    MessageBox.Show("No hay folios asociados a este cierre.",
                                    "Detalle vacío",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                // Obtener encabezado desde el controlador (no filtrar en la vista)
                var encabezado = ctrl.ObtenerEncabezadoCierre(idCierre);
                if (encabezado.HasValue)
                {
                    Dtp_Fecha_Cierre.Value = encabezado.Value.fecha;
                    Txt_Descripcion_Cierre.Text = encabezado.Value.descripcion;
                    Txt_Descripcion_Cierre.Enabled = true;
                }

                // Mensaje de confirmación removido a solicitud: no mostrar mensaje al seleccionar del ComboBox
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar detalle: " + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}