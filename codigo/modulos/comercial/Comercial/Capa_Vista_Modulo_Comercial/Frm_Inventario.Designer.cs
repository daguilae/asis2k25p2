
namespace Capa_Vista_Modulo_Comercial
{
    partial class Frm_Inventario
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
            this.Pnl_Principal = new System.Windows.Forms.Panel();
            this.Pnl_Vista_Producto = new System.Windows.Forms.Panel();
            this.Dgv_Vista_Producto = new System.Windows.Forms.DataGridView();
            this.Gpb_Caracteristicas_Inventario = new System.Windows.Forms.GroupBox();
            this.Cbo_Tipo_Operacion = new System.Windows.Forms.ComboBox();
            this.Lbl_Tipo_Operacion = new System.Windows.Forms.Label();
            this.Pnl_Principal.SuspendLayout();
            this.Pnl_Vista_Producto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Vista_Producto)).BeginInit();
            this.Gpb_Caracteristicas_Inventario.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Principal
            // 
            this.Pnl_Principal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_Principal.Controls.Add(this.Gpb_Caracteristicas_Inventario);
            this.Pnl_Principal.Location = new System.Drawing.Point(12, 12);
            this.Pnl_Principal.Name = "Pnl_Principal";
            this.Pnl_Principal.Size = new System.Drawing.Size(810, 269);
            this.Pnl_Principal.TabIndex = 0;
            // 
            // Pnl_Vista_Producto
            // 
            this.Pnl_Vista_Producto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_Vista_Producto.Controls.Add(this.Dgv_Vista_Producto);
            this.Pnl_Vista_Producto.Location = new System.Drawing.Point(12, 287);
            this.Pnl_Vista_Producto.Name = "Pnl_Vista_Producto";
            this.Pnl_Vista_Producto.Size = new System.Drawing.Size(810, 262);
            this.Pnl_Vista_Producto.TabIndex = 1;
            // 
            // Dgv_Vista_Producto
            // 
            this.Dgv_Vista_Producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Vista_Producto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_Vista_Producto.Location = new System.Drawing.Point(0, 0);
            this.Dgv_Vista_Producto.Name = "Dgv_Vista_Producto";
            this.Dgv_Vista_Producto.Size = new System.Drawing.Size(810, 262);
            this.Dgv_Vista_Producto.TabIndex = 0;
            // 
            // Gpb_Caracteristicas_Inventario
            // 
            this.Gpb_Caracteristicas_Inventario.Controls.Add(this.Lbl_Tipo_Operacion);
            this.Gpb_Caracteristicas_Inventario.Controls.Add(this.Cbo_Tipo_Operacion);
            this.Gpb_Caracteristicas_Inventario.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Caracteristicas_Inventario.Location = new System.Drawing.Point(3, 3);
            this.Gpb_Caracteristicas_Inventario.Name = "Gpb_Caracteristicas_Inventario";
            this.Gpb_Caracteristicas_Inventario.Size = new System.Drawing.Size(370, 125);
            this.Gpb_Caracteristicas_Inventario.TabIndex = 0;
            this.Gpb_Caracteristicas_Inventario.TabStop = false;
            this.Gpb_Caracteristicas_Inventario.Text = "Movimientos de Inventario";
            // 
            // Cbo_Tipo_Operacion
            // 
            this.Cbo_Tipo_Operacion.FormattingEnabled = true;
            this.Cbo_Tipo_Operacion.Items.AddRange(new object[] {
            "Ventas (-)",
            "Compras (+)",
            "Envios (-)",
            "Devol. Prod. Dañado (+)",
            "Devol. A Huespedes (-)"});
            this.Cbo_Tipo_Operacion.Location = new System.Drawing.Point(155, 24);
            this.Cbo_Tipo_Operacion.Name = "Cbo_Tipo_Operacion";
            this.Cbo_Tipo_Operacion.Size = new System.Drawing.Size(209, 26);
            this.Cbo_Tipo_Operacion.TabIndex = 0;
            // 
            // Lbl_Tipo_Operacion
            // 
            this.Lbl_Tipo_Operacion.AutoSize = true;
            this.Lbl_Tipo_Operacion.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Tipo_Operacion.Location = new System.Drawing.Point(8, 27);
            this.Lbl_Tipo_Operacion.Name = "Lbl_Tipo_Operacion";
            this.Lbl_Tipo_Operacion.Size = new System.Drawing.Size(141, 17);
            this.Lbl_Tipo_Operacion.TabIndex = 1;
            this.Lbl_Tipo_Operacion.Text = "Tipo de Operacion";
            // 
            // Frm_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.Controls.Add(this.Pnl_Vista_Producto);
            this.Controls.Add(this.Pnl_Principal);
            this.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(850, 600);
            this.Name = "Frm_Inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.Pnl_Principal.ResumeLayout(false);
            this.Pnl_Vista_Producto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Vista_Producto)).EndInit();
            this.Gpb_Caracteristicas_Inventario.ResumeLayout(false);
            this.Gpb_Caracteristicas_Inventario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Principal;
        private System.Windows.Forms.Panel Pnl_Vista_Producto;
        private System.Windows.Forms.GroupBox Gpb_Caracteristicas_Inventario;
        private System.Windows.Forms.DataGridView Dgv_Vista_Producto;
        private System.Windows.Forms.ComboBox Cbo_Tipo_Operacion;
        private System.Windows.Forms.Label Lbl_Tipo_Operacion;
    }
}