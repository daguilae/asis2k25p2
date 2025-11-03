
namespace Capa_Vista_S
{
    partial class Frm_Reservaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Reservaciones));
            this.Pnl_Superior = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_modificar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Lbl_Hora_Fin = new System.Windows.Forms.Label();
            this.Lbl_Hora_inicio = new System.Windows.Forms.Label();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.Lbl_Consulta = new System.Windows.Forms.Label();
            this.Dvg_Reservaciones = new System.Windows.Forms.DataGridView();
            this.Dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.Dtp_Inicio = new System.Windows.Forms.DateTimePicker();
            this.Dtp_Fin = new System.Windows.Forms.DateTimePicker();
            this.Txt_capacidad = new System.Windows.Forms.TextBox();
            this.Lbl_Capacidad = new System.Windows.Forms.Label();
            this.Cbo_Huesped = new System.Windows.Forms.ComboBox();
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.Lbl_Salon = new System.Windows.Forms.Label();
            this.Cbo_Salon = new System.Windows.Forms.ComboBox();
            this.Lbl_FechaR = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Monto = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salonesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Pnl_Superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dvg_Reservaciones)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Superior
            // 
            this.Pnl_Superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(142)))), ((int)(((byte)(181)))));
            this.Pnl_Superior.Controls.Add(this.label1);
            this.Pnl_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Superior.Location = new System.Drawing.Point(0, 24);
            this.Pnl_Superior.Margin = new System.Windows.Forms.Padding(2);
            this.Pnl_Superior.Name = "Pnl_Superior";
            this.Pnl_Superior.Size = new System.Drawing.Size(1011, 52);
            this.Pnl_Superior.TabIndex = 99;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(21, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "MODULO HOTELERIA";
            // 
            // Btn_modificar
            // 
            this.Btn_modificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_modificar.BackColor = System.Drawing.Color.White;
            this.Btn_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_modificar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_modificar.Image")));
            this.Btn_modificar.Location = new System.Drawing.Point(868, 81);
            this.Btn_modificar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_modificar.Name = "Btn_modificar";
            this.Btn_modificar.Size = new System.Drawing.Size(40, 37);
            this.Btn_modificar.TabIndex = 122;
            this.Btn_modificar.UseVisualStyleBackColor = false;
            this.Btn_modificar.Click += new System.EventHandler(this.Btn_modificar_Click_1);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_eliminar.BackColor = System.Drawing.Color.White;
            this.Btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_eliminar.Image")));
            this.Btn_eliminar.Location = new System.Drawing.Point(824, 81);
            this.Btn_eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(40, 37);
            this.Btn_eliminar.TabIndex = 121;
            this.Btn_eliminar.UseVisualStyleBackColor = false;
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click_1);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_guardar.BackColor = System.Drawing.Color.White;
            this.Btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_guardar.Image")));
            this.Btn_guardar.Location = new System.Drawing.Point(780, 81);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(40, 37);
            this.Btn_guardar.TabIndex = 120;
            this.Btn_guardar.UseVisualStyleBackColor = false;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click_1);
            // 
            // Lbl_Hora_Fin
            // 
            this.Lbl_Hora_Fin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Hora_Fin.AutoSize = true;
            this.Lbl_Hora_Fin.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lbl_Hora_Fin.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Lbl_Hora_Fin.Location = new System.Drawing.Point(466, 140);
            this.Lbl_Hora_Fin.Name = "Lbl_Hora_Fin";
            this.Lbl_Hora_Fin.Size = new System.Drawing.Size(63, 17);
            this.Lbl_Hora_Fin.TabIndex = 119;
            this.Lbl_Hora_Fin.Text = "Hora Fin";
            // 
            // Lbl_Hora_inicio
            // 
            this.Lbl_Hora_inicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Hora_inicio.AutoSize = true;
            this.Lbl_Hora_inicio.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lbl_Hora_inicio.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Lbl_Hora_inicio.Location = new System.Drawing.Point(22, 278);
            this.Lbl_Hora_inicio.Name = "Lbl_Hora_inicio";
            this.Lbl_Hora_inicio.Size = new System.Drawing.Size(78, 17);
            this.Lbl_Hora_inicio.TabIndex = 118;
            this.Lbl_Hora_inicio.Text = "Hora Inicio";
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lbl_Fecha.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Lbl_Fecha.Location = new System.Drawing.Point(12, 210);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(0, 17);
            this.Lbl_Fecha.TabIndex = 117;
            // 
            // Lbl_Consulta
            // 
            this.Lbl_Consulta.AutoSize = true;
            this.Lbl_Consulta.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lbl_Consulta.Font = new System.Drawing.Font("Rockwell", 18F);
            this.Lbl_Consulta.Location = new System.Drawing.Point(20, 86);
            this.Lbl_Consulta.Name = "Lbl_Consulta";
            this.Lbl_Consulta.Size = new System.Drawing.Size(184, 27);
            this.Lbl_Consulta.TabIndex = 115;
            this.Lbl_Consulta.Text = "Datos del Salon";
            // 
            // Dvg_Reservaciones
            // 
            this.Dvg_Reservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dvg_Reservaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dvg_Reservaciones.Location = new System.Drawing.Point(13, 323);
            this.Dvg_Reservaciones.Name = "Dvg_Reservaciones";
            this.Dvg_Reservaciones.RowHeadersWidth = 51;
            this.Dvg_Reservaciones.Size = new System.Drawing.Size(987, 300);
            this.Dvg_Reservaciones.TabIndex = 114;
            this.Dvg_Reservaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dvg_Reservaciones_CellContentClick);
            // 
            // Dtp_Fecha
            // 
            this.Dtp_Fecha.Checked = false;
            this.Dtp_Fecha.Location = new System.Drawing.Point(207, 226);
            this.Dtp_Fecha.Name = "Dtp_Fecha";
            this.Dtp_Fecha.Size = new System.Drawing.Size(200, 20);
            this.Dtp_Fecha.TabIndex = 127;
            this.Dtp_Fecha.Value = new System.DateTime(2025, 10, 31, 19, 11, 16, 0);
            // 
            // Dtp_Inicio
            // 
            this.Dtp_Inicio.Checked = false;
            this.Dtp_Inicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Dtp_Inicio.Location = new System.Drawing.Point(207, 278);
            this.Dtp_Inicio.Name = "Dtp_Inicio";
            this.Dtp_Inicio.ShowUpDown = true;
            this.Dtp_Inicio.Size = new System.Drawing.Size(200, 20);
            this.Dtp_Inicio.TabIndex = 128;
            this.Dtp_Inicio.Value = new System.DateTime(2025, 10, 31, 19, 11, 16, 0);
            // 
            // Dtp_Fin
            // 
            this.Dtp_Fin.Checked = false;
            this.Dtp_Fin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Dtp_Fin.Location = new System.Drawing.Point(650, 136);
            this.Dtp_Fin.Name = "Dtp_Fin";
            this.Dtp_Fin.ShowUpDown = true;
            this.Dtp_Fin.Size = new System.Drawing.Size(200, 20);
            this.Dtp_Fin.TabIndex = 129;
            this.Dtp_Fin.Value = new System.DateTime(2025, 10, 31, 19, 11, 16, 0);
            // 
            // Txt_capacidad
            // 
            this.Txt_capacidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_capacidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_capacidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_capacidad.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Txt_capacidad.Location = new System.Drawing.Point(650, 179);
            this.Txt_capacidad.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_capacidad.Name = "Txt_capacidad";
            this.Txt_capacidad.Size = new System.Drawing.Size(200, 23);
            this.Txt_capacidad.TabIndex = 131;
            // 
            // Lbl_Capacidad
            // 
            this.Lbl_Capacidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Capacidad.AutoSize = true;
            this.Lbl_Capacidad.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lbl_Capacidad.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Lbl_Capacidad.Location = new System.Drawing.Point(466, 185);
            this.Lbl_Capacidad.Name = "Lbl_Capacidad";
            this.Lbl_Capacidad.Size = new System.Drawing.Size(165, 17);
            this.Lbl_Capacidad.TabIndex = 130;
            this.Lbl_Capacidad.Text = "Capacidad de personas ";
            // 
            // Cbo_Huesped
            // 
            this.Cbo_Huesped.FormattingEnabled = true;
            this.Cbo_Huesped.Location = new System.Drawing.Point(207, 143);
            this.Cbo_Huesped.Name = "Cbo_Huesped";
            this.Cbo_Huesped.Size = new System.Drawing.Size(200, 21);
            this.Cbo_Huesped.TabIndex = 132;
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lbl_Nombre.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Lbl_Nombre.Location = new System.Drawing.Point(22, 140);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(153, 17);
            this.Lbl_Nombre.TabIndex = 133;
            this.Lbl_Nombre.Text = "Nombre  Del Huesped";
            // 
            // Lbl_Salon
            // 
            this.Lbl_Salon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Salon.AutoSize = true;
            this.Lbl_Salon.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lbl_Salon.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Lbl_Salon.Location = new System.Drawing.Point(22, 185);
            this.Lbl_Salon.Name = "Lbl_Salon";
            this.Lbl_Salon.Size = new System.Drawing.Size(42, 17);
            this.Lbl_Salon.TabIndex = 134;
            this.Lbl_Salon.Text = "Salon";
            // 
            // Cbo_Salon
            // 
            this.Cbo_Salon.FormattingEnabled = true;
            this.Cbo_Salon.Location = new System.Drawing.Point(207, 185);
            this.Cbo_Salon.Name = "Cbo_Salon";
            this.Cbo_Salon.Size = new System.Drawing.Size(200, 21);
            this.Cbo_Salon.TabIndex = 135;
            // 
            // Lbl_FechaR
            // 
            this.Lbl_FechaR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_FechaR.AutoSize = true;
            this.Lbl_FechaR.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lbl_FechaR.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Lbl_FechaR.Location = new System.Drawing.Point(22, 230);
            this.Lbl_FechaR.Name = "Lbl_FechaR";
            this.Lbl_FechaR.Size = new System.Drawing.Size(123, 17);
            this.Lbl_FechaR.TabIndex = 136;
            this.Lbl_FechaR.Text = "Fecha De Reserva";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Rockwell", 10F);
            this.label2.Location = new System.Drawing.Point(466, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 137;
            this.label2.Text = "Monto Total ";
            // 
            // Txt_Monto
            // 
            this.Txt_Monto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Monto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Monto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Monto.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Txt_Monto.Location = new System.Drawing.Point(650, 230);
            this.Txt_Monto.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Monto.Name = "Txt_Monto";
            this.Txt_Monto.Size = new System.Drawing.Size(200, 23);
            this.Txt_Monto.TabIndex = 138;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(142)))), ((int)(((byte)(181)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salonesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1011, 24);
            this.menuStrip1.TabIndex = 139;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salonesToolStripMenuItem
            // 
            this.salonesToolStripMenuItem.Name = "salonesToolStripMenuItem";
            this.salonesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.salonesToolStripMenuItem.Text = "Salones";
            this.salonesToolStripMenuItem.Click += new System.EventHandler(this.salonesToolStripMenuItem_Click);
            // 
            // Frm_Reservaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 641);
            this.Controls.Add(this.Txt_Monto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lbl_FechaR);
            this.Controls.Add(this.Cbo_Salon);
            this.Controls.Add(this.Lbl_Salon);
            this.Controls.Add(this.Lbl_Nombre);
            this.Controls.Add(this.Cbo_Huesped);
            this.Controls.Add(this.Txt_capacidad);
            this.Controls.Add(this.Lbl_Capacidad);
            this.Controls.Add(this.Dtp_Fin);
            this.Controls.Add(this.Dtp_Inicio);
            this.Controls.Add(this.Dtp_Fecha);
            this.Controls.Add(this.Btn_modificar);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Lbl_Hora_Fin);
            this.Controls.Add(this.Lbl_Hora_inicio);
            this.Controls.Add(this.Lbl_Fecha);
            this.Controls.Add(this.Lbl_Consulta);
            this.Controls.Add(this.Dvg_Reservaciones);
            this.Controls.Add(this.Pnl_Superior);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Reservaciones";
            this.Text = "Frm_Reservaciones";
            this.Pnl_Superior.ResumeLayout(false);
            this.Pnl_Superior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dvg_Reservaciones)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Superior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_modificar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Label Lbl_Hora_Fin;
        private System.Windows.Forms.Label Lbl_Hora_inicio;
        private System.Windows.Forms.Label Lbl_Fecha;
        private System.Windows.Forms.Label Lbl_Consulta;
        private System.Windows.Forms.DataGridView Dvg_Reservaciones;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha;
        private System.Windows.Forms.DateTimePicker Dtp_Inicio;
        private System.Windows.Forms.DateTimePicker Dtp_Fin;
        private System.Windows.Forms.TextBox Txt_capacidad;
        private System.Windows.Forms.Label Lbl_Capacidad;
        private System.Windows.Forms.ComboBox Cbo_Huesped;
        private System.Windows.Forms.Label Lbl_Nombre;
        private System.Windows.Forms.Label Lbl_Salon;
        private System.Windows.Forms.ComboBox Cbo_Salon;
        private System.Windows.Forms.Label Lbl_FechaR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Monto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salonesToolStripMenuItem;
    }
} 