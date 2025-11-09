
namespace Capa_vista_Check_In_Check_out
{
    partial class Frm_Detalle_Folio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Detalle_Folio));
            this.Gbp_Titulo = new System.Windows.Forms.GroupBox();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_IdcheckOut = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Gbp_Datos = new System.Windows.Forms.GroupBox();
            this.Txt_Numero_Habitaciones = new System.Windows.Forms.TextBox();
            this.Lbl_Numero_Habitacion = new System.Windows.Forms.Label();
            this.Cbo_Folios = new System.Windows.Forms.ComboBox();
            this.Lbl_Idfolio = new System.Windows.Forms.Label();
            this.Txt_Fecha_Creacion = new System.Windows.Forms.TextBox();
            this.Txt_Numero_Documentos = new System.Windows.Forms.TextBox();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Lbl_Fecha_Creacion = new System.Windows.Forms.Label();
            this.Lbl_Numero_Documento = new System.Windows.Forms.Label();
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.Dgv_Movimientos = new System.Windows.Forms.DataGridView();
            this.Lbl_Estado = new System.Windows.Forms.Label();
            this.Txt_Estado = new System.Windows.Forms.TextBox();
            this.Lbl_Total = new System.Windows.Forms.Label();
            this.Txt_Total = new System.Windows.Forms.TextBox();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Reporte = new System.Windows.Forms.Button();
            this.Btn_Ayuda = new System.Windows.Forms.Button();
            this.Gbp_Titulo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Gbp_Datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Movimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // Gbp_Titulo
            // 
            this.Gbp_Titulo.Controls.Add(this.Lbl_Titulo);
            this.Gbp_Titulo.Location = new System.Drawing.Point(12, 12);
            this.Gbp_Titulo.Name = "Gbp_Titulo";
            this.Gbp_Titulo.Size = new System.Drawing.Size(366, 80);
            this.Gbp_Titulo.TabIndex = 26;
            this.Gbp_Titulo.TabStop = false;
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.BackColor = System.Drawing.SystemColors.Control;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(81, 33);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(128, 21);
            this.Lbl_Titulo.TabIndex = 0;
            this.Lbl_Titulo.Text = "Detalle_Folio";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Lbl_IdcheckOut);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1438, 293);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del cliente ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(186, 223);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(1169, 27);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(224, 121);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(1131, 27);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1229, 27);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha de Creacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero de Documento ";
            // 
            // Lbl_IdcheckOut
            // 
            this.Lbl_IdcheckOut.AutoSize = true;
            this.Lbl_IdcheckOut.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_IdcheckOut.Location = new System.Drawing.Point(16, 49);
            this.Lbl_IdcheckOut.Name = "Lbl_IdcheckOut";
            this.Lbl_IdcheckOut.Size = new System.Drawing.Size(82, 20);
            this.Lbl_IdcheckOut.TabIndex = 2;
            this.Lbl_IdcheckOut.Text = "Nombre :";
            // 
            // Gbp_Datos
            // 
            this.Gbp_Datos.Controls.Add(this.Txt_Numero_Habitaciones);
            this.Gbp_Datos.Controls.Add(this.Lbl_Numero_Habitacion);
            this.Gbp_Datos.Controls.Add(this.Cbo_Folios);
            this.Gbp_Datos.Controls.Add(this.Lbl_Idfolio);
            this.Gbp_Datos.Controls.Add(this.Txt_Fecha_Creacion);
            this.Gbp_Datos.Controls.Add(this.Txt_Numero_Documentos);
            this.Gbp_Datos.Controls.Add(this.Txt_Nombre);
            this.Gbp_Datos.Controls.Add(this.Lbl_Fecha_Creacion);
            this.Gbp_Datos.Controls.Add(this.Lbl_Numero_Documento);
            this.Gbp_Datos.Controls.Add(this.Lbl_Nombre);
            this.Gbp_Datos.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gbp_Datos.Location = new System.Drawing.Point(12, 129);
            this.Gbp_Datos.Name = "Gbp_Datos";
            this.Gbp_Datos.Size = new System.Drawing.Size(1586, 293);
            this.Gbp_Datos.TabIndex = 27;
            this.Gbp_Datos.TabStop = false;
            this.Gbp_Datos.Text = "Datos del cliente ";
            // 
            // Txt_Numero_Habitaciones
            // 
            this.Txt_Numero_Habitaciones.Location = new System.Drawing.Point(217, 169);
            this.Txt_Numero_Habitaciones.Name = "Txt_Numero_Habitaciones";
            this.Txt_Numero_Habitaciones.Size = new System.Drawing.Size(1329, 27);
            this.Txt_Numero_Habitaciones.TabIndex = 11;
            // 
            // Lbl_Numero_Habitacion
            // 
            this.Lbl_Numero_Habitacion.AutoSize = true;
            this.Lbl_Numero_Habitacion.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Numero_Habitacion.Location = new System.Drawing.Point(0, 172);
            this.Lbl_Numero_Habitacion.Name = "Lbl_Numero_Habitacion";
            this.Lbl_Numero_Habitacion.Size = new System.Drawing.Size(190, 20);
            this.Lbl_Numero_Habitacion.TabIndex = 10;
            this.Lbl_Numero_Habitacion.Text = "Numero de Habitacion:";
            // 
            // Cbo_Folios
            // 
            this.Cbo_Folios.FormattingEnabled = true;
            this.Cbo_Folios.Location = new System.Drawing.Point(117, 75);
            this.Cbo_Folios.Name = "Cbo_Folios";
            this.Cbo_Folios.Size = new System.Drawing.Size(1416, 28);
            this.Cbo_Folios.TabIndex = 9;
            this.Cbo_Folios.SelectedIndexChanged += new System.EventHandler(this.Cbo_Folios_SelectedIndexChanged);
            // 
            // Lbl_Idfolio
            // 
            this.Lbl_Idfolio.AutoSize = true;
            this.Lbl_Idfolio.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Idfolio.Location = new System.Drawing.Point(16, 78);
            this.Lbl_Idfolio.Name = "Lbl_Idfolio";
            this.Lbl_Idfolio.Size = new System.Drawing.Size(76, 20);
            this.Lbl_Idfolio.TabIndex = 8;
            this.Lbl_Idfolio.Text = "Id Folio :";
            // 
            // Txt_Fecha_Creacion
            // 
            this.Txt_Fecha_Creacion.Location = new System.Drawing.Point(168, 256);
            this.Txt_Fecha_Creacion.Name = "Txt_Fecha_Creacion";
            this.Txt_Fecha_Creacion.Size = new System.Drawing.Size(1347, 27);
            this.Txt_Fecha_Creacion.TabIndex = 7;
            // 
            // Txt_Numero_Documentos
            // 
            this.Txt_Numero_Documentos.Location = new System.Drawing.Point(217, 206);
            this.Txt_Numero_Documentos.Name = "Txt_Numero_Documentos";
            this.Txt_Numero_Documentos.Size = new System.Drawing.Size(1322, 27);
            this.Txt_Numero_Documentos.TabIndex = 6;
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(117, 117);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(1435, 27);
            this.Txt_Nombre.TabIndex = 5;
            // 
            // Lbl_Fecha_Creacion
            // 
            this.Lbl_Fecha_Creacion.AutoSize = true;
            this.Lbl_Fecha_Creacion.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha_Creacion.Location = new System.Drawing.Point(-4, 253);
            this.Lbl_Fecha_Creacion.Name = "Lbl_Fecha_Creacion";
            this.Lbl_Fecha_Creacion.Size = new System.Drawing.Size(166, 20);
            this.Lbl_Fecha_Creacion.TabIndex = 4;
            this.Lbl_Fecha_Creacion.Text = "Fecha de Creacion ;";
            // 
            // Lbl_Numero_Documento
            // 
            this.Lbl_Numero_Documento.AutoSize = true;
            this.Lbl_Numero_Documento.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Numero_Documento.Location = new System.Drawing.Point(-3, 213);
            this.Lbl_Numero_Documento.Name = "Lbl_Numero_Documento";
            this.Lbl_Numero_Documento.Size = new System.Drawing.Size(205, 20);
            this.Lbl_Numero_Documento.TabIndex = 3;
            this.Lbl_Numero_Documento.Text = "Numero de Documento : ";
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nombre.Location = new System.Drawing.Point(16, 121);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(82, 20);
            this.Lbl_Nombre.TabIndex = 2;
            this.Lbl_Nombre.Text = "Nombre :";
            // 
            // Dgv_Movimientos
            // 
            this.Dgv_Movimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Movimientos.Location = new System.Drawing.Point(13, 437);
            this.Dgv_Movimientos.Name = "Dgv_Movimientos";
            this.Dgv_Movimientos.RowHeadersWidth = 51;
            this.Dgv_Movimientos.RowTemplate.Height = 24;
            this.Dgv_Movimientos.Size = new System.Drawing.Size(1585, 439);
            this.Dgv_Movimientos.TabIndex = 28;
            // 
            // Lbl_Estado
            // 
            this.Lbl_Estado.AutoSize = true;
            this.Lbl_Estado.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Estado.Location = new System.Drawing.Point(37, 910);
            this.Lbl_Estado.Name = "Lbl_Estado";
            this.Lbl_Estado.Size = new System.Drawing.Size(67, 20);
            this.Lbl_Estado.TabIndex = 8;
            this.Lbl_Estado.Text = "Estado:";
            // 
            // Txt_Estado
            // 
            this.Txt_Estado.Location = new System.Drawing.Point(157, 908);
            this.Txt_Estado.Name = "Txt_Estado";
            this.Txt_Estado.Size = new System.Drawing.Size(341, 22);
            this.Txt_Estado.TabIndex = 30;
            // 
            // Lbl_Total
            // 
            this.Lbl_Total.AutoSize = true;
            this.Lbl_Total.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Total.Location = new System.Drawing.Point(1261, 900);
            this.Lbl_Total.Name = "Lbl_Total";
            this.Lbl_Total.Size = new System.Drawing.Size(48, 20);
            this.Lbl_Total.TabIndex = 31;
            this.Lbl_Total.Text = "Total";
            // 
            // Txt_Total
            // 
            this.Txt_Total.Location = new System.Drawing.Point(1338, 898);
            this.Txt_Total.Name = "Txt_Total";
            this.Txt_Total.Size = new System.Drawing.Size(220, 22);
            this.Txt_Total.TabIndex = 32;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.Color.White;
            this.Btn_Salir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Salir.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Salir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Salir.Image")));
            this.Btn_Salir.Location = new System.Drawing.Point(1549, 8);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(66, 63);
            this.Btn_Salir.TabIndex = 38;
            this.Btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_Reporte
            // 
            this.Btn_Reporte.BackColor = System.Drawing.Color.White;
            this.Btn_Reporte.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Reporte.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Reporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Reporte.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Reporte.Image")));
            this.Btn_Reporte.Location = new System.Drawing.Point(1392, 8);
            this.Btn_Reporte.Name = "Btn_Reporte";
            this.Btn_Reporte.Size = new System.Drawing.Size(76, 68);
            this.Btn_Reporte.TabIndex = 39;
            this.Btn_Reporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Reporte.UseVisualStyleBackColor = false;
            this.Btn_Reporte.Click += new System.EventHandler(this.Btn_Reporte_Click);
            // 
            // Btn_Ayuda
            // 
            this.Btn_Ayuda.BackColor = System.Drawing.Color.White;
            this.Btn_Ayuda.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Ayuda.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Ayuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ayuda.Image")));
            this.Btn_Ayuda.Location = new System.Drawing.Point(1474, 7);
            this.Btn_Ayuda.Name = "Btn_Ayuda";
            this.Btn_Ayuda.Size = new System.Drawing.Size(69, 68);
            this.Btn_Ayuda.TabIndex = 40;
            this.Btn_Ayuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Ayuda.UseVisualStyleBackColor = false;
            // 
            // Frm_Detalle_Folio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1612, 950);
            this.Controls.Add(this.Btn_Ayuda);
            this.Controls.Add(this.Btn_Reporte);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Txt_Total);
            this.Controls.Add(this.Lbl_Total);
            this.Controls.Add(this.Txt_Estado);
            this.Controls.Add(this.Lbl_Estado);
            this.Controls.Add(this.Dgv_Movimientos);
            this.Controls.Add(this.Gbp_Datos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Gbp_Titulo);
            this.Name = "Frm_Detalle_Folio";
            this.Text = "Frm_Detalle_Folio";
            this.Gbp_Titulo.ResumeLayout(false);
            this.Gbp_Titulo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Gbp_Datos.ResumeLayout(false);
            this.Gbp_Datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Movimientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Gbp_Titulo;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_IdcheckOut;
        private System.Windows.Forms.GroupBox Gbp_Datos;
        private System.Windows.Forms.TextBox Txt_Fecha_Creacion;
        private System.Windows.Forms.TextBox Txt_Numero_Documentos;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Label Lbl_Fecha_Creacion;
        private System.Windows.Forms.Label Lbl_Numero_Documento;
        private System.Windows.Forms.Label Lbl_Nombre;
        private System.Windows.Forms.DataGridView Dgv_Movimientos;
        private System.Windows.Forms.Label Lbl_Estado;
        private System.Windows.Forms.TextBox Txt_Estado;
        private System.Windows.Forms.Label Lbl_Total;
        private System.Windows.Forms.TextBox Txt_Total;
        private System.Windows.Forms.ComboBox Cbo_Folios;
        private System.Windows.Forms.Label Lbl_Idfolio;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Reporte;
        private System.Windows.Forms.TextBox Txt_Numero_Habitaciones;
        private System.Windows.Forms.Label Lbl_Numero_Habitacion;
        private System.Windows.Forms.Button Btn_Ayuda;
    }
}