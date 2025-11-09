
namespace Capa_Vista_Cheques
{
    partial class Frm_Tipo_Cheques
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
            this.btn = new System.Windows.Forms.Button();
            this.bnt_Proveedores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(74, 82);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(122, 78);
            this.btn.TabIndex = 0;
            this.btn.Text = "CHEQUES PLANILLA";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // bnt_Proveedores
            // 
            this.bnt_Proveedores.Location = new System.Drawing.Point(287, 82);
            this.bnt_Proveedores.Name = "bnt_Proveedores";
            this.bnt_Proveedores.Size = new System.Drawing.Size(138, 78);
            this.bnt_Proveedores.TabIndex = 1;
            this.bnt_Proveedores.Text = "CHEQUES PROVEEDORES";
            this.bnt_Proveedores.UseVisualStyleBackColor = true;
            this.bnt_Proveedores.Click += new System.EventHandler(this.bnt_Proveedores_Click);
            // 
            // Frm_Tipo_Cheques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 265);
            this.Controls.Add(this.bnt_Proveedores);
            this.Controls.Add(this.btn);
            this.Name = "Frm_Tipo_Cheques";
            this.Text = "Frm_Tipo_Cheques";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button bnt_Proveedores;
    }
}