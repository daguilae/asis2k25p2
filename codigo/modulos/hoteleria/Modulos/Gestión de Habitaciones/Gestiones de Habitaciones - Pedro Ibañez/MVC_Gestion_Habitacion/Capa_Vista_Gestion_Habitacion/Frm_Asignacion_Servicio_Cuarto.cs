using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_GesHab;

namespace Capa_Vista_Gestion_Habitacion
{
    public partial class Frm_Asignacion_Servicio_Cuarto : Form
    {
        Cls_Controlador_Asignacion ctrlAsig = new Cls_Controlador_Asignacion();

        public Frm_Asignacion_Servicio_Cuarto()
        {
            InitializeComponent();
            CargarCombos();
            MostrarAsignaciones();
            this.DGV_Asignaciones.CellClick += new DataGridViewCellEventHandler(this.Dgv_Asignaciones_CellClick);

        }

        private void CargarCombos()
        {
            // --- ComboBox Habitaciones ---
            DataTable dtHabitaciones = ctrlAsig.CargarHabitaciones();
            Cbo_NumHabitaciones.DataSource = dtHabitaciones;
            Cbo_NumHabitaciones.DisplayMember = "PK_ID_Habitaciones";
            Cbo_NumHabitaciones.ValueMember = "PK_ID_Habitaciones";
            Cbo_NumHabitaciones.SelectedIndex = -1;

            DataTable dt = ctrlAsig.CargarServicios();
            Cbo_Servicios.DataSource = dt;
            Cbo_Servicios.DisplayMember = "Cmp_Nombre_Servicio";
            Cbo_Servicios.ValueMember = "PK_ID_Servicio_habitacion";
            Cbo_Servicios.SelectedIndex = -1;
        }

        private void btn_Asignar_Click(object sender, EventArgs e)
        {
            Capa_Controlador_GesHab.Cls_Controlador_Asignacion controlador = new Capa_Controlador_GesHab.Cls_Controlador_Asignacion();

            int IidHabitacion = 0;
            int.TryParse(Cbo_NumHabitaciones.SelectedValue?.ToString(), out IidHabitacion);
            int IidServicio = 0;
            int.TryParse(Cbo_Servicios.SelectedValue?.ToString(), out IidServicio);

            string mensaje;

            // Llamar al método del controlador
            bool exito = controlador.InsertarAsigancionServicios(IidHabitacion, IidServicio, out mensaje);

            // Mostrar mensaje al usuario
            if (exito)
            {
                MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarAsignaciones();
                LimpiarCombos();
            }
            else
            {
                MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MostrarAsignaciones()
        {
            DataTable dt = ctrlAsig.MostrarAsignaciones();
            DGV_Asignaciones.DataSource = dt;

            // Opcional: ajustar el estilo visual
            DGV_Asignaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Asignaciones.ReadOnly = true;
            DGV_Asignaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LimpiarCombos()
        {
            Cbo_NumHabitaciones.SelectedItem = null;
            Cbo_Servicios.SelectedItem = null;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

            int IidHabitacion = 0;
            int.TryParse(Cbo_NumHabitaciones.SelectedValue?.ToString(), out IidHabitacion);
            int IidServicio = 0;
            int.TryParse(Cbo_Servicios.SelectedValue?.ToString(), out IidServicio);

            string mensaje;
            bool exito = ctrlAsig.EliminarAsignacion(IidHabitacion, IidServicio, out mensaje);

            if (exito)
            {
                MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarAsignaciones();
                LimpiarCombos();
            }
            else
            {
                MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Dgv_Asignaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0) // Para evitar el header
                {
                    // Obtener la fila seleccionada
                    DataGridViewRow fila = DGV_Asignaciones.Rows[e.RowIndex];

                    // Asegúrate de que tus columnas tengan estos alias en el SQL:
                    // Habitacion | IdServicio
                    int idHabitacion = Convert.ToInt32(fila.Cells["Habitacion"].Value);
                    int idServicio = Convert.ToInt32(fila.Cells["IdServicio"].Value);

                    // Asignar los valores a los ComboBox
                    Cbo_NumHabitaciones.SelectedValue = idHabitacion;
                    Cbo_Servicios.SelectedValue = idServicio;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos en los ComboBox: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                int idHabitacion = Convert.ToInt32(Cbo_NumHabitaciones.SelectedValue);

                string mensaje;
                DataTable datos = ctrlAsig.BuscarAsignacion(idHabitacion, out mensaje);

                MessageBox.Show(mensaje, "Resultado de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (datos != null)
                    DGV_Asignaciones.DataSource = datos;
                else
                    DGV_Asignaciones.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar asignaciones: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_recargar_Click(object sender, EventArgs e)
        {
            LimpiarCombos();
            MostrarAsignaciones();
        }
    }
}
