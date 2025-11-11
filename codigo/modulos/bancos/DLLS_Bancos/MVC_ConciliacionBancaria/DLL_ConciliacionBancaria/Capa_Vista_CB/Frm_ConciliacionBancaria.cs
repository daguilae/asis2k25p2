using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Capa_Controlador_CB;

namespace Capa_Vista_CB
{
    public partial class Frm_ConciliacionBancaria : Form
    {
        private class MesItem
        {
            public int iValor { get; set; }
            public string sNombre { get; set; }
        }

        private readonly Cls_Controlador_Conciliacion gControlador = new Cls_Controlador_Conciliacion();
        private int? gIdEditando = null;
        private bool bCargando = false;

        public Frm_ConciliacionBancaria()
        {
            InitializeComponent();
            WireEvents();
        }

        private void WireEvents()
        {
            this.Load += Frm_ConciliacionBancaria_Load;
            Cbo_Bancos.SelectedIndexChanged += Cbo_Bancos_SelectedIndexChanged;
            Cbo_Cuenta.SelectedIndexChanged += Cbo_Cuenta_SelectedIndexChanged;
            Cbo_Mes.SelectedIndexChanged += Cbo_Mes_SelectedIndexChanged;
        }

        // ============== EVENTOS ==============

        private void Frm_ConciliacionBancaria_Load(object sender, EventArgs e)
        {
            try
            {
                bCargando = true;
                LlenarMeses();
                LlenarBancos();

                Dtp_FechaConciliacion.Value = DateTime.Today;
                Txt_Anio.Text = DateTime.Today.Year.ToString();
                Chk_Estado.Checked = true;
                Txt_Diferencias.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar el formulario: " + ex.Message);
            }
            finally { bCargando = false; }
        }

        private void Btn_Ayuda_Click(object sender, EventArgs e)
        {
            try
            {
                const string subRutaAyuda = @"ayuda\modulos\bancos\AyudasConciliacionBancaria\AyudasConciliacionBancaria.chm";

                string rutaEncontrada = null;

                System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(Application.StartupPath);

                for (int i = 0; i < 10 && dir != null; i++, dir = dir.Parent)
                {
                    string candidata = System.IO.Path.Combine(dir.FullName, subRutaAyuda);
                    if (System.IO.File.Exists(candidata))
                    {
                        rutaEncontrada = candidata;
                        break;
                    }
                }

                string rutaAbsolutaRespaldo =
                    @"C:\Users\paula\source\repos\CuentaPrincipal\ModuloBancos-ConciliacionBancaria\asis2k25p2\ayuda\modulos\bancos\AyudasConciliacionBancaria\AyudasConciliacionBancaria.chm";

                if (rutaEncontrada == null && System.IO.File.Exists(rutaAbsolutaRespaldo))
                    rutaEncontrada = rutaAbsolutaRespaldo;

                if (rutaEncontrada != null)
                {

                    Help.ShowHelp(this, rutaEncontrada, HelpNavigator.Topic, "ConciliacionBancaria_ayuda.html");
                }
                else
                {
                    string intento = System.IO.Path.Combine(Application.StartupPath, subRutaAyuda);
                    MessageBox.Show(
                        "No se encontró el archivo de ayuda.\n\nProbé desde:\n" + intento +
                        "\n\nVerifica que exista esta ruta relativa dentro del proyecto:\n" + subRutaAyuda,
                        "Archivo de ayuda no encontrado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al abrir la ayuda:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }



        private void Btn_Salir_Click(object sender, EventArgs e) => Close();

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cbo_Bancos.SelectedValue == null) { MessageBox.Show("Seleccione un banco."); return; }
                if (Cbo_Cuenta.SelectedValue == null) { MessageBox.Show("Seleccione una cuenta bancaria."); return; }
                if (Cbo_Mes.SelectedValue == null) { MessageBox.Show("Seleccione el mes."); return; }

                int iAnio = int.Parse(Txt_Anio.Text.Trim());
                int iMes = Convert.ToInt32(Cbo_Mes.SelectedValue);
                DateTime dFecha = Dtp_FechaConciliacion.Value;

                int iIdBanco = Convert.ToInt32(Cbo_Bancos.SelectedValue);
                int iIdCuenta = Convert.ToInt32(Cbo_Cuenta.SelectedValue);

                // Validaciones en Controlador
                decimal deSaldoBanco = gControlador.ParseMonto2DecOrThrow(Txt_SaldoBanco.Text, "Saldo de banco");
                decimal deSaldoSistema = gControlador.ParseMonto2DecOrThrow(Txt_SaldoLibros.Text, "Saldo de libros");
                string sObservaciones = gControlador.ValidarObservacionesSoloTextoOrThrow(Txt_Observaciones.Text);
                bool bActiva = Chk_Estado.Checked;

                if (gIdEditando.HasValue)
                {
                    gControlador.ModificarConciliacion(gIdEditando.Value,
                        iAnio, iMes, dFecha, iIdBanco, iIdCuenta,
                        deSaldoBanco, deSaldoSistema, sObservaciones, bActiva);

                    MessageBox.Show("Conciliación actualizada correctamente.");
                }
                else
                {
                    int iNuevoId = gControlador.GuardarConciliacion(iAnio, iMes, dFecha,
                        iIdBanco, iIdCuenta, deSaldoBanco, deSaldoSistema, sObservaciones, bActiva);

                    MessageBox.Show("Conciliación guardada. ID: " + iNuevoId);
                }

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar: " + ex.Message);
            }
        }

        private void Txt_Diferencias_TextChanged(object sender, EventArgs e)
        {
            // Campo calculado (solo lectura). No hacer nada aquí.
        }

        private void Chk_Estado_CheckedChanged(object sender, EventArgs e)
        {
            // No hay lógica necesaria por ahora; checkbox solo marca Activa/Inactiva.
        }

        private void Txt_Observaciones_TextChanged(object sender, EventArgs e)
        {
            // No hacemos nada aquí. La validación real va por KeyPress/Validating. dentro de Controlador
        }

        private void Btn_BuscarConciliacion_Click(object sender, EventArgs e)
        {
            Hide();
            var oFrmBuscar = new Frm_BuscarConciliacion();
            oFrmBuscar.FormClosed += (s, args) => Show();
            oFrmBuscar.Show();
        }

        private void Btn_LimpiarCampos_Click(object sender, EventArgs e) => LimpiarCampos();

        private void Cbo_Bancos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bCargando || Cbo_Bancos.SelectedValue == null) return;

