namespace Capa_Vista_Comercial
{
    partial class Frm_Slash
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.PictureBox Pic_Logo_Modulo_Comercial;
        private System.Windows.Forms.ProgressBar Pgb_Carga;
        private System.Windows.Forms.Label Lbl_Porcentaje;
        private System.Windows.Forms.Timer Tmr_Carga;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Pgb_Carga = new System.Windows.Forms.ProgressBar();
            this.Lbl_Porcentaje = new System.Windows.Forms.Label();
            this.Tmr_Carga = new System.Windows.Forms.Timer(this.components);
            this.Pic_Logo_Empresa = new System.Windows.Forms.PictureBox();
            this.Pic_Logo_Modulo_Comercial = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Logo_Empresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Logo_Modulo_Comercial)).BeginInit();
            this.SuspendLayout();
            // 
            // Pgb_Carga
            // 
            this.Pgb_Carga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Pgb_Carga.Location = new System.Drawing.Point(139, 274);
            this.Pgb_Carga.Name = "Pgb_Carga";
            this.Pgb_Carga.Size = new System.Drawing.Size(540, 24);
            this.Pgb_Carga.TabIndex = 1;
            // 
            // Lbl_Porcentaje
            // 
            this.Lbl_Porcentaje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl_Porcentaje.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Lbl_Porcentaje.Location = new System.Drawing.Point(139, 302);
            this.Lbl_Porcentaje.Name = "Lbl_Porcentaje";
            this.Lbl_Porcentaje.Size = new System.Drawing.Size(540, 22);
            this.Lbl_Porcentaje.TabIndex = 2;
            this.Lbl_Porcentaje.Text = "0%";
            this.Lbl_Porcentaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tmr_Carga
            // 
            this.Tmr_Carga.Tick += new System.EventHandler(this.Tmr_Carga_Tick);
            // 
            // Pic_Logo_Empresa
            // 
            this.Pic_Logo_Empresa.Location = new System.Drawing.Point(12, 12);
            this.Pic_Logo_Empresa.Name = "Pic_Logo_Empresa";
            this.Pic_Logo_Empresa.Size = new System.Drawing.Size(212, 57);
            this.Pic_Logo_Empresa.TabIndex = 3;
            this.Pic_Logo_Empresa.TabStop = false;
            // 
            // Pic_Logo_Modulo_Comercial
            // 
            this.Pic_Logo_Modulo_Comercial.Location = new System.Drawing.Point(220, 75);
            this.Pic_Logo_Modulo_Comercial.Name = "Pic_Logo_Modulo_Comercial";
            this.Pic_Logo_Modulo_Comercial.Size = new System.Drawing.Size(370, 193);
            this.Pic_Logo_Modulo_Comercial.TabIndex = 0;
            this.Pic_Logo_Modulo_Comercial.TabStop = false;
            // 
            // Frm_Slash
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(820, 420);
            this.Controls.Add(this.Pic_Logo_Empresa);
            this.Controls.Add(this.Lbl_Porcentaje);
            this.Controls.Add(this.Pgb_Carga);
            this.Controls.Add(this.Pic_Logo_Modulo_Comercial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Slash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.Load += new System.EventHandler(this.Frm_Slash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Logo_Empresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Logo_Modulo_Comercial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Pic_Logo_Empresa;
    }
}
