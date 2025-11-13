
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
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Num_Huespedes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DTP_Check_in = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.DTP_CheckOut = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.Chk_TieneReservación = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_montoTotal = new System.Windows.Forms.Label();
            this.btn_Reportes = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.cbo_fk_id_Habitacion = new System.Windows.Forms.ComboBox();
            this.cbo_Fk_Id_Huesped = new System.Windows.Forms.ComboBox();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.lbl_Precio_Unitario = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Cbo_PK_Id_Estadia = new System.Windows.Forms.ComboBox();
            this.lbl_maxima_capacidad = new System.Windows.Forms.Label();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id Estadia";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Buscar.Image")));
            this.btn_Buscar.Location = new System.Drawing.Point(439, 12);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(87, 85);
            this.btn_Buscar.TabIndex = 3;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(352, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Num Habitacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(635, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Id Huesped";
            // 
            // txt_Num_Huespedes
            // 
            this.txt_Num_Huespedes.Location = new System.Drawing.Point(219, 172);
            this.txt_Num_Huespedes.MaxLength = 2;
            this.txt_Num_Huespedes.Name = "txt_Num_Huespedes";
            this.txt_Num_Huespedes.Size = new System.Drawing.Size(170, 20);
            this.txt_Num_Huespedes.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Numero de Huespedes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(73, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fecha De Check-In";
            // 
            // DTP_Check_in
            // 
            this.DTP_Check_in.Location = new System.Drawing.Point(198, 255);
            this.DTP_Check_in.Name = "DTP_Check_in";
            this.DTP_Check_in.Size = new System.Drawing.Size(200, 20);
            this.DTP_Check_in.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(479, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fecha De Actual";
            // 
            // DTP_CheckOut
            // 
            this.DTP_CheckOut.Location = new System.Drawing.Point(587, 259);
            this.DTP_CheckOut.Name = "DTP_CheckOut";
            this.DTP_CheckOut.Size = new System.Drawing.Size(200, 20);
            this.DTP_CheckOut.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(485, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tiene Reservación";
            // 
            // Chk_TieneReservación
            // 
            this.Chk_TieneReservación.AutoSize = true;
            this.Chk_TieneReservación.Location = new System.Drawing.Point(610, 173);
            this.Chk_TieneReservación.Name = "Chk_TieneReservación";
            this.Chk_TieneReservación.Size = new System.Drawing.Size(15, 14);
            this.Chk_TieneReservación.TabIndex = 17;
            this.Chk_TieneReservación.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(72, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "MONTO TOTAL DE PAGO:";
            // 
            // lbl_montoTotal
            // 
            this.lbl_montoTotal.AutoSize = true;
            this.lbl_montoTotal.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_montoTotal.Location = new System.Drawing.Point(258, 333);
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
            this.cbo_fk_id_Habitacion.Location = new System.Drawing.Point(455, 113);
            this.cbo_fk_id_Habitacion.Name = "cbo_fk_id_Habitacion";
            this.cbo_fk_id_Habitacion.Size = new System.Drawing.Size(170, 21);
            this.cbo_fk_id_Habitacion.TabIndex = 26;
            // 
            // cbo_Fk_Id_Huesped
            // 
            this.cbo_Fk_Id_Huesped.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Fk_Id_Huesped.FormattingEnabled = true;
            this.cbo_Fk_Id_Huesped.Location = new System.Drawing.Point(716, 114);
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
            this.lbl_Precio_Unitario.Location = new System.Drawing.Point(259, 308);
            this.lbl_Precio_Unitario.Name = "lbl_Precio_Unitario";
            this.lbl_Precio_Unitario.Size = new System.Drawing.Size(33, 16);
            this.lbl_Precio_Unitario.TabIndex = 30;
            this.lbl_Precio_Unitario.Text = "-----";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(73, 308);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 16);
            this.label11.TabIndex = 29;
            this.label11.Text = "MONTO POR NOCHE:";
            // 
            // Cbo_PK_Id_Estadia
            // 
            this.Cbo_PK_Id_Estadia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_PK_Id_Estadia.FormattingEnabled = true;
            this.Cbo_PK_Id_Estadia.Location = new System.Drawing.Point(145, 113);
            this.Cbo_PK_Id_Estadia.Name = "Cbo_PK_Id_Estadia";
            this.Cbo_PK_Id_Estadia.Size = new System.Drawing.Size(170, 21);
            this.Cbo_PK_Id_Estadia.TabIndex = 31;
            // 
            // lbl_maxima_capacidad
            // 
            this.lbl_maxima_capacidad.AutoSize = true;
            this.lbl_maxima_capacidad.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maxima_capacidad.Location = new System.Drawing.Point(142, 206);
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
            this.lbl_Titulo.Location = new System.Drawing.Point(76, 48);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(277, 25);
            this.lbl_Titulo.TabIndex = 35;
            this.lbl_Titulo.Text = "ACTUALIZACIÓN ESTADÍA";
            // 
            // Frm_Estadia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 376);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.lbl_maxima_capacidad);
            this.Controls.Add(this.Cbo_PK_Id_Estadia);
            this.Controls.Add(this.lbl_Precio_Unitario);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.cbo_Fk_Id_Huesped);
            this.Controls.Add(this.cbo_fk_id_Habitacion);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_Reportes);
            this.Controls.Add(this.lbl_montoTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Chk_TieneReservación);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DTP_CheckOut);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DTP_Check_in);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Num_Huespedes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.label2);
            this.Name = "Frm_Estadia";
            this.Text = "Frm_Estadia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Num_Huespedes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DTP_Check_in;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DTP_CheckOut;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox Chk_TieneReservación;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_montoTotal;
        private System.Windows.Forms.Button btn_Reportes;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.ComboBox cbo_fk_id_Habitacion;
        private System.Windows.Forms.ComboBox cbo_Fk_Id_Huesped;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Label lbl_Precio_Unitario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox Cbo_PK_Id_Estadia;
        private System.Windows.Forms.Label lbl_maxima_capacidad;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Label lbl_Titulo;
    }
}