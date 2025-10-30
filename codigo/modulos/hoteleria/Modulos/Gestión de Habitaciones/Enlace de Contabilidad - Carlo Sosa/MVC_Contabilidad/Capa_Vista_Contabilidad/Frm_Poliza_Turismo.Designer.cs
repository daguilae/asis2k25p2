
namespace Capa_Vista_Contabilidad
{
    partial class Frm_Poliza_Turismo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Poliza_Turismo));
            this.Pnl_Superior = new System.Windows.Forms.Panel();
            this.Pic_Cerrar = new System.Windows.Forms.PictureBox();
            this.Gpb_Rangos = new System.Windows.Forms.GroupBox();
            this.Txt_Fecha_Rango2 = new System.Windows.Forms.TextBox();
            this.Txt_fecha_Rango = new System.Windows.Forms.TextBox();
            this.Lbl_fecha_rango = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_Concepto = new System.Windows.Forms.TextBox();
            this.Lbl_Concepto = new System.Windows.Forms.Label();
            this.Txt_ID_Poliza = new System.Windows.Forms.TextBox();
            this.Txt_Fecha_Generales = new System.Windows.Forms.TextBox();
            this.Lbl_Fecha_Generales = new System.Windows.Forms.Label();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Lbl_Poliza = new System.Windows.Forms.Label();
            this.Pnl_Superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Cerrar)).BeginInit();
            this.Gpb_Rangos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Superior
            // 
            this.Pnl_Superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(142)))), ((int)(((byte)(181)))));
            this.Pnl_Superior.Controls.Add(this.Pic_Cerrar);
            this.Pnl_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Superior.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Superior.Name = "Pnl_Superior";
            this.Pnl_Superior.Size = new System.Drawing.Size(832, 44);
            this.Pnl_Superior.TabIndex = 96;
            // 
            // Pic_Cerrar
            // 
            this.Pic_Cerrar.BackColor = System.Drawing.Color.Transparent;
            this.Pic_Cerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pic_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Cerrar.Image")));
            this.Pic_Cerrar.Location = new System.Drawing.Point(795, 0);
            this.Pic_Cerrar.Name = "Pic_Cerrar";
            this.Pic_Cerrar.Size = new System.Drawing.Size(37, 44);
            this.Pic_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Cerrar.TabIndex = 1;
            this.Pic_Cerrar.TabStop = false;
            this.Pic_Cerrar.Click += new System.EventHandler(this.Pic_Cerrar_Click);
            // 
            // Gpb_Rangos
            // 
            this.Gpb_Rangos.Controls.Add(this.Txt_Fecha_Rango2);
            this.Gpb_Rangos.Controls.Add(this.Txt_fecha_Rango);
            this.Gpb_Rangos.Controls.Add(this.Lbl_fecha_rango);
            this.Gpb_Rangos.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Rangos.Location = new System.Drawing.Point(135, 126);
            this.Gpb_Rangos.Name = "Gpb_Rangos";
            this.Gpb_Rangos.Size = new System.Drawing.Size(566, 109);
            this.Gpb_Rangos.TabIndex = 97;
            this.Gpb_Rangos.TabStop = false;
            this.Gpb_Rangos.Text = "Rangos";
            // 
            // Txt_Fecha_Rango2
            // 
            this.Txt_Fecha_Rango2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.Txt_Fecha_Rango2.Location = new System.Drawing.Point(314, 49);
            this.Txt_Fecha_Rango2.Name = "Txt_Fecha_Rango2";
            this.Txt_Fecha_Rango2.Size = new System.Drawing.Size(183, 27);
            this.Txt_Fecha_Rango2.TabIndex = 3;
            // 
            // Txt_fecha_Rango
            // 
            this.Txt_fecha_Rango.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.Txt_fecha_Rango.Location = new System.Drawing.Point(125, 49);
            this.Txt_fecha_Rango.Name = "Txt_fecha_Rango";
            this.Txt_fecha_Rango.Size = new System.Drawing.Size(183, 27);
            this.Txt_fecha_Rango.TabIndex = 1;
            // 
            // Lbl_fecha_rango
            // 
            this.Lbl_fecha_rango.AutoSize = true;
            this.Lbl_fecha_rango.Location = new System.Drawing.Point(46, 52);
            this.Lbl_fecha_rango.Name = "Lbl_fecha_rango";
            this.Lbl_fecha_rango.Size = new System.Drawing.Size(64, 20);
            this.Lbl_fecha_rango.TabIndex = 0;
            this.Lbl_fecha_rango.Text = "Fechas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Txt_Concepto);
            this.groupBox1.Controls.Add(this.Lbl_Concepto);
            this.groupBox1.Controls.Add(this.Txt_ID_Poliza);
            this.groupBox1.Controls.Add(this.Txt_Fecha_Generales);
            this.groupBox1.Controls.Add(this.Lbl_Fecha_Generales);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(135, 257);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 159);
            this.groupBox1.TabIndex = 98;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generales de la Poliza";
            // 
            // Txt_Concepto
            // 
            this.Txt_Concepto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.Txt_Concepto.Location = new System.Drawing.Point(125, 94);
            this.Txt_Concepto.Name = "Txt_Concepto";
            this.Txt_Concepto.Size = new System.Drawing.Size(397, 27);
            this.Txt_Concepto.TabIndex = 5;
            // 
            // Lbl_Concepto
            // 
            this.Lbl_Concepto.AutoSize = true;
            this.Lbl_Concepto.Location = new System.Drawing.Point(24, 97);
            this.Lbl_Concepto.Name = "Lbl_Concepto";
            this.Lbl_Concepto.Size = new System.Drawing.Size(86, 20);
            this.Lbl_Concepto.TabIndex = 4;
            this.Lbl_Concepto.Text = "Concepto";
            // 
            // Txt_ID_Poliza
            // 
            this.Txt_ID_Poliza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.Txt_ID_Poliza.Location = new System.Drawing.Point(339, 49);
            this.Txt_ID_Poliza.Name = "Txt_ID_Poliza";
            this.Txt_ID_Poliza.Size = new System.Drawing.Size(183, 27);
            this.Txt_ID_Poliza.TabIndex = 3;
            // 
            // Txt_Fecha_Generales
            // 
            this.Txt_Fecha_Generales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.Txt_Fecha_Generales.Location = new System.Drawing.Point(125, 49);
            this.Txt_Fecha_Generales.Name = "Txt_Fecha_Generales";
            this.Txt_Fecha_Generales.Size = new System.Drawing.Size(183, 27);
            this.Txt_Fecha_Generales.TabIndex = 1;
            // 
            // Lbl_Fecha_Generales
            // 
            this.Lbl_Fecha_Generales.AutoSize = true;
            this.Lbl_Fecha_Generales.Location = new System.Drawing.Point(46, 52);
            this.Lbl_Fecha_Generales.Name = "Lbl_Fecha_Generales";
            this.Lbl_Fecha_Generales.Size = new System.Drawing.Size(56, 20);
            this.Lbl_Fecha_Generales.TabIndex = 0;
            this.Lbl_Fecha_Generales.Text = "Fecha";
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(88)))));
            this.Btn_Aceptar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Aceptar.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Aceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Aceptar.Location = new System.Drawing.Point(281, 437);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(143, 54);
            this.Btn_Aceptar.TabIndex = 99;
            this.Btn_Aceptar.Text = "Aceptar";
            this.Btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Aceptar.UseVisualStyleBackColor = false;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(88)))));
            this.Btn_Cancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancelar.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Cancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Cancelar.Location = new System.Drawing.Point(474, 437);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(143, 54);
            this.Btn_Cancelar.TabIndex = 100;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Cancelar.UseVisualStyleBackColor = false;
            // 
            // Lbl_Poliza
            // 
            this.Lbl_Poliza.AutoSize = true;
            this.Lbl_Poliza.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Poliza.Location = new System.Drawing.Point(307, 57);
            this.Lbl_Poliza.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Poliza.Name = "Lbl_Poliza";
            this.Lbl_Poliza.Size = new System.Drawing.Size(261, 35);
            this.Lbl_Poliza.TabIndex = 101;
            this.Lbl_Poliza.Text = "Poliza de Turismo";
            // 
            // Frm_Poliza_Turismo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(832, 503);
            this.Controls.Add(this.Lbl_Poliza);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Gpb_Rangos);
            this.Controls.Add(this.Pnl_Superior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Poliza_Turismo";
            this.Text = "Frm_Poliza_Turismo";
            this.Pnl_Superior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Cerrar)).EndInit();
            this.Gpb_Rangos.ResumeLayout(false);
            this.Gpb_Rangos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Superior;
        private System.Windows.Forms.GroupBox Gpb_Rangos;
        private System.Windows.Forms.TextBox Txt_Fecha_Rango2;
        private System.Windows.Forms.TextBox Txt_fecha_Rango;
        private System.Windows.Forms.Label Lbl_fecha_rango;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txt_Concepto;
        private System.Windows.Forms.Label Lbl_Concepto;
        private System.Windows.Forms.TextBox Txt_ID_Poliza;
        private System.Windows.Forms.TextBox Txt_Fecha_Generales;
        private System.Windows.Forms.Label Lbl_Fecha_Generales;
        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Label Lbl_Poliza;
        private System.Windows.Forms.PictureBox Pic_Cerrar;
    }
}