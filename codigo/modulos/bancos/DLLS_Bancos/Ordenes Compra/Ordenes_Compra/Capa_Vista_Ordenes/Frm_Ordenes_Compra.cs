using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Ordenes;
using System.Data.Odbc;


// Inicio de código de María Alejandra Morales García con carné: 0901-22-1226 con la fecha de: 07/11/2025
namespace Capa_Vista_Ordenes
{
    public partial class Frm_Ordenes_Compra : Form
    {
        // Inicio de código de María Alejandra Morales García con carné: 0901-22-1226 con la fecha de: 08/11/2025
        private void AlertOk(string text)
        {
            MessageBox.Show(this, text, "Autorizaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void AlertWarn(string text)
        {
            MessageBox.Show(this, text, "Autorizaciones", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void AlertErr(string text)
        {
            MessageBox.Show(this, text, "Autorizaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private bool ConfirmDlg(string text)
        {
            return MessageBox.Show(this, text, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                   == DialogResult.Yes;
        }
        // Fin de código de María Alejandra Morales García con carné: 0901-22-1226 con la fecha de: 08/11/2025



        private readonly Cls_Controlador_Ordenes _ctrl = new Cls_Controlador_Ordenes();
        public Frm_Ordenes_Compra()
        {
            InitializeComponent();
            this.Load += Frm_Ordenes_Compra_Load;
            Dgv_Auto_Ordenes.CellClick += Dgv_Auto_Ordenes_CellClick;
           
            Btn_Actualizar_Autorizacion.Click += Btn_Actualizar_Autorizacion_Click;
            Btn_Eliminar_Autorizacion.Click += Btn_Eliminar_Autorizacion_Click;
        }


        private void Frm_Ordenes_Compra_Load(object sender, EventArgs e)
        {
            ConfigurarControles();
            CargarCombos();
            CargarGrid();
        }



        private void ConfigurarControles()
        {
            Txt_Id_Autorizacion.ReadOnly = true;
            Nud_Monto_Autorizado.DecimalPlaces = 2;
            Nud_Monto_Autorizado.Minimum = 0.01M;
            Nud_Monto_Autorizado.Maximum = 9999999999.99M;
            Dtp_Fecha_Autorizacion.Value = DateTime.Now;
            Cbo_Id_Orden.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbo_Id_Banco.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbo_Id_Empleado.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbo_Id_Estado.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        private void CargarCombos()
        {
            // Orden
            var dtOrden = _ctrl.ObtenerOrdenes();
            Cbo_Id_Orden.DataSource = dtOrden;
            Cbo_Id_Orden.DisplayMember = "Cmp_Descripcion_Orden_Compra";
            Cbo_Id_Orden.ValueMember = "Pk_Id_Orden_Compra";

            // Banco
            var dtBanco = _ctrl.ObtenerBancos();
            Cbo_Id_Banco.DataSource = dtBanco;
            Cbo_Id_Banco.DisplayMember = "Cmp_NombreBanco";
            Cbo_Id_Banco.ValueMember = "Pk_Id_Banco";

            // Empleado (agrega opción nula)
            var dtEmp = _ctrl.ObtenerEmpleados();
            var filaNula = dtEmp.NewRow();
            filaNula["Pk_Id_Empleado"] = DBNull.Value;
            filaNula["Cmp_Nombre_Empleado"] = "(Sin asignar)";
            dtEmp.Rows.InsertAt(filaNula, 0);
            Cbo_Id_Empleado.DataSource = dtEmp;
            Cbo_Id_Empleado.DisplayMember = "Cmp_Nombre_Empleado";
            Cbo_Id_Empleado.ValueMember = "Pk_Id_Empleado";

            // Estado
            var dtEst = _ctrl.ObtenerEstados();
            Cbo_Id_Estado.DataSource = dtEst;
            Cbo_Id_Estado.DisplayMember = "Cmp_Nombre_Estado";
            Cbo_Id_Estado.ValueMember = "Pk_Id_Estado_Autorizacion";
        }


        private void CargarGrid()
        {
            Dgv_Auto_Ordenes.AutoGenerateColumns = true;
            Dgv_Auto_Ordenes.DataSource = _ctrl.ObtenerAutorizacionesDetalle();
            Dgv_Auto_Ordenes.ClearSelection();
        }



        private int? ValorNullable(ComboBox cbo)
        {
            if (cbo.SelectedValue == null || cbo.SelectedValue == DBNull.Value) return null;
            var s = cbo.SelectedValue.ToString();
            return string.IsNullOrWhiteSpace(s) ? (int?)null : Convert.ToInt32(cbo.SelectedValue);
        }

        private void Btn_Agregar_Autorizacion_Click(object sender, EventArgs e)
        {
            try
            {
                var idOrden = Convert.ToInt32(Cbo_Id_Orden.SelectedValue);
                var idBanco = Convert.ToInt32(Cbo_Id_Banco.SelectedValue);
                int? idEmpleado = ValorNullable(Cbo_Id_Empleado);
                var fecha = Dtp_Fecha_Autorizacion.Value;
                var monto = Nud_Monto_Autorizado.Value;
                var idEstado = Convert.ToInt32(Cbo_Id_Estado.SelectedValue);
                var obs = string.IsNullOrWhiteSpace(Txt_Observaciones.Text) ? null : Txt_Observaciones.Text.Trim();

                var nuevoId = _ctrl.Agregar(idOrden, idBanco, idEmpleado, fecha, monto, idEstado, obs);
                Txt_Id_Autorizacion.Text = nuevoId.ToString();
                CargarGrid();

                // Inicio de código de María Alejandra Morales García con carné: 0901-22-1226 con la fecha de: 08/11/2025
                AlertOk($"Autorización agregada correctamente (ID #{nuevoId}).");
            }
            catch (OdbcException ex) { AlertErr("Error de base de datos al agregar: " + ex.Message); }
            catch (Exception ex) { AlertErr("Error al agregar: " + ex.Message); }
        }
        // Fin de código de María Alejandra Morales García con carné: 0901-22-1226 con la fecha de: 08/11/2025

        private void Btn_Actualizar_Autorizacion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_Id_Autorizacion.Text)) return;

            try
            {
                var idAut = Convert.ToInt32(Txt_Id_Autorizacion.Text);
                var idOrden = Convert.ToInt32(Cbo_Id_Orden.SelectedValue);
                var idBanco = Convert.ToInt32(Cbo_Id_Banco.SelectedValue);
                int? idEmpleado = ValorNullable(Cbo_Id_Empleado);
                var fecha = Dtp_Fecha_Autorizacion.Value;
                var monto = Nud_Monto_Autorizado.Value;
                var idEstado = Convert.ToInt32(Cbo_Id_Estado.SelectedValue);
                var obs = string.IsNullOrWhiteSpace(Txt_Observaciones.Text) ? null : Txt_Observaciones.Text.Trim();

                var filas = _ctrl.Actualizar(idAut, idOrden, idBanco, idEmpleado, fecha, monto, idEstado, obs);
                CargarGrid();

                // Inicio de código de María Alejandra Morales García con carné: 0901-22-1226 con la fecha de: 08/11/2025
                if (filas > 0)
                {
                    AlertOk("Autorización modificada correctamente.");
                }
                // Fin de código de María Alejandra Morales García con carné: 0901-22-1226 con la fecha de: 08/11/2025

            }
            catch (OdbcException ex) { AlertErr("Error de base de datos al modificar: " + ex.Message); }
            catch (Exception ex) { AlertErr("Error al modificar: " + ex.Message); }
        }

        private void Btn_Eliminar_Autorizacion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_Id_Autorizacion.Text)) return;
            var idAut = Convert.ToInt32(Txt_Id_Autorizacion.Text);

            // Inicio de código de María Alejandra Morales García con carné: 0901-22-1226 con la fecha de: 08/11/2025
            if (!ConfirmDlg($"¿Seguro que deseas eliminar la autorización #{idAut}?")) return;

            try
            {
                var filas = _ctrl.Eliminar(idAut);
                Limpiar();
                CargarGrid();

                if (filas > 0) AlertOk("Autorización eliminada correctamente.");
                else AlertWarn($"No se encontró la autorización #{idAut}.");
            }
            catch (OdbcException ex) { AlertErr("Error de base de datos al eliminar: " + ex.Message); }
            catch (Exception ex) { AlertErr("Error al eliminar: " + ex.Message); }
        }
        // Fin de código de María Alejandra Morales García con carné: 0901-22-1226 con la fecha de: 08/11/2025

        private void Dgv_Auto_Ordenes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var r = Dgv_Auto_Ordenes.Rows[e.RowIndex];

            Txt_Id_Autorizacion.Text = r.Cells["Pk_Id_Autorizacion"].Value?.ToString();
            Cbo_Id_Orden.SelectedValue = r.Cells["Fk_Id_Orden_Compra"].Value;
            Cbo_Id_Banco.SelectedValue = r.Cells["Fk_Id_Banco"].Value;
            Cbo_Id_Empleado.SelectedValue = r.Cells["Fk_Id_Empleado"].Value == DBNull.Value ? DBNull.Value : r.Cells["Fk_Id_Empleado"].Value;
            Dtp_Fecha_Autorizacion.Value = Convert.ToDateTime(r.Cells["Cmp_Fecha_Autorizacion"].Value);
            Nud_Monto_Autorizado.Value = Convert.ToDecimal(r.Cells["Cmp_Monto_Autorizado"].Value);
            Cbo_Id_Estado.SelectedValue = r.Cells["Fk_Id_Estado_Autorizacion"].Value;
            Txt_Observaciones.Text = r.Cells["Cmp_Observaciones"].Value?.ToString();
        }


        private void Limpiar()
        {
            Txt_Id_Autorizacion.Clear();
            if (Cbo_Id_Empleado.Items.Count > 0) Cbo_Id_Empleado.SelectedIndex = 0; // "(Sin asignar)"
            Txt_Observaciones.Clear();
            Dtp_Fecha_Autorizacion.Value = DateTime.Now;
            if (Cbo_Id_Orden.Items.Count > 0) Cbo_Id_Orden.SelectedIndex = 0;
            if (Cbo_Id_Banco.Items.Count > 0) Cbo_Id_Banco.SelectedIndex = 0;
            if (Cbo_Id_Estado.Items.Count > 0) Cbo_Id_Estado.SelectedIndex = 0;
            Nud_Monto_Autorizado.Value = 0.01M;
        }

        private void Frm_Ordenes_Compra_Load_1(object sender, EventArgs e)
        {

        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
// Fin de código de María Alejandra Morales García con carné: 0901-22-1226 con la fecha de: 07/11/2025