
namespace CapaVista_CPR
{
    partial class Frm_Reportes_Hoteleria
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
            this.lbl_Reportes_hotel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Reportes_hotel
            // 
            this.lbl_Reportes_hotel.AutoSize = true;
            this.lbl_Reportes_hotel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.lbl_Reportes_hotel.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Reportes_hotel.Location = new System.Drawing.Point(29, 24);
            this.lbl_Reportes_hotel.Name = "lbl_Reportes_hotel";
            this.lbl_Reportes_hotel.Size = new System.Drawing.Size(275, 35);
            this.lbl_Reportes_hotel.TabIndex = 3;
            this.lbl_Reportes_hotel.Text = "Reportes Hoteleria";
            // 
            // Frm_Reportes_Hoteleria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Reportes_hotel);
            this.Name = "Frm_Reportes_Hoteleria";
            this.Text = "Frm_Reportes_Hoteleria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Reportes_hotel;
    }
}