            int iIdBanco;
            if (Cbo_Bancos.SelectedValue is int v) iIdBanco = v;
            else if (Cbo_Bancos.SelectedItem is DataRowView drv) iIdBanco = Convert.ToInt32(drv["Pk_Id_Banco"]);
            else iIdBanco = Convert.ToInt32(Cbo_Bancos.SelectedValue.ToString());

            LlenarCuentas(iIdBanco);
        }

        private void Cbo_Cuenta_SelectedIndexChanged(object sender, EventArgs e) { /* sin lógica extra */ }
        private void Dtp_FechaConciliacion_ValueChanged(object sender, EventArgs e) { /* opcional sync */ }
        private void Cbo_Mes_SelectedIndexChanged(object sender, EventArgs e) { /* sin lógica extra */ }

        private void Txt_Anio_TextChanged(object sender, EventArgs e)
        {
            string sTexto = Txt_Anio.Text;
            if (sTexto.Length == 0) return;
            if (sTexto.Any(ch => !char.IsDigit(ch)))
            {
                int iPos = Txt_Anio.SelectionStart - 1;
                Txt_Anio.Text = new string(sTexto.Where(char.IsDigit).ToArray());
                Txt_Anio.SelectionStart = Math.Max(0, iPos);
            }
        }

        private void Txt_SaldoBanco_TextChanged(object sender, EventArgs e) => RecalcularDiferencia();
        private void Txt_SaldoLibros_TextChanged(object sender, EventArgs e) => RecalcularDiferencia();

        // ============== AUXILIARES ==============

        private void LlenarMeses()
        {
            var lMeses = new[]
            {
                new MesItem{ iValor = 1,  sNombre = "01 - Enero"},
                new MesItem{ iValor = 2,  sNombre = "02 - Febrero"},
                new MesItem{ iValor = 3,  sNombre = "03 - Marzo"},
                new MesItem{ iValor = 4,  sNombre = "04 - Abril"},
                new MesItem{ iValor = 5,  sNombre = "05 - Mayo"},
                new MesItem{ iValor = 6,  sNombre = "06 - Junio"},
                new MesItem{ iValor = 7,  sNombre = "07 - Julio"},
                new MesItem{ iValor = 8,  sNombre = "08 - Agosto"},
                new MesItem{ iValor = 9,  sNombre = "09 - Septiembre"},
                new MesItem{ iValor = 10, sNombre = "10 - Octubre"},
                new MesItem{ iValor = 11, sNombre = "11 - Noviembre"},
                new MesItem{ iValor = 12, sNombre = "12 - Diciembre"},
            }.ToList();

            Cbo_Mes.DataSource = lMeses;
            Cbo_Mes.DisplayMember = "sNombre";
            Cbo_Mes.ValueMember = "iValor";
            Cbo_Mes.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbo_Mes.SelectedValue = DateTime.Today.Month;
        }

