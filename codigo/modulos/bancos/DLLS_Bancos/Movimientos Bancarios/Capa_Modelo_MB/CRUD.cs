using System;
using System.Data;
using System.Data.Odbc;
using System.Collections.Generic;

namespace Capa_Modelo_MB
{
    public class CRUD
    {
        Conexion cn = new Conexion();

        // Obtener las cuentas bancarias
        public DataTable ObtenerCuentas()
        {
            try
            {
                string sql = @"SELECT 
                            Pk_Id_Cuenta, 
                            Cmp_Numero_Cuenta,
                            Cmp_Nombre_Cuenta
                       FROM Tbl_Cuenta_Bancaria
                       WHERE Cmp_Estado_Cuenta = 1";


                OdbcDataAdapter da = new OdbcDataAdapter(sql, cn.ConexionBD());
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las cuentas: " + ex.Message);
            }
        }


        public string ObtenerNombreCuenta(int idCuenta)
        {
            string nombreCuenta = "";
            try
            {
                string sql = @"SELECT Cmp_Nombre_Cuenta
                       FROM Tbl_Cuenta_Bancaria
                       WHERE Pk_Id_Cuenta = ?";
                using (OdbcConnection conn = cn.ConexionBD())
                {
                    using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Pk_Id_Cuenta", idCuenta);
                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                            nombreCuenta = result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el nombre de la cuenta: " + ex.Message);
            }
            return nombreCuenta;
        }

        public DataTable ObtenerOperaciones()
        {
            try
            {
                string sql = @"SELECT 
                    Pk_Id_operacion, 
                    Cmp_nombre 
                   FROM Tbl_Operaciones_Bancarias
                   WHERE Cmp_estado = 'Activo'";
                OdbcDataAdapter da = new OdbcDataAdapter(sql, cn.ConexionBD());
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las operaciones bancarias: " + ex.Message);
            }
        }

        public DataTable ObtenerConceptos()
        {
            string sql = "SELECT " +
                            "Pk_Id_concepto, " +
                            "Cmp_nombre " +
                        "FROM Tbl_Conceptos_Bancarios " +
                        "WHERE Cmp_estado = 'Activo'";
            using (var da = new OdbcDataAdapter(sql, cn.ConexionBD()))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public string ObtenerSignoOperacionPorId(int idOperacion)
        {
            string signo = "";
            try
            {
                string sql = @"SELECT Cmp_signo 
                       FROM Tbl_Operaciones_Bancarias
                       WHERE Pk_Id_operacion = ? AND Cmp_estado = 'Activo'";

                using (OdbcConnection conn = cn.ConexionBD())
                using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idOperacion);
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                        signo = result.ToString(); // "+" o "-"
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el signo de la operación: " + ex.Message);
            }
            return signo;
        }

        // --- util para truncar cadenas ---
        private static string Trunc(string s, int max)
        {
            if (string.IsNullOrWhiteSpace(s)) return null;
            return s.Length <= max ? s : s.Substring(0, max);
        }

        public int CrearMovimientoConDetalles(Sentencias mov, List<Sentencias.MovimientoDetalle> detalles)
        {
            if (mov == null) throw new ArgumentNullException(nameof(mov));
            if (detalles == null) detalles = new List<Sentencias.MovimientoDetalle>();

            // ========== VALIDACIÓN DE CUENTAS ==========
            using (var con = cn.ConexionBD())
            {
                // Verificar que la cuenta origen existe
                string validarCuentaOrigen = "SELECT COUNT(*) FROM Tbl_Cuenta_Bancaria WHERE Pk_Id_Cuenta = ?";
                using (var cmdVal = new OdbcCommand(validarCuentaOrigen, con))
                {
                    cmdVal.Parameters.AddWithValue("", mov.Fk_Id_cuenta_origen);
                    int cuentaOrigenExiste = Convert.ToInt32(cmdVal.ExecuteScalar());
                    if (cuentaOrigenExiste == 0)
                    {
                        throw new Exception($"La cuenta origen (ID: {mov.Fk_Id_cuenta_origen}) no existe en la base de datos");
                    }
                }

                // Si hay cuenta destino, validar que también existe
                if (mov.Fk_Id_cuenta_destino.HasValue && mov.Fk_Id_cuenta_destino.Value > 0)
                {
                    string validarCuentaDestino = "SELECT COUNT(*) FROM Tbl_Cuenta_Bancaria WHERE Pk_Id_Cuenta = ?";
                    using (var cmdVal = new OdbcCommand(validarCuentaDestino, con))
                    {
                        cmdVal.Parameters.AddWithValue("", mov.Fk_Id_cuenta_destino.Value);
                        int cuentaDestinoExiste = Convert.ToInt32(cmdVal.ExecuteScalar());

                        if (cuentaDestinoExiste == 0)
                        {
                            throw new Exception($"La cuenta destino (ID: {mov.Fk_Id_cuenta_destino.Value}) no existe en la base de datos");
                        }
                    }
                }
            }

            // ========== FIN VALIDACIÓN ==========
            mov.Cmp_numero_documento = Trunc(mov.Cmp_numero_documento, 50);
            mov.Cmp_observaciones = Trunc(mov.Cmp_observaciones, 300);
            mov.Cmp_estado = Trunc(string.IsNullOrWhiteSpace(mov.Cmp_estado) ? "Activo" : mov.Cmp_estado, 20);

            using (var con = cn.ConexionBD())
            using (var tx = con.BeginTransaction())
            {
                try
                {
                    // ================= ENCABEZADO =================
                    string sqlMov = @"
                INSERT INTO Tbl_Movimientos_Bancarios
                (Fk_Id_cuenta_origen, Fk_Id_cuenta_destino, Fk_Id_operacion, Fk_Id_concepto,
                 Cmp_fecha_movimiento, Cmp_numero_documento, Cmp_valor_total,
                 Cmp_observaciones, Cmp_conciliado, Cmp_estado)
                VALUES (?,?,?,?,?,?,?,?,?,?)";

                    using (var cmd = new OdbcCommand(sqlMov, con, tx))
                    {
                        // Los parámetros deben agregarse en el mismo orden de los VALUES
                        cmd.Parameters.AddWithValue("", mov.Fk_Id_cuenta_origen);
                        cmd.Parameters.AddWithValue("", (object)mov.Fk_Id_cuenta_destino ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("", mov.Fk_Id_operacion);
                        cmd.Parameters.AddWithValue("", (object)mov.Fk_Id_concepto ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("", mov.Cmp_fecha_movimiento);
                        cmd.Parameters.AddWithValue("", (object)mov.Cmp_numero_documento ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("", Convert.ToDouble(mov.Cmp_valor_total));
                        cmd.Parameters.AddWithValue("", (object)mov.Cmp_observaciones ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("", mov.Cmp_conciliado);
                        cmd.Parameters.AddWithValue("", mov.Cmp_estado);

                        cmd.ExecuteNonQuery();

                        // Obtener el ID generado
                        using (var cmdId = new OdbcCommand("SELECT LAST_INSERT_ID()", con, tx))
                        {
                            mov.Pk_Id_movimiento = Convert.ToInt32(cmdId.ExecuteScalar());
                        }
                    }

                    // ================= DETALLES =================
                    if (detalles.Count > 0)
                    {
                        string sqlDet = @"
                    INSERT INTO Tbl_Detalle_MovBancario
                    (Fk_Id_movimiento, Fk_Id_tipo_pago, Cmp_Num_Documento, Cmp_Monto, Cmp_Descripcion, Cmp_Conciliado)
                    VALUES (?,?,?,?,?,?)";

                        using (var cmdDet = new OdbcCommand(sqlDet, con, tx))
                        {
                            foreach (var d in detalles)
                            {
                                // Saneo por cada detalle
                                d.Cmp_Num_Documento = Trunc(d.Cmp_Num_Documento, 50);
                                d.Cmp_Descripcion = Trunc(d.Cmp_Descripcion, 500);

                                // Agregar parámetros en el orden correcto
                                cmdDet.Parameters.Clear();
                                cmdDet.Parameters.AddWithValue("", mov.Pk_Id_movimiento);  // ✅ CORREGIDO
                                cmdDet.Parameters.AddWithValue("", (object)d.Fk_Id_tipo_pago ?? DBNull.Value);
                                cmdDet.Parameters.AddWithValue("", (object)d.Cmp_Num_Documento ?? DBNull.Value);
                                cmdDet.Parameters.AddWithValue("", Convert.ToDouble(d.Cmp_Monto));
                                cmdDet.Parameters.AddWithValue("", (object)d.Cmp_Descripcion ?? DBNull.Value);
                                cmdDet.Parameters.AddWithValue("", d.Cmp_Conciliado);

                                cmdDet.ExecuteNonQuery();
                            }
                        }
                    }

                    tx.Commit();
                    return mov.Pk_Id_movimiento;
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    throw new Exception("Error al crear movimiento con detalles: " + ex.Message);
                }
            }
        }

        // En tu clase CRUD 
        public List<string> ObtenerEstadosMovimiento()
        {
            var estados = new List<string>();

            try
            {
                string sql = @"
            SELECT COLUMN_TYPE 
            FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_SCHEMA = DATABASE() 
            AND TABLE_NAME = 'Tbl_Movimientos_Bancarios' 
            AND COLUMN_NAME = 'Cmp_estado'";
                using (var con = cn.ConexionBD())
                using (var cmd = new OdbcCommand(sql, con))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string enumDefinition = reader.GetString(0);
                            // El formato viene como: ENUM('Activo','Anulado','Pendiente','Trasladado')
                            // Extraer los valores del ENUM
                            estados = ExtraerValoresEnum(enumDefinition);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Si falla, usar valores por defecto
                estados = new List<string> { "Activo", "Anulado", "Pendiente", "Trasladado" };
                Console.WriteLine($"Error al obtener estados: {ex.Message}. Usando valores por defecto.");
            }

            return estados;
        }

        private List<string> ExtraerValoresEnum(string enumDefinition)
        {
            var valores = new List<string>();

            try
            {
                // Remover "ENUM(" y ")"
                string valoresStr = enumDefinition
                    .Replace("ENUM", "")
                    .Replace("enum('", "")
                    .Replace(")", "")
                    .Trim('\'');
                // Separar por comas y remover comillas simples
                string[] partes = valoresStr.Split(',');
                foreach (string parte in partes)
                {
                    string valor = parte.Trim().Trim('\'');
                    if (!string.IsNullOrEmpty(valor))
                        valores.Add(valor);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error extrayendo valores ENUM: {ex.Message}");
                // Valores por defecto
                valores = new List<string> { "Activo", "Anulado", "Pendiente", "Trasladado" };
            }
            return valores;
        }

        public DataTable ObtenerDetallesContablesParaCaptura()
        {
            try
            {
                string query = @"
            SELECT 
                NULL AS Fk_Id_tipo_pago,
                m.Cmp_numero_documento AS Cmp_Num_Documento,
                CASE 
                    WHEN o.Cmp_signo = '-' THEN d.Cmp_valor 
                    ELSE 0 
                END AS Debe,
                CASE 
                    WHEN o.Cmp_signo = '+' THEN d.Cmp_valor 
                    ELSE 0 
                END AS Haber,
                CONCAT('Cuenta contable: ', d.Fk_Id_cuenta_contable) AS Cmp_Concepto
            FROM Tbl_MovBancario_DetalleContable d
            INNER JOIN Tbl_Movimientos_Bancarios m ON d.Fk_Id_movimiento = m.Pk_Id_movimiento
            INNER JOIN Tbl_Operaciones_Bancarias o ON m.Fk_Id_operacion = o.Pk_Id_operacion
            ORDER BY m.Pk_Id_movimiento DESC";

                OdbcDataAdapter da = new OdbcDataAdapter(query, cn.ConexionBD());
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener movimientos bancarios: " + ex.Message);
            }
        }

        public int ObtenerCuentaContablePorDefecto()
        {
            try
            {
                string sql = "SELECT Cmp_valor FROM Tbl_Configuracion_Cuentas WHERE Cmp_clave = 'CUENTA_CONTABLE_DEFAULT' AND Cmp_estado = 'Activo'";
                using (var con = new Conexion().ConexionBD())
                using (var cmd = new OdbcCommand(sql, con))
                {
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 1; // Default to 1 if not found
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener cuenta contable por defecto: {ex.Message}");
                return 1; // Valor por defecto
            }
        }

        public string ObtenerTipoLineaPorSigno(string signoOperacion)
        {
            return signoOperacion == "-" ? "D" : "H"; // '-' = Debe (D), '+' = Haber (H)
        }

        // Método para obtener detalles contables
        public DataTable ObtenerDetallesContables()
        {
            try
            {
                string query = @"
                    SELECT 
                        dc.Pk_Id_detalleContable as ID_Detalle,
                        dc.Fk_Id_movimiento as ID_Movimiento,
                        dc.Fk_Id_cuenta_contable as Cuenta_Contable,
                        dc.Cmp_tipo_linea as Tipo_Linea,
                        dc.Cmp_valor as Valor,
                        mb.Cmp_numero_documento as Documento,
                        mb.Cmp_fecha_movimiento as Fecha_Movimiento
                    FROM Tbl_MovBancario_DetalleContable dc
                    INNER JOIN Tbl_Movimientos_Bancarios mb ON dc.Fk_Id_movimiento = mb.Pk_Id_movimiento
                    ORDER BY dc.Pk_Id_detalleContable DESC";
                OdbcDataAdapter da = new OdbcDataAdapter(query, cn.ConexionBD());
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener detalles contables: " + ex.Message);
            }
        }
    }
}