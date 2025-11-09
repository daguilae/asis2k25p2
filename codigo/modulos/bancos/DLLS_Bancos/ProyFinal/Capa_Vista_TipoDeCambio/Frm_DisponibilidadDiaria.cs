using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_TipoDeCambio;

namespace Capa_Vista_TipoDeCambio
{
    public partial class Frm_DisponibilidadDiaria : Form
    {
        public Frm_DisponibilidadDiaria()
        {
            InitializeComponent();
        }


        Controlador_TipoCambio controlador = new Controlador_TipoCambio();

        private void Frm_DisponibilidadDiaria_Load(object sender, EventArgs e)
        {
            // Evita errores si el nombre del grid cambia
            Dgv_DisponibilidaadDiaria.AutoGenerateColumns = false;

            // Asignar columnas (verifica los Name exactos en el diseñador)
            Dgv_DisponibilidaadDiaria.Columns["Banco"].DataPropertyName = "Banco";
            Dgv_DisponibilidaadDiaria.Columns["Tipo_De_Cuenta"].DataPropertyName = "TipoCuenta";
            Dgv_DisponibilidaadDiaria.Columns["Numero_De_Cuenta"].DataPropertyName = "NumeroCuenta";
            Dgv_DisponibilidaadDiaria.Columns["Disponibilidad"].DataPropertyName = "Disponibilidad";

            // Cargar Bancos
            Cbo_Banco.DataSource = controlador.CargarBancos();
            Cbo_Banco.DisplayMember = "Cmp_NombreBanco";
            Cbo_Banco.ValueMember = "Pk_Id_Banco";
            Cbo_Banco.SelectedIndex = -1;

            // Cargar Tipos de Cuenta
            Cbo_TipoDeCuenta.DataSource = controlador.CargarTiposCuenta();
            Cbo_TipoDeCuenta.DisplayMember = "Cmp_TipoCuenta";
            Cbo_TipoDeCuenta.ValueMember = "Cmp_TipoCuenta";
            Cbo_TipoDeCuenta.SelectedIndex = -1;

            // Cargar datos del día actual
            DataTable datos = controlador.BuscarDisponibilidad("", "", "");
            Dgv_DisponibilidaadDiaria.DataSource = datos;

            MessageBox.Show("Registros cargados: " + datos.Rows.Count);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string banco = Cbo_Banco.SelectedIndex == -1 ? "" : Cbo_Banco.SelectedValue.ToString();
            string tipoCuenta = Cbo_TipoDeCuenta.SelectedIndex == -1 ? "" : Cbo_TipoDeCuenta.SelectedValue.ToString();
            string numeroCuenta = Txt_NumeroDeCuenta.Text.Trim();

            DataTable datos = controlador.BuscarDisponibilidad(banco, tipoCuenta, numeroCuenta);
            Dgv_DisponibilidaadDiaria.DataSource = datos;

            if (datos.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron registros con los filtros seleccionados.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void Txt_NumeroDeCuenta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}