        private void LlenarBancos()
        {
            DataTable dtBancos = gControlador.ObtenerBancos();

            Cbo_Bancos.DataSource = null;
            Cbo_Bancos.DisplayMember = "Cmp_NombreBanco";
            Cbo_Bancos.ValueMember = "Pk_Id_Banco";
            Cbo_Bancos.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbo_Bancos.DataSource = dtBancos;

            if (dtBancos.Rows.Count > 0 && Cbo_Bancos.SelectedValue != null)
            {
                int iIdBanco = Convert.ToInt32(Cbo_Bancos.SelectedValue);
                LlenarCuentas(iIdBanco);
            }
        }

        private void LlenarCuentas(int iIdBanco)
        {
            DataTable dtCuentas = gControlador.ObtenerCuentasPorBanco(iIdBanco);

            Cbo_Cuenta.DataSource = null;
            Cbo_Cuenta.DisplayMember = "Cmp_NumeroCuenta";
            Cbo_Cuenta.ValueMember = "Pk_Id_CuentaBancaria";
            Cbo_Cuenta.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbo_Cuenta.DataSource = dtCuentas;
        }

        // Solo cálculo informativo (sin validar). La validación real ocurre al Guardar. y la validación se encuentra en controlador
        private void RecalcularDiferencia()
        {
            if (decimal.TryParse(Txt_SaldoBanco.Text.Replace(',', '.'), NumberStyles.Number, CultureInfo.InvariantCulture, out var deBanco) &&
                decimal.TryParse(Txt_SaldoLibros.Text.Replace(',', '.'), NumberStyles.Number, CultureInfo.InvariantCulture, out var deLibros))
            {
                Txt_Diferencias.Text = (deBanco - deLibros).ToString("0.00", CultureInfo.InvariantCulture);
            }
            else
            {
                Txt_Diferencias.Text = "";
            }
        }

        private void LimpiarCampos()
        {
            Dtp_FechaConciliacion.Value = DateTime.Today;
            Cbo_Mes.SelectedValue = DateTime.Today.Month;
            Txt_Anio.Text = DateTime.Today.Year.ToString();
            Txt_SaldoBanco.Clear();
            Txt_SaldoLibros.Clear();
            Txt_Diferencias.Clear();
            Txt_Observaciones.Clear();
            Chk_Estado.Checked = true;

            if (Cbo_Bancos.Items.Count > 0)
                Cbo_Bancos.SelectedIndex = 0;

            gIdEditando = null;
            Btn_Guardar.Text = "Guardar";
        }

        // ----- Público: cargar desde buscador -----
        public void CargarConciliacionPorId(int iIdConciliacion)
        {
            try
            {
                DataTable dt = gControlador.ObtenerConciliacionPorId(iIdConciliacion);
                if (dt.Rows.Count == 0) { MessageBox.Show("No se encontró la conciliación."); return; }

                var r = dt.Rows[0];

                gIdEditando = iIdConciliacion;
                Btn_Guardar.Text = "Actualizar";

                int iIdBanco = Convert.ToInt32(r["Fk_Id_Banco"]);
                Cbo_Bancos.SelectedValue = iIdBanco;
                LlenarCuentas(iIdBanco);

                if (Cbo_Cuenta.DataSource != null)
                    Cbo_Cuenta.SelectedValue = Convert.ToInt32(r["Fk_Id_CuentaBancaria"]);

                Txt_Anio.Text = r["Cmp_AnioConciliacion"].ToString();
                Cbo_Mes.SelectedValue = Convert.ToInt32(r["Cmp_MesConciliacion"]);
                Dtp_FechaConciliacion.Value = Convert.ToDateTime(r["Cmp_FechaConciliacion"]);

                Txt_SaldoBanco.Text = Convert.ToDecimal(r["Cmp_SaldoBanco"]).ToString(CultureInfo.InvariantCulture);
                Txt_SaldoLibros.Text = Convert.ToDecimal(r["Cmp_SaldoSistema"]).ToString(CultureInfo.InvariantCulture);
                Txt_Diferencias.Text = Convert.ToDecimal(r["Cmp_Diferencia"]).ToString(CultureInfo.InvariantCulture);

                Txt_Observaciones.Text = r["Cmp_Observaciones"] == DBNull.Value ? "" : r["Cmp_Observaciones"].ToString();
                Chk_Estado.Checked = Convert.ToInt32(r["Cmp_EstadoConciliacion"]) == 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la conciliación: " + ex.Message);
            }
        }
    }
}

