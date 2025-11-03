
namespace Capa_Vista_TipoDeCambio
{
    partial class Frm_TipoDeCambio
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
            this.Lbl_Historico = new System.Windows.Forms.Label();
            this.Dgv_TipoDeCambio = new System.Windows.Forms.DataGridView();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.Txt_Fecha = new System.Windows.Forms.TextBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_TipoDeCambio)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_Buscar);
            this.panel1.Controls.Add(this.Txt_Fecha);
            this.panel1.Controls.Add(this.Lbl_Fecha);
            this.panel1.Controls.Add(this.Dgv_TipoDeCambio);
            this.panel1.Controls.Add(this.Lbl_Historico);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 486);
            this.panel1.TabIndex = 0;
            // 
            // Lbl_Historico
            // 
            this.Lbl_Historico.AutoSize = true;
            this.Lbl_Historico.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Historico.Location = new System.Drawing.Point(240, 11);
            this.Lbl_Historico.Name = "Lbl_Historico";
            this.Lbl_Historico.Size = new System.Drawing.Size(301, 27);
            this.Lbl_Historico.TabIndex = 0;
            this.Lbl_Historico.Text = "Historico Tipo De Cambio";
            // 
            // Dgv_TipoDeCambio
            // 
            this.Dgv_TipoDeCambio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_TipoDeCambio.Location = new System.Drawing.Point(13, 96);
            this.Dgv_TipoDeCambio.Name = "Dgv_TipoDeCambio";
            this.Dgv_TipoDeCambio.Size = new System.Drawing.Size(780, 376);
            this.Dgv_TipoDeCambio.TabIndex = 1;
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha.Location = new System.Drawing.Point(132, 59);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(107, 17);
            this.Lbl_Fecha.TabIndex = 2;
            this.Lbl_Fecha.Text = "Ingresa fecha:";
            // 
            // Txt_Fecha
            // 
            this.Txt_Fecha.Location = new System.Drawing.Point(245, 59);
            this.Txt_Fecha.Name = "Txt_Fecha";
            this.Txt_Fecha.Size = new System.Drawing.Size(209, 20);
            this.Txt_Fecha.TabIndex = 3;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buscar.Location = new System.Drawing.Point(528, 50);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(83, 29);
            this.Btn_Buscar.TabIndex = 4;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Frm_TipoDeCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_TipoDeCambio";
            this.Text = "Frm_TipoDeCambio";
            this.Load += new System.EventHandler(this.Frm_TipoDeCambio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_TipoDeCambio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.TextBox Txt_Fecha;
        private System.Windows.Forms.Label Lbl_Fecha;
        private System.Windows.Forms.DataGridView Dgv_TipoDeCambio;
        private System.Windows.Forms.Label Lbl_Historico;
    }
}