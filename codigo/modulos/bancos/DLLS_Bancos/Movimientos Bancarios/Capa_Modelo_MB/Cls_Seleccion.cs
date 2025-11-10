using System;
using System.Data;
using System.Data.Odbc;
using System.Collections.Generic;
using System.Text;

namespace Capa_Modelo_MB
{
    public class Cls_Seleccion
    {
        private readonly Cls_Conexion oCn = new Cls_Conexion();

        public DataTable fun_obtener_cuentas()
        {
            try
            {
                string sSql = @"
            SELECT 
                Pk_Codigo_Cuenta,
                Cmp_CtaNombre,
                Cmp_CtaMadre,
                Cmp_CtaTipo,
                Cmp_CtaNaturaleza
            FROM Tbl_Catalogo_Cuentas
            WHERE Cmp_CtaTipo = 1       
            ORDER BY Pk_Codigo_Cuenta;";

                using (var da = new OdbcDataAdapter(sSql, oCn.fun_conexion_bd()))
                {
                    var dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las cuentas: " + ex.Message);
            }
        }


        public DataTable fun_obtener_cuentas_bancarias()
        {
            try
            {
                string sSql = @"
            SELECT 
                cb.Pk_Id_CuentaBancaria,
                cb.Cmp_NumeroCuenta,
                b.Cmp_NombreBanco
            FROM Tbl_CuentasBancarias cb
            INNER JOIN Tbl_Bancos b ON b.Pk_Id_Banco = cb.Fk_Id_Banco
            WHERE cb.Cmp_Estado = 1
            ORDER BY b.Cmp_NombreBanco, cb.Cmp_NumeroCuenta;";

                using (var da = new OdbcDataAdapter(sSql, oCn.fun_conexion_bd()))
                {
                    var dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener cuentas bancarias: " + ex.Message);
            }
        }


        public string fun_obtener_nombre_cuenta_bancaria_por_id(int iIdCuentaBancaria)
        {
            try
            {
                string sSql = @"
            SELECT CONCAT(cb.Cmp_NumeroCuenta, ' - ', b.Cmp_NombreBanco) AS Nombre
            FROM Tbl_CuentasBancarias cb
            INNER JOIN Tbl_Bancos b ON b.Pk_Id_Banco = cb.Fk_Id_Banco
            WHERE cb.Pk_Id_CuentaBancaria = ?";

                using (var cn = oCn.fun_conexion_bd())
                using (var cmd = new OdbcCommand(sSql, cn))
                {
                    cmd.Parameters.AddWithValue("@id", iIdCuentaBancaria);
                    object o = cmd.ExecuteScalar();
                    return (o == null || o == DBNull.Value) ? "" : o.ToString();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener nombre de cuenta bancaria: " + ex.Message);
            }
        }


        public DataTable fun_obtener_cuentas_catalogo()
        {
            try
            {
                string sSql = @"
            SELECT 
                Pk_Codigo_Cuenta,
                Cmp_CtaNombre,
                CONCAT(Pk_Codigo_Cuenta, ' - ', Cmp_CtaNombre) AS CuentaDisplay
            FROM Tbl_Catalogo_Cuentas
            WHERE Cmp_CtaTipo = 1       -- Solo cuentas detalle
            ORDER BY Pk_Codigo_Cuenta;";
                using (var da = new OdbcDataAdapter(sSql, oCn.fun_conexion_bd()))
                {
                    var dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener cuentas del catálogo: " + ex.Message);
            }
        }

        public string fun_obtener_nombre_cuenta_catalogo(string sCodigoCuenta)
        {
            try
            {
                string sSql = @"
            SELECT Cmp_CtaNombre
            FROM Tbl_Catalogo_Cuentas
            WHERE Pk_Codigo_Cuenta = ?";
                using (var cn = oCn.fun_conexion_bd())
                using (var cmd = new OdbcCommand(sSql, cn))
                {
                    cmd.Parameters.AddWithValue("@cod", sCodigoCuenta);
                    object o = cmd.ExecuteScalar();
                    return (o == null || o == DBNull.Value) ? "" : o.ToString();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener nombre (catálogo): " + ex.Message);
            }
        }


        // Overload de compatibilidad para llamadas que envían int
        public string fun_obtener_nombre_cuenta_catalogo(int iCodigoCuenta)
        {
            return fun_obtener_nombre_cuenta_catalogo(iCodigoCuenta.ToString());
        }



        public DataTable fun_obtener_operaciones()
        {
            try
            {
                string sSql = @"
                    SELECT 
                        Pk_Id_Transaccion AS Pk_Id_operacion, 
                        Cmp_NombreTransaccion AS Cmp_nombre
                    FROM Tbl_TransaccionesBancarias
                    WHERE Cmp_Estado = 1";

                using (var da = new OdbcDataAdapter(sSql, oCn.fun_conexion_bd()))
                {
                    var dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las operaciones bancarias: " + ex.Message);
            }
        }

        public DataTable fun_obtener_tipos_pago()
        {
            try
            {
                string sSql = @"
                    SELECT 
                        Pk_Id_TipoPago AS Pk_Id_TipoPago, 
                        Cmp_NombreTipoPago AS Cmp_nombre
                    FROM Tbl_TiposPago
                    WHERE Cmp_Estado = 1";

                using (var da = new OdbcDataAdapter(sSql, oCn.fun_conexion_bd()))
                {
                    var dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los tipos de pago: " + ex.Message);
            }
        }

        public int? fun_obtener_moneda_por_cuenta(int iIdCuenta)
        {
            try
            {
                string sSql = @"
                    SELECT m.Pk_Id_Moneda
                    FROM Tbl_CuentasBancarias cb
                    INNER JOIN Tbl_Monedas m
                        ON m.Cmp_CodigoMoneda = cb.Cmp_Moneda
                    WHERE cb.Pk_Id_CuentaBancaria = ?";

                using (OdbcConnection conn = oCn.fun_conexion_bd())
                using (OdbcCommand cmd = new OdbcCommand(sSql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", iIdCuenta);
                    object oResult = cmd.ExecuteScalar();
                    return (oResult != null && oResult != DBNull.Value) ? Convert.ToInt32(oResult) : (int?)null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener moneda de cuenta: {ex.Message}");
                return null;
            }
        }

        public string fun_obtener_signo_operacion_por_id(int iIdOperacion)
        {
            string sSigno = "";
            try
            {
                string sSql = @"
                    SELECT Cmp_Efecto 
                    FROM Tbl_TransaccionesBancarias
                    WHERE Pk_Id_Transaccion = ? AND Cmp_Estado = 1";

                using (OdbcConnection odcn_Conn = oCn.fun_conexion_bd())
                using (OdbcCommand odc_Cmd = new OdbcCommand(sSql, odcn_Conn))
                {
                    odc_Cmd.Parameters.AddWithValue("@id", iIdOperacion);
                    object oResultado = odc_Cmd.ExecuteScalar();
                    if (oResultado != null && oResultado != DBNull.Value)
                    {
                        string sEfecto = oResultado.ToString();
                        sSigno = sEfecto == "POSITIVO" ? "+" : "-";
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el signo de la operación: " + ex.Message);
            }
            return sSigno;
        }

        public DataTable fun_obtener_monedas()
        {
            try
            {
                string sSql = @"
                    SELECT 
                        Pk_Id_Moneda, 
                        Cmp_CodigoMoneda,
                        Cmp_NombreMoneda,
                        Cmp_Simbolo
                    FROM Tbl_Monedas
                    WHERE Cmp_Estado = 1
                    ORDER BY Cmp_NombreMoneda";

                using (var da = new OdbcDataAdapter(sSql, oCn.fun_conexion_bd()))
                {
                    var dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las monedas: " + ex.Message);
            }
        }

        public List<string> fun_obtener_estados_movimiento()
        {
            List<string> lst_Estados = new List<string>();

            try
            {
                string sSql = @"
                    SELECT DISTINCT UPPER(TRIM(Cmp_Estado)) 
                    FROM Tbl_MovimientoBancarioEncabezado 
                    WHERE Cmp_Estado IS NOT NULL 
                      AND TRIM(Cmp_Estado) != ''
                    ORDER BY Cmp_Estado";

                using (OdbcConnection odcn_Conn = oCn.fun_conexion_bd())
                using (OdbcCommand odc_Cmd = new OdbcCommand(sSql, odcn_Conn))
                using (OdbcDataReader odr_Reader = odc_Cmd.ExecuteReader())
                {
                    while (odr_Reader.Read())
                    {
                        if (!odr_Reader.IsDBNull(0))
                        {
                            string sEstado = odr_Reader.GetString(0).Trim();
                            if (!string.IsNullOrEmpty(sEstado) && !lst_Estados.Contains(sEstado))
                                lst_Estados.Add(sEstado);
                        }
                    }
                }

                if (lst_Estados.Count == 0)
                {
                    lst_Estados.AddRange(new[] { "ACTIVO", "ANULADO", "PENDIENTE" });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener estados: {ex.Message}");
                lst_Estados = new List<string> { "ACTIVO", "ANULADO", "PENDIENTE" };
            }

            return lst_Estados;
        }

        public DataTable fun_obtener_cuentas_contables()
        {
            try
            {
                string sSql = @"
                    SELECT 
                        Pk_Codigo_Cuenta AS Pk_Id_CuentaContable, 
                        CONCAT(Pk_Codigo_Cuenta, ' - ', Cmp_CtaNombre) AS Cmp_NombreCompleto
                    FROM Tbl_Catalogo_Cuentas
                    ORDER BY Pk_Codigo_Cuenta";

                using (var da = new OdbcDataAdapter(sSql, oCn.fun_conexion_bd()))
                {
                    var dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las cuentas contables: " + ex.Message);
            }
        }

        public DataTable fun_obtener_movimientos_completos(DateTime? dDesde = null, DateTime? dHasta = null, string sEstado = null)
        {
            var sb = new StringBuilder();
            sb.AppendLine("SELECT");
            sb.AppendLine("  Pk_Id_Movimiento,");
            sb.AppendLine("  Fk_Id_CuentaOrigen,");
            sb.AppendLine("  Cmp_NumeroCuenta,");
            sb.AppendLine("  Cmp_NombreBanco,");
            sb.AppendLine("  Fk_Id_Operacion,");
            sb.AppendLine("  Tipo_Operacion,");
            sb.AppendLine("  Cmp_Efecto,");
            sb.AppendLine("  Cmp_NumeroDocumento,");
            sb.AppendLine("  Cmp_Fecha,");
            sb.AppendLine("  Cmp_MontoTotal,");
            sb.AppendLine("  Cmp_Beneficiario,");
            sb.AppendLine("  Cmp_Conciliado,");
            sb.AppendLine("  Estado_Movimiento,");
            sb.AppendLine("  Cmp_UsuarioRegistro,");
            sb.AppendLine("  Fk_Id_TipoPago,");
            sb.AppendLine("  Debe,");
            sb.AppendLine("  Haber");
            sb.AppendLine("FROM Vw_MovimientosBancariosCompletos");
            sb.AppendLine("WHERE 1=1");

            var sSql = sb.ToString();
            var lst_Params = new List<OdbcParameter>();

            if (dDesde.HasValue) { sSql += " AND Cmp_Fecha >= ?"; lst_Params.Add(new OdbcParameter("", dDesde.Value)); }
            if (dHasta.HasValue) { sSql += " AND Cmp_Fecha <  DATE_ADD(?, INTERVAL 1 DAY)"; lst_Params.Add(new OdbcParameter("", dHasta.Value)); }
            if (!string.IsNullOrWhiteSpace(sEstado)) { sSql += " AND Estado_Movimiento = ?"; lst_Params.Add(new OdbcParameter("", sEstado)); }

            sSql += " ORDER BY Cmp_Fecha DESC, Pk_Id_Movimiento DESC;";

            using (var da = new OdbcDataAdapter(sSql, oCn.fun_conexion_bd()))
            {
                foreach (var p in lst_Params) da.SelectCommand.Parameters.Add(p);
                var dt = new DataTable();
                da.Fill(dt);

                // Compatibilidad con grids viejos
                if (!dt.Columns.Contains("Cmp_Num_Documento") && dt.Columns.Contains("Cmp_NumeroDocumento"))
                    dt.Columns["Cmp_NumeroDocumento"].ColumnName = "Cmp_Num_Documento";
                if (!dt.Columns.Contains("Fk_Id_tipo_pago") && dt.Columns.Contains("Fk_Id_TipoPago"))
                    dt.Columns["Fk_Id_TipoPago"].ColumnName = "Fk_Id_tipo_pago";

                return dt;
            }
        }

        public DataTable fun_obtener_movimientos_view(DateTime? dDesde = null, DateTime? dHasta = null, string sEstado = null)
        {
            var sb = new System.Text.StringBuilder();
            sb.AppendLine("SELECT * FROM Vw_MovimientosBancariosCompletos WHERE 1=1");

            var lst_Params = new List<OdbcParameter>();

            if (dDesde.HasValue) { sb.AppendLine("AND Cmp_Fecha >= ?"); lst_Params.Add(new OdbcParameter("", dDesde.Value)); }
            if (dHasta.HasValue) { sb.AppendLine("AND Cmp_Fecha < DATE_ADD(?, INTERVAL 1 DAY)"); lst_Params.Add(new OdbcParameter("", dHasta.Value)); }
            if (!string.IsNullOrWhiteSpace(sEstado)) { sb.AppendLine("AND Estado_Movimiento = ?"); lst_Params.Add(new OdbcParameter("", sEstado)); }

            sb.AppendLine("ORDER BY Cmp_Fecha DESC, Pk_Id_Movimiento DESC;");

            using (var da = new OdbcDataAdapter(sb.ToString(), oCn.fun_conexion_bd()))
            {
                foreach (var p in lst_Params) da.SelectCommand.Parameters.Add(p);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public string fun_obtener_cuenta_contable_por_defecto()
        {
            try
            {
                string sSql = @"
                    SELECT Cmp_Valor 
                    FROM Tbl_ParametrosCheques 
                    WHERE Cmp_Estado = 1
                      AND (Cmp_Parametro = 'CUENTA BANCO PRINCIPAL' OR Cmp_Parametro = 'CUENTA_BANCO_PRINCIPAL')
                    ORDER BY (Cmp_Parametro = 'CUENTA BANCO PRINCIPAL') DESC
                    LIMIT 1";

                using (OdbcConnection odcn_Conn = oCn.fun_conexion_bd())
                using (OdbcCommand odc_Cmd = new OdbcCommand(sSql, odcn_Conn))
                {
                    object oResultado = odc_Cmd.ExecuteScalar();
                    return oResultado != null ? oResultado.ToString() : "1110";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener cuenta contable por defecto: {ex.Message}");
                return "1110";
            }
        }

        // Obtener un movimiento específico por PK compuesta
        public DataTable fun_obtener_movimiento_por_id(int iIdMovimiento, int iIdCuentaOrigen, int iIdOperacion)
        {
            try
            {
                string sSql = @"
                    SELECT 
                        Pk_Id_Movimiento,
                        Fk_Id_CuentaOrigen,
                        Fk_Id_Operacion,
                        Cmp_NumeroDocumento,
                        Cmp_Fecha,
                        Cmp_Concepto,
                        Cmp_MontoTotal,
                        Cmp_Beneficiario,
                        Cmp_Estado,
                        Fk_Id_TipoPago,
                        Fk_Id_CuentaDestino,
                        Fk_Id_Moneda,
                        Cmp_Conciliado 
                    FROM Tbl_MovimientoBancarioEncabezado 
                    WHERE Pk_Id_Movimiento = ? 
                      AND Fk_Id_CuentaOrigen = ? 
                      AND Fk_Id_Operacion = ?";

                using (var da = new OdbcDataAdapter(sSql, oCn.fun_conexion_bd()))
                {
                    da.SelectCommand.Parameters.AddWithValue("@Mov", iIdMovimiento);
                    da.SelectCommand.Parameters.AddWithValue("@CtaOri", iIdCuentaOrigen);
                    da.SelectCommand.Parameters.AddWithValue("@Op", iIdOperacion);

                    var dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener movimiento por ID: " + ex.Message);
            }
        }

        // Detalles del movimiento (por PK compuesta)
        public DataTable fun_obtener_detalles_movimiento(int iIdMovimiento, int iIdCuentaOrigen, int iIdOperacion)
        {
            try
            {
                string sSql = @"
                    SELECT 
                        Pk_Id_Detalle,
                        Fk_Id_CuentaContable,
                        Cmp_TipoOperacion,
                        Cmp_Valor,
                        Cmp_Descripcion,
                        Cmp_OrdenDetalle
                    FROM Tbl_MovimientoBancarioDetalle
                    WHERE Fk_Id_Movimiento = ? 
                      AND Fk_Id_CuentaOrigen = ? 
                      AND Fk_Id_Operacion = ?
                    ORDER BY Cmp_OrdenDetalle";

                using (OdbcConnection odcn_Conn = oCn.fun_conexion_bd())
                using (OdbcCommand cmd = new OdbcCommand(sSql, odcn_Conn))
                {
                    cmd.Parameters.AddWithValue("@Mov", iIdMovimiento);
                    cmd.Parameters.AddWithValue("@CtaOri", iIdCuentaOrigen);
                    cmd.Parameters.AddWithValue("@Op", iIdOperacion);

                    using (var da = new OdbcDataAdapter(cmd))
                    {
                        var dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener detalles del movimiento: " + ex.Message);
            }
        }


    }
}
