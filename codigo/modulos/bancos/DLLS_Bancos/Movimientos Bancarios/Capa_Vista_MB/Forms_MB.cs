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
using Capa_Controldor_MB;

namespace Capa_Vista_MB
{
    public partial class Forms_MB : Form
    {
        Cls_Conexion cn = new Cls_Conexion();
        Cls_CRUD crud = new Cls_CRUD();

        public class Cls_OpcionCombo
        {
            public string sTexto { get; set; }
            public int iValor { get; set; }
        }

        public Forms_MB()
        {
            InitializeComponent();
            this.Load += Forms_MB_Load;

            Cbo_Signo.Items.Clear();
            Cbo_Signo.Items.Add("+");
            Cbo_Signo.Items.Add("-");
            Cbo_Signo.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbo_Signo.SelectedIndex = -1;
            Cbo_Signo.Enabled = false;

            Cbo_NoCuenta_Recibe.SelectionChangeCommitted += Cbo_NoCuenta_Recibe_SelectionChangeCommitted;
            Cbo_NoCuenta_Envia.SelectionChangeCommitted += Cbo_NoCuenta_Envia_SelectionChangeCommitted;
            Cbo_Operacion.SelectionChangeCommitted += Cbo_Operacion_SelectionChangeCommitted;

            Cbo_Signo.DropDownStyle = ComboBoxStyle.DropDownList;

            Lbl_Division.AutoSize = false;
            Lbl_Division.Height = 2;
            Lbl_Division.BorderStyle = BorderStyle.Fixed3D;
            Lbl_Division.BackColor = Color.Green;

            Lbl_Division2.AutoSize = false;
            Lbl_Division2.Height = 2;
            Lbl_Division2.BorderStyle = BorderStyle.Fixed3D;
            Lbl_Division2.BackColor = Color.Green;
        }

        private void Forms_MB_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.Font = new Font("Rockwell", 11, FontStyle.Regular);
            pro_CargarCuentasRecibe();
            pro_CargarCuentasEnvia();
            pro_CargarOperaciones();
            pro_ConfigurarComboConciliado();
            pro_CargarEstadosMovimiento();
            pro_CargarDatosEnEstructuraCaptura();

            Cbo_NoCuenta_Recibe.Enabled = false;
            Txt_NombreCuenta_Recibe.Enabled = false;
        }

