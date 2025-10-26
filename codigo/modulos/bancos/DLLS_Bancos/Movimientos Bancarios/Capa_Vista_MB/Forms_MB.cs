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
        CRUD crud = new CRUD();

        public Forms_MB()
        {
            InitializeComponent();
            this.Load += Forms_MB_Load;

            Cbo_NoCuenta_Recibe.SelectionChangeCommitted += Cbo_NoCuenta_Recibe_SelectionChangeCommitted;
            Cbo_NoCuenta_Envia.SelectionChangeCommitted += Cbo_NoCuenta_Envia_SelectionChangeCommitted;
            Cbo_Operacion.SelectionChangeCommitted += Cbo_Operacion_SelectionChangeCommitted;

        }

        private void Forms_MB_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.Font = new Font("Rockwell", 11, FontStyle.Regular);
            CargarDetalleMovimientos();
            CargarCuentasRecibe();
            CargarCuentasEnvia();
            CargarOperaciones();

            Cbo_NoCuenta_Recibe.Enabled = false;
            Txt_NombreCuenta_Recibe.Enabled = false;
        }

        private void CargarDetalleMovimientos()
        {
            try
            {
                // Llamar directamente al método del modelo
                var crud = new Capa_Modelo_MB.Sentencias();
                OdbcDataAdapter da = crud.llenarTbl("Tbl_Movimientos_Bancarios");

                DataTable dt = new DataTable();
                da.Fill(dt);

                // Mostrar los datos en el DataGridView
                Dgv_Detalle_Movimiento.AutoGenerateColumns = true;
                Dgv_Detalle_Movimiento.DataSource = dt;

                // Encabezados legibles
                if (Dgv_Detalle_Movimiento.Columns.Contains("Pk_Id_movimiento"))
                    Dgv_Detalle_Movimiento.Columns["Pk_Id_movimiento"].HeaderText = "ID Movimiento";
                if (Dgv_Detalle_Movimiento.Columns.Contains("Fk_Id_cuenta_origen"))
                    Dgv_Detalle_Movimiento.Columns["Fk_Id_cuenta_origen"].HeaderText = "Cuenta Origen";
                if (Dgv_Detalle_Movimiento.Columns.Contains("Fk_Id_cuenta_destino"))
                    Dgv_Detalle_Movimiento.Columns["Fk_Id_cuenta_destino"].HeaderText = "Cuenta Destino";
                if (Dgv_Detalle_Movimiento.Columns.Contains("Fk_Id_operacion"))
                    Dgv_Detalle_Movimiento.Columns["Fk_Id_operacion"].HeaderText = "Operación";
                if (Dgv_Detalle_Movimiento.Columns.Contains("Fk_Id_concepto"))
                    Dgv_Detalle_Movimiento.Columns["Fk_Id_concepto"].HeaderText = "Concepto";
                if (Dgv_Detalle_Movimiento.Columns.Contains("Cmp_fecha_movimiento"))
                    Dgv_Detalle_Movimiento.Columns["Cmp_fecha_movimiento"].HeaderText = "Fecha";
                if (Dgv_Detalle_Movimiento.Columns.Contains("Cmp_valor_total"))
                    Dgv_Detalle_Movimiento.Columns["Cmp_valor_total"].HeaderText = "Monto Total";
                if (Dgv_Detalle_Movimiento.Columns.Contains("Cmp_observaciones"))
                    Dgv_Detalle_Movimiento.Columns["Cmp_observaciones"].HeaderText = "Observaciones";
                if (Dgv_Detalle_Movimiento.Columns.Contains("Cmp_conciliado"))
                    Dgv_Detalle_Movimiento.Columns["Cmp_conciliado"].HeaderText = "Conciliado";
                if (Dgv_Detalle_Movimiento.Columns.Contains("Cmp_estado"))
                    Dgv_Detalle_Movimiento.Columns["Cmp_estado"].HeaderText = "Estado";

                // Ajustes visuales
                Dgv_Detalle_Movimiento.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                Dgv_Detalle_Movimiento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                Dgv_Detalle_Movimiento.RowHeadersVisible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCuentasRecibe()
        {
            CRUD crud = new CRUD();
            try
            {
                DataTable dt = crud.ObtenerCuentas();

                if (dt.Rows.Count > 0)
                {
                    Cbo_NoCuenta_Recibe.DataSource = dt;
                    Cbo_NoCuenta_Recibe.DisplayMember = "Cmp_Numero_Cuenta"; // lo que se muestra
                    Cbo_NoCuenta_Recibe.ValueMember = "Pk_Id_Cuenta"; // valor interno
                }
                else
                {
                    MessageBox.Show("No hay cuentas disponibles en la base de datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las cuentas: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCuentasEnvia()
        {
            CRUD crud = new CRUD();
            try
            {
                DataTable dt = crud.ObtenerCuentas();

                if (dt.Rows.Count > 0)
                {
                    Cbo_NoCuenta_Envia.DataSource = dt;
                    Cbo_NoCuenta_Envia.DisplayMember = "Cmp_Numero_Cuenta"; // lo que se muestra
                    Cbo_NoCuenta_Envia.ValueMember = "Pk_Id_Cuenta"; // valor interno
                }
                else
                {
                    MessageBox.Show("No hay cuentas disponibles en la base de datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las cuentas: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cbo_NoCuenta_Recibe_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Cbo_NoCuenta_Recibe.SelectedValue != null)
            {
                int idCuenta = Convert.ToInt32(Cbo_NoCuenta_Recibe.SelectedValue);
                string nombreCuenta = crud.ObtenerNombreCuenta(idCuenta);
                Txt_NombreCuenta_Recibe.Text = nombreCuenta;
            }
        }
        private void Cbo_NoCuenta_Envia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Cbo_NoCuenta_Envia.SelectedValue != null)
            {
                int idCuenta = Convert.ToInt32(Cbo_NoCuenta_Envia.SelectedValue);
                string nombreCuenta = crud.ObtenerNombreCuenta(idCuenta);
                Txt_NombreCuenta_Envia.Text = nombreCuenta;
            }
        }

        private void CargarOperaciones()
        {
            try
            {
                var dt = crud.ObtenerOperaciones();
                Cbo_Operacion.DataSource = dt;
                Cbo_Operacion.DisplayMember = "Cmp_nombre";
                Cbo_Operacion.ValueMember = "Pk_Id_operacion";
                Cbo_Operacion.SelectedIndex = -1; // empieza vacío
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar operaciones: " + ex.Message);
            }
        }
        private void Cbo_Operacion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Toma la fila seleccionada de la fuente de datos
            var row = Cbo_Operacion.SelectedItem as DataRowView;
            string nombreOperacion = row?["Cmp_nombre"]?.ToString().Trim() ?? Cbo_Operacion.Text.Trim();

            bool habilitar = string.Equals(nombreOperacion, "Transferencia", StringComparison.OrdinalIgnoreCase);

            Cbo_NoCuenta_Recibe.Enabled = habilitar;
            Txt_NombreCuenta_Recibe.Enabled = habilitar;

            if (!habilitar)
            {
                Cbo_NoCuenta_Recibe.SelectedIndex = -1;
                Txt_NombreCuenta_Recibe.Clear();
            }
        }


    }
}
