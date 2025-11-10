using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Receta;

namespace Capa_Vista_Receta
{
    public partial class Frm_Receta : Form
    {
        Cls_Controlador_Receta controlador = new Cls_Controlador_Receta();
        int iCodigoReceta = -1;
        string sIngredienteOriginal = "";
        string sUnidadOriginal = "";
        double doCantidadOriginal = 0;


        public Frm_Receta()
        {
            InitializeComponent();
        }


        private void pro_Frm_Receta_Load(object sender, EventArgs e)
        {
            pro_CargarDatos();
            Dgv_Receta.Columns.Clear();
            Dgv_Receta.Columns.Add("ingrediente", "Ingrediente");
            Dgv_Receta.Columns.Add("cantidad", "Cantidad");
            Dgv_Receta.Columns.Add("unidad", "Unidad");
            Dgv_Receta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Receta.ReadOnly = true;
        }

        private void pro_CargarDatos()
        {
            try
            {
                DataTable datos = controlador.fun_DatosMenu();
                if (datos.Rows.Count > 0)
                {
                    DataRow fila = datos.NewRow();
                    fila["codigoMenu"] = 0;
                    fila["Platillo"] = "— Opciones de menú —";
                    datos.Rows.InsertAt(fila, 0);

                    Cbo_Menu.DataSource = datos;
                    Cbo_Menu.DisplayMember = "Platillo";
                    Cbo_Menu.ValueMember = "codigoMenu";
                }
                else
                {
                    Cbo_Menu.DataSource = null;
                    Cbo_Menu.Items.Clear();
                    Cbo_Menu.Items.Add("No hay platillos disponibles");
                    Cbo_Menu.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar los menús: " + ex.Message);
            }
        }

        private void pro_DatosReceta(int iCodigoMenu)
        {
            try
            {
                DataTable tabla = controlador.fun_DatosReceta(iCodigoMenu);
                Dgv_Receta.Rows.Clear();

                foreach (DataRow fila in tabla.Rows)
                {
                    int iIndice = Dgv_Receta.Rows.Add();

                    Dgv_Receta.Rows[iIndice].Cells["ingrediente"].Value = fila["ingrediente"];
                    Dgv_Receta.Rows[iIndice].Cells["cantidad"].Value = fila["cantidad"];
                    Dgv_Receta.Rows[iIndice].Cells["unidad"].Value = fila["unidadMedida"];
                    Dgv_Receta.Rows[iIndice].Tag = fila["codigo"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Cbo_Menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Cbo_Menu.SelectedValue == null) return;
                if (Cbo_Menu.SelectedValue is DataRowView) return;

                int icodigoMenu = Convert.ToInt32(Cbo_Menu.SelectedValue);

                if (icodigoMenu > 0)
                {
                    pro_DatosReceta(icodigoMenu);
                }
                else
                {
                    Dgv_Receta.Columns.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la receta: " + ex.Message);
            }
        }

        private void pro_Dgv_Receta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow fila = Dgv_Receta.Rows[e.RowIndex];
            if (fila == null) return;

            string sIngrediente = fila.Cells["ingrediente"].Value?.ToString() ?? "";
            string sUnidad = fila.Cells["unidad"].Value?.ToString() ?? "";
            string sCantidad = fila.Cells["cantidad"].Value?.ToString() ?? "";

            Txt_Ingrediente.Text = sIngrediente;
            Txt_Unidad.Text = sUnidad;
            Txt_Cantidad.Text = sCantidad;

            sIngredienteOriginal = sIngrediente;
            sUnidadOriginal = sUnidad;
            double.TryParse(sCantidad, out doCantidadOriginal);

            if (fila.Tag != null)
            {
                iCodigoReceta = Convert.ToInt32(fila.Tag);
            }
        }


        private void pro_Btn_guardar_Click(object sender, EventArgs e)
        {
            string sIngrediente = Txt_Ingrediente.Text;
            string sUnidad = Txt_Unidad.Text;

            if (string.IsNullOrWhiteSpace(sIngrediente) ||
                string.IsNullOrWhiteSpace(sUnidad) ||
                string.IsNullOrWhiteSpace(Txt_Cantidad.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
                return;
            }

            Regex regex = new Regex(@"^[a-zA-Z0-9\s]+$");

            if (!regex.IsMatch(sIngrediente) || !regex.IsMatch(sUnidad))
            {
                MessageBox.Show("No puede ingresar caracteres especiales");
                return;
            }

            if (!double.TryParse(Txt_Cantidad.Text, out double doCantidad))
            {
                MessageBox.Show("Ingrese un valor numérico válido");
                return;
            }
            if (doCantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad mayor a 0");
                return;
            }

            int iCodigoMenu = 0;
            if (Cbo_Menu.SelectedValue != null && !(Cbo_Menu.SelectedValue is DataRowView))
            {
                iCodigoMenu = Convert.ToInt32(Cbo_Menu.SelectedValue);
            }
            else
            {
                MessageBox.Show("Seleccione un platillo válido");
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Desea guardar la receta?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.No)
                return;

            try
            {
                controlador.pro_GuardarReceta(iCodigoMenu, sIngrediente, sUnidad, doCantidad);
                MessageBox.Show("Receta guardada correctamente");
                Txt_Ingrediente.Clear();
                Txt_Unidad.Clear();
                Txt_Cantidad.Clear();
                pro_DatosReceta(iCodigoMenu);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al ingresar la receta" + ex.Message);
            }

        }



        private void pro_Btn_Modificar_Click(object sender, EventArgs e)
        {
            string sIngrediente = Txt_Ingrediente.Text;
            string sUnidad = Txt_Unidad.Text;

            if (iCodigoReceta < 0)
            {
                MessageBox.Show("Seleccione primero la fila de la receta que desea actualizar");
                return;
            }

            if (string.IsNullOrWhiteSpace(sIngrediente) ||
                string.IsNullOrWhiteSpace(sUnidad) ||
                string.IsNullOrWhiteSpace(Txt_Cantidad.Text))
            {
                MessageBox.Show("No hay datos por actualizar");
                return;
            }

            if (!double.TryParse(Txt_Cantidad.Text, out double doValorIngresado))
            {
                MessageBox.Show("Ingrese un valor numérico válido");
                return;
            }

            if (doValorIngresado <= 0)
            {
                MessageBox.Show("Ingrese una cantidad mayor a 0");
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Desea actualizar la receta?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.No)
                return;
            pro_Actualizar(sIngrediente, sUnidad, doValorIngresado);

        }

        private void pro_Actualizar(string sIngrediente, string sUnidad, double doValorIngresado)
        {
            int iCodigoMenu = Convert.ToInt32(Cbo_Menu.SelectedValue);
            bool bCambio = false;
            try
            {
                // Actualizar Ingrediente
                if (!sIngrediente.Equals(sIngredienteOriginal, StringComparison.OrdinalIgnoreCase))
                {
                    controlador.pro_ActualizarIngrediente(sIngredienteOriginal, sIngrediente);
                    bCambio = true;
                }
                // Actualizar Cantidad o unidad
                if (!sUnidad.Equals(sUnidadOriginal, StringComparison.OrdinalIgnoreCase) ||
                    doValorIngresado != doCantidadOriginal)
                {
                    controlador.pro_ActualizarReceta(iCodigoReceta, sUnidad, doValorIngresado);
                    bCambio = true;
                }

                if (bCambio)
                {
                    MessageBox.Show("Receta actualizada correctamente");
                    Txt_Ingrediente.Clear();
                    Txt_Unidad.Clear();
                    Txt_Cantidad.Clear();
                    iCodigoReceta = -1;
                    pro_DatosReceta(iCodigoMenu);
                }
                else
                {
                    MessageBox.Show("No se ha cambiado ningún dato");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }

        private void pro_Btn_Eliminar_Click(object sender, EventArgs e)
        {
            int iCodigoMenu = Convert.ToInt32(Cbo_Menu.SelectedValue);
            if (iCodigoReceta < 0)
            {
                MessageBox.Show("Seleccione primero la fila de la receta que desea eliminar");
                return;
            }
            DialogResult resultado = MessageBox.Show(
               "¿Desea eliminar el dato de la receta?",
               "Confirmación",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
            );
            if (resultado == DialogResult.No)
                return;
            try
            {
                controlador.pro_EliminarReceta(iCodigoReceta);
                MessageBox.Show("Dato eliminado correctamente de la receta");
                Txt_Ingrediente.Clear();
                Txt_Unidad.Clear();
                Txt_Cantidad.Clear();
                iCodigoReceta = -1;
                pro_DatosReceta(iCodigoMenu);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void pro_Btn_Limpiar_Click(object sender, EventArgs e)
        {
            Txt_Ingrediente.Clear();
            Txt_Unidad.Clear();
            Txt_Cantidad.Clear();
            iCodigoReceta = -1;
        }

        private void pro_Btn_Reporte_Click(object sender, EventArgs e)
        {
            Frm_Reporte reporte = new Frm_Reporte();
            reporte.Show();
        }
    }
}
