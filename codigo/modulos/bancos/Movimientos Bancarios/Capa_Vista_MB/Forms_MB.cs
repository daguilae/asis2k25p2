using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using Capa_Modelo_MB;

namespace Capa_Vista_MB
{
    public partial class Forms_MB : Form
    {
        Conexion cn = new Conexion();

        public Forms_MB()
        {
            InitializeComponent();

            this.Load += Forms_MB_Load;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
            private void Forms_MB_Load(object sender, EventArgs e)
            {
                this.WindowState = FormWindowState.Maximized;
                this.Font = new Font("Rockwell", 11, FontStyle.Regular);
                CargarDetalleMovimientos();
            }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Dgv_Detalle_Movimiento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void CargarDetalleMovimientos()
        {
            try
            {
 
                using (OdbcConnection conn = cn.AbrirConexion())
                {
                    string query = @"SELECT id_detalleMB, id_movimiento, id_tipo_pago,
                                            Num_Documento, Monto, Descripcion, Conciliado
                                     FROM Movimientos_Bancarios";

                    OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    Dgv_Detalle_Movimiento.DataSource = dt;

                    //encabezados
                    Dgv_Detalle_Movimiento.Columns["id_detalleMB"].HeaderText = "ID Detalle";
                    Dgv_Detalle_Movimiento.Columns["id_movimiento"].HeaderText = "Movimiento";
                    Dgv_Detalle_Movimiento.Columns["id_tipo_pago"].HeaderText = "Tipo de Pago";
                    Dgv_Detalle_Movimiento.Columns["Num_Documento"].HeaderText = "Documento";
                    Dgv_Detalle_Movimiento.Columns["Monto"].HeaderText = "Monto";
                    Dgv_Detalle_Movimiento.Columns["Descripcion"].HeaderText = "Descripción";
                    Dgv_Detalle_Movimiento.Columns["Conciliado"].HeaderText = "Conciliado";


                    //grid  responsive
                    Dgv_Detalle_Movimiento.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                    Dgv_Detalle_Movimiento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    Dgv_Detalle_Movimiento.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                    Dgv_Detalle_Movimiento.RowHeadersVisible = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
