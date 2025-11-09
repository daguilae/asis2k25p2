using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Capa_Controlador_MH;
// hecho Por Fernando José Cahuex Gonzalez con carnet 0901-22-14979
namespace Capa_Vista_MH
{
    public partial class Frm_Mantenimiento_hoteleria : Form
    {
        private readonly Cls_Controlador_MH controlador = new Cls_Controlador_MH();

        public Frm_Mantenimiento_hoteleria()
        {
            InitializeComponent();
        }

        private void Frm_Mantenimiento_hoteleria_Load(object sender, EventArgs e)
        {
            fun_CargarCombos();
            fun_CargarComboMantenimientos();
            fun_MostrarMantenimientos();

            // Bloqueo dinámico de combos (para no escribir un mantenimiento a la vez en salon y habitacion)
            Cbo_Id_Salon.SelectedIndexChanged += Cbo_Id_Salon_TextChanged;
            Cbo_Id_Habitacion.SelectedIndexChanged += Cbo_Id_Habitacion_TextChanged;
        }

        // CARGA DE COMBOS
    
        private void fun_CargarCombos()
        {
            try
            {
                Cbo_Id_Salon.DataSource = controlador.fun_ObtenerSalones();
                Cbo_Id_Salon.DisplayMember = "Nombre_Salon";
                Cbo_Id_Salon.ValueMember = "Pk_Id_Salon";
                Cbo_Id_Salon.SelectedIndex = -1;

                Cbo_Id_Habitacion.DataSource = controlador.fun_ObtenerHabitaciones();
                Cbo_Id_Habitacion.DisplayMember = "Nombre_Habitacion";
                Cbo_Id_Habitacion.ValueMember = "PK_ID_Habitaciones";
                Cbo_Id_Habitacion.SelectedIndex = -1;

                Cbo_Id_Empleado.DataSource = controlador.fun_ObtenerEmpleados();
                Cbo_Id_Empleado.DisplayMember = "Nombre_Empleado";
                Cbo_Id_Empleado.ValueMember = "Pk_Id_Empleado";
                Cbo_Id_Empleado.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los combos: {ex.Message}");
            }
        }

        private void fun_CargarComboMantenimientos()
        {
            try
            {
                Cbo_Id_Mantenimiento.DataSource = controlador.fun_MostrarMantenimientos();
                Cbo_Id_Mantenimiento.DisplayMember = "Pk_Id_Mantenimiento";
                Cbo_Id_Mantenimiento.ValueMember = "Pk_Id_Mantenimiento";
                Cbo_Id_Mantenimiento.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar mantenimientos: {ex.Message}");
            }
        }

        // BOTONES CRUD

        private void Pic_Guardar_Click(object sender, EventArgs e)
        {
            string mensaje = controlador.fun_GuardarMantenimiento(
                Cbo_Id_Salon.SelectedValue?.ToString(),
                Cbo_Id_Habitacion.SelectedValue?.ToString(),
                Cbo_Id_Empleado.SelectedValue?.ToString(),
                Txt_Tipo_Mantenimiento.Text,
                Txt_Descripcion_Mantenimiento.Text,
                Txt_Estado.Text,
                Dtp_Fecha_Inicio.Value.ToString("yyyy-MM-dd"),
                Dtp_Fecha_Fin.Value.ToString("yyyy-MM-dd")
            );

            MessageBox.Show(mensaje);
            fun_MostrarMantenimientos();
            fun_CargarComboMantenimientos();
            fun_LimpiarCampos();
        }

        private void Pic_Editar_Click(object sender, EventArgs e)
        {
            string mensaje = controlador.fun_ActualizarMantenimiento(
                Cbo_Id_Mantenimiento.SelectedValue?.ToString(),
                Cbo_Id_Salon.SelectedValue?.ToString(),
                Cbo_Id_Habitacion.SelectedValue?.ToString(),
                Cbo_Id_Empleado.SelectedValue?.ToString(),
                Txt_Tipo_Mantenimiento.Text,
                Txt_Descripcion_Mantenimiento.Text,
                Txt_Estado.Text,
                Dtp_Fecha_Inicio.Value.ToString("yyyy-MM-dd"),
                Dtp_Fecha_Fin.Value.ToString("yyyy-MM-dd")
            );

            MessageBox.Show(mensaje);
            fun_MostrarMantenimientos();
            fun_CargarComboMantenimientos();
            fun_LimpiarCampos();
        }

