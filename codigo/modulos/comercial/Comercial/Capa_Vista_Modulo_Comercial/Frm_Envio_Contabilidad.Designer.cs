
namespace Capa_Vista_Modulo_Comercial
{
    partial class Frm_Envio_Contabilidad
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
            this.Gpb_Pendientes = new System.Windows.Forms.GroupBox();
            this.Dgv_Pendientes = new System.Windows.Forms.DataGridView();
            this.id_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gpb_Envio = new System.Windows.Forms.GroupBox();
            this.Lbl_Progreso = new System.Windows.Forms.Label();
            this.Pgb_Envio = new System.Windows.Forms.ProgressBar();
            this.Lbl_Instruccion = new System.Windows.Forms.Label();
            this.Pnl_AccionesEnvio = new System.Windows.Forms.Panel();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.Btn_Actualizar = new System.Windows.Forms.Button();
            this.Btn_Historial = new System.Windows.Forms.Button();
            this.Btn_Enviar = new System.Windows.Forms.Button();
            this.Gpb_Pendientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Pendientes)).BeginInit();
            this.Gpb_Envio.SuspendLayout();
            this.Pnl_AccionesEnvio.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gpb_Pendientes
            // 
            this.Gpb_Pendientes.Controls.Add(this.Dgv_Pendientes);
            this.Gpb_Pendientes.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Pendientes.Location = new System.Drawing.Point(30, 27);
            this.Gpb_Pendientes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Gpb_Pendientes.Name = "Gpb_Pendientes";
            this.Gpb_Pendientes.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Gpb_Pendientes.Size = new System.Drawing.Size(1245, 357);
            this.Gpb_Pendientes.TabIndex = 0;
            this.Gpb_Pendientes.TabStop = false;
            this.Gpb_Pendientes.Text = "Compras Pendientes de Enviar a Contabilidad";
            // 
            // Dgv_Pendientes
            // 
            this.Dgv_Pendientes.AllowUserToAddRows = false;
            this.Dgv_Pendientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Pendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Pendientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_compra,
            this.proveedor,
            this.fecha,
            this.total,
            this.estado});
            this.Dgv_Pendientes.Location = new System.Drawing.Point(30, 41);
            this.Dgv_Pendientes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Dgv_Pendientes.Name = "Dgv_Pendientes";
            this.Dgv_Pendientes.ReadOnly = true;
            this.Dgv_Pendientes.RowHeadersWidth = 51;
            this.Dgv_Pendientes.RowTemplate.Height = 24;
            this.Dgv_Pendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Pendientes.Size = new System.Drawing.Size(1185, 275);
            this.Dgv_Pendientes.TabIndex = 0;
            // 
            // id_compra
            // 
            this.id_compra.HeaderText = "ID";
            this.id_compra.MinimumWidth = 6;
            this.id_compra.Name = "id_compra";
            this.id_compra.ReadOnly = true;
            // 
            // proveedor
            // 
            this.proveedor.HeaderText = "Proveedor";
            this.proveedor.MinimumWidth = 6;
            this.proveedor.Name = "proveedor";
            this.proveedor.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.MinimumWidth = 6;
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "Total (Q)";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.MinimumWidth = 6;
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // Gpb_Envio
            // 
            this.Gpb_Envio.Controls.Add(this.Lbl_Progreso);
            this.Gpb_Envio.Controls.Add(this.Pgb_Envio);
            this.Gpb_Envio.Controls.Add(this.Lbl_Instruccion);
            this.Gpb_Envio.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Envio.Location = new System.Drawing.Point(30, 413);
            this.Gpb_Envio.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Gpb_Envio.Name = "Gpb_Envio";
            this.Gpb_Envio.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Gpb_Envio.Size = new System.Drawing.Size(1245, 179);
            this.Gpb_Envio.TabIndex = 1;
            this.Gpb_Envio.TabStop = false;
            this.Gpb_Envio.Text = "Proceso de Envio a Contabilidad";
            // 
            // Lbl_Progreso
            // 
            this.Lbl_Progreso.AutoSize = true;
            this.Lbl_Progreso.Location = new System.Drawing.Point(30, 130);
            this.Lbl_Progreso.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_Progreso.Name = "Lbl_Progreso";
            this.Lbl_Progreso.Size = new System.Drawing.Size(115, 20);
            this.Lbl_Progreso.TabIndex = 2;
            this.Lbl_Progreso.Text = "Progreso: 0%";
            // 
            // Pgb_Envio
            // 
            this.Pgb_Envio.Location = new System.Drawing.Point(30, 90);
            this.Pgb_Envio.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Pgb_Envio.Name = "Pgb_Envio";
            this.Pgb_Envio.Size = new System.Drawing.Size(1185, 34);
            this.Pgb_Envio.TabIndex = 1;
            // 
            // Lbl_Instruccion
            // 
            this.Lbl_Instruccion.AutoSize = true;
            this.Lbl_Instruccion.Location = new System.Drawing.Point(30, 48);
            this.Lbl_Instruccion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_Instruccion.Name = "Lbl_Instruccion";
            this.Lbl_Instruccion.Size = new System.Drawing.Size(422, 20);
            this.Lbl_Instruccion.TabIndex = 0;
            this.Lbl_Instruccion.Text = "Seleccione las compras a enviar y presione \"Enviar\" ";
            // 
            // Pnl_AccionesEnvio
            // 
            this.Pnl_AccionesEnvio.Controls.Add(this.Btn_Cerrar);
            this.Pnl_AccionesEnvio.Controls.Add(this.Btn_Actualizar);
            this.Pnl_AccionesEnvio.Controls.Add(this.Btn_Historial);
            this.Pnl_AccionesEnvio.Controls.Add(this.Btn_Enviar);
            this.Pnl_AccionesEnvio.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pnl_AccionesEnvio.Location = new System.Drawing.Point(30, 619);
            this.Pnl_AccionesEnvio.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Pnl_AccionesEnvio.Name = "Pnl_AccionesEnvio";
            this.Pnl_AccionesEnvio.Size = new System.Drawing.Size(1245, 110);
            this.Pnl_AccionesEnvio.TabIndex = 2;
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Location = new System.Drawing.Point(946, 32);
            this.Btn_Cerrar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(150, 48);
            this.Btn_Cerrar.TabIndex = 3;
            this.Btn_Cerrar.Text = "Cerrar";
            this.Btn_Cerrar.UseVisualStyleBackColor = true;
            // 
            // Btn_Actualizar
            // 
            this.Btn_Actualizar.Location = new System.Drawing.Point(727, 32);
            this.Btn_Actualizar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.Size = new System.Drawing.Size(210, 48);
            this.Btn_Actualizar.TabIndex = 2;
            this.Btn_Actualizar.Text = "Actualizar Lista";
            this.Btn_Actualizar.UseVisualStyleBackColor = true;
            // 
            // Btn_Historial
            // 
            this.Btn_Historial.Location = new System.Drawing.Point(414, 32);
            this.Btn_Historial.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Btn_Historial.Name = "Btn_Historial";
            this.Btn_Historial.Size = new System.Drawing.Size(305, 48);
            this.Btn_Historial.TabIndex = 1;
            this.Btn_Historial.Text = "Ver Historial de Envios";
            this.Btn_Historial.UseVisualStyleBackColor = true;
            // 
            // Btn_Enviar
            // 
            this.Btn_Enviar.Location = new System.Drawing.Point(117, 32);
            this.Btn_Enviar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Btn_Enviar.Name = "Btn_Enviar";
            this.Btn_Enviar.Size = new System.Drawing.Size(288, 48);
            this.Btn_Enviar.TabIndex = 0;
            this.Btn_Enviar.Text = "Enviar a Contabilidad";
            this.Btn_Enviar.UseVisualStyleBackColor = true;
            // 
            // Frm_Envio_Contabilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1294, 740);
            this.Controls.Add(this.Pnl_AccionesEnvio);
            this.Controls.Add(this.Gpb_Envio);
            this.Controls.Add(this.Gpb_Pendientes);
            this.Font = new System.Drawing.Font("Rockwell", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Frm_Envio_Contabilidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Envio_Contabilidad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Gpb_Pendientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Pendientes)).EndInit();
            this.Gpb_Envio.ResumeLayout(false);
            this.Gpb_Envio.PerformLayout();
            this.Pnl_AccionesEnvio.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gpb_Pendientes;
        private System.Windows.Forms.DataGridView Dgv_Pendientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.GroupBox Gpb_Envio;
        private System.Windows.Forms.Label Lbl_Progreso;
        private System.Windows.Forms.ProgressBar Pgb_Envio;
        private System.Windows.Forms.Label Lbl_Instruccion;
        private System.Windows.Forms.Panel Pnl_AccionesEnvio;
        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.Button Btn_Actualizar;
        private System.Windows.Forms.Button Btn_Historial;
        private System.Windows.Forms.Button Btn_Enviar;
    }
}