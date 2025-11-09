
namespace Capa_Vista_TipoDeCambio
{
    partial class Frm_DisponibilidadDiaria
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
            this.Txt_NumeroDeCuenta = new System.Windows.Forms.TextBox();
            this.Lbl_NumeroDeCuenta = new System.Windows.Forms.Label();
            this.Dgv_DisponibilidaadDiaria = new System.Windows.Forms.DataGridView();
            this.Banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_De_Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_De_Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disponibilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Cbo_TipoDeCuenta = new System.Windows.Forms.ComboBox();
            this.Cbo_Banco = new System.Windows.Forms.ComboBox();
            this.Lbl_TipoDeCuenta = new System.Windows.Forms.Label();
            this.Lbl_Banco = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_DisponibilidaadDiaria)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Txt_NumeroDeCuenta);
            this.panel1.Controls.Add(this.Lbl_NumeroDeCuenta);
            this.panel1.Controls.Add(this.Dgv_DisponibilidaadDiaria);
            this.panel1.Controls.Add(this.Btn_Buscar);
            this.panel1.Controls.Add(this.Cbo_TipoDeCuenta);
            this.panel1.Controls.Add(this.Cbo_Banco);
            this.panel1.Controls.Add(this.Lbl_TipoDeCuenta);
            this.panel1.Controls.Add(this.Lbl_Banco);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 542);
            this.panel1.TabIndex = 0;
            // 
            // Txt_NumeroDeCuenta
            // 
            this.Txt_NumeroDeCuenta.Location = new System.Drawing.Point(176, 138);
            this.Txt_NumeroDeCuenta.Name = "Txt_NumeroDeCuenta";
            this.Txt_NumeroDeCuenta.Size = new System.Drawing.Size(157, 20);
            this.Txt_NumeroDeCuenta.TabIndex = 8;
            this.Txt_NumeroDeCuenta.TextChanged += new System.EventHandler(this.Txt_NumeroDeCuenta_TextChanged);
            // 
            // Lbl_NumeroDeCuenta
            // 
            this.Lbl_NumeroDeCuenta.AutoSize = true;
            this.Lbl_NumeroDeCuenta.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NumeroDeCuenta.Location = new System.Drawing.Point(27, 138);
            this.Lbl_NumeroDeCuenta.Name = "Lbl_NumeroDeCuenta";
            this.Lbl_NumeroDeCuenta.Size = new System.Drawing.Size(143, 17);
            this.Lbl_NumeroDeCuenta.TabIndex = 7;
            this.Lbl_NumeroDeCuenta.Text = "Numero de cuenta:";
            // 
            // Dgv_DisponibilidaadDiaria
            // 
            this.Dgv_DisponibilidaadDiaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_DisponibilidaadDiaria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Banco,
            this.Tipo_De_Cuenta,
            this.Numero_De_Cuenta,
            this.Disponibilidad});
            this.Dgv_DisponibilidaadDiaria.Location = new System.Drawing.Point(41, 203);
            this.Dgv_DisponibilidaadDiaria.Name = "Dgv_DisponibilidaadDiaria";
            this.Dgv_DisponibilidaadDiaria.Size = new System.Drawing.Size(445, 323);
            this.Dgv_DisponibilidaadDiaria.TabIndex = 6;
            // 
            // Banco
            // 
            this.Banco.HeaderText = "Banco";
            this.Banco.Name = "Banco";
            this.Banco.ReadOnly = true;
            // 
            // Tipo_De_Cuenta
            // 
            this.Tipo_De_Cuenta.HeaderText = "Tipo De Cuenta";
            this.Tipo_De_Cuenta.Name = "Tipo_De_Cuenta";
            this.Tipo_De_Cuenta.ReadOnly = true;
            // 
            // Numero_De_Cuenta
            // 
            this.Numero_De_Cuenta.HeaderText = "Numero De cuenta";
            this.Numero_De_Cuenta.Name = "Numero_De_Cuenta";
            this.Numero_De_Cuenta.ReadOnly = true;
            // 
            // Disponibilidad
            // 
            this.Disponibilidad.HeaderText = "Disponibilidad";
            this.Disponibilidad.Name = "Disponibilidad";
            this.Disponibilidad.ReadOnly = true;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buscar.Location = new System.Drawing.Point(373, 85);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(113, 46);
            this.Btn_Buscar.TabIndex = 5;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Cbo_TipoDeCuenta
            // 
            this.Cbo_TipoDeCuenta.FormattingEnabled = true;
            this.Cbo_TipoDeCuenta.Location = new System.Drawing.Point(176, 99);
            this.Cbo_TipoDeCuenta.Name = "Cbo_TipoDeCuenta";
            this.Cbo_TipoDeCuenta.Size = new System.Drawing.Size(157, 21);
            this.Cbo_TipoDeCuenta.TabIndex = 4;
            // 
            // Cbo_Banco
            // 
            this.Cbo_Banco.FormattingEnabled = true;
            this.Cbo_Banco.Location = new System.Drawing.Point(176, 63);
            this.Cbo_Banco.Name = "Cbo_Banco";
            this.Cbo_Banco.Size = new System.Drawing.Size(157, 21);
            this.Cbo_Banco.TabIndex = 3;
            // 
            // Lbl_TipoDeCuenta
            // 
            this.Lbl_TipoDeCuenta.AutoSize = true;
            this.Lbl_TipoDeCuenta.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TipoDeCuenta.Location = new System.Drawing.Point(47, 99);
            this.Lbl_TipoDeCuenta.Name = "Lbl_TipoDeCuenta";
            this.Lbl_TipoDeCuenta.Size = new System.Drawing.Size(123, 17);
            this.Lbl_TipoDeCuenta.TabIndex = 2;
            this.Lbl_TipoDeCuenta.Text = "Tipo De Cuenta:";
            // 
            // Lbl_Banco
            // 
            this.Lbl_Banco.AutoSize = true;
            this.Lbl_Banco.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Banco.Location = new System.Drawing.Point(115, 63);
            this.Lbl_Banco.Name = "Lbl_Banco";
            this.Lbl_Banco.Size = new System.Drawing.Size(55, 17);
            this.Lbl_Banco.TabIndex = 1;
            this.Lbl_Banco.Text = "Banco:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Disponibilidad Diaria";
            // 
            // Frm_DisponibilidadDiaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 567);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_DisponibilidadDiaria";
            this.Text = "Frm_DisponibilidadDiaria";
            this.Load += new System.EventHandler(this.Frm_DisponibilidadDiaria_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_DisponibilidaadDiaria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Txt_NumeroDeCuenta;
        private System.Windows.Forms.Label Lbl_NumeroDeCuenta;
        private System.Windows.Forms.DataGridView Dgv_DisponibilidaadDiaria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Banco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_De_Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_De_Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disponibilidad;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.ComboBox Cbo_TipoDeCuenta;
        private System.Windows.Forms.ComboBox Cbo_Banco;
        private System.Windows.Forms.Label Lbl_TipoDeCuenta;
        private System.Windows.Forms.Label Lbl_Banco;
        private System.Windows.Forms.Label label1;
    }
}