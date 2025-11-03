
namespace Capa_Vista_Contabilidad
{
    partial class Frm_Cuenta_Turismo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cuenta_Turismo));
            this.Gpb_Cuentas = new System.Windows.Forms.GroupBox();
            this.Cbo_Cuenta_Haber = new System.Windows.Forms.ComboBox();
            this.Lbl_Cuenta_Haber = new System.Windows.Forms.Label();
            this.Cbo_Cuenta_Debe = new System.Windows.Forms.ComboBox();
            this.Lbl_Cuenta_Debe = new System.Windows.Forms.Label();
            this.lbl_catalogo_cuentas = new System.Windows.Forms.Label();
            this.Lbl_Poliza = new System.Windows.Forms.Label();
            this.Btn_modificar = new System.Windows.Forms.Button();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.Gpb_Cuentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gpb_Cuentas
            // 
            this.Gpb_Cuentas.Controls.Add(this.Cbo_Cuenta_Haber);
            this.Gpb_Cuentas.Controls.Add(this.Lbl_Cuenta_Haber);
            this.Gpb_Cuentas.Controls.Add(this.Cbo_Cuenta_Debe);
            this.Gpb_Cuentas.Controls.Add(this.Lbl_Cuenta_Debe);
            this.Gpb_Cuentas.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Cuentas.Location = new System.Drawing.Point(41, 154);
            this.Gpb_Cuentas.Name = "Gpb_Cuentas";
            this.Gpb_Cuentas.Size = new System.Drawing.Size(549, 213);
            this.Gpb_Cuentas.TabIndex = 98;
            this.Gpb_Cuentas.TabStop = false;
            this.Gpb_Cuentas.Text = "Configuración de cuentas para póliza de turismo";
            // 
            // Cbo_Cuenta_Haber
            // 
            this.Cbo_Cuenta_Haber.FormattingEnabled = true;
            this.Cbo_Cuenta_Haber.Location = new System.Drawing.Point(169, 115);
            this.Cbo_Cuenta_Haber.Name = "Cbo_Cuenta_Haber";
            this.Cbo_Cuenta_Haber.Size = new System.Drawing.Size(260, 28);
            this.Cbo_Cuenta_Haber.TabIndex = 6;
            // 
            // Lbl_Cuenta_Haber
            // 
            this.Lbl_Cuenta_Haber.AutoSize = true;
            this.Lbl_Cuenta_Haber.Location = new System.Drawing.Point(39, 118);
            this.Lbl_Cuenta_Haber.Name = "Lbl_Cuenta_Haber";
            this.Lbl_Cuenta_Haber.Size = new System.Drawing.Size(118, 20);
            this.Lbl_Cuenta_Haber.TabIndex = 5;
            this.Lbl_Cuenta_Haber.Text = "Cuenta Haber";
            // 
            // Cbo_Cuenta_Debe
            // 
            this.Cbo_Cuenta_Debe.FormattingEnabled = true;
            this.Cbo_Cuenta_Debe.Location = new System.Drawing.Point(169, 70);
            this.Cbo_Cuenta_Debe.Name = "Cbo_Cuenta_Debe";
            this.Cbo_Cuenta_Debe.Size = new System.Drawing.Size(260, 28);
            this.Cbo_Cuenta_Debe.TabIndex = 4;
            // 
            // Lbl_Cuenta_Debe
            // 
            this.Lbl_Cuenta_Debe.AutoSize = true;
            this.Lbl_Cuenta_Debe.Location = new System.Drawing.Point(39, 73);
            this.Lbl_Cuenta_Debe.Name = "Lbl_Cuenta_Debe";
            this.Lbl_Cuenta_Debe.Size = new System.Drawing.Size(112, 20);
            this.Lbl_Cuenta_Debe.TabIndex = 0;
            this.Lbl_Cuenta_Debe.Text = "Cuenta Debe";
            // 
            // lbl_catalogo_cuentas
            // 
            this.lbl_catalogo_cuentas.AutoSize = true;
            this.lbl_catalogo_cuentas.Location = new System.Drawing.Point(258, 53);
            this.lbl_catalogo_cuentas.Name = "lbl_catalogo_cuentas";
            this.lbl_catalogo_cuentas.Size = new System.Drawing.Size(0, 17);
            this.lbl_catalogo_cuentas.TabIndex = 99;
            // 
            // Lbl_Poliza
            // 
            this.Lbl_Poliza.AutoSize = true;
            this.Lbl_Poliza.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Poliza.Location = new System.Drawing.Point(255, 38);
            this.Lbl_Poliza.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Poliza.Name = "Lbl_Poliza";
            this.Lbl_Poliza.Size = new System.Drawing.Size(299, 35);
            this.Lbl_Poliza.TabIndex = 102;
            this.Lbl_Poliza.Text = "Catalogo de cuentas";
            // 
            // Btn_modificar
            // 
            this.Btn_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(74)))), ((int)(((byte)(83)))));
            this.Btn_modificar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_modificar.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_modificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_modificar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_modificar.Image")));
            this.Btn_modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_modificar.Location = new System.Drawing.Point(635, 224);
            this.Btn_modificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_modificar.Name = "Btn_modificar";
            this.Btn_modificar.Size = new System.Drawing.Size(143, 54);
            this.Btn_modificar.TabIndex = 104;
            this.Btn_modificar.Text = "Modificar";
            this.Btn_modificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_modificar.UseVisualStyleBackColor = false;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(74)))), ((int)(((byte)(83)))));
            this.Btn_Buscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Buscar.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Buscar.Image")));
            this.Btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Buscar.Location = new System.Drawing.Point(635, 142);
            this.Btn_Buscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(143, 54);
            this.Btn_Buscar.TabIndex = 105;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Buscar.UseVisualStyleBackColor = false;
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(74)))), ((int)(((byte)(83)))));
            this.Btn_Limpiar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Limpiar.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Limpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Limpiar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Limpiar.Image")));
            this.Btn_Limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Limpiar.Location = new System.Drawing.Point(635, 313);
            this.Btn_Limpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(143, 54);
            this.Btn_Limpiar.TabIndex = 106;
            this.Btn_Limpiar.Text = "Limpiar";
            this.Btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Limpiar.UseVisualStyleBackColor = false;
            // 
            // Frm_Cuenta_Turismo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(832, 503);
            this.Controls.Add(this.Btn_Limpiar);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Btn_modificar);
            this.Controls.Add(this.Lbl_Poliza);
            this.Controls.Add(this.lbl_catalogo_cuentas);
            this.Controls.Add(this.Gpb_Cuentas);
            this.Name = "Frm_Cuenta_Turismo";
            this.Text = "Frm_Cuenta_Turismo";
            this.Gpb_Cuentas.ResumeLayout(false);
            this.Gpb_Cuentas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Gpb_Cuentas;
        private System.Windows.Forms.ComboBox Cbo_Cuenta_Haber;
        private System.Windows.Forms.Label Lbl_Cuenta_Haber;
        private System.Windows.Forms.ComboBox Cbo_Cuenta_Debe;
        private System.Windows.Forms.Label Lbl_Cuenta_Debe;
        private System.Windows.Forms.Label lbl_catalogo_cuentas;
        private System.Windows.Forms.Label Lbl_Poliza;
        private System.Windows.Forms.Button Btn_modificar;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Button Btn_Limpiar;
    }
}