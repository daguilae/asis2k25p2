
namespace Capa_Vista_Inventario
{
    partial class Frm_Cierre_Inventario
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
            this.Pnl_Principal_Cierre = new System.Windows.Forms.Panel();
            this.Gpb_Cierre = new System.Windows.Forms.GroupBox();
            this.Btn_Cancelar_Cierre = new System.Windows.Forms.Button();
            this.Btn_Cierre_Inventario = new System.Windows.Forms.Button();
            this.Txt_Cargos_Mes = new System.Windows.Forms.TextBox();
            this.Txt_Cargos_Acumulados = new System.Windows.Forms.TextBox();
            this.Txt_Abono_Acumulado = new System.Windows.Forms.TextBox();
            this.Txt_Abono_Mes = new System.Windows.Forms.TextBox();
            this.Txt_Saldo_Final = new System.Windows.Forms.TextBox();
            this.Lbl_Saldo_Inicial = new System.Windows.Forms.Label();
            this.Txt_Saldo_Inicial_Producto = new System.Windows.Forms.TextBox();
            this.Lbl_Cargos_Mes_Producto = new System.Windows.Forms.Label();
            this.Lbl_Abonos_Acumulados = new System.Windows.Forms.Label();
            this.Lbl_Cargos_Acumulados = new System.Windows.Forms.Label();
            this.Lbl_Abono_Mes_Producto = new System.Windows.Forms.Label();
            this.Lbl_Saldo_Final_Producto = new System.Windows.Forms.Label();
            this.Pnl_Principal_Cierre.SuspendLayout();
            this.Gpb_Cierre.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Principal_Cierre
            // 
            this.Pnl_Principal_Cierre.Controls.Add(this.Gpb_Cierre);
            this.Pnl_Principal_Cierre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Principal_Cierre.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Principal_Cierre.Margin = new System.Windows.Forms.Padding(4);
            this.Pnl_Principal_Cierre.Name = "Pnl_Principal_Cierre";
            this.Pnl_Principal_Cierre.Size = new System.Drawing.Size(634, 261);
            this.Pnl_Principal_Cierre.TabIndex = 0;
            // 
            // Gpb_Cierre
            // 
            this.Gpb_Cierre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gpb_Cierre.Controls.Add(this.Btn_Cancelar_Cierre);
            this.Gpb_Cierre.Controls.Add(this.Btn_Cierre_Inventario);
            this.Gpb_Cierre.Controls.Add(this.Txt_Cargos_Mes);
            this.Gpb_Cierre.Controls.Add(this.Txt_Cargos_Acumulados);
            this.Gpb_Cierre.Controls.Add(this.Txt_Abono_Acumulado);
            this.Gpb_Cierre.Controls.Add(this.Txt_Abono_Mes);
            this.Gpb_Cierre.Controls.Add(this.Txt_Saldo_Final);
            this.Gpb_Cierre.Controls.Add(this.Lbl_Saldo_Inicial);
            this.Gpb_Cierre.Controls.Add(this.Txt_Saldo_Inicial_Producto);
            this.Gpb_Cierre.Controls.Add(this.Lbl_Cargos_Mes_Producto);
            this.Gpb_Cierre.Controls.Add(this.Lbl_Abonos_Acumulados);
            this.Gpb_Cierre.Controls.Add(this.Lbl_Cargos_Acumulados);
            this.Gpb_Cierre.Controls.Add(this.Lbl_Abono_Mes_Producto);
            this.Gpb_Cierre.Controls.Add(this.Lbl_Saldo_Final_Producto);
            this.Gpb_Cierre.Location = new System.Drawing.Point(12, 12);
            this.Gpb_Cierre.Name = "Gpb_Cierre";
            this.Gpb_Cierre.Size = new System.Drawing.Size(616, 237);
            this.Gpb_Cierre.TabIndex = 41;
            this.Gpb_Cierre.TabStop = false;
            // 
            // Btn_Cancelar_Cierre
            // 
            this.Btn_Cancelar_Cierre.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancelar_Cierre.Location = new System.Drawing.Point(240, 203);
            this.Btn_Cancelar_Cierre.Name = "Btn_Cancelar_Cierre";
            this.Btn_Cancelar_Cierre.Size = new System.Drawing.Size(162, 28);
            this.Btn_Cancelar_Cierre.TabIndex = 46;
            this.Btn_Cancelar_Cierre.Text = "Cancelar Cierre";
            this.Btn_Cancelar_Cierre.UseVisualStyleBackColor = true;
            this.Btn_Cancelar_Cierre.Click += new System.EventHandler(this.Btn_Cancelar_Cierre_Click);
            // 
            // Btn_Cierre_Inventario
            // 
            this.Btn_Cierre_Inventario.BackColor = System.Drawing.Color.IndianRed;
            this.Btn_Cierre_Inventario.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cierre_Inventario.Location = new System.Drawing.Point(240, 169);
            this.Btn_Cierre_Inventario.Name = "Btn_Cierre_Inventario";
            this.Btn_Cierre_Inventario.Size = new System.Drawing.Size(162, 28);
            this.Btn_Cierre_Inventario.TabIndex = 45;
            this.Btn_Cierre_Inventario.Text = "Cerrar Inventario";
            this.Btn_Cierre_Inventario.UseVisualStyleBackColor = false;
            this.Btn_Cierre_Inventario.Click += new System.EventHandler(this.Btn_Cierre_Inventario_Click);
            // 
            // Txt_Cargos_Mes
            // 
            this.Txt_Cargos_Mes.Location = new System.Drawing.Point(493, 46);
            this.Txt_Cargos_Mes.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Cargos_Mes.MaxLength = 5;
            this.Txt_Cargos_Mes.Name = "Txt_Cargos_Mes";
            this.Txt_Cargos_Mes.Size = new System.Drawing.Size(116, 23);
            this.Txt_Cargos_Mes.TabIndex = 44;
            // 
            // Txt_Cargos_Acumulados
            // 
            this.Txt_Cargos_Acumulados.Location = new System.Drawing.Point(493, 16);
            this.Txt_Cargos_Acumulados.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Cargos_Acumulados.MaxLength = 5;
            this.Txt_Cargos_Acumulados.Name = "Txt_Cargos_Acumulados";
            this.Txt_Cargos_Acumulados.Size = new System.Drawing.Size(116, 23);
            this.Txt_Cargos_Acumulados.TabIndex = 43;
            // 
            // Txt_Abono_Acumulado
            // 
            this.Txt_Abono_Acumulado.Location = new System.Drawing.Point(178, 107);
            this.Txt_Abono_Acumulado.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Abono_Acumulado.MaxLength = 5;
            this.Txt_Abono_Acumulado.Name = "Txt_Abono_Acumulado";
            this.Txt_Abono_Acumulado.Size = new System.Drawing.Size(116, 23);
            this.Txt_Abono_Acumulado.TabIndex = 42;
            // 
            // Txt_Abono_Mes
            // 
            this.Txt_Abono_Mes.Location = new System.Drawing.Point(178, 76);
            this.Txt_Abono_Mes.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Abono_Mes.MaxLength = 5;
            this.Txt_Abono_Mes.Name = "Txt_Abono_Mes";
            this.Txt_Abono_Mes.Size = new System.Drawing.Size(116, 23);
            this.Txt_Abono_Mes.TabIndex = 41;
            // 
            // Txt_Saldo_Final
            // 
            this.Txt_Saldo_Final.Location = new System.Drawing.Point(178, 46);
            this.Txt_Saldo_Final.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Saldo_Final.MaxLength = 5;
            this.Txt_Saldo_Final.Name = "Txt_Saldo_Final";
            this.Txt_Saldo_Final.Size = new System.Drawing.Size(116, 23);
            this.Txt_Saldo_Final.TabIndex = 40;
            // 
            // Lbl_Saldo_Inicial
            // 
            this.Lbl_Saldo_Inicial.AutoSize = true;
            this.Lbl_Saldo_Inicial.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Saldo_Inicial.Location = new System.Drawing.Point(6, 18);
            this.Lbl_Saldo_Inicial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Saldo_Inicial.Name = "Lbl_Saldo_Inicial";
            this.Lbl_Saldo_Inicial.Size = new System.Drawing.Size(96, 17);
            this.Lbl_Saldo_Inicial.TabIndex = 33;
            this.Lbl_Saldo_Inicial.Text = "Saldo Inicial";
            // 
            // Txt_Saldo_Inicial_Producto
            // 
            this.Txt_Saldo_Inicial_Producto.Location = new System.Drawing.Point(178, 16);
            this.Txt_Saldo_Inicial_Producto.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Saldo_Inicial_Producto.MaxLength = 5;
            this.Txt_Saldo_Inicial_Producto.Name = "Txt_Saldo_Inicial_Producto";
            this.Txt_Saldo_Inicial_Producto.Size = new System.Drawing.Size(116, 23);
            this.Txt_Saldo_Inicial_Producto.TabIndex = 34;
            // 
            // Lbl_Cargos_Mes_Producto
            // 
            this.Lbl_Cargos_Mes_Producto.AutoSize = true;
            this.Lbl_Cargos_Mes_Producto.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cargos_Mes_Producto.Location = new System.Drawing.Point(332, 48);
            this.Lbl_Cargos_Mes_Producto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Cargos_Mes_Producto.Name = "Lbl_Cargos_Mes_Producto";
            this.Lbl_Cargos_Mes_Producto.Size = new System.Drawing.Size(118, 17);
            this.Lbl_Cargos_Mes_Producto.TabIndex = 35;
            this.Lbl_Cargos_Mes_Producto.Text = "Cargos del Mes";
            // 
            // Lbl_Abonos_Acumulados
            // 
            this.Lbl_Abonos_Acumulados.AutoSize = true;
            this.Lbl_Abonos_Acumulados.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Abonos_Acumulados.Location = new System.Drawing.Point(7, 109);
            this.Lbl_Abonos_Acumulados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Abonos_Acumulados.Name = "Lbl_Abonos_Acumulados";
            this.Lbl_Abonos_Acumulados.Size = new System.Drawing.Size(153, 17);
            this.Lbl_Abonos_Acumulados.TabIndex = 39;
            this.Lbl_Abonos_Acumulados.Text = "Abonos Acumulados";
            // 
            // Lbl_Cargos_Acumulados
            // 
            this.Lbl_Cargos_Acumulados.AutoSize = true;
            this.Lbl_Cargos_Acumulados.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cargos_Acumulados.Location = new System.Drawing.Point(332, 18);
            this.Lbl_Cargos_Acumulados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Cargos_Acumulados.Name = "Lbl_Cargos_Acumulados";
            this.Lbl_Cargos_Acumulados.Size = new System.Drawing.Size(149, 17);
            this.Lbl_Cargos_Acumulados.TabIndex = 38;
            this.Lbl_Cargos_Acumulados.Text = "Cargos Acumulados";
            // 
            // Lbl_Abono_Mes_Producto
            // 
            this.Lbl_Abono_Mes_Producto.AutoSize = true;
            this.Lbl_Abono_Mes_Producto.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Abono_Mes_Producto.Location = new System.Drawing.Point(6, 78);
            this.Lbl_Abono_Mes_Producto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Abono_Mes_Producto.Name = "Lbl_Abono_Mes_Producto";
            this.Lbl_Abono_Mes_Producto.Size = new System.Drawing.Size(115, 17);
            this.Lbl_Abono_Mes_Producto.TabIndex = 36;
            this.Lbl_Abono_Mes_Producto.Text = "Abono del Mes";
            // 
            // Lbl_Saldo_Final_Producto
            // 
            this.Lbl_Saldo_Final_Producto.AutoSize = true;
            this.Lbl_Saldo_Final_Producto.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Saldo_Final_Producto.Location = new System.Drawing.Point(6, 48);
            this.Lbl_Saldo_Final_Producto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Saldo_Final_Producto.Name = "Lbl_Saldo_Final_Producto";
            this.Lbl_Saldo_Final_Producto.Size = new System.Drawing.Size(86, 17);
            this.Lbl_Saldo_Final_Producto.TabIndex = 37;
            this.Lbl_Saldo_Final_Producto.Text = "Saldo Final";
            // 
            // Frm_Cierre_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 261);
            this.Controls.Add(this.Pnl_Principal_Cierre);
            this.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(650, 300);
            this.Name = "Frm_Cierre_Inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Cierre_Inventario";
            this.Pnl_Principal_Cierre.ResumeLayout(false);
            this.Gpb_Cierre.ResumeLayout(false);
            this.Gpb_Cierre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Principal_Cierre;
        private System.Windows.Forms.Label Lbl_Abonos_Acumulados;
        private System.Windows.Forms.Label Lbl_Cargos_Acumulados;
        private System.Windows.Forms.Label Lbl_Saldo_Final_Producto;
        private System.Windows.Forms.Label Lbl_Abono_Mes_Producto;
        private System.Windows.Forms.Label Lbl_Cargos_Mes_Producto;
        private System.Windows.Forms.TextBox Txt_Saldo_Inicial_Producto;
        private System.Windows.Forms.Label Lbl_Saldo_Inicial;
        private System.Windows.Forms.GroupBox Gpb_Cierre;
        private System.Windows.Forms.TextBox Txt_Abono_Mes;
        private System.Windows.Forms.TextBox Txt_Saldo_Final;
        private System.Windows.Forms.TextBox Txt_Cargos_Mes;
        private System.Windows.Forms.TextBox Txt_Cargos_Acumulados;
        private System.Windows.Forms.TextBox Txt_Abono_Acumulado;
        private System.Windows.Forms.Button Btn_Cierre_Inventario;
        private System.Windows.Forms.Button Btn_Cancelar_Cierre;
    }
}