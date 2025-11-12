
namespace CapaVistaOP
{
    partial class Frm_menu_ordenes
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
            this.Pnl_Superior = new System.Windows.Forms.Panel();
            this.Lbl_Modulo_Hoteleria = new System.Windows.Forms.Label();
            this.Btn_Ordenes_Menu = new System.Windows.Forms.Button();
            this.Btn_Mobiliario = new System.Windows.Forms.Button();
            this.Btn_Ordenes_Produccion = new System.Windows.Forms.Button();
            this.Btn_Ordenes_Mobiliario = new System.Windows.Forms.Button();
            this.Pnl_Superior.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Superior
            // 
            this.Pnl_Superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(142)))), ((int)(((byte)(181)))));
            this.Pnl_Superior.Controls.Add(this.Lbl_Modulo_Hoteleria);
            this.Pnl_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Superior.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Superior.Name = "Pnl_Superior";
            this.Pnl_Superior.Size = new System.Drawing.Size(746, 111);
            this.Pnl_Superior.TabIndex = 100;
            // 
            // Lbl_Modulo_Hoteleria
            // 
            this.Lbl_Modulo_Hoteleria.AutoSize = true;
            this.Lbl_Modulo_Hoteleria.Font = new System.Drawing.Font("Rockwell", 18F);
            this.Lbl_Modulo_Hoteleria.Location = new System.Drawing.Point(231, 46);
            this.Lbl_Modulo_Hoteleria.Name = "Lbl_Modulo_Hoteleria";
            this.Lbl_Modulo_Hoteleria.Size = new System.Drawing.Size(252, 35);
            this.Lbl_Modulo_Hoteleria.TabIndex = 104;
            this.Lbl_Modulo_Hoteleria.Text = "Módulo hotelería";
            // 
            // Btn_Ordenes_Menu
            // 
            this.Btn_Ordenes_Menu.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ordenes_Menu.Location = new System.Drawing.Point(41, 218);
            this.Btn_Ordenes_Menu.Name = "Btn_Ordenes_Menu";
            this.Btn_Ordenes_Menu.Size = new System.Drawing.Size(140, 57);
            this.Btn_Ordenes_Menu.TabIndex = 101;
            this.Btn_Ordenes_Menu.Text = "Ordenes de menu";
            this.Btn_Ordenes_Menu.UseVisualStyleBackColor = true;
            this.Btn_Ordenes_Menu.Click += new System.EventHandler(this.ss_Click);
            // 
            // Btn_Mobiliario
            // 
            this.Btn_Mobiliario.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Mobiliario.Location = new System.Drawing.Point(207, 218);
            this.Btn_Mobiliario.Name = "Btn_Mobiliario";
            this.Btn_Mobiliario.Size = new System.Drawing.Size(119, 57);
            this.Btn_Mobiliario.TabIndex = 102;
            this.Btn_Mobiliario.Text = "Mobiliario";
            this.Btn_Mobiliario.UseVisualStyleBackColor = true;
            this.Btn_Mobiliario.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_Ordenes_Produccion
            // 
            this.Btn_Ordenes_Produccion.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ordenes_Produccion.Location = new System.Drawing.Point(346, 218);
            this.Btn_Ordenes_Produccion.Name = "Btn_Ordenes_Produccion";
            this.Btn_Ordenes_Produccion.Size = new System.Drawing.Size(145, 57);
            this.Btn_Ordenes_Produccion.TabIndex = 103;
            this.Btn_Ordenes_Produccion.Text = "Ordenes de producción";
            this.Btn_Ordenes_Produccion.UseVisualStyleBackColor = true;
            this.Btn_Ordenes_Produccion.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btn_Ordenes_Mobiliario
            // 
            this.Btn_Ordenes_Mobiliario.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ordenes_Mobiliario.Location = new System.Drawing.Point(517, 218);
            this.Btn_Ordenes_Mobiliario.Name = "Btn_Ordenes_Mobiliario";
            this.Btn_Ordenes_Mobiliario.Size = new System.Drawing.Size(149, 57);
            this.Btn_Ordenes_Mobiliario.TabIndex = 104;
            this.Btn_Ordenes_Mobiliario.Text = "Ordenes de mobiliario";
            this.Btn_Ordenes_Mobiliario.UseVisualStyleBackColor = true;
            this.Btn_Ordenes_Mobiliario.Click += new System.EventHandler(this.button3_Click);
            // 
            // Frm_menu_ordenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 471);
            this.Controls.Add(this.Btn_Ordenes_Mobiliario);
            this.Controls.Add(this.Btn_Ordenes_Produccion);
            this.Controls.Add(this.Btn_Mobiliario);
            this.Controls.Add(this.Btn_Ordenes_Menu);
            this.Controls.Add(this.Pnl_Superior);
            this.Name = "Frm_menu_ordenes";
            this.Text = "Frm_menu_ordenes";
            this.Pnl_Superior.ResumeLayout(false);
            this.Pnl_Superior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Superior;
        private System.Windows.Forms.Label Lbl_Modulo_Hoteleria;
        private System.Windows.Forms.Button Btn_Ordenes_Menu;
        private System.Windows.Forms.Button Btn_Mobiliario;
        private System.Windows.Forms.Button Btn_Ordenes_Produccion;
        private System.Windows.Forms.Button Btn_Ordenes_Mobiliario;
    }
}