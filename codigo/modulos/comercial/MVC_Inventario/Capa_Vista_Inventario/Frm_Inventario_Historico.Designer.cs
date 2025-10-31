
namespace Capa_Vista_Inventario
{
    partial class Frm_Inventario_Historico
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Pnl_Herramientas = new System.Windows.Forms.Panel();
            this.Btn_Buscar_Inventario = new System.Windows.Forms.Button();
            this.Lbl_Inventarios_Pasados = new System.Windows.Forms.Label();
            this.Gpb_Buscar_Inventario_Pasado = new System.Windows.Forms.GroupBox();
            this.Rdb_Usar_Filtros_Busqueda = new System.Windows.Forms.RadioButton();
            this.Rdb_Ver_Historicos = new System.Windows.Forms.RadioButton();
            this.Cbo_Tipo_Operacion = new System.Windows.Forms.ComboBox();
            this.Gpb_Gestion_Inventario = new System.Windows.Forms.GroupBox();
            this.Btn_Nuevo_Inventario = new System.Windows.Forms.Button();
            this.Btn_Imprimir_PDF = new System.Windows.Forms.Button();
            this.Gpb_Filtros = new System.Windows.Forms.GroupBox();
            this.Rdb_Filtro_Rango_Fecha = new System.Windows.Forms.RadioButton();
            this.Lbl_Rango_Fecha_Fin = new System.Windows.Forms.Label();
            this.Lbl_Rango_Fecha_Inicio = new System.Windows.Forms.Label();
            this.Dtp_Filtro_Rango_Fecha_Fin = new System.Windows.Forms.DateTimePicker();
            this.Dtp_Filtro_Rango_Fecha_Inicio = new System.Windows.Forms.DateTimePicker();
            this.Rdb_Filtro_Valor_Mas_Alto = new System.Windows.Forms.RadioButton();
            this.Rdb_Filtro_Valor_Mas_Bajo = new System.Windows.Forms.RadioButton();
            this.Cbo_Filtro_Almacen = new System.Windows.Forms.ComboBox();
            this.Rdb_Filtro_Almacen = new System.Windows.Forms.RadioButton();
            this.Cbo_Filtro_Estado = new System.Windows.Forms.ComboBox();
            this.Rdb_Filtro_Estado = new System.Windows.Forms.RadioButton();
            this.Rdb_Filtro_Mas_Recientes = new System.Windows.Forms.RadioButton();
            this.Rdb_Filtro_Menos_Recientes = new System.Windows.Forms.RadioButton();
            this.Pnl_Vista_Inventarios_Pasados = new System.Windows.Forms.Panel();
            this.Dgv_Vista_Inventarios_Pasados = new System.Windows.Forms.DataGridView();
            this.Pnl_Herramientas.SuspendLayout();
            this.Gpb_Buscar_Inventario_Pasado.SuspendLayout();
            this.Gpb_Gestion_Inventario.SuspendLayout();
            this.Gpb_Filtros.SuspendLayout();
            this.Pnl_Vista_Inventarios_Pasados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Vista_Inventarios_Pasados)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_Herramientas
            // 
            this.Pnl_Herramientas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_Herramientas.Controls.Add(this.Btn_Buscar_Inventario);
            this.Pnl_Herramientas.Controls.Add(this.Lbl_Inventarios_Pasados);
            this.Pnl_Herramientas.Controls.Add(this.Gpb_Buscar_Inventario_Pasado);
            this.Pnl_Herramientas.Controls.Add(this.Gpb_Gestion_Inventario);
            this.Pnl_Herramientas.Controls.Add(this.Gpb_Filtros);
            this.Pnl_Herramientas.Location = new System.Drawing.Point(13, 12);
            this.Pnl_Herramientas.Name = "Pnl_Herramientas";
            this.Pnl_Herramientas.Size = new System.Drawing.Size(1113, 154);
            this.Pnl_Herramientas.TabIndex = 0;
            // 
            // Btn_Buscar_Inventario
            // 
            this.Btn_Buscar_Inventario.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buscar_Inventario.Location = new System.Drawing.Point(303, 111);
            this.Btn_Buscar_Inventario.Name = "Btn_Buscar_Inventario";
            this.Btn_Buscar_Inventario.Size = new System.Drawing.Size(228, 40);
            this.Btn_Buscar_Inventario.TabIndex = 5;
            this.Btn_Buscar_Inventario.Text = "Buscar";
            this.Btn_Buscar_Inventario.UseVisualStyleBackColor = true;
            this.Btn_Buscar_Inventario.Click += new System.EventHandler(this.Btn_Buscar_Inventario_Click);
            // 
            // Lbl_Inventarios_Pasados
            // 
            this.Lbl_Inventarios_Pasados.AutoSize = true;
            this.Lbl_Inventarios_Pasados.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Inventarios_Pasados.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Inventarios_Pasados.Name = "Lbl_Inventarios_Pasados";
            this.Lbl_Inventarios_Pasados.Size = new System.Drawing.Size(295, 29);
            this.Lbl_Inventarios_Pasados.TabIndex = 0;
            this.Lbl_Inventarios_Pasados.Text = "Historico de Inventarios";
            // 
            // Gpb_Buscar_Inventario_Pasado
            // 
            this.Gpb_Buscar_Inventario_Pasado.Controls.Add(this.Rdb_Usar_Filtros_Busqueda);
            this.Gpb_Buscar_Inventario_Pasado.Controls.Add(this.Rdb_Ver_Historicos);
            this.Gpb_Buscar_Inventario_Pasado.Controls.Add(this.Cbo_Tipo_Operacion);
            this.Gpb_Buscar_Inventario_Pasado.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Buscar_Inventario_Pasado.Location = new System.Drawing.Point(5, 27);
            this.Gpb_Buscar_Inventario_Pasado.Name = "Gpb_Buscar_Inventario_Pasado";
            this.Gpb_Buscar_Inventario_Pasado.Size = new System.Drawing.Size(292, 124);
            this.Gpb_Buscar_Inventario_Pasado.TabIndex = 9;
            this.Gpb_Buscar_Inventario_Pasado.TabStop = false;
            this.Gpb_Buscar_Inventario_Pasado.Text = "Buscar por Tipo de Movimiento";
            // 
            // Rdb_Usar_Filtros_Busqueda
            // 
            this.Rdb_Usar_Filtros_Busqueda.AutoSize = true;
            this.Rdb_Usar_Filtros_Busqueda.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_Usar_Filtros_Busqueda.Location = new System.Drawing.Point(50, 58);
            this.Rdb_Usar_Filtros_Busqueda.Name = "Rdb_Usar_Filtros_Busqueda";
            this.Rdb_Usar_Filtros_Busqueda.Size = new System.Drawing.Size(202, 22);
            this.Rdb_Usar_Filtros_Busqueda.TabIndex = 17;
            this.Rdb_Usar_Filtros_Busqueda.TabStop = true;
            this.Rdb_Usar_Filtros_Busqueda.Text = "Usar Filtros y Busqueda";
            this.Rdb_Usar_Filtros_Busqueda.UseVisualStyleBackColor = true;
            this.Rdb_Usar_Filtros_Busqueda.CheckedChanged += new System.EventHandler(this.ModoDeBusqueda_CheckedChanged);
            // 
            // Rdb_Ver_Historicos
            // 
            this.Rdb_Ver_Historicos.AutoSize = true;
            this.Rdb_Ver_Historicos.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_Ver_Historicos.ForeColor = System.Drawing.Color.DarkRed;
            this.Rdb_Ver_Historicos.Location = new System.Drawing.Point(50, 86);
            this.Rdb_Ver_Historicos.Name = "Rdb_Ver_Historicos";
            this.Rdb_Ver_Historicos.Size = new System.Drawing.Size(198, 22);
            this.Rdb_Ver_Historicos.TabIndex = 1;
            this.Rdb_Ver_Historicos.TabStop = true;
            this.Rdb_Ver_Historicos.Text = "Ver Todo los Historicos";
            this.Rdb_Ver_Historicos.UseVisualStyleBackColor = true;
            this.Rdb_Ver_Historicos.CheckedChanged += new System.EventHandler(this.ModoDeBusqueda_CheckedChanged);
            // 
            // Cbo_Tipo_Operacion
            // 
            this.Cbo_Tipo_Operacion.FormattingEnabled = true;
            this.Cbo_Tipo_Operacion.Location = new System.Drawing.Point(6, 26);
            this.Cbo_Tipo_Operacion.Name = "Cbo_Tipo_Operacion";
            this.Cbo_Tipo_Operacion.Size = new System.Drawing.Size(280, 26);
            this.Cbo_Tipo_Operacion.TabIndex = 0;
            // 
            // Gpb_Gestion_Inventario
            // 
            this.Gpb_Gestion_Inventario.Controls.Add(this.Btn_Nuevo_Inventario);
            this.Gpb_Gestion_Inventario.Controls.Add(this.Btn_Imprimir_PDF);
            this.Gpb_Gestion_Inventario.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Gestion_Inventario.Location = new System.Drawing.Point(303, 3);
            this.Gpb_Gestion_Inventario.Name = "Gpb_Gestion_Inventario";
            this.Gpb_Gestion_Inventario.Size = new System.Drawing.Size(228, 102);
            this.Gpb_Gestion_Inventario.TabIndex = 8;
            this.Gpb_Gestion_Inventario.TabStop = false;
            this.Gpb_Gestion_Inventario.Text = "Gestion Inventario";
            // 
            // Btn_Nuevo_Inventario
            // 
            this.Btn_Nuevo_Inventario.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Nuevo_Inventario.Location = new System.Drawing.Point(40, 19);
            this.Btn_Nuevo_Inventario.Name = "Btn_Nuevo_Inventario";
            this.Btn_Nuevo_Inventario.Size = new System.Drawing.Size(152, 31);
            this.Btn_Nuevo_Inventario.TabIndex = 10;
            this.Btn_Nuevo_Inventario.Text = "Nuevo Inventario";
            this.Btn_Nuevo_Inventario.UseVisualStyleBackColor = true;
            this.Btn_Nuevo_Inventario.Click += new System.EventHandler(this.Btn_Nuevo_Inventario_Click);
            // 
            // Btn_Imprimir_PDF
            // 
            this.Btn_Imprimir_PDF.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Imprimir_PDF.Location = new System.Drawing.Point(40, 56);
            this.Btn_Imprimir_PDF.Name = "Btn_Imprimir_PDF";
            this.Btn_Imprimir_PDF.Size = new System.Drawing.Size(152, 31);
            this.Btn_Imprimir_PDF.TabIndex = 9;
            this.Btn_Imprimir_PDF.Text = "Imprimir en PDF";
            this.Btn_Imprimir_PDF.UseVisualStyleBackColor = true;
            this.Btn_Imprimir_PDF.Click += new System.EventHandler(this.Btn_Imprimir_PDF_Click);
            // 
            // Gpb_Filtros
            // 
            this.Gpb_Filtros.Controls.Add(this.Rdb_Filtro_Rango_Fecha);
            this.Gpb_Filtros.Controls.Add(this.Lbl_Rango_Fecha_Fin);
            this.Gpb_Filtros.Controls.Add(this.Lbl_Rango_Fecha_Inicio);
            this.Gpb_Filtros.Controls.Add(this.Dtp_Filtro_Rango_Fecha_Fin);
            this.Gpb_Filtros.Controls.Add(this.Dtp_Filtro_Rango_Fecha_Inicio);
            this.Gpb_Filtros.Controls.Add(this.Rdb_Filtro_Valor_Mas_Alto);
            this.Gpb_Filtros.Controls.Add(this.Rdb_Filtro_Valor_Mas_Bajo);
            this.Gpb_Filtros.Controls.Add(this.Cbo_Filtro_Almacen);
            this.Gpb_Filtros.Controls.Add(this.Rdb_Filtro_Almacen);
            this.Gpb_Filtros.Controls.Add(this.Cbo_Filtro_Estado);
            this.Gpb_Filtros.Controls.Add(this.Rdb_Filtro_Estado);
            this.Gpb_Filtros.Controls.Add(this.Rdb_Filtro_Mas_Recientes);
            this.Gpb_Filtros.Controls.Add(this.Rdb_Filtro_Menos_Recientes);
            this.Gpb_Filtros.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Filtros.Location = new System.Drawing.Point(537, 3);
            this.Gpb_Filtros.Name = "Gpb_Filtros";
            this.Gpb_Filtros.Size = new System.Drawing.Size(573, 148);
            this.Gpb_Filtros.TabIndex = 1;
            this.Gpb_Filtros.TabStop = false;
            this.Gpb_Filtros.Text = "Filtros y Orden";
            // 
            // Rdb_Filtro_Rango_Fecha
            // 
            this.Rdb_Filtro_Rango_Fecha.AutoSize = true;
            this.Rdb_Filtro_Rango_Fecha.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_Filtro_Rango_Fecha.Location = new System.Drawing.Point(245, 87);
            this.Rdb_Filtro_Rango_Fecha.Name = "Rdb_Filtro_Rango_Fecha";
            this.Rdb_Filtro_Rango_Fecha.Size = new System.Drawing.Size(73, 22);
            this.Rdb_Filtro_Rango_Fecha.TabIndex = 16;
            this.Rdb_Filtro_Rango_Fecha.TabStop = true;
            this.Rdb_Filtro_Rango_Fecha.Text = "Rango";
            this.Rdb_Filtro_Rango_Fecha.UseVisualStyleBackColor = true;
            this.Rdb_Filtro_Rango_Fecha.CheckedChanged += new System.EventHandler(this.Rdb_Filtro_Rango_Fecha_CheckedChanged);
            // 
            // Lbl_Rango_Fecha_Fin
            // 
            this.Lbl_Rango_Fecha_Fin.AutoSize = true;
            this.Lbl_Rango_Fecha_Fin.Location = new System.Drawing.Point(339, 123);
            this.Lbl_Rango_Fecha_Fin.Name = "Lbl_Rango_Fecha_Fin";
            this.Lbl_Rango_Fecha_Fin.Size = new System.Drawing.Size(23, 18);
            this.Lbl_Rango_Fecha_Fin.TabIndex = 15;
            this.Lbl_Rango_Fecha_Fin.Text = "Al";
            // 
            // Lbl_Rango_Fecha_Inicio
            // 
            this.Lbl_Rango_Fecha_Inicio.AutoSize = true;
            this.Lbl_Rango_Fecha_Inicio.Location = new System.Drawing.Point(339, 92);
            this.Lbl_Rango_Fecha_Inicio.Name = "Lbl_Rango_Fecha_Inicio";
            this.Lbl_Rango_Fecha_Inicio.Size = new System.Drawing.Size(34, 18);
            this.Lbl_Rango_Fecha_Inicio.TabIndex = 14;
            this.Lbl_Rango_Fecha_Inicio.Text = "Del";
            // 
            // Dtp_Filtro_Rango_Fecha_Fin
            // 
            this.Dtp_Filtro_Rango_Fecha_Fin.Enabled = false;
            this.Dtp_Filtro_Rango_Fecha_Fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_Filtro_Rango_Fecha_Fin.Location = new System.Drawing.Point(379, 118);
            this.Dtp_Filtro_Rango_Fecha_Fin.Name = "Dtp_Filtro_Rango_Fecha_Fin";
            this.Dtp_Filtro_Rango_Fecha_Fin.Size = new System.Drawing.Size(125, 25);
            this.Dtp_Filtro_Rango_Fecha_Fin.TabIndex = 13;
            this.Dtp_Filtro_Rango_Fecha_Fin.Value = new System.DateTime(2025, 10, 29, 0, 0, 0, 0);
            // 
            // Dtp_Filtro_Rango_Fecha_Inicio
            // 
            this.Dtp_Filtro_Rango_Fecha_Inicio.Enabled = false;
            this.Dtp_Filtro_Rango_Fecha_Inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_Filtro_Rango_Fecha_Inicio.Location = new System.Drawing.Point(379, 87);
            this.Dtp_Filtro_Rango_Fecha_Inicio.Name = "Dtp_Filtro_Rango_Fecha_Inicio";
            this.Dtp_Filtro_Rango_Fecha_Inicio.Size = new System.Drawing.Size(125, 25);
            this.Dtp_Filtro_Rango_Fecha_Inicio.TabIndex = 12;
            this.Dtp_Filtro_Rango_Fecha_Inicio.Value = new System.DateTime(2025, 10, 29, 0, 0, 0, 0);
            // 
            // Rdb_Filtro_Valor_Mas_Alto
            // 
            this.Rdb_Filtro_Valor_Mas_Alto.AutoSize = true;
            this.Rdb_Filtro_Valor_Mas_Alto.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_Filtro_Valor_Mas_Alto.Location = new System.Drawing.Point(6, 80);
            this.Rdb_Filtro_Valor_Mas_Alto.Name = "Rdb_Filtro_Valor_Mas_Alto";
            this.Rdb_Filtro_Valor_Mas_Alto.Size = new System.Drawing.Size(239, 22);
            this.Rdb_Filtro_Valor_Mas_Alto.TabIndex = 10;
            this.Rdb_Filtro_Valor_Mas_Alto.TabStop = true;
            this.Rdb_Filtro_Valor_Mas_Alto.Text = "Valor Mas Alto en Inventario";
            this.Rdb_Filtro_Valor_Mas_Alto.UseVisualStyleBackColor = true;
            // 
            // Rdb_Filtro_Valor_Mas_Bajo
            // 
            this.Rdb_Filtro_Valor_Mas_Bajo.AutoSize = true;
            this.Rdb_Filtro_Valor_Mas_Bajo.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_Filtro_Valor_Mas_Bajo.Location = new System.Drawing.Point(6, 108);
            this.Rdb_Filtro_Valor_Mas_Bajo.Name = "Rdb_Filtro_Valor_Mas_Bajo";
            this.Rdb_Filtro_Valor_Mas_Bajo.Size = new System.Drawing.Size(243, 22);
            this.Rdb_Filtro_Valor_Mas_Bajo.TabIndex = 11;
            this.Rdb_Filtro_Valor_Mas_Bajo.TabStop = true;
            this.Rdb_Filtro_Valor_Mas_Bajo.Text = "Valor Mas Bajo en Inventario";
            this.Rdb_Filtro_Valor_Mas_Bajo.UseVisualStyleBackColor = true;
            // 
            // Cbo_Filtro_Almacen
            // 
            this.Cbo_Filtro_Almacen.Enabled = false;
            this.Cbo_Filtro_Almacen.FormattingEnabled = true;
            this.Cbo_Filtro_Almacen.Location = new System.Drawing.Point(342, 23);
            this.Cbo_Filtro_Almacen.Name = "Cbo_Filtro_Almacen";
            this.Cbo_Filtro_Almacen.Size = new System.Drawing.Size(225, 26);
            this.Cbo_Filtro_Almacen.TabIndex = 7;
            // 
            // Rdb_Filtro_Almacen
            // 
            this.Rdb_Filtro_Almacen.AutoSize = true;
            this.Rdb_Filtro_Almacen.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_Filtro_Almacen.Location = new System.Drawing.Point(245, 24);
            this.Rdb_Filtro_Almacen.Name = "Rdb_Filtro_Almacen";
            this.Rdb_Filtro_Almacen.Size = new System.Drawing.Size(91, 22);
            this.Rdb_Filtro_Almacen.TabIndex = 6;
            this.Rdb_Filtro_Almacen.TabStop = true;
            this.Rdb_Filtro_Almacen.Text = "Almacen";
            this.Rdb_Filtro_Almacen.UseVisualStyleBackColor = true;
            this.Rdb_Filtro_Almacen.CheckedChanged += new System.EventHandler(this.Rdb_Filtro_Almacen_CheckedChanged);
            // 
            // Cbo_Filtro_Estado
            // 
            this.Cbo_Filtro_Estado.Enabled = false;
            this.Cbo_Filtro_Estado.FormattingEnabled = true;
            this.Cbo_Filtro_Estado.Location = new System.Drawing.Point(342, 55);
            this.Cbo_Filtro_Estado.Name = "Cbo_Filtro_Estado";
            this.Cbo_Filtro_Estado.Size = new System.Drawing.Size(162, 26);
            this.Cbo_Filtro_Estado.TabIndex = 5;
            // 
            // Rdb_Filtro_Estado
            // 
            this.Rdb_Filtro_Estado.AutoSize = true;
            this.Rdb_Filtro_Estado.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_Filtro_Estado.Location = new System.Drawing.Point(245, 55);
            this.Rdb_Filtro_Estado.Name = "Rdb_Filtro_Estado";
            this.Rdb_Filtro_Estado.Size = new System.Drawing.Size(76, 22);
            this.Rdb_Filtro_Estado.TabIndex = 4;
            this.Rdb_Filtro_Estado.TabStop = true;
            this.Rdb_Filtro_Estado.Text = "Estado";
            this.Rdb_Filtro_Estado.UseVisualStyleBackColor = true;
            this.Rdb_Filtro_Estado.CheckedChanged += new System.EventHandler(this.Rdb_Filtro_Estado_CheckedChanged);
            // 
            // Rdb_Filtro_Mas_Recientes
            // 
            this.Rdb_Filtro_Mas_Recientes.AutoSize = true;
            this.Rdb_Filtro_Mas_Recientes.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_Filtro_Mas_Recientes.Location = new System.Drawing.Point(6, 24);
            this.Rdb_Filtro_Mas_Recientes.Name = "Rdb_Filtro_Mas_Recientes";
            this.Rdb_Filtro_Mas_Recientes.Size = new System.Drawing.Size(193, 22);
            this.Rdb_Filtro_Mas_Recientes.TabIndex = 0;
            this.Rdb_Filtro_Mas_Recientes.TabStop = true;
            this.Rdb_Filtro_Mas_Recientes.Text = "Fechas Más Recientes";
            this.Rdb_Filtro_Mas_Recientes.UseVisualStyleBackColor = true;
            // 
            // Rdb_Filtro_Menos_Recientes
            // 
            this.Rdb_Filtro_Menos_Recientes.AutoSize = true;
            this.Rdb_Filtro_Menos_Recientes.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_Filtro_Menos_Recientes.Location = new System.Drawing.Point(6, 52);
            this.Rdb_Filtro_Menos_Recientes.Name = "Rdb_Filtro_Menos_Recientes";
            this.Rdb_Filtro_Menos_Recientes.Size = new System.Drawing.Size(211, 22);
            this.Rdb_Filtro_Menos_Recientes.TabIndex = 1;
            this.Rdb_Filtro_Menos_Recientes.TabStop = true;
            this.Rdb_Filtro_Menos_Recientes.Text = "Fechas Menos Recientes";
            this.Rdb_Filtro_Menos_Recientes.UseVisualStyleBackColor = true;
            // 
            // Pnl_Vista_Inventarios_Pasados
            // 
            this.Pnl_Vista_Inventarios_Pasados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_Vista_Inventarios_Pasados.Controls.Add(this.Dgv_Vista_Inventarios_Pasados);
            this.Pnl_Vista_Inventarios_Pasados.Location = new System.Drawing.Point(13, 172);
            this.Pnl_Vista_Inventarios_Pasados.Name = "Pnl_Vista_Inventarios_Pasados";
            this.Pnl_Vista_Inventarios_Pasados.Size = new System.Drawing.Size(1113, 377);
            this.Pnl_Vista_Inventarios_Pasados.TabIndex = 1;
            // 
            // Dgv_Vista_Inventarios_Pasados
            // 
            this.Dgv_Vista_Inventarios_Pasados.AllowUserToAddRows = false;
            this.Dgv_Vista_Inventarios_Pasados.AllowUserToDeleteRows = false;
            this.Dgv_Vista_Inventarios_Pasados.AllowUserToResizeRows = false;
            this.Dgv_Vista_Inventarios_Pasados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Vista_Inventarios_Pasados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dgv_Vista_Inventarios_Pasados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Vista_Inventarios_Pasados.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_Vista_Inventarios_Pasados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_Vista_Inventarios_Pasados.Location = new System.Drawing.Point(0, 0);
            this.Dgv_Vista_Inventarios_Pasados.MultiSelect = false;
            this.Dgv_Vista_Inventarios_Pasados.Name = "Dgv_Vista_Inventarios_Pasados";
            this.Dgv_Vista_Inventarios_Pasados.ReadOnly = true;
            this.Dgv_Vista_Inventarios_Pasados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Dgv_Vista_Inventarios_Pasados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgv_Vista_Inventarios_Pasados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Vista_Inventarios_Pasados.Size = new System.Drawing.Size(1113, 377);
            this.Dgv_Vista_Inventarios_Pasados.TabIndex = 0;
            // 
            // Frm_Inventario_Historico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1138, 561);
            this.Controls.Add(this.Pnl_Vista_Inventarios_Pasados);
            this.Controls.Add(this.Pnl_Herramientas);
            this.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1154, 600);
            this.Name = "Frm_Inventario_Historico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historico Inventario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Pnl_Herramientas.ResumeLayout(false);
            this.Pnl_Herramientas.PerformLayout();
            this.Gpb_Buscar_Inventario_Pasado.ResumeLayout(false);
            this.Gpb_Buscar_Inventario_Pasado.PerformLayout();
            this.Gpb_Gestion_Inventario.ResumeLayout(false);
            this.Gpb_Filtros.ResumeLayout(false);
            this.Gpb_Filtros.PerformLayout();
            this.Pnl_Vista_Inventarios_Pasados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Vista_Inventarios_Pasados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Herramientas;
        private System.Windows.Forms.Panel Pnl_Vista_Inventarios_Pasados;
        private System.Windows.Forms.DataGridView Dgv_Vista_Inventarios_Pasados;
        private System.Windows.Forms.GroupBox Gpb_Filtros;
        private System.Windows.Forms.RadioButton Rdb_Filtro_Menos_Recientes;
        private System.Windows.Forms.RadioButton Rdb_Filtro_Mas_Recientes;
        private System.Windows.Forms.Label Lbl_Inventarios_Pasados;
        private System.Windows.Forms.Button Btn_Buscar_Inventario;
        private System.Windows.Forms.GroupBox Gpb_Gestion_Inventario;
        private System.Windows.Forms.GroupBox Gpb_Buscar_Inventario_Pasado;
        private System.Windows.Forms.ComboBox Cbo_Filtro_Estado;
        private System.Windows.Forms.RadioButton Rdb_Filtro_Estado;
        private System.Windows.Forms.Button Btn_Imprimir_PDF;
        private System.Windows.Forms.Button Btn_Nuevo_Inventario;
        private System.Windows.Forms.RadioButton Rdb_Filtro_Almacen;
        private System.Windows.Forms.ComboBox Cbo_Tipo_Operacion;
        private System.Windows.Forms.ComboBox Cbo_Filtro_Almacen;
        private System.Windows.Forms.RadioButton Rdb_Filtro_Valor_Mas_Alto;
        private System.Windows.Forms.RadioButton Rdb_Filtro_Valor_Mas_Bajo;
        private System.Windows.Forms.RadioButton Rdb_Filtro_Rango_Fecha;
        private System.Windows.Forms.Label Lbl_Rango_Fecha_Fin;
        private System.Windows.Forms.Label Lbl_Rango_Fecha_Inicio;
        private System.Windows.Forms.DateTimePicker Dtp_Filtro_Rango_Fecha_Fin;
        private System.Windows.Forms.DateTimePicker Dtp_Filtro_Rango_Fecha_Inicio;
        private System.Windows.Forms.RadioButton Rdb_Ver_Historicos;
        private System.Windows.Forms.RadioButton Rdb_Usar_Filtros_Busqueda;
    }
}