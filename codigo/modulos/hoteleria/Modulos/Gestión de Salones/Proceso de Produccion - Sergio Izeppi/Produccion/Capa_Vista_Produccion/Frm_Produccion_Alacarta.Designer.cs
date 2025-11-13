namespace Capa_Vista_Produccion
{
    partial class Frm_Produccion_Alacarta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Produccion_Alacarta));
            this.Pnl_Superior = new System.Windows.Forms.Panel();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Lbl_Room_Service_Reporte = new System.Windows.Forms.Label();
            this.Lbl_Id_Habitacion = new System.Windows.Forms.Label();
            this.Lbl_Id_huesped = new System.Windows.Forms.Label();
            this.Txt_Id_Habitacion = new System.Windows.Forms.TextBox();
            this.Txt_Id_Huesped = new System.Windows.Forms.TextBox();
            this.Dgv_Reservas = new System.Windows.Forms.DataGridView();
            this.Dtp_Fecha_Reserva = new System.Windows.Forms.DateTimePicker();
            this.Dtp_Hora_Reserva = new System.Windows.Forms.DateTimePicker();
            this.Txt_Cantidad = new System.Windows.Forms.TextBox();
            this.Cbo_Estado = new System.Windows.Forms.ComboBox();
            this.Lbl_Id_Salon = new System.Windows.Forms.Label();
            this.Lbl_Numero_Comensales = new System.Windows.Forms.Label();
            this.Lbl_Hora_Reserva = new System.Windows.Forms.Label();
            this.Lbl_Fecha_Reserva = new System.Windows.Forms.Label();
            this.Lbl_Estado_Reserva = new System.Windows.Forms.Label();
            this.Btn_editar_reserva = new System.Windows.Forms.Button();
            this.Btn_eliminar_Reserva = new System.Windows.Forms.Button();
            this.Btn_Guardar_Reserva = new System.Windows.Forms.Button();
            this.Btn_Reporte = new System.Windows.Forms.Button();
            this.Cbo_Salon = new System.Windows.Forms.ComboBox();
            this.Pnl_Superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Reservas)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_Superior
            // 
            this.Pnl_Superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(142)))), ((int)(((byte)(181)))));
            this.Pnl_Superior.Controls.Add(this.Lbl_Titulo);
            this.Pnl_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Superior.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Superior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pnl_Superior.Name = "Pnl_Superior";
            this.Pnl_Superior.Size = new System.Drawing.Size(1175, 64);
            this.Pnl_Superior.TabIndex = 122;
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_Titulo.Location = new System.Drawing.Point(14, 12);
            this.Lbl_Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(319, 35);
            this.Lbl_Titulo.TabIndex = 2;
            this.Lbl_Titulo.Text = "MODULO HOTELERIA";
            // 
            // Lbl_Room_Service_Reporte
            // 
            this.Lbl_Room_Service_Reporte.AutoSize = true;
            this.Lbl_Room_Service_Reporte.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Room_Service_Reporte.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_Room_Service_Reporte.Location = new System.Drawing.Point(16, 80);
            this.Lbl_Room_Service_Reporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Room_Service_Reporte.Name = "Lbl_Room_Service_Reporte";
            this.Lbl_Room_Service_Reporte.Size = new System.Drawing.Size(215, 21);
            this.Lbl_Room_Service_Reporte.TabIndex = 141;
            this.Lbl_Room_Service_Reporte.Text = "RESERVAS A LA CARTA";
            // 
            // Lbl_Id_Habitacion
            // 
            this.Lbl_Id_Habitacion.AutoSize = true;
            this.Lbl_Id_Habitacion.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Id_Habitacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_Id_Habitacion.Location = new System.Drawing.Point(16, 177);
            this.Lbl_Id_Habitacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Id_Habitacion.Name = "Lbl_Id_Habitacion";
            this.Lbl_Id_Habitacion.Size = new System.Drawing.Size(185, 21);
            this.Lbl_Id_Habitacion.TabIndex = 145;
            this.Lbl_Id_Habitacion.Text = "ID de la Habitacion:";
            // 
            // Lbl_Id_huesped
            // 
            this.Lbl_Id_huesped.AutoSize = true;
            this.Lbl_Id_huesped.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Id_huesped.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_Id_huesped.Location = new System.Drawing.Point(13, 132);
            this.Lbl_Id_huesped.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Id_huesped.Name = "Lbl_Id_huesped";
            this.Lbl_Id_huesped.Size = new System.Drawing.Size(134, 20);
            this.Lbl_Id_huesped.TabIndex = 144;
            this.Lbl_Id_huesped.Text = "ID del Huesped:";
            // 
            // Txt_Id_Habitacion
            // 
            this.Txt_Id_Habitacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Id_Habitacion.Location = new System.Drawing.Point(225, 178);
            this.Txt_Id_Habitacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Id_Habitacion.Name = "Txt_Id_Habitacion";
            this.Txt_Id_Habitacion.Size = new System.Drawing.Size(139, 22);
            this.Txt_Id_Habitacion.TabIndex = 143;
            this.Txt_Id_Habitacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Id_Habitacion_KeyPress);
            // 
            // Txt_Id_Huesped
            // 
            this.Txt_Id_Huesped.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Id_Huesped.Location = new System.Drawing.Point(225, 133);
            this.Txt_Id_Huesped.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Id_Huesped.Name = "Txt_Id_Huesped";
            this.Txt_Id_Huesped.Size = new System.Drawing.Size(139, 22);
            this.Txt_Id_Huesped.TabIndex = 142;
            this.Txt_Id_Huesped.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Id_Huesped_KeyPress);
            // 
            // Dgv_Reservas
            // 
            this.Dgv_Reservas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Reservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Reservas.Location = new System.Drawing.Point(20, 288);
            this.Dgv_Reservas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dgv_Reservas.Name = "Dgv_Reservas";
            this.Dgv_Reservas.RowHeadersWidth = 51;
            this.Dgv_Reservas.RowTemplate.Height = 24;
            this.Dgv_Reservas.Size = new System.Drawing.Size(1133, 252);
            this.Dgv_Reservas.TabIndex = 146;
            // 
            // Dtp_Fecha_Reserva
            // 
            this.Dtp_Fecha_Reserva.Location = new System.Drawing.Point(680, 130);
            this.Dtp_Fecha_Reserva.Name = "Dtp_Fecha_Reserva";
            this.Dtp_Fecha_Reserva.Size = new System.Drawing.Size(154, 22);
            this.Dtp_Fecha_Reserva.TabIndex = 148;
            // 
            // Dtp_Hora_Reserva
            // 
            this.Dtp_Hora_Reserva.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Dtp_Hora_Reserva.Location = new System.Drawing.Point(680, 170);
            this.Dtp_Hora_Reserva.Name = "Dtp_Hora_Reserva";
            this.Dtp_Hora_Reserva.Size = new System.Drawing.Size(154, 22);
            this.Dtp_Hora_Reserva.TabIndex = 149;
            // 
            // Txt_Cantidad
            // 
            this.Txt_Cantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Cantidad.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.Txt_Cantidad.Location = new System.Drawing.Point(680, 217);
            this.Txt_Cantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Cantidad.Name = "Txt_Cantidad";
            this.Txt_Cantidad.Size = new System.Drawing.Size(154, 22);
            this.Txt_Cantidad.TabIndex = 150;
            this.Txt_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Cantidad_KeyPress);
            // 
            // Cbo_Estado
            // 
            this.Cbo_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Estado.FormattingEnabled = true;
            this.Cbo_Estado.Location = new System.Drawing.Point(1007, 130);
            this.Cbo_Estado.Name = "Cbo_Estado";
            this.Cbo_Estado.Size = new System.Drawing.Size(149, 24);
            this.Cbo_Estado.TabIndex = 151;
            // 
            // Lbl_Id_Salon
            // 
            this.Lbl_Id_Salon.AutoSize = true;
            this.Lbl_Id_Salon.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Id_Salon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_Id_Salon.Location = new System.Drawing.Point(16, 218);
            this.Lbl_Id_Salon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Id_Salon.Name = "Lbl_Id_Salon";
            this.Lbl_Id_Salon.Size = new System.Drawing.Size(123, 21);
            this.Lbl_Id_Salon.TabIndex = 152;
            this.Lbl_Id_Salon.Text = "ID del Salon:";
            // 
            // Lbl_Numero_Comensales
            // 
            this.Lbl_Numero_Comensales.AutoSize = true;
            this.Lbl_Numero_Comensales.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Numero_Comensales.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_Numero_Comensales.Location = new System.Drawing.Point(488, 216);
            this.Lbl_Numero_Comensales.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Numero_Comensales.Name = "Lbl_Numero_Comensales";
            this.Lbl_Numero_Comensales.Size = new System.Drawing.Size(176, 21);
            this.Lbl_Numero_Comensales.TabIndex = 155;
            this.Lbl_Numero_Comensales.Text = "Cant. Comensales:";
            // 
            // Lbl_Hora_Reserva
            // 
            this.Lbl_Hora_Reserva.AutoSize = true;
            this.Lbl_Hora_Reserva.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Hora_Reserva.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_Hora_Reserva.Location = new System.Drawing.Point(488, 170);
            this.Lbl_Hora_Reserva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Hora_Reserva.Name = "Lbl_Hora_Reserva";
            this.Lbl_Hora_Reserva.Size = new System.Drawing.Size(182, 21);
            this.Lbl_Hora_Reserva.TabIndex = 154;
            this.Lbl_Hora_Reserva.Text = "Hora de la Reserva:";
            // 
            // Lbl_Fecha_Reserva
            // 
            this.Lbl_Fecha_Reserva.AutoSize = true;
            this.Lbl_Fecha_Reserva.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha_Reserva.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_Fecha_Reserva.Location = new System.Drawing.Point(488, 130);
            this.Lbl_Fecha_Reserva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Fecha_Reserva.Name = "Lbl_Fecha_Reserva";
            this.Lbl_Fecha_Reserva.Size = new System.Drawing.Size(170, 20);
            this.Lbl_Fecha_Reserva.TabIndex = 153;
            this.Lbl_Fecha_Reserva.Text = "Fecha de la Reserva:";
            // 
            // Lbl_Estado_Reserva
            // 
            this.Lbl_Estado_Reserva.AutoSize = true;
            this.Lbl_Estado_Reserva.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Estado_Reserva.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_Estado_Reserva.Location = new System.Drawing.Point(917, 130);
            this.Lbl_Estado_Reserva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Estado_Reserva.Name = "Lbl_Estado_Reserva";
            this.Lbl_Estado_Reserva.Size = new System.Drawing.Size(76, 21);
            this.Lbl_Estado_Reserva.TabIndex = 156;
            this.Lbl_Estado_Reserva.Text = "Estado:";
            // 
            // Btn_editar_reserva
            // 
            this.Btn_editar_reserva.BackColor = System.Drawing.Color.White;
            this.Btn_editar_reserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_editar_reserva.Image = ((System.Drawing.Image)(resources.GetObject("Btn_editar_reserva.Image")));
            this.Btn_editar_reserva.Location = new System.Drawing.Point(1105, 68);
            this.Btn_editar_reserva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_editar_reserva.Name = "Btn_editar_reserva";
            this.Btn_editar_reserva.Size = new System.Drawing.Size(53, 46);
            this.Btn_editar_reserva.TabIndex = 159;
            this.Btn_editar_reserva.UseVisualStyleBackColor = false;
            this.Btn_editar_reserva.Click += new System.EventHandler(this.pro_Btn_editar_reserva_Click);
            // 
            // Btn_eliminar_Reserva
            // 
            this.Btn_eliminar_Reserva.BackColor = System.Drawing.Color.White;
            this.Btn_eliminar_Reserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminar_Reserva.Image = ((System.Drawing.Image)(resources.GetObject("Btn_eliminar_Reserva.Image")));
            this.Btn_eliminar_Reserva.Location = new System.Drawing.Point(1046, 68);
            this.Btn_eliminar_Reserva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_eliminar_Reserva.Name = "Btn_eliminar_Reserva";
            this.Btn_eliminar_Reserva.Size = new System.Drawing.Size(53, 46);
            this.Btn_eliminar_Reserva.TabIndex = 158;
            this.Btn_eliminar_Reserva.UseVisualStyleBackColor = false;
            this.Btn_eliminar_Reserva.Click += new System.EventHandler(this.pro_Btn_eliminar_Reserva_Click);
            // 
            // Btn_Guardar_Reserva
            // 
            this.Btn_Guardar_Reserva.BackColor = System.Drawing.Color.White;
            this.Btn_Guardar_Reserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Guardar_Reserva.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Guardar_Reserva.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Guardar_Reserva.Image")));
            this.Btn_Guardar_Reserva.Location = new System.Drawing.Point(987, 68);
            this.Btn_Guardar_Reserva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Guardar_Reserva.Name = "Btn_Guardar_Reserva";
            this.Btn_Guardar_Reserva.Size = new System.Drawing.Size(53, 46);
            this.Btn_Guardar_Reserva.TabIndex = 157;
            this.Btn_Guardar_Reserva.UseVisualStyleBackColor = false;
            this.Btn_Guardar_Reserva.Click += new System.EventHandler(this.pro_Btn_Guardar_Reserva_Click);
            // 
            // Btn_Reporte
            // 
            this.Btn_Reporte.BackColor = System.Drawing.Color.White;
            this.Btn_Reporte.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Reporte.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Reporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Reporte.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Reporte.Image")));
            this.Btn_Reporte.Location = new System.Drawing.Point(921, 69);
            this.Btn_Reporte.Name = "Btn_Reporte";
            this.Btn_Reporte.Size = new System.Drawing.Size(56, 46);
            this.Btn_Reporte.TabIndex = 160;
            this.Btn_Reporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Reporte.UseVisualStyleBackColor = false;
            this.Btn_Reporte.Click += new System.EventHandler(this.pro_Btn_Reporte_Click);
            // 
            // Cbo_Salon
            // 
            this.Cbo_Salon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Salon.FormattingEnabled = true;
            this.Cbo_Salon.Location = new System.Drawing.Point(225, 219);
            this.Cbo_Salon.Name = "Cbo_Salon";
            this.Cbo_Salon.Size = new System.Drawing.Size(139, 24);
            this.Cbo_Salon.TabIndex = 161;
            // 
            // Frm_Produccion_Alacarta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 559);
            this.Controls.Add(this.Cbo_Salon);
            this.Controls.Add(this.Btn_Reporte);
            this.Controls.Add(this.Btn_editar_reserva);
            this.Controls.Add(this.Btn_eliminar_Reserva);
            this.Controls.Add(this.Btn_Guardar_Reserva);
            this.Controls.Add(this.Lbl_Estado_Reserva);
            this.Controls.Add(this.Lbl_Numero_Comensales);
            this.Controls.Add(this.Lbl_Hora_Reserva);
            this.Controls.Add(this.Lbl_Fecha_Reserva);
            this.Controls.Add(this.Lbl_Id_Salon);
            this.Controls.Add(this.Cbo_Estado);
            this.Controls.Add(this.Txt_Cantidad);
            this.Controls.Add(this.Dtp_Fecha_Reserva);
            this.Controls.Add(this.Dtp_Hora_Reserva);
            this.Controls.Add(this.Dgv_Reservas);
            this.Controls.Add(this.Lbl_Id_Habitacion);
            this.Controls.Add(this.Lbl_Id_huesped);
            this.Controls.Add(this.Txt_Id_Habitacion);
            this.Controls.Add(this.Txt_Id_Huesped);
            this.Controls.Add(this.Lbl_Room_Service_Reporte);
            this.Controls.Add(this.Pnl_Superior);
            this.Name = "Frm_Produccion_Alacarta";
            this.Text = "Form1";
            this.Pnl_Superior.ResumeLayout(false);
            this.Pnl_Superior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Reservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Pnl_Superior;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Label Lbl_Room_Service_Reporte;
        private System.Windows.Forms.Label Lbl_Id_Habitacion;
        private System.Windows.Forms.Label Lbl_Id_huesped;
        private System.Windows.Forms.TextBox Txt_Id_Habitacion;
        private System.Windows.Forms.TextBox Txt_Id_Huesped;
        private System.Windows.Forms.DataGridView Dgv_Reservas;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Reserva;
        private System.Windows.Forms.DateTimePicker Dtp_Hora_Reserva;
        private System.Windows.Forms.TextBox Txt_Cantidad;
        private System.Windows.Forms.ComboBox Cbo_Estado;
        private System.Windows.Forms.Label Lbl_Id_Salon;
        private System.Windows.Forms.Label Lbl_Numero_Comensales;
        private System.Windows.Forms.Label Lbl_Hora_Reserva;
        private System.Windows.Forms.Label Lbl_Fecha_Reserva;
        private System.Windows.Forms.Label Lbl_Estado_Reserva;
        private System.Windows.Forms.Button Btn_editar_reserva;
        private System.Windows.Forms.Button Btn_eliminar_Reserva;
        private System.Windows.Forms.Button Btn_Guardar_Reserva;
        private System.Windows.Forms.Button Btn_Reporte;
        private System.Windows.Forms.ComboBox Cbo_Salon;
    }
}