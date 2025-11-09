using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Capa_Controlador_Cheques;
using System.Data;
using System.Data;
using System.Data.Odbc;

//REALIZADO POR ROCIO LOPEZ 


namespace Capa_Vista_Cheques
{
    public partial class Frm_Proveedores : Form
    {
        Cls_Controlador_Cheques cn = new Cls_Controlador_Cheques();
        string tabla = "";

        public Frm_Proveedores()
        {
            InitializeComponent();
        }

        private void Frm_Proveedores_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable bancos = cn.ObtenerListaBancos();
                Cmb_CodigoCuenta.DataSource = bancos;
                Cmb_CodigoCuenta.DisplayMember = "Banco"; // lo que ve el usuario
                Cmb_CodigoCuenta.ValueMember = "ID";      // valor real
                Cmb_CodigoCuenta.SelectedIndex = -1;      // nada seleccionado
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los bancos: " + ex.Message);
            }




        }
        private void CargarLotes()
        {
            try
            {
                DataTable lotes = cn.ObtenerLotes();

                if (lotes.Rows.Count > 0)
                {
                    txt_lote.Text = lotes.Rows[lotes.Rows.Count - 1]["ID"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar lotes: " + ex.Message);
            }
        }
        //
        private void Frm_Cheques_Load(object sender, EventArgs e)
        {
            CargarLotes();          // ✅ Cargar lista de lotes
                                    //lo que ya tenías
            DataTable bancos = cn.ObtenerListaBancos();
            Cmb_CodigoCuenta.DataSource = bancos;
            Cmb_CodigoCuenta.DisplayMember = "Banco";
            Cmb_CodigoCuenta.ValueMember = "ID";
        }


        private void Btn_Cargar_Click(object sender, EventArgs e)
        {
            //  Validar banco seleccionado ANTES de hacer lote
            if (Cmb_CodigoCuenta.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un banco antes de cargar los datos.",
                                "Banco requerido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            Cls_Controlador_Cheques ctrl = new Cls_Controlador_Cheques();

            // Obtener empleados simulados
            List<Empleado> empleados = ctrl.ObtenerEmpleadosSimulados();

            // Mostrar en el DataGridView
            dgv_Cheques.DataSource = empleados;
            string usuario = "Rocio";

            int idLote = ctrl.CrearLote(usuario);
          
            if (idLote > 0)
            {
                MessageBox.Show("✅ Lote creado correctamente");

                txt_lote.Text = idLote.ToString();   // ✅ Mostrar el lote creado
            }
            else
                MessageBox.Show("❌ Error al crear el lote");
        }

        private void btn_Generar_Cheque_Click(object sender, EventArgs e)
        {
            // 1. Validar banco seleccionado
            if (Cmb_CodigoCuenta.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un banco antes de generar los cheques.",
                                "Banco requerido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return; // ❌ Bloquea la operación
            }

            //  Si sí seleccionó banco, seguimos
            int idBanco = Convert.ToInt32(Cmb_CodigoCuenta.SelectedValue);

            Cls_Controlador_Cheques control = new Cls_Controlador_Cheques();

            // empleados simulados
            List<Empleado> empleados = control.ObtenerEmpleadosSimulados();

            int idLote = control.CrearLote("Rocio");
            control.GenerarChequesCompletos("Rocio", idLote, idBanco, empleados);
            MessageBox.Show("✅ Cheques generados");

        }
    }
}
