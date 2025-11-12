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
        Cls_Controlador_Asignacion oCtrlAsignacion = new Cls_Controlador_Asignacion();

        public Frm_Asignacion_Servicio_Cuarto()
        {
            InitializeComponent();
            fun_CargarCombos();
            fun_MostrarAsignaciones();
            this.DGV_Asignaciones.CellClick += new DataGridViewCellEventHandler(this.Dgv_Asignaciones_CellClick);
        }

        private void fun_CargarCombos()
        {
            // --- ComboBox Habitaciones ---
            DataTable dtHabitaciones = oCtrlAsignacion.fun_CargarHabitaciones();
            Cbo_NumHabitaciones.DataSource = dtHabitaciones;
            Cbo_NumHabitaciones.DisplayMember = "PK_ID_Habitaciones";
            Cbo_NumHabitaciones.ValueMember = "PK_ID_Habitaciones";
            Cbo_NumHabitaciones.SelectedIndex = -1;

            // --- ComboBox Servicios ---
            DataTable dtServicios = oCtrlAsignacion.fun_CargarServicios();
            Cbo_Servicios.DataSource = dtServicios;
            Cbo_Servicios.DisplayMember = "Cmp_Nombre_Servicio";
            Cbo_Servicios.ValueMember = "PK_ID_Servicio_habitacion";
            Cbo_Servicios.SelectedIndex = -1;
        }

        private void btn_Asignar_Click(object sender, EventArgs e)
        {
            Cls_Controlador_Asignacion oControlador = new Cls_Controlador_Asignacion();

            int iIdHabitacion = 0;
            int.TryParse(Cbo_NumHabitaciones.SelectedValue?.ToString(), out iIdHabitacion);

            int iIdServicio = 0;
            int.TryParse(Cbo_Servicios.SelectedValue?.ToString(), out iIdServicio);

            string sMensaje;

            // Llamar al método del controlador
            bool bExito = oControlador.pro_InsertarAsigancionServicios(iIdHabitacion, iIdServicio, out sMensaje);

            // Mostrar mensaje al usuario
            if (bExito)
            {
                MessageBox.Show(sMensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fun_MostrarAsignaciones();
                fun_LimpiarCombos();
            }
            else
            {
                MessageBox.Show(sMensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void fun_MostrarAsignaciones()
        {
            DataTable dtAsignaciones = oCtrlAsignacion.pro_MostrarAsignaciones();
            DGV_Asignaciones.DataSource = dtAsignaciones;

            // Estilo visual del DataGridView
            DGV_Asignaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Asignaciones.ReadOnly = true;
            DGV_Asignaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void fun_LimpiarCombos()
        {
            Cbo_NumHabitaciones.SelectedItem = null;
            Cbo_Servicios.SelectedItem = null;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            int iIdHabitacion = 0;
            int.TryParse(Cbo_NumHabitaciones.SelectedValue?.ToString(), out iIdHabitacion);

            int iIdServicio = 0;
            int.TryParse(Cbo_Servicios.SelectedValue?.ToString(), out iIdServicio);

            string sMensaje;
            bool bExito = oCtrlAsignacion.pro_EliminarAsignacion(iIdHabitacion, iIdServicio, out sMensaje);

            if (bExito)
            {
                MessageBox.Show(sMensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fun_MostrarAsignaciones();
                fun_LimpiarCombos();
            }
            else
            {
                MessageBox.Show(sMensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Dgv_Asignaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0) // Evita seleccionar el encabezado
                {
                    // Obtener la fila seleccionada
                    DataGridViewRow oFila = DGV_Asignaciones.Rows[e.RowIndex];

                    // Asegúrate de que tus columnas tengan estos alias en el SQL: Habitacion | IdServicio
                    int iIdHabitacion = Convert.ToInt32(oFila.Cells["Habitacion"].Value);
                    int iIdServicio = Convert.ToInt32(oFila.Cells["IdServicio"].Value);

                    // Asignar los valores a los ComboBox
                    Cbo_NumHabitaciones.SelectedValue = iIdHabitacion;
                    Cbo_Servicios.SelectedValue = iIdServicio;
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
            //this.Close();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                int iIdHabitacion = 0;
                int.TryParse(Cbo_NumHabitaciones.SelectedValue?.ToString(), out iIdHabitacion);

                string sMensaje;
                DataTable dtDatos = oCtrlAsignacion.fun_BuscarAsignacion(iIdHabitacion, out sMensaje);

                MessageBox.Show(sMensaje, "Resultado de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (dtDatos != null)
                    DGV_Asignaciones.DataSource = dtDatos;
                else
                    DGV_Asignaciones.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar asignaciones: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_recargar_Click(object sender, EventArgs e)
        {
            fun_LimpiarCombos();
            fun_MostrarAsignaciones();
            fun_CargarCombos();
        }

        private void btn_salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_reporte_Click(object sender, EventArgs e)
        {
            Frm_Asig_Serv_hab rpt = new Frm_Asig_Serv_hab();
            rpt.Show();
        }
    }
}
