
namespace Capa_Vista_Creacion_Nomina
{
    partial class Frm_Movimientos_Nomina
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.no_movimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_nomina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movimientos de Nomina";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no_movimiento,
            this.id_nomina,
            this.cod_empleado,
            this.empleado,
            this.concepto,
            this.tipo_concepto,
            this.cargo,
            this.abono});
            this.dataGridView1.Location = new System.Drawing.Point(19, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(846, 319);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // no_movimiento
            // 
            this.no_movimiento.HeaderText = "No. Movimiento";
            this.no_movimiento.Name = "no_movimiento";
            // 
            // id_nomina
            // 
            this.id_nomina.HeaderText = "Codigo Nomina";
            this.id_nomina.Name = "id_nomina";
            // 
            // cod_empleado
            // 
            this.cod_empleado.HeaderText = "Codigo Empleado";
            this.cod_empleado.Name = "cod_empleado";
            // 
            // empleado
            // 
            this.empleado.HeaderText = "Empleado";
            this.empleado.Name = "empleado";
            // 
            // concepto
            // 
            this.concepto.HeaderText = "Concepto";
            this.concepto.Name = "concepto";
            // 
            // tipo_concepto
            // 
            this.tipo_concepto.HeaderText = "Tipo Concepto";
            this.tipo_concepto.Name = "tipo_concepto";
            // 
            // cargo
            // 
            this.cargo.HeaderText = "Cargo";
            this.cargo.Name = "cargo";
            // 
            // abono
            // 
            this.abono.HeaderText = "Abono";
            this.abono.Name = "abono";
            // 
            // Frm_Movimientos_Nomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Movimientos_Nomina";
            this.Text = "Frm_Movimientos_Nomina";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn no_movimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_nomina;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn abono;
    }
}