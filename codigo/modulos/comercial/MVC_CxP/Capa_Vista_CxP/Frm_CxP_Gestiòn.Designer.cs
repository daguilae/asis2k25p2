
namespace Capa_Vista_CxP
{
    partial class Frm_CxP_Gestiòn
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
            this.Lbl_Numero_factura = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Lbl_subtitulo_fechainicial = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Lbl_subtitulo_fechafinal = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Btn_Registro = new System.Windows.Forms.Button();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Lbl_Proveedor = new System.Windows.Forms.Label();
            this.Txt_Proveedor = new System.Windows.Forms.TextBox();
            this.Lbl_Total = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Gpb_Proveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Gpb_Proveedores
            // 
            this.Gpb_Proveedores.Controls.Add(this.textBox2);
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
            this.Gpb_Proveedores.Size = new System.Drawing.Size(850, 190);
            this.Gpb_Proveedores.TabIndex = 0;
            this.Gpb_Proveedores.TabStop = false;
            this.Gpb_Proveedores.Text = "Gestión de registro de facturas de proveedores";
            // 
            // Lbl_Numero_factura
            // 
            this.Lbl_Numero_factura.AutoSize = true;
            this.Lbl_Numero_factura.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Numero_factura.Location = new System.Drawing.Point(20, 28);
            this.Lbl_Numero_factura.Name = "Lbl_Numero_factura";
            this.Lbl_Numero_factura.Size = new System.Drawing.Size(98, 20);
            this.Lbl_Numero_factura.TabIndex = 0;
            this.Lbl_Numero_factura.Text = "No. Factura";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 29);
            this.textBox1.TabIndex = 1;
            // 
            // Lbl_subtitulo_fechainicial
            // 
            this.Lbl_subtitulo_fechainicial.AutoSize = true;
            this.Lbl_subtitulo_fechainicial.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_subtitulo_fechainicial.Location = new System.Drawing.Point(20, 117);
            this.Lbl_subtitulo_fechainicial.Name = "Lbl_subtitulo_fechainicial";
            this.Lbl_subtitulo_fechainicial.Size = new System.Drawing.Size(123, 20);
            this.Lbl_subtitulo_fechainicial.TabIndex = 2;
            this.Lbl_subtitulo_fechainicial.Text = "Fecha emisión";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(149, 111);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(246, 29);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // Lbl_subtitulo_fechafinal
            // 
            this.Lbl_subtitulo_fechafinal.AutoSize = true;
            this.Lbl_subtitulo_fechafinal.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_subtitulo_fechafinal.Location = new System.Drawing.Point(416, 117);
            this.Lbl_subtitulo_fechafinal.Name = "Lbl_subtitulo_fechafinal";
            this.Lbl_subtitulo_fechafinal.Size = new System.Drawing.Size(161, 20);
            this.Lbl_subtitulo_fechafinal.TabIndex = 4;
            this.Lbl_subtitulo_fechafinal.Text = "Fecha Vencimiento";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(583, 111);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(246, 29);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // Btn_Registro
            // 
            this.Btn_Registro.Location = new System.Drawing.Point(24, 157);
            this.Btn_Registro.Name = "Btn_Registro";
            this.Btn_Registro.Size = new System.Drawing.Size(169, 28);
            this.Btn_Registro.TabIndex = 6;
            this.Btn_Registro.Text = "Registrar Factura";
            this.Btn_Registro.UseVisualStyleBackColor = true;
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.Location = new System.Drawing.Point(211, 157);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(145, 29);
            this.Btn_Limpiar.TabIndex = 7;
            this.Btn_Limpiar.Text = "Limpiar Datos";
            this.Btn_Limpiar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(844, 258);
            this.dataGridView1.TabIndex = 1;
            // 
            // Lbl_Proveedor
            // 
            this.Lbl_Proveedor.AutoSize = true;
            this.Lbl_Proveedor.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Proveedor.Location = new System.Drawing.Point(20, 73);
            this.Lbl_Proveedor.Name = "Lbl_Proveedor";
            this.Lbl_Proveedor.Size = new System.Drawing.Size(92, 20);
            this.Lbl_Proveedor.TabIndex = 8;
            this.Lbl_Proveedor.Text = "Proveedor";
            // 
            // Txt_Proveedor
            // 
            this.Txt_Proveedor.Location = new System.Drawing.Point(134, 64);
            this.Txt_Proveedor.Name = "Txt_Proveedor";
            this.Txt_Proveedor.Size = new System.Drawing.Size(206, 29);
            this.Txt_Proveedor.TabIndex = 9;
            // 
            // Lbl_Total
            // 
            this.Lbl_Total.AutoSize = true;
            this.Lbl_Total.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Total.Location = new System.Drawing.Point(429, 73);
            this.Lbl_Total.Name = "Lbl_Total";
            this.Lbl_Total.Size = new System.Drawing.Size(148, 20);
            this.Lbl_Total.TabIndex = 10;
            this.Lbl_Total.Text = "Total de la factura";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(583, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(206, 29);
            this.textBox2.TabIndex = 11;
            // 
            // Frm_CxP_Gestiòn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(868, 471);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Gpb_Proveedores);
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
    }
}