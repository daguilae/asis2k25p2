
namespace Capa_Vista_Hoteleria
{
    partial class Frm_Reservaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Reservaciones));
            this.Msp_hoteleria = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.Btn_modificar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Lbl_Capacidad = new System.Windows.Forms.Label();
            this.Txt_Capacidad = new System.Windows.Forms.TextBox();
            this.Txt_Fin = new System.Windows.Forms.TextBox();
            this.Lbl_Fin = new System.Windows.Forms.Label();
            this.Txt_Inicio = new System.Windows.Forms.TextBox();
            this.Lbl_inicio = new System.Windows.Forms.Label();
            this.Txt_Fecha_Reserva = new System.Windows.Forms.TextBox();
            this.Lbl_Fecha_Reserva = new System.Windows.Forms.Label();
            this.Lbl_Costo = new System.Windows.Forms.Label();
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.Txt_Costo = new System.Windows.Forms.TextBox();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Lbl_Reservacion = new System.Windows.Forms.Label();
            this.Dvg_Salones = new System.Windows.Forms.DataGridView();
            this.Msp_hoteleria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dvg_Salones)).BeginInit();
            this.SuspendLayout();
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
            this.Msp_hoteleria.TabIndex = 21;
            this.Msp_hoteleria.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
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
            // 
            // gestionDeSalonesToolStripMenuItem
            // 
            this.gestionDeSalonesToolStripMenuItem.Name = "gestionDeSalonesToolStripMenuItem";
            this.gestionDeSalonesToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.gestionDeSalonesToolStripMenuItem.Text = "Gestion de Salones";
            this.gestionDeSalonesToolStripMenuItem.Click += new System.EventHandler(this.gestionDeSalonesToolStripMenuItem_Click);
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
            // Btn_modificar
            // 
            this.Btn_modificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_modificar.BackColor = System.Drawing.Color.White;
            this.Btn_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_modificar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_modificar.Image")));
            this.Btn_modificar.Location = new System.Drawing.Point(800, 35);
            this.Btn_modificar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_modificar.Name = "Btn_modificar";
            this.Btn_modificar.Size = new System.Drawing.Size(40, 37);
            this.Btn_modificar.TabIndex = 38;
            this.Btn_modificar.UseVisualStyleBackColor = false;
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_eliminar.BackColor = System.Drawing.Color.White;
            this.Btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_eliminar.Image")));
            this.Btn_eliminar.Location = new System.Drawing.Point(756, 35);
            this.Btn_eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(40, 37);
            this.Btn_eliminar.TabIndex = 37;
            this.Btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_guardar.BackColor = System.Drawing.Color.White;
            this.Btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_guardar.Image")));
            this.Btn_guardar.Location = new System.Drawing.Point(712, 35);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(40, 37);
            this.Btn_guardar.TabIndex = 36;
            this.Btn_guardar.UseVisualStyleBackColor = false;
            // 
            // Lbl_Capacidad
            // 
            this.Lbl_Capacidad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Capacidad.AutoSize = true;
            this.Lbl_Capacidad.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lbl_Capacidad.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Lbl_Capacidad.Location = new System.Drawing.Point(9, 212);
            this.Lbl_Capacidad.Name = "Lbl_Capacidad";
            this.Lbl_Capacidad.Size = new System.Drawing.Size(165, 17);
            this.Lbl_Capacidad.TabIndex = 35;
            this.Lbl_Capacidad.Text = "Capacidad de personas ";
            // 
            // Txt_Capacidad
            // 
            this.Txt_Capacidad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Capacidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Capacidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Capacidad.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Txt_Capacidad.Location = new System.Drawing.Point(12, 231);
            this.Txt_Capacidad.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Capacidad.Name = "Txt_Capacidad";
            this.Txt_Capacidad.ReadOnly = true;
            this.Txt_Capacidad.Size = new System.Drawing.Size(337, 23);
            this.Txt_Capacidad.TabIndex = 34;
            // 
            // Txt_Fin
            // 
            this.Txt_Fin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Fin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Fin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Fin.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Txt_Fin.Location = new System.Drawing.Point(456, 163);
            this.Txt_Fin.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Fin.Name = "Txt_Fin";
            this.Txt_Fin.ReadOnly = true;
            this.Txt_Fin.Size = new System.Drawing.Size(337, 23);
            this.Txt_Fin.TabIndex = 33;
            // 
            // Lbl_Fin
            // 
            this.Lbl_Fin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Fin.AutoSize = true;
            this.Lbl_Fin.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lbl_Fin.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Lbl_Fin.Location = new System.Drawing.Point(453, 144);
            this.Lbl_Fin.Name = "Lbl_Fin";
            this.Lbl_Fin.Size = new System.Drawing.Size(140, 17);
            this.Lbl_Fin.TabIndex = 32;
            this.Lbl_Fin.Text = "Hora De Finalizacion";
            // 
            // Txt_Inicio
            // 
            this.Txt_Inicio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Inicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Inicio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Inicio.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Txt_Inicio.Location = new System.Drawing.Point(15, 163);
            this.Txt_Inicio.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Inicio.Name = "Txt_Inicio";
            this.Txt_Inicio.ReadOnly = true;
            this.Txt_Inicio.Size = new System.Drawing.Size(337, 23);
            this.Txt_Inicio.TabIndex = 31;
            // 
            // Lbl_inicio
            // 
            this.Lbl_inicio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_inicio.AutoSize = true;
            this.Lbl_inicio.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lbl_inicio.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Lbl_inicio.Location = new System.Drawing.Point(12, 141);
            this.Lbl_inicio.Name = "Lbl_inicio";
            this.Lbl_inicio.Size = new System.Drawing.Size(100, 17);
            this.Lbl_inicio.TabIndex = 30;
            this.Lbl_inicio.Text = "Hora De inicio";
            // 
            // Txt_Fecha_Reserva
            // 
            this.Txt_Fecha_Reserva.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Fecha_Reserva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Fecha_Reserva.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Fecha_Reserva.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Txt_Fecha_Reserva.Location = new System.Drawing.Point(456, 91);
            this.Txt_Fecha_Reserva.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Fecha_Reserva.Name = "Txt_Fecha_Reserva";
            this.Txt_Fecha_Reserva.ReadOnly = true;
            this.Txt_Fecha_Reserva.Size = new System.Drawing.Size(337, 23);
            this.Txt_Fecha_Reserva.TabIndex = 29;
            // 
            // Lbl_Fecha_Reserva
            // 
            this.Lbl_Fecha_Reserva.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Fecha_Reserva.AutoSize = true;
            this.Lbl_Fecha_Reserva.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lbl_Fecha_Reserva.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Lbl_Fecha_Reserva.Location = new System.Drawing.Point(453, 69);
            this.Lbl_Fecha_Reserva.Name = "Lbl_Fecha_Reserva";
            this.Lbl_Fecha_Reserva.Size = new System.Drawing.Size(150, 17);
            this.Lbl_Fecha_Reserva.TabIndex = 28;
            this.Lbl_Fecha_Reserva.Text = "Fecha De Reservacion";
            // 
            // Lbl_Costo
            // 
            this.Lbl_Costo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Costo.AutoSize = true;
            this.Lbl_Costo.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lbl_Costo.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Lbl_Costo.Location = new System.Drawing.Point(453, 212);
            this.Lbl_Costo.Name = "Lbl_Costo";
            this.Lbl_Costo.Size = new System.Drawing.Size(45, 17);
            this.Lbl_Costo.TabIndex = 27;
            this.Lbl_Costo.Text = "Costo";
            this.Lbl_Costo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lbl_Nombre.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Lbl_Nombre.Location = new System.Drawing.Point(12, 69);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(138, 17);
            this.Lbl_Nombre.TabIndex = 26;
            this.Lbl_Nombre.Text = "Nombre Del Cliente";
            // 
            // Txt_Costo
            // 
            this.Txt_Costo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Costo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Costo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Costo.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Txt_Costo.Location = new System.Drawing.Point(456, 231);
            this.Txt_Costo.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Costo.Name = "Txt_Costo";
            this.Txt_Costo.ReadOnly = true;
            this.Txt_Costo.Size = new System.Drawing.Size(337, 23);
            this.Txt_Costo.TabIndex = 25;
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Nombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Nombre.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Txt_Nombre.Location = new System.Drawing.Point(15, 93);
            this.Txt_Nombre.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.ReadOnly = true;
            this.Txt_Nombre.Size = new System.Drawing.Size(337, 23);
            this.Txt_Nombre.TabIndex = 24;
            // 
            // Lbl_Reservacion
            // 
            this.Lbl_Reservacion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Reservacion.AutoSize = true;
            this.Lbl_Reservacion.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lbl_Reservacion.Font = new System.Drawing.Font("Rockwell", 18F);
            this.Lbl_Reservacion.Location = new System.Drawing.Point(7, 30);
            this.Lbl_Reservacion.Name = "Lbl_Reservacion";
            this.Lbl_Reservacion.Size = new System.Drawing.Size(257, 27);
            this.Lbl_Reservacion.TabIndex = 23;
            this.Lbl_Reservacion.Text = "Datos De Reservacion";
            // 
            // Dvg_Salones
            // 
            this.Dvg_Salones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dvg_Salones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dvg_Salones.Location = new System.Drawing.Point(12, 282);
            this.Dvg_Salones.Name = "Dvg_Salones";
            this.Dvg_Salones.Size = new System.Drawing.Size(884, 297);
            this.Dvg_Salones.TabIndex = 22;
            // 
            // Frm_Reservaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 582);
            this.Controls.Add(this.Btn_modificar);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Lbl_Capacidad);
            this.Controls.Add(this.Txt_Capacidad);
            this.Controls.Add(this.Txt_Fin);
            this.Controls.Add(this.Lbl_Fin);
            this.Controls.Add(this.Txt_Inicio);
            this.Controls.Add(this.Lbl_inicio);
            this.Controls.Add(this.Txt_Fecha_Reserva);
            this.Controls.Add(this.Lbl_Fecha_Reserva);
            this.Controls.Add(this.Lbl_Costo);
            this.Controls.Add(this.Lbl_Nombre);
            this.Controls.Add(this.Txt_Costo);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.Lbl_Reservacion);
            this.Controls.Add(this.Dvg_Salones);
            this.Controls.Add(this.Msp_hoteleria);
            this.Name = "Frm_Reservaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Reservaciones";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Reservaciones_Load);
            this.Msp_hoteleria.ResumeLayout(false);
            this.Msp_hoteleria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dvg_Salones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Msp_hoteleria;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
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
        private System.Windows.Forms.Button Btn_modificar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Label Lbl_Capacidad;
        private System.Windows.Forms.TextBox Txt_Capacidad;
        private System.Windows.Forms.TextBox Txt_Fin;
        private System.Windows.Forms.Label Lbl_Fin;
        private System.Windows.Forms.TextBox Txt_Inicio;
        private System.Windows.Forms.Label Lbl_inicio;
        private System.Windows.Forms.TextBox Txt_Fecha_Reserva;
        private System.Windows.Forms.Label Lbl_Fecha_Reserva;
        private System.Windows.Forms.Label Lbl_Costo;
        private System.Windows.Forms.Label Lbl_Nombre;
        private System.Windows.Forms.TextBox Txt_Costo;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Label Lbl_Reservacion;
        private System.Windows.Forms.DataGridView Dvg_Salones;
    }
}