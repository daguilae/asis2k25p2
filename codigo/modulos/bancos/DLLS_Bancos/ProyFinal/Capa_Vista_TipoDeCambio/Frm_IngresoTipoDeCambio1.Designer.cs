
namespace Capa_Vista_TipoDeCambio
{
    partial class Frm_IngresoTipoDeCambio1
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
            this.Lbl_Ingreso = new System.Windows.Forms.Label();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.Lbl_Compra = new System.Windows.Forms.Label();
            this.Lbl_Venta = new System.Windows.Forms.Label();
            this.Lbl_Moneda = new System.Windows.Forms.Label();
            this.Txt_Fecha = new System.Windows.Forms.TextBox();
            this.Txt_Compra = new System.Windows.Forms.TextBox();
            this.Txt_Venta = new System.Windows.Forms.TextBox();
            this.Cbo_Moneda = new System.Windows.Forms.ComboBox();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.AutoSize = true;

            this.Lbl_Fecha.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha.Location = new System.Drawing.Point(78, 91);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(54, 17);

            this.Lbl_Fecha.TabIndex = 1;
            this.Lbl_Fecha.Text = "Fecha:";
            // 
            // Lbl_Compra
            // 
            this.Lbl_Compra.AutoSize = true;

            this.Lbl_Compra.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Compra.Location = new System.Drawing.Point(64, 131);
            this.Lbl_Compra.Name = "Lbl_Compra";
            this.Lbl_Compra.Size = new System.Drawing.Size(68, 17);

            this.Lbl_Compra.TabIndex = 2;
            this.Lbl_Compra.Text = "Compra:";
            // 
            // Lbl_Venta
            // 
            this.Lbl_Venta.AutoSize = true;

            this.Lbl_Venta.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Venta.Location = new System.Drawing.Point(78, 173);
            this.Lbl_Venta.Name = "Lbl_Venta";
            this.Lbl_Venta.Size = new System.Drawing.Size(54, 17);

            this.Lbl_Venta.TabIndex = 3;
            this.Lbl_Venta.Text = "Venta:";
            // 
            // Lbl_Moneda
            // 
            this.Lbl_Moneda.AutoSize = true;

            this.Lbl_Moneda.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Moneda.Location = new System.Drawing.Point(63, 220);
            this.Lbl_Moneda.Name = "Lbl_Moneda";
            this.Lbl_Moneda.Size = new System.Drawing.Size(69, 17);

            this.Lbl_Moneda.TabIndex = 5;
            this.Lbl_Moneda.Text = "Moneda:";
            // 
            // Txt_Fecha
            // 
            this.Txt_Fecha.Location = new System.Drawing.Point(156, 91);
            this.Txt_Fecha.Name = "Txt_Fecha";
            this.Txt_Fecha.Size = new System.Drawing.Size(262, 20);
            this.Txt_Fecha.TabIndex = 6;
            // 
            // Txt_Compra
            // 
            this.Txt_Compra.Location = new System.Drawing.Point(156, 131);
            this.Txt_Compra.Name = "Txt_Compra";
            this.Txt_Compra.Size = new System.Drawing.Size(262, 20);
            this.Txt_Compra.TabIndex = 7;
            // 
            // Txt_Venta
            // 
            this.Txt_Venta.Location = new System.Drawing.Point(156, 173);
            this.Txt_Venta.Name = "Txt_Venta";
            this.Txt_Venta.Size = new System.Drawing.Size(262, 20);
            this.Txt_Venta.TabIndex = 8;
            // 
            // Cbo_Moneda
            // 
            this.Cbo_Moneda.FormattingEnabled = true;
            this.Cbo_Moneda.Location = new System.Drawing.Point(156, 220);
            this.Cbo_Moneda.Name = "Cbo_Moneda";
            this.Cbo_Moneda.Size = new System.Drawing.Size(262, 21);
            this.Cbo_Moneda.TabIndex = 10;
            this.Cbo_Moneda.SelectedIndexChanged += new System.EventHandler(this.Cbo_Moneda_SelectedIndexChanged);
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.Btn_Agregar.Location = new System.Drawing.Point(173, 288);

            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(128, 34);
            this.Btn_Agregar.TabIndex = 11;
            this.Btn_Agregar.Text = "Agregar";
            this.Btn_Agregar.UseVisualStyleBackColor = true;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_Agregar);
            this.panel1.Controls.Add(this.Cbo_Moneda);
            this.panel1.Controls.Add(this.Txt_Venta);
            this.panel1.Controls.Add(this.Txt_Compra);
            this.panel1.Controls.Add(this.Txt_Fecha);
            this.panel1.Controls.Add(this.Lbl_Moneda);
            this.panel1.Controls.Add(this.Lbl_Venta);
            this.panel1.Controls.Add(this.Lbl_Compra);
            this.panel1.Controls.Add(this.Lbl_Fecha);
            this.panel1.Controls.Add(this.Lbl_Ingreso);

            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 359);

            this.panel1.TabIndex = 1;
            // 
            // Frm_IngresoTipoDeCambio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(492, 390);

            this.Controls.Add(this.panel1);
            this.Name = "Frm_IngresoTipoDeCambio1";
            this.Text = "Frm_IngresoTipoDeCambio1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Ingreso;
        private System.Windows.Forms.Label Lbl_Fecha;
        private System.Windows.Forms.Label Lbl_Compra;
        private System.Windows.Forms.Label Lbl_Venta;
        private System.Windows.Forms.Label Lbl_Moneda;
        private System.Windows.Forms.TextBox Txt_Fecha;
        private System.Windows.Forms.TextBox Txt_Compra;
        private System.Windows.Forms.TextBox Txt_Venta;
        private System.Windows.Forms.ComboBox Cbo_Moneda;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.Panel panel1;
    }
}