
namespace Capa_Vista_CB
{
    partial class Frm_ConciliacionBancaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ConciliacionBancaria));
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Lbl_Banco = new System.Windows.Forms.Label();
            this.Cbo_Bancos = new System.Windows.Forms.ComboBox();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.Dtp_FechaConciliacion = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Mes = new System.Windows.Forms.Label();
            this.Cbo_Mes = new System.Windows.Forms.ComboBox();
            this.Lbl_anio = new System.Windows.Forms.Label();
            this.Txt_Anio = new System.Windows.Forms.TextBox();
            this.Gpb_Encabezado = new System.Windows.Forms.GroupBox();
            this.Lbl_SaldoLibros = new System.Windows.Forms.Label();
            this.Lbl_Diferencia = new System.Windows.Forms.Label();
            this.Lbl_Observaciones = new System.Windows.Forms.Label();
            this.Lbl_Estado = new System.Windows.Forms.Label();
            this.Lbl_SaldoBanco = new System.Windows.Forms.Label();
            this.Txt_SaldoLibros = new System.Windows.Forms.TextBox();
            this.Txt_SaldoBanco = new System.Windows.Forms.TextBox();
            this.Txt_Diferencias = new System.Windows.Forms.TextBox();
            this.Txt_Observaciones = new System.Windows.Forms.TextBox();
            this.Chk_Estado = new System.Windows.Forms.CheckBox();
            this.Gpb_Detalle = new System.Windows.Forms.GroupBox();
            this.Lbl_Tipo = new System.Windows.Forms.Label();
            this.Lbl_Referencia = new System.Windows.Forms.Label();
            this.Lbl_Monto = new System.Windows.Forms.Label();
            this.Lbl_Descripcion = new System.Windows.Forms.Label();
            this.Lbl_Estado_Conciliado = new System.Windows.Forms.Label();
            this.Lbl_FechaDoc = new System.Windows.Forms.Label();
            this.Cbo_Tipo_Diferencia = new System.Windows.Forms.ComboBox();
            this.Txt_Monto = new System.Windows.Forms.TextBox();
            this.Txt_Referencia = new System.Windows.Forms.TextBox();
            this.Txt_Descripcion = new System.Windows.Forms.TextBox();
            this.Chk_Estado_Conciliado = new System.Windows.Forms.CheckBox();
            this.Dtp_FechaDoc = new System.Windows.Forms.DateTimePicker();
            this.Dgv_DetalleConciliacion = new System.Windows.Forms.DataGridView();
            this.Gpb_Acciones = new System.Windows.Forms.GroupBox();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_BuscarConciliacion = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_AgregarDetalle = new System.Windows.Forms.Button();
            this.Btn_EliminarDetalle = new System.Windows.Forms.Button();
            this.Btn_Ayuda = new System.Windows.Forms.Button();
            this.Gpb_AccionesFin = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_DetalleConciliacion)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(320, 9);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(347, 38);
            this.Lbl_Titulo.TabIndex = 0;
            this.Lbl_Titulo.Text = "Conciliación Bancaria";
            this.Lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lbl_Banco
            // 
            this.Lbl_Banco.AutoSize = true;
            this.Lbl_Banco.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Banco.Location = new System.Drawing.Point(12, 115);
            this.Lbl_Banco.Name = "Lbl_Banco";
            this.Lbl_Banco.Size = new System.Drawing.Size(68, 20);
            this.Lbl_Banco.TabIndex = 1;
            this.Lbl_Banco.Text = "Banco:";
            // 
            // Cbo_Bancos
            // 
            this.Cbo_Bancos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbo_Bancos.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Bancos.FormattingEnabled = true;
            this.Cbo_Bancos.Location = new System.Drawing.Point(86, 112);
            this.Cbo_Bancos.Name = "Cbo_Bancos";
            this.Cbo_Bancos.Size = new System.Drawing.Size(316, 28);
            this.Cbo_Bancos.TabIndex = 2;
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha.Location = new System.Drawing.Point(581, 115);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(67, 20);
            this.Lbl_Fecha.TabIndex = 3;
            this.Lbl_Fecha.Text = "Fecha:";
            // 
            // Dtp_FechaConciliacion
            // 
            this.Dtp_FechaConciliacion.CalendarFont = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_FechaConciliacion.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_FechaConciliacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_FechaConciliacion.Location = new System.Drawing.Point(654, 112);
            this.Dtp_FechaConciliacion.Name = "Dtp_FechaConciliacion";
            this.Dtp_FechaConciliacion.Size = new System.Drawing.Size(316, 27);
            this.Dtp_FechaConciliacion.TabIndex = 4;
            // 
            // Lbl_Mes
            // 
            this.Lbl_Mes.AutoSize = true;
            this.Lbl_Mes.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Mes.Location = new System.Drawing.Point(12, 159);
            this.Lbl_Mes.Name = "Lbl_Mes";
            this.Lbl_Mes.Size = new System.Drawing.Size(52, 20);
            this.Lbl_Mes.TabIndex = 5;
            this.Lbl_Mes.Text = "Mes:";
            // 
            // Cbo_Mes
            // 
            this.Cbo_Mes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbo_Mes.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Mes.FormattingEnabled = true;
            this.Cbo_Mes.Location = new System.Drawing.Point(70, 156);
            this.Cbo_Mes.Name = "Cbo_Mes";
            this.Cbo_Mes.Size = new System.Drawing.Size(316, 28);
            this.Cbo_Mes.TabIndex = 6;
            // 
            // Lbl_anio
            // 
            this.Lbl_anio.AutoSize = true;
            this.Lbl_anio.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_anio.Location = new System.Drawing.Point(581, 165);
            this.Lbl_anio.Name = "Lbl_anio";
            this.Lbl_anio.Size = new System.Drawing.Size(48, 20);
            this.Lbl_anio.TabIndex = 7;
            this.Lbl_anio.Text = "Año:";
            // 
            // Txt_Anio
            // 
            this.Txt_Anio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Anio.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Anio.Location = new System.Drawing.Point(654, 165);
            this.Txt_Anio.Name = "Txt_Anio";
            this.Txt_Anio.Size = new System.Drawing.Size(316, 20);
            this.Txt_Anio.TabIndex = 8;
            this.Txt_Anio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Gpb_Encabezado
            // 
            this.Gpb_Encabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(167)))), ((int)(((byte)(76)))));
            this.Gpb_Encabezado.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Encabezado.Location = new System.Drawing.Point(12, 69);
            this.Gpb_Encabezado.Name = "Gpb_Encabezado";
            this.Gpb_Encabezado.Size = new System.Drawing.Size(958, 25);
            this.Gpb_Encabezado.TabIndex = 9;
            this.Gpb_Encabezado.TabStop = false;
            this.Gpb_Encabezado.Text = "Encabezado de Conciliación";
            // 
            // Lbl_SaldoLibros
            // 
            this.Lbl_SaldoLibros.AutoSize = true;
            this.Lbl_SaldoLibros.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_SaldoLibros.Location = new System.Drawing.Point(12, 240);
            this.Lbl_SaldoLibros.Name = "Lbl_SaldoLibros";
            this.Lbl_SaldoLibros.Size = new System.Drawing.Size(120, 20);
            this.Lbl_SaldoLibros.TabIndex = 10;
            this.Lbl_SaldoLibros.Text = "Saldo Libros:";
            // 
            // Lbl_Diferencia
            // 
            this.Lbl_Diferencia.AutoSize = true;
            this.Lbl_Diferencia.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Diferencia.Location = new System.Drawing.Point(14, 279);
            this.Lbl_Diferencia.Name = "Lbl_Diferencia";
            this.Lbl_Diferencia.Size = new System.Drawing.Size(106, 20);
            this.Lbl_Diferencia.TabIndex = 11;
            this.Lbl_Diferencia.Text = "Diferencia:";
            // 
            // Lbl_Observaciones
            // 
            this.Lbl_Observaciones.AutoSize = true;
            this.Lbl_Observaciones.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Observaciones.Location = new System.Drawing.Point(12, 324);
            this.Lbl_Observaciones.Name = "Lbl_Observaciones";
            this.Lbl_Observaciones.Size = new System.Drawing.Size(144, 20);
            this.Lbl_Observaciones.TabIndex = 12;
            this.Lbl_Observaciones.Text = "Observaciones:";
            // 
            // Lbl_Estado
            // 
            this.Lbl_Estado.AutoSize = true;
            this.Lbl_Estado.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Estado.Location = new System.Drawing.Point(14, 362);
            this.Lbl_Estado.Name = "Lbl_Estado";
            this.Lbl_Estado.Size = new System.Drawing.Size(72, 20);
            this.Lbl_Estado.TabIndex = 13;
            this.Lbl_Estado.Text = "Estado:";
            // 
            // Lbl_SaldoBanco
            // 
            this.Lbl_SaldoBanco.AutoSize = true;
            this.Lbl_SaldoBanco.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_SaldoBanco.Location = new System.Drawing.Point(12, 209);
            this.Lbl_SaldoBanco.Name = "Lbl_SaldoBanco";
            this.Lbl_SaldoBanco.Size = new System.Drawing.Size(114, 20);
            this.Lbl_SaldoBanco.TabIndex = 14;
            this.Lbl_SaldoBanco.Text = "SaldoBanco:";
            // 
            // Txt_SaldoLibros
            // 
            this.Txt_SaldoLibros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_SaldoLibros.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_SaldoLibros.Location = new System.Drawing.Point(138, 240);
            this.Txt_SaldoLibros.Name = "Txt_SaldoLibros";
            this.Txt_SaldoLibros.Size = new System.Drawing.Size(316, 20);
            this.Txt_SaldoLibros.TabIndex = 15;
            this.Txt_SaldoLibros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Txt_SaldoBanco
            // 
            this.Txt_SaldoBanco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_SaldoBanco.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_SaldoBanco.Location = new System.Drawing.Point(138, 209);
            this.Txt_SaldoBanco.Name = "Txt_SaldoBanco";
            this.Txt_SaldoBanco.Size = new System.Drawing.Size(316, 20);
            this.Txt_SaldoBanco.TabIndex = 16;
            this.Txt_SaldoBanco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Txt_Diferencias
            // 
            this.Txt_Diferencias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Diferencias.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Diferencias.Location = new System.Drawing.Point(138, 279);
            this.Txt_Diferencias.Name = "Txt_Diferencias";
            this.Txt_Diferencias.Size = new System.Drawing.Size(316, 20);
            this.Txt_Diferencias.TabIndex = 17;
            this.Txt_Diferencias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Txt_Observaciones
            // 
            this.Txt_Observaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Observaciones.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Observaciones.Location = new System.Drawing.Point(162, 324);
            this.Txt_Observaciones.Name = "Txt_Observaciones";
            this.Txt_Observaciones.Size = new System.Drawing.Size(808, 20);
            this.Txt_Observaciones.TabIndex = 18;
            // 
            // Chk_Estado
            // 
            this.Chk_Estado.AutoSize = true;
            this.Chk_Estado.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chk_Estado.Location = new System.Drawing.Point(92, 361);
            this.Chk_Estado.Name = "Chk_Estado";
            this.Chk_Estado.Size = new System.Drawing.Size(156, 24);
            this.Chk_Estado.TabIndex = 19;
            this.Chk_Estado.Text = "Activa / Inactiva";
            this.Chk_Estado.UseVisualStyleBackColor = true;
            // 
            // Gpb_Detalle
            // 
            this.Gpb_Detalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(167)))), ((int)(((byte)(76)))));
            this.Gpb_Detalle.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Detalle.Location = new System.Drawing.Point(12, 404);
            this.Gpb_Detalle.Name = "Gpb_Detalle";
            this.Gpb_Detalle.Size = new System.Drawing.Size(958, 25);
            this.Gpb_Detalle.TabIndex = 10;
            this.Gpb_Detalle.TabStop = false;
            this.Gpb_Detalle.Text = "Partidas de Conciliación";
            // 
            // Lbl_Tipo
            // 
            this.Lbl_Tipo.AutoSize = true;
            this.Lbl_Tipo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Tipo.Location = new System.Drawing.Point(12, 445);
            this.Lbl_Tipo.Name = "Lbl_Tipo";
            this.Lbl_Tipo.Size = new System.Drawing.Size(54, 20);
            this.Lbl_Tipo.TabIndex = 20;
            this.Lbl_Tipo.Text = "Tipo:";
            // 
            // Lbl_Referencia
            // 
            this.Lbl_Referencia.AutoSize = true;
            this.Lbl_Referencia.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Referencia.Location = new System.Drawing.Point(12, 483);
            this.Lbl_Referencia.Name = "Lbl_Referencia";
            this.Lbl_Referencia.Size = new System.Drawing.Size(43, 20);
            this.Lbl_Referencia.TabIndex = 21;
            this.Lbl_Referencia.Text = "Ref:";
            // 
            // Lbl_Monto
            // 
            this.Lbl_Monto.AutoSize = true;
            this.Lbl_Monto.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Monto.Location = new System.Drawing.Point(12, 518);
            this.Lbl_Monto.Name = "Lbl_Monto";
            this.Lbl_Monto.Size = new System.Drawing.Size(70, 20);
            this.Lbl_Monto.TabIndex = 22;
            this.Lbl_Monto.Text = "Monto:";
            // 
            // Lbl_Descripcion
            // 
            this.Lbl_Descripcion.AutoSize = true;
            this.Lbl_Descripcion.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Descripcion.Location = new System.Drawing.Point(12, 553);
            this.Lbl_Descripcion.Name = "Lbl_Descripcion";
            this.Lbl_Descripcion.Size = new System.Drawing.Size(120, 20);
            this.Lbl_Descripcion.TabIndex = 23;
            this.Lbl_Descripcion.Text = "Descripción:";
            // 
            // Lbl_Estado_Conciliado
            // 
            this.Lbl_Estado_Conciliado.AutoSize = true;
            this.Lbl_Estado_Conciliado.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Estado_Conciliado.Location = new System.Drawing.Point(12, 590);
            this.Lbl_Estado_Conciliado.Name = "Lbl_Estado_Conciliado";
            this.Lbl_Estado_Conciliado.Size = new System.Drawing.Size(108, 20);
            this.Lbl_Estado_Conciliado.TabIndex = 24;
            this.Lbl_Estado_Conciliado.Text = "Conciliado:";
            // 
            // Lbl_FechaDoc
            // 
            this.Lbl_FechaDoc.AutoSize = true;
            this.Lbl_FechaDoc.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FechaDoc.Location = new System.Drawing.Point(581, 445);
            this.Lbl_FechaDoc.Name = "Lbl_FechaDoc";
            this.Lbl_FechaDoc.Size = new System.Drawing.Size(67, 20);
            this.Lbl_FechaDoc.TabIndex = 25;
            this.Lbl_FechaDoc.Text = "Fecha:";
            // 
            // Cbo_Tipo_Diferencia
            // 
            this.Cbo_Tipo_Diferencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbo_Tipo_Diferencia.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Tipo_Diferencia.FormattingEnabled = true;
            this.Cbo_Tipo_Diferencia.Location = new System.Drawing.Point(72, 442);
            this.Cbo_Tipo_Diferencia.Name = "Cbo_Tipo_Diferencia";
            this.Cbo_Tipo_Diferencia.Size = new System.Drawing.Size(316, 28);
            this.Cbo_Tipo_Diferencia.TabIndex = 26;
            // 
            // Txt_Monto
            // 
            this.Txt_Monto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Monto.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Monto.Location = new System.Drawing.Point(86, 518);
            this.Txt_Monto.Name = "Txt_Monto";
            this.Txt_Monto.Size = new System.Drawing.Size(316, 20);
            this.Txt_Monto.TabIndex = 28;
            this.Txt_Monto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Txt_Referencia
            // 
            this.Txt_Referencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Referencia.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Referencia.Location = new System.Drawing.Point(86, 481);
            this.Txt_Referencia.Name = "Txt_Referencia";
            this.Txt_Referencia.Size = new System.Drawing.Size(316, 20);
            this.Txt_Referencia.TabIndex = 29;
            this.Txt_Referencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Descripcion.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Descripcion.Location = new System.Drawing.Point(138, 553);
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(422, 20);
            this.Txt_Descripcion.TabIndex = 30;
            this.Txt_Descripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Chk_Estado_Conciliado
            // 
            this.Chk_Estado_Conciliado.AutoSize = true;
            this.Chk_Estado_Conciliado.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chk_Estado_Conciliado.Location = new System.Drawing.Point(126, 590);
            this.Chk_Estado_Conciliado.Name = "Chk_Estado_Conciliado";
            this.Chk_Estado_Conciliado.Size = new System.Drawing.Size(212, 24);
            this.Chk_Estado_Conciliado.TabIndex = 31;
            this.Chk_Estado_Conciliado.Text = "Conciliado / Pendiente";
            this.Chk_Estado_Conciliado.UseVisualStyleBackColor = true;
            // 
            // Dtp_FechaDoc
            // 
            this.Dtp_FechaDoc.CalendarFont = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_FechaDoc.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_FechaDoc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_FechaDoc.Location = new System.Drawing.Point(654, 442);
            this.Dtp_FechaDoc.Name = "Dtp_FechaDoc";
            this.Dtp_FechaDoc.Size = new System.Drawing.Size(316, 27);
            this.Dtp_FechaDoc.TabIndex = 32;
            // 
            // Dgv_DetalleConciliacion
            // 
            this.Dgv_DetalleConciliacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_DetalleConciliacion.Location = new System.Drawing.Point(12, 629);
            this.Dgv_DetalleConciliacion.Name = "Dgv_DetalleConciliacion";
            this.Dgv_DetalleConciliacion.RowHeadersWidth = 51;
            this.Dgv_DetalleConciliacion.RowTemplate.Height = 24;
            this.Dgv_DetalleConciliacion.Size = new System.Drawing.Size(954, 148);
            this.Dgv_DetalleConciliacion.TabIndex = 33;
            // 
            // Gpb_Acciones
            // 
            this.Gpb_Acciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(167)))), ((int)(((byte)(76)))));
            this.Gpb_Acciones.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Acciones.Location = new System.Drawing.Point(12, 803);
            this.Gpb_Acciones.Name = "Gpb_Acciones";
            this.Gpb_Acciones.Size = new System.Drawing.Size(958, 25);
            this.Gpb_Acciones.TabIndex = 11;
            this.Gpb_Acciones.TabStop = false;
            this.Gpb_Acciones.Text = "Acciones";
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Limpiar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Limpiar.Image")));
            this.Btn_Limpiar.Location = new System.Drawing.Point(795, 834);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(175, 50);
            this.Btn_Limpiar.TabIndex = 34;
            this.Btn_Limpiar.UseVisualStyleBackColor = true;
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Guardar.Image")));
            this.Btn_Guardar.Location = new System.Drawing.Point(12, 834);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(175, 50);
            this.Btn_Guardar.TabIndex = 37;
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Modificar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Modificar.Image")));
            this.Btn_Modificar.Location = new System.Drawing.Point(213, 834);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(175, 50);
            this.Btn_Modificar.TabIndex = 38;
            this.Btn_Modificar.UseVisualStyleBackColor = true;
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Eliminar.Image")));
            this.Btn_Eliminar.Location = new System.Drawing.Point(413, 834);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(175, 50);
            this.Btn_Eliminar.TabIndex = 39;
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // Btn_BuscarConciliacion
            // 
            this.Btn_BuscarConciliacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_BuscarConciliacion.Image = ((System.Drawing.Image)(resources.GetObject("Btn_BuscarConciliacion.Image")));
            this.Btn_BuscarConciliacion.Location = new System.Drawing.Point(604, 834);
            this.Btn_BuscarConciliacion.Name = "Btn_BuscarConciliacion";
            this.Btn_BuscarConciliacion.Size = new System.Drawing.Size(175, 50);
            this.Btn_BuscarConciliacion.TabIndex = 40;
            this.Btn_BuscarConciliacion.UseVisualStyleBackColor = true;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Salir.Image")));
            this.Btn_Salir.Location = new System.Drawing.Point(911, 8);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(50, 50);
            this.Btn_Salir.TabIndex = 42;
            this.Btn_Salir.UseVisualStyleBackColor = true;
            // 
            // Btn_AgregarDetalle
            // 
            this.Btn_AgregarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AgregarDetalle.Image = ((System.Drawing.Image)(resources.GetObject("Btn_AgregarDetalle.Image")));
            this.Btn_AgregarDetalle.Location = new System.Drawing.Point(756, 573);
            this.Btn_AgregarDetalle.Name = "Btn_AgregarDetalle";
            this.Btn_AgregarDetalle.Size = new System.Drawing.Size(100, 50);
            this.Btn_AgregarDetalle.TabIndex = 45;
            this.Btn_AgregarDetalle.UseVisualStyleBackColor = true;
            // 
            // Btn_EliminarDetalle
            // 
            this.Btn_EliminarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_EliminarDetalle.Image = ((System.Drawing.Image)(resources.GetObject("Btn_EliminarDetalle.Image")));
            this.Btn_EliminarDetalle.Location = new System.Drawing.Point(867, 573);
            this.Btn_EliminarDetalle.Name = "Btn_EliminarDetalle";
            this.Btn_EliminarDetalle.Size = new System.Drawing.Size(100, 50);
            this.Btn_EliminarDetalle.TabIndex = 46;
            this.Btn_EliminarDetalle.UseVisualStyleBackColor = true;
            // 
            // Btn_Ayuda
            // 
            this.Btn_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ayuda.Image")));
            this.Btn_Ayuda.Location = new System.Drawing.Point(855, 8);
            this.Btn_Ayuda.Name = "Btn_Ayuda";
            this.Btn_Ayuda.Size = new System.Drawing.Size(50, 50);
            this.Btn_Ayuda.TabIndex = 43;
            this.Btn_Ayuda.UseVisualStyleBackColor = true;
            // 
            // Gpb_AccionesFin
            // 
            this.Gpb_AccionesFin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(167)))), ((int)(((byte)(76)))));
            this.Gpb_AccionesFin.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_AccionesFin.Location = new System.Drawing.Point(12, 890);
            this.Gpb_AccionesFin.Name = "Gpb_AccionesFin";
            this.Gpb_AccionesFin.Size = new System.Drawing.Size(958, 25);
            this.Gpb_AccionesFin.TabIndex = 12;
            this.Gpb_AccionesFin.TabStop = false;
            this.Gpb_AccionesFin.Text = "Fin de Acciones";
            // 
            // Frm_ConciliacionBancaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(982, 703);
            this.Controls.Add(this.Gpb_AccionesFin);
            this.Controls.Add(this.Btn_EliminarDetalle);
            this.Controls.Add(this.Btn_AgregarDetalle);
            this.Controls.Add(this.Btn_Ayuda);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_BuscarConciliacion);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Btn_Limpiar);
            this.Controls.Add(this.Gpb_Acciones);
            this.Controls.Add(this.Dgv_DetalleConciliacion);
            this.Controls.Add(this.Dtp_FechaDoc);
            this.Controls.Add(this.Chk_Estado_Conciliado);
            this.Controls.Add(this.Txt_Descripcion);
            this.Controls.Add(this.Txt_Referencia);
            this.Controls.Add(this.Txt_Monto);
            this.Controls.Add(this.Cbo_Tipo_Diferencia);
            this.Controls.Add(this.Lbl_FechaDoc);
            this.Controls.Add(this.Lbl_Estado_Conciliado);
            this.Controls.Add(this.Lbl_Descripcion);
            this.Controls.Add(this.Lbl_Monto);
            this.Controls.Add(this.Lbl_Referencia);
            this.Controls.Add(this.Lbl_Tipo);
            this.Controls.Add(this.Gpb_Detalle);
            this.Controls.Add(this.Chk_Estado);
            this.Controls.Add(this.Txt_Observaciones);
            this.Controls.Add(this.Txt_Diferencias);
            this.Controls.Add(this.Txt_SaldoBanco);
            this.Controls.Add(this.Txt_SaldoLibros);
            this.Controls.Add(this.Lbl_SaldoBanco);
            this.Controls.Add(this.Lbl_Estado);
            this.Controls.Add(this.Lbl_Observaciones);
            this.Controls.Add(this.Lbl_Diferencia);
            this.Controls.Add(this.Lbl_SaldoLibros);
            this.Controls.Add(this.Gpb_Encabezado);
            this.Controls.Add(this.Txt_Anio);
            this.Controls.Add(this.Lbl_anio);
            this.Controls.Add(this.Cbo_Mes);
            this.Controls.Add(this.Lbl_Mes);
            this.Controls.Add(this.Dtp_FechaConciliacion);
            this.Controls.Add(this.Lbl_Fecha);
            this.Controls.Add(this.Cbo_Bancos);
            this.Controls.Add(this.Lbl_Banco);
            this.Controls.Add(this.Lbl_Titulo);
            this.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_ConciliacionBancaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ConciliacionBancaria";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_DetalleConciliacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Label Lbl_Banco;
        private System.Windows.Forms.ComboBox Cbo_Bancos;
        private System.Windows.Forms.Label Lbl_Fecha;
        private System.Windows.Forms.DateTimePicker Dtp_FechaConciliacion;
        private System.Windows.Forms.Label Lbl_Mes;
        private System.Windows.Forms.ComboBox Cbo_Mes;
        private System.Windows.Forms.Label Lbl_anio;
        private System.Windows.Forms.TextBox Txt_Anio;
        private System.Windows.Forms.GroupBox Gpb_Encabezado;
        private System.Windows.Forms.Label Lbl_SaldoLibros;
        private System.Windows.Forms.Label Lbl_Diferencia;
        private System.Windows.Forms.Label Lbl_Observaciones;
        private System.Windows.Forms.Label Lbl_Estado;
        private System.Windows.Forms.Label Lbl_SaldoBanco;
        private System.Windows.Forms.TextBox Txt_SaldoLibros;
        private System.Windows.Forms.TextBox Txt_SaldoBanco;
        private System.Windows.Forms.TextBox Txt_Diferencias;
        private System.Windows.Forms.TextBox Txt_Observaciones;
        private System.Windows.Forms.CheckBox Chk_Estado;
        private System.Windows.Forms.GroupBox Gpb_Detalle;
        private System.Windows.Forms.Label Lbl_Tipo;
        private System.Windows.Forms.Label Lbl_Referencia;
        private System.Windows.Forms.Label Lbl_Monto;
        private System.Windows.Forms.Label Lbl_Descripcion;
        private System.Windows.Forms.Label Lbl_Estado_Conciliado;
        private System.Windows.Forms.Label Lbl_FechaDoc;
        private System.Windows.Forms.ComboBox Cbo_Tipo_Diferencia;
        private System.Windows.Forms.TextBox Txt_Monto;
        private System.Windows.Forms.TextBox Txt_Referencia;
        private System.Windows.Forms.TextBox Txt_Descripcion;
        private System.Windows.Forms.CheckBox Chk_Estado_Conciliado;
        private System.Windows.Forms.DateTimePicker Dtp_FechaDoc;
        private System.Windows.Forms.DataGridView Dgv_DetalleConciliacion;
        private System.Windows.Forms.GroupBox Gpb_Acciones;
        private System.Windows.Forms.Button Btn_Limpiar;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_BuscarConciliacion;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_AgregarDetalle;
        private System.Windows.Forms.Button Btn_EliminarDetalle;
        private System.Windows.Forms.Button Btn_Ayuda;
        private System.Windows.Forms.GroupBox Gpb_AccionesFin;
    }
}