
namespace CapaVistaOP
{
    partial class Frm_Ordenes_de_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Ordenes_de_menu));
            this.Pnl_Superior = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Lbl_Modulo_Hoteleria = new System.Windows.Forms.Label();
            this.Lbl_Detalle_Orden = new System.Windows.Forms.Label();
            this.Lbl_Ordenes_Menu = new System.Windows.Forms.Label();
            this.Lbl_Orden_Produccion = new System.Windows.Forms.Label();
            this.Lbl_Menu = new System.Windows.Forms.Label();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Lbl_Cantidad_de_Platillos = new System.Windows.Forms.Label();
            this.Dgv_Detalle_Orden_menu = new System.Windows.Forms.DataGridView();
            this.Txt_Detalle_Orden = new System.Windows.Forms.TextBox();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Nud_Cantidad = new System.Windows.Forms.NumericUpDown();
            this.Cbo_Menu = new System.Windows.Forms.ComboBox();
            this.Cbo_Orden_Produccion = new System.Windows.Forms.ComboBox();
            this.Btn_Reporte = new System.Windows.Forms.Button();
            this.Pnl_Superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Detalle_Orden_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_Superior
            // 
            this.Pnl_Superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(142)))), ((int)(((byte)(181)))));
            this.Pnl_Superior.Controls.Add(this.button1);
            this.Pnl_Superior.Controls.Add(this.Lbl_Modulo_Hoteleria);
            this.Pnl_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Superior.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Superior.Name = "Pnl_Superior";
            this.Pnl_Superior.Size = new System.Drawing.Size(895, 50);
            this.Pnl_Superior.TabIndex = 98;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(979, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 37);
            this.button1.TabIndex = 132;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lbl_Modulo_Hoteleria
            // 
            this.Lbl_Modulo_Hoteleria.AutoSize = true;
            this.Lbl_Modulo_Hoteleria.Font = new System.Drawing.Font("Rockwell", 18F);
            this.Lbl_Modulo_Hoteleria.Location = new System.Drawing.Point(27, 9);
            this.Lbl_Modulo_Hoteleria.Name = "Lbl_Modulo_Hoteleria";
            this.Lbl_Modulo_Hoteleria.Size = new System.Drawing.Size(252, 35);
            this.Lbl_Modulo_Hoteleria.TabIndex = 104;
            this.Lbl_Modulo_Hoteleria.Text = "Módulo hotelería";
            // 
            // Lbl_Detalle_Orden
            // 
            this.Lbl_Detalle_Orden.AutoSize = true;
            this.Lbl_Detalle_Orden.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Detalle_Orden.Location = new System.Drawing.Point(30, 116);
            this.Lbl_Detalle_Orden.Name = "Lbl_Detalle_Orden";
            this.Lbl_Detalle_Orden.Size = new System.Drawing.Size(116, 20);
            this.Lbl_Detalle_Orden.TabIndex = 99;
            this.Lbl_Detalle_Orden.Text = "Detalle orden";
            // 
            // Lbl_Ordenes_Menu
            // 
            this.Lbl_Ordenes_Menu.AutoSize = true;
            this.Lbl_Ordenes_Menu.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Ordenes_Menu.Location = new System.Drawing.Point(27, 69);
            this.Lbl_Ordenes_Menu.Name = "Lbl_Ordenes_Menu";
            this.Lbl_Ordenes_Menu.Size = new System.Drawing.Size(190, 21);
            this.Lbl_Ordenes_Menu.TabIndex = 105;
            this.Lbl_Ordenes_Menu.Text = "ORDENES DE MENU";
            // 
            // Lbl_Orden_Produccion
            // 
            this.Lbl_Orden_Produccion.AutoSize = true;
            this.Lbl_Orden_Produccion.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Orden_Produccion.Location = new System.Drawing.Point(30, 151);
            this.Lbl_Orden_Produccion.Name = "Lbl_Orden_Produccion";
            this.Lbl_Orden_Produccion.Size = new System.Drawing.Size(154, 20);
            this.Lbl_Orden_Produccion.TabIndex = 107;
            this.Lbl_Orden_Produccion.Text = "Orden produccion";
            // 
            // Lbl_Menu
            // 
            this.Lbl_Menu.AutoSize = true;
            this.Lbl_Menu.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Menu.Location = new System.Drawing.Point(30, 184);
            this.Lbl_Menu.Name = "Lbl_Menu";
            this.Lbl_Menu.Size = new System.Drawing.Size(54, 20);
            this.Lbl_Menu.TabIndex = 108;
            this.Lbl_Menu.Text = "Menu";
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(42, 224);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(0, 29);
            this.Lbl_Titulo.TabIndex = 113;
            // 
            // Lbl_Cantidad_de_Platillos
            // 
            this.Lbl_Cantidad_de_Platillos.AutoSize = true;
            this.Lbl_Cantidad_de_Platillos.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cantidad_de_Platillos.Location = new System.Drawing.Point(28, 221);
            this.Lbl_Cantidad_de_Platillos.Name = "Lbl_Cantidad_de_Platillos";
            this.Lbl_Cantidad_de_Platillos.Size = new System.Drawing.Size(170, 20);
            this.Lbl_Cantidad_de_Platillos.TabIndex = 114;
            this.Lbl_Cantidad_de_Platillos.Text = "Cantidad de platillos";
            // 
            // Dgv_Detalle_Orden_menu
            // 
            this.Dgv_Detalle_Orden_menu.AllowUserToAddRows = false;
            this.Dgv_Detalle_Orden_menu.AllowUserToDeleteRows = false;
            this.Dgv_Detalle_Orden_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Detalle_Orden_menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Detalle_Orden_menu.Location = new System.Drawing.Point(31, 271);
            this.Dgv_Detalle_Orden_menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dgv_Detalle_Orden_menu.Name = "Dgv_Detalle_Orden_menu";
            this.Dgv_Detalle_Orden_menu.ReadOnly = true;
            this.Dgv_Detalle_Orden_menu.RowHeadersWidth = 51;
            this.Dgv_Detalle_Orden_menu.RowTemplate.Height = 24;
            this.Dgv_Detalle_Orden_menu.Size = new System.Drawing.Size(840, 300);
            this.Dgv_Detalle_Orden_menu.TabIndex = 115;
            this.Dgv_Detalle_Orden_menu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleOrdenes_CellContentClick);
            // 
            // Txt_Detalle_Orden
            // 
            this.Txt_Detalle_Orden.BackColor = System.Drawing.Color.White;
            this.Txt_Detalle_Orden.Location = new System.Drawing.Point(252, 116);
            this.Txt_Detalle_Orden.Name = "Txt_Detalle_Orden";
            this.Txt_Detalle_Orden.Size = new System.Drawing.Size(181, 22);
            this.Txt_Detalle_Orden.TabIndex = 116;
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.BackColor = System.Drawing.Color.White;
            this.Btn_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Editar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Editar.Image")));
            this.Btn_Editar.Location = new System.Drawing.Point(818, 69);
            this.Btn_Editar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(53, 46);
            this.Btn_Editar.TabIndex = 130;
            this.Btn_Editar.UseVisualStyleBackColor = false;
            this.Btn_Editar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.Color.White;
            this.Btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Eliminar.Image")));
            this.Btn_Eliminar.Location = new System.Drawing.Point(746, 69);
            this.Btn_Eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(53, 46);
            this.Btn_Eliminar.TabIndex = 129;
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            this.Btn_Eliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.BackColor = System.Drawing.Color.White;
            this.Btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Guardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Guardar.Image")));
            this.Btn_Guardar.Location = new System.Drawing.Point(674, 69);
            this.Btn_Guardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(53, 46);
            this.Btn_Guardar.TabIndex = 128;
            this.Btn_Guardar.UseVisualStyleBackColor = false;
            this.Btn_Guardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Nud_Cantidad
            // 
            this.Nud_Cantidad.Location = new System.Drawing.Point(252, 221);
            this.Nud_Cantidad.Name = "Nud_Cantidad";
            this.Nud_Cantidad.Size = new System.Drawing.Size(181, 22);
            this.Nud_Cantidad.TabIndex = 131;
            // 
            // Cbo_Menu
            // 
            this.Cbo_Menu.BackColor = System.Drawing.Color.White;
            this.Cbo_Menu.FormattingEnabled = true;
            this.Cbo_Menu.Location = new System.Drawing.Point(252, 184);
            this.Cbo_Menu.Name = "Cbo_Menu";
            this.Cbo_Menu.Size = new System.Drawing.Size(181, 24);
            this.Cbo_Menu.TabIndex = 112;
            // 
            // Cbo_Orden_Produccion
            // 
            this.Cbo_Orden_Produccion.BackColor = System.Drawing.Color.White;
            this.Cbo_Orden_Produccion.FormattingEnabled = true;
            this.Cbo_Orden_Produccion.Location = new System.Drawing.Point(252, 151);
            this.Cbo_Orden_Produccion.Name = "Cbo_Orden_Produccion";
            this.Cbo_Orden_Produccion.Size = new System.Drawing.Size(181, 24);
            this.Cbo_Orden_Produccion.TabIndex = 111;
            this.Cbo_Orden_Produccion.SelectedIndexChanged += new System.EventHandler(this.cbOrdenesProduccion_SelectedIndexChanged);
            // 
            // Btn_Reporte
            // 
            this.Btn_Reporte.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Reporte.Image")));
            this.Btn_Reporte.Location = new System.Drawing.Point(604, 69);
            this.Btn_Reporte.Name = "Btn_Reporte";
            this.Btn_Reporte.Size = new System.Drawing.Size(55, 46);
            this.Btn_Reporte.TabIndex = 132;
            this.Btn_Reporte.UseVisualStyleBackColor = true;
            this.Btn_Reporte.Click += new System.EventHandler(this.Btn_Reporte_Click);
            // 
            // Frm_Ordenes_de_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(895, 597);
            this.Controls.Add(this.Btn_Reporte);
            this.Controls.Add(this.Nud_Cantidad);
            this.Controls.Add(this.Btn_Editar);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Txt_Detalle_Orden);
            this.Controls.Add(this.Dgv_Detalle_Orden_menu);
            this.Controls.Add(this.Lbl_Cantidad_de_Platillos);
            this.Controls.Add(this.Lbl_Titulo);
            this.Controls.Add(this.Cbo_Menu);
            this.Controls.Add(this.Cbo_Orden_Produccion);
            this.Controls.Add(this.Lbl_Menu);
            this.Controls.Add(this.Lbl_Orden_Produccion);
            this.Controls.Add(this.Lbl_Ordenes_Menu);
            this.Controls.Add(this.Lbl_Detalle_Orden);
            this.Controls.Add(this.Pnl_Superior);
            this.Name = "Frm_Ordenes_de_menu";
            this.Text = "Frm_Ordenes_de_produccion";
            this.Load += new System.EventHandler(this.Frm_Ordenes_de_produccion_Load);
            this.Pnl_Superior.ResumeLayout(false);
            this.Pnl_Superior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Detalle_Orden_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Cantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Superior;
        private System.Windows.Forms.Label Lbl_Modulo_Hoteleria;
        private System.Windows.Forms.Label Lbl_Detalle_Orden;
        private System.Windows.Forms.Label Lbl_Ordenes_Menu;
        private System.Windows.Forms.Label Lbl_Orden_Produccion;
        private System.Windows.Forms.Label Lbl_Menu;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Label Lbl_Cantidad_de_Platillos;
        private System.Windows.Forms.DataGridView Dgv_Detalle_Orden_menu;
        private System.Windows.Forms.TextBox Txt_Detalle_Orden;
        private System.Windows.Forms.Button Btn_Editar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.NumericUpDown Nud_Cantidad;
        private System.Windows.Forms.ComboBox Cbo_Menu;
        private System.Windows.Forms.ComboBox Cbo_Orden_Produccion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Btn_Reporte;
    }
}