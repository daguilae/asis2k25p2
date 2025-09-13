
namespace Capa_Vista_Componente_Consultas
{
    partial class Frm_Principal
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
            this.btn_ConsultaSimple = new System.Windows.Forms.Button();
            this.btn_ConsultaCompleja = new System.Windows.Forms.Button();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ConsultaSimple
            // 
            this.btn_ConsultaSimple.Location = new System.Drawing.Point(330, 64);
            this.btn_ConsultaSimple.Name = "btn_ConsultaSimple";
            this.btn_ConsultaSimple.Size = new System.Drawing.Size(116, 54);
            this.btn_ConsultaSimple.TabIndex = 0;
            this.btn_ConsultaSimple.Text = "Consultas Simples";
            this.btn_ConsultaSimple.UseVisualStyleBackColor = true;
            // 
            // btn_ConsultaCompleja
            // 
            this.btn_ConsultaCompleja.Location = new System.Drawing.Point(330, 162);
            this.btn_ConsultaCompleja.Name = "btn_ConsultaCompleja";
            this.btn_ConsultaCompleja.Size = new System.Drawing.Size(116, 56);
            this.btn_ConsultaCompleja.TabIndex = 1;
            this.btn_ConsultaCompleja.Text = "Consulta Compleja";
            this.btn_ConsultaCompleja.UseVisualStyleBackColor = true;
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.Location = new System.Drawing.Point(351, 246);
            this.btn_Ayuda.Name = "btn_Ayuda";
            this.btn_Ayuda.Size = new System.Drawing.Size(75, 50);
            this.btn_Ayuda.TabIndex = 2;
            this.btn_Ayuda.Text = "Ayuda";
            this.btn_Ayuda.UseVisualStyleBackColor = true;
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Ayuda);
            this.Controls.Add(this.btn_ConsultaCompleja);
            this.Controls.Add(this.btn_ConsultaSimple);
            this.Name = "Frm_Principal";
            this.Text = "Frm_Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ConsultaSimple;
        private System.Windows.Forms.Button btn_ConsultaCompleja;
        private System.Windows.Forms.Button btn_Ayuda;
    }
}