        private void Pic_Eliminar_Click(object sender, EventArgs e)
        {
            string mensaje = controlador.fun_EliminarMantenimiento(Cbo_Id_Mantenimiento.SelectedValue?.ToString());
            MessageBox.Show(mensaje);
            fun_MostrarMantenimientos();
            fun_CargarComboMantenimientos();
            fun_LimpiarCampos();
        }

        private void Pic_Buscar_Click(object sender, EventArgs e)
        {
            string sid = Cbo_Id_Mantenimiento.SelectedValue?.ToString() ?? Cbo_Id_Mantenimiento.Text.Trim();
            DataTable dts_resultado = controlador.fun_BuscarMantenimientoPorId(sid);

            if (dts_resultado.Rows.Count > 0)
            {
                DataRow fila = dts_resultado.Rows[0];
                Cbo_Id_Salon.SelectedValue = fila["Fk_Id_Salon"];
                Cbo_Id_Habitacion.SelectedValue = fila["Fk_Id_Habitacion"];
                Cbo_Id_Empleado.SelectedValue = fila["Fk_Id_Empleado"];
                Txt_Tipo_Mantenimiento.Text = fila["Cmp_Tipo_Mantenimiento"].ToString();
                Txt_Descripcion_Mantenimiento.Text = fila["Cmp_Descripcion_Mantenimiento"].ToString();
                Txt_Estado.Text = fila["Cmp_Estado"].ToString();

                if (DateTime.TryParse(fila["Cmp_Fecha_Inicio_Mantenimiento"].ToString(), out DateTime f1))
                    Dtp_Fecha_Inicio.Value = f1;
                if (DateTime.TryParse(fila["Cmp_Fecha_Fin_Mantenimiento"].ToString(), out DateTime f2))
                    Dtp_Fecha_Fin.Value = f2;
            }
            else
            {
                MessageBox.Show("No se encontró el mantenimiento.");
            }
        }

        private void fun_MostrarMantenimientos()
        {
            Dgv_Mantenimiento_hoteleria.DataSource = controlador.fun_MostrarMantenimientos();
        }

        private void fun_LimpiarCampos()
        {
            Cbo_Id_Mantenimiento.SelectedIndex = -1;
            Cbo_Id_Salon.SelectedIndex = -1;
            Cbo_Id_Habitacion.SelectedIndex = -1;
            Cbo_Id_Empleado.SelectedIndex = -1;
            Txt_Tipo_Mantenimiento.Clear();
            Txt_Descripcion_Mantenimiento.Clear();
            Txt_Estado.Clear();
            Dtp_Fecha_Inicio.Value = DateTime.Now;
            Dtp_Fecha_Fin.Value = DateTime.Now;
            Cbo_Id_Salon.Enabled = true;
            Cbo_Id_Habitacion.Enabled = true;
        }

        private void Cbo_Id_Salon_TextChanged(object sender, EventArgs e)
        {
            Cbo_Id_Habitacion.Enabled = string.IsNullOrWhiteSpace(Cbo_Id_Salon.Text);
        }

        private void Cbo_Id_Habitacion_TextChanged(object sender, EventArgs e)
        {
            Cbo_Id_Salon.Enabled = string.IsNullOrWhiteSpace(Cbo_Id_Habitacion.Text);
        }

        private void Pic_Cancelar_Click(object sender, EventArgs e)
        {
            fun_LimpiarCampos();
        }

        private void Pic_Salir_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void Pic_Reporte_Click(object sender, EventArgs e)
        {
            Frm_Reporte_MHOT frm = new Frm_Reporte_MHOT();
            frm.Show();
        }
    }
}
