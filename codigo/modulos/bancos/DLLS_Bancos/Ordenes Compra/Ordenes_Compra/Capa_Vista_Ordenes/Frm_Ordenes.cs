using System;
using System.Windows.Forms;
using Capa_Controlador_Ordenes;

namespace Capa_Vista_Ordenes
{
    public partial class Frm_Ordenes : Form
    {
        Cls_Controlador_Ordenes controlador = new Cls_Controlador_Ordenes();
        string idSeleccionado = "";


        public Frm_Ordenes()
        {
            InitializeComponent();
            CargarTabla();


          
            Dgv_Auto_Ordenes.CellClick += Dgv_Auto_Ordenes_CellClick;

        }

 
        private void CargarTabla()
        {
            Dgv_Auto_Ordenes.DataSource = controlador.Mostrar();
        }

  



        private void Btn_Guardar_Autorizacion_Click(object sender, EventArgs e)
        {
            if (txtOrden.Text == "" || txtBanco.Text == "" || txtFecha.Text == "" || txtAutorizadoPor.Text == "" || txtMonto.Text == "" || txtEstado.Text == "")
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return;
            }

            controlador.Agregar(
                txtOrden.Text,
                txtBanco.Text,
                txtFecha.Text,
                txtAutorizadoPor.Text,
                txtMonto.Text,
                txtEstado.Text
            );

            MessageBox.Show("Autorización registrada correctamente.");
            CargarTabla();
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtOrden.Clear();
            txtBanco.Clear();
            txtAutorizadoPor.Clear();
            txtMonto.Clear();
            txtEstado.Clear();
            txtFecha.Clear();
        }

        private void Btn_Eliminar_Autorizacion_Click(object sender, EventArgs e)
        {
            if (Dgv_Auto_Ordenes.SelectedRows.Count > 0)
            {
                // obtener el valor de la primera columna (ID)
                string idAutorizacion = Dgv_Auto_Ordenes.SelectedRows[0].Cells["Pk_Id_Autorizacion"].Value.ToString();

                DialogResult confirm = MessageBox.Show(
                    $"¿Seguro que deseas eliminar la autorización con ID {idAutorizacion}?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm == DialogResult.Yes)
                {
                    controlador.Eliminar(idAutorizacion);
                    MessageBox.Show("Registro eliminado correctamente.");
                    CargarTabla();
                }
            }
            else
            {
                MessageBox.Show("Por favor selecciona una fila para eliminar.");
            }
        }

        private void Btn_Modificar_Autorizacion_Click(object sender, EventArgs e)
        {

            if (idSeleccionado == "")
            {
                MessageBox.Show("Selecciona una fila para editar.");
                return;
            }

            controlador.Editar(
                idSeleccionado,
                txtOrden.Text,
                txtBanco.Text,
                txtFecha.Text,
                txtAutorizadoPor.Text,
                txtMonto.Text,
                txtEstado.Text
            );

            MessageBox.Show("Registro actualizado correctamente.");
            CargarTabla();
            LimpiarCampos();



        }


      // fila seleccionada
        private void Dgv_Auto_Ordenes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = Dgv_Auto_Ordenes.Rows[e.RowIndex];

                idSeleccionado = fila.Cells["Pk_Id_Autorizacion"].Value.ToString();
                txtOrden.Text = fila.Cells["Fk_Id_Orden_Compra"].Value.ToString();
                txtBanco.Text = fila.Cells["Fk_Id_Banco"].Value.ToString();
                txtFecha.Text = fila.Cells["Cmp_Fecha_Autorizacion"].Value.ToString();
                txtAutorizadoPor.Text = fila.Cells["Cmp_Autorizado_Por"].Value.ToString();
                txtMonto.Text = fila.Cells["Cmp_Monto_Autorizado"].Value.ToString();
                txtEstado.Text = fila.Cells["Fk_Id_Estado_Autorizacion"].Value.ToString();
            }
        }






    }
}
