
namespace Capa_Vista_Gestion_Habitacion
{
    partial class Frm_Estadia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Estadia));
            this.lbl_idestadia = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.lbl_idHabitacion = new System.Windows.Forms.Label();
            this.lbl_idhuesped = new System.Windows.Forms.Label();
            this.txt_Num_Huespedes = new System.Windows.Forms.TextBox();
            this.lbl_Num_Huespedes = new System.Windows.Forms.Label();
            this.lbl_fecha_check_In = new System.Windows.Forms.Label();
            this.DTP_Check_in = new System.Windows.Forms.DateTimePicker();
            this.lbl_Fecha_actual = new System.Windows.Forms.Label();
            this.DTP_CheckOut = new System.Windows.Forms.DateTimePicker();
            this.lbl_Reservacion = new System.Windows.Forms.Label();
            this.Chk_TieneReservación = new System.Windows.Forms.CheckBox();
            this.lbl_Monto_Total = new System.Windows.Forms.Label();
            this.lbl_montoTotal = new System.Windows.Forms.Label();
            this.btn_Reportes = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.cbo_fk_id_Habitacion = new System.Windows.Forms.ComboBox();
            this.cbo_Fk_Id_Huesped = new System.Windows.Forms.ComboBox();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.lbl_Precio_Unitario = new System.Windows.Forms.Label();
            this.lbl_monto_noche = new System.Windows.Forms.Label();
            this.Cbo_PK_Id_Estadia = new System.Windows.Forms.ComboBox();
            this.lbl_maxima_capacidad = new System.Windows.Forms.Label();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.cbo_Reserva = new System.Windows.Forms.ComboBox();
            this.lbl_Reserva = new System.Windows.Forms.Label();
            this.btn_buscar_reserva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_idestadia
            // 
            this.lbl_idestadia.AutoSize = true;
            this.lbl_idestadia.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idestadia.Location = new System.Drawing.Point(78, 182);
            this.lbl_idestadia.Name = "lbl_idestadia";
            this.lbl_idestadia.Size = new System.Drawing.Size(66, 16);
            this.lbl_idestadia.TabIndex = 2;
            this.lbl_idestadia.Text = "Id Estadia";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Buscar.Image")));
            this.btn_Buscar.Location = new System.Drawing.Point(439, 12);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(87, 85);
            this.btn_Buscar.TabIndex = 3;
            this.btn_Buscar.Text = "Buscar Por Estadia";
            this.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // lbl_idHabitacion
            // 
            this.lbl_idHabitacion.AutoSize = true;
            this.lbl_idHabitacion.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idHabitacion.Location = new System.Drawing.Point(358, 184);
            this.lbl_idHabitacion.Name = "lbl_idHabitacion";
            this.lbl_idHabitacion.Size = new System.Drawing.Size(100, 16);
            this.lbl_idHabitacion.TabIndex = 6;
            this.lbl_idHabitacion.Text = "Num Habitacion";
            // 
            // lbl_idhuesped
            // 
            this.lbl_idhuesped.AutoSize = true;
            this.lbl_idhuesped.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idhuesped.Location = new System.Drawing.Point(641, 183);
            this.lbl_idhuesped.Name = "lbl_idhuesped";
            this.lbl_idhuesped.Size = new System.Drawing.Size(75, 16);
            this.lbl_idhuesped.TabIndex = 8;
            this.lbl_idhuesped.Text = "Id Huesped";
            // 
            // txt_Num_Huespedes
            // 
            this.txt_Num_Huespedes.Location = new System.Drawing.Point(225, 241);
            this.txt_Num_Huespedes.MaxLength = 2;
            this.txt_Num_Huespedes.Name = "txt_Num_Huespedes";
            this.txt_Num_Huespedes.Size = new System.Drawing.Size(170, 20);
            this.txt_Num_Huespedes.TabIndex = 11;
            // 
            // lbl_Num_Huespedes
            // 
            this.lbl_Num_Huespedes.AutoSize = true;
            this.lbl_Num_Huespedes.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Num_Huespedes.Location = new System.Drawing.Point(79, 242);
            this.lbl_Num_Huespedes.Name = "lbl_Num_Huespedes";
            this.lbl_Num_Huespedes.Size = new System.Drawing.Size(140, 16);
            this.lbl_Num_Huespedes.TabIndex = 10;
            this.lbl_Num_Huespedes.Text = "Numero de Huespedes";
            // 
            // lbl_fecha_check_In
            // 
            this.lbl_fecha_check_In.AutoSize = true;
            this.lbl_fecha_check_In.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_check_In.Location = new System.Drawing.Point(79, 324);
            this.lbl_fecha_check_In.Name = "lbl_fecha_check_In";
            this.lbl_fecha_check_In.Size = new System.Drawing.Size(119, 16);
            this.lbl_fecha_check_In.TabIndex = 12;
            this.lbl_fecha_check_In.Text = "Fecha De Check-In";
            // 
            // DTP_Check_in
            // 
            this.DTP_Check_in.Location = new System.Drawing.Point(204, 324);
            this.DTP_Check_in.Name = "DTP_Check_in";
            this.DTP_Check_in.Size = new System.Drawing.Size(200, 20);
            this.DTP_Check_in.TabIndex = 13;
            // 
            // lbl_Fecha_actual
            // 
            this.lbl_Fecha_actual.AutoSize = true;
            this.lbl_Fecha_actual.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fecha_actual.Location = new System.Drawing.Point(485, 328);
            this.lbl_Fecha_actual.Name = "lbl_Fecha_actual";
            this.lbl_Fecha_actual.Size = new System.Drawing.Size(102, 16);
            this.lbl_Fecha_actual.TabIndex = 14;
            this.lbl_Fecha_actual.Text = "Fecha De Actual";
            // 
            // DTP_CheckOut
            // 
            this.DTP_CheckOut.Location = new System.Drawing.Point(593, 328);
            this.DTP_CheckOut.Name = "DTP_CheckOut";
            this.DTP_CheckOut.Size = new System.Drawing.Size(200, 20);
            this.DTP_CheckOut.TabIndex = 15;
            // 
            // lbl_Reservacion
            // 
            this.lbl_Reservacion.AutoSize = true;
            this.lbl_Reservacion.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Reservacion.Location = new System.Drawing.Point(491, 241);
            this.lbl_Reservacion.Name = "lbl_Reservacion";
            this.lbl_Reservacion.Size = new System.Drawing.Size(113, 16);
            this.lbl_Reservacion.TabIndex = 16;
            this.lbl_Reservacion.Text = "Tiene Reservación";
            // 
            // Chk_TieneReservación
            // 
            this.Chk_TieneReservación.AutoSize = true;
            this.Chk_TieneReservación.Enabled = false;
            this.Chk_TieneReservación.Location = new System.Drawing.Point(616, 242);
            this.Chk_TieneReservación.Name = "Chk_TieneReservación";
            this.Chk_TieneReservación.Size = new System.Drawing.Size(15, 14);
            this.Chk_TieneReservación.TabIndex = 17;
            this.Chk_TieneReservación.UseVisualStyleBackColor = true;
            // 
            // lbl_Monto_Total
            // 
            this.lbl_Monto_Total.AutoSize = true;
            this.lbl_Monto_Total.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Monto_Total.Location = new System.Drawing.Point(78, 402);
            this.lbl_Monto_Total.Name = "lbl_Monto_Total";
            this.lbl_Monto_Total.Size = new System.Drawing.Size(161, 16);
            this.lbl_Monto_Total.TabIndex = 18;
            this.lbl_Monto_Total.Text = "MONTO TOTAL DE PAGO:";
            // 
            // lbl_montoTotal
            // 
            this.lbl_montoTotal.AutoSize = true;
            this.lbl_montoTotal.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_montoTotal.Location = new System.Drawing.Point(264, 402);
            this.lbl_montoTotal.Name = "lbl_montoTotal";
            this.lbl_montoTotal.Size = new System.Drawing.Size(33, 16);
            this.lbl_montoTotal.TabIndex = 19;
            this.lbl_montoTotal.Text = "-----";
            // 
            // btn_Reportes
            // 
            this.btn_Reportes.Image = ((System.Drawing.Image)(resources.GetObject("btn_Reportes.Image")));
            this.btn_Reportes.Location = new System.Drawing.Point(532, 12);
            this.btn_Reportes.Name = "btn_Reportes";
            this.btn_Reportes.Size = new System.Drawing.Size(87, 85);
            this.btn_Reportes.TabIndex = 20;
            this.btn_Reportes.Text = "Reporte";
            this.btn_Reportes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Reportes.UseVisualStyleBackColor = true;
            this.btn_Reportes.Click += new System.EventHandler(this.btn_Reportes_Click_1);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.Location = new System.Drawing.Point(815, 12);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(87, 85);
            this.btn_guardar.TabIndex = 21;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Image = ((System.Drawing.Image)(resources.GetObject("btn_modificar.Image")));
            this.btn_modificar.Location = new System.Drawing.Point(908, 12);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(87, 85);
            this.btn_modificar.TabIndex = 22;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.Image")));
            this.btn_eliminar.Location = new System.Drawing.Point(719, 12);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(87, 85);
            this.btn_eliminar.TabIndex = 23;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // cbo_fk_id_Habitacion
            // 
            this.cbo_fk_id_Habitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_fk_id_Habitacion.FormattingEnabled = true;
            this.cbo_fk_id_Habitacion.Location = new System.Drawing.Point(461, 182);
            this.cbo_fk_id_Habitacion.Name = "cbo_fk_id_Habitacion";
            this.cbo_fk_id_Habitacion.Size = new System.Drawing.Size(170, 21);
            this.cbo_fk_id_Habitacion.TabIndex = 26;
            // 
            // cbo_Fk_Id_Huesped
            // 
            this.cbo_Fk_Id_Huesped.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Fk_Id_Huesped.FormattingEnabled = true;
            this.cbo_Fk_Id_Huesped.Location = new System.Drawing.Point(722, 183);
            this.cbo_Fk_Id_Huesped.Name = "cbo_Fk_Id_Huesped";
            this.cbo_Fk_Id_Huesped.Size = new System.Drawing.Size(170, 21);
            this.cbo_Fk_Id_Huesped.TabIndex = 27;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Image = ((System.Drawing.Image)(resources.GetObject("btn_limpiar.Image")));
            this.btn_limpiar.Location = new System.Drawing.Point(626, 12);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(87, 85);
            this.btn_limpiar.TabIndex = 28;
            this.btn_limpiar.Text = "Refrescar";
            this.btn_limpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // lbl_Precio_Unitario
            // 
            this.lbl_Precio_Unitario.AutoSize = true;
            this.lbl_Precio_Unitario.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Precio_Unitario.Location = new System.Drawing.Point(265, 377);
            this.lbl_Precio_Unitario.Name = "lbl_Precio_Unitario";
            this.lbl_Precio_Unitario.Size = new System.Drawing.Size(33, 16);
            this.lbl_Precio_Unitario.TabIndex = 30;
            this.lbl_Precio_Unitario.Text = "-----";
            // 
            // lbl_monto_noche
            // 
            this.lbl_monto_noche.AutoSize = true;
            this.lbl_monto_noche.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_monto_noche.Location = new System.Drawing.Point(79, 377);
            this.lbl_monto_noche.Name = "lbl_monto_noche";
            this.lbl_monto_noche.Size = new System.Drawing.Size(136, 16);
            this.lbl_monto_noche.TabIndex = 29;
            this.lbl_monto_noche.Text = "MONTO POR NOCHE:";
            // 
            // Cbo_PK_Id_Estadia
            // 
            this.Cbo_PK_Id_Estadia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_PK_Id_Estadia.FormattingEnabled = true;
            this.Cbo_PK_Id_Estadia.Location = new System.Drawing.Point(151, 182);
            this.Cbo_PK_Id_Estadia.Name = "Cbo_PK_Id_Estadia";
            this.Cbo_PK_Id_Estadia.Size = new System.Drawing.Size(170, 21);
            this.Cbo_PK_Id_Estadia.TabIndex = 31;
            // 
            // lbl_maxima_capacidad
            // 
            this.lbl_maxima_capacidad.AutoSize = true;
            this.lbl_maxima_capacidad.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maxima_capacidad.Location = new System.Drawing.Point(148, 275);
            this.lbl_maxima_capacidad.Name = "lbl_maxima_capacidad";
            this.lbl_maxima_capacidad.Size = new System.Drawing.Size(33, 16);
            this.lbl_maxima_capacidad.TabIndex = 33;
            this.lbl_maxima_capacidad.Text = "-----";
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cerrar.Image")));
            this.btn_Cerrar.Location = new System.Drawing.Point(1001, 12);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(87, 85);
            this.btn_Cerrar.TabIndex = 34;
            this.btn_Cerrar.Text = "Salir";
            this.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Titulo.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(12, 25);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(277, 25);
            this.lbl_Titulo.TabIndex = 35;
            this.lbl_Titulo.Text = "ACTUALIZACIÓN ESTADÍA";
            // 
            // cbo_Reserva
            // 
            this.cbo_Reserva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Reserva.FormattingEnabled = true;
            this.cbo_Reserva.Location = new System.Drawing.Point(152, 124);
            this.cbo_Reserva.Name = "cbo_Reserva";
            this.cbo_Reserva.Size = new System.Drawing.Size(243, 21);
            this.cbo_Reserva.TabIndex = 37;
            // 
            // lbl_Reserva
            // 
            this.lbl_Reserva.AutoSize = true;
            this.lbl_Reserva.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Reserva.Location = new System.Drawing.Point(79, 124);
            this.lbl_Reserva.Name = "lbl_Reserva";
            this.lbl_Reserva.Size = new System.Drawing.Size(70, 16);
            this.lbl_Reserva.TabIndex = 36;
            this.lbl_Reserva.Text = "Id Reserva";
            // 
            // btn_buscar_reserva
            // 
            this.btn_buscar_reserva.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar_reserva.Image")));
            this.btn_buscar_reserva.Location = new System.Drawing.Point(346, 12);
            this.btn_buscar_reserva.Name = "btn_buscar_reserva";
            this.btn_buscar_reserva.Size = new System.Drawing.Size(87, 85);
            this.btn_buscar_reserva.TabIndex = 38;
            this.btn_buscar_reserva.Text = "Buscar Por Reserva";
            this.btn_buscar_reserva.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_buscar_reserva.UseVisualStyleBackColor = true;
            this.btn_buscar_reserva.Click += new System.EventHandler(this.btn_buscar_reserva_Click);
            // 
            // Frm_Estadia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 484);
            this.Controls.Add(this.btn_buscar_reserva);
            this.Controls.Add(this.cbo_Reserva);
            this.Controls.Add(this.lbl_Reserva);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.lbl_maxima_capacidad);
            this.Controls.Add(this.Cbo_PK_Id_Estadia);
            this.Controls.Add(this.lbl_Precio_Unitario);
            this.Controls.Add(this.lbl_monto_noche);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.cbo_Fk_Id_Huesped);
            this.Controls.Add(this.cbo_fk_id_Habitacion);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_Reportes);
            this.Controls.Add(this.lbl_montoTotal);
            this.Controls.Add(this.lbl_Monto_Total);
            this.Controls.Add(this.Chk_TieneReservación);
            this.Controls.Add(this.lbl_Reservacion);
            this.Controls.Add(this.DTP_CheckOut);
            this.Controls.Add(this.lbl_Fecha_actual);
            this.Controls.Add(this.DTP_Check_in);
            this.Controls.Add(this.lbl_fecha_check_In);
            this.Controls.Add(this.txt_Num_Huespedes);
            this.Controls.Add(this.lbl_Num_Huespedes);
            this.Controls.Add(this.lbl_idhuesped);
            this.Controls.Add(this.lbl_idHabitacion);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.lbl_idestadia);
            this.Name = "Frm_Estadia";
            this.Text = "Frm_Estadia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_idestadia;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Label lbl_idHabitacion;
        private System.Windows.Forms.Label lbl_idhuesped;
        private System.Windows.Forms.TextBox txt_Num_Huespedes;
        private System.Windows.Forms.Label lbl_Num_Huespedes;
        private System.Windows.Forms.Label lbl_fecha_check_In;
        private System.Windows.Forms.DateTimePicker DTP_Check_in;
        private System.Windows.Forms.Label lbl_Fecha_actual;
        private System.Windows.Forms.DateTimePicker DTP_CheckOut;
        private System.Windows.Forms.Label lbl_Reservacion;
        private System.Windows.Forms.CheckBox Chk_TieneReservación;
        private System.Windows.Forms.Label lbl_Monto_Total;
        private System.Windows.Forms.Label lbl_montoTotal;
        private System.Windows.Forms.Button btn_Reportes;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.ComboBox cbo_fk_id_Habitacion;
        private System.Windows.Forms.ComboBox cbo_Fk_Id_Huesped;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Label lbl_Precio_Unitario;
        private System.Windows.Forms.Label lbl_monto_noche;
        private System.Windows.Forms.ComboBox Cbo_PK_Id_Estadia;
        private System.Windows.Forms.Label lbl_maxima_capacidad;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.ComboBox cbo_Reserva;
        private System.Windows.Forms.Label lbl_Reserva;
        private System.Windows.Forms.Button btn_buscar_reserva;
    }
}