
namespace ejecutable
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
            this.ucVacaciones1 = new Capa_Vista_Vacaciones.Frm_Solicitar_Vacaciones_Nomina();
            this.frm_Prinicpal_Vacaciones_Nomina1 = new Capa_Vista_Vacaciones.Frm_Prinicpal_Vacaciones_Nomina();
            this.SuspendLayout();
            // 
            // ucVacaciones1
            // 
            this.ucVacaciones1.ClientSize = new System.Drawing.Size(805, 439);
            this.ucVacaciones1.Location = new System.Drawing.Point(12, 12);
            this.ucVacaciones1.Name = "ucVacaciones1";
            this.ucVacaciones1.Text = "Solicitar Vacaciones";
            this.ucVacaciones1.Visible = false;
            // 
            // frm_Prinicpal_Vacaciones_Nomina1
            // 
            this.frm_Prinicpal_Vacaciones_Nomina1.Location = new System.Drawing.Point(12, 3);
            this.frm_Prinicpal_Vacaciones_Nomina1.Name = "frm_Prinicpal_Vacaciones_Nomina1";
            this.frm_Prinicpal_Vacaciones_Nomina1.Size = new System.Drawing.Size(821, 478);
            this.frm_Prinicpal_Vacaciones_Nomina1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 477);
            this.Controls.Add(this.frm_Prinicpal_Vacaciones_Nomina1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Capa_Vista_Vacaciones.Frm_Solicitar_Vacaciones_Nomina ucVacaciones1;
        private Capa_Vista_Vacaciones.Frm_Prinicpal_Vacaciones_Nomina frm_Prinicpal_Vacaciones_Nomina1;
    }
}

