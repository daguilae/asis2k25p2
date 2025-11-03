using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_S;

namespace Capa_Vista_S
{
    public partial class Frm_Salones : Form
    {
        // ==========================
        // Variables globales
        // ==========================
        Cls_Controlador_S controlador = new Cls_Controlador_S();
        private int iCodigoSalon = -1;
        private string sNombreSalon = "";
        private string sUbicacion = "";
        private int iCapacidad = 0;
        private int iDisponibilidad = 0;

        // ==========================
        // Constructor
        // ==========================
        public Frm_Salones()
        {
            InitializeComponent();
            ActualizarGrid();
        }

        // ==========================
        // Métodos auxiliares
        // ==========================

        private void ActualizarGrid()
        {
            DataTable tabla = controlador.ObtenerSalones();
            Dvg_Salones.DataSource = tabla;

            if (Dvg_Salones.Columns.Count > 0)
            {
                Dvg_Salones.Columns["Pk_Id_Salon"].HeaderText = "ID";
                Dvg_Salones.Columns["Cmp_Nombre_Salon"].HeaderText = "Nombre Del Salon";
                Dvg_Salones.Columns["Cmp_Ubicacion"].HeaderText = "Ubicación";
                Dvg_Salones.Columns["Cmp_Capacidad"].HeaderText = "Capacidad";
                Dvg_Salones.Columns["Cmp_Disponibilidad"].HeaderText = "Disponible";
            }

            Dvg_Salones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dvg_Salones.MultiSelect = false;
            Dvg_Salones.ReadOnly = true;
            Dvg_Salones.AllowUserToAddRows = false;
            Dvg_Salones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void LimpiarCampos()
        {
            Txt_Nombre.Clear();
            Txt_ubicacion.Clear();
            Txt_capacidad.Clear();
            Chk_disponibilidad.Checked = false;
            iCodigoSalon = -1;
        }

        private int VerificarSalonExistente(string sNombreSalon)
        {
            return controlador.VerificarSalon(sNombreSalon);
        }

        private void GuardarSalon()
        {
            string nombre = Txt_Nombre.Text.Trim();
            string ubicacion = Txt_ubicacion.Text.Trim();
            int capacidad = int.TryParse(Txt_capacidad.Text, out int cap) ? cap : 0;
            int disponibilidad = Chk_disponibilidad.Checked ? 1 : 0;

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Debe ingresar un nombre para el salón.");
                return;
            }

            int existe = VerificarSalonExistente(nombre);
            if (existe > 0)
            {
                MessageBox.Show("Ya existe un salón con ese nombre.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            controlador.GuardarSalon(nombre, ubicacion, capacidad, disponibilidad);
            MessageBox.Show("Salón guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ActualizarGrid();
            LimpiarCampos();
        }

        private void ModificarSalon()
        {
            if (iCodigoSalon < 0)
            {
                MessageBox.Show("Seleccione un salón de la tabla para modificar.");
                return;
            }

            string nombreNuevo = Txt_Nombre.Text.Trim();
            string ubicacionNueva = Txt_ubicacion.Text.Trim();
            int capacidadNueva = int.TryParse(Txt_capacidad.Text, out int cap) ? cap : 0;
            int disponibilidadNueva = Chk_disponibilidad.Checked ? 1 : 0;

            controlador.ModificarSalon(iCodigoSalon, nombreNuevo, ubicacionNueva, capacidadNueva, disponibilidadNueva);
            MessageBox.Show("Salón modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ActualizarGrid();
            LimpiarCampos();
        }

        private void EliminarSalon()
        {
            if (iCodigoSalon < 0)
            {
                MessageBox.Show("Seleccione primero el salón que desea eliminar.");
                return;
            }

            DialogResult result = MessageBox.Show("¿Desea eliminar este salón?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                controlador.EliminarSalon(iCodigoSalon);
                MessageBox.Show("Salón eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarGrid();
                LimpiarCampos();
            }
        }

        // ==========================
        // Eventos
        // ==========================

        private void Frm_Salones_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            GuardarSalon();
        }

        private void Btn_modificar_Click(object sender, EventArgs e)
        {
            ModificarSalon();
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            EliminarSalon();
        }

        private void Dvg_Salones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = Dvg_Salones.Rows[e.RowIndex];
                iCodigoSalon = Convert.ToInt32(fila.Cells["Pk_Id_Salon"].Value);
                Txt_Nombre.Text = fila.Cells["Cmp_Nombre_Salon"].Value.ToString();
                Txt_ubicacion.Text = fila.Cells["Cmp_Ubicacion"].Value.ToString();
                Txt_capacidad.Text = fila.Cells["Cmp_Capacidad"].Value.ToString();
                Chk_disponibilidad.Checked = Convert.ToInt32(fila.Cells["Cmp_Disponibilidad"].Value) == 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Reservaciones formSalones = new Frm_Reservaciones();
            formSalones.Show();
        }

        private void Pnl_Superior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void salonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Frm_Reservaciones nuevoFormulario = new Frm_Reservaciones();
            nuevoFormulario.Show();
        }
    }
}
