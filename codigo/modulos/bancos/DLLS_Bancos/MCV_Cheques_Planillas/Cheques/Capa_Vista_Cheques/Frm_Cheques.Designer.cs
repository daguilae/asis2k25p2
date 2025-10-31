
namespace Capa_Vista_Cheques
{
    partial class Frm_Cheques
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cheques));
            this.Txt_planilla = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Banco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Moneda = new System.Windows.Forms.TextBox();
            this.Lbl_Moneda = new System.Windows.Forms.Label();
            this.Txt_Fecha = new System.Windows.Forms.TextBox();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Btn_Cargar = new System.Windows.Forms.Button();
            this.btn_Generar_Cheque = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Cuenta_Contable = new System.Windows.Forms.TextBox();
            this.Txt_nombre_banco = new System.Windows.Forms.TextBox();
            this.Txt_debe_haber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_Valor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_planilla
            // 
            this.Txt_planilla.Location = new System.Drawing.Point(318, 126);
            this.Txt_planilla.Name = "Txt_planilla";
            this.Txt_planilla.Size = new System.Drawing.Size(143, 22);
            this.Txt_planilla.TabIndex = 109;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 24);
            this.label3.TabIndex = 108;
            this.label3.Text = "Número de planilla (Lote):";
            // 
            // Txt_Banco
            // 
            this.Txt_Banco.Location = new System.Drawing.Point(318, 173);
            this.Txt_Banco.Name = "Txt_Banco";
            this.Txt_Banco.Size = new System.Drawing.Size(143, 22);
            this.Txt_Banco.TabIndex = 107;
            this.Txt_Banco.TextChanged += new System.EventHandler(this.Txt_Banco_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 106;
            this.label1.Text = "Banco Cuenta:";
            // 
            // Txt_Moneda
            // 
            this.Txt_Moneda.Location = new System.Drawing.Point(318, 214);
            this.Txt_Moneda.Name = "Txt_Moneda";
            this.Txt_Moneda.Size = new System.Drawing.Size(143, 22);
            this.Txt_Moneda.TabIndex = 103;
            // 
            // Lbl_Moneda
            // 
            this.Lbl_Moneda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Moneda.AutoSize = true;
            this.Lbl_Moneda.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Moneda.Location = new System.Drawing.Point(28, 212);
            this.Lbl_Moneda.Name = "Lbl_Moneda";
            this.Lbl_Moneda.Size = new System.Drawing.Size(89, 24);
            this.Lbl_Moneda.TabIndex = 102;
            this.Lbl_Moneda.Text = "Moneda:";
            // 
            // Txt_Fecha
            // 
            this.Txt_Fecha.Location = new System.Drawing.Point(318, 80);
            this.Txt_Fecha.Name = "Txt_Fecha";
            this.Txt_Fecha.Size = new System.Drawing.Size(143, 22);
            this.Txt_Fecha.TabIndex = 101;
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha.Location = new System.Drawing.Point(28, 80);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(145, 24);
            this.Lbl_Fecha.TabIndex = 100;
            this.Lbl_Fecha.Text = "Fecha de pago:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(379, 31);
            this.label2.TabIndex = 99;
            this.label2.Text = "Generacion de Cheques Planilla";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 359);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(824, 162);
            this.dataGridView1.TabIndex = 113;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Btn_Cargar
            // 
            this.Btn_Cargar.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cargar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cargar.Image")));
            this.Btn_Cargar.Location = new System.Drawing.Point(664, 23);
            this.Btn_Cargar.Name = "Btn_Cargar";
            this.Btn_Cargar.Size = new System.Drawing.Size(56, 51);
            this.Btn_Cargar.TabIndex = 114;
            this.Btn_Cargar.UseVisualStyleBackColor = true;
            // 
            // btn_Generar_Cheque
            // 
            this.btn_Generar_Cheque.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Generar_Cheque.Location = new System.Drawing.Point(726, 23);
            this.btn_Generar_Cheque.Name = "btn_Generar_Cheque";
            this.btn_Generar_Cheque.Size = new System.Drawing.Size(56, 51);
            this.btn_Generar_Cheque.TabIndex = 115;
            this.btn_Generar_Cheque.UseVisualStyleBackColor = true;
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir.Image = ((System.Drawing.Image)(resources.GetObject("btn_imprimir.Image")));
            this.btn_imprimir.Location = new System.Drawing.Point(788, 23);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(56, 51);
            this.btn_imprimir.TabIndex = 116;
            this.btn_imprimir.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 24);
            this.label4.TabIndex = 117;
            this.label4.Text = "Cuenta Contable:";
            // 
            // Txt_Cuenta_Contable
            // 
            this.Txt_Cuenta_Contable.Location = new System.Drawing.Point(32, 319);
            this.Txt_Cuenta_Contable.Name = "Txt_Cuenta_Contable";
            this.Txt_Cuenta_Contable.Size = new System.Drawing.Size(162, 22);
            this.Txt_Cuenta_Contable.TabIndex = 118;
            // 
            // Txt_nombre_banco
            // 
            this.Txt_nombre_banco.Location = new System.Drawing.Point(261, 319);
            this.Txt_nombre_banco.Name = "Txt_nombre_banco";
            this.Txt_nombre_banco.Size = new System.Drawing.Size(143, 22);
            this.Txt_nombre_banco.TabIndex = 119;
            // 
            // Txt_debe_haber
            // 
            this.Txt_debe_haber.Location = new System.Drawing.Point(441, 319);
            this.Txt_debe_haber.Name = "Txt_debe_haber";
            this.Txt_debe_haber.Size = new System.Drawing.Size(143, 22);
            this.Txt_debe_haber.TabIndex = 120;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(257, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 24);
            this.label5.TabIndex = 121;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(448, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 24);
            this.label6.TabIndex = 122;
            this.label6.Text = "D/H:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(614, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 24);
            this.label7.TabIndex = 123;
            this.label7.Text = "Valor:";
            // 
            // Txt_Valor
            // 
            this.Txt_Valor.Location = new System.Drawing.Point(618, 319);
            this.Txt_Valor.Name = "Txt_Valor";
            this.Txt_Valor.Size = new System.Drawing.Size(143, 22);
            this.Txt_Valor.TabIndex = 124;
            // 
            // Frm_Cheques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 575);
            this.Controls.Add(this.Txt_Valor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_debe_haber);
            this.Controls.Add(this.Txt_nombre_banco);
            this.Controls.Add(this.Txt_Cuenta_Contable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.btn_Generar_Cheque);
            this.Controls.Add(this.Btn_Cargar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Txt_planilla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_Banco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Moneda);
            this.Controls.Add(this.Lbl_Moneda);
            this.Controls.Add(this.Txt_Fecha);
            this.Controls.Add(this.Lbl_Fecha);
            this.Controls.Add(this.label2);
            this.Name = "Frm_Cheques";
            this.Text = "Frm_Cheques";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Txt_planilla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Banco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Moneda;
        private System.Windows.Forms.Label Lbl_Moneda;
        private System.Windows.Forms.TextBox Txt_Fecha;
        private System.Windows.Forms.Label Lbl_Fecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Btn_Cargar;
        private System.Windows.Forms.Button btn_Generar_Cheque;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Cuenta_Contable;
        private System.Windows.Forms.TextBox Txt_nombre_banco;
        private System.Windows.Forms.TextBox Txt_debe_haber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_Valor;
    }
}