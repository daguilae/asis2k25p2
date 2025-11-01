
namespace Capa_vista_Check_In_Check_out
{
    partial class Frm_Check_Out
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Check_Out));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Gbp_Titulo = new System.Windows.Forms.GroupBox();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Gbp_Campos = new System.Windows.Forms.GroupBox();
            this.Cbo_Huesped = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Lbl_idreserva = new System.Windows.Forms.Label();
            this.Lbl_IdcheckOut = new System.Windows.Forms.Label();
            this.Lbl_Icheck_in = new System.Windows.Forms.Label();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Reporte = new System.Windows.Forms.Button();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.Btn_Ayuda = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Gbp_Titulo.SuspendLayout();
            this.Gbp_Campos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 285);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1309, 476);
            this.dataGridView1.TabIndex = 15;
            // 
            // Gbp_Titulo
            // 
            this.Gbp_Titulo.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.Gbp_Titulo.Controls.Add(this.Lbl_titulo);
            this.Gbp_Titulo.Location = new System.Drawing.Point(27, 12);
            this.Gbp_Titulo.Name = "Gbp_Titulo";
            this.Gbp_Titulo.Size = new System.Drawing.Size(366, 80);
            this.Gbp_Titulo.TabIndex = 14;
            this.Gbp_Titulo.TabStop = false;
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.BackColor = System.Drawing.SystemColors.Control;
            this.Lbl_titulo.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.Location = new System.Drawing.Point(138, 41);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(104, 21);
            this.Lbl_titulo.TabIndex = 0;
            this.Lbl_titulo.Text = "Check Out";
            // 
            // Gbp_Campos
            // 
            this.Gbp_Campos.Controls.Add(this.Cbo_Huesped);
            this.Gbp_Campos.Controls.Add(this.textBox1);
            this.Gbp_Campos.Controls.Add(this.Lbl_Fecha);
            this.Gbp_Campos.Controls.Add(this.dateTimePicker1);
            this.Gbp_Campos.Controls.Add(this.Lbl_idreserva);
            this.Gbp_Campos.Controls.Add(this.Lbl_IdcheckOut);
            this.Gbp_Campos.Controls.Add(this.Lbl_Icheck_in);
            this.Gbp_Campos.Location = new System.Drawing.Point(27, 98);
            this.Gbp_Campos.Name = "Gbp_Campos";
            this.Gbp_Campos.Size = new System.Drawing.Size(1309, 170);
            this.Gbp_Campos.TabIndex = 13;
            this.Gbp_Campos.TabStop = false;
            // 
            // Cbo_Huesped
            // 
            this.Cbo_Huesped.FormattingEnabled = true;
            this.Cbo_Huesped.Location = new System.Drawing.Point(232, 76);
            this.Cbo_Huesped.Name = "Cbo_Huesped";
            this.Cbo_Huesped.Size = new System.Drawing.Size(695, 24);
            this.Cbo_Huesped.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 22);
            this.textBox1.TabIndex = 7;
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha.Location = new System.Drawing.Point(1046, 41);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(56, 20);
            this.Lbl_Fecha.TabIndex = 5;
            this.Lbl_Fecha.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(957, 80);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(257, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // Lbl_idreserva
            // 
            this.Lbl_idreserva.AutoSize = true;
            this.Lbl_idreserva.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_idreserva.Location = new System.Drawing.Point(530, 29);
            this.Lbl_idreserva.Name = "Lbl_idreserva";
            this.Lbl_idreserva.Size = new System.Drawing.Size(0, 20);
            this.Lbl_idreserva.TabIndex = 3;
            // 
            // Lbl_IdcheckOut
            // 
            this.Lbl_IdcheckOut.AutoSize = true;
            this.Lbl_IdcheckOut.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_IdcheckOut.Location = new System.Drawing.Point(47, 41);
            this.Lbl_IdcheckOut.Name = "Lbl_IdcheckOut";
            this.Lbl_IdcheckOut.Size = new System.Drawing.Size(109, 20);
            this.Lbl_IdcheckOut.TabIndex = 1;
            this.Lbl_IdcheckOut.Text = "Id Check out";
            // 
            // Lbl_Icheck_in
            // 
            this.Lbl_Icheck_in.AutoSize = true;
            this.Lbl_Icheck_in.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Icheck_in.Location = new System.Drawing.Point(501, 41);
            this.Lbl_Icheck_in.Name = "Lbl_Icheck_in";
            this.Lbl_Icheck_in.Size = new System.Drawing.Size(80, 20);
            this.Lbl_Icheck_in.TabIndex = 2;
            this.Lbl_Icheck_in.Text = "Check In";
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.Color.White;
            this.Btn_Salir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Salir.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Salir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Salir.Image")));
            this.Btn_Salir.Location = new System.Drawing.Point(1286, 29);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(66, 63);
            this.Btn_Salir.TabIndex = 23;
            this.Btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Salir.UseVisualStyleBackColor = false;
            // 
            // Btn_Reporte
            // 
            this.Btn_Reporte.BackColor = System.Drawing.Color.White;
            this.Btn_Reporte.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Reporte.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Reporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Reporte.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Reporte.Image")));
            this.Btn_Reporte.Location = new System.Drawing.Point(1126, 29);
            this.Btn_Reporte.Name = "Btn_Reporte";
            this.Btn_Reporte.Size = new System.Drawing.Size(76, 68);
            this.Btn_Reporte.TabIndex = 26;
            this.Btn_Reporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Reporte.UseVisualStyleBackColor = false;
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.BackColor = System.Drawing.Color.White;
            this.Btn_Limpiar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Limpiar.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Limpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Limpiar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Limpiar.Image")));
            this.Btn_Limpiar.Location = new System.Drawing.Point(1029, 29);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(89, 68);
            this.Btn_Limpiar.TabIndex = 22;
            this.Btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Limpiar.UseVisualStyleBackColor = false;
            // 
            // Btn_Ayuda
            // 
            this.Btn_Ayuda.BackColor = System.Drawing.Color.White;
            this.Btn_Ayuda.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Ayuda.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Ayuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ayuda.Image")));
            this.Btn_Ayuda.Location = new System.Drawing.Point(1209, 29);
            this.Btn_Ayuda.Name = "Btn_Ayuda";
            this.Btn_Ayuda.Size = new System.Drawing.Size(69, 68);
            this.Btn_Ayuda.TabIndex = 25;
            this.Btn_Ayuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Ayuda.UseVisualStyleBackColor = false;
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.Color.White;
            this.Btn_Eliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Eliminar.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Eliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Eliminar.Image")));
            this.Btn_Eliminar.Location = new System.Drawing.Point(941, 29);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(81, 68);
            this.Btn_Eliminar.TabIndex = 24;
            this.Btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.BackColor = System.Drawing.Color.White;
            this.Btn_Nuevo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Nuevo.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Nuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Nuevo.Image")));
            this.Btn_Nuevo.Location = new System.Drawing.Point(696, 29);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(64, 68);
            this.Btn_Nuevo.TabIndex = 20;
            this.Btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Nuevo.UseVisualStyleBackColor = false;
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.BackColor = System.Drawing.Color.White;
            this.Btn_Modificar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Modificar.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Modificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Modificar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Modificar.Image")));
            this.Btn_Modificar.Location = new System.Drawing.Point(851, 29);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(74, 68);
            this.Btn_Modificar.TabIndex = 21;
            this.Btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Modificar.UseVisualStyleBackColor = false;
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.White;
            this.Btn_guardar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_guardar.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_guardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_guardar.Image")));
            this.Btn_guardar.Location = new System.Drawing.Point(767, 29);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(63, 68);
            this.Btn_guardar.TabIndex = 19;
            this.Btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_guardar.UseVisualStyleBackColor = false;
            // 
            // Check_Out
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 788);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Reporte);
            this.Controls.Add(this.Btn_Limpiar);
            this.Controls.Add(this.Btn_Ayuda);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Nuevo);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Gbp_Titulo);
            this.Controls.Add(this.Gbp_Campos);
            this.Name = "Check_Out";
            this.Text = "Check_Out";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Gbp_Titulo.ResumeLayout(false);
            this.Gbp_Titulo.PerformLayout();
            this.Gbp_Campos.ResumeLayout(false);
            this.Gbp_Campos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox Gbp_Titulo;
        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.GroupBox Gbp_Campos;
        private System.Windows.Forms.ComboBox Cbo_Huesped;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Lbl_Fecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Lbl_idreserva;
        private System.Windows.Forms.Label Lbl_IdcheckOut;
        private System.Windows.Forms.Label Lbl_Icheck_in;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Reporte;
        private System.Windows.Forms.Button Btn_Limpiar;
        private System.Windows.Forms.Button Btn_Ayuda;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_guardar;
    }
}