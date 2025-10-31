
namespace Capa_Vista_Inventario
{
    partial class Frm_Inventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Pnl_Principal = new System.Windows.Forms.Panel();
            this.Lbl_Productos_Hotel = new System.Windows.Forms.Label();
            this.Gpb_Descripcion_Producto = new System.Windows.Forms.GroupBox();
            this.Txt_Existencias_Globales_Producto = new System.Windows.Forms.TextBox();
            this.Lbl_Existencias_Globales_Producto = new System.Windows.Forms.Label();
            this.Lbl_Precio_Venta_Producto = new System.Windows.Forms.Label();
            this.Txt_Precio_Venta_Producto = new System.Windows.Forms.TextBox();
            this.Lbl_Marca_Producto = new System.Windows.Forms.Label();
            this.Txt_Marca_Producto = new System.Windows.Forms.TextBox();
            this.Dtp_Fecha_Vencimiento_Producto = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Fecha_Vencimiento = new System.Windows.Forms.Label();
            this.Lbl_Fecha_Ingreso = new System.Windows.Forms.Label();
            this.Dtp_Fecha_Ingreso_Producto = new System.Windows.Forms.DateTimePicker();
            this.Cbo_Cod_Producto = new System.Windows.Forms.ComboBox();
            this.Lbl_Cod_Producto = new System.Windows.Forms.Label();
            this.Cbo_Unidad_Medida_Producto = new System.Windows.Forms.ComboBox();
            this.Cbo_Estado_Producto = new System.Windows.Forms.ComboBox();
            this.Lbl_Estado_Producto = new System.Windows.Forms.Label();
            this.Lbl_Unidad_Medida_Producto = new System.Windows.Forms.Label();
            this.Lbl_Cantidad_Producto = new System.Windows.Forms.Label();
            this.Txt_Cantidad_Producto = new System.Windows.Forms.TextBox();
            this.Lbl_Precio_Unitario_Producto = new System.Windows.Forms.Label();
            this.Txt_Costo_Unitario_Producto = new System.Windows.Forms.TextBox();
            this.Lbl_Nombre_Producto = new System.Windows.Forms.Label();
            this.Txt_Nombre_Producto = new System.Windows.Forms.TextBox();
            this.Gpb_Gestion_Inventario = new System.Windows.Forms.GroupBox();
            this.Btn_Cierre_Inventario = new System.Windows.Forms.Button();
            this.Btn_Agregar_Producto = new System.Windows.Forms.Button();
            this.Btn_Modificar_Producto = new System.Windows.Forms.Button();
            this.Btn_Eliminar_Producto = new System.Windows.Forms.Button();
            this.Gpb_Tipo_Producto = new System.Windows.Forms.GroupBox();
            this.Rdb_Ropa_Blanca_Lenceria = new System.Windows.Forms.RadioButton();
            this.Rdb_Producto_Cortesía = new System.Windows.Forms.RadioButton();
            this.Rdb_Producto_Seguridad_Emergencia = new System.Windows.Forms.RadioButton();
            this.Rdb_Producto_Suministros_Oficina = new System.Windows.Forms.RadioButton();
            this.Rdb_Producto_Mobiliario_Equipo = new System.Windows.Forms.RadioButton();
            this.Rdb_Producto_Equipos_Cocina = new System.Windows.Forms.RadioButton();
            this.Rdb_Producto_Alimentos_Bebidas = new System.Windows.Forms.RadioButton();
            this.Rdb_Producto_Limpieza_Mantenimiento = new System.Windows.Forms.RadioButton();
            this.Pnl_Vista_Producto = new System.Windows.Forms.Panel();
            this.Dgv_Vista_Producto = new System.Windows.Forms.DataGridView();
            this.Cbo_Almacen_Producto = new System.Windows.Forms.ComboBox();
            this.Lbl_Almacen_Producto = new System.Windows.Forms.Label();
            this.Pnl_Principal.SuspendLayout();
            this.Gpb_Descripcion_Producto.SuspendLayout();
            this.Gpb_Gestion_Inventario.SuspendLayout();
            this.Gpb_Tipo_Producto.SuspendLayout();
            this.Pnl_Vista_Producto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Vista_Producto)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_Principal
            // 
            this.Pnl_Principal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_Principal.Controls.Add(this.Lbl_Productos_Hotel);
            this.Pnl_Principal.Controls.Add(this.Gpb_Descripcion_Producto);
            this.Pnl_Principal.Controls.Add(this.Gpb_Gestion_Inventario);
            this.Pnl_Principal.Controls.Add(this.Gpb_Tipo_Producto);
            this.Pnl_Principal.Location = new System.Drawing.Point(12, 12);
            this.Pnl_Principal.Name = "Pnl_Principal";
            this.Pnl_Principal.Size = new System.Drawing.Size(960, 350);
            this.Pnl_Principal.TabIndex = 0;
            // 
            // Lbl_Productos_Hotel
            // 
            this.Lbl_Productos_Hotel.AutoSize = true;
            this.Lbl_Productos_Hotel.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Productos_Hotel.Location = new System.Drawing.Point(3, 3);
            this.Lbl_Productos_Hotel.Name = "Lbl_Productos_Hotel";
            this.Lbl_Productos_Hotel.Size = new System.Drawing.Size(235, 29);
            this.Lbl_Productos_Hotel.TabIndex = 5;
            this.Lbl_Productos_Hotel.Text = "Productos de Hotel";
            // 
            // Gpb_Descripcion_Producto
            // 
            this.Gpb_Descripcion_Producto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gpb_Descripcion_Producto.Controls.Add(this.Cbo_Almacen_Producto);
            this.Gpb_Descripcion_Producto.Controls.Add(this.Lbl_Almacen_Producto);
            this.Gpb_Descripcion_Producto.Controls.Add(this.Txt_Existencias_Globales_Producto);
            this.Gpb_Descripcion_Producto.Controls.Add(this.Lbl_Existencias_Globales_Producto);
            this.Gpb_Descripcion_Producto.Controls.Add(this.Lbl_Precio_Venta_Producto);
            this.Gpb_Descripcion_Producto.Controls.Add(this.Txt_Precio_Venta_Producto);
            this.Gpb_Descripcion_Producto.Controls.Add(this.Lbl_Marca_Producto);
            this.Gpb_Descripcion_Producto.Controls.Add(this.Txt_Marca_Producto);
            this.Gpb_Descripcion_Producto.Controls.Add(this.Dtp_Fecha_Vencimiento_Producto);
            this.Gpb_Descripcion_Producto.Controls.Add(this.Lbl_Fecha_Vencimiento);
            this.Gpb_Descripcion_Producto.Controls.Add(this.Lbl_Fecha_Ingreso);
            this.Gpb_Descripcion_Producto.Controls.Add(this.Dtp_Fecha_Ingreso_Producto);
            this.Gpb_Descripcion_Producto.Controls.Add(this.Cbo_Cod_Producto);
            this.Gpb_Descripcion_Producto.Controls.Add(this.Lbl_Cod_Producto);
            this.Gpb_Descripcion_Producto.Controls.Add(this.Cbo_Unidad_Medida_Producto);
            this.Gpb_Descripcion_Producto.Controls.Add(this.Cbo_Estado_Producto);
            this.Gpb_Descripcion_Producto.Controls.Add(this.Lbl_Estado_Producto);
            this.Gpb_Descripcion_Producto.Controls.Add(this.Lbl_Unidad_Medida_Producto);
            this.Gpb_Descripcion_Producto.Controls.Add(this.Lbl_Cantidad_Producto);
            this.Gpb_Descripcion_Producto.Controls.Add(this.Txt_Cantidad_Producto);
            this.Gpb_Descripcion_Producto.Controls.Add(this.Lbl_Precio_Unitario_Producto);
            this.Gpb_Descripcion_Producto.Controls.Add(this.Txt_Costo_Unitario_Producto);
            this.Gpb_Descripcion_Producto.Controls.Add(this.Lbl_Nombre_Producto);
            this.Gpb_Descripcion_Producto.Controls.Add(this.Txt_Nombre_Producto);
            this.Gpb_Descripcion_Producto.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Descripcion_Producto.Location = new System.Drawing.Point(3, 134);
            this.Gpb_Descripcion_Producto.Name = "Gpb_Descripcion_Producto";
            this.Gpb_Descripcion_Producto.Size = new System.Drawing.Size(954, 213);
            this.Gpb_Descripcion_Producto.TabIndex = 4;
            this.Gpb_Descripcion_Producto.TabStop = false;
            this.Gpb_Descripcion_Producto.Text = "Descripcion de Producto";
            // 
            // Txt_Existencias_Globales_Producto
            // 
            this.Txt_Existencias_Globales_Producto.Location = new System.Drawing.Point(584, 81);
            this.Txt_Existencias_Globales_Producto.MaxLength = 10;
            this.Txt_Existencias_Globales_Producto.Name = "Txt_Existencias_Globales_Producto";
            this.Txt_Existencias_Globales_Producto.Size = new System.Drawing.Size(141, 25);
            this.Txt_Existencias_Globales_Producto.TabIndex = 27;
            // 
            // Lbl_Existencias_Globales_Producto
            // 
            this.Lbl_Existencias_Globales_Producto.AutoSize = true;
            this.Lbl_Existencias_Globales_Producto.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Existencias_Globales_Producto.Location = new System.Drawing.Point(413, 84);
            this.Lbl_Existencias_Globales_Producto.Name = "Lbl_Existencias_Globales_Producto";
            this.Lbl_Existencias_Globales_Producto.Size = new System.Drawing.Size(157, 17);
            this.Lbl_Existencias_Globales_Producto.TabIndex = 26;
            this.Lbl_Existencias_Globales_Producto.Text = "Existencias Globales";
            // 
            // Lbl_Precio_Venta_Producto
            // 
            this.Lbl_Precio_Venta_Producto.AutoSize = true;
            this.Lbl_Precio_Venta_Producto.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Precio_Venta_Producto.Location = new System.Drawing.Point(6, 178);
            this.Lbl_Precio_Venta_Producto.Name = "Lbl_Precio_Venta_Producto";
            this.Lbl_Precio_Venta_Producto.Size = new System.Drawing.Size(100, 17);
            this.Lbl_Precio_Venta_Producto.TabIndex = 23;
            this.Lbl_Precio_Venta_Producto.Text = "Precio Venta";
            // 
            // Txt_Precio_Venta_Producto
            // 
            this.Txt_Precio_Venta_Producto.Location = new System.Drawing.Point(140, 175);
            this.Txt_Precio_Venta_Producto.MaxLength = 10;
            this.Txt_Precio_Venta_Producto.Name = "Txt_Precio_Venta_Producto";
            this.Txt_Precio_Venta_Producto.Size = new System.Drawing.Size(147, 25);
            this.Txt_Precio_Venta_Producto.TabIndex = 22;
            // 
            // Lbl_Marca_Producto
            // 
            this.Lbl_Marca_Producto.AutoSize = true;
            this.Lbl_Marca_Producto.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Marca_Producto.Location = new System.Drawing.Point(6, 84);
            this.Lbl_Marca_Producto.Name = "Lbl_Marca_Producto";
            this.Lbl_Marca_Producto.Size = new System.Drawing.Size(51, 17);
            this.Lbl_Marca_Producto.TabIndex = 21;
            this.Lbl_Marca_Producto.Text = "Marca";
            // 
            // Txt_Marca_Producto
            // 
            this.Txt_Marca_Producto.Location = new System.Drawing.Point(140, 81);
            this.Txt_Marca_Producto.MaxLength = 20;
            this.Txt_Marca_Producto.Name = "Txt_Marca_Producto";
            this.Txt_Marca_Producto.Size = new System.Drawing.Size(220, 25);
            this.Txt_Marca_Producto.TabIndex = 20;
            // 
            // Dtp_Fecha_Vencimiento_Producto
            // 
            this.Dtp_Fecha_Vencimiento_Producto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_Fecha_Vencimiento_Producto.Location = new System.Drawing.Point(584, 143);
            this.Dtp_Fecha_Vencimiento_Producto.Name = "Dtp_Fecha_Vencimiento_Producto";
            this.Dtp_Fecha_Vencimiento_Producto.Size = new System.Drawing.Size(142, 25);
            this.Dtp_Fecha_Vencimiento_Producto.TabIndex = 19;
            this.Dtp_Fecha_Vencimiento_Producto.Value = new System.DateTime(2025, 10, 26, 0, 0, 0, 0);
            // 
            // Lbl_Fecha_Vencimiento
            // 
            this.Lbl_Fecha_Vencimiento.AutoSize = true;
            this.Lbl_Fecha_Vencimiento.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha_Vencimiento.Location = new System.Drawing.Point(413, 148);
            this.Lbl_Fecha_Vencimiento.Name = "Lbl_Fecha_Vencimiento";
            this.Lbl_Fecha_Vencimiento.Size = new System.Drawing.Size(146, 17);
            this.Lbl_Fecha_Vencimiento.TabIndex = 18;
            this.Lbl_Fecha_Vencimiento.Text = "Fecha Vencimiento";
            // 
            // Lbl_Fecha_Ingreso
            // 
            this.Lbl_Fecha_Ingreso.AutoSize = true;
            this.Lbl_Fecha_Ingreso.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha_Ingreso.Location = new System.Drawing.Point(413, 117);
            this.Lbl_Fecha_Ingreso.Name = "Lbl_Fecha_Ingreso";
            this.Lbl_Fecha_Ingreso.Size = new System.Drawing.Size(108, 17);
            this.Lbl_Fecha_Ingreso.TabIndex = 17;
            this.Lbl_Fecha_Ingreso.Text = "Fecha Ingreso";
            // 
            // Dtp_Fecha_Ingreso_Producto
            // 
            this.Dtp_Fecha_Ingreso_Producto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_Fecha_Ingreso_Producto.Location = new System.Drawing.Point(583, 112);
            this.Dtp_Fecha_Ingreso_Producto.Name = "Dtp_Fecha_Ingreso_Producto";
            this.Dtp_Fecha_Ingreso_Producto.Size = new System.Drawing.Size(142, 25);
            this.Dtp_Fecha_Ingreso_Producto.TabIndex = 16;
            this.Dtp_Fecha_Ingreso_Producto.Value = new System.DateTime(2025, 10, 26, 0, 0, 0, 0);
            // 
            // Cbo_Cod_Producto
            // 
            this.Cbo_Cod_Producto.FormattingEnabled = true;
            this.Cbo_Cod_Producto.Items.AddRange(new object[] {
            "LIMP",
            "COR",
            "COC",
            "LENC",
            "SUM",
            "MOB",
            "ALIM",
            "SEG"});
            this.Cbo_Cod_Producto.Location = new System.Drawing.Point(140, 18);
            this.Cbo_Cod_Producto.Name = "Cbo_Cod_Producto";
            this.Cbo_Cod_Producto.Size = new System.Drawing.Size(147, 26);
            this.Cbo_Cod_Producto.TabIndex = 15;
            // 
            // Lbl_Cod_Producto
            // 
            this.Lbl_Cod_Producto.AutoSize = true;
            this.Lbl_Cod_Producto.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cod_Producto.Location = new System.Drawing.Point(6, 21);
            this.Lbl_Cod_Producto.Name = "Lbl_Cod_Producto";
            this.Lbl_Cod_Producto.Size = new System.Drawing.Size(128, 17);
            this.Lbl_Cod_Producto.TabIndex = 14;
            this.Lbl_Cod_Producto.Text = "Codigo Producto";
            // 
            // Cbo_Unidad_Medida_Producto
            // 
            this.Cbo_Unidad_Medida_Producto.FormattingEnabled = true;
            this.Cbo_Unidad_Medida_Producto.Items.AddRange(new object[] {
            "Unidad (und)",
            "Libra (lb)",
            "Kilogramo (kg)",
            "Litro (L)",
            "Mililitro (ml)",
            "Caja (caja)",
            "Paquete (paq)",
            "Bolsa (bolsa)",
            "Docena (doc)",
            "Rollo (rollo)",
            "Botella (bot)",
            "Bandeja (band)",
            "Porción (porc)",
            "Juego (jgo)",
            "Set (set)",
            "Metro (m)",
            "Galón (gal)"});
            this.Cbo_Unidad_Medida_Producto.Location = new System.Drawing.Point(140, 112);
            this.Cbo_Unidad_Medida_Producto.Name = "Cbo_Unidad_Medida_Producto";
            this.Cbo_Unidad_Medida_Producto.Size = new System.Drawing.Size(147, 26);
            this.Cbo_Unidad_Medida_Producto.TabIndex = 13;
            // 
            // Cbo_Estado_Producto
            // 
            this.Cbo_Estado_Producto.FormattingEnabled = true;
            this.Cbo_Estado_Producto.Location = new System.Drawing.Point(583, 49);
            this.Cbo_Estado_Producto.Name = "Cbo_Estado_Producto";
            this.Cbo_Estado_Producto.Size = new System.Drawing.Size(142, 26);
            this.Cbo_Estado_Producto.TabIndex = 12;
            // 
            // Lbl_Estado_Producto
            // 
            this.Lbl_Estado_Producto.AutoSize = true;
            this.Lbl_Estado_Producto.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Estado_Producto.Location = new System.Drawing.Point(413, 53);
            this.Lbl_Estado_Producto.Name = "Lbl_Estado_Producto";
            this.Lbl_Estado_Producto.Size = new System.Drawing.Size(150, 17);
            this.Lbl_Estado_Producto.TabIndex = 11;
            this.Lbl_Estado_Producto.Text = "Estado del Producto";
            // 
            // Lbl_Unidad_Medida_Producto
            // 
            this.Lbl_Unidad_Medida_Producto.AutoSize = true;
            this.Lbl_Unidad_Medida_Producto.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Unidad_Medida_Producto.Location = new System.Drawing.Point(6, 115);
            this.Lbl_Unidad_Medida_Producto.Name = "Lbl_Unidad_Medida_Producto";
            this.Lbl_Unidad_Medida_Producto.Size = new System.Drawing.Size(115, 17);
            this.Lbl_Unidad_Medida_Producto.TabIndex = 9;
            this.Lbl_Unidad_Medida_Producto.Text = "Unidad Medida";
            // 
            // Lbl_Cantidad_Producto
            // 
            this.Lbl_Cantidad_Producto.AutoSize = true;
            this.Lbl_Cantidad_Producto.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cantidad_Producto.Location = new System.Drawing.Point(413, 21);
            this.Lbl_Cantidad_Producto.Name = "Lbl_Cantidad_Producto";
            this.Lbl_Cantidad_Producto.Size = new System.Drawing.Size(72, 17);
            this.Lbl_Cantidad_Producto.TabIndex = 7;
            this.Lbl_Cantidad_Producto.Text = "Cantidad";
            // 
            // Txt_Cantidad_Producto
            // 
            this.Txt_Cantidad_Producto.Location = new System.Drawing.Point(583, 18);
            this.Txt_Cantidad_Producto.MaxLength = 5;
            this.Txt_Cantidad_Producto.Name = "Txt_Cantidad_Producto";
            this.Txt_Cantidad_Producto.Size = new System.Drawing.Size(142, 25);
            this.Txt_Cantidad_Producto.TabIndex = 6;
            // 
            // Lbl_Precio_Unitario_Producto
            // 
            this.Lbl_Precio_Unitario_Producto.AutoSize = true;
            this.Lbl_Precio_Unitario_Producto.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Precio_Unitario_Producto.Location = new System.Drawing.Point(6, 147);
            this.Lbl_Precio_Unitario_Producto.Name = "Lbl_Precio_Unitario_Producto";
            this.Lbl_Precio_Unitario_Producto.Size = new System.Drawing.Size(110, 17);
            this.Lbl_Precio_Unitario_Producto.TabIndex = 5;
            this.Lbl_Precio_Unitario_Producto.Text = "Costo Unitario";
            // 
            // Txt_Costo_Unitario_Producto
            // 
            this.Txt_Costo_Unitario_Producto.Location = new System.Drawing.Point(140, 144);
            this.Txt_Costo_Unitario_Producto.MaxLength = 10;
            this.Txt_Costo_Unitario_Producto.Name = "Txt_Costo_Unitario_Producto";
            this.Txt_Costo_Unitario_Producto.Size = new System.Drawing.Size(147, 25);
            this.Txt_Costo_Unitario_Producto.TabIndex = 4;
            // 
            // Lbl_Nombre_Producto
            // 
            this.Lbl_Nombre_Producto.AutoSize = true;
            this.Lbl_Nombre_Producto.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nombre_Producto.Location = new System.Drawing.Point(6, 52);
            this.Lbl_Nombre_Producto.Name = "Lbl_Nombre_Producto";
            this.Lbl_Nombre_Producto.Size = new System.Drawing.Size(66, 17);
            this.Lbl_Nombre_Producto.TabIndex = 2;
            this.Lbl_Nombre_Producto.Text = "Nombre";
            // 
            // Txt_Nombre_Producto
            // 
            this.Txt_Nombre_Producto.Location = new System.Drawing.Point(140, 50);
            this.Txt_Nombre_Producto.MaxLength = 30;
            this.Txt_Nombre_Producto.Name = "Txt_Nombre_Producto";
            this.Txt_Nombre_Producto.Size = new System.Drawing.Size(267, 25);
            this.Txt_Nombre_Producto.TabIndex = 3;
            // 
            // Gpb_Gestion_Inventario
            // 
            this.Gpb_Gestion_Inventario.Controls.Add(this.Btn_Cierre_Inventario);
            this.Gpb_Gestion_Inventario.Controls.Add(this.Btn_Agregar_Producto);
            this.Gpb_Gestion_Inventario.Controls.Add(this.Btn_Modificar_Producto);
            this.Gpb_Gestion_Inventario.Controls.Add(this.Btn_Eliminar_Producto);
            this.Gpb_Gestion_Inventario.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Gestion_Inventario.Location = new System.Drawing.Point(3, 35);
            this.Gpb_Gestion_Inventario.Name = "Gpb_Gestion_Inventario";
            this.Gpb_Gestion_Inventario.Size = new System.Drawing.Size(398, 54);
            this.Gpb_Gestion_Inventario.TabIndex = 2;
            this.Gpb_Gestion_Inventario.TabStop = false;
            this.Gpb_Gestion_Inventario.Text = "Gestion de Inventario";
            // 
            // Btn_Cierre_Inventario
            // 
            this.Btn_Cierre_Inventario.BackColor = System.Drawing.Color.IndianRed;
            this.Btn_Cierre_Inventario.Location = new System.Drawing.Point(6, 18);
            this.Btn_Cierre_Inventario.Name = "Btn_Cierre_Inventario";
            this.Btn_Cierre_Inventario.Size = new System.Drawing.Size(81, 30);
            this.Btn_Cierre_Inventario.TabIndex = 4;
            this.Btn_Cierre_Inventario.Text = "Cierre";
            this.Btn_Cierre_Inventario.UseVisualStyleBackColor = false;
            this.Btn_Cierre_Inventario.Click += new System.EventHandler(this.Btn_Cierre_Inventario_Click);
            // 
            // Btn_Agregar_Producto
            // 
            this.Btn_Agregar_Producto.Location = new System.Drawing.Point(93, 18);
            this.Btn_Agregar_Producto.Name = "Btn_Agregar_Producto";
            this.Btn_Agregar_Producto.Size = new System.Drawing.Size(94, 30);
            this.Btn_Agregar_Producto.TabIndex = 1;
            this.Btn_Agregar_Producto.Text = "Agregar";
            this.Btn_Agregar_Producto.UseVisualStyleBackColor = true;
            // 
            // Btn_Modificar_Producto
            // 
            this.Btn_Modificar_Producto.Location = new System.Drawing.Point(193, 18);
            this.Btn_Modificar_Producto.Name = "Btn_Modificar_Producto";
            this.Btn_Modificar_Producto.Size = new System.Drawing.Size(94, 30);
            this.Btn_Modificar_Producto.TabIndex = 2;
            this.Btn_Modificar_Producto.Text = "Modificar";
            this.Btn_Modificar_Producto.UseVisualStyleBackColor = true;
            // 
            // Btn_Eliminar_Producto
            // 
            this.Btn_Eliminar_Producto.Location = new System.Drawing.Point(293, 18);
            this.Btn_Eliminar_Producto.Name = "Btn_Eliminar_Producto";
            this.Btn_Eliminar_Producto.Size = new System.Drawing.Size(94, 30);
            this.Btn_Eliminar_Producto.TabIndex = 3;
            this.Btn_Eliminar_Producto.Text = "Eliminar";
            this.Btn_Eliminar_Producto.UseVisualStyleBackColor = true;
            // 
            // Gpb_Tipo_Producto
            // 
            this.Gpb_Tipo_Producto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Gpb_Tipo_Producto.Controls.Add(this.Rdb_Ropa_Blanca_Lenceria);
            this.Gpb_Tipo_Producto.Controls.Add(this.Rdb_Producto_Cortesía);
            this.Gpb_Tipo_Producto.Controls.Add(this.Rdb_Producto_Seguridad_Emergencia);
            this.Gpb_Tipo_Producto.Controls.Add(this.Rdb_Producto_Suministros_Oficina);
            this.Gpb_Tipo_Producto.Controls.Add(this.Rdb_Producto_Mobiliario_Equipo);
            this.Gpb_Tipo_Producto.Controls.Add(this.Rdb_Producto_Equipos_Cocina);
            this.Gpb_Tipo_Producto.Controls.Add(this.Rdb_Producto_Alimentos_Bebidas);
            this.Gpb_Tipo_Producto.Controls.Add(this.Rdb_Producto_Limpieza_Mantenimiento);
            this.Gpb_Tipo_Producto.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Tipo_Producto.Location = new System.Drawing.Point(407, 3);
            this.Gpb_Tipo_Producto.Name = "Gpb_Tipo_Producto";
            this.Gpb_Tipo_Producto.Size = new System.Drawing.Size(544, 132);
            this.Gpb_Tipo_Producto.TabIndex = 1;
            this.Gpb_Tipo_Producto.TabStop = false;
            this.Gpb_Tipo_Producto.Text = "Tipo de Producto";
            // 
            // Rdb_Ropa_Blanca_Lenceria
            // 
            this.Rdb_Ropa_Blanca_Lenceria.AutoSize = true;
            this.Rdb_Ropa_Blanca_Lenceria.Location = new System.Drawing.Point(239, 50);
            this.Rdb_Ropa_Blanca_Lenceria.Name = "Rdb_Ropa_Blanca_Lenceria";
            this.Rdb_Ropa_Blanca_Lenceria.Size = new System.Drawing.Size(201, 22);
            this.Rdb_Ropa_Blanca_Lenceria.TabIndex = 8;
            this.Rdb_Ropa_Blanca_Lenceria.TabStop = true;
            this.Rdb_Ropa_Blanca_Lenceria.Text = "Ropa Blanca y Lencería";
            this.Rdb_Ropa_Blanca_Lenceria.UseVisualStyleBackColor = true;
            // 
            // Rdb_Producto_Cortesía
            // 
            this.Rdb_Producto_Cortesía.AutoSize = true;
            this.Rdb_Producto_Cortesía.Location = new System.Drawing.Point(239, 22);
            this.Rdb_Producto_Cortesía.Name = "Rdb_Producto_Cortesía";
            this.Rdb_Producto_Cortesía.Size = new System.Drawing.Size(90, 22);
            this.Rdb_Producto_Cortesía.TabIndex = 7;
            this.Rdb_Producto_Cortesía.TabStop = true;
            this.Rdb_Producto_Cortesía.Text = "Cortesía";
            this.Rdb_Producto_Cortesía.UseVisualStyleBackColor = true;
            // 
            // Rdb_Producto_Seguridad_Emergencia
            // 
            this.Rdb_Producto_Seguridad_Emergencia.AutoSize = true;
            this.Rdb_Producto_Seguridad_Emergencia.Location = new System.Drawing.Point(239, 103);
            this.Rdb_Producto_Seguridad_Emergencia.Name = "Rdb_Producto_Seguridad_Emergencia";
            this.Rdb_Producto_Seguridad_Emergencia.Size = new System.Drawing.Size(207, 22);
            this.Rdb_Producto_Seguridad_Emergencia.TabIndex = 6;
            this.Rdb_Producto_Seguridad_Emergencia.TabStop = true;
            this.Rdb_Producto_Seguridad_Emergencia.Text = "Seguridad y Emergencia";
            this.Rdb_Producto_Seguridad_Emergencia.UseVisualStyleBackColor = true;
            // 
            // Rdb_Producto_Suministros_Oficina
            // 
            this.Rdb_Producto_Suministros_Oficina.AutoSize = true;
            this.Rdb_Producto_Suministros_Oficina.Location = new System.Drawing.Point(6, 78);
            this.Rdb_Producto_Suministros_Oficina.Name = "Rdb_Producto_Suministros_Oficina";
            this.Rdb_Producto_Suministros_Oficina.Size = new System.Drawing.Size(194, 22);
            this.Rdb_Producto_Suministros_Oficina.TabIndex = 5;
            this.Rdb_Producto_Suministros_Oficina.TabStop = true;
            this.Rdb_Producto_Suministros_Oficina.Text = "Suministros de Oficina";
            this.Rdb_Producto_Suministros_Oficina.UseVisualStyleBackColor = true;
            // 
            // Rdb_Producto_Mobiliario_Equipo
            // 
            this.Rdb_Producto_Mobiliario_Equipo.AutoSize = true;
            this.Rdb_Producto_Mobiliario_Equipo.Location = new System.Drawing.Point(239, 78);
            this.Rdb_Producto_Mobiliario_Equipo.Name = "Rdb_Producto_Mobiliario_Equipo";
            this.Rdb_Producto_Mobiliario_Equipo.Size = new System.Drawing.Size(173, 22);
            this.Rdb_Producto_Mobiliario_Equipo.TabIndex = 4;
            this.Rdb_Producto_Mobiliario_Equipo.TabStop = true;
            this.Rdb_Producto_Mobiliario_Equipo.Text = "Mobiliario y Equipo";
            this.Rdb_Producto_Mobiliario_Equipo.UseVisualStyleBackColor = true;
            // 
            // Rdb_Producto_Equipos_Cocina
            // 
            this.Rdb_Producto_Equipos_Cocina.AutoSize = true;
            this.Rdb_Producto_Equipos_Cocina.Location = new System.Drawing.Point(6, 50);
            this.Rdb_Producto_Equipos_Cocina.Name = "Rdb_Producto_Equipos_Cocina";
            this.Rdb_Producto_Equipos_Cocina.Size = new System.Drawing.Size(163, 22);
            this.Rdb_Producto_Equipos_Cocina.TabIndex = 3;
            this.Rdb_Producto_Equipos_Cocina.TabStop = true;
            this.Rdb_Producto_Equipos_Cocina.Text = "Equipos de Cocina";
            this.Rdb_Producto_Equipos_Cocina.UseVisualStyleBackColor = true;
            // 
            // Rdb_Producto_Alimentos_Bebidas
            // 
            this.Rdb_Producto_Alimentos_Bebidas.AutoSize = true;
            this.Rdb_Producto_Alimentos_Bebidas.Location = new System.Drawing.Point(6, 103);
            this.Rdb_Producto_Alimentos_Bebidas.Name = "Rdb_Producto_Alimentos_Bebidas";
            this.Rdb_Producto_Alimentos_Bebidas.Size = new System.Drawing.Size(177, 22);
            this.Rdb_Producto_Alimentos_Bebidas.TabIndex = 2;
            this.Rdb_Producto_Alimentos_Bebidas.TabStop = true;
            this.Rdb_Producto_Alimentos_Bebidas.Text = "Alimentos y Bebidas";
            this.Rdb_Producto_Alimentos_Bebidas.UseVisualStyleBackColor = true;
            // 
            // Rdb_Producto_Limpieza_Mantenimiento
            // 
            this.Rdb_Producto_Limpieza_Mantenimiento.AutoSize = true;
            this.Rdb_Producto_Limpieza_Mantenimiento.Location = new System.Drawing.Point(6, 22);
            this.Rdb_Producto_Limpieza_Mantenimiento.Name = "Rdb_Producto_Limpieza_Mantenimiento";
            this.Rdb_Producto_Limpieza_Mantenimiento.Size = new System.Drawing.Size(227, 22);
            this.Rdb_Producto_Limpieza_Mantenimiento.TabIndex = 0;
            this.Rdb_Producto_Limpieza_Mantenimiento.TabStop = true;
            this.Rdb_Producto_Limpieza_Mantenimiento.Text = "Limpieza y Mantenimiento";
            this.Rdb_Producto_Limpieza_Mantenimiento.UseVisualStyleBackColor = true;
            // 
            // Pnl_Vista_Producto
            // 
            this.Pnl_Vista_Producto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_Vista_Producto.Controls.Add(this.Dgv_Vista_Producto);
            this.Pnl_Vista_Producto.Location = new System.Drawing.Point(12, 368);
            this.Pnl_Vista_Producto.Name = "Pnl_Vista_Producto";
            this.Pnl_Vista_Producto.Size = new System.Drawing.Size(960, 381);
            this.Pnl_Vista_Producto.TabIndex = 1;
            // 
            // Dgv_Vista_Producto
            // 
            this.Dgv_Vista_Producto.AllowUserToAddRows = false;
            this.Dgv_Vista_Producto.AllowUserToDeleteRows = false;
            this.Dgv_Vista_Producto.AllowUserToResizeRows = false;
            this.Dgv_Vista_Producto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Vista_Producto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dgv_Vista_Producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Vista_Producto.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_Vista_Producto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_Vista_Producto.Location = new System.Drawing.Point(0, 0);
            this.Dgv_Vista_Producto.MultiSelect = false;
            this.Dgv_Vista_Producto.Name = "Dgv_Vista_Producto";
            this.Dgv_Vista_Producto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Dgv_Vista_Producto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgv_Vista_Producto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Vista_Producto.Size = new System.Drawing.Size(960, 381);
            this.Dgv_Vista_Producto.TabIndex = 0;
            // 
            // Cbo_Almacen_Producto
            // 
            this.Cbo_Almacen_Producto.FormattingEnabled = true;
            this.Cbo_Almacen_Producto.Location = new System.Drawing.Point(584, 174);
            this.Cbo_Almacen_Producto.Name = "Cbo_Almacen_Producto";
            this.Cbo_Almacen_Producto.Size = new System.Drawing.Size(142, 26);
            this.Cbo_Almacen_Producto.TabIndex = 29;
            // 
            // Lbl_Almacen_Producto
            // 
            this.Lbl_Almacen_Producto.AutoSize = true;
            this.Lbl_Almacen_Producto.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Almacen_Producto.Location = new System.Drawing.Point(413, 177);
            this.Lbl_Almacen_Producto.Name = "Lbl_Almacen_Producto";
            this.Lbl_Almacen_Producto.Size = new System.Drawing.Size(165, 17);
            this.Lbl_Almacen_Producto.TabIndex = 28;
            this.Lbl_Almacen_Producto.Text = "Almacen del Producto";
            // 
            // Frm_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.Pnl_Vista_Producto);
            this.Controls.Add(this.Pnl_Principal);
            this.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1000, 800);
            this.Name = "Frm_Inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Pnl_Principal.ResumeLayout(false);
            this.Pnl_Principal.PerformLayout();
            this.Gpb_Descripcion_Producto.ResumeLayout(false);
            this.Gpb_Descripcion_Producto.PerformLayout();
            this.Gpb_Gestion_Inventario.ResumeLayout(false);
            this.Gpb_Tipo_Producto.ResumeLayout(false);
            this.Gpb_Tipo_Producto.PerformLayout();
            this.Pnl_Vista_Producto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Vista_Producto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Principal;
        private System.Windows.Forms.Panel Pnl_Vista_Producto;
        private System.Windows.Forms.DataGridView Dgv_Vista_Producto;
        private System.Windows.Forms.GroupBox Gpb_Tipo_Producto;
        private System.Windows.Forms.GroupBox Gpb_Gestion_Inventario;
        private System.Windows.Forms.RadioButton Rdb_Producto_Alimentos_Bebidas;
        private System.Windows.Forms.RadioButton Rdb_Producto_Limpieza_Mantenimiento;
        private System.Windows.Forms.GroupBox Gpb_Descripcion_Producto;
        private System.Windows.Forms.Label Lbl_Precio_Unitario_Producto;
        private System.Windows.Forms.TextBox Txt_Costo_Unitario_Producto;
        private System.Windows.Forms.TextBox Txt_Nombre_Producto;
        private System.Windows.Forms.Label Lbl_Nombre_Producto;
        private System.Windows.Forms.RadioButton Rdb_Producto_Mobiliario_Equipo;
        private System.Windows.Forms.RadioButton Rdb_Producto_Equipos_Cocina;
        private System.Windows.Forms.Button Btn_Agregar_Producto;
        private System.Windows.Forms.RadioButton Rdb_Producto_Seguridad_Emergencia;
        private System.Windows.Forms.RadioButton Rdb_Producto_Suministros_Oficina;
        private System.Windows.Forms.Button Btn_Eliminar_Producto;
        private System.Windows.Forms.Button Btn_Modificar_Producto;
        private System.Windows.Forms.RadioButton Rdb_Producto_Cortesía;
        private System.Windows.Forms.RadioButton Rdb_Ropa_Blanca_Lenceria;
        private System.Windows.Forms.Label Lbl_Unidad_Medida_Producto;
        private System.Windows.Forms.Label Lbl_Cantidad_Producto;
        private System.Windows.Forms.TextBox Txt_Cantidad_Producto;
        private System.Windows.Forms.ComboBox Cbo_Estado_Producto;
        private System.Windows.Forms.Label Lbl_Estado_Producto;
        private System.Windows.Forms.ComboBox Cbo_Unidad_Medida_Producto;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Vencimiento_Producto;
        private System.Windows.Forms.Label Lbl_Fecha_Vencimiento;
        private System.Windows.Forms.Label Lbl_Fecha_Ingreso;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Ingreso_Producto;
        private System.Windows.Forms.ComboBox Cbo_Cod_Producto;
        private System.Windows.Forms.Label Lbl_Cod_Producto;
        private System.Windows.Forms.Button Btn_Cierre_Inventario;
        private System.Windows.Forms.Label Lbl_Marca_Producto;
        private System.Windows.Forms.TextBox Txt_Marca_Producto;
        private System.Windows.Forms.Label Lbl_Precio_Venta_Producto;
        private System.Windows.Forms.TextBox Txt_Precio_Venta_Producto;
        private System.Windows.Forms.TextBox Txt_Existencias_Globales_Producto;
        private System.Windows.Forms.Label Lbl_Existencias_Globales_Producto;
        private System.Windows.Forms.Label Lbl_Productos_Hotel;
        private System.Windows.Forms.ComboBox Cbo_Almacen_Producto;
        private System.Windows.Forms.Label Lbl_Almacen_Producto;
    }
}