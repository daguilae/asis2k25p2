/* 
 * Programador: Richard Anthony De León Milian
 * Carné: 0901-22-10245
 * Fecha de modificación: 11/11/2025
 * Archivo: Frm_PolizaNomina.cs
 * Descripción: Formulario para generar, previsualizar e insertar pólizas de nómina
 * a partir de un rango de fechas. Muestra detalles en la grilla y totales.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Poliza;

namespace MVC_Poliza_Nomina
{
    public partial class Frm_PolizaNomina : Form
    {
        private List<Cls_DetalleLineaVm> _lVm = new List<Cls_DetalleLineaVm>();

        public Frm_PolizaNomina()
        {
            InitializeComponent();

            // Configuración básica de la grilla
            Dgv_detalles.AutoGenerateColumns = true;
            Dgv_detalles.ReadOnly = true;
            Dgv_detalles.AllowUserToAddRows = false;
            Dgv_detalles.AllowUserToDeleteRows = false;
            Dgv_detalles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv_detalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_detalles.RowHeadersVisible = false;

            // Formato de fechas
            Dtp_desde.Format = DateTimePickerFormat.Custom;
            Dtp_desde.CustomFormat = "yyyy-MM-dd";
            Dtp_hasta.Format = DateTimePickerFormat.Custom;
            Dtp_hasta.CustomFormat = "yyyy-MM-dd";
            Dtp_FechaPoliza.Format = DateTimePickerFormat.Custom;
            Dtp_FechaPoliza.CustomFormat = "yyyy-MM-dd";
        }

        // Eventos

        private void Frm_polizanomina_Load(object sender, EventArgs e)
        {
            Btn_aceptar.Enabled = false;
            Txt_IdPoliza.ReadOnly = true;

            // Fecha de póliza igual a la fecha "hasta"
            Dtp_FechaPoliza.Value = Dtp_hasta.Value;

            funActualizarIdEncabezado();
            funRefrescarTotales();
        }

        private void Dtp_fechapoliza_ValueChanged(object sender, EventArgs e)
        {
            funActualizarIdEncabezado();
        }

        // Utilidades privadas

        private void funActualizarIdEncabezado()
        {
            try
            {
                int iId = Cls_ControladorPoliza.funPrevisualizarId(Dtp_FechaPoliza.Value);
                Txt_IdPoliza.Text = iId.ToString();
            }
            catch (Exception)
            {
                Txt_IdPoliza.Text = "";
                // Opcional: mostrar aviso no bloqueante si no se puede obtener el ID
                // MessageBox.Show("No se pudo obtener el ID.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void funRefrescarTotales()
        {
            if (_lVm == null) _lVm = new List<Cls_DetalleLineaVm>();

            var t = Cls_ControladorPoliza.funTotalesVm(_lVm);

            Txt_TotalCargos.Text = t.deCargos.ToString("N2");
            Txt_TotalAbonos.Text = t.deAbonos.ToString("N2");
            Txt_Diferencia.Text = t.deDiferencia.ToString("N2");

            // Color rojo si hay diferencia distinta de 0
            Txt_Diferencia.ForeColor = (t.deDiferencia == 0m) ? Color.Black : Color.Red;
        }

        private void funLimpiarDespuesDeInsertar()
        {
            // Limpia grilla y lista en memoria
            _lVm = new List<Cls_DetalleLineaVm>();
            Dgv_detalles.DataSource = null;

            // Totales a cero
            Txt_TotalCargos.Text = "0.00";
            Txt_TotalAbonos.Text = "0.00";
            Txt_Diferencia.Text = "0.00";
            Txt_Diferencia.ForeColor = Color.Black;

            // Concepto vacío
            Txt_Concepto.Text = "";

            // Fecha de póliza igual a "hasta"
            Dtp_FechaPoliza.Value = Dtp_hasta.Value;

            // Recalcula ID visible
            funActualizarIdEncabezado();

            // Deshabilita aceptar hasta regenerar
            Btn_aceptar.Enabled = false;
        }

        private void Btn_generar_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Obtiene detalles desde el controlador y los muestra en la grilla
                _lVm = Cls_ControladorPoliza.funGenerarDetallesVm(Dtp_desde.Value, Dtp_hasta.Value);
                Dgv_detalles.DataSource = null;
                Dgv_detalles.DataSource = _lVm;

                // Concepto sugerido si está vacío
                if (string.IsNullOrWhiteSpace(Txt_Concepto.Text))
                    Txt_Concepto.Text = Cls_ControladorPoliza.funConceptoSugerido(Dtp_desde.Value, Dtp_hasta.Value);

                // Actualiza totales e ID
                funRefrescarTotales();
                funActualizarIdEncabezado();

                // Habilita aceptar si hay filas
                Btn_aceptar.Enabled = _lVm != null && _lVm.Count > 0;

                // Encabezados recomendados
                if (Dgv_detalles.Columns.Contains("sCodigoCuenta"))
                    Dgv_detalles.Columns["sCodigoCuenta"].HeaderText = "Código de Cuenta";
                if (Dgv_detalles.Columns.Contains("sNombreCuenta"))
                    Dgv_detalles.Columns["sNombreCuenta"].HeaderText = "Nombre de Cuenta";
                if (Dgv_detalles.Columns.Contains("sTipoTexto"))
                    Dgv_detalles.Columns["sTipoTexto"].HeaderText = "Tipo (Cargo/Abono)";
                if (Dgv_detalles.Columns.Contains("deValor"))
                    Dgv_detalles.Columns["deValor"].HeaderText = "Valor";

                // Ocultar columna interna (no debe verse)
                if (Dgv_detalles.Columns.Contains("bTipo"))
                    Dgv_detalles.Columns["bTipo"].Visible = false;

                // Agregar columna "Estado" si no existe y asignarle un valor por defecto
                if (!Dgv_detalles.Columns.Contains("Estado"))
                {
                    var colEstado = new DataGridViewTextBoxColumn
                    {
                        Name = "Estado",
                        HeaderText = "Estado",
                        ReadOnly = true
                    };
                    Dgv_detalles.Columns.Add(colEstado);
                }

                // Rellenar la columna "Estado" (por defecto: Pendiente)
                foreach (DataGridViewRow row in Dgv_detalles.Rows)
                {
                    if (!row.IsNewRow)
                        row.Cells["Estado"].Value = "Pendiente";
                }

                // Orden sugerido de columnas
                Dgv_detalles.Columns["sCodigoCuenta"].DisplayIndex = 0;
                Dgv_detalles.Columns["sNombreCuenta"].DisplayIndex = 1;
                Dgv_detalles.Columns["sTipoTexto"].DisplayIndex = 2;
                Dgv_detalles.Columns["deValor"].DisplayIndex = 3;
                Dgv_detalles.Columns["Estado"].DisplayIndex = 4;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar desde nómina: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_aceptar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (_lVm == null || _lVm.Count == 0)
                {
                    MessageBox.Show("No hay detalles para trasladar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string sMsg;
                bool bOk = Cls_ControladorPoliza.funInsertarPoliza(
                    Dtp_FechaPoliza.Value.Date,
                    Txt_Concepto.Text == null ? "" : Txt_Concepto.Text.Trim(),
                    _lVm,
                    out sMsg
                );

                if (!bOk)
                {
                    MessageBox.Show(sMsg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show(
                    "Póliza trasladada correctamente." +
                    "\nID: " + Txt_IdPoliza.Text +
                    "\nFecha: " + Dtp_FechaPoliza.Value.ToString("yyyy-MM-dd"),
                    "OK",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Limpieza posterior al insert
                funLimpiarDespuesDeInsertar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar póliza: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_cancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
