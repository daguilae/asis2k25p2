
namespace Capa_Vista_TipoDeCambio
{
    partial class Frm_IngresoTipoDeCambio
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.Cbo_Moneda = new System.Windows.Forms.ComboBox();
            this.Txt_Fuente = new System.Windows.Forms.TextBox();
            this.Txt_Venta = new System.Windows.Forms.TextBox();
            this.Txt_Compra = new System.Windows.Forms.TextBox();
            this.Txt_Fecha = new System.Windows.Forms.TextBox();
            this.Lbl_Moneda = new System.Windows.Forms.Label();
            this.Lbl_Fuente = new System.Windows.Forms.Label();
            this.Lbl_Venta = new System.Windows.Forms.Label();
            this.Lbl_Compra = new System.Windows.Forms.Label();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.Lbl_Ingreso = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_Agregar);
            this.panel1.Controls.Add(this.Cbo_Moneda);
            this.panel1.Controls.Add(this.Txt_Fuente);
            this.panel1.Controls.Add(this.Txt_Venta);
            this.panel1.Controls.Add(this.Txt_Compra);
            this.panel1.Controls.Add(this.Txt_Fecha);
            this.panel1.Controls.Add(this.Lbl_Moneda);
            this.panel1.Controls.Add(this.Lbl_Fuente);
            this.panel1.Controls.Add(this.Lbl_Venta);
            this.panel1.Controls.Add(this.Lbl_Compra);
            this.panel1.Controls.Add(this.Lbl_Fecha);
            this.panel1.Controls.Add(this.Lbl_Ingreso);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 409);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Agregar.Location = new System.Drawing.Point(156, 341);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(128, 34);
            this.Btn_Agregar.TabIndex = 11;
            this.Btn_Agregar.Text = "Agregar";
            this.Btn_Agregar.UseVisualStyleBackColor = true;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // Cbo_Moneda
            // 
            this.Cbo_Moneda.FormattingEnabled = true;
            this.Cbo_Moneda.Location = new System.Drawing.Point(156, 262);
            this.Cbo_Moneda.Name = "Cbo_Moneda";
            this.Cbo_Moneda.Size = new System.Drawing.Size(262, 21);
            this.Cbo_Moneda.TabIndex = 10;
            // 
            // Txt_Fuente
            // 
            this.Txt_Fuente.Location = new System.Drawing.Point(156, 212);
            this.Txt_Fuente.Name = "Txt_Fuente";
            this.Txt_Fuente.Size = new System.Drawing.Size(262, 20);
            this.Txt_Fuente.TabIndex = 9;
            this.Txt_Fuente.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Txt_Venta
            // 
            this.Txt_Venta.Location = new System.Drawing.Point(156, 173);
            this.Txt_Venta.Name = "Txt_Venta";
            this.Txt_Venta.Size = new System.Drawing.Size(262, 20);
            this.Txt_Venta.TabIndex = 8;
            // 
            // Txt_Compra
            // 
            this.Txt_Compra.Location = new System.Drawing.Point(156, 131);
            this.Txt_Compra.Name = "Txt_Compra";
            this.Txt_Compra.Size = new System.Drawing.Size(262, 20);
            this.Txt_Compra.TabIndex = 7;
            // 
            // Txt_Fecha
            // 
            this.Txt_Fecha.Location = new System.Drawing.Point(156, 91);
            this.Txt_Fecha.Name = "Txt_Fecha";
            this.Txt_Fecha.Size = new System.Drawing.Size(262, 20);
            this.Txt_Fecha.TabIndex = 6;
            // 
            // Lbl_Moneda
            // 
            this.Lbl_Moneda.AutoSize = true;
            this.Lbl_Moneda.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Moneda.Location = new System.Drawing.Point(59, 262);
            this.Lbl_Moneda.Name = "Lbl_Moneda";
            this.Lbl_Moneda.Size = new System.Drawing.Size(74, 18);
            this.Lbl_Moneda.TabIndex = 5;
            this.Lbl_Moneda.Text = "Moneda:";
            // 
            // Lbl_Fuente
            // 
            this.Lbl_Fuente.AutoSize = true;
            this.Lbl_Fuente.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fuente.Location = new System.Drawing.Point(69, 212);
            this.Lbl_Fuente.Name = "Lbl_Fuente";
            this.Lbl_Fuente.Size = new System.Drawing.Size(64, 18);
            this.Lbl_Fuente.TabIndex = 4;
            this.Lbl_Fuente.Text = "Fuente:";
            // 
            // Lbl_Venta
            // 
            this.Lbl_Venta.AutoSize = true;
            this.Lbl_Venta.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Venta.Location = new System.Drawing.Point(78, 173);
            this.Lbl_Venta.Name = "Lbl_Venta";
            this.Lbl_Venta.Size = new System.Drawing.Size(55, 18);
            this.Lbl_Venta.TabIndex = 3;
            this.Lbl_Venta.Text = "Venta:";
            // 
            // Lbl_Compra
            // 
            this.Lbl_Compra.AutoSize = true;
            this.Lbl_Compra.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Compra.Location = new System.Drawing.Point(62, 131);
            this.Lbl_Compra.Name = "Lbl_Compra";
            this.Lbl_Compra.Size = new System.Drawing.Size(74, 18);
            this.Lbl_Compra.TabIndex = 2;
            this.Lbl_Compra.Text = "Compra:";
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha.Location = new System.Drawing.Point(78, 93);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(58, 18);
            this.Lbl_Fecha.TabIndex = 1;
            this.Lbl_Fecha.Text = "Fecha:";
            // 
            // Lbl_Ingreso
            // 
            this.Lbl_Ingreso.AutoSize = true;
            this.Lbl_Ingreso.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Ingreso.Location = new System.Drawing.Point(76, 21);
            this.Lbl_Ingreso.Name = "Lbl_Ingreso";
            this.Lbl_Ingreso.Size = new System.Drawing.Size(336, 29);
            this.Lbl_Ingreso.TabIndex = 0;
            this.Lbl_Ingreso.Text = "Ingreso de Tipo De Cambio";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 489);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Frm_IngresoTipoDeCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 546);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_IngresoTipoDeCambio";
            this.Text = "Frm_IngresoTipoDeCambio";
            this.Load += new System.EventHandler(this.Frm_IngresoTipoDeCambio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_Fuente;
        private System.Windows.Forms.Label Lbl_Venta;
        private System.Windows.Forms.Label Lbl_Compra;
        private System.Windows.Forms.Label Lbl_Fecha;
        private System.Windows.Forms.Label Lbl_Ingreso;
        private System.Windows.Forms.Label Lbl_Moneda;
        private System.Windows.Forms.ComboBox Cbo_Moneda;
        private System.Windows.Forms.TextBox Txt_Fuente;
        private System.Windows.Forms.TextBox Txt_Venta;
        private System.Windows.Forms.TextBox Txt_Compra;
        private System.Windows.Forms.TextBox Txt_Fecha;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.Button button1;
    }
}