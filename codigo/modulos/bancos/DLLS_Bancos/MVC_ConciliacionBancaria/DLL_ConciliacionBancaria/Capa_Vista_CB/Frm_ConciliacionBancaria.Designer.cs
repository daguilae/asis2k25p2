
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.Lbl_SaldoLibros.Location = new System.Drawing.Point(12, 231);
            this.Lbl_SaldoLibros.Name = "Lbl_SaldoLibros";
            this.Lbl_SaldoLibros.Size = new System.Drawing.Size(120, 20);
            this.Lbl_SaldoLibros.TabIndex = 10;
            this.Lbl_SaldoLibros.Text = "Saldo Libros:";
            // 
            // Lbl_Diferencia
            // 
            this.Lbl_Diferencia.AutoSize = true;
            this.Lbl_Diferencia.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Diferencia.Location = new System.Drawing.Point(12, 314);
            this.Lbl_Diferencia.Name = "Lbl_Diferencia";
            this.Lbl_Diferencia.Size = new System.Drawing.Size(106, 20);
            this.Lbl_Diferencia.TabIndex = 11;
            this.Lbl_Diferencia.Text = "Diferencia:";
            // 
            // Lbl_Observaciones
            // 
            this.Lbl_Observaciones.AutoSize = true;
            this.Lbl_Observaciones.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Observaciones.Location = new System.Drawing.Point(12, 373);
            this.Lbl_Observaciones.Name = "Lbl_Observaciones";
            this.Lbl_Observaciones.Size = new System.Drawing.Size(144, 20);
            this.Lbl_Observaciones.TabIndex = 12;
            this.Lbl_Observaciones.Text = "Observaciones:";
            // 
            // Lbl_Estado
            // 
            this.Lbl_Estado.AutoSize = true;
            this.Lbl_Estado.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Estado.Location = new System.Drawing.Point(12, 405);
            this.Lbl_Estado.Name = "Lbl_Estado";
            this.Lbl_Estado.Size = new System.Drawing.Size(72, 20);
            this.Lbl_Estado.TabIndex = 13;
            this.Lbl_Estado.Text = "Estado:";
            // 
            // Lbl_SaldoBanco
            // 
            this.Lbl_SaldoBanco.AutoSize = true;
            this.Lbl_SaldoBanco.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_SaldoBanco.Location = new System.Drawing.Point(12, 265);
            this.Lbl_SaldoBanco.Name = "Lbl_SaldoBanco";
            this.Lbl_SaldoBanco.Size = new System.Drawing.Size(114, 20);
            this.Lbl_SaldoBanco.TabIndex = 14;
            this.Lbl_SaldoBanco.Text = "SaldoBanco:";
            // 
            // Txt_SaldoLibros
            // 
            this.Txt_SaldoLibros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_SaldoLibros.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_SaldoLibros.Location = new System.Drawing.Point(138, 231);
            this.Txt_SaldoLibros.Name = "Txt_SaldoLibros";
            this.Txt_SaldoLibros.Size = new System.Drawing.Size(316, 20);
            this.Txt_SaldoLibros.TabIndex = 15;
            this.Txt_SaldoLibros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Txt_SaldoBanco
            // 
            this.Txt_SaldoBanco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_SaldoBanco.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_SaldoBanco.Location = new System.Drawing.Point(138, 265);
            this.Txt_SaldoBanco.Name = "Txt_SaldoBanco";
            this.Txt_SaldoBanco.Size = new System.Drawing.Size(316, 20);
            this.Txt_SaldoBanco.TabIndex = 16;
            this.Txt_SaldoBanco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Txt_Diferencias
            // 
            this.Txt_Diferencias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Diferencias.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Diferencias.Location = new System.Drawing.Point(138, 314);
            this.Txt_Diferencias.Name = "Txt_Diferencias";
            this.Txt_Diferencias.Size = new System.Drawing.Size(316, 20);
            this.Txt_Diferencias.TabIndex = 17;
            this.Txt_Diferencias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Txt_Observaciones
            // 
            this.Txt_Observaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Observaciones.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Observaciones.Location = new System.Drawing.Point(162, 373);
            this.Txt_Observaciones.Name = "Txt_Observaciones";
            this.Txt_Observaciones.Size = new System.Drawing.Size(808, 20);
            this.Txt_Observaciones.TabIndex = 18;
            // 
            // Chk_Estado
            // 
            this.Chk_Estado.AutoSize = true;
            this.Chk_Estado.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chk_Estado.Location = new System.Drawing.Point(90, 405);
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
            this.Gpb_Detalle.Location = new System.Drawing.Point(12, 459);
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
            this.Lbl_Tipo.Location = new System.Drawing.Point(12, 505);
            this.Lbl_Tipo.Name = "Lbl_Tipo";
            this.Lbl_Tipo.Size = new System.Drawing.Size(54, 20);
            this.Lbl_Tipo.TabIndex = 20;
            this.Lbl_Tipo.Text = "Tipo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 543);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ref:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 578);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Monto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 613);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Descripción:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 650);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Conciliado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(581, 505);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Fecha:";
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(72, 502);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(316, 28);
            this.comboBox1.TabIndex = 26;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(86, 578);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(316, 20);
            this.textBox2.TabIndex = 28;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(86, 541);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(316, 20);
            this.textBox1.TabIndex = 29;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(138, 613);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(832, 20);
            this.textBox3.TabIndex = 30;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(126, 650);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(212, 24);
            this.checkBox1.TabIndex = 31;
            this.checkBox1.Text = "Conciliado / Pendiente";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(654, 502);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(316, 27);
            this.dateTimePicker1.TabIndex = 32;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 737);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(954, 175);
            this.dataGridView1.TabIndex = 33;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(167)))), ((int)(((byte)(76)))));
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 932);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(958, 25);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 979);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 53);
            this.button1.TabIndex = 34;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(93, 979);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 53);
            this.button4.TabIndex = 37;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(174, 979);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 53);
            this.button5.TabIndex = 38;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(255, 979);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 53);
            this.button6.TabIndex = 39;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(336, 979);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 53);
            this.button7.TabIndex = 40;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(417, 979);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 53);
            this.button8.TabIndex = 41;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(498, 979);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 53);
            this.button9.TabIndex = 42;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.Location = new System.Drawing.Point(895, 7);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 53);
            this.button10.TabIndex = 43;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(16, 688);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 43);
            this.button2.TabIndex = 45;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(70, 688);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 43);
            this.button3.TabIndex = 46;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Frm_ConciliacionBancaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 1053);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}