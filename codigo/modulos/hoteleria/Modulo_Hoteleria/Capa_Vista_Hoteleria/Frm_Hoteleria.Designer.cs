
namespace Capa_Vista_Hoteleria
{
    partial class Frm_Hoteleria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Hoteleria));
            this.Lbl_Hotel = new System.Windows.Forms.Label();
            this.Pic_Hotel = new System.Windows.Forms.PictureBox();
            this.Pic_Hotel2 = new System.Windows.Forms.PictureBox();
            this.Pnl_panel_color = new System.Windows.Forms.Panel();
            this.Msp_hoteleria = new System.Windows.Forms.MenuStrip();
            this.salonesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservacionesDeSalonesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeSalonesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesDeProduccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recetasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesoDeProduccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.implosionDeMatarialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.explosionDeMaterialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoHoteleriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Hotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Hotel2)).BeginInit();
            this.Pnl_panel_color.SuspendLayout();
            this.Msp_hoteleria.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Hotel
            // 
            this.Lbl_Hotel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Hotel.AutoSize = true;
            this.Lbl_Hotel.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lbl_Hotel.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Hotel.Location = new System.Drawing.Point(388, 51);
            this.Lbl_Hotel.Name = "Lbl_Hotel";
            this.Lbl_Hotel.Size = new System.Drawing.Size(196, 27);
            this.Lbl_Hotel.TabIndex = 0;
            this.Lbl_Hotel.Text = "Hotel San Carlos";
            this.Lbl_Hotel.Click += new System.EventHandler(this.Lbl_Hotel_Click);
            // 
            // Pic_Hotel
            // 
            this.Pic_Hotel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Pic_Hotel.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Hotel.Image")));
            this.Pic_Hotel.Location = new System.Drawing.Point(324, 33);
            this.Pic_Hotel.Name = "Pic_Hotel";
            this.Pic_Hotel.Size = new System.Drawing.Size(58, 57);
            this.Pic_Hotel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Hotel.TabIndex = 2;
            this.Pic_Hotel.TabStop = false;
            // 
            // Pic_Hotel2
            // 
            this.Pic_Hotel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Pic_Hotel2.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Hotel2.Image")));
            this.Pic_Hotel2.Location = new System.Drawing.Point(590, 33);
            this.Pic_Hotel2.Name = "Pic_Hotel2";
            this.Pic_Hotel2.Size = new System.Drawing.Size(58, 57);
            this.Pic_Hotel2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Hotel2.TabIndex = 30;
            this.Pic_Hotel2.TabStop = false;
            // 
            // Pnl_panel_color
            // 
            this.Pnl_panel_color.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_panel_color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(142)))), ((int)(((byte)(181)))));
            this.Pnl_panel_color.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pnl_panel_color.Controls.Add(this.Msp_hoteleria);
            this.Pnl_panel_color.Controls.Add(this.Pic_Hotel2);
            this.Pnl_panel_color.Controls.Add(this.Pic_Hotel);
            this.Pnl_panel_color.Controls.Add(this.Lbl_Hotel);
            this.Pnl_panel_color.Location = new System.Drawing.Point(1, 2);
            this.Pnl_panel_color.Name = "Pnl_panel_color";
            this.Pnl_panel_color.Size = new System.Drawing.Size(973, 161);
            this.Pnl_panel_color.TabIndex = 0;
            // 
            // Msp_hoteleria
            // 
            this.Msp_hoteleria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(142)))), ((int)(((byte)(181)))));
            this.Msp_hoteleria.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Msp_hoteleria.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salonesToolStripMenuItem,
            this.ordenesDeProduccionToolStripMenuItem,
            this.recetasToolStripMenuItem,
            this.procesoDeProduccionToolStripMenuItem,
            this.materialesToolStripMenuItem,
            this.mantenimientoHoteleriaToolStripMenuItem});
            this.Msp_hoteleria.Location = new System.Drawing.Point(0, 0);
            this.Msp_hoteleria.Name = "Msp_hoteleria";
            this.Msp_hoteleria.Size = new System.Drawing.Size(969, 24);
            this.Msp_hoteleria.TabIndex = 31;
            this.Msp_hoteleria.Text = "menuStrip1";
            // 
            // salonesToolStripMenuItem
            // 
            this.salonesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservacionesDeSalonesToolStripMenuItem,
            this.gestionDeSalonesToolStripMenuItem});
            this.salonesToolStripMenuItem.Name = "salonesToolStripMenuItem";
            this.salonesToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.salonesToolStripMenuItem.Text = "Salones";
            // 
            // reservacionesDeSalonesToolStripMenuItem
            // 
            this.reservacionesDeSalonesToolStripMenuItem.Name = "reservacionesDeSalonesToolStripMenuItem";
            this.reservacionesDeSalonesToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.reservacionesDeSalonesToolStripMenuItem.Text = "Reservaciones de Salones ";
            this.reservacionesDeSalonesToolStripMenuItem.Click += new System.EventHandler(this.reservacionesDeSalonesToolStripMenuItem_Click_1);
            // 
            // gestionDeSalonesToolStripMenuItem
            // 
            this.gestionDeSalonesToolStripMenuItem.Name = "gestionDeSalonesToolStripMenuItem";
            this.gestionDeSalonesToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.gestionDeSalonesToolStripMenuItem.Text = "Gestion de Salones";
            this.gestionDeSalonesToolStripMenuItem.Click += new System.EventHandler(this.gestionDeSalonesToolStripMenuItem_Click_1);
            // 
            // ordenesDeProduccionToolStripMenuItem
            // 
            this.ordenesDeProduccionToolStripMenuItem.Name = "ordenesDeProduccionToolStripMenuItem";
            this.ordenesDeProduccionToolStripMenuItem.Size = new System.Drawing.Size(160, 20);
            this.ordenesDeProduccionToolStripMenuItem.Text = "Ordenes De Produccion ";
            // 
            // recetasToolStripMenuItem
            // 
            this.recetasToolStripMenuItem.Name = "recetasToolStripMenuItem";
            this.recetasToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.recetasToolStripMenuItem.Text = "Recetas";
            // 
            // procesoDeProduccionToolStripMenuItem
            // 
            this.procesoDeProduccionToolStripMenuItem.Name = "procesoDeProduccionToolStripMenuItem";
            this.procesoDeProduccionToolStripMenuItem.Size = new System.Drawing.Size(153, 20);
            this.procesoDeProduccionToolStripMenuItem.Text = "Proceso De Produccion";
            // 
            // materialesToolStripMenuItem
            // 
            this.materialesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.implosionDeMatarialesToolStripMenuItem,
            this.explosionDeMaterialesToolStripMenuItem});
            this.materialesToolStripMenuItem.Name = "materialesToolStripMenuItem";
            this.materialesToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.materialesToolStripMenuItem.Text = "Materiales";
            // 
            // implosionDeMatarialesToolStripMenuItem
            // 
            this.implosionDeMatarialesToolStripMenuItem.Name = "implosionDeMatarialesToolStripMenuItem";
            this.implosionDeMatarialesToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.implosionDeMatarialesToolStripMenuItem.Text = "Implosion De Matariales ";
            // 
            // explosionDeMaterialesToolStripMenuItem
            // 
            this.explosionDeMaterialesToolStripMenuItem.Name = "explosionDeMaterialesToolStripMenuItem";
            this.explosionDeMaterialesToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.explosionDeMaterialesToolStripMenuItem.Text = "Explosion De Materiales ";
            // 
            // mantenimientoHoteleriaToolStripMenuItem
            // 
            this.mantenimientoHoteleriaToolStripMenuItem.Name = "mantenimientoHoteleriaToolStripMenuItem";
            this.mantenimientoHoteleriaToolStripMenuItem.Size = new System.Drawing.Size(160, 20);
            this.mantenimientoHoteleriaToolStripMenuItem.Text = "Mantenimiento Hoteleria";
            // 
            // Frm_Hoteleria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 558);
            this.Controls.Add(this.Pnl_panel_color);
            this.Name = "Frm_Hoteleria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Hoteleria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Hotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Hotel2)).EndInit();
            this.Pnl_panel_color.ResumeLayout(false);
            this.Pnl_panel_color.PerformLayout();
            this.Msp_hoteleria.ResumeLayout(false);
            this.Msp_hoteleria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Lbl_Hotel;
        private System.Windows.Forms.PictureBox Pic_Hotel;
        private System.Windows.Forms.PictureBox Pic_Hotel2;
        private System.Windows.Forms.Panel Pnl_panel_color;
        private System.Windows.Forms.MenuStrip Msp_hoteleria;
        private System.Windows.Forms.ToolStripMenuItem salonesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservacionesDeSalonesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeSalonesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenesDeProduccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recetasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesoDeProduccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem implosionDeMatarialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem explosionDeMaterialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoHoteleriaToolStripMenuItem;
    }
}