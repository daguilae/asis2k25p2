
namespace Capa_Vista_Modulo_Comercial
{
    partial class Frm_Operaciones_Logisticas
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
            this.Lbl_Normal = new System.Windows.Forms.Label();
            this.Lbl_Subtitulo = new System.Windows.Forms.Label();
            this.Lbl_Titulos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_Normal
            // 
            this.Lbl_Normal.AutoSize = true;
            this.Lbl_Normal.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Normal.Location = new System.Drawing.Point(412, 319);
            this.Lbl_Normal.Name = "Lbl_Normal";
            this.Lbl_Normal.Size = new System.Drawing.Size(189, 20);
            this.Lbl_Normal.TabIndex = 8;
            this.Lbl_Normal.Text = "PARA TEXTO NORMAL";
            // 
            // Lbl_Subtitulo
            // 
            this.Lbl_Subtitulo.AutoSize = true;
            this.Lbl_Subtitulo.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Subtitulo.Location = new System.Drawing.Point(412, 278);
            this.Lbl_Subtitulo.Name = "Lbl_Subtitulo";
            this.Lbl_Subtitulo.Size = new System.Drawing.Size(173, 21);
            this.Lbl_Subtitulo.TabIndex = 7;
            this.Lbl_Subtitulo.Text = "PARA SUBTITULOS";
            // 
            // Lbl_Titulos
            // 
            this.Lbl_Titulos.AutoSize = true;
            this.Lbl_Titulos.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulos.Location = new System.Drawing.Point(391, 224);
            this.Lbl_Titulos.Name = "Lbl_Titulos";
            this.Lbl_Titulos.Size = new System.Drawing.Size(219, 35);
            this.Lbl_Titulos.TabIndex = 6;
            this.Lbl_Titulos.Text = "PARA TITULOS";
            // 
            // Frm_Operaciones_Logisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.Lbl_Normal);
            this.Controls.Add(this.Lbl_Subtitulo);
            this.Controls.Add(this.Lbl_Titulos);
            this.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Frm_Operaciones_Logisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operaciones y Logisticas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Normal;
        private System.Windows.Forms.Label Lbl_Subtitulo;
        private System.Windows.Forms.Label Lbl_Titulos;
    }
}