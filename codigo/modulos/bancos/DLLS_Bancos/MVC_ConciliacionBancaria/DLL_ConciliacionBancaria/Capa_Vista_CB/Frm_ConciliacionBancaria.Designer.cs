
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
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Lbl_Banco = new System.Windows.Forms.Label();
            this.Cbo_Bancos = new System.Windows.Forms.ComboBox();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.Dtp_Fecha = new System.Windows.Forms.DateTimePicker();
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
            // Dtp_Fecha
            // 
            this.Dtp_Fecha.CalendarFont = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_Fecha.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_Fecha.Location = new System.Drawing.Point(654, 111);
            this.Dtp_Fecha.Name = "Dtp_Fecha";
            this.Dtp_Fecha.Size = new System.Drawing.Size(316, 27);
            this.Dtp_Fecha.TabIndex = 4;
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
            // Frm_ConciliacionBancaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 953);
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
            this.Controls.Add(this.Dtp_Fecha);
            this.Controls.Add(this.Lbl_Fecha);
            this.Controls.Add(this.Cbo_Bancos);
            this.Controls.Add(this.Lbl_Banco);
            this.Controls.Add(this.Lbl_Titulo);
            this.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_ConciliacionBancaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ConciliacionBancaria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Label Lbl_Banco;
        private System.Windows.Forms.ComboBox Cbo_Bancos;
        private System.Windows.Forms.Label Lbl_Fecha;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha;
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
    }
}