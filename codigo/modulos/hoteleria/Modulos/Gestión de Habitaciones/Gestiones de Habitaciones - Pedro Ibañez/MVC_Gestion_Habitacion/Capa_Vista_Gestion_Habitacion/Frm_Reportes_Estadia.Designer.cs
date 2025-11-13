
namespace Capa_Vista_Gestion_Habitacion
{
    partial class Frm_Reportes_Estadia
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Rpt_Estadia2 = new Capa_Vista_Gestion_Habitacion.Rpt_Estadia();
            this.Rpt_Estadia1 = new Capa_Vista_Gestion_Habitacion.Rpt_Estadia();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.Rpt_Estadia2;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1304, 576);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // Frm_Reportes_Estadia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 576);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "Frm_Reportes_Estadia";
            this.Text = "Frm_Reportes_Estadia";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private Rpt_Estadia Rpt_Estadia1;
        private Rpt_Estadia Rpt_Estadia2;
    }
}