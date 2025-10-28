
namespace Capa_Vista_IE
{
    partial class Frm_Orden_Compra
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
            this.Pnl_Encabezado = new System.Windows.Forms.Panel();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Lbl_Orden_Compra = new System.Windows.Forms.Label();
            this.Pnl_Encabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Encabezado
            // 
            this.Pnl_Encabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(142)))), ((int)(((byte)(181)))));
            this.Pnl_Encabezado.Controls.Add(this.Lbl_Titulo);
            this.Pnl_Encabezado.Location = new System.Drawing.Point(-5, 0);
            this.Pnl_Encabezado.Name = "Pnl_Encabezado";
            this.Pnl_Encabezado.Size = new System.Drawing.Size(1068, 61);
            this.Pnl_Encabezado.TabIndex = 1;
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_Titulo.Location = new System.Drawing.Point(260, 9);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(560, 38);
            this.Lbl_Titulo.TabIndex = 1;
            this.Lbl_Titulo.Text = "Implosión y Explosión de Materiales";
            // 
            // Lbl_Orden_Compra
            // 
            this.Lbl_Orden_Compra.AutoSize = true;
            this.Lbl_Orden_Compra.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Orden_Compra.Location = new System.Drawing.Point(430, 103);
            this.Lbl_Orden_Compra.Name = "Lbl_Orden_Compra";
            this.Lbl_Orden_Compra.Size = new System.Drawing.Size(180, 23);
            this.Lbl_Orden_Compra.TabIndex = 2;
            this.Lbl_Orden_Compra.Text = "Orden de Compra";
            // 
            // Frm_Orden_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 601);
            this.Controls.Add(this.Lbl_Orden_Compra);
            this.Controls.Add(this.Pnl_Encabezado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Orden_Compra";
            this.Text = "Frm_Orden_Compra";
            this.Pnl_Encabezado.ResumeLayout(false);
            this.Pnl_Encabezado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Encabezado;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Label Lbl_Orden_Compra;
    }
}