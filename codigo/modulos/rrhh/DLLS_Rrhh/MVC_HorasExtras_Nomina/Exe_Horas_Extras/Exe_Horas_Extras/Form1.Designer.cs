
namespace Exe_Horas_Extras
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
            this.frm_Horas_Extras1 = new Capa_Vista_HorasExtra.Frm_Horas_Extras();
            this.SuspendLayout();
            // 
            // frm_Horas_Extras1
            // 
            this.frm_Horas_Extras1.Location = new System.Drawing.Point(35, 12);
            this.frm_Horas_Extras1.Name = "frm_Horas_Extras1";
            this.frm_Horas_Extras1.Size = new System.Drawing.Size(901, 472);
            this.frm_Horas_Extras1.TabIndex = 0;
            this.frm_Horas_Extras1.Load += new System.EventHandler(this.frm_Horas_Extras1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 592);
            this.Controls.Add(this.frm_Horas_Extras1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Capa_Vista_HorasExtra.Frm_Horas_Extras frm_Horas_Extras1;
    }
}

