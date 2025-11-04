
namespace Capa_Vista_Reservas_Hotel
{
    partial class Frm_Pago_Tarjeta
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
            this.Gbo_Pago_Con_Tarjeta = new System.Windows.Forms.GroupBox();
            this.Lbl_Pago_Con_Tarjeta = new System.Windows.Forms.Label();
            this.Gbo_Cmpos = new System.Windows.Forms.GroupBox();
            this.Txt_Cvc = new System.Windows.Forms.TextBox();
            this.Txt_Fecha_Vencimiento = new System.Windows.Forms.TextBox();
            this.Txt_Numero_Tarjeta = new System.Windows.Forms.TextBox();
            this.Txt_Nombre_Titular = new System.Windows.Forms.TextBox();
            this.Lbl_Cvc = new System.Windows.Forms.Label();
            this.Lbl_Codigo_Postal = new System.Windows.Forms.Label();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.Lbl_MetodoPago = new System.Windows.Forms.Label();
            this.Lbl_Nombre_Titular = new System.Windows.Forms.Label();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.Txt_Codigo_Postal = new System.Windows.Forms.TextBox();
            this.Gbo_Pago_Con_Tarjeta.SuspendLayout();
            this.Gbo_Cmpos.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gbo_Pago_Con_Tarjeta
            // 
            this.Gbo_Pago_Con_Tarjeta.Controls.Add(this.Lbl_Pago_Con_Tarjeta);
            this.Gbo_Pago_Con_Tarjeta.Location = new System.Drawing.Point(12, 24);
            this.Gbo_Pago_Con_Tarjeta.Name = "Gbo_Pago_Con_Tarjeta";
            this.Gbo_Pago_Con_Tarjeta.Size = new System.Drawing.Size(699, 104);
            this.Gbo_Pago_Con_Tarjeta.TabIndex = 115;
            this.Gbo_Pago_Con_Tarjeta.TabStop = false;
            // 
            // Lbl_Pago_Con_Tarjeta
            // 
            this.Lbl_Pago_Con_Tarjeta.AutoSize = true;
            this.Lbl_Pago_Con_Tarjeta.Font = new System.Drawing.Font("Rockwell", 18F);
            this.Lbl_Pago_Con_Tarjeta.Location = new System.Drawing.Point(32, 21);
            this.Lbl_Pago_Con_Tarjeta.Name = "Lbl_Pago_Con_Tarjeta";
            this.Lbl_Pago_Con_Tarjeta.Size = new System.Drawing.Size(253, 35);
            this.Lbl_Pago_Con_Tarjeta.TabIndex = 112;
            this.Lbl_Pago_Con_Tarjeta.Text = "Pagos con tarjeta";
            // 
            // Gbo_Cmpos
            // 
            this.Gbo_Cmpos.Controls.Add(this.Txt_Codigo_Postal);
            this.Gbo_Cmpos.Controls.Add(this.Txt_Cvc);
            this.Gbo_Cmpos.Controls.Add(this.Txt_Fecha_Vencimiento);
            this.Gbo_Cmpos.Controls.Add(this.Txt_Numero_Tarjeta);
            this.Gbo_Cmpos.Controls.Add(this.Txt_Nombre_Titular);
            this.Gbo_Cmpos.Controls.Add(this.Lbl_Cvc);
            this.Gbo_Cmpos.Controls.Add(this.Lbl_Codigo_Postal);
            this.Gbo_Cmpos.Controls.Add(this.Lbl_Fecha);
            this.Gbo_Cmpos.Controls.Add(this.Lbl_MetodoPago);
            this.Gbo_Cmpos.Controls.Add(this.Lbl_Nombre_Titular);
            this.Gbo_Cmpos.Location = new System.Drawing.Point(12, 144);
            this.Gbo_Cmpos.Name = "Gbo_Cmpos";
            this.Gbo_Cmpos.Size = new System.Drawing.Size(1144, 341);
            this.Gbo_Cmpos.TabIndex = 121;
            this.Gbo_Cmpos.TabStop = false;
            // 
            // Txt_Cvc
            // 
            this.Txt_Cvc.Location = new System.Drawing.Point(647, 29);
            this.Txt_Cvc.Name = "Txt_Cvc";
            this.Txt_Cvc.Size = new System.Drawing.Size(107, 22);
            this.Txt_Cvc.TabIndex = 30;
            this.Txt_Cvc.TextChanged += new System.EventHandler(this.Txt_Cvc_TextChanged);
            // 
            // Txt_Fecha_Vencimiento
            // 
            this.Txt_Fecha_Vencimiento.Location = new System.Drawing.Point(250, 158);
            this.Txt_Fecha_Vencimiento.Name = "Txt_Fecha_Vencimiento";
            this.Txt_Fecha_Vencimiento.Size = new System.Drawing.Size(265, 22);
            this.Txt_Fecha_Vencimiento.TabIndex = 29;
            this.Txt_Fecha_Vencimiento.TextChanged += new System.EventHandler(this.Txt_Fecha_Vencimiento_TextChanged);
            // 
            // Txt_Numero_Tarjeta
            // 
            this.Txt_Numero_Tarjeta.Location = new System.Drawing.Point(235, 89);
            this.Txt_Numero_Tarjeta.Name = "Txt_Numero_Tarjeta";
            this.Txt_Numero_Tarjeta.Size = new System.Drawing.Size(280, 22);
            this.Txt_Numero_Tarjeta.TabIndex = 28;
            this.Txt_Numero_Tarjeta.TextChanged += new System.EventHandler(this.Txt_Numero_Tarjeta_TextChanged);
            // 
            // Txt_Nombre_Titular
            // 
            this.Txt_Nombre_Titular.Location = new System.Drawing.Point(235, 28);
            this.Txt_Nombre_Titular.Name = "Txt_Nombre_Titular";
            this.Txt_Nombre_Titular.Size = new System.Drawing.Size(280, 22);
            this.Txt_Nombre_Titular.TabIndex = 27;
            this.Txt_Nombre_Titular.TextChanged += new System.EventHandler(this.Txt_Nombre_Titular_TextChanged);
            // 
            // Lbl_Cvc
            // 
            this.Lbl_Cvc.AutoSize = true;
            this.Lbl_Cvc.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cvc.Location = new System.Drawing.Point(575, 29);
            this.Lbl_Cvc.Name = "Lbl_Cvc";
            this.Lbl_Cvc.Size = new System.Drawing.Size(50, 21);
            this.Lbl_Cvc.TabIndex = 21;
            this.Lbl_Cvc.Text = "Cvc:";
            // 
            // Lbl_Codigo_Postal
            // 
            this.Lbl_Codigo_Postal.AutoSize = true;
            this.Lbl_Codigo_Postal.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Codigo_Postal.Location = new System.Drawing.Point(575, 89);
            this.Lbl_Codigo_Postal.Name = "Lbl_Codigo_Postal";
            this.Lbl_Codigo_Postal.Size = new System.Drawing.Size(141, 21);
            this.Lbl_Codigo_Postal.TabIndex = 20;
            this.Lbl_Codigo_Postal.Text = "Código postal:";
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha.Location = new System.Drawing.Point(34, 159);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(210, 21);
            this.Lbl_Fecha.TabIndex = 18;
            this.Lbl_Fecha.Text = "Fecha de vencimiento:";
            // 
            // Lbl_MetodoPago
            // 
            this.Lbl_MetodoPago.AutoSize = true;
            this.Lbl_MetodoPago.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_MetodoPago.Location = new System.Drawing.Point(31, 89);
            this.Lbl_MetodoPago.Name = "Lbl_MetodoPago";
            this.Lbl_MetodoPago.Size = new System.Drawing.Size(177, 21);
            this.Lbl_MetodoPago.TabIndex = 17;
            this.Lbl_MetodoPago.Text = "Número de tarjeta:";
            // 
            // Lbl_Nombre_Titular
            // 
            this.Lbl_Nombre_Titular.AutoSize = true;
            this.Lbl_Nombre_Titular.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nombre_Titular.Location = new System.Drawing.Point(31, 28);
            this.Lbl_Nombre_Titular.Name = "Lbl_Nombre_Titular";
            this.Lbl_Nombre_Titular.Size = new System.Drawing.Size(180, 21);
            this.Lbl_Nombre_Titular.TabIndex = 16;
            this.Lbl_Nombre_Titular.Text = "Nombre del titular:";
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Limpiar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Limpiar.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Limpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Limpiar.Image = global::Capa_Vista_Reservas_Hotel.Properties.Resources.icono_limpiar__1_;
            this.Btn_Limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Limpiar.Location = new System.Drawing.Point(1083, 45);
            this.Btn_Limpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(55, 54);
            this.Btn_Limpiar.TabIndex = 119;
            this.Btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Limpiar.UseVisualStyleBackColor = false;
            this.Btn_Limpiar.Click += new System.EventHandler(this.Btn_Limpiar_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Modificar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Modificar.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Modificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Modificar.Image = global::Capa_Vista_Reservas_Hotel.Properties.Resources.icono_modificar;
            this.Btn_Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Modificar.Location = new System.Drawing.Point(1013, 45);
            this.Btn_Modificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(55, 54);
            this.Btn_Modificar.TabIndex = 118;
            this.Btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Modificar.UseVisualStyleBackColor = false;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Guardar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Guardar.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Guardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Guardar.Image = global::Capa_Vista_Reservas_Hotel.Properties.Resources.icono_guardar;
            this.Btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Guardar.Location = new System.Drawing.Point(942, 45);
            this.Btn_Guardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(55, 54);
            this.Btn_Guardar.TabIndex = 117;
            this.Btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Guardar.UseVisualStyleBackColor = false;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Nuevo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Nuevo.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Nuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Nuevo.Image = global::Capa_Vista_Reservas_Hotel.Properties.Resources.icono_agregar;
            this.Btn_Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Nuevo.Location = new System.Drawing.Point(881, 45);
            this.Btn_Nuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(55, 54);
            this.Btn_Nuevo.TabIndex = 116;
            this.Btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Nuevo.UseVisualStyleBackColor = false;
            this.Btn_Nuevo.Click += new System.EventHandler(this.Btn_Nuevo_Click);
            // 
            // Txt_Codigo_Postal
            // 
            this.Txt_Codigo_Postal.Location = new System.Drawing.Point(722, 88);
            this.Txt_Codigo_Postal.Name = "Txt_Codigo_Postal";
            this.Txt_Codigo_Postal.Size = new System.Drawing.Size(169, 22);
            this.Txt_Codigo_Postal.TabIndex = 31;
            this.Txt_Codigo_Postal.TextChanged += new System.EventHandler(this.Txt_Codigo_Postal_TextChanged);
            // 
            // Frm_Pago_Tarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1183, 497);
            this.Controls.Add(this.Gbo_Cmpos);
            this.Controls.Add(this.Btn_Limpiar);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Btn_Nuevo);
            this.Controls.Add(this.Gbo_Pago_Con_Tarjeta);
            this.Name = "Frm_Pago_Tarjeta";
            this.Text = "Frm_Pago_Tarjeta";
            this.Gbo_Pago_Con_Tarjeta.ResumeLayout(false);
            this.Gbo_Pago_Con_Tarjeta.PerformLayout();
            this.Gbo_Cmpos.ResumeLayout(false);
            this.Gbo_Cmpos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gbo_Pago_Con_Tarjeta;
        private System.Windows.Forms.Label Lbl_Pago_Con_Tarjeta;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Limpiar;
        private System.Windows.Forms.GroupBox Gbo_Cmpos;
        private System.Windows.Forms.TextBox Txt_Cvc;
        private System.Windows.Forms.TextBox Txt_Fecha_Vencimiento;
        private System.Windows.Forms.TextBox Txt_Numero_Tarjeta;
        private System.Windows.Forms.TextBox Txt_Nombre_Titular;
        private System.Windows.Forms.Label Lbl_Cvc;
        private System.Windows.Forms.Label Lbl_Codigo_Postal;
        private System.Windows.Forms.Label Lbl_Fecha;
        private System.Windows.Forms.Label Lbl_MetodoPago;
        private System.Windows.Forms.Label Lbl_Nombre_Titular;
        private System.Windows.Forms.TextBox Txt_Codigo_Postal;
    }
}