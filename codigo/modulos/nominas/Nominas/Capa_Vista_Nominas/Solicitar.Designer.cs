
namespace Capa_Vista_Nominas
{
    partial class Frm_solicitar
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
            this.Gpb_solicitaranticipo = new System.Windows.Forms.GroupBox();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Txt_motivo = new System.Windows.Forms.TextBox();
            this.Txt_monto = new System.Windows.Forms.TextBox();
            this.Dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.Cbo_Nombreempleados = new System.Windows.Forms.ComboBox();
            this.Lbl_motivo = new System.Windows.Forms.Label();
            this.Lbl_monto = new System.Windows.Forms.Label();
            this.Lbl_fecha = new System.Windows.Forms.Label();
            this.Lbl_Nombreempleado = new System.Windows.Forms.Label();
            this.Gpb_solicitaranticipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gpb_solicitaranticipo
            // 
            this.Gpb_solicitaranticipo.Controls.Add(this.Btn_Cancelar);
            this.Gpb_solicitaranticipo.Controls.Add(this.Btn_guardar);
            this.Gpb_solicitaranticipo.Controls.Add(this.Txt_motivo);
            this.Gpb_solicitaranticipo.Controls.Add(this.Txt_monto);
            this.Gpb_solicitaranticipo.Controls.Add(this.Dtp_fecha);
            this.Gpb_solicitaranticipo.Controls.Add(this.Cbo_Nombreempleados);
            this.Gpb_solicitaranticipo.Controls.Add(this.Lbl_motivo);
            this.Gpb_solicitaranticipo.Controls.Add(this.Lbl_monto);
            this.Gpb_solicitaranticipo.Controls.Add(this.Lbl_fecha);
            this.Gpb_solicitaranticipo.Controls.Add(this.Lbl_Nombreempleado);
            this.Gpb_solicitaranticipo.Font = new System.Drawing.Font("Rockwell", 18F);
            this.Gpb_solicitaranticipo.Location = new System.Drawing.Point(12, 22);
            this.Gpb_solicitaranticipo.Name = "Gpb_solicitaranticipo";
            this.Gpb_solicitaranticipo.Size = new System.Drawing.Size(815, 472);
            this.Gpb_solicitaranticipo.TabIndex = 0;
            this.Gpb_solicitaranticipo.TabStop = false;
            this.Gpb_solicitaranticipo.Text = "Solicitar Anticipo";
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Cancelar.Image = global::Capa_Vista_Nominas.Properties.Resources.Cancel_icon_icons1;
            this.Btn_Cancelar.Location = new System.Drawing.Point(457, 386);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(80, 63);
            this.Btn_Cancelar.TabIndex = 11;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_guardar.Image = global::Capa_Vista_Nominas.Properties.Resources.savetheapplication_guardar_2958;
            this.Btn_guardar.Location = new System.Drawing.Point(276, 386);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(71, 63);
            this.Btn_guardar.TabIndex = 10;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_guardar.UseVisualStyleBackColor = true;
            // 
            // Txt_motivo
            // 
            this.Txt_motivo.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Txt_motivo.Location = new System.Drawing.Point(276, 203);
            this.Txt_motivo.Multiline = true;
            this.Txt_motivo.Name = "Txt_motivo";
            this.Txt_motivo.Size = new System.Drawing.Size(252, 138);
            this.Txt_motivo.TabIndex = 9;
            // 
            // Txt_monto
            // 
            this.Txt_monto.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Txt_monto.Location = new System.Drawing.Point(276, 154);
            this.Txt_monto.Name = "Txt_monto";
            this.Txt_monto.Size = new System.Drawing.Size(252, 23);
            this.Txt_monto.TabIndex = 8;
            // 
            // Dtp_fecha
            // 
            this.Dtp_fecha.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Dtp_fecha.Location = new System.Drawing.Point(276, 116);
            this.Dtp_fecha.Name = "Dtp_fecha";
            this.Dtp_fecha.Size = new System.Drawing.Size(252, 23);
            this.Dtp_fecha.TabIndex = 7;
            // 
            // Cbo_Nombreempleados
            // 
            this.Cbo_Nombreempleados.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Cbo_Nombreempleados.FormattingEnabled = true;
            this.Cbo_Nombreempleados.Location = new System.Drawing.Point(276, 73);
            this.Cbo_Nombreempleados.Name = "Cbo_Nombreempleados";
            this.Cbo_Nombreempleados.Size = new System.Drawing.Size(252, 24);
            this.Cbo_Nombreempleados.TabIndex = 6;
            // 
            // Lbl_motivo
            // 
            this.Lbl_motivo.AutoSize = true;
            this.Lbl_motivo.Font = new System.Drawing.Font("Rockwell", 18F);
            this.Lbl_motivo.Location = new System.Drawing.Point(46, 203);
            this.Lbl_motivo.Name = "Lbl_motivo";
            this.Lbl_motivo.Size = new System.Drawing.Size(88, 27);
            this.Lbl_motivo.TabIndex = 5;
            this.Lbl_motivo.Text = "Motivo";
            // 
            // Lbl_monto
            // 
            this.Lbl_monto.AutoSize = true;
            this.Lbl_monto.Font = new System.Drawing.Font("Rockwell", 18F);
            this.Lbl_monto.Location = new System.Drawing.Point(46, 157);
            this.Lbl_monto.Name = "Lbl_monto";
            this.Lbl_monto.Size = new System.Drawing.Size(82, 27);
            this.Lbl_monto.TabIndex = 4;
            this.Lbl_monto.Text = "Monto";
            // 
            // Lbl_fecha
            // 
            this.Lbl_fecha.AutoSize = true;
            this.Lbl_fecha.Font = new System.Drawing.Font("Rockwell", 18F);
            this.Lbl_fecha.Location = new System.Drawing.Point(46, 112);
            this.Lbl_fecha.Name = "Lbl_fecha";
            this.Lbl_fecha.Size = new System.Drawing.Size(79, 27);
            this.Lbl_fecha.TabIndex = 3;
            this.Lbl_fecha.Text = "Fecha";
            // 
            // Lbl_Nombreempleado
            // 
            this.Lbl_Nombreempleado.AutoSize = true;
            this.Lbl_Nombreempleado.Font = new System.Drawing.Font("Rockwell", 18F);
            this.Lbl_Nombreempleado.Location = new System.Drawing.Point(46, 70);
            this.Lbl_Nombreempleado.Name = "Lbl_Nombreempleado";
            this.Lbl_Nombreempleado.Size = new System.Drawing.Size(224, 27);
            this.Lbl_Nombreempleado.TabIndex = 2;
            this.Lbl_Nombreempleado.Text = "Nombre Empleado";
            // 
            // Frm_solicitar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 524);
            this.Controls.Add(this.Gpb_solicitaranticipo);
            this.Name = "Frm_solicitar";
            this.Text = "Frm_SolicitarAnticipo";
            this.Gpb_solicitaranticipo.ResumeLayout(false);
            this.Gpb_solicitaranticipo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gpb_solicitaranticipo;
        private System.Windows.Forms.TextBox Txt_motivo;
        private System.Windows.Forms.TextBox Txt_monto;
        private System.Windows.Forms.DateTimePicker Dtp_fecha;
        private System.Windows.Forms.ComboBox Cbo_Nombreempleados;
        private System.Windows.Forms.Label Lbl_motivo;
        private System.Windows.Forms.Label Lbl_monto;
        private System.Windows.Forms.Label Lbl_fecha;
        private System.Windows.Forms.Label Lbl_Nombreempleado;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_Cancelar;
    }
}