
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
            this.Pnl_Superior = new System.Windows.Forms.Panel();
            this.Gpb_buscarDetalle_poliza = new System.Windows.Forms.GroupBox();
            this.Lbl_Id_Huesped = new System.Windows.Forms.Label();
            this.Cbo_Id_Reserva = new System.Windows.Forms.ComboBox();
            this.Lbl_Control_Reservas = new System.Windows.Forms.Label();
            this.Gpb_datos = new System.Windows.Forms.GroupBox();
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
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Btn_nuevo = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Btn_modificar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Cbo_Id_Huesped = new System.Windows.Forms.ComboBox();
            this.Lbl_Id_Estadia = new System.Windows.Forms.Label();
            this.Cbo_Id_Estadia = new System.Windows.Forms.ComboBox();
            this.Dtp_Fecha_Reserva = new System.Windows.Forms.DateTimePicker();
            this.Dtp_Fecha_Salida = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Fecha_Entrada = new System.Windows.Forms.Label();
            this.Dtp_Fecha_Entrada = new System.Windows.Forms.DateTimePicker();
            this.Chk_Codigo_Promocional = new System.Windows.Forms.CheckBox();
            this.Lbl_Estado_Reserva = new System.Windows.Forms.Label();
            this.Cbo_Estado_Reserva = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Total_Reserva = new System.Windows.Forms.TextBox();
            this.Gpb_buscarDetalle_poliza.SuspendLayout();
            this.Gpb_datos.SuspendLayout();
            this.Gbp_opc.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Superior
            // 
            this.Pnl_Superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(142)))), ((int)(((byte)(181)))));
            this.Pnl_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Superior.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Superior.Name = "Pnl_Superior";
            this.Pnl_Superior.Size = new System.Drawing.Size(1053, 50);
            this.Pnl_Superior.TabIndex = 98;
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
            this.Gpb_buscarDetalle_poliza.Location = new System.Drawing.Point(12, 111);
            this.Gpb_buscarDetalle_poliza.Name = "Gpb_buscarDetalle_poliza";
            this.Gpb_buscarDetalle_poliza.Size = new System.Drawing.Size(733, 125);
            this.Gpb_buscarDetalle_poliza.TabIndex = 101;
            this.Gpb_buscarDetalle_poliza.TabStop = false;
            this.Gpb_buscarDetalle_poliza.Text = "Información de Huésped";
            // 
            // Lbl_Id_Huesped
            // 
            this.Lbl_Id_Huesped.AutoSize = true;
            this.Lbl_Id_Huesped.Location = new System.Drawing.Point(13, 59);
            this.Lbl_Id_Huesped.Name = "Lbl_Id_Huesped";
            this.Lbl_Id_Huesped.Size = new System.Drawing.Size(117, 21);
            this.Lbl_Id_Huesped.TabIndex = 1;
            this.Lbl_Id_Huesped.Text = "Id_Huésped";
            // 
            // Cbo_Id_Reserva
            // 
            this.Cbo_Id_Reserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.Cbo_Id_Reserva.FormattingEnabled = true;
            this.Cbo_Id_Reserva.Location = new System.Drawing.Point(140, 28);
            this.Cbo_Id_Reserva.Name = "Cbo_Id_Reserva";
            this.Cbo_Id_Reserva.Size = new System.Drawing.Size(118, 28);
            this.Cbo_Id_Reserva.TabIndex = 0;
            // 
            // Lbl_Control_Reservas
            // 
            this.Lbl_Control_Reservas.AutoSize = true;
            this.Lbl_Control_Reservas.Font = new System.Drawing.Font("Rockwell", 18F);
            this.Lbl_Control_Reservas.Location = new System.Drawing.Point(12, 62);
            this.Lbl_Control_Reservas.Name = "Lbl_Control_Reservas";
            this.Lbl_Control_Reservas.Size = new System.Drawing.Size(292, 35);
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
            this.Gpb_datos.Location = new System.Drawing.Point(12, 252);
            this.Gpb_datos.Name = "Gpb_datos";
            this.Gpb_datos.Size = new System.Drawing.Size(733, 278);
            this.Gpb_datos.TabIndex = 105;
            this.Gpb_datos.TabStop = false;
            this.Gpb_datos.Text = "Datos";
            // 
            // Txt_Pais_Huesped
            // 
            this.Txt_Pais_Huesped.Location = new System.Drawing.Point(238, 219);
            this.Txt_Pais_Huesped.Name = "Txt_Pais_Huesped";
            this.Txt_Pais_Huesped.Size = new System.Drawing.Size(297, 29);
            this.Txt_Pais_Huesped.TabIndex = 11;
            // 
            // Lbl_Peticiones
            // 
            this.Lbl_Peticiones.AutoSize = true;
            this.Lbl_Peticiones.Location = new System.Drawing.Point(13, 222);
            this.Lbl_Peticiones.Name = "Lbl_Peticiones";
            this.Lbl_Peticiones.Size = new System.Drawing.Size(208, 21);
            this.Lbl_Peticiones.TabIndex = 10;
            this.Lbl_Peticiones.Text = "Peticiones especiales:";
            // 
            // Txt_Numero_Huespedes
            // 
            this.Txt_Numero_Huespedes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.Txt_Numero_Huespedes.Location = new System.Drawing.Point(238, 143);
            this.Txt_Numero_Huespedes.Name = "Txt_Numero_Huespedes";
            this.Txt_Numero_Huespedes.Size = new System.Drawing.Size(199, 29);
            this.Txt_Numero_Huespedes.TabIndex = 9;
            // 
            // Txt_Codigo_Promocional
            // 
            this.Txt_Codigo_Promocional.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.Txt_Codigo_Promocional.Location = new System.Drawing.Point(238, 181);
            this.Txt_Codigo_Promocional.Name = "Txt_Codigo_Promocional";
            this.Txt_Codigo_Promocional.Size = new System.Drawing.Size(199, 29);
            this.Txt_Codigo_Promocional.TabIndex = 8;
            // 
            // Lbl_Numero_Huespedes
            // 
            this.Lbl_Numero_Huespedes.AutoSize = true;
            this.Lbl_Numero_Huespedes.Location = new System.Drawing.Point(13, 146);
            this.Lbl_Numero_Huespedes.Name = "Lbl_Numero_Huespedes";
            this.Lbl_Numero_Huespedes.Size = new System.Drawing.Size(219, 21);
            this.Lbl_Numero_Huespedes.TabIndex = 7;
            this.Lbl_Numero_Huespedes.Text = "Numero de Huéspedes:";
            // 
            // Lbl_Codigo_Promocional
            // 
            this.Lbl_Codigo_Promocional.AutoSize = true;
            this.Lbl_Codigo_Promocional.Location = new System.Drawing.Point(13, 184);
            this.Lbl_Codigo_Promocional.Name = "Lbl_Codigo_Promocional";
            this.Lbl_Codigo_Promocional.Size = new System.Drawing.Size(199, 21);
            this.Lbl_Codigo_Promocional.TabIndex = 5;
            this.Lbl_Codigo_Promocional.Text = "Codigo promocional:";
            // 
            // Lbl_Fecha_Salida
            // 
            this.Lbl_Fecha_Salida.AutoSize = true;
            this.Lbl_Fecha_Salida.Location = new System.Drawing.Point(13, 106);
            this.Lbl_Fecha_Salida.Name = "Lbl_Fecha_Salida";
            this.Lbl_Fecha_Salida.Size = new System.Drawing.Size(126, 21);
            this.Lbl_Fecha_Salida.TabIndex = 2;
            this.Lbl_Fecha_Salida.Text = "Fecha salida:";
            // 
            // Lbl_Fecha_Reserva
            // 
            this.Lbl_Fecha_Reserva.AutoSize = true;
            this.Lbl_Fecha_Reserva.Location = new System.Drawing.Point(13, 34);
            this.Lbl_Fecha_Reserva.Name = "Lbl_Fecha_Reserva";
            this.Lbl_Fecha_Reserva.Size = new System.Drawing.Size(140, 21);
            this.Lbl_Fecha_Reserva.TabIndex = 0;
            this.Lbl_Fecha_Reserva.Text = "Fecha reserva:";
            // 
            // Gbp_opc
            // 
            this.Gbp_opc.Controls.Add(this.Btn_Eliminar);
            this.Gbp_opc.Controls.Add(this.Btn_salir);
            this.Gbp_opc.Controls.Add(this.Btn_nuevo);
            this.Gbp_opc.Controls.Add(this.Btn_cancelar);
            this.Gbp_opc.Controls.Add(this.Btn_modificar);
            this.Gbp_opc.Controls.Add(this.Btn_guardar);
            this.Gbp_opc.Font = new System.Drawing.Font("Rockwell", 11F);
            this.Gbp_opc.Location = new System.Drawing.Point(772, 84);
            this.Gbp_opc.Name = "Gbp_opc";
            this.Gbp_opc.Size = new System.Drawing.Size(227, 472);
            this.Gbp_opc.TabIndex = 106;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id_Reserva";
            // 
            // Cbo_Id_Huesped
            // 
            this.Cbo_Id_Huesped.FormattingEnabled = true;
            this.Cbo_Id_Huesped.Location = new System.Drawing.Point(140, 62);
            this.Cbo_Id_Huesped.Name = "Cbo_Id_Huesped";
            this.Cbo_Id_Huesped.Size = new System.Drawing.Size(118, 28);
            this.Cbo_Id_Huesped.TabIndex = 4;
            // 
            // Lbl_Id_Estadia
            // 
            this.Lbl_Id_Estadia.AutoSize = true;
            this.Lbl_Id_Estadia.Location = new System.Drawing.Point(293, 35);
            this.Lbl_Id_Estadia.Name = "Lbl_Id_Estadia";
            this.Lbl_Id_Estadia.Size = new System.Drawing.Size(103, 21);
            this.Lbl_Id_Estadia.TabIndex = 5;
            this.Lbl_Id_Estadia.Text = "Id_Estadía";
            // 
            // Cbo_Id_Estadia
            // 
            this.Cbo_Id_Estadia.FormattingEnabled = true;
            this.Cbo_Id_Estadia.Location = new System.Drawing.Point(402, 32);
            this.Cbo_Id_Estadia.Name = "Cbo_Id_Estadia";
            this.Cbo_Id_Estadia.Size = new System.Drawing.Size(121, 28);
            this.Cbo_Id_Estadia.TabIndex = 6;
            // 
            // Dtp_Fecha_Reserva
            // 
            this.Dtp_Fecha_Reserva.Location = new System.Drawing.Point(159, 36);
            this.Dtp_Fecha_Reserva.Name = "Dtp_Fecha_Reserva";
            this.Dtp_Fecha_Reserva.Size = new System.Drawing.Size(200, 29);
            this.Dtp_Fecha_Reserva.TabIndex = 19;
            // 
            // Dtp_Fecha_Salida
            // 
            this.Dtp_Fecha_Salida.Location = new System.Drawing.Point(159, 108);
            this.Dtp_Fecha_Salida.Name = "Dtp_Fecha_Salida";
            this.Dtp_Fecha_Salida.Size = new System.Drawing.Size(200, 29);
            this.Dtp_Fecha_Salida.TabIndex = 20;
            // 
            // Lbl_Fecha_Entrada
            // 
            this.Lbl_Fecha_Entrada.AutoSize = true;
            this.Lbl_Fecha_Entrada.Location = new System.Drawing.Point(13, 73);
            this.Lbl_Fecha_Entrada.Name = "Lbl_Fecha_Entrada";
            this.Lbl_Fecha_Entrada.Size = new System.Drawing.Size(141, 21);
            this.Lbl_Fecha_Entrada.TabIndex = 21;
            this.Lbl_Fecha_Entrada.Text = "Fecha entrada:";
            // 
            // Dtp_Fecha_Entrada
            // 
            this.Dtp_Fecha_Entrada.Location = new System.Drawing.Point(159, 73);
            this.Dtp_Fecha_Entrada.Name = "Dtp_Fecha_Entrada";
            this.Dtp_Fecha_Entrada.Size = new System.Drawing.Size(200, 29);
            this.Dtp_Fecha_Entrada.TabIndex = 22;
            // 
            // Chk_Codigo_Promocional
            // 
            this.Chk_Codigo_Promocional.AutoSize = true;
            this.Chk_Codigo_Promocional.Location = new System.Drawing.Point(443, 193);
            this.Chk_Codigo_Promocional.Name = "Chk_Codigo_Promocional";
            this.Chk_Codigo_Promocional.Size = new System.Drawing.Size(18, 17);
            this.Chk_Codigo_Promocional.TabIndex = 23;
            this.Chk_Codigo_Promocional.UseVisualStyleBackColor = true;
            // 
            // Lbl_Estado_Reserva
            // 
            this.Lbl_Estado_Reserva.AutoSize = true;
            this.Lbl_Estado_Reserva.Location = new System.Drawing.Point(398, 42);
            this.Lbl_Estado_Reserva.Name = "Lbl_Estado_Reserva";
            this.Lbl_Estado_Reserva.Size = new System.Drawing.Size(148, 21);
            this.Lbl_Estado_Reserva.TabIndex = 24;
            this.Lbl_Estado_Reserva.Text = "Estado reserva:";
            // 
            // Cbo_Estado_Reserva
            // 
            this.Cbo_Estado_Reserva.FormattingEnabled = true;
            this.Cbo_Estado_Reserva.Location = new System.Drawing.Point(552, 42);
            this.Cbo_Estado_Reserva.Name = "Cbo_Estado_Reserva";
            this.Cbo_Estado_Reserva.Size = new System.Drawing.Size(164, 28);
            this.Cbo_Estado_Reserva.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "Total reserva:";
            // 
            // Txt_Total_Reserva
            // 
            this.Txt_Total_Reserva.Location = new System.Drawing.Point(552, 81);
            this.Txt_Total_Reserva.Name = "Txt_Total_Reserva";
            this.Txt_Total_Reserva.Size = new System.Drawing.Size(164, 29);
            this.Txt_Total_Reserva.TabIndex = 27;
            // 
            // Frm_Reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(1053, 593);
            this.Controls.Add(this.Gbp_opc);
            this.Controls.Add(this.Gpb_datos);
            this.Controls.Add(this.Lbl_Control_Reservas);
            this.Controls.Add(this.Gpb_buscarDetalle_poliza);
            this.Controls.Add(this.Pnl_Superior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Reserva";
            this.Text = "Frm_Reserva";
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
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Button Btn_nuevo;
        private System.Windows.Forms.Button Btn_cancelar;
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
    }
}