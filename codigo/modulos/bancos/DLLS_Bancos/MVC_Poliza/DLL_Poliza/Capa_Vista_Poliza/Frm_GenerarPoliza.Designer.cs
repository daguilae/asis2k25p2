
namespace Capa_Vista
{
    partial class Frm_GenerarPoliza
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
            this.Gpb_Rangos = new System.Windows.Forms.GroupBox();
            this.Dtp_Fecha_Fin = new System.Windows.Forms.DateTimePicker();
            this.Dtp_Fecha_Ini = new System.Windows.Forms.DateTimePicker();
            this.Cbo_Documento = new System.Windows.Forms.ComboBox();
            this.Cbo_Tipo = new System.Windows.Forms.ComboBox();
            this.Cbo_Banco = new System.Windows.Forms.ComboBox();
            this.Lbl_Fechas = new System.Windows.Forms.Label();
            this.Lbl_Documento = new System.Windows.Forms.Label();
            this.Lbl_Tipo = new System.Windows.Forms.Label();
            this.Lbl_Banco = new System.Windows.Forms.Label();
            this.Gpb_Generales = new System.Windows.Forms.GroupBox();
            this.Dtp_Fecha_Poliza = new System.Windows.Forms.DateTimePicker();
            this.Txt_Concepto = new System.Windows.Forms.TextBox();
            this.Lbl_Concepto = new System.Windows.Forms.Label();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Gpb_Rangos.SuspendLayout();
            this.Gpb_Generales.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gpb_Rangos
            // 
            this.Gpb_Rangos.Controls.Add(this.Dtp_Fecha_Fin);
            this.Gpb_Rangos.Controls.Add(this.Dtp_Fecha_Ini);
            this.Gpb_Rangos.Controls.Add(this.Cbo_Documento);
            this.Gpb_Rangos.Controls.Add(this.Cbo_Tipo);
            this.Gpb_Rangos.Controls.Add(this.Cbo_Banco);
            this.Gpb_Rangos.Controls.Add(this.Lbl_Fechas);
            this.Gpb_Rangos.Controls.Add(this.Lbl_Documento);
            this.Gpb_Rangos.Controls.Add(this.Lbl_Tipo);
            this.Gpb_Rangos.Controls.Add(this.Lbl_Banco);
            this.Gpb_Rangos.Font = new System.Drawing.Font("Rockwell Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Rangos.Location = new System.Drawing.Point(36, 38);
            this.Gpb_Rangos.Name = "Gpb_Rangos";
            this.Gpb_Rangos.Size = new System.Drawing.Size(638, 263);
            this.Gpb_Rangos.TabIndex = 0;
            this.Gpb_Rangos.TabStop = false;
            this.Gpb_Rangos.Text = "Rangos";
            // 
            // Dtp_Fecha_Fin
            // 
            this.Dtp_Fecha_Fin.Font = new System.Drawing.Font("Rockwell Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_Fecha_Fin.Location = new System.Drawing.Point(326, 208);
            this.Dtp_Fecha_Fin.Name = "Dtp_Fecha_Fin";
            this.Dtp_Fecha_Fin.Size = new System.Drawing.Size(171, 29);
            this.Dtp_Fecha_Fin.TabIndex = 21;
            // 
            // Dtp_Fecha_Ini
            // 
            this.Dtp_Fecha_Ini.Font = new System.Drawing.Font("Rockwell Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_Fecha_Ini.Location = new System.Drawing.Point(141, 208);
            this.Dtp_Fecha_Ini.Name = "Dtp_Fecha_Ini";
            this.Dtp_Fecha_Ini.Size = new System.Drawing.Size(171, 29);
            this.Dtp_Fecha_Ini.TabIndex = 20;
            // 
            // Cbo_Documento
            // 
            this.Cbo_Documento.Font = new System.Drawing.Font("Rockwell Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Documento.FormattingEnabled = true;
            this.Cbo_Documento.Location = new System.Drawing.Point(171, 148);
            this.Cbo_Documento.Name = "Cbo_Documento";
            this.Cbo_Documento.Size = new System.Drawing.Size(356, 29);
            this.Cbo_Documento.TabIndex = 14;
            // 
            // Cbo_Tipo
            // 
            this.Cbo_Tipo.Font = new System.Drawing.Font("Rockwell Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Tipo.FormattingEnabled = true;
            this.Cbo_Tipo.Location = new System.Drawing.Point(171, 88);
            this.Cbo_Tipo.Name = "Cbo_Tipo";
            this.Cbo_Tipo.Size = new System.Drawing.Size(356, 29);
            this.Cbo_Tipo.TabIndex = 13;
            // 
            // Cbo_Banco
            // 
            this.Cbo_Banco.Font = new System.Drawing.Font("Rockwell Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Banco.FormattingEnabled = true;
            this.Cbo_Banco.Location = new System.Drawing.Point(171, 39);
            this.Cbo_Banco.Name = "Cbo_Banco";
            this.Cbo_Banco.Size = new System.Drawing.Size(356, 29);
            this.Cbo_Banco.TabIndex = 12;
            this.Cbo_Banco.SelectedIndexChanged += new System.EventHandler(this.Cbo_Banco_SelectedIndexChanged);
            // 
            // Lbl_Fechas
            // 
            this.Lbl_Fechas.AutoSize = true;
            this.Lbl_Fechas.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fechas.Location = new System.Drawing.Point(15, 208);
            this.Lbl_Fechas.Name = "Lbl_Fechas";
            this.Lbl_Fechas.Size = new System.Drawing.Size(71, 21);
            this.Lbl_Fechas.TabIndex = 9;
            this.Lbl_Fechas.Text = "Fechas";
            // 
            // Lbl_Documento
            // 
            this.Lbl_Documento.AutoSize = true;
            this.Lbl_Documento.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Documento.Location = new System.Drawing.Point(15, 148);
            this.Lbl_Documento.Name = "Lbl_Documento";
            this.Lbl_Documento.Size = new System.Drawing.Size(111, 21);
            this.Lbl_Documento.TabIndex = 6;
            this.Lbl_Documento.Text = "Documento";
            // 
            // Lbl_Tipo
            // 
            this.Lbl_Tipo.AutoSize = true;
            this.Lbl_Tipo.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Tipo.Location = new System.Drawing.Point(15, 92);
            this.Lbl_Tipo.Name = "Lbl_Tipo";
            this.Lbl_Tipo.Size = new System.Drawing.Size(154, 21);
            this.Lbl_Tipo.TabIndex = 3;
            this.Lbl_Tipo.Text = "Cuenta Bancaria";
            // 
            // Lbl_Banco
            // 
            this.Lbl_Banco.AutoSize = true;
            this.Lbl_Banco.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Banco.Location = new System.Drawing.Point(15, 47);
            this.Lbl_Banco.Name = "Lbl_Banco";
            this.Lbl_Banco.Size = new System.Drawing.Size(63, 21);
            this.Lbl_Banco.TabIndex = 0;
            this.Lbl_Banco.Text = "Banco";
            // 
            // Gpb_Generales
            // 
            this.Gpb_Generales.Controls.Add(this.Dtp_Fecha_Poliza);
            this.Gpb_Generales.Controls.Add(this.Txt_Concepto);
            this.Gpb_Generales.Controls.Add(this.Lbl_Concepto);
            this.Gpb_Generales.Controls.Add(this.Lbl_Fecha);
            this.Gpb_Generales.Font = new System.Drawing.Font("Rockwell Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Generales.Location = new System.Drawing.Point(36, 319);
            this.Gpb_Generales.Name = "Gpb_Generales";
            this.Gpb_Generales.Size = new System.Drawing.Size(638, 172);
            this.Gpb_Generales.TabIndex = 1;
            this.Gpb_Generales.TabStop = false;
            this.Gpb_Generales.Text = "Generales de Poliza";
            // 
            // Dtp_Fecha_Poliza
            // 
            this.Dtp_Fecha_Poliza.Font = new System.Drawing.Font("Rockwell Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_Fecha_Poliza.Location = new System.Drawing.Point(141, 60);
            this.Dtp_Fecha_Poliza.Name = "Dtp_Fecha_Poliza";
            this.Dtp_Fecha_Poliza.Size = new System.Drawing.Size(356, 29);
            this.Dtp_Fecha_Poliza.TabIndex = 22;
            // 
            // Txt_Concepto
            // 
            this.Txt_Concepto.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Concepto.Location = new System.Drawing.Point(31, 127);
            this.Txt_Concepto.Name = "Txt_Concepto";
            this.Txt_Concepto.Size = new System.Drawing.Size(586, 29);
            this.Txt_Concepto.TabIndex = 13;
            // 
            // Lbl_Concepto
            // 
            this.Lbl_Concepto.AutoSize = true;
            this.Lbl_Concepto.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Concepto.Location = new System.Drawing.Point(27, 103);
            this.Lbl_Concepto.Name = "Lbl_Concepto";
            this.Lbl_Concepto.Size = new System.Drawing.Size(96, 21);
            this.Lbl_Concepto.TabIndex = 12;
            this.Lbl_Concepto.Text = "Concepto";
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha.Location = new System.Drawing.Point(29, 60);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(62, 21);
            this.Lbl_Fecha.TabIndex = 9;
            this.Lbl_Fecha.Text = "Fecha";
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.Location = new System.Drawing.Point(177, 506);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(160, 76);
            this.Btn_Aceptar.TabIndex = 2;
            this.Btn_Aceptar.Text = "Aceptar";
            this.Btn_Aceptar.UseVisualStyleBackColor = true;
            this.Btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(357, 506);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(160, 76);
            this.Btn_Cancelar.TabIndex = 3;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Frm_GenerarPoliza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 673);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.Gpb_Generales);
            this.Controls.Add(this.Gpb_Rangos);
            this.Name = "Frm_GenerarPoliza";
            this.Text = "Frm_Poliza";
            this.Gpb_Rangos.ResumeLayout(false);
            this.Gpb_Rangos.PerformLayout();
            this.Gpb_Generales.ResumeLayout(false);
            this.Gpb_Generales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gpb_Rangos;
        private System.Windows.Forms.Label Lbl_Fechas;
        private System.Windows.Forms.Label Lbl_Documento;
        private System.Windows.Forms.Label Lbl_Tipo;
        private System.Windows.Forms.Label Lbl_Banco;
        private System.Windows.Forms.GroupBox Gpb_Generales;
        private System.Windows.Forms.TextBox Txt_Concepto;
        private System.Windows.Forms.Label Lbl_Concepto;
        private System.Windows.Forms.Label Lbl_Fecha;
        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.ComboBox Cbo_Documento;
        private System.Windows.Forms.ComboBox Cbo_Tipo;
        private System.Windows.Forms.ComboBox Cbo_Banco;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Ini;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Fin;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Poliza;
    }
}