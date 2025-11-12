
namespace Capa_Vista_Reservas_Hotel
{
    partial class Frm_Reservas
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
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.Gpb_Datos = new System.Windows.Forms.GroupBox();
            this.Btn_Calcular_Total = new System.Windows.Forms.Button();
            this.Txt_Buffet_Descripcion = new System.Windows.Forms.TextBox();
            this.Lbl_Buffet_Incluido = new System.Windows.Forms.Label();
            this.Txt_Total_Reserva = new System.Windows.Forms.TextBox();
            this.Lbl_Total_Reserva = new System.Windows.Forms.Label();
            this.Cmb_Estado_Reserva = new System.Windows.Forms.ComboBox();
            this.Lbl_Estado_Reserva = new System.Windows.Forms.Label();
            this.Dtp_Entrada = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Fecha_Entrada = new System.Windows.Forms.Label();
            this.Dtp_Salida = new System.Windows.Forms.DateTimePicker();
            this.Txt_Peticiones = new System.Windows.Forms.TextBox();
            this.Lbl_Peticiones_Especiales = new System.Windows.Forms.Label();
            this.Lbl_Numero_Huespedes = new System.Windows.Forms.Label();
            this.Lbl_Fecha_Salida = new System.Windows.Forms.Label();
            this.Lbl_Control_Reservas = new System.Windows.Forms.Label();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Gpb_Informacion_Huesped = new System.Windows.Forms.GroupBox();
            this.Lbl_Apellido = new System.Windows.Forms.Label();
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.Txt_Tarifa = new System.Windows.Forms.TextBox();
            this.Lbl_Tarifa = new System.Windows.Forms.Label();
            this.Txt_Apellido_Huesped = new System.Windows.Forms.TextBox();
            this.Txt_Nombre_Huesped = new System.Windows.Forms.TextBox();
            this.Btn_Buscar_Huesped = new System.Windows.Forms.Button();
            this.Txt_Puntos_Huesped = new System.Windows.Forms.TextBox();
            this.Lbl_Puntos_Disponibles = new System.Windows.Forms.Label();
            this.Txt_Numero_Documento = new System.Windows.Forms.TextBox();
            this.Cmb_Habitacion = new System.Windows.Forms.ComboBox();
            this.Lbl_Habitacion = new System.Windows.Forms.Label();
            this.Cmb_Tipo_Documento = new System.Windows.Forms.ComboBox();
            this.Lbl_Huesped = new System.Windows.Forms.Label();
            this.Txt_Capacidad = new System.Windows.Forms.TextBox();
            this.Gpb_Datos.SuspendLayout();
            this.Gpb_Informacion_Huesped.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Limpiar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Limpiar.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Limpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Limpiar.Image = global::Capa_Vista_Reservas_Hotel.Properties.Resources.icono_limpiar__1_;
            this.Btn_Limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Limpiar.Location = new System.Drawing.Point(1097, 16);
            this.Btn_Limpiar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(41, 44);
            this.Btn_Limpiar.TabIndex = 109;
            this.Btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Limpiar.UseVisualStyleBackColor = false;
            this.Btn_Limpiar.Click += new System.EventHandler(this.Btn_Limpiar_Click);
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Nuevo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Nuevo.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Nuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Nuevo.Image = global::Capa_Vista_Reservas_Hotel.Properties.Resources.icono_agregar;
            this.Btn_Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Nuevo.Location = new System.Drawing.Point(962, 16);
            this.Btn_Nuevo.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(41, 44);
            this.Btn_Nuevo.TabIndex = 107;
            this.Btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Nuevo.UseVisualStyleBackColor = false;
            // 
            // Gpb_Datos
            // 
            this.Gpb_Datos.Controls.Add(this.Txt_Capacidad);
            this.Gpb_Datos.Controls.Add(this.Btn_Calcular_Total);
            this.Gpb_Datos.Controls.Add(this.Txt_Buffet_Descripcion);
            this.Gpb_Datos.Controls.Add(this.Lbl_Buffet_Incluido);
            this.Gpb_Datos.Controls.Add(this.Txt_Total_Reserva);
            this.Gpb_Datos.Controls.Add(this.Lbl_Total_Reserva);
            this.Gpb_Datos.Controls.Add(this.Cmb_Estado_Reserva);
            this.Gpb_Datos.Controls.Add(this.Lbl_Estado_Reserva);
            this.Gpb_Datos.Controls.Add(this.Dtp_Entrada);
            this.Gpb_Datos.Controls.Add(this.Lbl_Fecha_Entrada);
            this.Gpb_Datos.Controls.Add(this.Dtp_Salida);
            this.Gpb_Datos.Controls.Add(this.Txt_Peticiones);
            this.Gpb_Datos.Controls.Add(this.Lbl_Peticiones_Especiales);
            this.Gpb_Datos.Controls.Add(this.Lbl_Numero_Huespedes);
            this.Gpb_Datos.Controls.Add(this.Lbl_Fecha_Salida);
            this.Gpb_Datos.Font = new System.Drawing.Font("Rockwell", 11F);
            this.Gpb_Datos.Location = new System.Drawing.Point(16, 362);
            this.Gpb_Datos.Margin = new System.Windows.Forms.Padding(2);
            this.Gpb_Datos.Name = "Gpb_Datos";
            this.Gpb_Datos.Padding = new System.Windows.Forms.Padding(2);
            this.Gpb_Datos.Size = new System.Drawing.Size(1110, 256);
            this.Gpb_Datos.TabIndex = 112;
            this.Gpb_Datos.TabStop = false;
            this.Gpb_Datos.Text = "Datos";
            // 
            // Btn_Calcular_Total
            // 
            this.Btn_Calcular_Total.Location = new System.Drawing.Point(984, 166);
            this.Btn_Calcular_Total.Name = "Btn_Calcular_Total";
            this.Btn_Calcular_Total.Size = new System.Drawing.Size(86, 46);
            this.Btn_Calcular_Total.TabIndex = 31;
            this.Btn_Calcular_Total.Text = "calcular total";
            this.Btn_Calcular_Total.UseVisualStyleBackColor = true;
            this.Btn_Calcular_Total.Click += new System.EventHandler(this.Btn_Calcular_Total_Click);
            // 
            // Txt_Buffet_Descripcion
            // 
            this.Txt_Buffet_Descripcion.Location = new System.Drawing.Point(609, 40);
            this.Txt_Buffet_Descripcion.Multiline = true;
            this.Txt_Buffet_Descripcion.Name = "Txt_Buffet_Descripcion";
            this.Txt_Buffet_Descripcion.ReadOnly = true;
            this.Txt_Buffet_Descripcion.Size = new System.Drawing.Size(234, 84);
            this.Txt_Buffet_Descripcion.TabIndex = 29;
            // 
            // Lbl_Buffet_Incluido
            // 
            this.Lbl_Buffet_Incluido.AutoSize = true;
            this.Lbl_Buffet_Incluido.Location = new System.Drawing.Point(670, 20);
            this.Lbl_Buffet_Incluido.Name = "Lbl_Buffet_Incluido";
            this.Lbl_Buffet_Incluido.Size = new System.Drawing.Size(111, 17);
            this.Lbl_Buffet_Incluido.TabIndex = 28;
            this.Lbl_Buffet_Incluido.Text = "Buffet incluido";
            // 
            // Txt_Total_Reserva
            // 
            this.Txt_Total_Reserva.BackColor = System.Drawing.SystemColors.Window;
            this.Txt_Total_Reserva.Location = new System.Drawing.Point(946, 223);
            this.Txt_Total_Reserva.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Total_Reserva.Name = "Txt_Total_Reserva";
            this.Txt_Total_Reserva.ReadOnly = true;
            this.Txt_Total_Reserva.Size = new System.Drawing.Size(124, 25);
            this.Txt_Total_Reserva.TabIndex = 27;
            // 
            // Lbl_Total_Reserva
            // 
            this.Lbl_Total_Reserva.AutoSize = true;
            this.Lbl_Total_Reserva.Location = new System.Drawing.Point(821, 226);
            this.Lbl_Total_Reserva.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Total_Reserva.Name = "Lbl_Total_Reserva";
            this.Lbl_Total_Reserva.Size = new System.Drawing.Size(105, 17);
            this.Lbl_Total_Reserva.TabIndex = 26;
            this.Lbl_Total_Reserva.Text = "Total reserva:";
            // 
            // Cmb_Estado_Reserva
            // 
            this.Cmb_Estado_Reserva.BackColor = System.Drawing.SystemColors.Window;
            this.Cmb_Estado_Reserva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Estado_Reserva.FormattingEnabled = true;
            this.Cmb_Estado_Reserva.Location = new System.Drawing.Point(210, 178);
            this.Cmb_Estado_Reserva.Margin = new System.Windows.Forms.Padding(2);
            this.Cmb_Estado_Reserva.Name = "Cmb_Estado_Reserva";
            this.Cmb_Estado_Reserva.Size = new System.Drawing.Size(188, 25);
            this.Cmb_Estado_Reserva.TabIndex = 25;
            // 
            // Lbl_Estado_Reserva
            // 
            this.Lbl_Estado_Reserva.AutoSize = true;
            this.Lbl_Estado_Reserva.Location = new System.Drawing.Point(10, 186);
            this.Lbl_Estado_Reserva.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Estado_Reserva.Name = "Lbl_Estado_Reserva";
            this.Lbl_Estado_Reserva.Size = new System.Drawing.Size(116, 17);
            this.Lbl_Estado_Reserva.TabIndex = 24;
            this.Lbl_Estado_Reserva.Text = "Estado reserva:";
            // 
            // Dtp_Entrada
            // 
            this.Dtp_Entrada.Location = new System.Drawing.Point(151, 31);
            this.Dtp_Entrada.Margin = new System.Windows.Forms.Padding(2);
            this.Dtp_Entrada.Name = "Dtp_Entrada";
            this.Dtp_Entrada.Size = new System.Drawing.Size(151, 25);
            this.Dtp_Entrada.TabIndex = 22;
            // 
            // Lbl_Fecha_Entrada
            // 
            this.Lbl_Fecha_Entrada.AutoSize = true;
            this.Lbl_Fecha_Entrada.Location = new System.Drawing.Point(10, 34);
            this.Lbl_Fecha_Entrada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Fecha_Entrada.Name = "Lbl_Fecha_Entrada";
            this.Lbl_Fecha_Entrada.Size = new System.Drawing.Size(112, 17);
            this.Lbl_Fecha_Entrada.TabIndex = 21;
            this.Lbl_Fecha_Entrada.Text = "Fecha entrada:";
            // 
            // Dtp_Salida
            // 
            this.Dtp_Salida.Location = new System.Drawing.Point(151, 64);
            this.Dtp_Salida.Margin = new System.Windows.Forms.Padding(2);
            this.Dtp_Salida.Name = "Dtp_Salida";
            this.Dtp_Salida.Size = new System.Drawing.Size(151, 25);
            this.Dtp_Salida.TabIndex = 20;
            // 
            // Txt_Peticiones
            // 
            this.Txt_Peticiones.BackColor = System.Drawing.SystemColors.Window;
            this.Txt_Peticiones.Location = new System.Drawing.Point(210, 149);
            this.Txt_Peticiones.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Peticiones.Name = "Txt_Peticiones";
            this.Txt_Peticiones.Size = new System.Drawing.Size(224, 25);
            this.Txt_Peticiones.TabIndex = 11;
            // 
            // Lbl_Peticiones_Especiales
            // 
            this.Lbl_Peticiones_Especiales.AutoSize = true;
            this.Lbl_Peticiones_Especiales.Location = new System.Drawing.Point(10, 157);
            this.Lbl_Peticiones_Especiales.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Peticiones_Especiales.Name = "Lbl_Peticiones_Especiales";
            this.Lbl_Peticiones_Especiales.Size = new System.Drawing.Size(167, 17);
            this.Lbl_Peticiones_Especiales.TabIndex = 10;
            this.Lbl_Peticiones_Especiales.Text = "Peticiones especiales:";
            // 
            // Lbl_Numero_Huespedes
            // 
            this.Lbl_Numero_Huespedes.AutoSize = true;
            this.Lbl_Numero_Huespedes.Location = new System.Drawing.Point(10, 116);
            this.Lbl_Numero_Huespedes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Numero_Huespedes.Name = "Lbl_Numero_Huespedes";
            this.Lbl_Numero_Huespedes.Size = new System.Drawing.Size(174, 17);
            this.Lbl_Numero_Huespedes.TabIndex = 7;
            this.Lbl_Numero_Huespedes.Text = "Numero de Huéspedes:";
            // 
            // Lbl_Fecha_Salida
            // 
            this.Lbl_Fecha_Salida.AutoSize = true;
            this.Lbl_Fecha_Salida.Location = new System.Drawing.Point(10, 72);
            this.Lbl_Fecha_Salida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Fecha_Salida.Name = "Lbl_Fecha_Salida";
            this.Lbl_Fecha_Salida.Size = new System.Drawing.Size(100, 17);
            this.Lbl_Fecha_Salida.TabIndex = 2;
            this.Lbl_Fecha_Salida.Text = "Fecha salida:";
            // 
            // Lbl_Control_Reservas
            // 
            this.Lbl_Control_Reservas.AutoSize = true;
            this.Lbl_Control_Reservas.Font = new System.Drawing.Font("Rockwell", 18F);
            this.Lbl_Control_Reservas.Location = new System.Drawing.Point(11, 32);
            this.Lbl_Control_Reservas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Control_Reservas.Name = "Lbl_Control_Reservas";
            this.Lbl_Control_Reservas.Size = new System.Drawing.Size(233, 27);
            this.Lbl_Control_Reservas.TabIndex = 111;
            this.Lbl_Control_Reservas.Text = "Control de reservas";
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Guardar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Guardar.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Guardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Guardar.Image = global::Capa_Vista_Reservas_Hotel.Properties.Resources.icono_guardar;
            this.Btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Guardar.Location = new System.Drawing.Point(1007, 15);
            this.Btn_Guardar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(41, 44);
            this.Btn_Guardar.TabIndex = 106;
            this.Btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Guardar.UseVisualStyleBackColor = false;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Modificar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Modificar.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Modificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Modificar.Image = global::Capa_Vista_Reservas_Hotel.Properties.Resources.icono_modificar;
            this.Btn_Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Modificar.Location = new System.Drawing.Point(1052, 15);
            this.Btn_Modificar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(41, 44);
            this.Btn_Modificar.TabIndex = 108;
            this.Btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Modificar.UseVisualStyleBackColor = false;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Gpb_Informacion_Huesped
            // 
            this.Gpb_Informacion_Huesped.Controls.Add(this.Lbl_Apellido);
            this.Gpb_Informacion_Huesped.Controls.Add(this.Lbl_Nombre);
            this.Gpb_Informacion_Huesped.Controls.Add(this.Txt_Tarifa);
            this.Gpb_Informacion_Huesped.Controls.Add(this.Lbl_Tarifa);
            this.Gpb_Informacion_Huesped.Controls.Add(this.Txt_Apellido_Huesped);
            this.Gpb_Informacion_Huesped.Controls.Add(this.Txt_Nombre_Huesped);
            this.Gpb_Informacion_Huesped.Controls.Add(this.Btn_Buscar_Huesped);
            this.Gpb_Informacion_Huesped.Controls.Add(this.Txt_Puntos_Huesped);
            this.Gpb_Informacion_Huesped.Controls.Add(this.Lbl_Puntos_Disponibles);
            this.Gpb_Informacion_Huesped.Controls.Add(this.Txt_Numero_Documento);
            this.Gpb_Informacion_Huesped.Controls.Add(this.Cmb_Habitacion);
            this.Gpb_Informacion_Huesped.Controls.Add(this.Lbl_Habitacion);
            this.Gpb_Informacion_Huesped.Controls.Add(this.Cmb_Tipo_Documento);
            this.Gpb_Informacion_Huesped.Controls.Add(this.Lbl_Huesped);
            this.Gpb_Informacion_Huesped.Font = new System.Drawing.Font("Rockwell", 11F);
            this.Gpb_Informacion_Huesped.Location = new System.Drawing.Point(16, 108);
            this.Gpb_Informacion_Huesped.Margin = new System.Windows.Forms.Padding(2);
            this.Gpb_Informacion_Huesped.Name = "Gpb_Informacion_Huesped";
            this.Gpb_Informacion_Huesped.Padding = new System.Windows.Forms.Padding(2);
            this.Gpb_Informacion_Huesped.Size = new System.Drawing.Size(1106, 219);
            this.Gpb_Informacion_Huesped.TabIndex = 110;
            this.Gpb_Informacion_Huesped.TabStop = false;
            this.Gpb_Informacion_Huesped.Text = "Información de Huésped";
            // 
            // Lbl_Apellido
            // 
            this.Lbl_Apellido.AutoSize = true;
            this.Lbl_Apellido.Location = new System.Drawing.Point(118, 105);
            this.Lbl_Apellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Apellido.Name = "Lbl_Apellido";
            this.Lbl_Apellido.Size = new System.Drawing.Size(69, 17);
            this.Lbl_Apellido.TabIndex = 16;
            this.Lbl_Apellido.Text = "Apellido";
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.Location = new System.Drawing.Point(113, 71);
            this.Lbl_Nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(66, 17);
            this.Lbl_Nombre.TabIndex = 15;
            this.Lbl_Nombre.Text = "Nombre";
            // 
            // Txt_Tarifa
            // 
            this.Txt_Tarifa.Location = new System.Drawing.Point(590, 71);
            this.Txt_Tarifa.Name = "Txt_Tarifa";
            this.Txt_Tarifa.ReadOnly = true;
            this.Txt_Tarifa.Size = new System.Drawing.Size(100, 25);
            this.Txt_Tarifa.TabIndex = 14;
            // 
            // Lbl_Tarifa
            // 
            this.Lbl_Tarifa.AutoSize = true;
            this.Lbl_Tarifa.Location = new System.Drawing.Point(488, 74);
            this.Lbl_Tarifa.Name = "Lbl_Tarifa";
            this.Lbl_Tarifa.Size = new System.Drawing.Size(48, 17);
            this.Lbl_Tarifa.TabIndex = 13;
            this.Lbl_Tarifa.Text = "Tarifa";
            // 
            // Txt_Apellido_Huesped
            // 
            this.Txt_Apellido_Huesped.Location = new System.Drawing.Point(224, 97);
            this.Txt_Apellido_Huesped.Name = "Txt_Apellido_Huesped";
            this.Txt_Apellido_Huesped.ReadOnly = true;
            this.Txt_Apellido_Huesped.Size = new System.Drawing.Size(158, 25);
            this.Txt_Apellido_Huesped.TabIndex = 12;
            // 
            // Txt_Nombre_Huesped
            // 
            this.Txt_Nombre_Huesped.Location = new System.Drawing.Point(224, 66);
            this.Txt_Nombre_Huesped.Name = "Txt_Nombre_Huesped";
            this.Txt_Nombre_Huesped.ReadOnly = true;
            this.Txt_Nombre_Huesped.Size = new System.Drawing.Size(158, 25);
            this.Txt_Nombre_Huesped.TabIndex = 11;
            // 
            // Btn_Buscar_Huesped
            // 
            this.Btn_Buscar_Huesped.Location = new System.Drawing.Point(20, 68);
            this.Btn_Buscar_Huesped.Name = "Btn_Buscar_Huesped";
            this.Btn_Buscar_Huesped.Size = new System.Drawing.Size(75, 23);
            this.Btn_Buscar_Huesped.TabIndex = 10;
            this.Btn_Buscar_Huesped.Text = "buscar";
            this.Btn_Buscar_Huesped.UseVisualStyleBackColor = true;
            this.Btn_Buscar_Huesped.Click += new System.EventHandler(this.Btn_Buscar_Huesped_Click);
            // 
            // Txt_Puntos_Huesped
            // 
            this.Txt_Puntos_Huesped.Location = new System.Drawing.Point(224, 158);
            this.Txt_Puntos_Huesped.Name = "Txt_Puntos_Huesped";
            this.Txt_Puntos_Huesped.ReadOnly = true;
            this.Txt_Puntos_Huesped.Size = new System.Drawing.Size(164, 25);
            this.Txt_Puntos_Huesped.TabIndex = 9;
            // 
            // Lbl_Puntos_Disponibles
            // 
            this.Lbl_Puntos_Disponibles.AutoSize = true;
            this.Lbl_Puntos_Disponibles.Location = new System.Drawing.Point(10, 166);
            this.Lbl_Puntos_Disponibles.Name = "Lbl_Puntos_Disponibles";
            this.Lbl_Puntos_Disponibles.Size = new System.Drawing.Size(144, 17);
            this.Lbl_Puntos_Disponibles.TabIndex = 8;
            this.Lbl_Puntos_Disponibles.Text = "Puntos disponibles";
            // 
            // Txt_Numero_Documento
            // 
            this.Txt_Numero_Documento.Location = new System.Drawing.Point(235, 28);
            this.Txt_Numero_Documento.Name = "Txt_Numero_Documento";
            this.Txt_Numero_Documento.Size = new System.Drawing.Size(164, 25);
            this.Txt_Numero_Documento.TabIndex = 7;
            // 
            // Cmb_Habitacion
            // 
            this.Cmb_Habitacion.BackColor = System.Drawing.SystemColors.Window;
            this.Cmb_Habitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Habitacion.FormattingEnabled = true;
            this.Cmb_Habitacion.Location = new System.Drawing.Point(590, 28);
            this.Cmb_Habitacion.Margin = new System.Windows.Forms.Padding(2);
            this.Cmb_Habitacion.Name = "Cmb_Habitacion";
            this.Cmb_Habitacion.Size = new System.Drawing.Size(493, 25);
            this.Cmb_Habitacion.TabIndex = 6;
            this.Cmb_Habitacion.SelectedIndexChanged += new System.EventHandler(this.Cmb_Habitacion_SelectedIndexChanged);
            // 
            // Lbl_Habitacion
            // 
            this.Lbl_Habitacion.AutoSize = true;
            this.Lbl_Habitacion.Location = new System.Drawing.Point(488, 31);
            this.Lbl_Habitacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Habitacion.Name = "Lbl_Habitacion";
            this.Lbl_Habitacion.Size = new System.Drawing.Size(86, 17);
            this.Lbl_Habitacion.TabIndex = 5;
            this.Lbl_Habitacion.Text = "Habitacion";
            // 
            // Cmb_Tipo_Documento
            // 
            this.Cmb_Tipo_Documento.BackColor = System.Drawing.SystemColors.Window;
            this.Cmb_Tipo_Documento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Tipo_Documento.FormattingEnabled = true;
            this.Cmb_Tipo_Documento.Location = new System.Drawing.Point(94, 28);
            this.Cmb_Tipo_Documento.Margin = new System.Windows.Forms.Padding(2);
            this.Cmb_Tipo_Documento.Name = "Cmb_Tipo_Documento";
            this.Cmb_Tipo_Documento.Size = new System.Drawing.Size(123, 25);
            this.Cmb_Tipo_Documento.TabIndex = 4;
            // 
            // Lbl_Huesped
            // 
            this.Lbl_Huesped.AutoSize = true;
            this.Lbl_Huesped.Location = new System.Drawing.Point(17, 31);
            this.Lbl_Huesped.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Huesped.Name = "Lbl_Huesped";
            this.Lbl_Huesped.Size = new System.Drawing.Size(71, 17);
            this.Lbl_Huesped.TabIndex = 1;
            this.Lbl_Huesped.Text = "Huésped";
            // 
            // Txt_Capacidad
            // 
            this.Txt_Capacidad.Location = new System.Drawing.Point(210, 113);
            this.Txt_Capacidad.Name = "Txt_Capacidad";
            this.Txt_Capacidad.ReadOnly = true;
            this.Txt_Capacidad.Size = new System.Drawing.Size(100, 25);
            this.Txt_Capacidad.TabIndex = 32;
            this.Txt_Capacidad.TabStop = false;
            // 
            // Frm_Reservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 632);
            this.Controls.Add(this.Btn_Limpiar);
            this.Controls.Add(this.Btn_Nuevo);
            this.Controls.Add(this.Gpb_Datos);
            this.Controls.Add(this.Lbl_Control_Reservas);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Gpb_Informacion_Huesped);
            this.Name = "Frm_Reservas";
            this.Text = "Frm_Reservas";
            this.Load += new System.EventHandler(this.Frm_Reservas_Load);
            this.Gpb_Datos.ResumeLayout(false);
            this.Gpb_Datos.PerformLayout();
            this.Gpb_Informacion_Huesped.ResumeLayout(false);
            this.Gpb_Informacion_Huesped.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Limpiar;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.GroupBox Gpb_Datos;
        private System.Windows.Forms.Button Btn_Calcular_Total;
        private System.Windows.Forms.TextBox Txt_Buffet_Descripcion;
        private System.Windows.Forms.Label Lbl_Buffet_Incluido;
        private System.Windows.Forms.TextBox Txt_Total_Reserva;
        private System.Windows.Forms.Label Lbl_Total_Reserva;
        private System.Windows.Forms.ComboBox Cmb_Estado_Reserva;
        private System.Windows.Forms.Label Lbl_Estado_Reserva;
        private System.Windows.Forms.DateTimePicker Dtp_Entrada;
        private System.Windows.Forms.Label Lbl_Fecha_Entrada;
        private System.Windows.Forms.DateTimePicker Dtp_Salida;
        private System.Windows.Forms.TextBox Txt_Peticiones;
        private System.Windows.Forms.Label Lbl_Peticiones_Especiales;
        private System.Windows.Forms.Label Lbl_Numero_Huespedes;
        private System.Windows.Forms.Label Lbl_Fecha_Salida;
        private System.Windows.Forms.Label Lbl_Control_Reservas;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.GroupBox Gpb_Informacion_Huesped;
        private System.Windows.Forms.Label Lbl_Apellido;
        private System.Windows.Forms.Label Lbl_Nombre;
        private System.Windows.Forms.TextBox Txt_Tarifa;
        private System.Windows.Forms.Label Lbl_Tarifa;
        private System.Windows.Forms.TextBox Txt_Apellido_Huesped;
        private System.Windows.Forms.TextBox Txt_Nombre_Huesped;
        private System.Windows.Forms.Button Btn_Buscar_Huesped;
        private System.Windows.Forms.TextBox Txt_Puntos_Huesped;
        private System.Windows.Forms.Label Lbl_Puntos_Disponibles;
        private System.Windows.Forms.TextBox Txt_Numero_Documento;
        private System.Windows.Forms.ComboBox Cmb_Habitacion;
        private System.Windows.Forms.Label Lbl_Habitacion;
        private System.Windows.Forms.ComboBox Cmb_Tipo_Documento;
        private System.Windows.Forms.Label Lbl_Huesped;
        private System.Windows.Forms.TextBox Txt_Capacidad;
    }
}