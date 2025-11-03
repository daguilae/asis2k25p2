
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.txt_pk_id_estadia = new System.Windows.Forms.TextBox();
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
            this.btn_salir = new System.Windows.Forms.PictureBox();
            this.txt_Id_Habitacion = new System.Windows.Forms.TextBox();
            this.txt_ID_Huesped = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(142)))), ((int)(((byte)(181)))));
            this.panel1.Controls.Add(this.btn_salir);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1177, 36);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "MODULO HOTELERIA - Mantenimiento Estadia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id Estadia";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Buscar.Image")));
            this.btn_Buscar.Location = new System.Drawing.Point(912, 47);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(87, 85);
            this.btn_Buscar.TabIndex = 3;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // txt_pk_id_estadia
            // 
            this.txt_pk_id_estadia.Location = new System.Drawing.Point(116, 81);
            this.txt_pk_id_estadia.Name = "txt_pk_id_estadia";
            this.txt_pk_id_estadia.Size = new System.Drawing.Size(170, 20);
            this.txt_pk_id_estadia.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(304, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Id Habitacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(587, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Id Huesped";
            // 
            // txt_Num_Huespedes
            // 
            this.txt_Num_Huespedes.Location = new System.Drawing.Point(171, 139);
            this.txt_Num_Huespedes.Name = "txt_Num_Huespedes";
            this.txt_Num_Huespedes.Size = new System.Drawing.Size(170, 20);
            this.txt_Num_Huespedes.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Numero de Huespedes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fecha De Check-In";
            // 
            // DTP_Check_in
            // 
            this.DTP_Check_in.Location = new System.Drawing.Point(150, 205);
            this.DTP_Check_in.Name = "DTP_Check_in";
            this.DTP_Check_in.Size = new System.Drawing.Size(200, 20);
            this.DTP_Check_in.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(431, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fecha De Actual";
            // 
            // DTP_CheckOut
            // 
            this.DTP_CheckOut.Location = new System.Drawing.Point(539, 209);
            this.DTP_CheckOut.Name = "DTP_CheckOut";
            this.DTP_CheckOut.Size = new System.Drawing.Size(200, 20);
            this.DTP_CheckOut.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(437, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tiene Reservación";
            // 
            // Chk_TieneReservación
            // 
            this.Chk_TieneReservación.AutoSize = true;
            this.Chk_TieneReservación.Location = new System.Drawing.Point(562, 140);
            this.Chk_TieneReservación.Name = "Chk_TieneReservación";
            this.Chk_TieneReservación.Size = new System.Drawing.Size(15, 14);
            this.Chk_TieneReservación.TabIndex = 17;
            this.Chk_TieneReservación.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "MONTO TOTAL DE PAGO:";
            // 
            // lbl_montoTotal
            // 
            this.lbl_montoTotal.AutoSize = true;
            this.lbl_montoTotal.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_montoTotal.Location = new System.Drawing.Point(211, 277);
            this.lbl_montoTotal.Name = "lbl_montoTotal";
            this.lbl_montoTotal.Size = new System.Drawing.Size(33, 16);
            this.lbl_montoTotal.TabIndex = 19;
            this.lbl_montoTotal.Text = "-----";
            // 
            // btn_Reportes
            // 
            this.btn_Reportes.Image = ((System.Drawing.Image)(resources.GetObject("btn_Reportes.Image")));
            this.btn_Reportes.Location = new System.Drawing.Point(1005, 47);
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
            this.btn_guardar.Location = new System.Drawing.Point(28, 324);
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
            this.btn_modificar.Location = new System.Drawing.Point(135, 324);
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
            this.btn_eliminar.Location = new System.Drawing.Point(245, 325);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(87, 85);
            this.btn_eliminar.TabIndex = 23;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_salir.BackgroundImage")));
            this.btn_salir.Location = new System.Drawing.Point(1115, 2);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(31, 32);
            this.btn_salir.TabIndex = 24;
            this.btn_salir.TabStop = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // txt_Id_Habitacion
            // 
            this.txt_Id_Habitacion.Location = new System.Drawing.Point(395, 82);
            this.txt_Id_Habitacion.Name = "txt_Id_Habitacion";
            this.txt_Id_Habitacion.Size = new System.Drawing.Size(170, 20);
            this.txt_Id_Habitacion.TabIndex = 24;
            // 
            // txt_ID_Huesped
            // 
            this.txt_ID_Huesped.Location = new System.Drawing.Point(668, 82);
            this.txt_ID_Huesped.Name = "txt_ID_Huesped";
            this.txt_ID_Huesped.Size = new System.Drawing.Size(170, 20);
            this.txt_ID_Huesped.TabIndex = 25;
            // 
            // Frm_Estadia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 446);
            this.Controls.Add(this.txt_ID_Huesped);
            this.Controls.Add(this.txt_Id_Habitacion);
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
            this.Controls.Add(this.txt_pk_id_estadia);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Estadia";
            this.Text = "Frm_Estadia";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox txt_pk_id_estadia;
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
        private System.Windows.Forms.PictureBox btn_salir;
        private System.Windows.Forms.TextBox txt_Id_Habitacion;
        private System.Windows.Forms.TextBox txt_ID_Huesped;
    }
}