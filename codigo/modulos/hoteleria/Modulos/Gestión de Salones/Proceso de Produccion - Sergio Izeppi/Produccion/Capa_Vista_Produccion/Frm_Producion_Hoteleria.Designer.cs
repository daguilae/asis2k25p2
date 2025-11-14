namespace Capa_Vista_Produccion
{
    partial class Frm_Produccion_Hoteleria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Produccion_Hoteleria));
            this.Lbl_Room_Service = new System.Windows.Forms.Label();
            this.Cbo_Menu = new System.Windows.Forms.ComboBox();
            this.Cbo_Estado = new System.Windows.Forms.ComboBox();
            this.Dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Estado = new System.Windows.Forms.Label();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Lbl_Habitacion = new System.Windows.Forms.Label();
            this.Lbl_Cantidad = new System.Windows.Forms.Label();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.Lbl_Id_Menu = new System.Windows.Forms.Label();
            this.Lbl_Id_Habitacion = new System.Windows.Forms.Label();
            this.Lbl_Id_huesped = new System.Windows.Forms.Label();
            this.Btn_modificar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Dgv_Room_Service = new System.Windows.Forms.DataGridView();
            this.Txt_Id_Habitacion = new System.Windows.Forms.TextBox();
            this.Txt_ID_Pedido = new System.Windows.Forms.TextBox();
            this.Txt_Cantidad = new System.Windows.Forms.TextBox();
            this.Txt_Id_Huesped = new System.Windows.Forms.TextBox();
            this.Pnl_Superior = new System.Windows.Forms.Panel();
            this.Btn_Cambio = new System.Windows.Forms.Button();
            this.Lbl_Precio = new System.Windows.Forms.Label();
            this.Txt_PrecioUni = new System.Windows.Forms.TextBox();
            this.Lbl_Subtotal = new System.Windows.Forms.Label();
            this.Txt_Subtotal = new System.Windows.Forms.TextBox();
            this.Dgv_Platos = new System.Windows.Forms.DataGridView();
            this.Btn_Guardar_Plato = new System.Windows.Forms.Button();
            this.Btn_eliminar_Plato = new System.Windows.Forms.Button();
            this.Btn_editar_plato = new System.Windows.Forms.Button();
            this.Btn_Reporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Room_Service)).BeginInit();
            this.Pnl_Superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Platos)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Room_Service
            // 
            this.Lbl_Room_Service.AutoSize = true;
            this.Lbl_Room_Service.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Room_Service.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_Room_Service.Location = new System.Drawing.Point(14, 92);
            this.Lbl_Room_Service.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Room_Service.Name = "Lbl_Room_Service";
            this.Lbl_Room_Service.Size = new System.Drawing.Size(151, 21);
            this.Lbl_Room_Service.TabIndex = 140;
            this.Lbl_Room_Service.Text = "ROOM SERVICE";
            // 
            // Cbo_Menu
            // 
            this.Cbo_Menu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Menu.FormattingEnabled = true;
            this.Cbo_Menu.Location = new System.Drawing.Point(192, 296);
            this.Cbo_Menu.Name = "Cbo_Menu";
            this.Cbo_Menu.Size = new System.Drawing.Size(128, 24);
            this.Cbo_Menu.TabIndex = 139;
            this.Cbo_Menu.SelectedIndexChanged += new System.EventHandler(this.pro_Cbo_Menu_SelectedIndexChanged);
            // 
            // Cbo_Estado
            // 
            this.Cbo_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Estado.FormattingEnabled = true;
            this.Cbo_Estado.Location = new System.Drawing.Point(805, 186);
            this.Cbo_Estado.Name = "Cbo_Estado";
            this.Cbo_Estado.Size = new System.Drawing.Size(147, 24);
            this.Cbo_Estado.TabIndex = 138;
            // 
            // Dtp_Fecha
            // 
            this.Dtp_Fecha.Location = new System.Drawing.Point(807, 140);
            this.Dtp_Fecha.Name = "Dtp_Fecha";
            this.Dtp_Fecha.Size = new System.Drawing.Size(233, 22);
            this.Dtp_Fecha.TabIndex = 137;
            // 
            // Lbl_Estado
            // 
            this.Lbl_Estado.AutoSize = true;
            this.Lbl_Estado.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Estado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_Estado.Location = new System.Drawing.Point(600, 183);
            this.Lbl_Estado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Estado.Name = "Lbl_Estado";
            this.Lbl_Estado.Size = new System.Drawing.Size(178, 21);
            this.Lbl_Estado.TabIndex = 136;
            this.Lbl_Estado.Text = "Estado del Pedido:";
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_Titulo.Location = new System.Drawing.Point(14, 10);
            this.Lbl_Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(319, 35);
            this.Lbl_Titulo.TabIndex = 2;
            this.Lbl_Titulo.Text = "MODULO HOTELERIA";
            // 
            // Lbl_Habitacion
            // 
            this.Lbl_Habitacion.AutoSize = true;
            this.Lbl_Habitacion.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Habitacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_Habitacion.Location = new System.Drawing.Point(13, 272);
            this.Lbl_Habitacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Habitacion.Name = "Lbl_Habitacion";
            this.Lbl_Habitacion.Size = new System.Drawing.Size(136, 21);
            this.Lbl_Habitacion.TabIndex = 135;
            this.Lbl_Habitacion.Text = "ID Habitacion:";
            // 
            // Lbl_Cantidad
            // 
            this.Lbl_Cantidad.AutoSize = true;
            this.Lbl_Cantidad.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cantidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_Cantidad.Location = new System.Drawing.Point(425, 272);
            this.Lbl_Cantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Cantidad.Name = "Lbl_Cantidad";
            this.Lbl_Cantidad.Size = new System.Drawing.Size(164, 21);
            this.Lbl_Cantidad.TabIndex = 134;
            this.Lbl_Cantidad.Text = "Cantidad Pedida:";
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_Fecha.Location = new System.Drawing.Point(603, 140);
            this.Lbl_Fecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(170, 21);
            this.Lbl_Fecha.TabIndex = 133;
            this.Lbl_Fecha.Text = "Fecha del Pedido:";
            // 
            // Lbl_Id_Menu
            // 
            this.Lbl_Id_Menu.AutoSize = true;
            this.Lbl_Id_Menu.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Id_Menu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_Id_Menu.Location = new System.Drawing.Point(188, 272);
            this.Lbl_Id_Menu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Id_Menu.Name = "Lbl_Id_Menu";
            this.Lbl_Id_Menu.Size = new System.Drawing.Size(171, 21);
            this.Lbl_Id_Menu.TabIndex = 132;
            this.Lbl_Id_Menu.Text = "Nombre del Plato:";
            // 
            // Lbl_Id_Habitacion
            // 
            this.Lbl_Id_Habitacion.AutoSize = true;
            this.Lbl_Id_Habitacion.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Id_Habitacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_Id_Habitacion.Location = new System.Drawing.Point(15, 177);
            this.Lbl_Id_Habitacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Id_Habitacion.Name = "Lbl_Id_Habitacion";
            this.Lbl_Id_Habitacion.Size = new System.Drawing.Size(185, 21);
            this.Lbl_Id_Habitacion.TabIndex = 131;
            this.Lbl_Id_Habitacion.Text = "ID de la Habitacion:";
            // 
            // Lbl_Id_huesped
            // 
            this.Lbl_Id_huesped.AutoSize = true;
            this.Lbl_Id_huesped.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Id_huesped.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_Id_huesped.Location = new System.Drawing.Point(15, 134);
            this.Lbl_Id_huesped.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Id_huesped.Name = "Lbl_Id_huesped";
            this.Lbl_Id_huesped.Size = new System.Drawing.Size(134, 20);
            this.Lbl_Id_huesped.TabIndex = 130;
            this.Lbl_Id_huesped.Text = "ID del Huesped:";
            // 
            // Btn_modificar
            // 
            this.Btn_modificar.BackColor = System.Drawing.Color.White;
            this.Btn_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_modificar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_modificar.Image")));
            this.Btn_modificar.Location = new System.Drawing.Point(1361, 72);
            this.Btn_modificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_modificar.Name = "Btn_modificar";
            this.Btn_modificar.Size = new System.Drawing.Size(53, 46);
            this.Btn_modificar.TabIndex = 129;
            this.Btn_modificar.UseVisualStyleBackColor = false;
            this.Btn_modificar.Click += new System.EventHandler(this.pro_Btn_modificar_Click);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.BackColor = System.Drawing.Color.White;
            this.Btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_eliminar.Image")));
            this.Btn_eliminar.Location = new System.Drawing.Point(1304, 72);
            this.Btn_eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(53, 46);
            this.Btn_eliminar.TabIndex = 128;
            this.Btn_eliminar.UseVisualStyleBackColor = false;
            this.Btn_eliminar.Click += new System.EventHandler(this.pro_Btn_eliminar_Click);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.White;
            this.Btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_guardar.Image")));
            this.Btn_guardar.Location = new System.Drawing.Point(1245, 72);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(53, 46);
            this.Btn_guardar.TabIndex = 127;
            this.Btn_guardar.UseVisualStyleBackColor = false;
            this.Btn_guardar.Click += new System.EventHandler(this.pro_Btn_guardar_Click);
            // 
            // Dgv_Room_Service
            // 
            this.Dgv_Room_Service.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Room_Service.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Room_Service.Location = new System.Drawing.Point(20, 341);
            this.Dgv_Room_Service.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dgv_Room_Service.Name = "Dgv_Room_Service";
            this.Dgv_Room_Service.RowHeadersWidth = 51;
            this.Dgv_Room_Service.RowTemplate.Height = 24;
            this.Dgv_Room_Service.Size = new System.Drawing.Size(687, 295);
            this.Dgv_Room_Service.TabIndex = 126;
            this.Dgv_Room_Service.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pro_Dgv_Room_Service_CellContentClick);
            // 
            // Txt_Id_Habitacion
            // 
            this.Txt_Id_Habitacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Id_Habitacion.Location = new System.Drawing.Point(229, 182);
            this.Txt_Id_Habitacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Id_Habitacion.Name = "Txt_Id_Habitacion";
            this.Txt_Id_Habitacion.Size = new System.Drawing.Size(233, 22);
            this.Txt_Id_Habitacion.TabIndex = 125;
            this.Txt_Id_Habitacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Id_Habitacion_KeyPress);
            // 
            // Txt_ID_Pedido
            // 
            this.Txt_ID_Pedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_ID_Pedido.Location = new System.Drawing.Point(17, 298);
            this.Txt_ID_Pedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_ID_Pedido.Name = "Txt_ID_Pedido";
            this.Txt_ID_Pedido.Size = new System.Drawing.Size(100, 22);
            this.Txt_ID_Pedido.TabIndex = 124;
            this.Txt_ID_Pedido.TextChanged += new System.EventHandler(this.pro_Txt_ID_Pedido_TextChanged);
            this.Txt_ID_Pedido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_ID_Pedido_KeyPress);
            // 
            // Txt_Cantidad
            // 
            this.Txt_Cantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Cantidad.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.Txt_Cantidad.Location = new System.Drawing.Point(429, 298);
            this.Txt_Cantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Cantidad.Name = "Txt_Cantidad";
            this.Txt_Cantidad.Size = new System.Drawing.Size(123, 22);
            this.Txt_Cantidad.TabIndex = 123;
            this.Txt_Cantidad.TextChanged += new System.EventHandler(this.pro_Txt_Cantidad_TextChanged);
            this.Txt_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Cantidad_KeyPress);
            // 
            // Txt_Id_Huesped
            // 
            this.Txt_Id_Huesped.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Id_Huesped.Location = new System.Drawing.Point(229, 140);
            this.Txt_Id_Huesped.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Id_Huesped.Name = "Txt_Id_Huesped";
            this.Txt_Id_Huesped.Size = new System.Drawing.Size(233, 22);
            this.Txt_Id_Huesped.TabIndex = 122;
            this.Txt_Id_Huesped.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Id_Huesped_KeyPress);
            // 
            // Pnl_Superior
            // 
            this.Pnl_Superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(142)))), ((int)(((byte)(181)))));
            this.Pnl_Superior.Controls.Add(this.Lbl_Titulo);
            this.Pnl_Superior.Controls.Add(this.Btn_Cambio);
            this.Pnl_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Superior.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Superior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pnl_Superior.Name = "Pnl_Superior";
            this.Pnl_Superior.Size = new System.Drawing.Size(1437, 64);
            this.Pnl_Superior.TabIndex = 121;
            // 
            // Btn_Cambio
            // 
            this.Btn_Cambio.Location = new System.Drawing.Point(1245, 10);
            this.Btn_Cambio.Name = "Btn_Cambio";
            this.Btn_Cambio.Size = new System.Drawing.Size(132, 44);
            this.Btn_Cambio.TabIndex = 150;
            this.Btn_Cambio.Text = "Reservas a la Carta";
            this.Btn_Cambio.UseVisualStyleBackColor = true;
            this.Btn_Cambio.Click += new System.EventHandler(this.pro_button1_Click);
            // 
            // Lbl_Precio
            // 
            this.Lbl_Precio.AutoSize = true;
            this.Lbl_Precio.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Precio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_Precio.Location = new System.Drawing.Point(661, 272);
            this.Lbl_Precio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Precio.Name = "Lbl_Precio";
            this.Lbl_Precio.Size = new System.Drawing.Size(143, 21);
            this.Lbl_Precio.TabIndex = 142;
            this.Lbl_Precio.Text = "Precio Unitario";
            // 
            // Txt_PrecioUni
            // 
            this.Txt_PrecioUni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_PrecioUni.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.Txt_PrecioUni.Location = new System.Drawing.Point(665, 298);
            this.Txt_PrecioUni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_PrecioUni.Name = "Txt_PrecioUni";
            this.Txt_PrecioUni.Size = new System.Drawing.Size(123, 22);
            this.Txt_PrecioUni.TabIndex = 141;
            // 
            // Lbl_Subtotal
            // 
            this.Lbl_Subtotal.AutoSize = true;
            this.Lbl_Subtotal.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Subtotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_Subtotal.Location = new System.Drawing.Point(893, 272);
            this.Lbl_Subtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Subtotal.Name = "Lbl_Subtotal";
            this.Lbl_Subtotal.Size = new System.Drawing.Size(88, 21);
            this.Lbl_Subtotal.TabIndex = 144;
            this.Lbl_Subtotal.Text = "Subtotal:";
            // 
            // Txt_Subtotal
            // 
            this.Txt_Subtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Subtotal.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.Txt_Subtotal.Location = new System.Drawing.Point(897, 298);
            this.Txt_Subtotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Subtotal.Name = "Txt_Subtotal";
            this.Txt_Subtotal.Size = new System.Drawing.Size(123, 22);
            this.Txt_Subtotal.TabIndex = 143;
            // 
            // Dgv_Platos
            // 
            this.Dgv_Platos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Platos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Platos.Location = new System.Drawing.Point(723, 341);
            this.Dgv_Platos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dgv_Platos.Name = "Dgv_Platos";
            this.Dgv_Platos.RowHeadersWidth = 51;
            this.Dgv_Platos.RowTemplate.Height = 24;
            this.Dgv_Platos.Size = new System.Drawing.Size(691, 295);
            this.Dgv_Platos.TabIndex = 146;
            this.Dgv_Platos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pro_Dgv_Platos_CellContentClick);
            // 
            // Btn_Guardar_Plato
            // 
            this.Btn_Guardar_Plato.BackColor = System.Drawing.Color.White;
            this.Btn_Guardar_Plato.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Guardar_Plato.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Guardar_Plato.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Guardar_Plato.Image")));
            this.Btn_Guardar_Plato.Location = new System.Drawing.Point(1245, 221);
            this.Btn_Guardar_Plato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Guardar_Plato.Name = "Btn_Guardar_Plato";
            this.Btn_Guardar_Plato.Size = new System.Drawing.Size(53, 46);
            this.Btn_Guardar_Plato.TabIndex = 147;
            this.Btn_Guardar_Plato.UseVisualStyleBackColor = false;
            this.Btn_Guardar_Plato.Click += new System.EventHandler(this.pro_Btn_Guardar_Plato_Click);
            // 
            // Btn_eliminar_Plato
            // 
            this.Btn_eliminar_Plato.BackColor = System.Drawing.Color.White;
            this.Btn_eliminar_Plato.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminar_Plato.Image = ((System.Drawing.Image)(resources.GetObject("Btn_eliminar_Plato.Image")));
            this.Btn_eliminar_Plato.Location = new System.Drawing.Point(1304, 221);
            this.Btn_eliminar_Plato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_eliminar_Plato.Name = "Btn_eliminar_Plato";
            this.Btn_eliminar_Plato.Size = new System.Drawing.Size(53, 46);
            this.Btn_eliminar_Plato.TabIndex = 148;
            this.Btn_eliminar_Plato.UseVisualStyleBackColor = false;
            this.Btn_eliminar_Plato.Click += new System.EventHandler(this.pro_Btn_eliminar_Plato_Click);
            // 
            // Btn_editar_plato
            // 
            this.Btn_editar_plato.BackColor = System.Drawing.Color.White;
            this.Btn_editar_plato.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_editar_plato.Image = ((System.Drawing.Image)(resources.GetObject("Btn_editar_plato.Image")));
            this.Btn_editar_plato.Location = new System.Drawing.Point(1363, 221);
            this.Btn_editar_plato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_editar_plato.Name = "Btn_editar_plato";
            this.Btn_editar_plato.Size = new System.Drawing.Size(53, 46);
            this.Btn_editar_plato.TabIndex = 149;
            this.Btn_editar_plato.UseVisualStyleBackColor = false;
            this.Btn_editar_plato.Click += new System.EventHandler(this.pro_Btn_editar_plato_Click);
            // 
            // Btn_Reporte
            // 
            this.Btn_Reporte.BackColor = System.Drawing.Color.White;
            this.Btn_Reporte.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Reporte.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Reporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Reporte.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Reporte.Image")));
            this.Btn_Reporte.Location = new System.Drawing.Point(1183, 221);
            this.Btn_Reporte.Name = "Btn_Reporte";
            this.Btn_Reporte.Size = new System.Drawing.Size(56, 46);
            this.Btn_Reporte.TabIndex = 151;
            this.Btn_Reporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Reporte.UseVisualStyleBackColor = false;
            this.Btn_Reporte.Click += new System.EventHandler(this.pro_Btn_Reporte_Click);
            // 
            // Frm_Produccion_Hoteleria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1437, 647);
            this.Controls.Add(this.Btn_Reporte);
            this.Controls.Add(this.Btn_editar_plato);
            this.Controls.Add(this.Btn_eliminar_Plato);
            this.Controls.Add(this.Btn_Guardar_Plato);
            this.Controls.Add(this.Dgv_Platos);
            this.Controls.Add(this.Lbl_Subtotal);
            this.Controls.Add(this.Txt_Subtotal);
            this.Controls.Add(this.Lbl_Precio);
            this.Controls.Add(this.Txt_PrecioUni);
            this.Controls.Add(this.Lbl_Room_Service);
            this.Controls.Add(this.Cbo_Menu);
            this.Controls.Add(this.Cbo_Estado);
            this.Controls.Add(this.Dtp_Fecha);
            this.Controls.Add(this.Lbl_Estado);
            this.Controls.Add(this.Lbl_Habitacion);
            this.Controls.Add(this.Lbl_Cantidad);
            this.Controls.Add(this.Lbl_Fecha);
            this.Controls.Add(this.Lbl_Id_Menu);
            this.Controls.Add(this.Lbl_Id_Habitacion);
            this.Controls.Add(this.Lbl_Id_huesped);
            this.Controls.Add(this.Btn_modificar);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Dgv_Room_Service);
            this.Controls.Add(this.Txt_Id_Habitacion);
            this.Controls.Add(this.Txt_ID_Pedido);
            this.Controls.Add(this.Txt_Cantidad);
            this.Controls.Add(this.Txt_Id_Huesped);
            this.Controls.Add(this.Pnl_Superior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Frm_Produccion_Hoteleria";
            this.Text = "Frm_Producion_Hoteleria2";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Room_Service)).EndInit();
            this.Pnl_Superior.ResumeLayout(false);
            this.Pnl_Superior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Platos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_Room_Service;
        private System.Windows.Forms.ComboBox Cbo_Menu;
        private System.Windows.Forms.ComboBox Cbo_Estado;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha;
        private System.Windows.Forms.Label Lbl_Estado;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Label Lbl_Habitacion;
        private System.Windows.Forms.Label Lbl_Cantidad;
        private System.Windows.Forms.Label Lbl_Fecha;
        private System.Windows.Forms.Label Lbl_Id_Menu;
        private System.Windows.Forms.Label Lbl_Id_Habitacion;
        private System.Windows.Forms.Label Lbl_Id_huesped;
        private System.Windows.Forms.Button Btn_modificar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.DataGridView Dgv_Room_Service;
        private System.Windows.Forms.TextBox Txt_Id_Habitacion;
        private System.Windows.Forms.TextBox Txt_ID_Pedido;
        private System.Windows.Forms.TextBox Txt_Cantidad;
        private System.Windows.Forms.TextBox Txt_Id_Huesped;
        private System.Windows.Forms.Panel Pnl_Superior;
        private System.Windows.Forms.Label Lbl_Precio;
        private System.Windows.Forms.TextBox Txt_PrecioUni;
        private System.Windows.Forms.Label Lbl_Subtotal;
        private System.Windows.Forms.TextBox Txt_Subtotal;
        private System.Windows.Forms.DataGridView Dgv_Platos;
        private System.Windows.Forms.Button Btn_Guardar_Plato;
        private System.Windows.Forms.Button Btn_eliminar_Plato;
        private System.Windows.Forms.Button Btn_editar_plato;
        private System.Windows.Forms.Button Btn_Cambio;
        private System.Windows.Forms.Button Btn_Reporte;
    }
}