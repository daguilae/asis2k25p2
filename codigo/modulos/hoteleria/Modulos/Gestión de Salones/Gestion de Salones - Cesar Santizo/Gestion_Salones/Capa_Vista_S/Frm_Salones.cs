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
        
        Cls_Controlador_S cControlador = new Cls_Controlador_S();
        private int iCodigoSalon = -1;
        private string sNombreSalon = "";
        private string sUbicacion = "";
        private int iCapacidad = 0;
        private int iDisponibilidad = 0;

       
        public Frm_Salones()
        {
            InitializeComponent();
            ActualizarGrid();
        }

       
        private void ActualizarGrid()
        {
            DataTable dTabla = cControlador.ObtenerSalones();
            Dvg_Salones.DataSource = dTabla;

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
            return cControlador.VerificarSalon(sNombreSalon);
        }

        private void GuardarSalon()
        {
            string sNombre = Txt_Nombre.Text.Trim();
            string sUbicacion = Txt_ubicacion.Text.Trim();
            int iCapacidad = int.TryParse(Txt_capacidad.Text, out int iCap) ? iCap : 0;
            int iDisponibilidad = Chk_disponibilidad.Checked ? 1 : 0;

            if (string.IsNullOrWhiteSpace(sNombre))
            {
                MessageBox.Show("Debe ingresar un nombre para el salón.");
                return;
            }

            int iExiste = VerificarSalonExistente(sNombre);
            if (iExiste > 0)
            {
                MessageBox.Show("Ya existe un salón con ese nombre.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cControlador.GuardarSalon(sNombre, sUbicacion, iCapacidad, iDisponibilidad);
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

            string sNombreNuevo = Txt_Nombre.Text.Trim();
            string sUbicacionNueva = Txt_ubicacion.Text.Trim();
            int iCapacidadNueva = int.TryParse(Txt_capacidad.Text, out int iCap) ? iCap : 0;
            int iDisponibilidadNueva = Chk_disponibilidad.Checked ? 1 : 0;

            cControlador.ModificarSalon(iCodigoSalon, sNombreNuevo, sUbicacionNueva, iCapacidadNueva, iDisponibilidadNueva);
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

            DialogResult dResult = MessageBox.Show("¿Desea eliminar este salón?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dResult == DialogResult.Yes)
            {
                cControlador.EliminarSalon(iCodigoSalon);
                MessageBox.Show("Salón eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarGrid();
                LimpiarCampos();
            }
        }

    
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
                DataGridViewRow dFila = Dvg_Salones.Rows[e.RowIndex];
                iCodigoSalon = Convert.ToInt32(dFila.Cells["Pk_Id_Salon"].Value);
                Txt_Nombre.Text = dFila.Cells["Cmp_Nombre_Salon"].Value.ToString();
                Txt_ubicacion.Text = dFila.Cells["Cmp_Ubicacion"].Value.ToString();
                Txt_capacidad.Text = dFila.Cells["Cmp_Capacidad"].Value.ToString();
                Chk_disponibilidad.Checked = Convert.ToInt32(dFila.Cells["Cmp_Disponibilidad"].Value) == 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Reservaciones fFormReservas = new Frm_Reservaciones();
            fFormReservas.Show();
        }

        private void Pnl_Superior_Paint(object sender, PaintEventArgs e)
        {
        }

        private void salonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Reservaciones fNuevoFormulario = new Frm_Reservaciones();
            fNuevoFormulario.Show();
        }
    }
}
