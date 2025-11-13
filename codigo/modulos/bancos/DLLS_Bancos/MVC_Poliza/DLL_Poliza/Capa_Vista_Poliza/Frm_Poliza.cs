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

namespace Capa_Vista
{
    //========================== Kevin Natareno 0901-21-635 : DLL Poliza, 26/10/2025 ===================================================
    public partial class Frm_Poliza : Form
    {
        Cls_Poliza_Controlador controlador = new Cls_Poliza_Controlador();
        public Frm_Poliza()
        {
            InitializeComponent();
            this.Load += new EventHandler(Frm_Poliza_Load);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                int idBanco = Convert.ToInt32(Cbo_Banco.SelectedValue);
                string tipo = Cbo_Tipo.Text;    
                int docIni = Convert.ToInt32(Cbo_Documento.Text);
                int docFin = Convert.ToInt32(Cbo_Documento_Fin.Text);
                DateTime fechaIni = Dtp_Fecha_Ini.Value;
                DateTime fechaFin = Dtp_Fecha_Fin.Value;
                DateTime fechaPoliza = Dtp_Fecha_Poliza.Value;
                string concepto = Txt_Concepto.Text;

                controlador.CrearPolizaDesdeFiltros(idBanco, tipo, docIni, docFin, fechaIni, fechaFin, fechaPoliza, concepto);

                MessageBox.Show("Póliza generada y trasladada a contabilidad correctamente.",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar la póliza: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (Convert.ToInt32(Cbo_Documento.Text) > Convert.ToInt32(Cbo_Documento_Fin.Text))
            {
                MessageBox.Show("El rango de documentos es inválido.");
                return;
            }

            if (Dtp_Fecha_Ini.Value > Dtp_Fecha_Fin.Value)
            {
                MessageBox.Show("El rango de fechas es inválido.");
                return;
            }

            if (string.IsNullOrWhiteSpace(Txt_Concepto.Text))
            {
                MessageBox.Show("Debe ingresar un concepto.");
                return;
            }

        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  

        private void CargarRangos(object sender, EventArgs e)
        {
            if (Cbo_Banco.SelectedValue == null || Cbo_Tipo.SelectedValue == null)
                return;

            int banco = Convert.ToInt32(Cbo_Banco.SelectedValue);
            int tipo = Convert.ToInt32(Cbo_Tipo.SelectedValue);

            // ---------- DOCUMENTOS ----------
            var documentos = controlador.ObtenerDocumentos(banco, tipo);
            Cbo_Documento.Text = documentos.min.ToString();
            Cbo_Documento_Fin.Text = documentos.max.ToString();

            // ---------- FECHAS ----------
            var fechas = controlador.ObtenerFechas(banco, tipo);
            Dtp_Fecha_Ini.Value = fechas.min;
            Dtp_Fecha_Fin.Value = fechas.max;
        }

        private void Cbo_Banco_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void Frm_Poliza_Load(object sender, EventArgs e)
        {
            try
            {
             

                Cbo_Banco.DataSource = controlador.CargarBancos();
                Cbo_Banco.DisplayMember = "Cmp_NumeroCuenta";
                Cbo_Banco.ValueMember = "Pk_Id_CuentaBancaria";

                Cbo_Tipo.DataSource = controlador.CargarTipos();
                Cbo_Tipo.DisplayMember = "Cmp_NombreTransaccion";
                Cbo_Tipo.ValueMember = "Pk_Id_Transaccion";

                Cbo_Banco.SelectedIndexChanged += CargarRangos;
                Cbo_Tipo.SelectedIndexChanged += CargarRangos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario: " + ex.Message);
            }
        }
    }
}
