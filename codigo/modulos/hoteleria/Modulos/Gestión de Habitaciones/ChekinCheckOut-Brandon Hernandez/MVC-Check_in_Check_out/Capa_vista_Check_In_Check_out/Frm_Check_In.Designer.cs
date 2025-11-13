
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Check_In));
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Dgv_Check_In = new System.Windows.Forms.DataGridView();
            this.Gbp_Titulo = new System.Windows.Forms.GroupBox();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Gbp_Campos = new System.Windows.Forms.GroupBox();
            this.Cbo_Estado = new System.Windows.Forms.ComboBox();
            this.Cbo_Reservas = new System.Windows.Forms.ComboBox();
            this.Cbo_Huesped = new System.Windows.Forms.ComboBox();
            this.Txt_Id_Check_In = new System.Windows.Forms.TextBox();
            this.Lbl_estado = new System.Windows.Forms.Label();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.Dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.Lbl_idreserva = new System.Windows.Forms.Label();
            this.Lbl_Idcheckin = new System.Windows.Forms.Label();
            this.Lbl_Idhuesped = new System.Windows.Forms.Label();
            this.Btn_Ayuda = new System.Windows.Forms.Button();
            this.Btn_Reporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Check_In)).BeginInit();
            this.Gbp_Titulo.SuspendLayout();
            this.Gbp_Campos.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.Color.White;
            this.Btn_Salir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Salir.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Salir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Salir.Image")));
            this.Btn_Salir.Location = new System.Drawing.Point(953, 16);
            this.Btn_Salir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(40, 41);
            this.Btn_Salir.TabIndex = 4;
            this.Btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.BackColor = System.Drawing.Color.White;
            this.Btn_Nuevo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Nuevo.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Nuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Nuevo.Image")));
            this.Btn_Nuevo.Location = new System.Drawing.Point(668, 14);
            this.Btn_Nuevo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(38, 44);
            this.Btn_Nuevo.TabIndex = 1;
            this.Btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Nuevo.UseVisualStyleBackColor = false;
            this.Btn_Nuevo.Click += new System.EventHandler(this.Btn_nuevo_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackColor = System.Drawing.Color.White;
            this.Btn_Cancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Cancelar.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Cancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cancelar.Image")));
            this.Btn_Cancelar.Location = new System.Drawing.Point(800, 14);
            this.Btn_Cancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(53, 44);
            this.Btn_Cancelar.TabIndex = 3;
            this.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Cancelar.UseVisualStyleBackColor = false;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.BackColor = System.Drawing.Color.White;
            this.Btn_Modificar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Modificar.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Modificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Modificar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Modificar.Image")));
            this.Btn_Modificar.Location = new System.Drawing.Point(752, 14);
            this.Btn_Modificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(44, 44);
            this.Btn_Modificar.TabIndex = 2;
            this.Btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Modificar.UseVisualStyleBackColor = false;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_modificar_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.BackColor = System.Drawing.Color.White;
            this.Btn_Guardar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Guardar.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Guardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Guardar.Image")));
            this.Btn_Guardar.Location = new System.Drawing.Point(710, 13);
            this.Btn_Guardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(38, 44);
            this.Btn_Guardar.TabIndex = 0;
            this.Btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Guardar.UseVisualStyleBackColor = false;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Dgv_Check_In
            // 
            this.Dgv_Check_In.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Check_In.Location = new System.Drawing.Point(16, 232);
            this.Dgv_Check_In.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Dgv_Check_In.Name = "Dgv_Check_In";
            this.Dgv_Check_In.RowHeadersWidth = 51;
            this.Dgv_Check_In.RowTemplate.Height = 24;
            this.Dgv_Check_In.Size = new System.Drawing.Size(1012, 414);
            this.Dgv_Check_In.TabIndex = 15;
            this.Dgv_Check_In.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Check_In_CellClick);
            // 
            // Gbp_Titulo
            // 
            this.Gbp_Titulo.Controls.Add(this.Lbl_Titulo);
            this.Gbp_Titulo.Location = new System.Drawing.Point(16, 10);
            this.Gbp_Titulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Gbp_Titulo.Name = "Gbp_Titulo";
            this.Gbp_Titulo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Gbp_Titulo.Size = new System.Drawing.Size(274, 65);
            this.Gbp_Titulo.TabIndex = 14;
            this.Gbp_Titulo.TabStop = false;
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.BackColor = System.Drawing.SystemColors.Control;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(61, 27);
            this.Lbl_Titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(76, 17);
            this.Lbl_Titulo.TabIndex = 0;
            this.Lbl_Titulo.Text = "Check In ";
            // 
            // Gbp_Campos
            // 
            this.Gbp_Campos.Controls.Add(this.Cbo_Estado);
            this.Gbp_Campos.Controls.Add(this.Cbo_Reservas);
            this.Gbp_Campos.Controls.Add(this.Cbo_Huesped);
            this.Gbp_Campos.Controls.Add(this.Txt_Id_Check_In);
            this.Gbp_Campos.Controls.Add(this.Lbl_estado);
            this.Gbp_Campos.Controls.Add(this.Lbl_Fecha);
            this.Gbp_Campos.Controls.Add(this.Dtp_Fecha);
            this.Gbp_Campos.Controls.Add(this.Lbl_idreserva);
            this.Gbp_Campos.Controls.Add(this.Lbl_Idcheckin);
            this.Gbp_Campos.Controls.Add(this.Lbl_Idhuesped);
            this.Gbp_Campos.Location = new System.Drawing.Point(28, 80);
            this.Gbp_Campos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Gbp_Campos.Name = "Gbp_Campos";
            this.Gbp_Campos.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Gbp_Campos.Size = new System.Drawing.Size(1028, 138);
            this.Gbp_Campos.TabIndex = 13;
            this.Gbp_Campos.TabStop = false;
            // 
            // Cbo_Estado
            // 
            this.Cbo_Estado.FormattingEnabled = true;
            this.Cbo_Estado.Location = new System.Drawing.Point(782, 58);
            this.Cbo_Estado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cbo_Estado.Name = "Cbo_Estado";
            this.Cbo_Estado.Size = new System.Drawing.Size(211, 21);
            this.Cbo_Estado.TabIndex = 10;
            // 
            // Cbo_Reservas
            // 
            this.Cbo_Reservas.FormattingEnabled = true;
            this.Cbo_Reservas.Location = new System.Drawing.Point(353, 60);
            this.Cbo_Reservas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cbo_Reservas.Name = "Cbo_Reservas";
            this.Cbo_Reservas.Size = new System.Drawing.Size(211, 21);
            this.Cbo_Reservas.TabIndex = 9;
            this.Cbo_Reservas.SelectedIndexChanged += new System.EventHandler(this.Cbo_Reservas_SelectedIndexChanged);
            // 
            // Cbo_Huesped
            // 
            this.Cbo_Huesped.FormattingEnabled = true;
            this.Cbo_Huesped.Location = new System.Drawing.Point(122, 62);
            this.Cbo_Huesped.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cbo_Huesped.Name = "Cbo_Huesped";
            this.Cbo_Huesped.Size = new System.Drawing.Size(211, 21);
            this.Cbo_Huesped.TabIndex = 8;
            this.Cbo_Huesped.SelectedIndexChanged += new System.EventHandler(this.Cbo_Huesped_SelectedIndexChanged);
            // 
            // Txt_Id_Check_In
            // 
            this.Txt_Id_Check_In.Location = new System.Drawing.Point(20, 63);
            this.Txt_Id_Check_In.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_Id_Check_In.Name = "Txt_Id_Check_In";
            this.Txt_Id_Check_In.Size = new System.Drawing.Size(72, 20);
            this.Txt_Id_Check_In.TabIndex = 7;
            // 
            // Lbl_estado
            // 
            this.Lbl_estado.AutoSize = true;
            this.Lbl_estado.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_estado.Location = new System.Drawing.Point(794, 24);
            this.Lbl_estado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_estado.Name = "Lbl_estado";
            this.Lbl_estado.Size = new System.Drawing.Size(51, 17);
            this.Lbl_estado.TabIndex = 6;
            this.Lbl_estado.Text = "Estado";
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha.Location = new System.Drawing.Point(612, 28);
            this.Lbl_Fecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(46, 17);
            this.Lbl_Fecha.TabIndex = 5;
            this.Lbl_Fecha.Text = "Fecha";
            // 
            // Dtp_Fecha
            // 
            this.Dtp_Fecha.Location = new System.Drawing.Point(568, 60);
            this.Dtp_Fecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Dtp_Fecha.Name = "Dtp_Fecha";
            this.Dtp_Fecha.Size = new System.Drawing.Size(194, 20);
            this.Dtp_Fecha.TabIndex = 4;
            // 
            // Lbl_idreserva
            // 
            this.Lbl_idreserva.AutoSize = true;
            this.Lbl_idreserva.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_idreserva.Location = new System.Drawing.Point(398, 24);
            this.Lbl_idreserva.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_idreserva.Name = "Lbl_idreserva";
            this.Lbl_idreserva.Size = new System.Drawing.Size(59, 17);
            this.Lbl_idreserva.TabIndex = 3;
            this.Lbl_idreserva.Text = "Reserva";
            // 
            // Lbl_Idcheckin
            // 
            this.Lbl_Idcheckin.AutoSize = true;
            this.Lbl_Idcheckin.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Idcheckin.Location = new System.Drawing.Point(17, 24);
            this.Lbl_Idcheckin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Idcheckin.Name = "Lbl_Idcheckin";
            this.Lbl_Idcheckin.Size = new System.Drawing.Size(83, 17);
            this.Lbl_Idcheckin.TabIndex = 1;
            this.Lbl_Idcheckin.Text = "Id Check In";
            // 
            // Lbl_Idhuesped
            // 
            this.Lbl_Idhuesped.AutoSize = true;
            this.Lbl_Idhuesped.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Idhuesped.Location = new System.Drawing.Point(176, 24);
            this.Lbl_Idhuesped.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Idhuesped.Name = "Lbl_Idhuesped";
            this.Lbl_Idhuesped.Size = new System.Drawing.Size(70, 17);
            this.Lbl_Idhuesped.TabIndex = 2;
            this.Lbl_Idhuesped.Text = " Huesped";
            // 
            // Btn_Ayuda
            // 
            this.Btn_Ayuda.BackColor = System.Drawing.Color.White;
            this.Btn_Ayuda.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Ayuda.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Ayuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ayuda.Image")));
            this.Btn_Ayuda.Location = new System.Drawing.Point(908, 13);
            this.Btn_Ayuda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Ayuda.Name = "Btn_Ayuda";
            this.Btn_Ayuda.Size = new System.Drawing.Size(41, 44);
            this.Btn_Ayuda.TabIndex = 17;
            this.Btn_Ayuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Ayuda.UseVisualStyleBackColor = false;
            // 
            // Btn_Reporte
            // 
            this.Btn_Reporte.BackColor = System.Drawing.Color.White;
            this.Btn_Reporte.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Reporte.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Reporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Reporte.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Reporte.Image")));
            this.Btn_Reporte.Location = new System.Drawing.Point(857, 13);
            this.Btn_Reporte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Reporte.Name = "Btn_Reporte";
            this.Btn_Reporte.Size = new System.Drawing.Size(46, 44);
            this.Btn_Reporte.TabIndex = 18;
            this.Btn_Reporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Reporte.UseVisualStyleBackColor = false;
            this.Btn_Reporte.Click += new System.EventHandler(this.Btn_Reporte_Click);
            // 
            // Frm_Check_In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 687);
            this.Controls.Add(this.Dgv_Check_In);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Reporte);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Ayuda);
            this.Controls.Add(this.Btn_Nuevo);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Gbp_Titulo);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Gbp_Campos);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_Check_In";
            this.Text = "Frm_Check_In";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Check_In)).EndInit();
            this.Gbp_Titulo.ResumeLayout(false);
            this.Gbp_Titulo.PerformLayout();
            this.Gbp_Campos.ResumeLayout(false);
            this.Gbp_Campos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.DataGridView Dgv_Check_In;
        private System.Windows.Forms.GroupBox Gbp_Titulo;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.GroupBox Gbp_Campos;
        private System.Windows.Forms.ComboBox Cbo_Estado;
        private System.Windows.Forms.ComboBox Cbo_Reservas;
        private System.Windows.Forms.ComboBox Cbo_Huesped;
        private System.Windows.Forms.TextBox Txt_Id_Check_In;
        private System.Windows.Forms.Label Lbl_estado;
        private System.Windows.Forms.Label Lbl_Fecha;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha;
        private System.Windows.Forms.Label Lbl_idreserva;
        private System.Windows.Forms.Label Lbl_Idcheckin;
        private System.Windows.Forms.Label Lbl_Idhuesped;
        private System.Windows.Forms.Button Btn_Ayuda;
        private System.Windows.Forms.Button Btn_Reporte;
    }
}