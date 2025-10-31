
namespace Capa_Vista_Facturas
{
    partial class Frm_Listado_Facturas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.Dgv_Facturas = new System.Windows.Forms.DataGridView();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.Btn_VerDetalle = new System.Windows.Forms.Button();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Txt_Buscar = new System.Windows.Forms.TextBox();
            this.Lbl_Buscar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Facturas)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dgv_Facturas
            // 
            this.Dgv_Facturas.AllowUserToAddRows = false;
            this.Dgv_Facturas.AllowUserToDeleteRows = false;
            this.Dgv_Facturas.AllowUserToOrderColumns = true;
            this.Dgv_Facturas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Facturas.BackgroundColor = System.Drawing.Color.White;
            this.Dgv_Facturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Facturas.Location = new System.Drawing.Point(13, 19);
            this.Dgv_Facturas.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_Facturas.MultiSelect = false;
            this.Dgv_Facturas.Name = "Dgv_Facturas";
            this.Dgv_Facturas.ReadOnly = true;
            this.Dgv_Facturas.RowHeadersVisible = false;
            this.Dgv_Facturas.RowHeadersWidth = 51;
            this.Dgv_Facturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Facturas.Size = new System.Drawing.Size(1147, 533);
            this.Dgv_Facturas.TabIndex = 0;
            // 
            // pnlTop
            // 
            this.pnlTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTop.BackColor = System.Drawing.Color.Silver;
            this.pnlTop.Controls.Add(this.Btn_VerDetalle);
            this.pnlTop.Controls.Add(this.Btn_Buscar);
            this.pnlTop.Controls.Add(this.Txt_Buscar);
            this.pnlTop.Controls.Add(this.Lbl_Buscar);
            this.pnlTop.Location = new System.Drawing.Point(16, 15);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1147, 59);
            this.pnlTop.TabIndex = 1;
            // 
            // Btn_VerDetalle
            // 
            this.Btn_VerDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_VerDetalle.Location = new System.Drawing.Point(984, 14);
            this.Btn_VerDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_VerDetalle.Name = "Btn_VerDetalle";
            this.Btn_VerDetalle.Size = new System.Drawing.Size(141, 30);
            this.Btn_VerDetalle.TabIndex = 3;
            this.Btn_VerDetalle.Text = "Ver detalle";
            this.Btn_VerDetalle.UseVisualStyleBackColor = true;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Buscar.Location = new System.Drawing.Point(849, 14);
            this.Btn_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(127, 30);
            this.Btn_Buscar.TabIndex = 2;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // Txt_Buscar
            // 
            this.Txt_Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Buscar.Location = new System.Drawing.Point(88, 16);
            this.Txt_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Buscar.Name = "Txt_Buscar";
            this.Txt_Buscar.Size = new System.Drawing.Size(752, 22);
            this.Txt_Buscar.TabIndex = 1;
            // 
            // Lbl_Buscar
            // 
            this.Lbl_Buscar.AutoSize = true;
            this.Lbl_Buscar.Location = new System.Drawing.Point(19, 20);
            this.Lbl_Buscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Buscar.Name = "Lbl_Buscar";
            this.Lbl_Buscar.Size = new System.Drawing.Size(60, 17);
            this.Lbl_Buscar.TabIndex = 0;
            this.Lbl_Buscar.Text = "Buscar :";
            // 
            // Frm_Listado_Facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1179, 629);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.Dgv_Facturas);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(927, 481);
            this.Name = "Frm_Listado_Facturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Facturas";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Facturas)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView Dgv_Facturas;
        private System.Windows.Forms.Panel pnlTop;
        internal System.Windows.Forms.Button Btn_VerDetalle;
        internal System.Windows.Forms.Button Btn_Buscar;
        internal System.Windows.Forms.TextBox Txt_Buscar;
        private System.Windows.Forms.Label Lbl_Buscar;
    }
}