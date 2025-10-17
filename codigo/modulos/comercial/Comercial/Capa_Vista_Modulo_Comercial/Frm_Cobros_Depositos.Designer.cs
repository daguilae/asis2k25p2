
namespace Capa_Vista_Modulo_Comercial
{
    partial class Frm_Cobros_Depositos
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
            this.MS_Cobros_Depositos = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // Lbl_Normal
            // 
            this.Lbl_Normal.AutoSize = true;
            this.Lbl_Normal.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Normal.Location = new System.Drawing.Point(399, 320);
            this.Lbl_Normal.Name = "Lbl_Normal";
            this.Lbl_Normal.Size = new System.Drawing.Size(142, 16);
            this.Lbl_Normal.TabIndex = 8;
            this.Lbl_Normal.Text = "PARA TEXTO NORMAL";
            // 
            // Lbl_Subtitulo
            // 
            this.Lbl_Subtitulo.AutoSize = true;
            this.Lbl_Subtitulo.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Subtitulo.Location = new System.Drawing.Point(399, 279);
            this.Lbl_Subtitulo.Name = "Lbl_Subtitulo";
            this.Lbl_Subtitulo.Size = new System.Drawing.Size(138, 17);
            this.Lbl_Subtitulo.TabIndex = 7;
            this.Lbl_Subtitulo.Text = "PARA SUBTITULOS";
            // 
            // Lbl_Titulos
            // 
            this.Lbl_Titulos.AutoSize = true;
            this.Lbl_Titulos.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulos.Location = new System.Drawing.Point(378, 225);
            this.Lbl_Titulos.Name = "Lbl_Titulos";
            this.Lbl_Titulos.Size = new System.Drawing.Size(177, 27);
            this.Lbl_Titulos.TabIndex = 6;
            this.Lbl_Titulos.Text = "PARA TITULOS";
            // 
            // MS_Cobros_Depositos
            // 
            this.MS_Cobros_Depositos.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MS_Cobros_Depositos.Location = new System.Drawing.Point(0, 0);
            this.MS_Cobros_Depositos.Name = "MS_Cobros_Depositos";
            this.MS_Cobros_Depositos.Size = new System.Drawing.Size(933, 24);
            this.MS_Cobros_Depositos.TabIndex = 9;
            this.MS_Cobros_Depositos.Text = "MDI";
            // 
            // Frm_Cobros_Depositos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(933, 561);
            this.Controls.Add(this.MS_Cobros_Depositos);
            this.Controls.Add(this.Lbl_Normal);
            this.Controls.Add(this.Lbl_Subtitulo);
            this.Controls.Add(this.Lbl_Titulos);
            this.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Frm_Cobros_Depositos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cobros y Depositos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Normal;
        private System.Windows.Forms.Label Lbl_Subtitulo;
        private System.Windows.Forms.Label Lbl_Titulos;
        private System.Windows.Forms.MenuStrip MS_Cobros_Depositos;
    }
}