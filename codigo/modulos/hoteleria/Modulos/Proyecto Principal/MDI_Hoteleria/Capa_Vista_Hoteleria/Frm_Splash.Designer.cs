
namespace Capa_Vista_Hoteleria
{
    partial class Frm_Splash
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Lbl_Carga = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(75, 253);
            this.progressBar1.Maximum = 101;
            this.progressBar1.Minimum = 101;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(444, 18);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Value = 101;
            // 
            // Lbl_Carga
            // 
            this.Lbl_Carga.AutoSize = true;
            this.Lbl_Carga.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Carga.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Carga.Location = new System.Drawing.Point(283, 284);
            this.Lbl_Carga.Name = "Lbl_Carga";
            this.Lbl_Carga.Size = new System.Drawing.Size(43, 25);
            this.Lbl_Carga.TabIndex = 1;
            this.Lbl_Carga.Text = "0%";
            // 
            // Frm_Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Capa_Vista_Hoteleria.Properties.Resources.Splash;
            this.ClientSize = new System.Drawing.Size(600, 329);
            this.Controls.Add(this.Lbl_Carga);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Splash";
            this.Text = "Frm_Splash";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label Lbl_Carga;
    }
}