using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;
using Capa_Controlador_Poliza;

namespace Capa_Vista
{
    public partial class Frm_GenerarPoliza : Form
    {
        private readonly Cls_Poliza_Controlador controlador = new Cls_Poliza_Controlador();

        public Frm_GenerarPoliza()
        {
            InitializeComponent();
            CargarBancos();
        }

        // =============================
        // CARGA DE COMBOS
        // =============================
        private void CargarBancos()
        {
            using (OdbcDataReader dr = controlador.ObtenerBancos())
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                Cbo_Banco.DataSource = dt;
                Cbo_Banco.DisplayMember = "Cmp_NombreBanco";
                Cbo_Banco.ValueMember = "Pk_Id_Banco";
                Cbo_Banco.SelectedIndex = -1;
            }
        }

        private void Cbo_Banco_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Evitar ejecución mientras se llena el combo
            if (Cbo_Banco.SelectedValue == null || Cbo_Banco.SelectedValue is DataRowView)
                return;

            if (int.TryParse(Cbo_Banco.SelectedValue.ToString(), out int idBanco))
            {
                CargarDocumentosPorBanco(idBanco);
            }
        }



        private void CargarDocumentosPorBanco(int idBanco)
        {
            using (OdbcDataReader dr = controlador.ObtenerCuentas(idBanco))
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                Cbo_Tipo.DataSource = dt;
                Cbo_Tipo.DisplayMember = "Cmp_NumeroCuenta";
                Cbo_Tipo.ValueMember = "Pk_Id_CuentaBancaria";
                Cbo_Tipo.SelectedIndex = -1;
            }
        }

        private void Cbo_Tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_Tipo.SelectedValue == null || Cbo_Tipo.SelectedValue is DataRowView)
                return;

            if (int.TryParse(Cbo_Tipo.SelectedValue.ToString(), out int idCuenta))
                CargarDocumentos(idCuenta);
        }


        private void CargarDocumentos(int idCuenta)
        {
            using (OdbcDataReader dr = controlador.ObtenerDocumentos(idCuenta))
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                Cbo_Documento.DataSource = dt;
                Cbo_Documento.DisplayMember = "Cmp_NumeroDocumento";
                Cbo_Documento.ValueMember = "Pk_Id_Movimiento";
                Cbo_Documento.SelectedIndex = -1;
            }
        }

        // =============================
        // BOTÓN ACEPTAR
        // =============================
        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Txt_Concepto.Text))
                {
                    MessageBox.Show("Debe ingresar un concepto para la póliza.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime fechaPoliza = Dtp_Fecha_Poliza.Value;
                string concepto = Txt_Concepto.Text.Trim();

                // Ejemplo de cuentas (esto se puede adaptar para tomar datos reales del movimiento)
                var detalles = new List<(string, bool, decimal)>
                {
                    ("5101", true, 1200.00m),   // Cargo
                    ("2105", false, 1200.00m)   // Abono
                };

                controlador.InsertarPoliza(fechaPoliza, concepto, detalles);
                MessageBox.Show("✅ Póliza generada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al generar la póliza: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
