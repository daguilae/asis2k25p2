
namespace Capa_Vista_Reservas_Hotel
{
    partial class Frm_Modificar_Reserva
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
            this.Lbl_Tarifa = new System.Windows.Forms.Label();
            this.Txt_Tarifa = new System.Windows.Forms.TextBox();
            this.Btn_Guardar_Reserva = new System.Windows.Forms.Button();
            this.Btn_Recalcular_Total = new System.Windows.Forms.Button();
            this.Lbl_Total_Calculado = new System.Windows.Forms.Label();
            this.Txt_Total = new System.Windows.Forms.TextBox();
            this.Lbl_Estado = new System.Windows.Forms.Label();
            this.Cmb_Estado = new System.Windows.Forms.ComboBox();
            this.Lbl_Peticiones_Especiales = new System.Windows.Forms.Label();
            this.Txt_Peticiones = new System.Windows.Forms.TextBox();
            this.Lbl_Cant_Huespedes = new System.Windows.Forms.Label();
            this.Dtp_Salida = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Fecha_Salida = new System.Windows.Forms.Label();
            this.Lbl_Fecha_Entrada = new System.Windows.Forms.Label();
            this.Lbl_Habitacion = new System.Windows.Forms.Label();
            this.Dtp_Entrada = new System.Windows.Forms.DateTimePicker();
            this.Cmb_Habitacion = new System.Windows.Forms.ComboBox();
            this.Dgv_Reservas = new System.Windows.Forms.DataGridView();
            this.Txt_Buscar_Reserva = new System.Windows.Forms.TextBox();
            this.Lbl_Nombre_Dpi_Pasaporte = new System.Windows.Forms.Label();
            this.Lbl_Modificar_Reservas = new System.Windows.Forms.Label();
            this.Txt_Capacidad_Mod = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Reservas)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Tarifa
            // 
            this.Lbl_Tarifa.AutoSize = true;
            this.Lbl_Tarifa.Location = new System.Drawing.Point(1236, 536);
            this.Lbl_Tarifa.Name = "Lbl_Tarifa";
            this.Lbl_Tarifa.Size = new System.Drawing.Size(34, 13);
            this.Lbl_Tarifa.TabIndex = 41;
            this.Lbl_Tarifa.Text = "Tarifa";
            // 
            // Txt_Tarifa
            // 
            this.Txt_Tarifa.Location = new System.Drawing.Point(1203, 552);
            this.Txt_Tarifa.Name = "Txt_Tarifa";
            this.Txt_Tarifa.Size = new System.Drawing.Size(100, 20);
            this.Txt_Tarifa.TabIndex = 40;
            // 
            // Btn_Guardar_Reserva
            // 
            this.Btn_Guardar_Reserva.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Guardar_Reserva.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Guardar_Reserva.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Guardar_Reserva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Guardar_Reserva.Image = global::Capa_Vista_Reservas_Hotel.Properties.Resources.icono_guardar;
            this.Btn_Guardar_Reserva.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Guardar_Reserva.Location = new System.Drawing.Point(772, 122);
            this.Btn_Guardar_Reserva.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Guardar_Reserva.Name = "Btn_Guardar_Reserva";
            this.Btn_Guardar_Reserva.Size = new System.Drawing.Size(41, 44);
            this.Btn_Guardar_Reserva.TabIndex = 39;
            this.Btn_Guardar_Reserva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Guardar_Reserva.UseVisualStyleBackColor = false;
            this.Btn_Guardar_Reserva.Click += new System.EventHandler(this.Btn_Guardar_Reserva_Click);
            // 
            // Btn_Recalcular_Total
            // 
            this.Btn_Recalcular_Total.Location = new System.Drawing.Point(1160, 673);
            this.Btn_Recalcular_Total.Name = "Btn_Recalcular_Total";
            this.Btn_Recalcular_Total.Size = new System.Drawing.Size(75, 23);
            this.Btn_Recalcular_Total.TabIndex = 38;
            this.Btn_Recalcular_Total.Text = "Calcular";
            this.Btn_Recalcular_Total.UseVisualStyleBackColor = true;
            this.Btn_Recalcular_Total.Click += new System.EventHandler(this.Btn_Recalcular_Total_Click);
            // 
            // Lbl_Total_Calculado
            // 
            this.Lbl_Total_Calculado.AutoSize = true;
            this.Lbl_Total_Calculado.Location = new System.Drawing.Point(1279, 640);
            this.Lbl_Total_Calculado.Name = "Lbl_Total_Calculado";
            this.Lbl_Total_Calculado.Size = new System.Drawing.Size(81, 13);
            this.Lbl_Total_Calculado.TabIndex = 37;
            this.Lbl_Total_Calculado.Text = "Total Calculado";
            // 
            // Txt_Total
            // 
            this.Txt_Total.Location = new System.Drawing.Point(1260, 676);
            this.Txt_Total.Name = "Txt_Total";
            this.Txt_Total.Size = new System.Drawing.Size(100, 20);
            this.Txt_Total.TabIndex = 36;
            // 
            // Lbl_Estado
            // 
            this.Lbl_Estado.AutoSize = true;
            this.Lbl_Estado.Location = new System.Drawing.Point(1236, 475);
            this.Lbl_Estado.Name = "Lbl_Estado";
            this.Lbl_Estado.Size = new System.Drawing.Size(40, 13);
            this.Lbl_Estado.TabIndex = 35;
            this.Lbl_Estado.Text = "Estado";
            // 
            // Cmb_Estado
            // 
            this.Cmb_Estado.FormattingEnabled = true;
            this.Cmb_Estado.Location = new System.Drawing.Point(1190, 491);
            this.Cmb_Estado.Name = "Cmb_Estado";
            this.Cmb_Estado.Size = new System.Drawing.Size(121, 21);
            this.Cmb_Estado.TabIndex = 34;
            // 
            // Lbl_Peticiones_Especiales
            // 
            this.Lbl_Peticiones_Especiales.AutoSize = true;
            this.Lbl_Peticiones_Especiales.Location = new System.Drawing.Point(1199, 414);
            this.Lbl_Peticiones_Especiales.Name = "Lbl_Peticiones_Especiales";
            this.Lbl_Peticiones_Especiales.Size = new System.Drawing.Size(109, 13);
            this.Lbl_Peticiones_Especiales.TabIndex = 33;
            this.Lbl_Peticiones_Especiales.Text = "Peticiones especiales";
            // 
            // Txt_Peticiones
            // 
            this.Txt_Peticiones.Location = new System.Drawing.Point(1202, 430);
            this.Txt_Peticiones.Name = "Txt_Peticiones";
            this.Txt_Peticiones.Size = new System.Drawing.Size(100, 20);
            this.Txt_Peticiones.TabIndex = 32;
            // 
            // Lbl_Cant_Huespedes
            // 
            this.Lbl_Cant_Huespedes.AutoSize = true;
            this.Lbl_Cant_Huespedes.Location = new System.Drawing.Point(1187, 359);
            this.Lbl_Cant_Huespedes.Name = "Lbl_Cant_Huespedes";
            this.Lbl_Cant_Huespedes.Size = new System.Drawing.Size(121, 13);
            this.Lbl_Cant_Huespedes.TabIndex = 31;
            this.Lbl_Cant_Huespedes.Text = "Cantidad de Huespedes";
            // 
            // Dtp_Salida
            // 
            this.Dtp_Salida.Location = new System.Drawing.Point(1141, 314);
            this.Dtp_Salida.Name = "Dtp_Salida";
            this.Dtp_Salida.Size = new System.Drawing.Size(200, 20);
            this.Dtp_Salida.TabIndex = 29;
            // 
            // Lbl_Fecha_Salida
            // 
            this.Lbl_Fecha_Salida.AutoSize = true;
            this.Lbl_Fecha_Salida.Location = new System.Drawing.Point(1215, 298);
            this.Lbl_Fecha_Salida.Name = "Lbl_Fecha_Salida";
            this.Lbl_Fecha_Salida.Size = new System.Drawing.Size(69, 13);
            this.Lbl_Fecha_Salida.TabIndex = 28;
            this.Lbl_Fecha_Salida.Text = "Fecha Salida";
            // 
            // Lbl_Fecha_Entrada
            // 
            this.Lbl_Fecha_Entrada.AutoSize = true;
            this.Lbl_Fecha_Entrada.Location = new System.Drawing.Point(1207, 228);
            this.Lbl_Fecha_Entrada.Name = "Lbl_Fecha_Entrada";
            this.Lbl_Fecha_Entrada.Size = new System.Drawing.Size(77, 13);
            this.Lbl_Fecha_Entrada.TabIndex = 27;
            this.Lbl_Fecha_Entrada.Text = "Fecha Entrada";
            // 
            // Lbl_Habitacion
            // 
            this.Lbl_Habitacion.AutoSize = true;
            this.Lbl_Habitacion.Location = new System.Drawing.Point(1222, 100);
            this.Lbl_Habitacion.Name = "Lbl_Habitacion";
            this.Lbl_Habitacion.Size = new System.Drawing.Size(58, 13);
            this.Lbl_Habitacion.TabIndex = 26;
            this.Lbl_Habitacion.Text = "Habitacion";
            // 
            // Dtp_Entrada
            // 
            this.Dtp_Entrada.Location = new System.Drawing.Point(1141, 244);
            this.Dtp_Entrada.Name = "Dtp_Entrada";
            this.Dtp_Entrada.Size = new System.Drawing.Size(200, 20);
            this.Dtp_Entrada.TabIndex = 25;
            // 
            // Cmb_Habitacion
            // 
            this.Cmb_Habitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Habitacion.FormattingEnabled = true;
            this.Cmb_Habitacion.Location = new System.Drawing.Point(909, 130);
            this.Cmb_Habitacion.Name = "Cmb_Habitacion";
            this.Cmb_Habitacion.Size = new System.Drawing.Size(451, 21);
            this.Cmb_Habitacion.TabIndex = 24;
            // 
            // Dgv_Reservas
            // 
            this.Dgv_Reservas.AllowUserToAddRows = false;
            this.Dgv_Reservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Reservas.Location = new System.Drawing.Point(27, 228);
            this.Dgv_Reservas.Name = "Dgv_Reservas";
            this.Dgv_Reservas.ReadOnly = true;
            this.Dgv_Reservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Reservas.Size = new System.Drawing.Size(1078, 483);
            this.Dgv_Reservas.TabIndex = 23;
            this.Dgv_Reservas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Reservas_CellContentClick);
            // 
            // Txt_Buscar_Reserva
            // 
            this.Txt_Buscar_Reserva.Location = new System.Drawing.Point(63, 131);
            this.Txt_Buscar_Reserva.Name = "Txt_Buscar_Reserva";
            this.Txt_Buscar_Reserva.Size = new System.Drawing.Size(263, 20);
            this.Txt_Buscar_Reserva.TabIndex = 22;
            this.Txt_Buscar_Reserva.TextChanged += new System.EventHandler(this.Txt_Buscar_Reserva_TextChanged);
            // 
            // Lbl_Nombre_Dpi_Pasaporte
            // 
            this.Lbl_Nombre_Dpi_Pasaporte.AutoSize = true;
            this.Lbl_Nombre_Dpi_Pasaporte.Location = new System.Drawing.Point(60, 100);
            this.Lbl_Nombre_Dpi_Pasaporte.Name = "Lbl_Nombre_Dpi_Pasaporte";
            this.Lbl_Nombre_Dpi_Pasaporte.Size = new System.Drawing.Size(227, 13);
            this.Lbl_Nombre_Dpi_Pasaporte.TabIndex = 21;
            this.Lbl_Nombre_Dpi_Pasaporte.Text = "Buscar reserva por Nombre / DPI / Pasaporte:";
            // 
            // Lbl_Modificar_Reservas
            // 
            this.Lbl_Modificar_Reservas.AutoSize = true;
            this.Lbl_Modificar_Reservas.Font = new System.Drawing.Font("Rockwell", 18F);
            this.Lbl_Modificar_Reservas.Location = new System.Drawing.Point(54, 39);
            this.Lbl_Modificar_Reservas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Modificar_Reservas.Name = "Lbl_Modificar_Reservas";
            this.Lbl_Modificar_Reservas.Size = new System.Drawing.Size(221, 27);
            this.Lbl_Modificar_Reservas.TabIndex = 112;
            this.Lbl_Modificar_Reservas.Text = "Modificar reservas";
            // 
            // Txt_Capacidad_Mod
            // 
            this.Txt_Capacidad_Mod.Location = new System.Drawing.Point(1202, 375);
            this.Txt_Capacidad_Mod.Name = "Txt_Capacidad_Mod";
            this.Txt_Capacidad_Mod.Size = new System.Drawing.Size(100, 20);
            this.Txt_Capacidad_Mod.TabIndex = 113;
            // 
            // Frm_Modificar_Reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 816);
            this.Controls.Add(this.Txt_Capacidad_Mod);
            this.Controls.Add(this.Lbl_Modificar_Reservas);
            this.Controls.Add(this.Lbl_Tarifa);
            this.Controls.Add(this.Txt_Tarifa);
            this.Controls.Add(this.Btn_Guardar_Reserva);
            this.Controls.Add(this.Btn_Recalcular_Total);
            this.Controls.Add(this.Lbl_Total_Calculado);
            this.Controls.Add(this.Txt_Total);
            this.Controls.Add(this.Lbl_Estado);
            this.Controls.Add(this.Cmb_Estado);
            this.Controls.Add(this.Lbl_Peticiones_Especiales);
            this.Controls.Add(this.Txt_Peticiones);
            this.Controls.Add(this.Lbl_Cant_Huespedes);
            this.Controls.Add(this.Dtp_Salida);
            this.Controls.Add(this.Lbl_Fecha_Salida);
            this.Controls.Add(this.Lbl_Fecha_Entrada);
            this.Controls.Add(this.Lbl_Habitacion);
            this.Controls.Add(this.Dtp_Entrada);
            this.Controls.Add(this.Cmb_Habitacion);
            this.Controls.Add(this.Dgv_Reservas);
            this.Controls.Add(this.Txt_Buscar_Reserva);
            this.Controls.Add(this.Lbl_Nombre_Dpi_Pasaporte);
            this.Name = "Frm_Modificar_Reserva";
            this.Text = "Frm_Modificar_Reserva";
            this.Load += new System.EventHandler(this.Frm_Modificar_Reserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Reservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Tarifa;
        private System.Windows.Forms.TextBox Txt_Tarifa;
        private System.Windows.Forms.Button Btn_Guardar_Reserva;
        private System.Windows.Forms.Button Btn_Recalcular_Total;
        private System.Windows.Forms.Label Lbl_Total_Calculado;
        private System.Windows.Forms.TextBox Txt_Total;
        private System.Windows.Forms.Label Lbl_Estado;
        private System.Windows.Forms.ComboBox Cmb_Estado;
        private System.Windows.Forms.Label Lbl_Peticiones_Especiales;
        private System.Windows.Forms.TextBox Txt_Peticiones;
        private System.Windows.Forms.Label Lbl_Cant_Huespedes;
        private System.Windows.Forms.DateTimePicker Dtp_Salida;
        private System.Windows.Forms.Label Lbl_Fecha_Salida;
        private System.Windows.Forms.Label Lbl_Fecha_Entrada;
        private System.Windows.Forms.Label Lbl_Habitacion;
        private System.Windows.Forms.DateTimePicker Dtp_Entrada;
        private System.Windows.Forms.ComboBox Cmb_Habitacion;
        private System.Windows.Forms.DataGridView Dgv_Reservas;
        private System.Windows.Forms.TextBox Txt_Buscar_Reserva;
        private System.Windows.Forms.Label Lbl_Nombre_Dpi_Pasaporte;
        private System.Windows.Forms.Label Lbl_Modificar_Reservas;
        private System.Windows.Forms.TextBox Txt_Capacidad_Mod;
    }
}