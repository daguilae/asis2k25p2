
namespace Capa_Vista_TipoDeCambio
{
    partial class Frm_TipoDeCambioDia
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Dgv_TipoDeCambioDia = new System.Windows.Forms.DataGridView();
            this.Moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lbl_TipoDeCambioDia = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_TipoDeCambioDia)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Dgv_TipoDeCambioDia);
            this.panel1.Controls.Add(this.Lbl_TipoDeCambioDia);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 425);
            this.panel1.TabIndex = 0;
            // 
            // Dgv_TipoDeCambioDia
            // 
            this.Dgv_TipoDeCambioDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_TipoDeCambioDia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Moneda,
            this.Compra,
            this.Venta});
            this.Dgv_TipoDeCambioDia.Location = new System.Drawing.Point(34, 67);
            this.Dgv_TipoDeCambioDia.Name = "Dgv_TipoDeCambioDia";
            this.Dgv_TipoDeCambioDia.Size = new System.Drawing.Size(345, 330);
            this.Dgv_TipoDeCambioDia.TabIndex = 1;
            // 
            // Moneda
            // 
            this.Moneda.HeaderText = "Moneda";
            this.Moneda.Name = "Moneda";
            // 
            // Compra
            // 
            this.Compra.HeaderText = "Compra";
            this.Compra.Name = "Compra";
            // 
            // Venta
            // 
            this.Venta.HeaderText = "Venta";
            this.Venta.Name = "Venta";
            // 
            // Lbl_TipoDeCambioDia
            // 
            this.Lbl_TipoDeCambioDia.AutoSize = true;
            this.Lbl_TipoDeCambioDia.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TipoDeCambioDia.Location = new System.Drawing.Point(55, 16);
            this.Lbl_TipoDeCambioDia.Name = "Lbl_TipoDeCambioDia";
            this.Lbl_TipoDeCambioDia.Size = new System.Drawing.Size(299, 29);
            this.Lbl_TipoDeCambioDia.TabIndex = 0;
            this.Lbl_TipoDeCambioDia.Text = "Tipo De Cambio Del Dia";
            // 
            // Frm_TipoDeCambioDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_TipoDeCambioDia";
            this.Text = "Frm_TipoDeCambioDia";
            this.Load += new System.EventHandler(this.Frm_TipoDeCambioDia_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_TipoDeCambioDia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_TipoDeCambioDia;
        private System.Windows.Forms.DataGridView Dgv_TipoDeCambioDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Venta;
    }
}