using System;
using System.Data;
using System.Data.Odbc;
using System.Collections.Generic;
using System.Text;

namespace Capa_Modelo_MB
{
    public class Cls_CRUD
    {
        private readonly Cls_Conexion oCn = new Cls_Conexion();

        private string fun_trunc(string sCadena, int iMaxLongitud)
        {
            if (string.IsNullOrWhiteSpace(sCadena)) return null;
            return sCadena.Length <= iMaxLongitud ? sCadena : sCadena.Substring(0, iMaxLongitud);
        }

        // ===========================
        // CREAR MOVIMIENTO + DETALLES
        // ===========================
        public int fun_crear_movimiento_con_detalles(
           Cls_Sentencias mov,
           List<Cls_Sentencias.Cls_MovimientoDetalle> lst_Detalles)
        {
            if (mov == null) throw new ArgumentNullException(nameof(mov));
            if (lst_Detalles == null) lst_Detalles = new List<Cls_Sentencias.Cls_MovimientoDetalle>();

            // VALIDACIONES
            if (mov.iFk_Id_cuenta_origen <= 0)
                throw new Exception("La cuenta origen es requerida");
            if (mov.iFk_Id_operacion <= 0)
                throw new Exception("La operación es requerida");

            // Normalizar textos
            mov.sCmp_numero_documento = fun_trunc(mov.sCmp_numero_documento, 50);
            mov.sCmp_concepto = fun_trunc(mov.sCmp_concepto, 255);
            mov.sCmp_beneficiario = fun_trunc(mov.sCmp_beneficiario, 255);
            mov.sCmp_estado = fun_trunc(string.IsNullOrWhiteSpace(mov.sCmp_estado) ? "ACTIVO" : mov.sCmp_estado, 20);

            using (var cn = oCn.fun_conexion_bd())
            {
                if (cn.State != ConnectionState.Open) cn.Open();
                using (var tx = cn.BeginTransaction())
                {
                    try
                    {
                        // Signo de la operación
                        string signo = fun_obtener_signo_operacion(mov.iFk_Id_operacion, cn, tx);
                        decimal factor = (signo == "+") ? 1m : -1m;

                        // Consecutivo por (cuenta/operación)
                        int pkMov = fun_obtener_proximo_id_movimiento(mov.iFk_Id_cuenta_origen, mov.iFk_Id_operacion, cn, tx);

                        // Actualizar saldos de la cuenta bancaria (tabla Tbl_CuentasBancarias)
                        fun_actualizar_saldo_cuenta(mov.iFk_Id_cuenta_origen, mov.deCmp_valor_total * factor, cn, tx);

                        // Si hay cuenta destino bancaria, aplícala en positivo
                        if (mov.iFk_Id_cuenta_destino.HasValue && mov.iFk_Id_cuenta_destino.Value > 0)
                            fun_actualizar_saldo_cuenta(mov.iFk_Id_cuenta_destino.Value, mov.deCmp_valor_total, cn, tx);

                        // Insertar encabezado 
                        const string sqlEnc = @"
                                        INSERT INTO Tbl_MovimientoBancarioEncabezado
                                        (Pk_Id_Movimiento, Fk_Id_CuentaOrigen, Fk_Id_Operacion,
                                         Cmp_NumeroDocumento, Cmp_Fecha, Cmp_Concepto, Cmp_MontoTotal,
                                         Fk_Id_TipoPago, Fk_Id_CuentaDestino, Cmp_Beneficiario, Cmp_Estado,
                                         Cmp_Conciliado, Cmp_UsuarioRegistro, Fk_Id_Moneda)
                                        VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
                        using (var cmd = new OdbcCommand(sqlEnc, cn, tx))
                        {
                            cmd.Parameters.AddWithValue("@Pk", pkMov);
                            cmd.Parameters.AddWithValue("@Ori", mov.iFk_Id_cuenta_origen);
                            cmd.Parameters.AddWithValue("@Op", mov.iFk_Id_operacion);
                            cmd.Parameters.AddWithValue("@NumDoc", (object)mov.sCmp_numero_documento ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@Fecha", mov.dCmp_fecha_movimiento);  // <— usa el nombre que ya llenas
                            cmd.Parameters.AddWithValue("@Con", (object)mov.sCmp_concepto ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@Monto", mov.deCmp_valor_total);       // <— usa el nombre que ya llenas
                            cmd.Parameters.AddWithValue("@TP", (object)mov.iFk_Id_tipo_pago ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@Des", (object)mov.iFk_Id_cuenta_destino ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@Ben", (object)mov.sCmp_beneficiario ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@Est", mov.sCmp_estado ?? "ACTIVO");
                            cmd.Parameters.AddWithValue("@Conci", mov.iCmp_conciliado);
                            cmd.Parameters.AddWithValue("@Usr", mov.sCmp_usuario_registro ?? "SISTEMA");
                            cmd.Parameters.AddWithValue("@Mon", (object)mov.iFk_Id_moneda ?? DBNull.Value);

                            if (cmd.ExecuteNonQuery() == 0)
                                throw new Exception("No se pudo insertar el movimiento encabezado");

                            mov.iPk_Id_movimiento = pkMov;
                        }
                        // Detalles (coincidir NOMBRES de propiedades con tu botón)
                        if (lst_Detalles.Count == 0)
                        {
                            // usa la cuenta por defecto del parámetro y el mismo monto
                            fun_crear_detalle_automatico_COMPAT(mov, signo, cn, tx);
                        }
                        else
                        {
                            fun_insertar_detalles_movimiento_COMPAT(mov, lst_Detalles, cn, tx);
                        }

                        tx.Commit();
                        return mov.iPk_Id_movimiento;
                    }
                    catch (Exception ex)
                    {
                        tx.Rollback();
                        throw new Exception("Error al crear movimiento con detalles: " + ex.Message);
                    }
                }
            }
        }

        private void fun_crear_detalle_automatico_COMPAT(Cls_Sentencias mov, string signo, OdbcConnection cn, OdbcTransaction tx)
        {
            string cuentaContable = fun_obtener_cuenta_contable_por_defecto();
            string tipoLinea = (signo == "+") ? "D" : "C";

            int idDet = fun_obtener_proximo_id_detalle(mov.iPk_Id_movimiento, mov.iFk_Id_cuenta_origen, mov.iFk_Id_operacion, cn, tx);

            const string sql = @"
                            INSERT INTO Tbl_MovimientoBancarioDetalle
                            (Fk_Id_Movimiento, Fk_Id_CuentaOrigen, Fk_Id_Operacion, Pk_Id_Detalle,
                             Fk_Id_CuentaContable, Cmp_TipoOperacion, Cmp_Valor, Cmp_Descripcion,
                             Cmp_OrdenDetalle, Cmp_UsuarioRegistro)
                            VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

            using (var cmd = new OdbcCommand(sql, cn, tx))
            {
                cmd.Parameters.AddWithValue("@Mov", mov.iPk_Id_movimiento);
                cmd.Parameters.AddWithValue("@Ori", mov.iFk_Id_cuenta_origen);
                cmd.Parameters.AddWithValue("@Op", mov.iFk_Id_operacion);
                cmd.Parameters.AddWithValue("@PkDet", idDet);
                cmd.Parameters.AddWithValue("@Cta", cuentaContable);
                cmd.Parameters.AddWithValue("@Tipo", tipoLinea);
                cmd.Parameters.AddWithValue("@Val", mov.deCmp_valor_total);
                cmd.Parameters.AddWithValue("@Desc", (object)mov.sCmp_concepto ?? "Movimiento bancario");
                cmd.Parameters.AddWithValue("@Ord", 1);
                cmd.Parameters.AddWithValue("@Usr", mov.sCmp_usuario_registro ?? "SISTEMA");

                if (cmd.ExecuteNonQuery() == 0)
                    throw new Exception("No se pudo insertar el detalle automático");
            }
        }

        private void fun_insertar_detalles_movimiento_COMPAT(
            Cls_Sentencias mov, List<Cls_Sentencias.Cls_MovimientoDetalle> dets,
            OdbcConnection cn, OdbcTransaction tx)
        {
            int idDet = fun_obtener_proximo_id_detalle(mov.iPk_Id_movimiento, mov.iFk_Id_cuenta_origen, mov.iFk_Id_operacion, cn, tx);

            const string sql = @"
                        INSERT INTO Tbl_MovimientoBancarioDetalle
                        (Fk_Id_Movimiento, Fk_Id_CuentaOrigen, Fk_Id_Operacion, Pk_Id_Detalle,
                         Fk_Id_CuentaContable, Cmp_TipoOperacion, Cmp_Valor, Cmp_Descripcion,
                         Cmp_OrdenDetalle, Cmp_UsuarioRegistro)
                        VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

            int orden = 1;
            foreach (var d in dets)
            {
                using (var cmd = new OdbcCommand(sql, cn, tx))
                {
                    string cta = string.IsNullOrWhiteSpace(d.sFk_Id_cuenta_contable) ? fun_obtener_cuenta_contable_por_defecto() : d.sFk_Id_cuenta_contable;
                    string tipo = string.IsNullOrWhiteSpace(d.sCmp_tipo_operacion) ? "C" : d.sCmp_tipo_operacion;

                    cmd.Parameters.AddWithValue("@Mov", mov.iPk_Id_movimiento);
                    cmd.Parameters.AddWithValue("@Ori", mov.iFk_Id_cuenta_origen);
                    cmd.Parameters.AddWithValue("@Op", mov.iFk_Id_operacion);
                    cmd.Parameters.AddWithValue("@PkDet", idDet);
                    cmd.Parameters.AddWithValue("@Cta", cta);
                    cmd.Parameters.AddWithValue("@Tipo", tipo);
                    cmd.Parameters.AddWithValue("@Val", d.deCmp_valor);
                    cmd.Parameters.AddWithValue("@Desc", (object)d.sCmp_Descripcion ?? DBNull.Value); // <—
                    cmd.Parameters.AddWithValue("@Ord", orden);
                    cmd.Parameters.AddWithValue("@Usr", mov.sCmp_usuario_registro ?? "SISTEMA");

                    if (cmd.ExecuteNonQuery() == 0)
                        throw new Exception($"No se pudo insertar el detalle en orden {orden}");
                }
                idDet++;
                orden++;
            }
        }

        private string fun_obtener_signo_operacion(int iIdOperacion, OdbcConnection connection, OdbcTransaction transaction)
        {
            string sSql = @"SELECT Cmp_Efecto 
                            FROM Tbl_TransaccionesBancarias 
                            WHERE Pk_Id_Transaccion = ? AND Cmp_Estado = 1";
            using (var cmd = new OdbcCommand(sSql, connection, transaction))
            {
                cmd.Parameters.AddWithValue("@id", iIdOperacion);
                object resultado = cmd.ExecuteScalar();
                return resultado?.ToString() == "POSITIVO" ? "+" : "-";
            }
        }

        // Próximo PK del movimiento por cuenta-origen y operación
        private int fun_obtener_proximo_id_movimiento(int iIdCuenta, int iIdOperacion, OdbcConnection connection, OdbcTransaction transaction)
        {
            string sSql = @"SELECT COALESCE(MAX(Pk_Id_Movimiento), 0) + 1 
                            FROM Tbl_MovimientoBancarioEncabezado 
                            WHERE Fk_Id_CuentaOrigen = ? AND Fk_Id_Operacion = ?";
            using (var cmd = new OdbcCommand(sSql, connection, transaction))
            {
                cmd.Parameters.AddWithValue("@cta", iIdCuenta);
                cmd.Parameters.AddWithValue("@op", iIdOperacion);
                object result = cmd.ExecuteScalar();
                return Convert.ToInt32(result);
            }
        }

        // Actualizar saldos en cuenta bancaria
        private void fun_actualizar_saldo_cuenta(int iIdCuenta, decimal deMonto, OdbcConnection connection, OdbcTransaction transaction)
        {
            string sSql = @"UPDATE Tbl_CuentasBancarias 
                            SET Cmp_SaldoDisponible = Cmp_SaldoDisponible + ?,
                                Cmp_SaldoContable   = Cmp_SaldoContable   + ?
                            WHERE Pk_Id_CuentaBancaria = ?";
            using (var cmd = new OdbcCommand(sSql, connection, transaction))
            {
                cmd.Parameters.AddWithValue("@monto1", deMonto);
                cmd.Parameters.AddWithValue("@monto2", deMonto);
                cmd.Parameters.AddWithValue("@id", iIdCuenta);

                int filasAfectadas = cmd.ExecuteNonQuery();
                if (filasAfectadas == 0)
                    throw new Exception($"No se pudo actualizar el saldo de la cuenta {iIdCuenta}");
            }
        }

        // Insertar encabezado en Tbl_MovimientoBancarioEncabezado
        private void fun_insertar_encabezado_movimiento(Cls_Sentencias mov, int iIdMovimiento, OdbcConnection connection, OdbcTransaction transaction)
        {
            string sSql = @"
                    INSERT INTO Tbl_MovimientoBancarioEncabezado
                    (Pk_Id_Movimiento, Fk_Id_CuentaOrigen, Fk_Id_Operacion,
                     Cmp_NumeroDocumento, Cmp_Fecha, Cmp_Concepto, Cmp_MontoTotal,
                     Fk_Id_TipoPago, Fk_Id_CuentaDestino, Cmp_Beneficiario, Cmp_Estado,
                     Cmp_Conciliado, Cmp_UsuarioRegistro, Fk_Id_Moneda)
                    VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
            using (var cmd = new OdbcCommand(sSql, connection, transaction))
            {
                cmd.Parameters.Add(new OdbcParameter("@Pk", OdbcType.Int) { Value = iIdMovimiento });
                cmd.Parameters.Add(new OdbcParameter("@CtaOri", OdbcType.Int) { Value = mov.iFk_Id_cuenta_origen });
                cmd.Parameters.Add(new OdbcParameter("@Op", OdbcType.Int) { Value = mov.iFk_Id_operacion });
                cmd.Parameters.Add(new OdbcParameter("@NumDoc", OdbcType.VarChar, 50) { Value = (object)mov.sCmp_numero_documento ?? DBNull.Value });
                cmd.Parameters.Add(new OdbcParameter("@Fecha", OdbcType.Date) { Value = mov.dCmp_fecha });
                cmd.Parameters.Add(new OdbcParameter("@Concepto", OdbcType.VarChar, 255) { Value = (object)mov.sCmp_concepto ?? DBNull.Value });
                cmd.Parameters.Add(new OdbcParameter("@Monto", OdbcType.Decimal) { Value = mov.deCmp_monto_total });
                cmd.Parameters.Add(new OdbcParameter("@TipoPago", OdbcType.Int) { Value = (object)mov.iFk_Id_tipo_pago ?? DBNull.Value });
                cmd.Parameters.Add(new OdbcParameter("@CtaDes", OdbcType.Int) { Value = (object)mov.iFk_Id_cuenta_destino ?? DBNull.Value });
                cmd.Parameters.Add(new OdbcParameter("@Benef", OdbcType.VarChar, 255) { Value = (object)mov.sCmp_beneficiario ?? DBNull.Value });
                cmd.Parameters.Add(new OdbcParameter("@Estado", OdbcType.VarChar, 20) { Value = mov.sCmp_estado });
                cmd.Parameters.Add(new OdbcParameter("@Conc", OdbcType.Int) { Value = mov.iCmp_conciliado });
                cmd.Parameters.Add(new OdbcParameter("@Usuario", OdbcType.VarChar, 50) { Value = mov.sCmp_usuario_registro ?? "SISTEMA" });
                cmd.Parameters.Add(new OdbcParameter("@Moneda", OdbcType.Int) { Value = (object)mov.iFk_Id_moneda ?? DBNull.Value });

                int filasAfectadas = cmd.ExecuteNonQuery();
                if (filasAfectadas == 0)
                    throw new Exception("No se pudo insertar el movimiento encabezado");

                mov.iPk_Id_movimiento = iIdMovimiento;
            }
        }

        // ===========================
        // Parámetro cuenta por defecto
        // ===========================
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

                using (OdbcConnection odcn_Conn = new Cls_Conexion().fun_conexion_bd())
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

        // ===========================
        // Detalle automático si no se envían detalles
        // ===========================
        private void fun_crear_detalle_automatico(Cls_Sentencias mov, string sSignoOperacion, OdbcConnection connection, OdbcTransaction transaction)
        {
            // Cuenta por defecto desde parámetros
            string sCuentaContable = fun_obtener_cuenta_contable_por_defecto();
            // D para positivo, C para negativo 
            string sTipoLinea = sSignoOperacion == "+" ? "D" : "C";

            int iProximoIdDetalle = fun_obtener_proximo_id_detalle(mov.iPk_Id_movimiento, mov.iFk_Id_cuenta_origen, mov.iFk_Id_operacion, connection, transaction);

            string sSql = @"
                        INSERT INTO Tbl_MovimientoBancarioDetalle
                        (Fk_Id_Movimiento, Fk_Id_CuentaOrigen, Fk_Id_Operacion, Pk_Id_Detalle,
                         Fk_Id_CuentaContable, Cmp_TipoOperacion, Cmp_Valor, Cmp_Descripcion,
                         Cmp_OrdenDetalle, Cmp_UsuarioRegistro)
                        VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

            using (var cmd = new OdbcCommand(sSql, connection, transaction))
            {
                cmd.Parameters.Add(new OdbcParameter("@Mov", OdbcType.Int) { Value = mov.iPk_Id_movimiento });
                cmd.Parameters.Add(new OdbcParameter("@Ori", OdbcType.Int) { Value = mov.iFk_Id_cuenta_origen });
                cmd.Parameters.Add(new OdbcParameter("@Op", OdbcType.Int) { Value = mov.iFk_Id_operacion });
                cmd.Parameters.Add(new OdbcParameter("@PkDet", OdbcType.Int) { Value = iProximoIdDetalle });
                cmd.Parameters.Add(new OdbcParameter("@Cuenta", OdbcType.VarChar, 20) { Value = sCuentaContable });
                cmd.Parameters.Add(new OdbcParameter("@Tipo", OdbcType.Char, 1) { Value = sTipoLinea });
                cmd.Parameters.Add(new OdbcParameter("@Valor", OdbcType.Decimal) { Value = mov.deCmp_monto_total });
                cmd.Parameters.Add(new OdbcParameter("@Desc", OdbcType.VarChar, 255) { Value = (object)mov.sCmp_concepto ?? "Movimiento bancario" });
                cmd.Parameters.Add(new OdbcParameter("@Orden", OdbcType.Int) { Value = 1 });
                cmd.Parameters.Add(new OdbcParameter("@User", OdbcType.VarChar, 50) { Value = mov.sCmp_usuario_registro ?? "SISTEMA" });

                int filasDetalle = cmd.ExecuteNonQuery();
                if (filasDetalle == 0)
                    throw new Exception("No se pudo insertar el detalle automático");
            }
        }

        // Insertar lista de detalles
        private void fun_insertar_detalles_movimiento(Cls_Sentencias mov, List<Cls_Sentencias.Cls_MovimientoDetalle> lst_Detalles, OdbcConnection connection, OdbcTransaction transaction)
        {
            int iProximoIdDetalle = fun_obtener_proximo_id_detalle(mov.iPk_Id_movimiento, mov.iFk_Id_cuenta_origen, mov.iFk_Id_operacion, connection, transaction);

            string sSql = @"
                        INSERT INTO Tbl_MovimientoBancarioDetalle
                        (Fk_Id_Movimiento, Fk_Id_CuentaOrigen, Fk_Id_Operacion, Pk_Id_Detalle,
                         Fk_Id_CuentaContable, Cmp_TipoOperacion, Cmp_Valor, Cmp_Descripcion,
                         Cmp_OrdenDetalle, Cmp_UsuarioRegistro)
                        VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

            int iOrden = 1;
            foreach (var det in lst_Detalles)
            {
                using (var cmdDet = new OdbcCommand(sSql, connection, transaction))
                {
                    // Sanitizar/por defecto
                    det.sCmp_descripcion = fun_trunc(det.sCmp_descripcion, 255);
                    string cuentaContable = string.IsNullOrWhiteSpace(det.sFk_Id_cuenta_contable)
                        ? fun_obtener_cuenta_contable_por_defecto()
                        : det.sFk_Id_cuenta_contable;
                    string tipoOperacion = string.IsNullOrWhiteSpace(det.sCmp_tipo_operacion) ? "C" : det.sCmp_tipo_operacion;

                    cmdDet.Parameters.Add(new OdbcParameter("@Mov", OdbcType.Int) { Value = mov.iPk_Id_movimiento });
                    cmdDet.Parameters.Add(new OdbcParameter("@Ori", OdbcType.Int) { Value = mov.iFk_Id_cuenta_origen });
                    cmdDet.Parameters.Add(new OdbcParameter("@Op", OdbcType.Int) { Value = mov.iFk_Id_operacion });
                    cmdDet.Parameters.Add(new OdbcParameter("@PkDet", OdbcType.Int) { Value = iProximoIdDetalle });
                    cmdDet.Parameters.Add(new OdbcParameter("@Cuenta", OdbcType.VarChar, 20) { Value = cuentaContable });
                    cmdDet.Parameters.Add(new OdbcParameter("@Tipo", OdbcType.Char, 1) { Value = tipoOperacion });
                    cmdDet.Parameters.Add(new OdbcParameter("@Valor", OdbcType.Decimal) { Value = det.deCmp_valor });
                    cmdDet.Parameters.Add(new OdbcParameter("@Desc", OdbcType.VarChar, 255) { Value = (object)det.sCmp_descripcion ?? DBNull.Value });
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

        // Próximo PK del detalle por movimiento (PK compuesta)
        private int fun_obtener_proximo_id_detalle(int iIdMovimiento, int iIdCuentaOrigen, int iIdOperacion, OdbcConnection connection, OdbcTransaction transaction)
        {
            string sSql = @"
                        SELECT COALESCE(MAX(Pk_Id_Detalle), 0) + 1 
                        FROM Tbl_MovimientoBancarioDetalle
                        WHERE Fk_Id_Movimiento = ? AND Fk_Id_CuentaOrigen = ? AND Fk_Id_Operacion = ?";
            using (var cmd = new OdbcCommand(sSql, connection, transaction))
            {
                cmd.Parameters.Add(new OdbcParameter("@Mov", OdbcType.Int) { Value = iIdMovimiento });
                cmd.Parameters.Add(new OdbcParameter("@Ori", OdbcType.Int) { Value = iIdCuentaOrigen });
                cmd.Parameters.Add(new OdbcParameter("@Op", OdbcType.Int) { Value = iIdOperacion });

                object result = cmd.ExecuteScalar();
                return Convert.ToInt32(result);
            }
        }

        // Tipo de línea contable según signo
        public string fun_obtener_tipo_linea_por_signo(string sSignoOperacion)
        {
            return sSignoOperacion == "-" ? "D" : "C";
        }

        // ===========================
        // BÚSQUEDA POR FILTROS
        // ===========================
        public DataTable fun_obtener_movimientos_por_filtro(int? iIdCuenta = null, DateTime? dFechaDesde = null, DateTime? dFechaHasta = null, string sEstado = null)
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
                        mbe.Cmp_Concepto,
                        mbe.Cmp_Estado,
                        mbe.Cmp_Conciliado
                    FROM Tbl_MovimientoBancarioEncabezado mbe
                    INNER JOIN Tbl_CuentasBancarias cb ON mbe.Fk_Id_CuentaOrigen = cb.Pk_Id_CuentaBancaria
                    INNER JOIN Tbl_Bancos b           ON cb.Fk_Id_Banco       = b.Pk_Id_Banco
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

                using (var da = new OdbcDataAdapter(sSql, oCn.fun_conexion_bd()))
                {
                    foreach (var p in lst_Parametros) da.SelectCommand.Parameters.Add(p);
                    var dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener movimientos: " + ex.Message);
            }
        }

        // ===========================
        // ANULAR 
        // ===========================
        public bool fun_anular_movimiento(int iIdMovimiento, int iIdCuentaOrigen, int iIdOperacion, string sUsuario)
        {
            using (var odcn_Conn = oCn.fun_conexion_bd())
            {
                if (odcn_Conn.State != ConnectionState.Open)
                    odcn_Conn.Open();

                using (var trx = odcn_Conn.BeginTransaction())
                {
                    try
                    {
                        // Leer datos para reverso
                        string sSqlSelect = @"
                            SELECT Cmp_MontoTotal, Fk_Id_Operacion, Fk_Id_CuentaDestino 
                            FROM Tbl_MovimientoBancarioEncabezado 
                            WHERE Pk_Id_Movimiento = ? 
                              AND Fk_Id_CuentaOrigen = ? 
                              AND Fk_Id_Operacion = ? 
                              AND Cmp_Estado = 'ACTIVO'";

                        decimal deMontoTotal = 0m;
                        int iIdOperacionActual = 0;
                        int? iIdCuentaDestino = null;

                        using (var cmdSelect = new OdbcCommand(sSqlSelect, odcn_Conn, trx))
                        {
                            cmdSelect.Parameters.AddWithValue("@Mov", iIdMovimiento);
                            cmdSelect.Parameters.AddWithValue("@CtaOri", iIdCuentaOrigen);
                            cmdSelect.Parameters.AddWithValue("@Op", iIdOperacion);
                            using (var reader = cmdSelect.ExecuteReader())
                            {
                                if (!reader.Read())
                                    throw new Exception("Movimiento no encontrado o ya está anulado");

                                deMontoTotal = reader.GetDecimal(0);
                                iIdOperacionActual = reader.GetInt32(1);
                                if (!reader.IsDBNull(2)) iIdCuentaDestino = reader.GetInt32(2);
                            }
                        }

                        // Reversar saldos
                        string sSigno = fun_obtener_signo_operacion(iIdOperacionActual, odcn_Conn, trx);
                        decimal deFactor = sSigno == "+" ? -1m : 1m; // invertido para reverso

                        fun_actualizar_saldo_cuenta(iIdCuentaOrigen, deMontoTotal * deFactor, odcn_Conn, trx);

                        if (iIdCuentaDestino.HasValue && iIdCuentaDestino > 0)
                            fun_actualizar_saldo_cuenta(iIdCuentaDestino.Value, deMontoTotal * (deFactor * -1m), odcn_Conn, trx);

                        // Marcar como ANULADO
                        string sSqlUpdate = @"
                            UPDATE Tbl_MovimientoBancarioEncabezado 
                            SET Cmp_Estado = 'ANULADO',
                                Cmp_UsuarioModifico = ?,
                                Cmp_FechaModificacion = NOW()
                            WHERE Pk_Id_Movimiento = ? 
                              AND Fk_Id_CuentaOrigen = ? 
                              AND Fk_Id_Operacion = ?";

                        using (var cmdUpdate = new OdbcCommand(sSqlUpdate, odcn_Conn, trx))
                        {
                            cmdUpdate.Parameters.AddWithValue("@Usuario", sUsuario);
                            cmdUpdate.Parameters.AddWithValue("@Mov", iIdMovimiento);
                            cmdUpdate.Parameters.AddWithValue("@CtaOri", iIdCuentaOrigen);
                            cmdUpdate.Parameters.AddWithValue("@Op", iIdOperacion);

                            int filasAfectadas = cmdUpdate.ExecuteNonQuery();
                            if (filasAfectadas == 0)
                                throw new Exception("No se pudo anular el movimiento");
                        }

                        trx.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trx.Rollback();
                        throw new Exception("Error al anular movimiento: " + ex.Message);
                    }
                }
            }
        }

        // ===========================
        // ELIMINAR
        // ===========================
        public bool fun_eliminar_movimiento_fisico(int iIdMovimiento, int iIdCuentaOrigen, int iIdOperacion)
        {
            using (var odcn_Conn = oCn.fun_conexion_bd())
            {
                if (odcn_Conn.State != ConnectionState.Open)
                    odcn_Conn.Open();

                using (var trx = odcn_Conn.BeginTransaction())
                {
                    try
                    {
                        string sSqlSelect = @"
                                        SELECT Cmp_MontoTotal, Fk_Id_Operacion, Fk_Id_CuentaDestino 
                                        FROM Tbl_MovimientoBancarioEncabezado 
                                        WHERE Pk_Id_Movimiento = ? 
                                          AND Fk_Id_CuentaOrigen = ? 
                                          AND Fk_Id_Operacion = ?";

                        decimal deMontoTotal = 0m;
                        int iIdOperacionActual = 0;
                        int? iIdCuentaDestino = null;

                        using (var cmdSelect = new OdbcCommand(sSqlSelect, odcn_Conn, trx))
                        {
                            cmdSelect.Parameters.AddWithValue("@Mov", iIdMovimiento);
                            cmdSelect.Parameters.AddWithValue("@CtaOri", iIdCuentaOrigen);
                            cmdSelect.Parameters.AddWithValue("@Op", iIdOperacion);

                            using (var reader = cmdSelect.ExecuteReader())
                            {
                                if (!reader.Read())
                                    throw new Exception("Movimiento no encontrado");

                                deMontoTotal = reader.GetDecimal(0);
                                iIdOperacionActual = reader.GetInt32(1);
                                if (!reader.IsDBNull(2))
                                    iIdCuentaDestino = reader.GetInt32(2);
                            }
                        }

                        string sSigno = fun_obtener_signo_operacion(iIdOperacionActual, odcn_Conn, trx);
                        decimal deFactor = sSigno == "+" ? -1m : 1m;

                        fun_actualizar_saldo_cuenta(iIdCuentaOrigen, deMontoTotal * deFactor, odcn_Conn, trx);
                        if (iIdCuentaDestino.HasValue && iIdCuentaDestino > 0)
                            fun_actualizar_saldo_cuenta(iIdCuentaDestino.Value, deMontoTotal * (deFactor * -1m), odcn_Conn, trx);

                        string sSqlDeleteDetalles = @"
                                                DELETE FROM Tbl_MovimientoBancarioDetalle 
                                                WHERE Fk_Id_Movimiento = ? 
                                                  AND Fk_Id_CuentaOrigen = ? 
                                                  AND Fk_Id_Operacion = ?";
                        using (var cmdDetalles = new OdbcCommand(sSqlDeleteDetalles, odcn_Conn, trx))
                        {
                            cmdDetalles.Parameters.AddWithValue("@Mov", iIdMovimiento);
                            cmdDetalles.Parameters.AddWithValue("@CtaOri", iIdCuentaOrigen);
                            cmdDetalles.Parameters.AddWithValue("@Op", iIdOperacion);
                            cmdDetalles.ExecuteNonQuery();
                        }

                        string sSqlDeleteEncabezado = @"
                                                    DELETE FROM Tbl_MovimientoBancarioEncabezado 
                                                    WHERE Pk_Id_Movimiento = ? 
                                                      AND Fk_Id_CuentaOrigen = ? 
                                                      AND Fk_Id_Operacion = ?";
                        using (var cmdEncabezado = new OdbcCommand(sSqlDeleteEncabezado, odcn_Conn, trx))
                        {
                            cmdEncabezado.Parameters.AddWithValue("@Mov", iIdMovimiento);
                            cmdEncabezado.Parameters.AddWithValue("@CtaOri", iIdCuentaOrigen);
                            cmdEncabezado.Parameters.AddWithValue("@Op", iIdOperacion);

                            int filasAfectadas = cmdEncabezado.ExecuteNonQuery();
                            if (filasAfectadas == 0)
                                throw new Exception("No se pudo eliminar el movimiento");
                        }
                        trx.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trx.Rollback();
                        throw new Exception("Error al eliminar movimiento: " + ex.Message);
                    }
                }
            }
        }

        // ===========================
        // EDITAR con reverso de saldos
        // ===========================
        public bool fun_actualizar_movimiento(
            int iIdMovimiento,
            int iNuevaCuentaOrigen,
            int iNuevaOperacion,
            string sNumeroDocumento,
            DateTime dFecha,
            string sConcepto,
            decimal deMontoNuevo,
            int? iTipoPago,
            int? iCuentaDestinoNueva,
            string sBeneficiario,
            string sUsuario,
            int iCuentaOrigenOriginal,
            int iOperacionOriginal,
            string sEstado,
            int iConciliado)
        {
            using (var odcn_Conn = oCn.fun_conexion_bd())
            {
                if (odcn_Conn.State != ConnectionState.Open)
                    odcn_Conn.Open();

                using (var trx = odcn_Conn.BeginTransaction())
                {
                    try
                    {
                        string sSqlSelect = @"
                                        SELECT Cmp_MontoTotal, Fk_Id_CuentaDestino, Cmp_Estado
                                        FROM Tbl_MovimientoBancarioEncabezado
                                        WHERE Pk_Id_Movimiento = ?
                                          AND Fk_Id_CuentaOrigen = ?
                                          AND Fk_Id_Operacion = ?";

                        decimal deMontoViejo = 0m;
                        int? iCuentaDestinoVieja = null;
                        string sEstadoActual = "";

                        using (var cmdSel = new OdbcCommand(sSqlSelect, odcn_Conn, trx))
                        {
                            cmdSel.Parameters.AddWithValue("@Mov", iIdMovimiento);
                            cmdSel.Parameters.AddWithValue("@CtaOriOld", iCuentaOrigenOriginal);
                            cmdSel.Parameters.AddWithValue("@OpOld", iOperacionOriginal);

                            using (var rd = cmdSel.ExecuteReader())
                            {
                                if (!rd.Read())
                                    throw new Exception("Movimiento no encontrado.");

                                deMontoViejo = rd.GetDecimal(0);
                                if (!rd.IsDBNull(1)) iCuentaDestinoVieja = rd.GetInt32(1);
                                sEstadoActual = rd.GetString(2);
                            }
                        }

                        if (sEstadoActual == "ANULADO" && sEstado != "ANULADO")
                            throw new Exception("No se puede modificar un movimiento ANULADO.");

                        string sSignoViejo = fun_obtener_signo_operacion(iOperacionOriginal, odcn_Conn, trx);
                        string sSignoNuevo = fun_obtener_signo_operacion(iNuevaOperacion, odcn_Conn, trx);

                        decimal factorViejo = (sSignoViejo == "+") ? 1m : -1m;
                        decimal factorNuevo = (sSignoNuevo == "+") ? 1m : -1m;

                        if (sEstadoActual == "ACTIVO")
                        {
                            // Reversar saldo de cuenta origen vieja
                            fun_actualizar_saldo_cuenta(iCuentaOrigenOriginal, deMontoViejo * (-factorViejo), odcn_Conn, trx);

                            // Reversar destino viejo, si aplica
                            if (iCuentaDestinoVieja.HasValue && iCuentaDestinoVieja > 0)
                                fun_actualizar_saldo_cuenta(iCuentaDestinoVieja.Value, -deMontoViejo, odcn_Conn, trx);

                            // Aplicar nuevos saldos si el nuevo estado es ACTIVO
                            if ((sEstado ?? "ACTIVO") == "ACTIVO")
                            {
                                fun_actualizar_saldo_cuenta(iNuevaCuentaOrigen, deMontoNuevo * factorNuevo, odcn_Conn, trx);

                                if (iCuentaDestinoNueva.HasValue && iCuentaDestinoNueva > 0)
                                    fun_actualizar_saldo_cuenta(iCuentaDestinoNueva.Value, deMontoNuevo, odcn_Conn, trx);
                            }
                        }

                        string sSqlUpdateEncabezado = @"
                                                UPDATE Tbl_MovimientoBancarioEncabezado 
                                                SET Cmp_NumeroDocumento = ?,
                                                    Cmp_Fecha = ?,
                                                    Cmp_Concepto = ?,
                                                    Cmp_MontoTotal = ?,
                                                    Fk_Id_TipoPago = ?,
                                                    Fk_Id_CuentaDestino = ?,
                                                    Cmp_Beneficiario = ?,
                                                    Fk_Id_CuentaOrigen = ?,      
                                                    Fk_Id_Operacion = ?,       
                                                    Cmp_Estado = ?, 
                                                    Cmp_Conciliado = ?, 
                                                    Cmp_UsuarioModifico = ?,
                                                    Cmp_FechaModificacion = NOW()
                                                WHERE Pk_Id_Movimiento = ?
                                                  AND Fk_Id_CuentaOrigen = ?
                                                  AND Fk_Id_Operacion = ?";

                        using (var cmdUpd = new OdbcCommand(sSqlUpdateEncabezado, odcn_Conn, trx))
                        {
                            cmdUpd.Parameters.AddWithValue("@NumDoc", (object)sNumeroDocumento ?? DBNull.Value);
                            cmdUpd.Parameters.AddWithValue("@Fecha", dFecha);
                            cmdUpd.Parameters.AddWithValue("@Concepto", (object)sConcepto ?? DBNull.Value);
                            cmdUpd.Parameters.AddWithValue("@Monto", deMontoNuevo);
                            cmdUpd.Parameters.AddWithValue("@TipoPago", (object)iTipoPago ?? DBNull.Value);
                            cmdUpd.Parameters.AddWithValue("@CtaDes", (object)iCuentaDestinoNueva ?? DBNull.Value);
                            cmdUpd.Parameters.AddWithValue("@Benef", (object)sBeneficiario ?? DBNull.Value);
                            cmdUpd.Parameters.AddWithValue("@CtaOriNueva", iNuevaCuentaOrigen);
                            cmdUpd.Parameters.AddWithValue("@OpNueva", iNuevaOperacion);
                            cmdUpd.Parameters.AddWithValue("@Estado", sEstado ?? "ACTIVO");
                            cmdUpd.Parameters.AddWithValue("@Conciliado", iConciliado);
                            cmdUpd.Parameters.AddWithValue("@Usuario", sUsuario);
                            cmdUpd.Parameters.AddWithValue("@Mov", iIdMovimiento);
                            cmdUpd.Parameters.AddWithValue("@CtaOriOld", iCuentaOrigenOriginal);
                            cmdUpd.Parameters.AddWithValue("@OpOld", iOperacionOriginal);

                            int n = cmdUpd.ExecuteNonQuery();
                            if (n == 0)
                                throw new Exception("No se encontró el movimiento para actualizar (encabezado).");
                        }

                        string sSqlUpdateDetalles = @"
                                                UPDATE Tbl_MovimientoBancarioDetalle 
                                                SET Fk_Id_CuentaOrigen = ?, 
                                                    Fk_Id_Operacion = ?
                                                WHERE Fk_Id_Movimiento = ? 
                                                  AND Fk_Id_CuentaOrigen = ? 
                                                  AND Fk_Id_Operacion = ?";

                        using (var cmdUpdateDetalles = new OdbcCommand(sSqlUpdateDetalles, odcn_Conn, trx))
                        {
                            cmdUpdateDetalles.Parameters.AddWithValue("@CtaOriNueva", iNuevaCuentaOrigen);
                            cmdUpdateDetalles.Parameters.AddWithValue("@OpNueva", iNuevaOperacion);
                            cmdUpdateDetalles.Parameters.AddWithValue("@Mov", iIdMovimiento);
                            cmdUpdateDetalles.Parameters.AddWithValue("@CtaOriOld", iCuentaOrigenOriginal);
                            cmdUpdateDetalles.Parameters.AddWithValue("@OpOld", iOperacionOriginal);
                            cmdUpdateDetalles.ExecuteNonQuery();
                        }

                        trx.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trx.Rollback();
                        throw new Exception("Error al actualizar movimiento (con saldos): " + ex.Message);
                    }
                }
            }
        }


        // Actualiza CARGO/ABONO y recalcula SALDO en Tbl_Catalogo_Cuentas
        private void fun_actualizar_saldo_catalogo(string sCodigoCuenta, decimal deMonto, string sTipoLinea,
                                                   OdbcConnection connection, OdbcTransaction transaction)
        {

            string s1 = @"
                        UPDATE Tbl_Catalogo_Cuentas
                        SET 
                            Cmp_CtaCargoActual = Cmp_CtaCargoActual + (CASE WHEN ? = 'D' THEN ? ELSE 0 END),
                            Cmp_CtaAbonoActual = Cmp_CtaAbonoActual + (CASE WHEN ? = 'C' THEN ? ELSE 0 END)
                        WHERE Pk_Codigo_Cuenta = ?";
            using (var cmd1 = new OdbcCommand(s1, connection, transaction))
            {
                cmd1.Parameters.AddWithValue("@tipo1", sTipoLinea);
                cmd1.Parameters.AddWithValue("@monto1", deMonto);
                cmd1.Parameters.AddWithValue("@tipo2", sTipoLinea);
                cmd1.Parameters.AddWithValue("@monto2", deMonto);
                cmd1.Parameters.AddWithValue("@cod", sCodigoCuenta);
                int n = cmd1.ExecuteNonQuery();
                if (n == 0)
                    throw new Exception($"No se pudo actualizar el cargo/abono de la cuenta {sCodigoCuenta}");
            }

            string s2 = @"
                        UPDATE Tbl_Catalogo_Cuentas
                        SET Cmp_CtaSaldoActual =
                            CASE 
                              WHEN Cmp_CtaNaturaleza = 1 THEN Cmp_CtaSaldoInicial + Cmp_CtaCargoActual - Cmp_CtaAbonoActual
                              ELSE                            Cmp_CtaSaldoInicial - Cmp_CtaCargoActual + Cmp_CtaAbonoActual
                            END
                        WHERE Pk_Codigo_Cuenta = ?";
            using (var cmd2 = new OdbcCommand(s2, connection, transaction))
            {
                cmd2.Parameters.AddWithValue("@cod", sCodigoCuenta);
                cmd2.ExecuteNonQuery();
            }
        }
    }
}