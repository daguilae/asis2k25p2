using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Componente_Consultas;

namespace Capa_Vista_Componente_Consultas
{
    public partial class Consulta_Compleja : Form
    {
        private ConsultasController _ctrl; //Controlador contiene UserQuery
        public Consulta_Compleja()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Consulta_Compleja_Load(object sender, EventArgs e)
        {
            try
            {
                // Ajusta el nombre de tu BD aquí
                _ctrl = new ConsultasController(baseDatos: "controlempleados");

                // Llenar combo de tablas
                var tablas = _ctrl.ObtenerNombresTablas();
                cbo_busqueda.Items.Clear();
                foreach (var t in tablas) cbo_busqueda.Items.Add(t);
                if (cbo_busqueda.Items.Count > 0) cbo_busqueda.SelectedIndex = 0;

                // Orden por defecto
                rb_asc.Checked = true;

                // Historial (ListBox)
                lst_Querys.DataSource = _ctrl.Historial;
                lst_Querys.DisplayMember = nameof(UserQuery.Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de inicio: " + ex.Message, "ODBC",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            _ctrl?.Dispose();
        }

        private void Dgv_Tabla_CellContentClick(object sender, DataGridViewCellEventArgs e) //Refrescar Tabla
        {
            if (cbo_busqueda.SelectedItem == null) return;

            try
            {
                var dt = _ctrl.ConsultarTabla(
                    tabla: cbo_busqueda.Text?.Trim(),
                    asc: rb_asc.Checked,
                    desc: rb_desc.Checked
                );
                Dgv_Tabla.DataSource = dt;
                Dgv_Tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                Dgv_Tabla.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en consulta: " + ex.Message);
            }
        }

        private void btn_EjecutarSQL_Click(object sender, EventArgs e)
        {
            var raw = txt_Sql.Text?.Trim();
            if (string.IsNullOrWhiteSpace(raw))
            {
                MessageBox.Show("Ingresa una consulta SQL (SELECT/SHOW/DESCRIBE).");
                return;
            }

            try
            {
                var dt = _ctrl.EjecutarSqlLectura(raw, agregarAlHistorial: true);
                dgv_Sql.DataSource = dt;
                dgv_Sql.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " + ex.Message);
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            var sel = lst_Querys.SelectedItem as UserQuery;
            if (sel == null)
            {
                MessageBox.Show("Selecciona una consulta en la lista.");
                return;
            }
            txt_Sql.Text = sel.Sql;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            var sel = lst_Querys.SelectedItem as UserQuery;
            if (sel == null)
            {
                MessageBox.Show("Selecciona una consulta en la lista.");
                return;
            }
            _ctrl.EliminarDelHistorial(sel);
        }
    }
    }
}
