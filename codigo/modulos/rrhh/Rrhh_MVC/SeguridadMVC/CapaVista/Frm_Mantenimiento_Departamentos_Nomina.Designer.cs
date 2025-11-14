
namespace Capa_Vista_Seguridad
{
    partial class Frm_Mantenimiento_Departamentos_Nomina
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.navegador1 = new Capa_Vista_Navegador.Navegador();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.IPkId_Aplicacion = 0;
            this.navegador1.IPkId_Modulo = 0;
            this.navegador1.Location = new System.Drawing.Point(12, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.SAlias = null;
            this.navegador1.SEtiquetas = null;
            this.navegador1.Size = new System.Drawing.Size(1180, 488);
            this.navegador1.SNombreTabla = null;
            this.navegador1.TabIndex = 0;
            // 
            // Frm_Mantenimiento_Departamentos_Nomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 594);
            this.Controls.Add(this.navegador1);
            this.Name = "Frm_Mantenimiento_Departamentos_Nomina";
            this.Text = "Frm_Mantenimiento_Departamentos_Nomina";
            this.Load += new System.EventHandler(this.Frm_Mantenimiento_Departamentos_Nomina_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Capa_Vista_Navegador.Navegador navegador1;
    }
}