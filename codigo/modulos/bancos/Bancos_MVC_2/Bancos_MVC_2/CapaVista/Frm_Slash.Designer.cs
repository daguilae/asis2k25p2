
namespace Capa_Vista_Bancos
{
    partial class Frm_Slash
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
            this.components = new System.ComponentModel.Container();
            this.Lbl_carga = new System.Windows.Forms.Label();
            this.Tmr_carga = new System.Windows.Forms.Timer(this.components);
            this.Pgb_carga = new System.Windows.Forms.ProgressBar();
            this.Pic_carga = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_carga)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_carga
            // 
            this.Lbl_carga.AutoSize = true;
            this.Lbl_carga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.Lbl_carga.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold);
            this.Lbl_carga.Location = new System.Drawing.Point(373, 292);
            this.Lbl_carga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_carga.Name = "Lbl_carga";
            this.Lbl_carga.Size = new System.Drawing.Size(50, 30);
            this.Lbl_carga.TabIndex = 0;
            this.Lbl_carga.Text = "0%";
            // 
            // Tmr_carga
            // 
            this.Tmr_carga.Enabled = true;
            this.Tmr_carga.Tick += new System.EventHandler(this.Tmr_carga_Tick);
            // 
            // Pgb_carga
            // 
            this.Pgb_carga.Location = new System.Drawing.Point(95, 245);
            this.Pgb_carga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Pgb_carga.Maximum = 101;
            this.Pgb_carga.Name = "Pgb_carga";
            this.Pgb_carga.Size = new System.Drawing.Size(600, 43);
            this.Pgb_carga.TabIndex = 1;
            // 
            // Pic_carga
            // 
            this.Pic_carga.BackColor = System.Drawing.Color.Transparent;
            this.Pic_carga.Image = global::Capa_Vista_Bancos.Properties.Resources.Bancos;
            this.Pic_carga.Location = new System.Drawing.Point(45, 46);
            this.Pic_carga.Margin = new System.Windows.Forms.Padding(4);
            this.Pic_carga.Name = "Pic_carga";
            this.Pic_carga.Size = new System.Drawing.Size(650, 265);
            this.Pic_carga.TabIndex = 2;
            this.Pic_carga.TabStop = false;
            // 
            // Frm_Slash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 324);
            this.Controls.Add(this.Pgb_carga);
            this.Controls.Add(this.Lbl_carga);
            this.Controls.Add(this.Pic_carga);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_Slash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSlash";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_carga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_carga;
        private System.Windows.Forms.Timer Tmr_carga;
        private System.Windows.Forms.ProgressBar Pgb_carga;
        private System.Windows.Forms.PictureBox Pic_carga;
    }
}