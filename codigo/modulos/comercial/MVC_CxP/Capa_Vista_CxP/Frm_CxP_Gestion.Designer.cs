
namespace Capa_Vista_CxP
{
    partial class Frm_CxP_Gestion
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
            this.Gpb_Proveedores = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Lbl_Total = new System.Windows.Forms.Label();
            this.Txt_Proveedor = new System.Windows.Forms.TextBox();
            this.Lbl_Proveedor = new System.Windows.Forms.Label();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.Btn_Registro = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Lbl_subtitulo_fechafinal = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Lbl_subtitulo_fechainicial = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Lbl_Numero_factura = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Pagos = new System.Windows.Forms.Button();
            this.Gpb_Proveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Gpb_Proveedores
            // 
            this.Gpb_Proveedores.Controls.Add(this.textBox2);
            this.Gpb_Proveedores.Controls.Add(this.groupBox1);
            this.Gpb_Proveedores.Controls.Add(this.Lbl_Total);
            this.Gpb_Proveedores.Controls.Add(this.Txt_Proveedor);
            this.Gpb_Proveedores.Controls.Add(this.Lbl_Proveedor);
            this.Gpb_Proveedores.Controls.Add(this.Btn_Limpiar);
            this.Gpb_Proveedores.Controls.Add(this.Btn_Registro);
            this.Gpb_Proveedores.Controls.Add(this.dateTimePicker2);
            this.Gpb_Proveedores.Controls.Add(this.Lbl_subtitulo_fechafinal);
            this.Gpb_Proveedores.Controls.Add(this.dateTimePicker1);
            this.Gpb_Proveedores.Controls.Add(this.Lbl_subtitulo_fechainicial);
            this.Gpb_Proveedores.Controls.Add(this.textBox1);
            this.Gpb_Proveedores.Controls.Add(this.Lbl_Numero_factura);
            this.Gpb_Proveedores.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Proveedores.Location = new System.Drawing.Point(6, 5);
            this.Gpb_Proveedores.Name = "Gpb_Proveedores";
            this.Gpb_Proveedores.Size = new System.Drawing.Size(1160, 242);
            this.Gpb_Proveedores.TabIndex = 0;
            this.Gpb_Proveedores.TabStop = false;
            this.Gpb_Proveedores.Text = "Gestión de registro de facturas de proveedores";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(881, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(260, 29);
            this.textBox2.TabIndex = 11;
            // 
            // Lbl_Total
            // 
            this.Lbl_Total.AutoSize = true;
            this.Lbl_Total.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Total.Location = new System.Drawing.Point(711, 91);
            this.Lbl_Total.Name = "Lbl_Total";
            this.Lbl_Total.Size = new System.Drawing.Size(148, 20);
            this.Lbl_Total.TabIndex = 10;
            this.Lbl_Total.Text = "Total de la factura";
            // 
            // Txt_Proveedor
            // 
            this.Txt_Proveedor.Location = new System.Drawing.Point(151, 82);
            this.Txt_Proveedor.Name = "Txt_Proveedor";
            this.Txt_Proveedor.Size = new System.Drawing.Size(362, 29);
            this.Txt_Proveedor.TabIndex = 9;
            // 
            // Lbl_Proveedor
            // 
            this.Lbl_Proveedor.AutoSize = true;
            this.Lbl_Proveedor.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Proveedor.Location = new System.Drawing.Point(26, 91);
            this.Lbl_Proveedor.Name = "Lbl_Proveedor";
            this.Lbl_Proveedor.Size = new System.Drawing.Size(92, 20);
            this.Lbl_Proveedor.TabIndex = 8;
            this.Lbl_Proveedor.Text = "Proveedor";
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.Location = new System.Drawing.Point(212, 193);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(145, 29);
            this.Btn_Limpiar.TabIndex = 7;
            this.Btn_Limpiar.Text = "Limpiar Datos";
            this.Btn_Limpiar.UseVisualStyleBackColor = true;
            // 
            // Btn_Registro
            // 
            this.Btn_Registro.Location = new System.Drawing.Point(24, 194);
            this.Btn_Registro.Name = "Btn_Registro";
            this.Btn_Registro.Size = new System.Drawing.Size(169, 28);
            this.Btn_Registro.TabIndex = 6;
            this.Btn_Registro.Text = "Registrar Factura";
            this.Btn_Registro.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(796, 138);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(345, 29);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // Lbl_subtitulo_fechafinal
            // 
            this.Lbl_subtitulo_fechafinal.AutoSize = true;
            this.Lbl_subtitulo_fechafinal.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_subtitulo_fechafinal.Location = new System.Drawing.Point(629, 144);
            this.Lbl_subtitulo_fechafinal.Name = "Lbl_subtitulo_fechafinal";
            this.Lbl_subtitulo_fechafinal.Size = new System.Drawing.Size(161, 20);
            this.Lbl_subtitulo_fechafinal.TabIndex = 4;
            this.Lbl_subtitulo_fechafinal.Text = "Fecha Vencimiento";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(174, 138);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(339, 29);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // Lbl_subtitulo_fechainicial
            // 
            this.Lbl_subtitulo_fechainicial.AutoSize = true;
            this.Lbl_subtitulo_fechainicial.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_subtitulo_fechainicial.Location = new System.Drawing.Point(26, 144);
            this.Lbl_subtitulo_fechainicial.Name = "Lbl_subtitulo_fechainicial";
            this.Lbl_subtitulo_fechainicial.Size = new System.Drawing.Size(123, 20);
            this.Lbl_subtitulo_fechainicial.TabIndex = 2;
            this.Lbl_subtitulo_fechainicial.Text = "Fecha emisión";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 29);
            this.textBox1.TabIndex = 1;
            // 
            // Lbl_Numero_factura
            // 
            this.Lbl_Numero_factura.AutoSize = true;
            this.Lbl_Numero_factura.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Numero_factura.Location = new System.Drawing.Point(26, 38);
            this.Lbl_Numero_factura.Name = "Lbl_Numero_factura";
            this.Lbl_Numero_factura.Size = new System.Drawing.Size(98, 20);
            this.Lbl_Numero_factura.TabIndex = 0;
            this.Lbl_Numero_factura.Text = "No. Factura";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1154, 550);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1166, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 463);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestión de registro de facturas de proveedores";
            // 
            // Btn_Pagos
            // 
            this.Btn_Pagos.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Pagos.Location = new System.Drawing.Point(1195, 219);
            this.Btn_Pagos.Name = "Btn_Pagos";
            this.Btn_Pagos.Size = new System.Drawing.Size(155, 57);
            this.Btn_Pagos.TabIndex = 12;
            this.Btn_Pagos.Text = "Realizar pago";
            this.Btn_Pagos.UseVisualStyleBackColor = true;
            this.Btn_Pagos.Click += new System.EventHandler(this.Btn_Pagos_Click);
            // 
            // Frm_CxP_Gestiòn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1362, 833);
            this.Controls.Add(this.Btn_Pagos);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Gpb_Proveedores);
            this.MaximumSize = new System.Drawing.Size(1380, 880);
            this.MinimumSize = new System.Drawing.Size(1380, 870);
            this.Name = "Frm_CxP_Gestiòn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_CxP_Recibos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Gpb_Proveedores.ResumeLayout(false);
            this.Gpb_Proveedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gpb_Proveedores;
        private System.Windows.Forms.Button Btn_Limpiar;
        private System.Windows.Forms.Button Btn_Registro;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label Lbl_subtitulo_fechafinal;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Lbl_subtitulo_fechainicial;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Lbl_Numero_factura;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Lbl_Proveedor;
        private System.Windows.Forms.Label Lbl_Total;
        private System.Windows.Forms.TextBox Txt_Proveedor;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Pagos;
    }
}