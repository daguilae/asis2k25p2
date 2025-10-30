
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
            this.Txt_Total = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_planilla = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Banco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Monto = new System.Windows.Forms.TextBox();
            this.Lbl_Monto = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Total
            // 
            this.Txt_Total.Location = new System.Drawing.Point(645, 82);
            this.Txt_Total.Name = "Txt_Total";
            this.Txt_Total.Size = new System.Drawing.Size(143, 22);
            this.Txt_Total.TabIndex = 112;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(666, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 24);
            this.label5.TabIndex = 111;
            this.label5.Text = "Total:  Q.";
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
            // Txt_Monto
            // 
            this.Txt_Monto.Location = new System.Drawing.Point(648, 153);
            this.Txt_Monto.Name = "Txt_Monto";
            this.Txt_Monto.Size = new System.Drawing.Size(143, 22);
            this.Txt_Monto.TabIndex = 105;
            // 
            // Lbl_Monto
            // 
            this.Lbl_Monto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Monto.AutoSize = true;
            this.Lbl_Monto.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Monto.Location = new System.Drawing.Point(666, 126);
            this.Lbl_Monto.Name = "Lbl_Monto";
            this.Lbl_Monto.Size = new System.Drawing.Size(75, 24);
            this.Lbl_Monto.TabIndex = 104;
            this.Lbl_Monto.Text = "Monto:";
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
            this.dataGridView1.Location = new System.Drawing.Point(26, 266);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(576, 162);
            this.dataGridView1.TabIndex = 113;
            // 
            // Btn_Cargar
            // 
            this.Btn_Cargar.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cargar.Location = new System.Drawing.Point(503, 82);
            this.Btn_Cargar.Name = "Btn_Cargar";
            this.Btn_Cargar.Size = new System.Drawing.Size(56, 51);
            this.Btn_Cargar.TabIndex = 114;
            this.Btn_Cargar.UseVisualStyleBackColor = true;
            // 
            // btn_Generar_Cheque
            // 
            this.btn_Generar_Cheque.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Generar_Cheque.Location = new System.Drawing.Point(503, 144);
            this.btn_Generar_Cheque.Name = "btn_Generar_Cheque";
            this.btn_Generar_Cheque.Size = new System.Drawing.Size(56, 51);
            this.btn_Generar_Cheque.TabIndex = 115;
            this.btn_Generar_Cheque.UseVisualStyleBackColor = true;
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir.Location = new System.Drawing.Point(503, 198);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(56, 51);
            this.btn_imprimir.TabIndex = 116;
            this.btn_imprimir.UseVisualStyleBackColor = true;
            // 
            // Frm_Cheques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.btn_Generar_Cheque);
            this.Controls.Add(this.Btn_Cargar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Txt_Total);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_planilla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_Banco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Monto);
            this.Controls.Add(this.Lbl_Monto);
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

        private System.Windows.Forms.TextBox Txt_Total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_planilla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Banco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Monto;
        private System.Windows.Forms.Label Lbl_Monto;
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
    }
}