using System;
using System.Data;
using System.Data.Odbc;
using System.Globalization;
using System.Windows.Forms;

namespace Capa_Vista_CxP
{
    public partial class Frm_CxP_Gestion : Form
    {
        // ⚠️ Cambia el DSN si usas otro nombre
        private const string DSN = "bd_hoteleria";
        private const int ID_USUARIO = 1; // luego enlazas con tu login

        public Frm_CxP_Gestion()
        {
            InitializeComponent();

            // Por si no están ligados en el diseñador
            this.Shown += Frm_CxP_Gestion_Shown;
            Btn_Registro.Click += Btn_Registro_Click;
            Btn_Limpiar.Click += Btn_Limpiar_Click;

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        // ----- Conexión ODBC -----
        private OdbcConnection Abrir()
        {
            var cn = new OdbcConnection($"Dsn={DSN};");
            cn.Open();
            return cn;
        }

        // ----- Carga inicial -----
        private void Frm_CxP_Gestion_Shown(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
            CargarGrid();
        }

        private void CargarGrid()
        {
            using (var cn = Abrir())
            using (var da = new OdbcDataAdapter(
                "SELECT * FROM Vw_CxP_Gestion ORDER BY FechaEmision DESC, Id_DocCxP DESC;", cn))
            {
                var dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                if (dataGridView1.Columns.Contains("Id_DocCxP"))
                    dataGridView1.Columns["Id_DocCxP"].HeaderText = "Id";
            }
        }

        // ----- Registrar factura -----
        private void Btn_Registro_Click(object sender, EventArgs e)
        {
            try
            {
                string proveedor = (Txt_Proveedor.Text ?? "").Trim();
                string numero = (textBox1.Text ?? "").Trim();
                string serie = ""; // pon "A" si quieres manejar series

                if (string.IsNullOrWhiteSpace(proveedor))
                    throw new Exception("Ingrese el nombre del proveedor.");
                if (string.IsNullOrWhiteSpace(numero))
                    throw new Exception("Ingrese el número de factura.");

                if (!TryParseMonto(textBox2.Text, out decimal total) || total <= 0)
                    throw new Exception("Total inválido o <= 0.");

                DateTime fEmi = dateTimePicker1.Value.Date;
                DateTime fVen = dateTimePicker2.Value.Date;
                if (fVen < fEmi) throw new Exception("La fecha de vencimiento no puede ser menor a la de emisión.");

                int idProveedor = EnsureProveedorId(proveedor);
                InsertarDocumento(idProveedor, serie, numero, fEmi, fVen, total, "", ID_USUARIO);

                CargarGrid();
                Limpiar();
                MessageBox.Show("Factura registrada correctamente.", "CxP", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Validación / Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool TryParseMonto(string input, out decimal valor)
        {
            input = (input ?? "").Trim();

            // intenta invariante (punto) y cultura local (coma)
            return decimal.TryParse(input, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out valor)
                || decimal.TryParse(input, NumberStyles.Any, CultureInfo.CurrentCulture, out valor);
        }

        // Crea proveedor si no existe y retorna Id
        private int EnsureProveedorId(string nombreProveedor)
        {
            using (var cn = Abrir())
            {
                // 1) ¿Ya existe?
                using (var cmd = new OdbcCommand(
                    "SELECT Cmp_Id_Proveedor FROM Tbl_Proveedor WHERE Cmp_Nombre_Proveedor = ? LIMIT 1;", cn))
                {
                    cmd.Parameters.AddWithValue("@p1", nombreProveedor);
                    var x = cmd.ExecuteScalar();
                    if (x != null && x != DBNull.Value) return Convert.ToInt32(x);
                }

                // 2) No existe: INSERT (una sola sentencia)
                using (var cmdIns = new OdbcCommand(
                    "INSERT INTO Tbl_Proveedor (Cmp_Nombre_Proveedor, Cmp_Nit, Cmp_Telefono, Cmp_Direccion) VALUES (?, 'CF', NULL, NULL);",
                    cn))
                {
                    cmdIns.Parameters.AddWithValue("@p1", nombreProveedor);
                    cmdIns.ExecuteNonQuery();
                }

                // 3) Obtener el nuevo id con una segunda sentencia
                using (var cmdId = new OdbcCommand("SELECT LAST_INSERT_ID();", cn))
                {
                    var id = cmdId.ExecuteScalar();
                    return Convert.ToInt32(id);
                }
            }
        }

        private void InsertarDocumento(int idProveedor, string serie, string numero,
                                       DateTime fEmi, DateTime fVen, decimal total,
                                       string descripcion, int idUsuario)
        {
            const string sql = @"
        INSERT INTO Tbl_CxP_Documento
        (Cmp_Id_Proveedor, Cmp_Serie, Cmp_Numero, Cmp_Tipo_Documento,
         Cmp_Fecha_Emision, Cmp_Fecha_Vencimiento,
         Cmp_Total_Documento, Cmp_Saldo_Pendiente, Cmp_Estado, Cmp_Descripcion,
         Cmp_Id_Usuario_Creacion)
        VALUES (?, ?, ?, 'Factura Compra', ?, ?, ?, ?, 'Pendiente', ?, ?);";

            // Formatos robustos para ODBC/MySQL
            string sFechaEmi = fEmi.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string sFechaVen = fVen.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string sTotal = total.ToString(CultureInfo.InvariantCulture);

            using (var cn = Abrir())
            using (var cmd = new OdbcCommand(sql, cn))
            {
                // OJO: ODBC es POSICIONAL. Respeta el orden de los ? en el SQL.
                cmd.Parameters.Add("@p1", OdbcType.Int).Value = idProveedor;                             // int
                cmd.Parameters.Add("@p2", OdbcType.VarChar, 20).Value = string.IsNullOrWhiteSpace(serie) ? "A" : serie.Trim();
                cmd.Parameters.Add("@p3", OdbcType.VarChar, 30).Value = numero?.Trim() ?? "";

                // Enviar fechas como ISO (cadena)
                cmd.Parameters.Add("@p4", OdbcType.VarChar, 10).Value = sFechaEmi;                                // 'YYYY-MM-DD'
                cmd.Parameters.Add("@p5", OdbcType.VarChar, 10).Value = sFechaVen;

                // Enviar decimales como cadena invariante (punto)
                cmd.Parameters.Add("@p6", OdbcType.VarChar, 32).Value = sTotal;                                   // total
                cmd.Parameters.Add("@p7", OdbcType.VarChar, 32).Value = sTotal;                                   // saldo inicial

                cmd.Parameters.Add("@p8", OdbcType.VarChar, 500).Value = descripcion?.Trim() ?? "";
                cmd.Parameters.Add("@p9", OdbcType.Int).Value = idUsuario;                                // int

                cmd.ExecuteNonQuery();
            }
        }

        // ----- Limpiar -----
        private void Btn_Limpiar_Click(object sender, EventArgs e) => Limpiar();

        private void Limpiar()
        {
            Txt_Proveedor.Clear();
            textBox1.Clear();
            textBox2.Clear();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
            Txt_Proveedor.Focus();
        }
        // Evento temporal para evitar error de compilación
        private void Btn_Pagos_Click(object sender, EventArgs e)
        {
            Frm_CxP_Pagos CxP_pagos = new Frm_CxP_Pagos();
            CxP_pagos.Show();
            this.Hide();
        }

    }
}
