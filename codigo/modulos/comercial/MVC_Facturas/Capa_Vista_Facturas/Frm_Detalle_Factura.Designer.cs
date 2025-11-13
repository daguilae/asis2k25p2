namespace Capa_Vista_Facturas
{
    partial class Frm_Detalle_Factura
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Numero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbl_Fecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lbl_Cliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lbl_Documento;

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView Dgv_Detalle;

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Lbl_Total;

        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button Btn_Imprimir;
        private System.Windows.Forms.Button Btn_Cerrar;

        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Detalle_Factura));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Numero = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lbl_Cliente = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lbl_Documento = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Dgv_Detalle = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Lbl_Total = new System.Windows.Forms.Label();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.Btn_Imprimir = new System.Windows.Forms.Button();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Detalle)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Lbl_Numero);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Lbl_Fecha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Lbl_Cliente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Lbl_Documento);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1176, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encabezado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número:";
            // 
            // Lbl_Numero
            // 
            this.Lbl_Numero.AutoSize = true;
            this.Lbl_Numero.Location = new System.Drawing.Point(80, 26);
            this.Lbl_Numero.Name = "Lbl_Numero";
            this.Lbl_Numero.Size = new System.Drawing.Size(15, 20);
            this.Lbl_Numero.TabIndex = 1;
            this.Lbl_Numero.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(620, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha:";
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Location = new System.Drawing.Point(670, 26);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(15, 20);
            this.Lbl_Fecha.TabIndex = 3;
            this.Lbl_Fecha.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cliente:";
            // 
            // Lbl_Cliente
            // 
            this.Lbl_Cliente.AutoSize = true;
            this.Lbl_Cliente.Location = new System.Drawing.Point(80, 60);
            this.Lbl_Cliente.Name = "Lbl_Cliente";
            this.Lbl_Cliente.Size = new System.Drawing.Size(15, 20);
            this.Lbl_Cliente.TabIndex = 5;
            this.Lbl_Cliente.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(620, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Documento:";
            // 
            // Lbl_Documento
            // 
            this.Lbl_Documento.AutoSize = true;
            this.Lbl_Documento.Location = new System.Drawing.Point(700, 60);
            this.Lbl_Documento.Name = "Lbl_Documento";
            this.Lbl_Documento.Size = new System.Drawing.Size(15, 20);
            this.Lbl_Documento.TabIndex = 7;
            this.Lbl_Documento.Text = "-";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.Dgv_Detalle);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1176, 420);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle";
            // 
            // Dgv_Detalle
            // 
            this.Dgv_Detalle.AllowUserToAddRows = false;
            this.Dgv_Detalle.AllowUserToDeleteRows = false;
            this.Dgv_Detalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Detalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Detalle.ColumnHeadersHeight = 29;
            this.Dgv_Detalle.Location = new System.Drawing.Point(12, 22);
            this.Dgv_Detalle.Name = "Dgv_Detalle";
            this.Dgv_Detalle.ReadOnly = true;
            this.Dgv_Detalle.RowHeadersVisible = false;
            this.Dgv_Detalle.RowHeadersWidth = 51;
            this.Dgv_Detalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Detalle.Size = new System.Drawing.Size(1152, 386);
            this.Dgv_Detalle.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.Lbl_Total);
            this.groupBox3.Location = new System.Drawing.Point(12, 544);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(840, 80);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Totales";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(20, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "TOTAL:";
            // 
            // Lbl_Total
            // 
            this.Lbl_Total.AutoSize = true;
            this.Lbl_Total.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.Lbl_Total.ForeColor = System.Drawing.Color.ForestGreen;
            this.Lbl_Total.Location = new System.Drawing.Point(110, 29);
            this.Lbl_Total.Name = "Lbl_Total";
            this.Lbl_Total.Size = new System.Drawing.Size(64, 32);
            this.Lbl_Total.TabIndex = 1;
            this.Lbl_Total.Text = "0.00";
            // 
            // panelBotones
            // 
            this.panelBotones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBotones.Controls.Add(this.Btn_Imprimir);
            this.panelBotones.Controls.Add(this.Btn_Cerrar);
            this.panelBotones.Location = new System.Drawing.Point(858, 544);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(330, 80);
            this.panelBotones.TabIndex = 3;
            // 
            // Btn_Imprimir
            // 
            this.Btn_Imprimir.Location = new System.Drawing.Point(24, 23);
            this.Btn_Imprimir.Name = "Btn_Imprimir";
            this.Btn_Imprimir.Size = new System.Drawing.Size(120, 34);
            this.Btn_Imprimir.TabIndex = 0;
            this.Btn_Imprimir.Text = "Imprimir";
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Location = new System.Drawing.Point(170, 23);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(120, 34);
            this.Btn_Cerrar.TabIndex = 1;
            this.Btn_Cerrar.Text = "Cerrar";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Frm_Detalle_Factura
            // 
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panelBotones);
            this.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Detalle_Factura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de Factura";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Detalle)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
