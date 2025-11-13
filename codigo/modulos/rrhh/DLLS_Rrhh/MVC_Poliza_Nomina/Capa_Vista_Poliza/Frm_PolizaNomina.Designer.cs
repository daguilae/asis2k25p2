
namespace MVC_Poliza_Nomina
{
    partial class Frm_PolizaNomina
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
            this.label1 = new System.Windows.Forms.Label();
            this.Gpb_rangos = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Dtp_hasta = new System.Windows.Forms.DateTimePicker();
            this.Dtp_desde = new System.Windows.Forms.DateTimePicker();
            this.Txt_RangoFechas = new System.Windows.Forms.Label();
            this.Btn_generar = new System.Windows.Forms.Button();
            this.Grp_generales = new System.Windows.Forms.GroupBox();
            this.Dtp_FechaPoliza = new System.Windows.Forms.DateTimePicker();
            this.Txt_Concepto = new System.Windows.Forms.TextBox();
            this.lbl_IdPoliza = new System.Windows.Forms.Label();
            this.Txt_IdPoliza = new System.Windows.Forms.TextBox();
            this.Lbl_Concepto = new System.Windows.Forms.Label();
            this.Txt_FechaPoliza = new System.Windows.Forms.Label();
            this.Dgv_detalles = new System.Windows.Forms.DataGridView();
            this.Txt_TotalCargosTitulo = new System.Windows.Forms.Label();
            this.Txt_TotalAbonosTitulo = new System.Windows.Forms.Label();
            this.Txt_DiferenciaTitulo = new System.Windows.Forms.Label();
            this.Txt_TotalCargos = new System.Windows.Forms.Label();
            this.Txt_TotalAbonos = new System.Windows.Forms.Label();
            this.Txt_Diferencia = new System.Windows.Forms.Label();
            this.Pnl_totales = new System.Windows.Forms.Panel();
            this.Btn_aceptar = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Gpb_rangos.SuspendLayout();
            this.Grp_generales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_detalles)).BeginInit();
            this.Pnl_totales.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Traslado de Póliza Nómina";
            // 
            // Gpb_rangos
            // 
            this.Gpb_rangos.Controls.Add(this.label3);
            this.Gpb_rangos.Controls.Add(this.label2);
            this.Gpb_rangos.Controls.Add(this.Dtp_hasta);
            this.Gpb_rangos.Controls.Add(this.Dtp_desde);
            this.Gpb_rangos.Controls.Add(this.Txt_RangoFechas);
            this.Gpb_rangos.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_rangos.Location = new System.Drawing.Point(66, 45);
            this.Gpb_rangos.Name = "Gpb_rangos";
            this.Gpb_rangos.Size = new System.Drawing.Size(678, 80);
            this.Gpb_rangos.TabIndex = 1;
            this.Gpb_rangos.TabStop = false;
            this.Gpb_rangos.Text = "Rangos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(511, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Desde";
            // 
            // Dtp_hasta
            // 
            this.Dtp_hasta.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_hasta.Location = new System.Drawing.Point(398, 32);
            this.Dtp_hasta.Name = "Dtp_hasta";
            this.Dtp_hasta.Size = new System.Drawing.Size(264, 23);
            this.Dtp_hasta.TabIndex = 2;
            // 
            // Dtp_desde
            // 
            this.Dtp_desde.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_desde.Location = new System.Drawing.Point(104, 32);
            this.Dtp_desde.Name = "Dtp_desde";
            this.Dtp_desde.Size = new System.Drawing.Size(268, 23);
            this.Dtp_desde.TabIndex = 1;
            // 
            // Txt_RangoFechas
            // 
            this.Txt_RangoFechas.AutoSize = true;
            this.Txt_RangoFechas.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_RangoFechas.Location = new System.Drawing.Point(35, 32);
            this.Txt_RangoFechas.Name = "Txt_RangoFechas";
            this.Txt_RangoFechas.Size = new System.Drawing.Size(57, 17);
            this.Txt_RangoFechas.TabIndex = 0;
            this.Txt_RangoFechas.Text = "Fechas";
            // 
            // Btn_generar
            // 
            this.Btn_generar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_generar.Location = new System.Drawing.Point(643, 12);
            this.Btn_generar.Name = "Btn_generar";
            this.Btn_generar.Size = new System.Drawing.Size(101, 34);
            this.Btn_generar.TabIndex = 4;
            this.Btn_generar.Text = "Generar Póliza";
            this.Btn_generar.UseVisualStyleBackColor = true;
            this.Btn_generar.Click += new System.EventHandler(this.Btn_generar_Click_1);
            // 
            // Grp_generales
            // 
            this.Grp_generales.Controls.Add(this.Dtp_FechaPoliza);
            this.Grp_generales.Controls.Add(this.Txt_Concepto);
            this.Grp_generales.Controls.Add(this.lbl_IdPoliza);
            this.Grp_generales.Controls.Add(this.Txt_IdPoliza);
            this.Grp_generales.Controls.Add(this.Lbl_Concepto);
            this.Grp_generales.Controls.Add(this.Txt_FechaPoliza);
            this.Grp_generales.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grp_generales.Location = new System.Drawing.Point(66, 146);
            this.Grp_generales.Name = "Grp_generales";
            this.Grp_generales.Size = new System.Drawing.Size(668, 114);
            this.Grp_generales.TabIndex = 2;
            this.Grp_generales.TabStop = false;
            this.Grp_generales.Text = "Generales de la Poliza";
            // 
            // Dtp_FechaPoliza
            // 
            this.Dtp_FechaPoliza.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_FechaPoliza.Location = new System.Drawing.Point(107, 37);
            this.Dtp_FechaPoliza.Name = "Dtp_FechaPoliza";
            this.Dtp_FechaPoliza.Size = new System.Drawing.Size(265, 23);
            this.Dtp_FechaPoliza.TabIndex = 5;
            // 
            // Txt_Concepto
            // 
            this.Txt_Concepto.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Concepto.Location = new System.Drawing.Point(107, 75);
            this.Txt_Concepto.Name = "Txt_Concepto";
            this.Txt_Concepto.Size = new System.Drawing.Size(265, 23);
            this.Txt_Concepto.TabIndex = 4;
            // 
            // lbl_IdPoliza
            // 
            this.lbl_IdPoliza.AutoSize = true;
            this.lbl_IdPoliza.Location = new System.Drawing.Point(446, 37);
            this.lbl_IdPoliza.Name = "lbl_IdPoliza";
            this.lbl_IdPoliza.Size = new System.Drawing.Size(24, 17);
            this.lbl_IdPoliza.TabIndex = 4;
            this.lbl_IdPoliza.Text = "ID";
            // 
            // Txt_IdPoliza
            // 
            this.Txt_IdPoliza.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_IdPoliza.Location = new System.Drawing.Point(474, 34);
            this.Txt_IdPoliza.Name = "Txt_IdPoliza";
            this.Txt_IdPoliza.ReadOnly = true;
            this.Txt_IdPoliza.Size = new System.Drawing.Size(84, 23);
            this.Txt_IdPoliza.TabIndex = 3;
            // 
            // Lbl_Concepto
            // 
            this.Lbl_Concepto.AutoSize = true;
            this.Lbl_Concepto.Location = new System.Drawing.Point(19, 81);
            this.Lbl_Concepto.Name = "Lbl_Concepto";
            this.Lbl_Concepto.Size = new System.Drawing.Size(77, 17);
            this.Lbl_Concepto.TabIndex = 1;
            this.Lbl_Concepto.Text = "Concepto";
            // 
            // Txt_FechaPoliza
            // 
            this.Txt_FechaPoliza.AutoSize = true;
            this.Txt_FechaPoliza.Location = new System.Drawing.Point(30, 37);
            this.Txt_FechaPoliza.Name = "Txt_FechaPoliza";
            this.Txt_FechaPoliza.Size = new System.Drawing.Size(50, 17);
            this.Txt_FechaPoliza.TabIndex = 0;
            this.Txt_FechaPoliza.Text = "Fecha";
            // 
            // Dgv_detalles
            // 
            this.Dgv_detalles.AllowUserToAddRows = false;
            this.Dgv_detalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_detalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_detalles.Location = new System.Drawing.Point(66, 281);
            this.Dgv_detalles.Name = "Dgv_detalles";
            this.Dgv_detalles.Size = new System.Drawing.Size(668, 121);
            this.Dgv_detalles.TabIndex = 3;
            // 
            // Txt_TotalCargosTitulo
            // 
            this.Txt_TotalCargosTitulo.AutoSize = true;
            this.Txt_TotalCargosTitulo.Location = new System.Drawing.Point(3, 13);
            this.Txt_TotalCargosTitulo.Name = "Txt_TotalCargosTitulo";
            this.Txt_TotalCargosTitulo.Size = new System.Drawing.Size(102, 17);
            this.Txt_TotalCargosTitulo.TabIndex = 6;
            this.Txt_TotalCargosTitulo.Text = "Total Cargos:";
            // 
            // Txt_TotalAbonosTitulo
            // 
            this.Txt_TotalAbonosTitulo.AutoSize = true;
            this.Txt_TotalAbonosTitulo.Location = new System.Drawing.Point(229, 10);
            this.Txt_TotalAbonosTitulo.Name = "Txt_TotalAbonosTitulo";
            this.Txt_TotalAbonosTitulo.Size = new System.Drawing.Size(106, 17);
            this.Txt_TotalAbonosTitulo.TabIndex = 7;
            this.Txt_TotalAbonosTitulo.Text = "Total Abonos:";
            // 
            // Txt_DiferenciaTitulo
            // 
            this.Txt_DiferenciaTitulo.AutoSize = true;
            this.Txt_DiferenciaTitulo.Location = new System.Drawing.Point(430, 10);
            this.Txt_DiferenciaTitulo.Name = "Txt_DiferenciaTitulo";
            this.Txt_DiferenciaTitulo.Size = new System.Drawing.Size(86, 17);
            this.Txt_DiferenciaTitulo.TabIndex = 8;
            this.Txt_DiferenciaTitulo.Text = "Diferencia:";
            // 
            // Txt_TotalCargos
            // 
            this.Txt_TotalCargos.AutoSize = true;
            this.Txt_TotalCargos.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_TotalCargos.Location = new System.Drawing.Point(104, 15);
            this.Txt_TotalCargos.Name = "Txt_TotalCargos";
            this.Txt_TotalCargos.Size = new System.Drawing.Size(15, 16);
            this.Txt_TotalCargos.TabIndex = 9;
            this.Txt_TotalCargos.Text = "0";
            // 
            // Txt_TotalAbonos
            // 
            this.Txt_TotalAbonos.AutoSize = true;
            this.Txt_TotalAbonos.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_TotalAbonos.Location = new System.Drawing.Point(332, 13);
            this.Txt_TotalAbonos.Name = "Txt_TotalAbonos";
            this.Txt_TotalAbonos.Size = new System.Drawing.Size(15, 16);
            this.Txt_TotalAbonos.TabIndex = 10;
            this.Txt_TotalAbonos.Text = "0";
            // 
            // Txt_Diferencia
            // 
            this.Txt_Diferencia.AutoSize = true;
            this.Txt_Diferencia.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Diferencia.Location = new System.Drawing.Point(511, 11);
            this.Txt_Diferencia.Name = "Txt_Diferencia";
            this.Txt_Diferencia.Size = new System.Drawing.Size(15, 16);
            this.Txt_Diferencia.TabIndex = 11;
            this.Txt_Diferencia.Text = "0";
            // 
            // Pnl_totales
            // 
            this.Pnl_totales.Controls.Add(this.Txt_Diferencia);
            this.Pnl_totales.Controls.Add(this.Txt_TotalCargosTitulo);
            this.Pnl_totales.Controls.Add(this.Txt_DiferenciaTitulo);
            this.Pnl_totales.Controls.Add(this.Txt_TotalAbonos);
            this.Pnl_totales.Controls.Add(this.Txt_TotalCargos);
            this.Pnl_totales.Controls.Add(this.Txt_TotalAbonosTitulo);
            this.Pnl_totales.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pnl_totales.Location = new System.Drawing.Point(66, 427);
            this.Pnl_totales.Name = "Pnl_totales";
            this.Pnl_totales.Size = new System.Drawing.Size(583, 44);
            this.Pnl_totales.TabIndex = 12;
            // 
            // Btn_aceptar
            // 
            this.Btn_aceptar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_aceptar.Location = new System.Drawing.Point(678, 431);
            this.Btn_aceptar.Name = "Btn_aceptar";
            this.Btn_aceptar.Size = new System.Drawing.Size(112, 30);
            this.Btn_aceptar.TabIndex = 6;
            this.Btn_aceptar.Text = "Trasladar Póliza";
            this.Btn_aceptar.UseVisualStyleBackColor = true;
            this.Btn_aceptar.Click += new System.EventHandler(this.Btn_aceptar_Click_1);
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cancelar.Location = new System.Drawing.Point(796, 431);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(71, 31);
            this.Btn_cancelar.TabIndex = 7;
            this.Btn_cancelar.Text = "Salir";
            this.Btn_cancelar.UseVisualStyleBackColor = true;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click_1);
            // 
            // Frm_PolizaNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(47)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(897, 511);
            this.Controls.Add(this.Btn_cancelar);
            this.Controls.Add(this.Pnl_totales);
            this.Controls.Add(this.Btn_aceptar);
            this.Controls.Add(this.Btn_generar);
            this.Controls.Add(this.Dgv_detalles);
            this.Controls.Add(this.Grp_generales);
            this.Controls.Add(this.Gpb_rangos);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Frm_PolizaNomina";
            this.Text = "x|";
            this.Gpb_rangos.ResumeLayout(false);
            this.Gpb_rangos.PerformLayout();
            this.Grp_generales.ResumeLayout(false);
            this.Grp_generales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_detalles)).EndInit();
            this.Pnl_totales.ResumeLayout(false);
            this.Pnl_totales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Gpb_rangos;
        private System.Windows.Forms.Button Btn_generar;
        private System.Windows.Forms.DateTimePicker Dtp_hasta;
        private System.Windows.Forms.DateTimePicker Dtp_desde;
        private System.Windows.Forms.Label Txt_RangoFechas;
        private System.Windows.Forms.GroupBox Grp_generales;
        private System.Windows.Forms.DateTimePicker Dtp_FechaPoliza;
        private System.Windows.Forms.TextBox Txt_Concepto;
        private System.Windows.Forms.Label lbl_IdPoliza;
        private System.Windows.Forms.TextBox Txt_IdPoliza;
        private System.Windows.Forms.Label Lbl_Concepto;
        private System.Windows.Forms.Label Txt_FechaPoliza;
        private System.Windows.Forms.DataGridView Dgv_detalles;
        private System.Windows.Forms.Label Txt_TotalCargosTitulo;
        private System.Windows.Forms.Label Txt_TotalAbonosTitulo;
        private System.Windows.Forms.Label Txt_DiferenciaTitulo;
        private System.Windows.Forms.Label Txt_TotalCargos;
        private System.Windows.Forms.Label Txt_TotalAbonos;
        private System.Windows.Forms.Label Txt_Diferencia;
        private System.Windows.Forms.Panel Pnl_totales;
        private System.Windows.Forms.Button Btn_aceptar;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}