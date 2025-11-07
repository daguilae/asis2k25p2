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


        //crear movimeintos
        public int fun_crear_movimiento_con_detalles(
            Cls_Sentencias mov,
            List<Cls_Sentencias.Cls_MovimientoDetalle> lst_Detalles)
        {
            if (mov == null) throw new ArgumentNullException(nameof(mov));
            if (lst_Detalles == null)
                lst_Detalles = new List<Cls_Sentencias.Cls_MovimientoDetalle>();

            // Validaciones básicas
            if (mov.iFk_Id_cuenta_origen <= 0)
                throw new Exception("La cuenta origen es requerida");
            if (mov.iFk_Id_operacion <= 0)
                throw new Exception("La operación es requerida");

            // Normalizar datos
            mov.sCmp_numero_documento = fun_trunc(mov.sCmp_numero_documento, 50);
            mov.sCmp_concepto = fun_trunc(mov.sCmp_concepto, 255);
            mov.sCmp_beneficiario = fun_trunc(mov.sCmp_beneficiario, 255);
            mov.sCmp_estado = fun_trunc(string.IsNullOrWhiteSpace(mov.sCmp_estado) ? "ACTIVO" : mov.sCmp_estado, 20);

            using (var odcn_Conn = oCn.fun_conexion_bd())
            {
                if (odcn_Conn.State != ConnectionState.Open)
                    odcn_Conn.Open();

                using (var trx = odcn_Conn.BeginTransaction())
                {
                    try
                    {
                        // OBTENER SIGNO DE LA OPERACIÓN
                        string sSignoOperacion = fun_obtener_signo_operacion(mov.iFk_Id_operacion, odcn_Conn, trx);
                        decimal deFactor = sSignoOperacion == "+" ? 1 : -1;

                        //  OBTENER PRÓXIMO ID DE MOVIMIENTO
                        int iProximoIdMovimiento = fun_obtener_proximo_id_movimiento(mov.iFk_Id_cuenta_origen, mov.iFk_Id_operacion, odcn_Conn, trx);

                        // ACTUALIZAR SALDO DE LA CUENTA ORIGEN
                        fun_actualizar_saldo_cuenta(mov.iFk_Id_cuenta_origen, mov.deCmp_valor_total * deFactor, odcn_Conn, trx);

                        // SI HAY CUENTA DESTINO, ACTUALIZAR SU SALDO TAMBIÉN
                        if (mov.iFk_Id_cuenta_destino.HasValue && mov.iFk_Id_cuenta_destino > 0)
                        {
                            // Para transferencias, el destino recibe el monto positivo
                            fun_actualizar_saldo_cuenta(mov.iFk_Id_cuenta_destino.Value, mov.deCmp_valor_total, odcn_Conn, trx);
                        }

                        //  INSERTAR ENCABEZADO DEL MOVIMIENTO
                        fun_insertar_encabezado_movimiento(mov, iProximoIdMovimiento, odcn_Conn, trx);

                        // INSERTAR DETALLES CONTABLES
                        if (lst_Detalles.Count > 0)
                        {
                            fun_insertar_detalles_movimiento(mov, lst_Detalles, odcn_Conn, trx);
                        }
                        else
                        {
                            // INSERTAR DETALLE AUTOMÁTICO SI NO HAY DETALLES EXPLÍCITOS
                            fun_crear_detalle_automatico(mov, sSignoOperacion, odcn_Conn, trx);
                        }

                        trx.Commit();
                        return iProximoIdMovimiento;
                    }
                    catch (Exception ex)
                    {
                        trx.Rollback();
                        throw new Exception("Error al crear movimiento con detalles: " + ex.Message);
                    }
                }
            }
        }


        // Método para obtener el signo de la operación
        private string fun_obtener_signo_operacion(int iIdOperacion, OdbcConnection connection, OdbcTransaction transaction)
        {
            string sSql = @"SELECT Cmp_Efecto FROM Tbl_TransaccionesBancarias 
                   WHERE Pk_Id_Transaccion = ? AND Cmp_Estado = 1";

            using (var cmd = new OdbcCommand(sSql, connection, transaction))
            {
                cmd.Parameters.AddWithValue("@id", iIdOperacion);
                object resultado = cmd.ExecuteScalar();
                return resultado?.ToString() == "POSITIVO" ? "+" : "-";
            }
        }

        // Método para obtener próximo ID de movimiento
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

        // Actualizar saldo de cuenta
        private void fun_actualizar_saldo_cuenta(int iIdCuenta, decimal deMonto, OdbcConnection connection, OdbcTransaction transaction)
        {
            string sSql = @"UPDATE Tbl_CuentasBancarias 
                   SET Cmp_SaldoDisponible = Cmp_SaldoDisponible + ?,
                       Cmp_SaldoContable = Cmp_SaldoContable + ?
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

        // Método para insertar encabezado
        private void fun_insertar_encabezado_movimiento(Cls_Sentencias mov, int iIdMovimiento, OdbcConnection connection, OdbcTransaction transaction)
        {
            string sSql = @"
                        INSERT INTO Tbl_MovimientoBancarioEncabezado
                        (Pk_Id_Movimiento, Fk_Id_CuentaOrigen, Fk_Id_Operacion,
                         Cmp_NumeroDocumento, Cmp_Fecha, Cmp_Concepto, Cmp_MontoTotal,
                         Fk_Id_TipoPago, Fk_Id_CuentaDestino, Cmp_Beneficiario, Cmp_Estado,
                         Cmp_Conciliado, Cmp_UsuarioRegistro,  Fk_Id_Moneda)
                        VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?,?)";

            using (var cmd = new OdbcCommand(sSql, connection, transaction))
            {
                cmd.Parameters.Add(new OdbcParameter("@Pk", OdbcType.Int) { Value = iIdMovimiento });
                cmd.Parameters.Add(new OdbcParameter("@CtaOri", OdbcType.Int) { Value = mov.iFk_Id_cuenta_origen });
                cmd.Parameters.Add(new OdbcParameter("@Op", OdbcType.Int) { Value = mov.iFk_Id_operacion });
                cmd.Parameters.Add(new OdbcParameter("@NumDoc", OdbcType.VarChar, 50) { Value = (object)mov.sCmp_numero_documento ?? DBNull.Value });
                cmd.Parameters.Add(new OdbcParameter("@Fecha", OdbcType.Date) { Value = mov.dCmp_fecha_movimiento });
                cmd.Parameters.Add(new OdbcParameter("@Concepto", OdbcType.VarChar, 255) { Value = (object)mov.sCmp_concepto ?? DBNull.Value });
                cmd.Parameters.Add(new OdbcParameter("@Monto", OdbcType.Decimal) { Value = mov.deCmp_valor_total });
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


        public string fun_obtener_cuenta_contable_por_defecto()
        {
            try
            {
                string sSql = @"SELECT Cmp_Valor 
                       FROM Tbl_ParametrosCheques 
                       WHERE Cmp_Parametro = 'CUENTA_BANCO_PRINCIPAL' 
                       AND Cmp_Estado = 1";

                using (OdbcConnection odcn_Conn = new Cls_Conexion().fun_conexion_bd())
                using (OdbcCommand odc_Cmd = new OdbcCommand(sSql, odcn_Conn))
                {
                    object oResultado = odc_Cmd.ExecuteScalar();
                    return oResultado != null ? oResultado.ToString() : "1110"; // Si no encuentra, retorna "1110" como cuenta por defecto
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener cuenta contable por defecto: {ex.Message}");
                return "1110"; // En caso de error, retorna "1110"
            }
        }

        // Método para crear detalle automático
        private void fun_crear_detalle_automatico(Cls_Sentencias mov, string sSignoOperacion, OdbcConnection connection, OdbcTransaction transaction)
        {
            // Obtener cuenta contable por defecto
            string sCuentaContable = fun_obtener_cuenta_contable_por_defecto();
            string sTipoLinea = sSignoOperacion == "+" ? "D" : "C"; // Débito para positivo, Crédito para negativo

            // Obtener próximo ID de detalle
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
                cmd.Parameters.Add(new OdbcParameter("@Valor", OdbcType.Decimal) { Value = mov.deCmp_valor_total });
                cmd.Parameters.Add(new OdbcParameter("@Desc", OdbcType.VarChar, 255) { Value = (object)mov.sCmp_concepto ?? "Movimiento bancario" });
                cmd.Parameters.Add(new OdbcParameter("@Orden", OdbcType.Int) { Value = 1 });
                cmd.Parameters.Add(new OdbcParameter("@User", OdbcType.VarChar, 50) { Value = mov.sCmp_usuario_registro ?? "SISTEMA" });

                int filasDetalle = cmd.ExecuteNonQuery();
                if (filasDetalle == 0)
                    throw new Exception("No se pudo insertar el detalle automático");
            }
        }

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
                    // Sanitizar datos del detalle
                    det.sCmp_Descripcion = fun_trunc(det.sCmp_Descripcion, 255);

                    // Asegurar valores por defecto
                    string cuentaContable = string.IsNullOrWhiteSpace(det.sFk_Id_cuenta_contable) ?
                        fun_obtener_cuenta_contable_por_defecto() : det.sFk_Id_cuenta_contable;
                    string tipoOperacion = string.IsNullOrWhiteSpace(det.sCmp_tipo_operacion) ?
                        "C" : det.sCmp_tipo_operacion;

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

        public string fun_obtener_tipo_linea_por_signo(string sSignoOperacion)
        {
            return sSignoOperacion == "-" ? "D" : "C";
        }

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

                OdbcDataAdapter oda_Adapter = new OdbcDataAdapter(sSql, oCn.fun_conexion_bd());
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


        // eliminar
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
                        // Obtener datos del movimiento antes de anular
                        string sSqlSelect = @"SELECT Cmp_MontoTotal, Fk_Id_Operacion, Fk_Id_CuentaDestino 
                                     FROM Tbl_MovimientoBancarioEncabezado 
                                     WHERE Pk_Id_Movimiento = ? 
                                     AND Fk_Id_CuentaOrigen = ? 
                                     AND Fk_Id_Operacion = ? 
                                     AND Cmp_Estado = 'ACTIVO'";

                        decimal deMontoTotal = 0;
                        int iIdOperacionActual = 0;
                        int? iIdCuentaDestino = null;

                        using (var cmdSelect = new OdbcCommand(sSqlSelect, odcn_Conn, trx))
                        {
                            cmdSelect.Parameters.AddWithValue("@Mov", iIdMovimiento);
                            cmdSelect.Parameters.AddWithValue("@CtaOri", iIdCuentaOrigen);
                            cmdSelect.Parameters.AddWithValue("@Op", iIdOperacion);

                            using (var reader = cmdSelect.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    deMontoTotal = reader.GetDecimal(0);
                                    iIdOperacionActual = reader.GetInt32(1);
                                    if (!reader.IsDBNull(2))
                                        iIdCuentaDestino = reader.GetInt32(2);
                                }
                                else
                                {
                                    throw new Exception("Movimiento no encontrado o ya está anulado");
                                }
                            }
                        }

                        // Obtener signo de la operación para reversar
                        string sSigno = fun_obtener_signo_operacion(iIdOperacionActual, odcn_Conn, trx);
                        decimal deFactor = sSigno == "+" ? -1 : 1; // Invertir para reversar

                        // Reversar saldo de la cuenta origen
                        fun_actualizar_saldo_cuenta(iIdCuentaOrigen, deMontoTotal * deFactor, odcn_Conn, trx);

                        // Si hay cuenta destino, reversar su saldo también
                        if (iIdCuentaDestino.HasValue && iIdCuentaDestino > 0)
                        {
                            // Para transferencias, el destino se afecta en sentido contrario
                            fun_actualizar_saldo_cuenta(iIdCuentaDestino.Value, deMontoTotal * (deFactor * -1), odcn_Conn, trx);
                        }

                        // Actualizar estado a ANULADO
                        string sSqlUpdate = @"UPDATE Tbl_MovimientoBancarioEncabezado 
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
                        // Primero obtener datos para reversar saldos
                        string sSqlSelect = @"SELECT Cmp_MontoTotal, Fk_Id_Operacion, Fk_Id_CuentaDestino 
                                     FROM Tbl_MovimientoBancarioEncabezado 
                                     WHERE Pk_Id_Movimiento = ? 
                                     AND Fk_Id_CuentaOrigen = ? 
                                     AND Fk_Id_Operacion = ?";

                        decimal deMontoTotal = 0;
                        int iIdOperacionActual = 0;
                        int? iIdCuentaDestino = null;

                        using (var cmdSelect = new OdbcCommand(sSqlSelect, odcn_Conn, trx))
                        {
                            cmdSelect.Parameters.AddWithValue("@Mov", iIdMovimiento);
                            cmdSelect.Parameters.AddWithValue("@CtaOri", iIdCuentaOrigen);
                            cmdSelect.Parameters.AddWithValue("@Op", iIdOperacion);

                            using (var reader = cmdSelect.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    deMontoTotal = reader.GetDecimal(0);
                                    iIdOperacionActual = reader.GetInt32(1);
                                    if (!reader.IsDBNull(2))
                                        iIdCuentaDestino = reader.GetInt32(2);
                                }
                                else
                                {
                                    throw new Exception("Movimiento no encontrado");
                                }
                            }
                        }

                        // Reversar saldos
                        string sSigno = fun_obtener_signo_operacion(iIdOperacionActual, odcn_Conn, trx);
                        decimal deFactor = sSigno == "+" ? -1 : 1;
                        fun_actualizar_saldo_cuenta(iIdCuentaOrigen, deMontoTotal * deFactor, odcn_Conn, trx);

                        if (iIdCuentaDestino.HasValue && iIdCuentaDestino > 0)
                        {
                            fun_actualizar_saldo_cuenta(iIdCuentaDestino.Value, deMontoTotal * (deFactor * -1), odcn_Conn, trx);
                        }

                        // Eliminar detalles primero (por la FK)
                        string sSqlDeleteDetalles = @"DELETE FROM Tbl_MovimientoBancarioDetalle 
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

                        // Eliminar encabezado
                        string sSqlDeleteEncabezado = @"DELETE FROM Tbl_MovimientoBancarioEncabezado 
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

        // ===========================================================
        // ==================== EDITAR ===============================
        // ==========================================================

        // Método simple para actualizar movimiento
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
            string sEstado)
        {
            using (var odcn_Conn = oCn.fun_conexion_bd())
            {
                if (odcn_Conn.State != ConnectionState.Open)
                    odcn_Conn.Open();

                using (var trx = odcn_Conn.BeginTransaction())
                {
                    try
                    {
                        // Leer estado actual 
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
                                if (!rd.IsDBNull(1))
                                    iCuentaDestinoVieja = rd.GetInt32(1);
                                sEstadoActual = rd.GetString(2); // Obtener estado actual
                            }
                        }

                        // Validar que no se intente modificar un movimiento ANULADO
                        if (sEstadoActual == "ANULADO" && sEstado != "ANULADO")
                        {
                            throw new Exception("No se puede modificar un movimiento ANULADO.");
                        }

                        // Obtener signos para reversar y aplicar (código existente)
                        string sSignoViejo = fun_obtener_signo_operacion(iOperacionOriginal, odcn_Conn, trx);
                        string sSignoNuevo = fun_obtener_signo_operacion(iNuevaOperacion, odcn_Conn, trx);

                        decimal factorViejo = (sSignoViejo == "+") ? 1m : -1m;
                        decimal factorNuevo = (sSignoNuevo == "+") ? 1m : -1m;

                        // Solo actualizar saldos si el movimiento está ACTIVO
                        if (sEstadoActual == "ACTIVO")
                        {
                            // Reversar saldo de la cuenta origen vieja
                            fun_actualizar_saldo_cuenta(iCuentaOrigenOriginal, deMontoViejo * (-factorViejo), odcn_Conn, trx);

                            // Si hay cuenta destino vieja, reversar su saldo también
                            if (iCuentaDestinoVieja.HasValue && iCuentaDestinoVieja > 0)
                            {
                                fun_actualizar_saldo_cuenta(iCuentaDestinoVieja.Value, -deMontoViejo, odcn_Conn, trx);
                            }

                            // Aplicar nuevos saldos solo si el nuevo estado es ACTIVO
                            if (sEstado == "ACTIVO")
                            {
                                // Origen con signo nuevo
                                fun_actualizar_saldo_cuenta(iNuevaCuentaOrigen, deMontoNuevo * factorNuevo, odcn_Conn, trx);

                                // Destino nuevo
                                if (iCuentaDestinoNueva.HasValue && iCuentaDestinoNueva > 0)
                                {
                                    fun_actualizar_saldo_cuenta(iCuentaDestinoNueva.Value, deMontoNuevo, odcn_Conn, trx);
                                }
                            }
                        }

                        // Actualizar ENCABEZADO
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
                            cmdUpd.Parameters.AddWithValue("@Usuario", sUsuario);
                            cmdUpd.Parameters.AddWithValue("@Mov", iIdMovimiento);
                            cmdUpd.Parameters.AddWithValue("@CtaOriOld", iCuentaOrigenOriginal);
                            cmdUpd.Parameters.AddWithValue("@OpOld", iOperacionOriginal);

                            int n = cmdUpd.ExecuteNonQuery();
                            if (n == 0)
                                throw new Exception("No se encontró el movimiento para actualizar (encabezado).");
                        }

                        // ACTUALIZAR DETALLES para que apunten a la nueva cuenta origen y operación
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
    }
}
