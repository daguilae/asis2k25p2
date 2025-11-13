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
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                // Recoger datos del formulario
                string banco = Txt_Banco.Text;
                string tipo = Txt_Tipo.Text;
                string docto = Txt_Documento.Text;
                DateTime fecha = Convert.ToDateTime(Txt_Fecha.Text);
                string concepto = Txt_Concepto.Text;

                // Crear encabezado y enviar al controlador
               controlador.InsertarPoliza(banco, tipo, docto, fecha, concepto);
                MessageBox.Show("Póliza enviada a Contabilidad correctamente.", "Éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la póliza: " + ex.Message);
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
