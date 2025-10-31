
namespace Capa_vista_Check_In_Check_out
{
    partial class Frm_Check_In
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
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Lbl_Idcheckin = new System.Windows.Forms.Label();
            this.Lbl_Idhuesped = new System.Windows.Forms.Label();
            this.Gbp_Campos = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Lbl_estado = new System.Windows.Forms.Label();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Lbl_idreserva = new System.Windows.Forms.Label();
            this.Gbp_Titulo = new System.Windows.Forms.GroupBox();
            this.Cbo_Huesped = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Gbp_opc = new System.Windows.Forms.GroupBox();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Btn_nuevo = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Btn_modificar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Gbp_Campos.SuspendLayout();
            this.Gbp_Titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Gbp_opc.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.BackColor = System.Drawing.SystemColors.Control;
            this.Lbl_titulo.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.Location = new System.Drawing.Point(110, 33);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(94, 21);
            this.Lbl_titulo.TabIndex = 0;
            this.Lbl_titulo.Text = "Check In ";
            // 
            // Lbl_Idcheckin
            // 
            this.Lbl_Idcheckin.AutoSize = true;
            this.Lbl_Idcheckin.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Idcheckin.Location = new System.Drawing.Point(23, 29);
            this.Lbl_Idcheckin.Name = "Lbl_Idcheckin";
            this.Lbl_Idcheckin.Size = new System.Drawing.Size(99, 20);
            this.Lbl_Idcheckin.TabIndex = 1;
            this.Lbl_Idcheckin.Text = "Id Check In";
            // 
            // Lbl_Idhuesped
            // 
            this.Lbl_Idhuesped.AutoSize = true;
            this.Lbl_Idhuesped.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Idhuesped.Location = new System.Drawing.Point(235, 29);
            this.Lbl_Idhuesped.Name = "Lbl_Idhuesped";
            this.Lbl_Idhuesped.Size = new System.Drawing.Size(83, 20);
            this.Lbl_Idhuesped.TabIndex = 2;
            this.Lbl_Idhuesped.Text = " Huesped";
            // 
            // Gbp_Campos
            // 
            this.Gbp_Campos.Controls.Add(this.comboBox2);
            this.Gbp_Campos.Controls.Add(this.comboBox1);
            this.Gbp_Campos.Controls.Add(this.Cbo_Huesped);
            this.Gbp_Campos.Controls.Add(this.textBox1);
            this.Gbp_Campos.Controls.Add(this.Lbl_estado);
            this.Gbp_Campos.Controls.Add(this.Lbl_Fecha);
            this.Gbp_Campos.Controls.Add(this.dateTimePicker1);
            this.Gbp_Campos.Controls.Add(this.Lbl_idreserva);
            this.Gbp_Campos.Controls.Add(this.Lbl_Idcheckin);
            this.Gbp_Campos.Controls.Add(this.Lbl_Idhuesped);
            this.Gbp_Campos.Location = new System.Drawing.Point(12, 111);
            this.Gbp_Campos.Name = "Gbp_Campos";
            this.Gbp_Campos.Size = new System.Drawing.Size(1371, 170);
            this.Gbp_Campos.TabIndex = 3;
            this.Gbp_Campos.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(95, 22);
            this.textBox1.TabIndex = 7;
            // 
            // Lbl_estado
            // 
            this.Lbl_estado.AutoSize = true;
            this.Lbl_estado.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_estado.Location = new System.Drawing.Point(1058, 29);
            this.Lbl_estado.Name = "Lbl_estado";
            this.Lbl_estado.Size = new System.Drawing.Size(62, 20);
            this.Lbl_estado.TabIndex = 6;
            this.Lbl_estado.Text = "Estado";
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha.Location = new System.Drawing.Point(816, 34);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(56, 20);
            this.Lbl_Fecha.TabIndex = 5;
            this.Lbl_Fecha.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(757, 74);
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
            this.Lbl_idreserva.Size = new System.Drawing.Size(90, 25);
            this.Lbl_idreserva.TabIndex = 3;
            this.Lbl_idreserva.Text = "Reserva";
            // 
            // Gbp_Titulo
            // 
            this.Gbp_Titulo.Controls.Add(this.Lbl_titulo);
            this.Gbp_Titulo.Location = new System.Drawing.Point(419, 25);
            this.Gbp_Titulo.Name = "Gbp_Titulo";
            this.Gbp_Titulo.Size = new System.Drawing.Size(366, 80);
            this.Gbp_Titulo.TabIndex = 4;
            this.Gbp_Titulo.TabStop = false;
            // 
            // Cbo_Huesped
            // 
            this.Cbo_Huesped.FormattingEnabled = true;
            this.Cbo_Huesped.Location = new System.Drawing.Point(163, 76);
            this.Cbo_Huesped.Name = "Cbo_Huesped";
            this.Cbo_Huesped.Size = new System.Drawing.Size(280, 24);
            this.Cbo_Huesped.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(471, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(280, 24);
            this.comboBox1.TabIndex = 9;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(1042, 72);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(280, 24);
            this.comboBox2.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 298);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1120, 478);
            this.dataGridView1.TabIndex = 11;
            // 
            // Gbp_opc
            // 
            this.Gbp_opc.Controls.Add(this.Btn_Eliminar);
            this.Gbp_opc.Controls.Add(this.Btn_salir);
            this.Gbp_opc.Controls.Add(this.Btn_nuevo);
            this.Gbp_opc.Controls.Add(this.Btn_cancelar);
            this.Gbp_opc.Controls.Add(this.Btn_modificar);
            this.Gbp_opc.Controls.Add(this.Btn_guardar);
            this.Gbp_opc.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gbp_opc.Location = new System.Drawing.Point(1148, 298);
            this.Gbp_opc.Name = "Gbp_opc";
            this.Gbp_opc.Size = new System.Drawing.Size(227, 472);
            this.Gbp_opc.TabIndex = 12;
            this.Gbp_opc.TabStop = false;
            this.Gbp_opc.Text = "Opciones";
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(88)))));
            this.Btn_Eliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Eliminar.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Eliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Eliminar.Location = new System.Drawing.Point(30, 241);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(143, 54);
            this.Btn_Eliminar.TabIndex = 5;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            // 
            // Btn_salir
            // 
            this.Btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(88)))));
            this.Btn_salir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_salir.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_salir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_salir.Location = new System.Drawing.Point(30, 381);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(143, 54);
            this.Btn_salir.TabIndex = 4;
            this.Btn_salir.Text = "Salir";
            this.Btn_salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_salir.UseVisualStyleBackColor = false;
            // 
            // Btn_nuevo
            // 
            this.Btn_nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(88)))));
            this.Btn_nuevo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_nuevo.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_nuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_nuevo.Location = new System.Drawing.Point(30, 171);
            this.Btn_nuevo.Name = "Btn_nuevo";
            this.Btn_nuevo.Size = new System.Drawing.Size(143, 54);
            this.Btn_nuevo.TabIndex = 1;
            this.Btn_nuevo.Text = "Nuevo";
            this.Btn_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_nuevo.UseVisualStyleBackColor = false;
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(88)))));
            this.Btn_cancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_cancelar.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_cancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_cancelar.Location = new System.Drawing.Point(30, 311);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(143, 54);
            this.Btn_cancelar.TabIndex = 3;
            this.Btn_cancelar.Text = "Cancelar";
            this.Btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // Btn_modificar
            // 
            this.Btn_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(88)))));
            this.Btn_modificar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_modificar.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_modificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_modificar.Location = new System.Drawing.Point(30, 26);
            this.Btn_modificar.Name = "Btn_modificar";
            this.Btn_modificar.Size = new System.Drawing.Size(143, 54);
            this.Btn_modificar.TabIndex = 2;
            this.Btn_modificar.Text = "Modificar";
            this.Btn_modificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_modificar.UseVisualStyleBackColor = false;
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(88)))));
            this.Btn_guardar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_guardar.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_guardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_guardar.Location = new System.Drawing.Point(30, 97);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(143, 54);
            this.Btn_guardar.TabIndex = 0;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_guardar.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 788);
            this.Controls.Add(this.Gbp_opc);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Gbp_Titulo);
            this.Controls.Add(this.Gbp_Campos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Gbp_Campos.ResumeLayout(false);
            this.Gbp_Campos.PerformLayout();
            this.Gbp_Titulo.ResumeLayout(false);
            this.Gbp_Titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Gbp_opc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.Label Lbl_Idcheckin;
        private System.Windows.Forms.Label Lbl_Idhuesped;
        private System.Windows.Forms.GroupBox Gbp_Campos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Lbl_estado;
        private System.Windows.Forms.Label Lbl_Fecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Lbl_idreserva;
        private System.Windows.Forms.GroupBox Gbp_Titulo;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox Cbo_Huesped;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox Gbp_opc;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Button Btn_nuevo;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.Button Btn_modificar;
        private System.Windows.Forms.Button Btn_guardar;
    }
}