
namespace Capa_Vista_Reservas_Hotel
{
    partial class Frm_Pago_Transferencia
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
            this.Gbo_Pago_Con_Efectivo = new System.Windows.Forms.GroupBox();
            this.Lbl_Pago_Con_Transferencia = new System.Windows.Forms.Label();
            this.Gbo_Cmpos = new System.Windows.Forms.GroupBox();
            this.Txt_Banco_Origen = new System.Windows.Forms.TextBox();
            this.Txt_Numero_Transferencia = new System.Windows.Forms.TextBox();
            this.Lbl_Banco_Origen = new System.Windows.Forms.Label();
            this.Lbl_Numero_Transferencia = new System.Windows.Forms.Label();
            this.Lbl_Cuenta_Origen = new System.Windows.Forms.Label();
            this.Txt_Cuenta_Origen = new System.Windows.Forms.TextBox();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.Gbo_Pago_Con_Efectivo.SuspendLayout();
            this.Gbo_Cmpos.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gbo_Pago_Con_Efectivo
            // 
            this.Gbo_Pago_Con_Efectivo.Controls.Add(this.Lbl_Pago_Con_Transferencia);
            this.Gbo_Pago_Con_Efectivo.Location = new System.Drawing.Point(28, 31);
            this.Gbo_Pago_Con_Efectivo.Name = "Gbo_Pago_Con_Efectivo";
            this.Gbo_Pago_Con_Efectivo.Size = new System.Drawing.Size(699, 104);
            this.Gbo_Pago_Con_Efectivo.TabIndex = 117;
            this.Gbo_Pago_Con_Efectivo.TabStop = false;
            // 
            // Lbl_Pago_Con_Transferencia
            // 
            this.Lbl_Pago_Con_Transferencia.AutoSize = true;
            this.Lbl_Pago_Con_Transferencia.Font = new System.Drawing.Font("Rockwell", 18F);
            this.Lbl_Pago_Con_Transferencia.Location = new System.Drawing.Point(32, 21);
            this.Lbl_Pago_Con_Transferencia.Name = "Lbl_Pago_Con_Transferencia";
            this.Lbl_Pago_Con_Transferencia.Size = new System.Drawing.Size(347, 35);
            this.Lbl_Pago_Con_Transferencia.TabIndex = 112;
            this.Lbl_Pago_Con_Transferencia.Text = "Pagos con transferencia";
            // 
            // Gbo_Cmpos
            // 
            this.Gbo_Cmpos.Controls.Add(this.Txt_Cuenta_Origen);
            this.Gbo_Cmpos.Controls.Add(this.Lbl_Cuenta_Origen);
            this.Gbo_Cmpos.Controls.Add(this.Txt_Banco_Origen);
            this.Gbo_Cmpos.Controls.Add(this.Txt_Numero_Transferencia);
            this.Gbo_Cmpos.Controls.Add(this.Lbl_Banco_Origen);
            this.Gbo_Cmpos.Controls.Add(this.Lbl_Numero_Transferencia);
            this.Gbo_Cmpos.Location = new System.Drawing.Point(2, 141);
            this.Gbo_Cmpos.Name = "Gbo_Cmpos";
            this.Gbo_Cmpos.Size = new System.Drawing.Size(1161, 341);
            this.Gbo_Cmpos.TabIndex = 128;
            this.Gbo_Cmpos.TabStop = false;
            // 
            // Txt_Banco_Origen
            // 
            this.Txt_Banco_Origen.Location = new System.Drawing.Point(203, 90);
            this.Txt_Banco_Origen.Name = "Txt_Banco_Origen";
            this.Txt_Banco_Origen.Size = new System.Drawing.Size(357, 22);
            this.Txt_Banco_Origen.TabIndex = 28;
            this.Txt_Banco_Origen.TextChanged += new System.EventHandler(this.Txt_Banco_Origen_TextChanged);
            // 
            // Txt_Numero_Transferencia
            // 
            this.Txt_Numero_Transferencia.Location = new System.Drawing.Point(280, 29);
            this.Txt_Numero_Transferencia.Name = "Txt_Numero_Transferencia";
            this.Txt_Numero_Transferencia.Size = new System.Drawing.Size(280, 22);
            this.Txt_Numero_Transferencia.TabIndex = 27;
            this.Txt_Numero_Transferencia.TextChanged += new System.EventHandler(this.Txt_Numero_Transferencia_TextChanged);
            // 
            // Lbl_Banco_Origen
            // 
            this.Lbl_Banco_Origen.AutoSize = true;
            this.Lbl_Banco_Origen.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Banco_Origen.Location = new System.Drawing.Point(60, 90);
            this.Lbl_Banco_Origen.Name = "Lbl_Banco_Origen";
            this.Lbl_Banco_Origen.Size = new System.Drawing.Size(137, 21);
            this.Lbl_Banco_Origen.TabIndex = 17;
            this.Lbl_Banco_Origen.Text = "Banco Origen:";
            // 
            // Lbl_Numero_Transferencia
            // 
            this.Lbl_Numero_Transferencia.AutoSize = true;
            this.Lbl_Numero_Transferencia.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Numero_Transferencia.Location = new System.Drawing.Point(60, 29);
            this.Lbl_Numero_Transferencia.Name = "Lbl_Numero_Transferencia";
            this.Lbl_Numero_Transferencia.Size = new System.Drawing.Size(214, 21);
            this.Lbl_Numero_Transferencia.TabIndex = 16;
            this.Lbl_Numero_Transferencia.Text = "Número Transferencia:";
            // 
            // Lbl_Cuenta_Origen
            // 
            this.Lbl_Cuenta_Origen.AutoSize = true;
            this.Lbl_Cuenta_Origen.Font = new System.Drawing.Font("Rockwell", 10.8F);
            this.Lbl_Cuenta_Origen.Location = new System.Drawing.Point(61, 150);
            this.Lbl_Cuenta_Origen.Name = "Lbl_Cuenta_Origen";
            this.Lbl_Cuenta_Origen.Size = new System.Drawing.Size(147, 21);
            this.Lbl_Cuenta_Origen.TabIndex = 29;
            this.Lbl_Cuenta_Origen.Text = "Cuenta Origen:";
            // 
            // Txt_Cuenta_Origen
            // 
            this.Txt_Cuenta_Origen.Location = new System.Drawing.Point(214, 150);
            this.Txt_Cuenta_Origen.Name = "Txt_Cuenta_Origen";
            this.Txt_Cuenta_Origen.Size = new System.Drawing.Size(346, 22);
            this.Txt_Cuenta_Origen.TabIndex = 30;
            this.Txt_Cuenta_Origen.TextChanged += new System.EventHandler(this.Txt_Cuenta_Origen_TextChanged);
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Limpiar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Limpiar.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Limpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Limpiar.Image = global::Capa_Vista_Reservas_Hotel.Properties.Resources.icono_limpiar__1_;
            this.Btn_Limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Limpiar.Location = new System.Drawing.Point(1009, 47);
            this.Btn_Limpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(55, 54);
            this.Btn_Limpiar.TabIndex = 127;
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
            this.Btn_Modificar.Location = new System.Drawing.Point(948, 47);
            this.Btn_Modificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(55, 54);
            this.Btn_Modificar.TabIndex = 126;
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
            this.Btn_Guardar.Location = new System.Drawing.Point(887, 47);
            this.Btn_Guardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(55, 54);
            this.Btn_Guardar.TabIndex = 125;
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
            this.Btn_Nuevo.Location = new System.Drawing.Point(826, 47);
            this.Btn_Nuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(55, 54);
            this.Btn_Nuevo.TabIndex = 124;
            this.Btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Nuevo.UseVisualStyleBackColor = false;
            this.Btn_Nuevo.Click += new System.EventHandler(this.Btn_Nuevo_Click);
            // 
            // Frm_Pago_Transferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1175, 539);
            this.Controls.Add(this.Gbo_Cmpos);
            this.Controls.Add(this.Btn_Limpiar);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Btn_Nuevo);
            this.Controls.Add(this.Gbo_Pago_Con_Efectivo);
            this.Name = "Frm_Pago_Transferencia";
            this.Text = "Frm_Pago_Transferencia";
            this.Gbo_Pago_Con_Efectivo.ResumeLayout(false);
            this.Gbo_Pago_Con_Efectivo.PerformLayout();
            this.Gbo_Cmpos.ResumeLayout(false);
            this.Gbo_Cmpos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gbo_Pago_Con_Efectivo;
        private System.Windows.Forms.Label Lbl_Pago_Con_Transferencia;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Limpiar;
        private System.Windows.Forms.GroupBox Gbo_Cmpos;
        private System.Windows.Forms.TextBox Txt_Banco_Origen;
        private System.Windows.Forms.TextBox Txt_Numero_Transferencia;
        private System.Windows.Forms.Label Lbl_Banco_Origen;
        private System.Windows.Forms.Label Lbl_Numero_Transferencia;
        private System.Windows.Forms.TextBox Txt_Cuenta_Origen;
        private System.Windows.Forms.Label Lbl_Cuenta_Origen;
    }
}