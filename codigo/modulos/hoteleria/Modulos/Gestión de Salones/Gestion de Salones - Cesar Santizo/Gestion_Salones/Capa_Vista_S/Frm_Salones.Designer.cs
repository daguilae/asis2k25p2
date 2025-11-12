
namespace Capa_Vista_S
{
    partial class Frm_Salones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Salones));
            this.Txt_capacidad = new System.Windows.Forms.TextBox();
            this.Txt_ubicacion = new System.Windows.Forms.TextBox();
            this.Btn_modificar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Lbl_Capacidad = new System.Windows.Forms.Label();
            this.Lbl_Ubicacion = new System.Windows.Forms.Label();
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Lbl_Salones = new System.Windows.Forms.Label();
            this.Dvg_Salones = new System.Windows.Forms.DataGridView();
            this.Lbl_Disponibilidad = new System.Windows.Forms.Label();
            this.Chk_disponibilidad = new System.Windows.Forms.CheckBox();
            this.Pnl_Superior = new System.Windows.Forms.Panel();
            this.Lbl_Hoteleria = new System.Windows.Forms.Label();
            this.Msp_Menu = new System.Windows.Forms.MenuStrip();
            this.salonesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Dvg_Salones)).BeginInit();
            this.Pnl_Superior.SuspendLayout();
            this.Msp_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt_capacidad
            // 
            this.Txt_capacidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_capacidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_capacidad.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Txt_capacidad.Location = new System.Drawing.Point(627, 150);
            this.Txt_capacidad.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_capacidad.Name = "Txt_capacidad";
            this.Txt_capacidad.Size = new System.Drawing.Size(178, 23);
            this.Txt_capacidad.TabIndex = 111;
            // 
            // Txt_ubicacion
            // 
            this.Txt_ubicacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_ubicacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_ubicacion.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Txt_ubicacion.Location = new System.Drawing.Point(206, 201);
            this.Txt_ubicacion.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_ubicacion.Name = "Txt_ubicacion";
            this.Txt_ubicacion.Size = new System.Drawing.Size(178, 23);
            this.Txt_ubicacion.TabIndex = 110;
            // 
            // Btn_modificar
            // 
            this.Btn_modificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_modificar.BackColor = System.Drawing.Color.White;
            this.Btn_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_modificar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_modificar.Image")));
            this.Btn_modificar.Location = new System.Drawing.Point(868, 83);
            this.Btn_modificar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_modificar.Name = "Btn_modificar";
            this.Btn_modificar.Size = new System.Drawing.Size(40, 37);
            this.Btn_modificar.TabIndex = 109;
            this.Btn_modificar.UseVisualStyleBackColor = false;
            this.Btn_modificar.Click += new System.EventHandler(this.Btn_modificar_Click);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_eliminar.BackColor = System.Drawing.Color.White;
            this.Btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_eliminar.Image")));
            this.Btn_eliminar.Location = new System.Drawing.Point(824, 83);
            this.Btn_eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(40, 37);
            this.Btn_eliminar.TabIndex = 108;
            this.Btn_eliminar.UseVisualStyleBackColor = false;
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_guardar.BackColor = System.Drawing.Color.White;
            this.Btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_guardar.Image")));
            this.Btn_guardar.Location = new System.Drawing.Point(780, 83);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(40, 37);
            this.Btn_guardar.TabIndex = 107;
            this.Btn_guardar.UseVisualStyleBackColor = false;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Lbl_Capacidad
            // 
            this.Lbl_Capacidad.AutoSize = true;
            this.Lbl_Capacidad.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lbl_Capacidad.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Lbl_Capacidad.Location = new System.Drawing.Point(443, 150);
            this.Lbl_Capacidad.Name = "Lbl_Capacidad";
            this.Lbl_Capacidad.Size = new System.Drawing.Size(165, 17);
            this.Lbl_Capacidad.TabIndex = 106;
            this.Lbl_Capacidad.Text = "Capacidad de personas ";
            // 
            // Lbl_Ubicacion
            // 
            this.Lbl_Ubicacion.AutoSize = true;
            this.Lbl_Ubicacion.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lbl_Ubicacion.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Lbl_Ubicacion.Location = new System.Drawing.Point(22, 201);
            this.Lbl_Ubicacion.Name = "Lbl_Ubicacion";
            this.Lbl_Ubicacion.Size = new System.Drawing.Size(71, 17);
            this.Lbl_Ubicacion.TabIndex = 105;
            this.Lbl_Ubicacion.Text = "Ubicacion";
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lbl_Nombre.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Lbl_Nombre.Location = new System.Drawing.Point(21, 150);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(125, 17);
            this.Lbl_Nombre.TabIndex = 104;
            this.Lbl_Nombre.Text = "Nombre Del Salon";
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Nombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Nombre.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Txt_Nombre.Location = new System.Drawing.Point(206, 148);
            this.Txt_Nombre.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(178, 23);
            this.Txt_Nombre.TabIndex = 103;
            // 
            // Lbl_Salones
            // 
            this.Lbl_Salones.AutoSize = true;
            this.Lbl_Salones.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lbl_Salones.Font = new System.Drawing.Font("Rockwell", 18F);
            this.Lbl_Salones.Location = new System.Drawing.Point(19, 93);
            this.Lbl_Salones.Name = "Lbl_Salones";
            this.Lbl_Salones.Size = new System.Drawing.Size(184, 27);
            this.Lbl_Salones.TabIndex = 102;
            this.Lbl_Salones.Text = "Datos del Salon";
            // 
            // Dvg_Salones
            // 
            this.Dvg_Salones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dvg_Salones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dvg_Salones.Location = new System.Drawing.Point(12, 307);
            this.Dvg_Salones.Name = "Dvg_Salones";
            this.Dvg_Salones.RowHeadersWidth = 51;
            this.Dvg_Salones.Size = new System.Drawing.Size(987, 322);
            this.Dvg_Salones.TabIndex = 101;
            this.Dvg_Salones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dvg_Salones_CellClick);
            // 
            // Lbl_Disponibilidad
            // 
            this.Lbl_Disponibilidad.AutoSize = true;
            this.Lbl_Disponibilidad.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lbl_Disponibilidad.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Lbl_Disponibilidad.Location = new System.Drawing.Point(443, 201);
            this.Lbl_Disponibilidad.Name = "Lbl_Disponibilidad";
            this.Lbl_Disponibilidad.Size = new System.Drawing.Size(103, 17);
            this.Lbl_Disponibilidad.TabIndex = 112;
            this.Lbl_Disponibilidad.Text = "Disponibilidad";
            // 
            // Chk_disponibilidad
            // 
            this.Chk_disponibilidad.AutoSize = true;
            this.Chk_disponibilidad.Location = new System.Drawing.Point(627, 207);
            this.Chk_disponibilidad.Name = "Chk_disponibilidad";
            this.Chk_disponibilidad.Size = new System.Drawing.Size(15, 14);
            this.Chk_disponibilidad.TabIndex = 113;
            this.Chk_disponibilidad.UseVisualStyleBackColor = true;
            // 
            // Pnl_Superior
            // 
            this.Pnl_Superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(142)))), ((int)(((byte)(181)))));
            this.Pnl_Superior.Controls.Add(this.Lbl_Hoteleria);
            this.Pnl_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Superior.Location = new System.Drawing.Point(0, 24);
            this.Pnl_Superior.Margin = new System.Windows.Forms.Padding(2);
            this.Pnl_Superior.Name = "Pnl_Superior";
            this.Pnl_Superior.Size = new System.Drawing.Size(1011, 52);
            this.Pnl_Superior.TabIndex = 140;
            // 
            // Lbl_Hoteleria
            // 
            this.Lbl_Hoteleria.AutoSize = true;
            this.Lbl_Hoteleria.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Hoteleria.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_Hoteleria.Location = new System.Drawing.Point(21, 11);
            this.Lbl_Hoteleria.Name = "Lbl_Hoteleria";
            this.Lbl_Hoteleria.Size = new System.Drawing.Size(223, 23);
            this.Lbl_Hoteleria.TabIndex = 2;
            this.Lbl_Hoteleria.Text = "MODULO HOTELERIA";
            // 
            // Msp_Menu
            // 
            this.Msp_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(142)))), ((int)(((byte)(181)))));
            this.Msp_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salonesToolStripMenuItem});
            this.Msp_Menu.Location = new System.Drawing.Point(0, 0);
            this.Msp_Menu.Name = "Msp_Menu";
            this.Msp_Menu.Size = new System.Drawing.Size(1011, 24);
            this.Msp_Menu.TabIndex = 141;
            this.Msp_Menu.Text = "Msp_Menu";
            // 
            // salonesToolStripMenuItem
            // 
            this.salonesToolStripMenuItem.Name = "salonesToolStripMenuItem";
            this.salonesToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.salonesToolStripMenuItem.Text = "Reservaciones";
            this.salonesToolStripMenuItem.Click += new System.EventHandler(this.salonesToolStripMenuItem_Click);
            // 
            // Frm_Salones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 641);
            this.Controls.Add(this.Pnl_Superior);
            this.Controls.Add(this.Msp_Menu);
            this.Controls.Add(this.Chk_disponibilidad);
            this.Controls.Add(this.Lbl_Disponibilidad);
            this.Controls.Add(this.Txt_capacidad);
            this.Controls.Add(this.Txt_ubicacion);
            this.Controls.Add(this.Btn_modificar);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Lbl_Capacidad);
            this.Controls.Add(this.Lbl_Ubicacion);
            this.Controls.Add(this.Lbl_Nombre);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.Lbl_Salones);
            this.Controls.Add(this.Dvg_Salones);
            this.Name = "Frm_Salones";
            this.Text = "Frm_Salones";
            ((System.ComponentModel.ISupportInitialize)(this.Dvg_Salones)).EndInit();
            this.Pnl_Superior.ResumeLayout(false);
            this.Pnl_Superior.PerformLayout();
            this.Msp_Menu.ResumeLayout(false);
            this.Msp_Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Txt_capacidad;
        private System.Windows.Forms.TextBox Txt_ubicacion;
        private System.Windows.Forms.Button Btn_modificar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Label Lbl_Capacidad;
        private System.Windows.Forms.Label Lbl_Ubicacion;
        private System.Windows.Forms.Label Lbl_Nombre;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Label Lbl_Salones;
        private System.Windows.Forms.DataGridView Dvg_Salones;
        private System.Windows.Forms.Label Lbl_Disponibilidad;
        private System.Windows.Forms.CheckBox Chk_disponibilidad;
        private System.Windows.Forms.Panel Pnl_Superior;
        private System.Windows.Forms.Label Lbl_Hoteleria;
        private System.Windows.Forms.MenuStrip Msp_Menu;
        private System.Windows.Forms.ToolStripMenuItem salonesToolStripMenuItem;
    }
}