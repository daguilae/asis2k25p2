
namespace Capa_Vista_Cheques
{
    partial class Frm_Proveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Proveedores));
            this.Txt_Valor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_debe_haber = new System.Windows.Forms.TextBox();
            this.Txt_nombre_banco = new System.Windows.Forms.TextBox();
            this.Txt_Cuenta_Contable = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_Generar_Cheque = new System.Windows.Forms.Button();
            this.Btn_Cargar = new System.Windows.Forms.Button();
            this.dgv_Cheques = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cmb_CodigoCuenta = new System.Windows.Forms.ComboBox();
            this.dtp_FechaPago = new System.Windows.Forms.DateTimePicker();
            this.txt_lote = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cheques)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Valor
            // 
            this.Txt_Valor.Location = new System.Drawing.Point(616, 315);
            this.Txt_Valor.Name = "Txt_Valor";
            this.Txt_Valor.Size = new System.Drawing.Size(143, 22);
            this.Txt_Valor.TabIndex = 145;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(612, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 24);
            this.label7.TabIndex = 144;
            this.label7.Text = "Valor:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(446, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 24);
            this.label6.TabIndex = 143;
            this.label6.Text = "D/H:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(255, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 24);
            this.label5.TabIndex = 142;
            this.label5.Text = "Nombre";
            // 
            // Txt_debe_haber
            // 
            this.Txt_debe_haber.Location = new System.Drawing.Point(439, 315);
            this.Txt_debe_haber.Name = "Txt_debe_haber";
            this.Txt_debe_haber.Size = new System.Drawing.Size(143, 22);
            this.Txt_debe_haber.TabIndex = 141;
            // 
            // Txt_nombre_banco
            // 
            this.Txt_nombre_banco.Location = new System.Drawing.Point(259, 315);
            this.Txt_nombre_banco.Name = "Txt_nombre_banco";
            this.Txt_nombre_banco.Size = new System.Drawing.Size(143, 22);
            this.Txt_nombre_banco.TabIndex = 140;
            // 
            // Txt_Cuenta_Contable
            // 
            this.Txt_Cuenta_Contable.Location = new System.Drawing.Point(30, 315);
            this.Txt_Cuenta_Contable.Name = "Txt_Cuenta_Contable";
            this.Txt_Cuenta_Contable.Size = new System.Drawing.Size(162, 22);
            this.Txt_Cuenta_Contable.TabIndex = 139;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 24);
            this.label4.TabIndex = 138;
            this.label4.Text = "Cuenta Contable:";
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir.Image = ((System.Drawing.Image)(resources.GetObject("btn_imprimir.Image")));
            this.btn_imprimir.Location = new System.Drawing.Point(786, 19);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(56, 51);
            this.btn_imprimir.TabIndex = 137;
            this.btn_imprimir.UseVisualStyleBackColor = true;
            // 
            // btn_Generar_Cheque
            // 
            this.btn_Generar_Cheque.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Generar_Cheque.Image = ((System.Drawing.Image)(resources.GetObject("btn_Generar_Cheque.Image")));
            this.btn_Generar_Cheque.Location = new System.Drawing.Point(724, 19);
            this.btn_Generar_Cheque.Name = "btn_Generar_Cheque";
            this.btn_Generar_Cheque.Size = new System.Drawing.Size(56, 51);
            this.btn_Generar_Cheque.TabIndex = 136;
            this.btn_Generar_Cheque.UseVisualStyleBackColor = true;
            this.btn_Generar_Cheque.Click += new System.EventHandler(this.btn_Generar_Cheque_Click);
            // 
            // Btn_Cargar
            // 
            this.Btn_Cargar.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cargar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cargar.Image")));
            this.Btn_Cargar.Location = new System.Drawing.Point(662, 19);
            this.Btn_Cargar.Name = "Btn_Cargar";
            this.Btn_Cargar.Size = new System.Drawing.Size(56, 51);
            this.Btn_Cargar.TabIndex = 135;
            this.Btn_Cargar.UseVisualStyleBackColor = true;
            this.Btn_Cargar.Click += new System.EventHandler(this.Btn_Cargar_Click);
            // 
            // dgv_Cheques
            // 
            this.dgv_Cheques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Cheques.Location = new System.Drawing.Point(29, 355);
            this.dgv_Cheques.Name = "dgv_Cheques";
            this.dgv_Cheques.RowHeadersWidth = 51;
            this.dgv_Cheques.RowTemplate.Height = 24;
            this.dgv_Cheques.Size = new System.Drawing.Size(824, 162);
            this.dgv_Cheques.TabIndex = 134;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 130;
            this.label1.Text = "Banco Cuenta:";
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha.Location = new System.Drawing.Point(26, 76);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(145, 24);
            this.Lbl_Fecha.TabIndex = 126;
            this.Lbl_Fecha.Text = "Fecha de pago:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(440, 31);
            this.label2.TabIndex = 125;
            this.label2.Text = "Generacion de Cheques Proveedores";
            // 
            // Cmb_CodigoCuenta
            // 
            this.Cmb_CodigoCuenta.FormattingEnabled = true;
            this.Cmb_CodigoCuenta.Location = new System.Drawing.Point(205, 129);
            this.Cmb_CodigoCuenta.Name = "Cmb_CodigoCuenta";
            this.Cmb_CodigoCuenta.Size = new System.Drawing.Size(554, 24);
            this.Cmb_CodigoCuenta.TabIndex = 146;
            // 
            // dtp_FechaPago
            // 
            this.dtp_FechaPago.Location = new System.Drawing.Point(205, 76);
            this.dtp_FechaPago.Name = "dtp_FechaPago";
            this.dtp_FechaPago.Size = new System.Drawing.Size(266, 22);
            this.dtp_FechaPago.TabIndex = 147;
            // 
            // txt_lote
            // 
            this.txt_lote.Location = new System.Drawing.Point(30, 201);
            this.txt_lote.Name = "txt_lote";
            this.txt_lote.Size = new System.Drawing.Size(162, 22);
            this.txt_lote.TabIndex = 148;
            // 
            // Frm_Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 567);
            this.Controls.Add(this.txt_lote);
            this.Controls.Add(this.dtp_FechaPago);
            this.Controls.Add(this.Cmb_CodigoCuenta);
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
            this.Controls.Add(this.dgv_Cheques);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_Fecha);
            this.Controls.Add(this.label2);
            this.Name = "Frm_Proveedores";
            this.Text = "Frm_Proveedores";
            this.Load += new System.EventHandler(this.Frm_Proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cheques)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Valor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_debe_haber;
        private System.Windows.Forms.TextBox Txt_nombre_banco;
        private System.Windows.Forms.TextBox Txt_Cuenta_Contable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_Generar_Cheque;
        private System.Windows.Forms.Button Btn_Cargar;
        private System.Windows.Forms.DataGridView dgv_Cheques;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Fecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cmb_CodigoCuenta;
        private System.Windows.Forms.DateTimePicker dtp_FechaPago;
        private System.Windows.Forms.TextBox txt_lote;
    }
}