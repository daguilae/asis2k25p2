using System;
using System.Data;
using System.Data.Odbc;
using System.Collections.Generic;
using System.Text;


namespace Capa_Modelo_MB
{
    public class Cls_CRUD
    {
        private Cls_Conexion cn = new Cls_Conexion();

        public DataTable fun_ObtenerCuentas()
        {
            try
            {
                string sSql = @"SELECT 
                            Pk_Id_CuentaBancaria AS Pk_Id_Cuenta, 
                            Cmp_NumeroCuenta AS Cmp_Numero_Cuenta,
                            CONCAT(b.Cmp_NombreBanco, ' - ', cb.Cmp_NumeroCuenta) AS Cmp_Nombre_Cuenta
                       FROM Tbl_CuentasBancarias cb
                       INNER JOIN Tbl_Bancos b ON cb.Fk_Id_Banco = b.Pk_Id_Banco
                       WHERE cb.Cmp_Estado = 1";

                OdbcDataAdapter oda_Adapter = new OdbcDataAdapter(sSql, cn.fun_ConexionBD());
                DataTable dts_Resultado = new DataTable();
                oda_Adapter.Fill(dts_Resultado);
                return dts_Resultado;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las cuentas: " + ex.Message);
            }
        }

        public string fun_ObtenerNombreCuenta(int iIdCuenta)
        {
            string sNombreCuenta = "";
            try
            {
                string sSql = @"SELECT CONCAT(b.Cmp_NombreBanco, ' - ', cb.Cmp_NumeroCuenta)
                       FROM Tbl_CuentasBancarias cb
                       INNER JOIN Tbl_Bancos b ON cb.Fk_Id_Banco = b.Pk_Id_Banco
                       WHERE cb.Pk_Id_CuentaBancaria = ?";

                using (OdbcConnection odcn_Conn = cn.fun_ConexionBD())
                {
                    using (OdbcCommand odc_Cmd = new OdbcCommand(sSql, odcn_Conn))
                    {
                        odc_Cmd.Parameters.AddWithValue("@Pk_Id_Cuenta", iIdCuenta);
                        object oResultado = odc_Cmd.ExecuteScalar();

                        if (oResultado != null && oResultado != DBNull.Value)
                            sNombreCuenta = oResultado.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el nombre de la cuenta: " + ex.Message);
            }
            return sNombreCuenta;
        }

        public DataTable fun_ObtenerOperaciones()
        {
            try
            {
                string sSql = @"SELECT 
                    Pk_Id_Transaccion AS Pk_Id_operacion, 
                    Cmp_NombreTransaccion AS Cmp_nombre
                   FROM Tbl_TransaccionesBancarias
                   WHERE Cmp_Estado = 1";

                OdbcDataAdapter oda_Adapter = new OdbcDataAdapter(sSql, cn.fun_ConexionBD());
                DataTable dts_Resultado = new DataTable();
                oda_Adapter.Fill(dts_Resultado);
                return dts_Resultado;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las operaciones bancarias: " + ex.Message);
            }
        }

        public DataTable fun_ObtenerTiposPago()
        {
            try
            {
                string sSql = @"SELECT 
                    Pk_Id_TipoPago AS Pk_Id_TipoPago, 
                    Cmp_NombreTipoPago AS Cmp_nombre
                   FROM Tbl_TiposPago
                   WHERE Cmp_Estado = 1";

                OdbcDataAdapter oda_Adapter = new OdbcDataAdapter(sSql, cn.fun_ConexionBD());
                DataTable dts_Resultado = new DataTable();
                oda_Adapter.Fill(dts_Resultado);
                return dts_Resultado;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los tipos de pago: " + ex.Message);
            }
        }

        public string fun_ObtenerSignoOperacionPorId(int iIdOperacion)
        {
            string sSigno = "";
            try
            {
                string sSql = @"SELECT Cmp_Efecto 
                       FROM Tbl_TransaccionesBancarias
                       WHERE Pk_Id_Transaccion = ? AND Cmp_Estado = 1";

                using (OdbcConnection odcn_Conn = cn.fun_ConexionBD())
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

        private string fun_Trunc(string sCadena, int iMaxLongitud)
        {
            if (string.IsNullOrWhiteSpace(sCadena)) return null;
            return sCadena.Length <= iMaxLongitud ? sCadena : sCadena.Substring(0, iMaxLongitud);
        }


        public int fun_CrearMovimientoConDetalles(
    Cls_Sentencias mov,
    List<Cls_Sentencias.Cls_MovimientoDetalle> lst_Detalles)
        {
            if (mov == null) throw new ArgumentNullException(nameof(mov));
            if (lst_Detalles == null)
                lst_Detalles = new List<Cls_Sentencias.Cls_MovimientoDetalle>();

            // Validaciones básicas antes de la transacción
            if (mov.iFk_Id_cuenta_origen <= 0)
                throw new Exception("La cuenta origen es requerida");

            if (mov.iFk_Id_operacion <= 0)
                throw new Exception("La operación es requerida");

            // Normaliza/trunca strings según longitudes de la BD
            mov.sCmp_numero_documento = fun_Trunc(mov.sCmp_numero_documento, 50);
            mov.sCmp_concepto = fun_Trunc(mov.sCmp_concepto, 255);
            mov.sCmp_beneficiario = fun_Trunc(mov.sCmp_beneficiario, 255);
            mov.sCmp_estado = fun_Trunc(string.IsNullOrWhiteSpace(mov.sCmp_estado) ? "ACTIVO" : mov.sCmp_estado, 20);

            using (var odcn_Conn = cn.fun_ConexionBD())
            {
                // Validar que la conexión esté abierta
                if (odcn_Conn.State != ConnectionState.Open)
                    odcn_Conn.Open();

                using (var trx = odcn_Conn.BeginTransaction())
                {
                    try
                    {
                        // ---- Siguiente ID de movimiento ----
                        int iProximoIdMovimiento;
                        string sSqlMaxId = @"
                    SELECT COALESCE(MAX(Pk_Id_Movimiento), 0) + 1
                    FROM Tbl_MovimientoBancarioEncabezado 
                    WHERE Fk_Id_CuentaOrigen = ? AND Fk_Id_Operacion = ?";

                        using (var cmdMax = new OdbcCommand(sSqlMaxId, odcn_Conn, trx))
                        {
                            cmdMax.Parameters.Add(new OdbcParameter("@cta", OdbcType.Int) { Value = mov.iFk_Id_cuenta_origen });
                            cmdMax.Parameters.Add(new OdbcParameter("@op", OdbcType.Int) { Value = mov.iFk_Id_operacion });

                            object result = cmdMax.ExecuteScalar();
                            iProximoIdMovimiento = Convert.ToInt32(result);
                            if (iProximoIdMovimiento <= 0) iProximoIdMovimiento = 1;
                        }

                        // ---- Insertar encabezado ----
                        string sSqlMov = @"
                    INSERT INTO Tbl_MovimientoBancarioEncabezado
                    (Pk_Id_Movimiento, Fk_Id_CuentaOrigen, Fk_Id_Operacion,
                     Cmp_NumeroDocumento, Cmp_Fecha, Cmp_Concepto, Cmp_MontoTotal,
                     Fk_Id_TipoPago, Fk_Id_CuentaDestino, Cmp_Beneficiario, Cmp_Estado,
                     Cmp_Conciliado, Cmp_UsuarioRegistro)
                    VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

                        using (var cmd = new OdbcCommand(sSqlMov, odcn_Conn, trx))
                        {
                            cmd.Parameters.Add(new OdbcParameter("@Pk", OdbcType.Int) { Value = iProximoIdMovimiento });
                            cmd.Parameters.Add(new OdbcParameter("@CtaOri", OdbcType.Int) { Value = mov.iFk_Id_cuenta_origen });
                            cmd.Parameters.Add(new OdbcParameter("@Op", OdbcType.Int) { Value = mov.iFk_Id_operacion });
                            cmd.Parameters.Add(new OdbcParameter("@NumDoc", OdbcType.VarChar, 50) { Value = (object)mov.sCmp_numero_documento ?? DBNull.Value });
                            cmd.Parameters.Add(new OdbcParameter("@Fecha", OdbcType.Date) { Value = mov.dCmp_fecha_movimiento }); // Usar Date en lugar de DateTime
                            cmd.Parameters.Add(new OdbcParameter("@Concepto", OdbcType.VarChar, 255) { Value = (object)mov.sCmp_concepto ?? DBNull.Value });
                            cmd.Parameters.Add(new OdbcParameter("@Monto", OdbcType.Decimal) { Value = mov.deCmp_valor_total });
                            cmd.Parameters.Add(new OdbcParameter("@TipoPago", OdbcType.Int) { Value = (object)mov.iFk_Id_tipo_pago ?? DBNull.Value });
                            cmd.Parameters.Add(new OdbcParameter("@CtaDes", OdbcType.Int) { Value = (object)mov.iFk_Id_cuenta_destino ?? DBNull.Value });
                            cmd.Parameters.Add(new OdbcParameter("@Benef", OdbcType.VarChar, 255) { Value = (object)mov.sCmp_beneficiario ?? DBNull.Value });
                            cmd.Parameters.Add(new OdbcParameter("@Estado", OdbcType.VarChar, 20) { Value = mov.sCmp_estado });

                            cmd.Parameters.Add(new OdbcParameter("@Conc", OdbcType.Int) { Value = mov.iCmp_conciliado });

                            cmd.Parameters.Add(new OdbcParameter("@Usuario", OdbcType.VarChar, 50) { Value = mov.sCmp_usuario_registro ?? "SISTEMA" });

                            int filasAfectadas = cmd.ExecuteNonQuery();
                            if (filasAfectadas == 0)
                                throw new Exception("No se pudo insertar el movimiento encabezado");

                            mov.iPk_Id_movimiento = iProximoIdMovimiento;
                        }

                        // ---- Insertar detalles ----
                        if (lst_Detalles.Count > 0)
                        {
                            // Siguiente ID de detalle
                            int iProximoIdDetalle;
                            string sSqlMaxDet = @"
                        SELECT COALESCE(MAX(Pk_Id_Detalle), 0) + 1 
                        FROM Tbl_MovimientoBancarioDetalle
                        WHERE Fk_Id_Movimiento = ? AND Fk_Id_CuentaOrigen = ? AND Fk_Id_Operacion = ?";

                            using (var cmdMaxDet = new OdbcCommand(sSqlMaxDet, odcn_Conn, trx))
                            {
                                cmdMaxDet.Parameters.Add(new OdbcParameter("@Mov", OdbcType.Int) { Value = mov.iPk_Id_movimiento });
                                cmdMaxDet.Parameters.Add(new OdbcParameter("@Ori", OdbcType.Int) { Value = mov.iFk_Id_cuenta_origen });
                                cmdMaxDet.Parameters.Add(new OdbcParameter("@Op", OdbcType.Int) { Value = mov.iFk_Id_operacion });

                                object result = cmdMaxDet.ExecuteScalar();
                                iProximoIdDetalle = Convert.ToInt32(result);
                                if (iProximoIdDetalle <= 0) iProximoIdDetalle = 1;
                            }

                            string sSqlDet = @"
                        INSERT INTO Tbl_MovimientoBancarioDetalle
                        (Fk_Id_Movimiento, Fk_Id_CuentaOrigen, Fk_Id_Operacion, Pk_Id_Detalle,
                         Fk_Id_CuentaContable, Cmp_TipoOperacion, Cmp_Valor, Cmp_Descripcion,
                         Cmp_OrdenDetalle, Cmp_UsuarioRegistro)
                        VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

                            int iOrden = 1;
                            foreach (var det in lst_Detalles)
                            {
                                using (var cmdDet = new OdbcCommand(sSqlDet, odcn_Conn, trx))
                                {
                                    // Sanitizar datos del detalle
                                    det.sCmp_Descripcion = fun_Trunc(det.sCmp_Descripcion, 255);

                                    // Asegurar valores por defecto
                                    string cuentaContable = string.IsNullOrWhiteSpace(det.sFk_Id_cuenta_contable) ? "1110" : det.sFk_Id_cuenta_contable;
                                    string tipoOperacion = string.IsNullOrWhiteSpace(det.sCmp_tipo_operacion) ? "C" : det.sCmp_tipo_operacion;

                                    cmdDet.Parameters.Add(new OdbcParameter("@Mov", OdbcType.Int) { Value = mov.iPk_Id_movimiento });
                                    cmdDet.Parameters.Add(new OdbcParameter("@Ori", OdbcType.Int) { Value = mov.iFk_Id_cuenta_origen });
                                    cmdDet.Parameters.Add(new OdbcParameter("@Op", OdbcType.Int) { Value = mov.iFk_Id_operacion });
                                    cmdDet.Parameters.Add(new OdbcParameter("@PkDet", OdbcType.Int) { Value = iProximoIdDetalle });

                                    cmdDet.Parameters.Add(new OdbcParameter("@Cuenta", OdbcType.VarChar, 20) { Value = cuentaContable });

                                    cmdDet.Parameters.Add(new OdbcParameter("@Tipo", OdbcType.Char, 1) { Value = tipoOperacion });
                                    cmdDet.Parameters.Add(new OdbcParameter("@Valor", OdbcType.Decimal) { Value = det.deCmp_valor });
                                    cmdDet.Parameters.Add(new OdbcParameter("@Desc", OdbcType.VarChar, 255) { Value = (object)det.sCmp_Descripcion ?? DBNull.Value });
                                    cmdDet.Parameters.Add(new OdbcParameter("@Orden", OdbcType.Int) { Value = iOrden });
                                    cmdDet.Parameters.Add(new OdbcParameter("@User", OdbcType.VarChar, 50) { Value = mov.sCmp_usuario_registro ?? "SISTEMA" });

                                    int filasDetalle = cmdDet.ExecuteNonQuery();
                                    if (filasDetalle == 0)
                                        throw new Exception($"No se pudo insertar el detalle en orden {iOrden}");
                                }

                                iProximoIdDetalle++;
                                iOrden++;
                            }
                        }

                        trx.Commit();
                        return mov.iPk_Id_movimiento;
                    }
                    catch (Exception ex)
                    {
                        trx.Rollback();
                        throw new Exception("Error al crear movimiento con detalles: " + ex.Message);
                    }
                }
            }
        }

        public List<string> fun_ObtenerEstadosMovimiento()
        {
            List<string> lst_Estados = new List<string>();

            try
            {
                string sSql = @"
                    SELECT DISTINCT Cmp_Estado 
                    FROM Tbl_MovimientoBancarioEncabezado 
                    WHERE Cmp_Estado IS NOT NULL 
                    ORDER BY Cmp_Estado";

                using (OdbcConnection odcn_Conn = cn.fun_ConexionBD())
                using (OdbcCommand odc_Cmd = new OdbcCommand(sSql, odcn_Conn))
                {
                    using (OdbcDataReader odr_Reader = odc_Cmd.ExecuteReader())
                    {
                        while (odr_Reader.Read())
                        {
                            string sEstado = odr_Reader.GetString(0);
                            if (!string.IsNullOrEmpty(sEstado))
                                lst_Estados.Add(sEstado);
                        }
                    }
                }
                // Si no hay estados, agregamos los básicos
                if (lst_Estados.Count == 0)
                {
                    lst_Estados.AddRange(new[] { "ACTIVO", "ANULADO", "PENDIENTE" });
                }
            }
            catch (Exception ex)
            {
                lst_Estados = new List<string> { "ACTIVO", "ANULADO", "PENDIENTE" };
                Console.WriteLine($"Error al obtener estados: {ex.Message}. Usando valores por defecto.");
            }

            return lst_Estados;
        }

        public DataTable fun_ObtenerDetallesContablesParaCaptura()
        {
            try
            {
                string sQuery = @"
                            SELECT 
                    mb.Pk_Id_Movimiento,
                    mb.Fk_Id_CuentaOrigen,
                    cb.Cmp_NumeroCuenta,
                    b.Cmp_NombreBanco,
                    mb.Fk_Id_Operacion,
                    tb.Cmp_NombreTransaccion AS Tipo_Operacion,
                    tb.Cmp_Efecto,
                    mb.Cmp_NumeroDocumento,
                    mb.Cmp_Fecha,
                    mb.Cmp_MontoTotal,
                    mb.Cmp_Beneficiario,
                    mb.Cmp_Conciliado,
                    mb.Cmp_Estado AS Estado_Movimiento,
                    mb.Cmp_UsuarioRegistro
                FROM Tbl_MovimientoBancarioEncabezado mb
                INNER JOIN Tbl_CuentasBancarias cb ON mb.Fk_Id_CuentaOrigen = cb.Pk_Id_CuentaBancaria
                INNER JOIN Tbl_Bancos b ON cb.Fk_Id_Banco = b.Pk_Id_Banco
                INNER JOIN Tbl_TransaccionesBancarias tb ON mb.Fk_Id_Operacion = tb.Pk_Id_Transaccion;";

                OdbcDataAdapter oda_Adapter = new OdbcDataAdapter(sQuery, cn.fun_ConexionBD());
                DataTable dts_Resultado = new DataTable();
                oda_Adapter.Fill(dts_Resultado);

                // DEBUG: Mostrar cuántos registros se obtienen
                Console.WriteLine($"Registros obtenidos: {dts_Resultado.Rows.Count}");

                return dts_Resultado;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener movimientos bancarios: " + ex.Message);
            }
        }

        public string fun_ObtenerCuentaContablePorDefecto()
        {
            try
            {
                string sSql = @"SELECT Cmp_Valor 
                       FROM Tbl_ParametrosCheques 
                       WHERE Cmp_Parametro = 'CUENTA_BANCO_PRINCIPAL' 
                       AND Cmp_Estado = 1";
                
                using (OdbcConnection odcn_Conn = new Cls_Conexion().fun_ConexionBD())
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

        public string fun_ObtenerTipoLineaPorSigno(string sSignoOperacion)
        {
            return sSignoOperacion == "-" ? "D" : "C";
        }

        public DataTable fun_ObtenerDetallesContables()
        {
            try
            {
                string sQuery = @"
                    SELECT 
                        mbd.Pk_Id_Detalle as ID_Detalle,
                        mbd.Fk_Id_Movimiento as ID_Movimiento,
                        mbd.Fk_Id_CuentaContable as Cuenta_Contable,
                        mbd.Cmp_TipoOperacion as Tipo_Linea,
                        mbd.Cmp_Valor as Valor,
                        mbe.Cmp_NumeroDocumento as Documento,
                        mbe.Cmp_Fecha as Fecha_Movimiento,
                        cc.Cmp_NombreCuenta as Nombre_Cuenta,
                        mbd.Cmp_Descripcion as Descripcion
                    FROM Tbl_MovimientoBancarioDetalle mbd
                    INNER JOIN Tbl_MovimientoBancarioEncabezado mbe ON 
                        mbd.Fk_Id_Movimiento = mbe.Pk_Id_Movimiento AND 
                        mbd.Fk_Id_CuentaOrigen = mbe.Fk_Id_CuentaOrigen AND 
                        mbd.Fk_Id_Operacion = mbe.Fk_Id_Operacion
                    INNER JOIN Tbl_CatalogoCuentas cc ON mbd.Fk_Id_CuentaContable = cc.Pk_Id_CuentaContable
                    ORDER BY mbd.Fk_Id_Movimiento DESC, mbd.Cmp_OrdenDetalle";

                OdbcDataAdapter oda_Adapter = new OdbcDataAdapter(sQuery, cn.fun_ConexionBD());
                DataTable dts_Resultado = new DataTable();
                oda_Adapter.Fill(dts_Resultado);
                return dts_Resultado;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener detalles contables: " + ex.Message);
            }
        }

        public DataTable fun_ObtenerCuentasContables()
        {
            try
            {
                string sSql = @"SELECT 
                            Pk_Id_CuentaContable, 
                            CONCAT(Pk_Id_CuentaContable, ' - ', Cmp_NombreCuenta) AS Cmp_NombreCompleto
                       FROM Tbl_CatalogoCuentas
                       WHERE Cmp_Estado = 1
                       ORDER BY Pk_Id_CuentaContable";

                OdbcDataAdapter oda_Adapter = new OdbcDataAdapter(sSql, cn.fun_ConexionBD());
                DataTable dts_Resultado = new DataTable();
                oda_Adapter.Fill(dts_Resultado);
                return dts_Resultado;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las cuentas contables: " + ex.Message);
            }
        }

        public DataTable fun_ObtenerMovimientosPorFiltro(int? iIdCuenta = null, DateTime? dFechaDesde = null, DateTime? dFechaHasta = null, string sEstado = null)
        {
            try
            {
                string sSql = @"
                    SELECT 
                        mbe.Pk_Id_Movimiento,
                        mbe.Fk_Id_CuentaOrigen,
                        mbe.Fk_Id_Operacion,
                        cb.Cmp_NumeroCuenta,
                        b.Cmp_NombreBanco,
                        tb.Cmp_NombreTransaccion,
                        mbe.Cmp_NumeroDocumento,
                        mbe.Cmp_Fecha,
                        mbe.Cmp_MontoTotal,
                        mbe.Cmp_Beneficiario,
                        mbe.Cmp_Estado,
                        mbe.Cmp_Conciliado
                    FROM Tbl_MovimientoBancarioEncabezado mbe
                    INNER JOIN Tbl_CuentasBancarias cb ON mbe.Fk_Id_CuentaOrigen = cb.Pk_Id_CuentaBancaria
                    INNER JOIN Tbl_Bancos b ON cb.Fk_Id_Banco = b.Pk_Id_Banco
                    INNER JOIN Tbl_TransaccionesBancarias tb ON mbe.Fk_Id_Operacion = tb.Pk_Id_Transaccion
                    WHERE 1=1";

                List<OdbcParameter> lst_Parametros = new List<OdbcParameter>();

                if (iIdCuenta.HasValue)
                {
                    sSql += " AND mbe.Fk_Id_CuentaOrigen = ?";
                    lst_Parametros.Add(new OdbcParameter("@Cuenta", iIdCuenta.Value));
                }

                if (dFechaDesde.HasValue)
                {
                    sSql += " AND mbe.Cmp_Fecha >= ?";
                    lst_Parametros.Add(new OdbcParameter("@FechaDesde", dFechaDesde.Value));
                }

                if (dFechaHasta.HasValue)
                {
                    sSql += " AND mbe.Cmp_Fecha <= ?";
                    lst_Parametros.Add(new OdbcParameter("@FechaHasta", dFechaHasta.Value));
                }

                if (!string.IsNullOrEmpty(sEstado))
                {
                    sSql += " AND mbe.Cmp_Estado = ?";
                    lst_Parametros.Add(new OdbcParameter("@Estado", sEstado));
                }

                sSql += " ORDER BY mbe.Cmp_Fecha DESC, mbe.Pk_Id_Movimiento DESC";

                OdbcDataAdapter oda_Adapter = new OdbcDataAdapter(sSql, cn.fun_ConexionBD());
                foreach (var param in lst_Parametros)
                {
                    oda_Adapter.SelectCommand.Parameters.Add(param);
                }

                DataTable dts_Resultado = new DataTable();
                oda_Adapter.Fill(dts_Resultado);
                return dts_Resultado;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener movimientos: " + ex.Message);
            }
        }

        public DataTable fun_ObtenerMovimientosCompletos(DateTime? desde = null, DateTime? hasta = null, string estado = null)
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

            var sql = sb.ToString();
            var pars = new List<OdbcParameter>();

            if (desde.HasValue) { sql += " AND Cmp_Fecha >= ?"; pars.Add(new OdbcParameter("", desde.Value)); }
            if (hasta.HasValue) { sql += " AND Cmp_Fecha <  DATE_ADD(?, INTERVAL 1 DAY)"; pars.Add(new OdbcParameter("", hasta.Value)); }
            if (!string.IsNullOrWhiteSpace(estado)) { sql += " AND Estado_Movimiento = ?"; pars.Add(new OdbcParameter("", estado)); }

            sql += " ORDER BY Cmp_Fecha DESC, Pk_Id_Movimiento DESC;";

            using (var da = new OdbcDataAdapter(sql, cn.fun_ConexionBD()))
            {
                foreach (var p in pars) da.SelectCommand.Parameters.Add(p);
                var dt = new DataTable();
                da.Fill(dt);

                // ⚠️ Renombramos una columna para que case con tu grid:
                // El grid quiere "Cmp_Num_Documento" (con guion bajo y D mayúscula).
                if (!dt.Columns.Contains("Cmp_Num_Documento") && dt.Columns.Contains("Cmp_NumeroDocumento"))
                    dt.Columns["Cmp_NumeroDocumento"].ColumnName = "Cmp_Num_Documento";

                // El grid tiene columna "Fk_Id_tipo_pago" (minúsculas en "pago")
                if (!dt.Columns.Contains("Fk_Id_tipo_pago") && dt.Columns.Contains("Fk_Id_TipoPago"))
                    dt.Columns["Fk_Id_TipoPago"].ColumnName = "Fk_Id_tipo_pago";

                return dt;
            }
        }



        public DataTable fun_ObtenerMovimientosView(DateTime? desde = null, DateTime? hasta = null, string estado = null)
        {
            var sb = new System.Text.StringBuilder();
            sb.AppendLine("SELECT * FROM Vw_MovimientosBancariosCompletos WHERE 1=1");

            var pars = new List<OdbcParameter>();

            if (desde.HasValue) { sb.AppendLine("AND Cmp_Fecha >= ?"); pars.Add(new OdbcParameter("", desde.Value)); }
            if (hasta.HasValue) { sb.AppendLine("AND Cmp_Fecha < DATE_ADD(?, INTERVAL 1 DAY)"); pars.Add(new OdbcParameter("", hasta.Value)); }
            if (!string.IsNullOrWhiteSpace(estado)) { sb.AppendLine("AND Estado_Movimiento = ?"); pars.Add(new OdbcParameter("", estado)); }

            sb.AppendLine("ORDER BY Cmp_Fecha DESC, Pk_Id_Movimiento DESC;");

            using (var da = new OdbcDataAdapter(sb.ToString(), cn.fun_ConexionBD()))
            {
                foreach (var p in pars) da.SelectCommand.Parameters.Add(p);

                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }



    }
}