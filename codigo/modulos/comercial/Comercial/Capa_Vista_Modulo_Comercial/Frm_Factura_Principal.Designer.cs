
namespace Capa_Vista_Modulo_Comercial
{
    partial class Frm_Factura_Principal
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
            this.Lbl_Principal = new System.Windows.Forms.Label();
            this.Btn_Detalle = new System.Windows.Forms.Button();
            this.Dgv_Detalle = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Detalle)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Principal
            // 
            this.Lbl_Principal.AutoSize = true;
            this.Lbl_Principal.Font = new System.Drawing.Font("Rockwell", 18F);
            this.Lbl_Principal.Location = new System.Drawing.Point(288, 9);
            this.Lbl_Principal.Name = "Lbl_Principal";
            this.Lbl_Principal.Size = new System.Drawing.Size(262, 35);
            this.Lbl_Principal.TabIndex = 0;
            this.Lbl_Principal.Text = "Detalle de factura";
            // 
            // Btn_Detalle
            // 
            this.Btn_Detalle.Font = new System.Drawing.Font("Rockwell", 12F);
            this.Btn_Detalle.Location = new System.Drawing.Point(259, 69);
            this.Btn_Detalle.Name = "Btn_Detalle";
            this.Btn_Detalle.Size = new System.Drawing.Size(328, 56);
            this.Btn_Detalle.TabIndex = 1;
            this.Btn_Detalle.Text = "Ver detalle";
            this.Btn_Detalle.UseVisualStyleBackColor = true;
            // 
            // Dgv_Detalle
            // 
            this.Dgv_Detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Detalle.Location = new System.Drawing.Point(37, 168);
            this.Dgv_Detalle.Name = "Dgv_Detalle";
            this.Dgv_Detalle.RowHeadersWidth = 51;
            this.Dgv_Detalle.RowTemplate.Height = 24;
            this.Dgv_Detalle.Size = new System.Drawing.Size(724, 253);
            this.Dgv_Detalle.TabIndex = 2;
            // 
            // Frm_Factura_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Dgv_Detalle);
            this.Controls.Add(this.Btn_Detalle);
            this.Controls.Add(this.Lbl_Principal);
            this.Name = "Frm_Factura_Principal";
            this.Text = "Frm_Factura_Principal";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Detalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Principal;
        private System.Windows.Forms.Button Btn_Detalle;
        private System.Windows.Forms.DataGridView Dgv_Detalle;
    }
}