
namespace Ejec_Creacion_Nomina
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.frm_Principal_Nomina1 = new Capa_Vista_Creacion_Nomina.Frm_Principal_Nomina();
            this.SuspendLayout();
            // 
            // frm_Principal_Nomina1
            // 
            this.frm_Principal_Nomina1.Location = new System.Drawing.Point(-1, 56);
            this.frm_Principal_Nomina1.Name = "frm_Principal_Nomina1";
            this.frm_Principal_Nomina1.Size = new System.Drawing.Size(848, 399);
            this.frm_Principal_Nomina1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 450);
            this.Controls.Add(this.frm_Principal_Nomina1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Capa_Vista_Creacion_Nomina.Frm_Principal_Nomina frm_Principal_Nomina1;
    }
}

