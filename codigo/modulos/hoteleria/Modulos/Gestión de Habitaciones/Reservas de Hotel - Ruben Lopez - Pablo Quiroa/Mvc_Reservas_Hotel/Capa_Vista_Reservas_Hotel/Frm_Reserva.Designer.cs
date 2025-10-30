
namespace Capa_Vista_Reservas_Hotel
{
    partial class Frm_Reserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Reserva));
            this.Pnl_Superior = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Gpb_buscarDetalle_poliza = new System.Windows.Forms.GroupBox();
            this.Cbo_Id_Estadia = new System.Windows.Forms.ComboBox();
            this.Lbl_Id_Estadia = new System.Windows.Forms.Label();
            this.Cbo_Id_Huesped = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Id_Huesped = new System.Windows.Forms.Label();
            this.Cbo_Id_Reserva = new System.Windows.Forms.ComboBox();
            this.Lbl_Control_Reservas = new System.Windows.Forms.Label();
            this.Gpb_datos = new System.Windows.Forms.GroupBox();
            this.Txt_Total_Reserva = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cbo_Estado_Reserva = new System.Windows.Forms.ComboBox();
            this.Lbl_Estado_Reserva = new System.Windows.Forms.Label();
            this.Chk_Codigo_Promocional = new System.Windows.Forms.CheckBox();
            this.Dtp_Fecha_Entrada = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Fecha_Entrada = new System.Windows.Forms.Label();
            this.Dtp_Fecha_Salida = new System.Windows.Forms.DateTimePicker();
            this.Dtp_Fecha_Reserva = new System.Windows.Forms.DateTimePicker();
            this.Txt_Pais_Huesped = new System.Windows.Forms.TextBox();
            this.Lbl_Peticiones = new System.Windows.Forms.Label();
            this.Txt_Numero_Huespedes = new System.Windows.Forms.TextBox();
            this.Txt_Codigo_Promocional = new System.Windows.Forms.TextBox();
            this.Lbl_Numero_Huespedes = new System.Windows.Forms.Label();
            this.Lbl_Codigo_Promocional = new System.Windows.Forms.Label();
            this.Lbl_Fecha_Salida = new System.Windows.Forms.Label();
            this.Lbl_Fecha_Reserva = new System.Windows.Forms.Label();
            this.Gbp_opc = new System.Windows.Forms.GroupBox();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_nuevo = new System.Windows.Forms.Button();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.Btn_modificar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Pnl_Superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Gpb_buscarDetalle_poliza.SuspendLayout();
            this.Gpb_datos.SuspendLayout();
            this.Gbp_opc.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Superior
            // 
            this.Pnl_Superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(79)))), ((int)(((byte)(101)))));
            this.Pnl_Superior.Controls.Add(this.pictureBox1);
            this.Pnl_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Superior.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Superior.Margin = new System.Windows.Forms.Padding(2);
            this.Pnl_Superior.Name = "Pnl_Superior";
            this.Pnl_Superior.Size = new System.Drawing.Size(790, 41);
            this.Pnl_Superior.TabIndex = 98;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(757, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 35);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Gpb_buscarDetalle_poliza
            // 
            this.Gpb_buscarDetalle_poliza.Controls.Add(this.Cbo_Id_Estadia);
            this.Gpb_buscarDetalle_poliza.Controls.Add(this.Lbl_Id_Estadia);
            this.Gpb_buscarDetalle_poliza.Controls.Add(this.Cbo_Id_Huesped);
            this.Gpb_buscarDetalle_poliza.Controls.Add(this.label1);
            this.Gpb_buscarDetalle_poliza.Controls.Add(this.Lbl_Id_Huesped);
            this.Gpb_buscarDetalle_poliza.Controls.Add(this.Cbo_Id_Reserva);
            this.Gpb_buscarDetalle_poliza.Font = new System.Drawing.Font("Rockwell", 11F);
            this.Gpb_buscarDetalle_poliza.Location = new System.Drawing.Point(9, 90);
            this.Gpb_buscarDetalle_poliza.Margin = new System.Windows.Forms.Padding(2);
            this.Gpb_buscarDetalle_poliza.Name = "Gpb_buscarDetalle_poliza";
            this.Gpb_buscarDetalle_poliza.Padding = new System.Windows.Forms.Padding(2);
            this.Gpb_buscarDetalle_poliza.Size = new System.Drawing.Size(550, 102);
            this.Gpb_buscarDetalle_poliza.TabIndex = 101;
            this.Gpb_buscarDetalle_poliza.TabStop = false;
            this.Gpb_buscarDetalle_poliza.Text = "Información de Huésped";
            // 
            // Cbo_Id_Estadia
            // 
            this.Cbo_Id_Estadia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(215)))), ((int)(((byte)(220)))));
            this.Cbo_Id_Estadia.FormattingEnabled = true;
            this.Cbo_Id_Estadia.Location = new System.Drawing.Point(302, 26);
            this.Cbo_Id_Estadia.Margin = new System.Windows.Forms.Padding(2);
            this.Cbo_Id_Estadia.Name = "Cbo_Id_Estadia";
            this.Cbo_Id_Estadia.Size = new System.Drawing.Size(92, 25);
            this.Cbo_Id_Estadia.TabIndex = 6;
            // 
            // Lbl_Id_Estadia
            // 
            this.Lbl_Id_Estadia.AutoSize = true;
            this.Lbl_Id_Estadia.Location = new System.Drawing.Point(220, 28);
            this.Lbl_Id_Estadia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Id_Estadia.Name = "Lbl_Id_Estadia";
            this.Lbl_Id_Estadia.Size = new System.Drawing.Size(81, 17);
            this.Lbl_Id_Estadia.TabIndex = 5;
            this.Lbl_Id_Estadia.Text = "Id_Estadía";
            // 
            // Cbo_Id_Huesped
            // 
            this.Cbo_Id_Huesped.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(215)))), ((int)(((byte)(220)))));
            this.Cbo_Id_Huesped.FormattingEnabled = true;
            this.Cbo_Id_Huesped.Location = new System.Drawing.Point(105, 50);
            this.Cbo_Id_Huesped.Margin = new System.Windows.Forms.Padding(2);
            this.Cbo_Id_Huesped.Name = "Cbo_Id_Huesped";
            this.Cbo_Id_Huesped.Size = new System.Drawing.Size(90, 25);
            this.Cbo_Id_Huesped.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id_Reserva";
            // 
            // Lbl_Id_Huesped
            // 
            this.Lbl_Id_Huesped.AutoSize = true;
            this.Lbl_Id_Huesped.Location = new System.Drawing.Point(10, 48);
            this.Lbl_Id_Huesped.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Id_Huesped.Name = "Lbl_Id_Huesped";
            this.Lbl_Id_Huesped.Size = new System.Drawing.Size(93, 17);
            this.Lbl_Id_Huesped.TabIndex = 1;
            this.Lbl_Id_Huesped.Text = "Id_Huésped";
            // 
            // Cbo_Id_Reserva
            // 
            this.Cbo_Id_Reserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(215)))), ((int)(((byte)(220)))));
            this.Cbo_Id_Reserva.FormattingEnabled = true;
            this.Cbo_Id_Reserva.Location = new System.Drawing.Point(105, 23);
            this.Cbo_Id_Reserva.Margin = new System.Windows.Forms.Padding(2);
            this.Cbo_Id_Reserva.Name = "Cbo_Id_Reserva";
            this.Cbo_Id_Reserva.Size = new System.Drawing.Size(90, 25);
            this.Cbo_Id_Reserva.TabIndex = 0;
            // 
            // Lbl_Control_Reservas
            // 
            this.Lbl_Control_Reservas.AutoSize = true;
            this.Lbl_Control_Reservas.Font = new System.Drawing.Font("Rockwell", 18F);
            this.Lbl_Control_Reservas.Location = new System.Drawing.Point(9, 50);
            this.Lbl_Control_Reservas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Control_Reservas.Name = "Lbl_Control_Reservas";
            this.Lbl_Control_Reservas.Size = new System.Drawing.Size(233, 27);
            this.Lbl_Control_Reservas.TabIndex = 104;
            this.Lbl_Control_Reservas.Text = "Control de reservas";
            // 
            // Gpb_datos
            // 
            this.Gpb_datos.Controls.Add(this.Txt_Total_Reserva);
            this.Gpb_datos.Controls.Add(this.label2);
            this.Gpb_datos.Controls.Add(this.Cbo_Estado_Reserva);
            this.Gpb_datos.Controls.Add(this.Lbl_Estado_Reserva);
            this.Gpb_datos.Controls.Add(this.Chk_Codigo_Promocional);
            this.Gpb_datos.Controls.Add(this.Dtp_Fecha_Entrada);
            this.Gpb_datos.Controls.Add(this.Lbl_Fecha_Entrada);
            this.Gpb_datos.Controls.Add(this.Dtp_Fecha_Salida);
            this.Gpb_datos.Controls.Add(this.Dtp_Fecha_Reserva);
            this.Gpb_datos.Controls.Add(this.Txt_Pais_Huesped);
            this.Gpb_datos.Controls.Add(this.Lbl_Peticiones);
            this.Gpb_datos.Controls.Add(this.Txt_Numero_Huespedes);
            this.Gpb_datos.Controls.Add(this.Txt_Codigo_Promocional);
            this.Gpb_datos.Controls.Add(this.Lbl_Numero_Huespedes);
            this.Gpb_datos.Controls.Add(this.Lbl_Codigo_Promocional);
            this.Gpb_datos.Controls.Add(this.Lbl_Fecha_Salida);
            this.Gpb_datos.Controls.Add(this.Lbl_Fecha_Reserva);
            this.Gpb_datos.Font = new System.Drawing.Font("Rockwell", 11F);
            this.Gpb_datos.Location = new System.Drawing.Point(9, 205);
            this.Gpb_datos.Margin = new System.Windows.Forms.Padding(2);
            this.Gpb_datos.Name = "Gpb_datos";
            this.Gpb_datos.Padding = new System.Windows.Forms.Padding(2);
            this.Gpb_datos.Size = new System.Drawing.Size(550, 226);
            this.Gpb_datos.TabIndex = 105;
            this.Gpb_datos.TabStop = false;
            this.Gpb_datos.Text = "Datos";
            // 
            // Txt_Total_Reserva
            // 
            this.Txt_Total_Reserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(215)))), ((int)(((byte)(220)))));
            this.Txt_Total_Reserva.Location = new System.Drawing.Point(414, 66);
            this.Txt_Total_Reserva.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Total_Reserva.Name = "Txt_Total_Reserva";
            this.Txt_Total_Reserva.Size = new System.Drawing.Size(124, 25);
            this.Txt_Total_Reserva.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Total reserva:";
            // 
            // Cbo_Estado_Reserva
            // 
            this.Cbo_Estado_Reserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(215)))), ((int)(((byte)(220)))));
            this.Cbo_Estado_Reserva.FormattingEnabled = true;
            this.Cbo_Estado_Reserva.Location = new System.Drawing.Point(414, 34);
            this.Cbo_Estado_Reserva.Margin = new System.Windows.Forms.Padding(2);
            this.Cbo_Estado_Reserva.Name = "Cbo_Estado_Reserva";
            this.Cbo_Estado_Reserva.Size = new System.Drawing.Size(124, 25);
            this.Cbo_Estado_Reserva.TabIndex = 25;
            // 
            // Lbl_Estado_Reserva
            // 
            this.Lbl_Estado_Reserva.AutoSize = true;
            this.Lbl_Estado_Reserva.Location = new System.Drawing.Point(298, 34);
            this.Lbl_Estado_Reserva.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Estado_Reserva.Name = "Lbl_Estado_Reserva";
            this.Lbl_Estado_Reserva.Size = new System.Drawing.Size(116, 17);
            this.Lbl_Estado_Reserva.TabIndex = 24;
            this.Lbl_Estado_Reserva.Text = "Estado reserva:";
            // 
            // Chk_Codigo_Promocional
            // 
            this.Chk_Codigo_Promocional.AutoSize = true;
            this.Chk_Codigo_Promocional.Location = new System.Drawing.Point(332, 157);
            this.Chk_Codigo_Promocional.Margin = new System.Windows.Forms.Padding(2);
            this.Chk_Codigo_Promocional.Name = "Chk_Codigo_Promocional";
            this.Chk_Codigo_Promocional.Size = new System.Drawing.Size(15, 14);
            this.Chk_Codigo_Promocional.TabIndex = 23;
            this.Chk_Codigo_Promocional.UseVisualStyleBackColor = true;
            // 
            // Dtp_Fecha_Entrada
            // 
            this.Dtp_Fecha_Entrada.Location = new System.Drawing.Point(119, 59);
            this.Dtp_Fecha_Entrada.Margin = new System.Windows.Forms.Padding(2);
            this.Dtp_Fecha_Entrada.Name = "Dtp_Fecha_Entrada";
            this.Dtp_Fecha_Entrada.Size = new System.Drawing.Size(151, 25);
            this.Dtp_Fecha_Entrada.TabIndex = 22;
            // 
            // Lbl_Fecha_Entrada
            // 
            this.Lbl_Fecha_Entrada.AutoSize = true;
            this.Lbl_Fecha_Entrada.Location = new System.Drawing.Point(10, 59);
            this.Lbl_Fecha_Entrada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Fecha_Entrada.Name = "Lbl_Fecha_Entrada";
            this.Lbl_Fecha_Entrada.Size = new System.Drawing.Size(112, 17);
            this.Lbl_Fecha_Entrada.TabIndex = 21;
            this.Lbl_Fecha_Entrada.Text = "Fecha entrada:";
            // 
            // Dtp_Fecha_Salida
            // 
            this.Dtp_Fecha_Salida.Location = new System.Drawing.Point(119, 88);
            this.Dtp_Fecha_Salida.Margin = new System.Windows.Forms.Padding(2);
            this.Dtp_Fecha_Salida.Name = "Dtp_Fecha_Salida";
            this.Dtp_Fecha_Salida.Size = new System.Drawing.Size(151, 25);
            this.Dtp_Fecha_Salida.TabIndex = 20;
            // 
            // Dtp_Fecha_Reserva
            // 
            this.Dtp_Fecha_Reserva.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.Dtp_Fecha_Reserva.CalendarTitleForeColor = System.Drawing.Color.AliceBlue;
            this.Dtp_Fecha_Reserva.Location = new System.Drawing.Point(119, 29);
            this.Dtp_Fecha_Reserva.Margin = new System.Windows.Forms.Padding(2);
            this.Dtp_Fecha_Reserva.Name = "Dtp_Fecha_Reserva";
            this.Dtp_Fecha_Reserva.Size = new System.Drawing.Size(151, 25);
            this.Dtp_Fecha_Reserva.TabIndex = 19;
            // 
            // Txt_Pais_Huesped
            // 
            this.Txt_Pais_Huesped.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(215)))), ((int)(((byte)(220)))));
            this.Txt_Pais_Huesped.Location = new System.Drawing.Point(178, 178);
            this.Txt_Pais_Huesped.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Pais_Huesped.Name = "Txt_Pais_Huesped";
            this.Txt_Pais_Huesped.Size = new System.Drawing.Size(224, 25);
            this.Txt_Pais_Huesped.TabIndex = 11;
            // 
            // Lbl_Peticiones
            // 
            this.Lbl_Peticiones.AutoSize = true;
            this.Lbl_Peticiones.Location = new System.Drawing.Point(10, 180);
            this.Lbl_Peticiones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Peticiones.Name = "Lbl_Peticiones";
            this.Lbl_Peticiones.Size = new System.Drawing.Size(167, 17);
            this.Lbl_Peticiones.TabIndex = 10;
            this.Lbl_Peticiones.Text = "Peticiones especiales:";
            // 
            // Txt_Numero_Huespedes
            // 
            this.Txt_Numero_Huespedes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(215)))), ((int)(((byte)(220)))));
            this.Txt_Numero_Huespedes.Location = new System.Drawing.Point(178, 116);
            this.Txt_Numero_Huespedes.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Numero_Huespedes.Name = "Txt_Numero_Huespedes";
            this.Txt_Numero_Huespedes.Size = new System.Drawing.Size(150, 25);
            this.Txt_Numero_Huespedes.TabIndex = 9;
            // 
            // Txt_Codigo_Promocional
            // 
            this.Txt_Codigo_Promocional.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(215)))), ((int)(((byte)(220)))));
            this.Txt_Codigo_Promocional.Location = new System.Drawing.Point(178, 147);
            this.Txt_Codigo_Promocional.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Codigo_Promocional.Name = "Txt_Codigo_Promocional";
            this.Txt_Codigo_Promocional.Size = new System.Drawing.Size(150, 25);
            this.Txt_Codigo_Promocional.TabIndex = 8;
            // 
            // Lbl_Numero_Huespedes
            // 
            this.Lbl_Numero_Huespedes.AutoSize = true;
            this.Lbl_Numero_Huespedes.Location = new System.Drawing.Point(10, 119);
            this.Lbl_Numero_Huespedes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Numero_Huespedes.Name = "Lbl_Numero_Huespedes";
            this.Lbl_Numero_Huespedes.Size = new System.Drawing.Size(174, 17);
            this.Lbl_Numero_Huespedes.TabIndex = 7;
            this.Lbl_Numero_Huespedes.Text = "Numero de Huéspedes:";
            // 
            // Lbl_Codigo_Promocional
            // 
            this.Lbl_Codigo_Promocional.AutoSize = true;
            this.Lbl_Codigo_Promocional.Location = new System.Drawing.Point(10, 150);
            this.Lbl_Codigo_Promocional.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Codigo_Promocional.Name = "Lbl_Codigo_Promocional";
            this.Lbl_Codigo_Promocional.Size = new System.Drawing.Size(158, 17);
            this.Lbl_Codigo_Promocional.TabIndex = 5;
            this.Lbl_Codigo_Promocional.Text = "Codigo promocional:";
            // 
            // Lbl_Fecha_Salida
            // 
            this.Lbl_Fecha_Salida.AutoSize = true;
            this.Lbl_Fecha_Salida.Location = new System.Drawing.Point(10, 86);
            this.Lbl_Fecha_Salida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Fecha_Salida.Name = "Lbl_Fecha_Salida";
            this.Lbl_Fecha_Salida.Size = new System.Drawing.Size(100, 17);
            this.Lbl_Fecha_Salida.TabIndex = 2;
            this.Lbl_Fecha_Salida.Text = "Fecha salida:";
            // 
            // Lbl_Fecha_Reserva
            // 
            this.Lbl_Fecha_Reserva.AutoSize = true;
            this.Lbl_Fecha_Reserva.Location = new System.Drawing.Point(10, 28);
            this.Lbl_Fecha_Reserva.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Fecha_Reserva.Name = "Lbl_Fecha_Reserva";
            this.Lbl_Fecha_Reserva.Size = new System.Drawing.Size(111, 17);
            this.Lbl_Fecha_Reserva.TabIndex = 0;
            this.Lbl_Fecha_Reserva.Text = "Fecha reserva:";
            // 
            // Gbp_opc
            // 
            this.Gbp_opc.Controls.Add(this.Btn_Eliminar);
            this.Gbp_opc.Controls.Add(this.Btn_nuevo);
            this.Gbp_opc.Controls.Add(this.Btn_Limpiar);
            this.Gbp_opc.Controls.Add(this.Btn_modificar);
            this.Gbp_opc.Controls.Add(this.Btn_guardar);
            this.Gbp_opc.Font = new System.Drawing.Font("Rockwell", 11F);
            this.Gbp_opc.Location = new System.Drawing.Point(581, 90);
            this.Gbp_opc.Margin = new System.Windows.Forms.Padding(2);
            this.Gbp_opc.Name = "Gbp_opc";
            this.Gbp_opc.Padding = new System.Windows.Forms.Padding(2);
            this.Gbp_opc.Size = new System.Drawing.Size(170, 339);
            this.Gbp_opc.TabIndex = 106;
            this.Gbp_opc.TabStop = false;
            this.Gbp_opc.Text = "Opciones";
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(74)))), ((int)(((byte)(83)))));
            this.Btn_Eliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Eliminar.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Eliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Eliminar.Image = global::Capa_Vista_Reservas_Hotel.Properties.Resources.icono_eliminar;
            this.Btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Eliminar.Location = new System.Drawing.Point(22, 196);
            this.Btn_Eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(107, 44);
            this.Btn_Eliminar.TabIndex = 5;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            // 
            // Btn_nuevo
            // 
            this.Btn_nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(74)))), ((int)(((byte)(83)))));
            this.Btn_nuevo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_nuevo.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_nuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_nuevo.Image = global::Capa_Vista_Reservas_Hotel.Properties.Resources.icono_agregar;
            this.Btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_nuevo.Location = new System.Drawing.Point(22, 139);
            this.Btn_nuevo.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_nuevo.Name = "Btn_nuevo";
            this.Btn_nuevo.Size = new System.Drawing.Size(107, 44);
            this.Btn_nuevo.TabIndex = 1;
            this.Btn_nuevo.Text = "Nuevo";
            this.Btn_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_nuevo.UseVisualStyleBackColor = false;
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(74)))), ((int)(((byte)(83)))));
            this.Btn_Limpiar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Limpiar.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Limpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Limpiar.Image = global::Capa_Vista_Reservas_Hotel.Properties.Resources.icono_limpiar__1_;
            this.Btn_Limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Limpiar.Location = new System.Drawing.Point(22, 253);
            this.Btn_Limpiar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(107, 44);
            this.Btn_Limpiar.TabIndex = 3;
            this.Btn_Limpiar.Text = "Limpiar";
            this.Btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Limpiar.UseVisualStyleBackColor = false;
            // 
            // Btn_modificar
            // 
            this.Btn_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(74)))), ((int)(((byte)(83)))));
            this.Btn_modificar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_modificar.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_modificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_modificar.Image = global::Capa_Vista_Reservas_Hotel.Properties.Resources.icono_modificar;
            this.Btn_modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_modificar.Location = new System.Drawing.Point(22, 21);
            this.Btn_modificar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_modificar.Name = "Btn_modificar";
            this.Btn_modificar.Size = new System.Drawing.Size(107, 44);
            this.Btn_modificar.TabIndex = 2;
            this.Btn_modificar.Text = "Modificar";
            this.Btn_modificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_modificar.UseVisualStyleBackColor = false;
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(74)))), ((int)(((byte)(83)))));
            this.Btn_guardar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_guardar.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_guardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_guardar.Image = global::Capa_Vista_Reservas_Hotel.Properties.Resources.icono_guardar;
            this.Btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_guardar.Location = new System.Drawing.Point(22, 79);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(107, 44);
            this.Btn_guardar.TabIndex = 0;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_guardar.UseVisualStyleBackColor = false;
            // 
            // Frm_Reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(196)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(790, 482);
            this.Controls.Add(this.Gbp_opc);
            this.Controls.Add(this.Gpb_datos);
            this.Controls.Add(this.Lbl_Control_Reservas);
            this.Controls.Add(this.Gpb_buscarDetalle_poliza);
            this.Controls.Add(this.Pnl_Superior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_Reserva";
            this.Text = "Frm_Reserva";
            this.Pnl_Superior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Gpb_buscarDetalle_poliza.ResumeLayout(false);
            this.Gpb_buscarDetalle_poliza.PerformLayout();
            this.Gpb_datos.ResumeLayout(false);
            this.Gpb_datos.PerformLayout();
            this.Gbp_opc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Superior;
        private System.Windows.Forms.GroupBox Gpb_buscarDetalle_poliza;
        private System.Windows.Forms.Label Lbl_Id_Huesped;
        private System.Windows.Forms.ComboBox Cbo_Id_Reserva;
        private System.Windows.Forms.Label Lbl_Control_Reservas;
        private System.Windows.Forms.GroupBox Gpb_datos;
        private System.Windows.Forms.TextBox Txt_Pais_Huesped;
        private System.Windows.Forms.Label Lbl_Peticiones;
        private System.Windows.Forms.TextBox Txt_Numero_Huespedes;
        private System.Windows.Forms.TextBox Txt_Codigo_Promocional;
        private System.Windows.Forms.Label Lbl_Numero_Huespedes;
        private System.Windows.Forms.Label Lbl_Codigo_Promocional;
        private System.Windows.Forms.Label Lbl_Fecha_Salida;
        private System.Windows.Forms.Label Lbl_Fecha_Reserva;
        private System.Windows.Forms.GroupBox Gbp_opc;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_nuevo;
        private System.Windows.Forms.Button Btn_Limpiar;
        private System.Windows.Forms.Button Btn_modificar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cbo_Id_Huesped;
        private System.Windows.Forms.ComboBox Cbo_Id_Estadia;
        private System.Windows.Forms.Label Lbl_Id_Estadia;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Reserva;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Salida;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Entrada;
        private System.Windows.Forms.Label Lbl_Fecha_Entrada;
        private System.Windows.Forms.CheckBox Chk_Codigo_Promocional;
        private System.Windows.Forms.TextBox Txt_Total_Reserva;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cbo_Estado_Reserva;
        private System.Windows.Forms.Label Lbl_Estado_Reserva;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}