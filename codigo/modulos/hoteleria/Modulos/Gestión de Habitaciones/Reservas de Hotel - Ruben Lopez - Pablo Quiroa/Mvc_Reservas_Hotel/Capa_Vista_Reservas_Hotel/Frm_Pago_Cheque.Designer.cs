
namespace Capa_Vista_Reservas_Hotel
{
    partial class Frm_Pago_Cheque
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
            this.Gbo_Pago_Con_Cheque = new System.Windows.Forms.GroupBox();
            this.Lbl_Pago_Con_Cheque = new System.Windows.Forms.Label();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.Gbo_Cmpos = new System.Windows.Forms.GroupBox();
            this.Cbo_Estado_Cheque = new System.Windows.Forms.ComboBox();
            this.Dtp_Fecha_Cobro = new System.Windows.Forms.DateTimePicker();
            this.Dtp_Fecha_Emision = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Estado_Cheque = new System.Windows.Forms.Label();
            this.Lbl_Fecha_Cobro = new System.Windows.Forms.Label();
            this.Lbl_Fecha_Emision = new System.Windows.Forms.Label();
            this.Txt_Nombre_Titular = new System.Windows.Forms.TextBox();
            this.Lbl_Nombre_Titular = new System.Windows.Forms.Label();
            this.Txt_Banco_Emisor = new System.Windows.Forms.TextBox();
            this.Txt_Numero_Cheque = new System.Windows.Forms.TextBox();
            this.Lbl_Banco_Emisor = new System.Windows.Forms.Label();
            this.Lbl_Numero_Cheque = new System.Windows.Forms.Label();
            this.Gbo_Pago_Con_Cheque.SuspendLayout();
            this.Gbo_Cmpos.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gbo_Pago_Con_Cheque
            // 
            this.Gbo_Pago_Con_Cheque.Controls.Add(this.Lbl_Pago_Con_Cheque);
            this.Gbo_Pago_Con_Cheque.Location = new System.Drawing.Point(12, 27);
            this.Gbo_Pago_Con_Cheque.Name = "Gbo_Pago_Con_Cheque";
            this.Gbo_Pago_Con_Cheque.Size = new System.Drawing.Size(699, 104);
            this.Gbo_Pago_Con_Cheque.TabIndex = 118;
            this.Gbo_Pago_Con_Cheque.TabStop = false;
            // 
            // Lbl_Pago_Con_Cheque
            // 
            this.Lbl_Pago_Con_Cheque.AutoSize = true;
            this.Lbl_Pago_Con_Cheque.Font = new System.Drawing.Font("Rockwell", 18F);
            this.Lbl_Pago_Con_Cheque.Location = new System.Drawing.Point(32, 21);
            this.Lbl_Pago_Con_Cheque.Name = "Lbl_Pago_Con_Cheque";
            this.Lbl_Pago_Con_Cheque.Size = new System.Drawing.Size(266, 35);
            this.Lbl_Pago_Con_Cheque.TabIndex = 112;
            this.Lbl_Pago_Con_Cheque.Text = "Pagos con cheque";
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Nuevo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Nuevo.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Nuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Nuevo.Image = global::Capa_Vista_Reservas_Hotel.Properties.Resources.icono_agregar;
            this.Btn_Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Nuevo.Location = new System.Drawing.Point(821, 48);
            this.Btn_Nuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(55, 54);
            this.Btn_Nuevo.TabIndex = 125;
            this.Btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Nuevo.UseVisualStyleBackColor = false;
            this.Btn_Nuevo.Click += new System.EventHandler(this.Btn_Nuevo_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Guardar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Guardar.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Guardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Guardar.Image = global::Capa_Vista_Reservas_Hotel.Properties.Resources.icono_guardar;
            this.Btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Guardar.Location = new System.Drawing.Point(882, 48);
            this.Btn_Guardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(55, 54);
            this.Btn_Guardar.TabIndex = 126;
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
            this.Btn_Modificar.Location = new System.Drawing.Point(943, 48);
            this.Btn_Modificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(55, 54);
            this.Btn_Modificar.TabIndex = 127;
            this.Btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Modificar.UseVisualStyleBackColor = false;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Limpiar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Limpiar.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Limpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Limpiar.Image = global::Capa_Vista_Reservas_Hotel.Properties.Resources.icono_limpiar__1_;
            this.Btn_Limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Limpiar.Location = new System.Drawing.Point(1004, 48);
            this.Btn_Limpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(55, 54);
            this.Btn_Limpiar.TabIndex = 128;
            this.Btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Limpiar.UseVisualStyleBackColor = false;
            this.Btn_Limpiar.Click += new System.EventHandler(this.Btn_Limpiar_Click);
            // 
            // Gbo_Cmpos
            // 
            this.Gbo_Cmpos.Controls.Add(this.Cbo_Estado_Cheque);
            this.Gbo_Cmpos.Controls.Add(this.Dtp_Fecha_Cobro);
            this.Gbo_Cmpos.Controls.Add(this.Dtp_Fecha_Emision);
            this.Gbo_Cmpos.Controls.Add(this.Lbl_Estado_Cheque);
            this.Gbo_Cmpos.Controls.Add(this.Lbl_Fecha_Cobro);
            this.Gbo_Cmpos.Controls.Add(this.Lbl_Fecha_Emision);
            this.Gbo_Cmpos.Controls.Add(this.Txt_Nombre_Titular);
            this.Gbo_Cmpos.Controls.Add(this.Lbl_Nombre_Titular);
            this.Gbo_Cmpos.Controls.Add(this.Txt_Banco_Emisor);
            this.Gbo_Cmpos.Controls.Add(this.Txt_Numero_Cheque);
            this.Gbo_Cmpos.Controls.Add(this.Lbl_Banco_Emisor);
            this.Gbo_Cmpos.Controls.Add(this.Lbl_Numero_Cheque);
            this.Gbo_Cmpos.Location = new System.Drawing.Point(2, 137);
            this.Gbo_Cmpos.Name = "Gbo_Cmpos";
            this.Gbo_Cmpos.Size = new System.Drawing.Size(1161, 387);
            this.Gbo_Cmpos.TabIndex = 129;
            this.Gbo_Cmpos.TabStop = false;
            // 
            // Cbo_Estado_Cheque
            // 
            this.Cbo_Estado_Cheque.FormattingEnabled = true;
            this.Cbo_Estado_Cheque.Location = new System.Drawing.Point(715, 29);
            this.Cbo_Estado_Cheque.Name = "Cbo_Estado_Cheque";
            this.Cbo_Estado_Cheque.Size = new System.Drawing.Size(291, 24);
            this.Cbo_Estado_Cheque.TabIndex = 133;
            this.Cbo_Estado_Cheque.SelectedIndexChanged += new System.EventHandler(this.Cbo_Estado_Cheque_SelectedIndexChanged);
            // 
            // Dtp_Fecha_Cobro
            // 
            this.Dtp_Fecha_Cobro.Location = new System.Drawing.Point(201, 247);
            this.Dtp_Fecha_Cobro.Name = "Dtp_Fecha_Cobro";
            this.Dtp_Fecha_Cobro.Size = new System.Drawing.Size(291, 22);
            this.Dtp_Fecha_Cobro.TabIndex = 132;
            this.Dtp_Fecha_Cobro.ValueChanged += new System.EventHandler(this.Dtp_Fecha_Cobro_ValueChanged);
            // 
            // Dtp_Fecha_Emision
            // 
            this.Dtp_Fecha_Emision.Location = new System.Drawing.Point(201, 201);
            this.Dtp_Fecha_Emision.Name = "Dtp_Fecha_Emision";
            this.Dtp_Fecha_Emision.Size = new System.Drawing.Size(291, 22);
            this.Dtp_Fecha_Emision.TabIndex = 131;
            this.Dtp_Fecha_Emision.ValueChanged += new System.EventHandler(this.Dtp_Fecha_Emision_ValueChanged);
            // 
            // Lbl_Estado_Cheque
            // 
            this.Lbl_Estado_Cheque.AutoSize = true;
            this.Lbl_Estado_Cheque.Font = new System.Drawing.Font("Rockwell", 10.8F);
            this.Lbl_Estado_Cheque.Location = new System.Drawing.Point(562, 30);
            this.Lbl_Estado_Cheque.Name = "Lbl_Estado_Cheque";
            this.Lbl_Estado_Cheque.Size = new System.Drawing.Size(147, 21);
            this.Lbl_Estado_Cheque.TabIndex = 130;
            this.Lbl_Estado_Cheque.Text = "Estado cheque:";
            // 
            // Lbl_Fecha_Cobro
            // 
            this.Lbl_Fecha_Cobro.AutoSize = true;
            this.Lbl_Fecha_Cobro.Font = new System.Drawing.Font("Rockwell", 10.8F);
            this.Lbl_Fecha_Cobro.Location = new System.Drawing.Point(45, 247);
            this.Lbl_Fecha_Cobro.Name = "Lbl_Fecha_Cobro";
            this.Lbl_Fecha_Cobro.Size = new System.Drawing.Size(125, 21);
            this.Lbl_Fecha_Cobro.TabIndex = 32;
            this.Lbl_Fecha_Cobro.Text = "Fecha cobro:";
            // 
            // Lbl_Fecha_Emision
            // 
            this.Lbl_Fecha_Emision.AutoSize = true;
            this.Lbl_Fecha_Emision.Font = new System.Drawing.Font("Rockwell", 10.8F);
            this.Lbl_Fecha_Emision.Location = new System.Drawing.Point(45, 201);
            this.Lbl_Fecha_Emision.Name = "Lbl_Fecha_Emision";
            this.Lbl_Fecha_Emision.Size = new System.Drawing.Size(143, 21);
            this.Lbl_Fecha_Emision.TabIndex = 31;
            this.Lbl_Fecha_Emision.Text = "Fecha emisión:";
            // 
            // Txt_Nombre_Titular
            // 
            this.Txt_Nombre_Titular.Location = new System.Drawing.Point(201, 150);
            this.Txt_Nombre_Titular.Name = "Txt_Nombre_Titular";
            this.Txt_Nombre_Titular.Size = new System.Drawing.Size(291, 22);
            this.Txt_Nombre_Titular.TabIndex = 30;
            this.Txt_Nombre_Titular.TextChanged += new System.EventHandler(this.Txt_Nombre_Titular_TextChanged);
            // 
            // Lbl_Nombre_Titular
            // 
            this.Lbl_Nombre_Titular.AutoSize = true;
            this.Lbl_Nombre_Titular.Font = new System.Drawing.Font("Rockwell", 10.8F);
            this.Lbl_Nombre_Titular.Location = new System.Drawing.Point(44, 150);
            this.Lbl_Nombre_Titular.Name = "Lbl_Nombre_Titular";
            this.Lbl_Nombre_Titular.Size = new System.Drawing.Size(151, 21);
            this.Lbl_Nombre_Titular.TabIndex = 29;
            this.Lbl_Nombre_Titular.Text = "Nombre TItular:";
            // 
            // Txt_Banco_Emisor
            // 
            this.Txt_Banco_Emisor.Location = new System.Drawing.Point(185, 90);
            this.Txt_Banco_Emisor.Name = "Txt_Banco_Emisor";
            this.Txt_Banco_Emisor.Size = new System.Drawing.Size(305, 22);
            this.Txt_Banco_Emisor.TabIndex = 28;
            this.Txt_Banco_Emisor.TextChanged += new System.EventHandler(this.Txt_Banco_Emisor_TextChanged);
            // 
            // Txt_Numero_Cheque
            // 
            this.Txt_Numero_Cheque.Location = new System.Drawing.Point(212, 29);
            this.Txt_Numero_Cheque.Name = "Txt_Numero_Cheque";
            this.Txt_Numero_Cheque.Size = new System.Drawing.Size(280, 22);
            this.Txt_Numero_Cheque.TabIndex = 27;
            this.Txt_Numero_Cheque.TextChanged += new System.EventHandler(this.Txt_Numero_Cheque_TextChanged);
            // 
            // Lbl_Banco_Emisor
            // 
            this.Lbl_Banco_Emisor.AutoSize = true;
            this.Lbl_Banco_Emisor.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Banco_Emisor.Location = new System.Drawing.Point(44, 90);
            this.Lbl_Banco_Emisor.Name = "Lbl_Banco_Emisor";
            this.Lbl_Banco_Emisor.Size = new System.Drawing.Size(135, 21);
            this.Lbl_Banco_Emisor.TabIndex = 17;
            this.Lbl_Banco_Emisor.Text = "Banco emisor:";
            // 
            // Lbl_Numero_Cheque
            // 
            this.Lbl_Numero_Cheque.AutoSize = true;
            this.Lbl_Numero_Cheque.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Numero_Cheque.Location = new System.Drawing.Point(44, 29);
            this.Lbl_Numero_Cheque.Name = "Lbl_Numero_Cheque";
            this.Lbl_Numero_Cheque.Size = new System.Drawing.Size(162, 21);
            this.Lbl_Numero_Cheque.TabIndex = 16;
            this.Lbl_Numero_Cheque.Text = "Numero Cheque:";
            // 
            // Frm_Pago_Cheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1132, 536);
            this.Controls.Add(this.Gbo_Cmpos);
            this.Controls.Add(this.Btn_Limpiar);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Btn_Nuevo);
            this.Controls.Add(this.Gbo_Pago_Con_Cheque);
            this.Name = "Frm_Pago_Cheque";
            this.Text = "Frm_Pago_Cheque";
            this.Gbo_Pago_Con_Cheque.ResumeLayout(false);
            this.Gbo_Pago_Con_Cheque.PerformLayout();
            this.Gbo_Cmpos.ResumeLayout(false);
            this.Gbo_Cmpos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gbo_Pago_Con_Cheque;
        private System.Windows.Forms.Label Lbl_Pago_Con_Cheque;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Limpiar;
        private System.Windows.Forms.GroupBox Gbo_Cmpos;
        private System.Windows.Forms.Label Lbl_Fecha_Cobro;
        private System.Windows.Forms.Label Lbl_Fecha_Emision;
        private System.Windows.Forms.TextBox Txt_Nombre_Titular;
        private System.Windows.Forms.Label Lbl_Nombre_Titular;
        private System.Windows.Forms.TextBox Txt_Banco_Emisor;
        private System.Windows.Forms.TextBox Txt_Numero_Cheque;
        private System.Windows.Forms.Label Lbl_Banco_Emisor;
        private System.Windows.Forms.Label Lbl_Numero_Cheque;
        private System.Windows.Forms.Label Lbl_Estado_Cheque;
        private System.Windows.Forms.ComboBox Cbo_Estado_Cheque;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Cobro;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Emision;
    }
}