        private void pro_CargarDatosEnEstructuraCaptura()
        {
            try
            {
                if (Dgv_Detalle_Movimiento.Columns.Count == 0)
                {
                    pro_PrepararGridDetalleParaCaptura();
                }

                DataTable dts_Detalles = crud.fun_ObtenerDetallesContablesParaCaptura();
                if (dts_Detalles.Rows.Count == 0)
                {
                    Dgv_Detalle_Movimiento.Rows.Clear();
                    MessageBox.Show("No hay datos existentes. El grid está listo para capturar nuevos movimientos.", "Información");
                    return;
                }

                DataTable dts_Safe = new DataTable();
                foreach (DataColumn col in dts_Detalles.Columns)
                {
                    dts_Safe.Columns.Add(col.ColumnName, col.DataType);
                }

                Dgv_Detalle_Movimiento.AutoGenerateColumns = false;
                Dgv_Detalle_Movimiento.Rows.Clear();

                foreach (DataRow row in dts_Detalles.Rows)
                {
                    int iIndex = Dgv_Detalle_Movimiento.Rows.Add();
                    if (dts_Detalles.Columns.Contains("Fk_Id_tipo_pago"))
                        Dgv_Detalle_Movimiento.Rows[iIndex].Cells["Fk_Id_tipo_pago"].Value = row["Fk_Id_tipo_pago"];

                    if (dts_Detalles.Columns.Contains("Cmp_Num_Documento"))
                        Dgv_Detalle_Movimiento.Rows[iIndex].Cells["Cmp_Num_Documento"].Value = row["Cmp_Num_Documento"];

                    if (dts_Detalles.Columns.Contains("Debe"))
                        Dgv_Detalle_Movimiento.Rows[iIndex].Cells["Debe"].Value = row["Debe"];

                    if (dts_Detalles.Columns.Contains("Haber"))
                        Dgv_Detalle_Movimiento.Rows[iIndex].Cells["Haber"].Value = row["Haber"];

                    if (dts_Detalles.Columns.Contains("Cmp_Concepto"))
                        Dgv_Detalle_Movimiento.Rows[iIndex].Cells["Cmp_Concepto"].Value = row["Cmp_Concepto"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
        }

        private void pro_PrepararGridDetalleParaCaptura()
        {
            try
            {
                DataGridView dgv_Grid = Dgv_Detalle_Movimiento;
                dgv_Grid.AutoGenerateColumns = false;
                dgv_Grid.Columns.Clear();

                dgv_Grid.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Fk_Id_tipo_pago",
                    HeaderText = "Tipo de Pago (ID)",
                    Width = 120,
                    ReadOnly = true
                });

                dgv_Grid.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Cmp_Num_Documento",
                    HeaderText = "Número Documento",
                    Width = 150,
                    ReadOnly = true
                });

                dgv_Grid.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Debe",
                    HeaderText = "Debe",
                    Width = 100,
                    ReadOnly = true,
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Format = "N2",
                        Alignment = DataGridViewContentAlignment.MiddleRight,
                        BackColor = Color.LightCoral
                    }
                });

                dgv_Grid.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Haber",
                    HeaderText = "Haber",
                    Width = 100,
                    ReadOnly = true,
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Format = "N2",
                        Alignment = DataGridViewContentAlignment.MiddleRight,
                        BackColor = Color.LightGreen
                    }
                });

                dgv_Grid.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Cmp_Concepto",
                    HeaderText = "Concepto",
                    Width = 200,
                    ReadOnly = true,
                });

                dgv_Grid.AllowUserToAddRows = true;
                dgv_Grid.AllowUserToDeleteRows = true;
                dgv_Grid.CellEndEdit += Dgv_Detalle_Movimiento_CellEndEdit;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en pro_PrepararGridDetalleParaCaptura: {ex.Message}", "Error");
            }
        }

        private void Dgv_Detalle_Movimiento_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow dgv_Row = Dgv_Detalle_Movimiento.Rows[e.RowIndex];

            if (e.ColumnIndex == Dgv_Detalle_Movimiento.Columns["Debe"].Index)
            {
                if (dgv_Row.Cells["Debe"].Value != null && !string.IsNullOrEmpty(dgv_Row.Cells["Debe"].Value.ToString()))
                {
                    dgv_Row.Cells["Haber"].Value = null;
                }
            }
            else if (e.ColumnIndex == Dgv_Detalle_Movimiento.Columns["Haber"].Index)
            {
                if (dgv_Row.Cells["Haber"].Value != null && !string.IsNullOrEmpty(dgv_Row.Cells["Haber"].Value.ToString()))
                {
                    dgv_Row.Cells["Debe"].Value = null;
                }
            }
        }

        private void pro_ConfigurarComboConciliado()
        {
            if (Cbo_Conciliado == null)
            {
                Cbo_Conciliado = new ComboBox();
                Cbo_Conciliado.Name = "Cbo_Conciliado";
                Cbo_Conciliado.Location = new Point(180, 240);
                Cbo_Conciliado.Size = new Size(100, 20);
                Cbo_Conciliado.DropDownStyle = ComboBoxStyle.DropDownList;
                this.Controls.Add(Cbo_Conciliado);
            }

            Cbo_Conciliado.Items.Clear();
            Cbo_Conciliado.Items.Add(new { Text = "No", Value = 0 });
            Cbo_Conciliado.Items.Add(new { Text = "Sí", Value = 1 });
            Cbo_Conciliado.DisplayMember = "Text";
            Cbo_Conciliado.ValueMember = "Value";
            Cbo_Conciliado.SelectedIndex = -1;
        }

        private void pro_CargarCuentasRecibe()
        {
            Cls_CRUD crud = new Cls_CRUD();
            try
            {
                DataTable dts_Cuentas = crud.fun_ObtenerCuentas();
                if (dts_Cuentas.Rows.Count > 0)
                {
                    Cbo_NoCuenta_Recibe.DataSource = dts_Cuentas;
                    Cbo_NoCuenta_Recibe.DisplayMember = "Cmp_Numero_Cuenta";
                    Cbo_NoCuenta_Recibe.ValueMember = "Pk_Id_Cuenta";
                    Cbo_NoCuenta_Recibe.SelectedIndex = -1;
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

        private void pro_CargarCuentasEnvia()
        {
            Cls_CRUD crud = new Cls_CRUD();
            try
            {
                DataTable dts_Cuentas = crud.fun_ObtenerCuentas();
                if (dts_Cuentas.Rows.Count > 0)
                {
                    Cbo_NoCuenta_Envia.DataSource = dts_Cuentas;
                    Cbo_NoCuenta_Envia.DisplayMember = "Cmp_Numero_Cuenta";
                    Cbo_NoCuenta_Envia.ValueMember = "Pk_Id_Cuenta";
                    Cbo_NoCuenta_Envia.SelectedIndex = -1;
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
                int iIdCuenta = Convert.ToInt32(Cbo_NoCuenta_Recibe.SelectedValue);
                string sNombreCuenta = crud.fun_ObtenerNombreCuenta(iIdCuenta);
                Txt_NombreCuenta_Recibe.Text = sNombreCuenta;
            }
        }

        private void Cbo_NoCuenta_Envia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Cbo_NoCuenta_Envia.SelectedValue != null)
            {
                int iIdCuenta = Convert.ToInt32(Cbo_NoCuenta_Envia.SelectedValue);
                string sNombreCuenta = crud.fun_ObtenerNombreCuenta(iIdCuenta);
                Txt_NombreCuenta_Envia.Text = sNombreCuenta;
            }
        }

        private void pro_CargarEstadosMovimiento()
        {
            try
            {
                var crud = new Cls_CRUD();
                var lst_Estados = crud.fun_ObtenerEstadosMovimiento();

                Cbo_Estado.DataSource = lst_Estados;
                Cbo_Estado.DropDownStyle = ComboBoxStyle.DropDownList;

                if (lst_Estados.Contains("Activo"))
                {
                    Cbo_Estado.SelectedItem = "Activo";
                }
                else if (lst_Estados.Count > 0)
                {
                    Cbo_Estado.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar estados: {ex.Message}");
                Cbo_Estado.Items.AddRange(new[] { "Activo", "Anulado", "Pendiente", "Trasladado" });
                Cbo_Estado.SelectedIndex = 0;
            }
        }

        private void pro_CargarOperaciones()
        {
            try
            {
                DataTable dts_Operaciones = crud.fun_ObtenerOperaciones();
                Cbo_Operacion.DataSource = null;
                Cbo_Operacion.Items.Clear();

                if (dts_Operaciones == null || dts_Operaciones.Rows.Count == 0)
                {
                    MessageBox.Show("No hay operaciones disponibles en la base de datos.");
                    Cbo_Operacion.Enabled = false;
                    return;
                }

                Cbo_Operacion.DataSource = dts_Operaciones;
                Cbo_Operacion.DisplayMember = "Cmp_nombre";
                Cbo_Operacion.ValueMember = "Pk_Id_operacion";
                Cbo_Operacion.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar operaciones: " + ex.Message);
                Cbo_Operacion.DataSource = null;
                Cbo_Operacion.Items.Clear();
                Cbo_Operacion.Enabled = false;
            }
        }

        private void Cbo_Operacion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Cbo_Operacion.SelectedValue == null) return;

            DataRowView drv_Row = Cbo_Operacion.SelectedItem as DataRowView;
            string sNombreOperacion = drv_Row?["Cmp_nombre"]?.ToString().Trim() ?? string.Empty;

            bool bHabilitarRecibe = sNombreOperacion.Equals("TRANSFERENCIA_ENVIADA", StringComparison.OrdinalIgnoreCase) ||
                                    sNombreOperacion.Equals("TRANSFERENCIA_RECIBIDA", StringComparison.OrdinalIgnoreCase);

            Cbo_NoCuenta_Recibe.Enabled = bHabilitarRecibe;
            Txt_NombreCuenta_Recibe.Enabled = bHabilitarRecibe;

            if (!bHabilitarRecibe)
            {
                Cbo_NoCuenta_Recibe.SelectedIndex = -1;
                Txt_NombreCuenta_Recibe.Clear();
            }

            int iIdOperacion = Convert.ToInt32(Cbo_Operacion.SelectedValue);
            string sSigno = crud.fun_ObtenerSignoOperacionPorId(iIdOperacion);

            if (sSigno == "+" || sSigno == "-")
            {
                if (Cbo_Signo.Items.Count == 0)
                {
                    Cbo_Signo.Items.Add("+");
                    Cbo_Signo.Items.Add("-");
                }
                Cbo_Signo.DropDownStyle = ComboBoxStyle.DropDownList;
                Cbo_Signo.Enabled = false;
                Cbo_Signo.SelectedItem = sSigno;
            }
            else
            {
                Cbo_Signo.Enabled = false;
            }
        }

        private int? fun_ObtenerCuentaDestino()
        {
            if (Cbo_NoCuenta_Recibe.Enabled && Cbo_NoCuenta_Recibe.SelectedValue != null)
            {
                return Convert.ToInt32(Cbo_NoCuenta_Recibe.SelectedValue);
            }
            return null;
        }

        private bool bGuardando = false;

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                int iConciliado = Cbo_Conciliado.SelectedIndex == 1 ? 1 : 0;
                string sEstado = Cbo_Estado.SelectedItem?.ToString() ?? "Activo";

                if (!decimal.TryParse(Txt_Monto.Text, out decimal deMontoPrincipal) || deMontoPrincipal <= 0)
                {
                    MessageBox.Show("Por favor, ingrese un monto válido mayor a cero.");
                    Txt_Monto.Focus();
                    return;
                }

                var mov = new Cls_Sentencias
                {
                    iFk_Id_cuenta_origen = Convert.ToInt32(Cbo_NoCuenta_Envia.SelectedValue),
                    iFk_Id_cuenta_destino = Cbo_NoCuenta_Recibe.SelectedValue != null ?
                                          Convert.ToInt32(Cbo_NoCuenta_Recibe.SelectedValue) : (int?)null,
                    iFk_Id_operacion = Convert.ToInt32(Cbo_Operacion.SelectedValue),
                    dCmp_fecha_movimiento = DateTime.Now,
                    sCmp_numero_documento = Txt_NumeroDocumento.Text,
                    deCmp_valor_total = deMontoPrincipal,
                    sCmp_observaciones = Txt_Concepto.Text,
                    iCmp_conciliado = iConciliado,
                    sCmp_estado = sEstado
                };

                var lst_Detalles = new List<Cls_Sentencias.Cls_MovimientoDetalle>();
                var ctrl_Controlador = new Cls_Controlador();

                foreach (DataGridViewRow dgv_Row in Dgv_Detalle_Movimiento.Rows)
                {
                    if (dgv_Row.IsNewRow) continue;

                    decimal deDebe = 0;
                    decimal deHaber = 0;
                    string sTipoLinea = "";
                    decimal deMonto = 0;

                    if (decimal.TryParse(dgv_Row.Cells["Debe"].Value?.ToString(), out deDebe) && deDebe > 0)
                    {
                        deMonto = deDebe;
                        sTipoLinea = "D";
                    }
                    else if (decimal.TryParse(dgv_Row.Cells["Haber"].Value?.ToString(), out deHaber) && deHaber > 0)
                    {
                        deMonto = deHaber;
                        sTipoLinea = "H";
                    }
                    else
                    {
                        continue;
                    }

                    int? iTipoPago = null;
                    if (int.TryParse(dgv_Row.Cells["Fk_Id_tipo_pago"].Value?.ToString(), out int iTp))
                        iTipoPago = iTp;

                    string sDocumento = dgv_Row.Cells["Cmp_Num_Documento"].Value?.ToString();
                    string sDescripcion = dgv_Row.Cells["Cmp_Concepto"].Value?.ToString();

                    lst_Detalles.Add(new Cls_Sentencias.Cls_MovimientoDetalle
                    {
                        iFk_Id_tipo_pago = iTipoPago,
                        sCmp_Num_Documento = sDocumento?.Trim(),
                        deCmp_Monto = deMonto,
                        sCmp_Descripcion = sDescripcion?.Trim(),
                        iCmp_Conciliado = 0,
                    });
                }

                var lst_Errores = ctrl_Controlador.fun_ValidarMovimiento(mov, lst_Detalles);
                if (lst_Errores.Any())
                {
                    MessageBox.Show("Errores de validación:\n\n• " + string.Join("\n• ", lst_Errores));
                    return;
                }

                var crud = new Cls_CRUD();
                int iIdNuevo = crud.fun_CrearMovimientoConDetalles(mov, lst_Detalles);

                MessageBox.Show($"Movimiento guardado correctamente. ID: {iIdNuevo}");

                pro_LimpiarFormulario();
                pro_CargarDatosEnEstructuraCaptura();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}");
            }
            finally
            {
                bGuardando = false;
                Btn_Guardar.Enabled = true;
            }
        }

        private void pro_LimpiarFormulario()
        {
            try
            {
                Txt_NumeroDocumento.Clear();
                Txt_Monto.Clear();
                Txt_Concepto.Clear();
                Txt_NombreCuenta_Envia.Clear();
                Txt_NombreCuenta_Recibe.Clear();
                Txt_Fecha.Clear();
                Txt_Hora.Clear();
                Txt_Moneda.Clear();

                Cbo_NoCuenta_Envia.SelectedIndex = -1;
                Cbo_NoCuenta_Recibe.SelectedIndex = -1;
                Cbo_Operacion.SelectedIndex = -1;
                Cbo_Signo.SelectedIndex = -1;

                if (Dgv_Detalle_Movimiento.Rows.Count > 0)
                {
                    for (int i = Dgv_Detalle_Movimiento.Rows.Count - 1; i >= 0; i--)
                    {
                        if (!Dgv_Detalle_Movimiento.Rows[i].IsNewRow)
                        {
                            Dgv_Detalle_Movimiento.Rows.RemoveAt(i);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al limpiar formulario: {ex.Message}");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}