
namespace Capa_Vista_Creacion_Nomina
{
    partial class Frm_Detalle_Nomina
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
            this.nomina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ausencias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dias_laborados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percepciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deducciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldo_liquido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Detalle de Nomina";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomina,
            this.codigo_empleado,
            this.empleado,
            this.ausencias,
            this.dias_laborados,
            this.percepciones,
            this.deducciones,
            this.sueldo_liquido});
            this.dataGridView1.Location = new System.Drawing.Point(17, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(847, 321);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // nomina
            // 
            this.nomina.HeaderText = "Nomina";
            this.nomina.Name = "nomina";
            // 
            // codigo_empleado
            // 
            this.codigo_empleado.HeaderText = "Codigo Empleado";
            this.codigo_empleado.Name = "codigo_empleado";
            // 
            // empleado
            // 
            this.empleado.HeaderText = "Empleado";
            this.empleado.Name = "empleado";
            // 
            // ausencias
            // 
            this.ausencias.HeaderText = "Ausencias";
            this.ausencias.Name = "ausencias";
            // 
            // dias_laborados
            // 
            this.dias_laborados.HeaderText = "Dias Laborados";
            this.dias_laborados.Name = "dias_laborados";
            // 
            // percepciones
            // 
            this.percepciones.HeaderText = "Percepciones";
            this.percepciones.Name = "percepciones";
            // 
            // deducciones
            // 
            this.deducciones.HeaderText = "Deducciones";
            this.deducciones.Name = "deducciones";
            // 
            // sueldo_liquido
            // 
            this.sueldo_liquido.HeaderText = "Sueldo Liquido";
            this.sueldo_liquido.Name = "sueldo_liquido";
            // 
            // Frm_Detalle_Nomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Detalle_Nomina";
            this.Text = "Frm_Detalle_Nomina";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomina;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ausencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn dias_laborados;
        private System.Windows.Forms.DataGridViewTextBoxColumn percepciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn deducciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldo_liquido;
    }
}