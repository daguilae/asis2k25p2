
namespace Capa_Vista_Hoteleria
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
            this.Dvg_Salones = new System.Windows.Forms.DataGridView();
            this.Lbl_Consulta = new System.Windows.Forms.Label();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Txt_Ubicacion = new System.Windows.Forms.TextBox();
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.Lbl_Ubicacion = new System.Windows.Forms.Label();
            this.Txt_Cpacidad = new System.Windows.Forms.TextBox();
            this.Lbl_Capacidad = new System.Windows.Forms.Label();
            this.Btn_modificar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
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
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Dvg_Salones)).BeginInit();
            this.Msp_hoteleria.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dvg_Salones
            // 
            this.Dvg_Salones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dvg_Salones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dvg_Salones.Location = new System.Drawing.Point(12, 273);
            this.Dvg_Salones.Name = "Dvg_Salones";
            this.Dvg_Salones.Size = new System.Drawing.Size(884, 297);
            this.Dvg_Salones.TabIndex = 3;
            this.Dvg_Salones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dvg_Salones_CellContentClick);
            // 
            // Lbl_Consulta
            // 
            this.Lbl_Consulta.AutoSize = true;
            this.Lbl_Consulta.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lbl_Consulta.Font = new System.Drawing.Font("Rockwell", 18F);
            this.Lbl_Consulta.Location = new System.Drawing.Point(6, 45);
            this.Lbl_Consulta.Name = "Lbl_Consulta";
            this.Lbl_Consulta.Size = new System.Drawing.Size(184, 27);
            this.Lbl_Consulta.TabIndex = 4;
            this.Lbl_Consulta.Text = "Datos del Salon";
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Nombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Nombre.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Txt_Nombre.Location = new System.Drawing.Point(11, 126);
            this.Txt_Nombre.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.ReadOnly = true;
            this.Txt_Nombre.Size = new System.Drawing.Size(337, 23);
            this.Txt_Nombre.TabIndex = 5;
            // 
            // Txt_Ubicacion
            // 
            this.Txt_Ubicacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Ubicacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Ubicacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Ubicacion.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Txt_Ubicacion.Location = new System.Drawing.Point(12, 177);
            this.Txt_Ubicacion.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Ubicacion.Name = "Txt_Ubicacion";
            this.Txt_Ubicacion.ReadOnly = true;
            this.Txt_Ubicacion.Size = new System.Drawing.Size(337, 23);
            this.Txt_Ubicacion.TabIndex = 6;
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lbl_Nombre.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Lbl_Nombre.Location = new System.Drawing.Point(8, 102);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(125, 17);
            this.Lbl_Nombre.TabIndex = 7;
            this.Lbl_Nombre.Text = "Nombre Del Salon";
            // 
            // Lbl_Ubicacion
            // 
            this.Lbl_Ubicacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Ubicacion.AutoSize = true;
            this.Lbl_Ubicacion.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lbl_Ubicacion.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Lbl_Ubicacion.Location = new System.Drawing.Point(9, 153);
            this.Lbl_Ubicacion.Name = "Lbl_Ubicacion";
            this.Lbl_Ubicacion.Size = new System.Drawing.Size(71, 17);
            this.Lbl_Ubicacion.TabIndex = 8;
            this.Lbl_Ubicacion.Text = "Ubicacion";
            // 
            // Txt_Cpacidad
            // 
            this.Txt_Cpacidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Cpacidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Cpacidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Cpacidad.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Txt_Cpacidad.Location = new System.Drawing.Point(12, 225);
            this.Txt_Cpacidad.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Cpacidad.Name = "Txt_Cpacidad";
            this.Txt_Cpacidad.ReadOnly = true;
            this.Txt_Cpacidad.Size = new System.Drawing.Size(337, 23);
            this.Txt_Cpacidad.TabIndex = 15;
            // 
            // Lbl_Capacidad
            // 
            this.Lbl_Capacidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Capacidad.AutoSize = true;
            this.Lbl_Capacidad.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lbl_Capacidad.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Lbl_Capacidad.Location = new System.Drawing.Point(9, 206);
            this.Lbl_Capacidad.Name = "Lbl_Capacidad";
            this.Lbl_Capacidad.Size = new System.Drawing.Size(165, 17);
            this.Lbl_Capacidad.TabIndex = 16;
            this.Lbl_Capacidad.Text = "Capacidad de personas ";
            // 
            // Btn_modificar
            // 
            this.Btn_modificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_modificar.BackColor = System.Drawing.Color.White;
            this.Btn_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_modificar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_modificar.Image")));
            this.Btn_modificar.Location = new System.Drawing.Point(698, 102);
            this.Btn_modificar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_modificar.Name = "Btn_modificar";
            this.Btn_modificar.Size = new System.Drawing.Size(40, 37);
            this.Btn_modificar.TabIndex = 19;
            this.Btn_modificar.UseVisualStyleBackColor = false;
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_eliminar.BackColor = System.Drawing.Color.White;
            this.Btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_eliminar.Image")));
            this.Btn_eliminar.Location = new System.Drawing.Point(654, 102);
            this.Btn_eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(40, 37);
            this.Btn_eliminar.TabIndex = 18;
            this.Btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_guardar.BackColor = System.Drawing.Color.White;
            this.Btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_guardar.Image")));
            this.Btn_guardar.Location = new System.Drawing.Point(610, 102);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(40, 37);
            this.Btn_guardar.TabIndex = 17;
            this.Btn_guardar.UseVisualStyleBackColor = false;
            // 
            // Msp_hoteleria
            // 
            this.Msp_hoteleria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(142)))), ((int)(((byte)(181)))));
            this.Msp_hoteleria.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Msp_hoteleria.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.salonesToolStripMenuItem,
            this.ordenesDeProduccionToolStripMenuItem,
            this.recetasToolStripMenuItem,
            this.procesoDeProduccionToolStripMenuItem,
            this.materialesToolStripMenuItem,
            this.mantenimientoHoteleriaToolStripMenuItem});
            this.Msp_hoteleria.Location = new System.Drawing.Point(0, 0);
            this.Msp_hoteleria.Name = "Msp_hoteleria";
            this.Msp_hoteleria.Size = new System.Drawing.Size(908, 24);
            this.Msp_hoteleria.TabIndex = 20;
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
            this.reservacionesDeSalonesToolStripMenuItem.Click += new System.EventHandler(this.reservacionesDeSalonesToolStripMenuItem_Click);
            // 
            // gestionDeSalonesToolStripMenuItem
            // 
            this.gestionDeSalonesToolStripMenuItem.Name = "gestionDeSalonesToolStripMenuItem";
            this.gestionDeSalonesToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.gestionDeSalonesToolStripMenuItem.Text = "Gestion de Salones";
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
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click_1);
            // 
            // Frm_Salones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 582);
            this.Controls.Add(this.Msp_hoteleria);
            this.Controls.Add(this.Btn_modificar);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Lbl_Capacidad);
            this.Controls.Add(this.Txt_Cpacidad);
            this.Controls.Add(this.Lbl_Ubicacion);
            this.Controls.Add(this.Lbl_Nombre);
            this.Controls.Add(this.Txt_Ubicacion);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.Lbl_Consulta);
            this.Controls.Add(this.Dvg_Salones);
            this.Name = "Frm_Salones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Salones";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Dvg_Salones)).EndInit();
            this.Msp_hoteleria.ResumeLayout(false);
            this.Msp_hoteleria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Dvg_Salones;
        private System.Windows.Forms.Label Lbl_Consulta;
        private System.Windows.Forms.TextBox Txt_Ubicacion;
        private System.Windows.Forms.Label Lbl_Nombre;
        private System.Windows.Forms.Label Lbl_Ubicacion;
        private System.Windows.Forms.TextBox Txt_Cpacidad;
        private System.Windows.Forms.Label Lbl_Capacidad;
        private System.Windows.Forms.Button Btn_modificar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_guardar;
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
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.TextBox Txt_Nombre;
    }
}