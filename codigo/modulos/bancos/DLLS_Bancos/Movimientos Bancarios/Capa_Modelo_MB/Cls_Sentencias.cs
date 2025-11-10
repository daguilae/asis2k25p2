using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_MB
{
    public class Cls_Sentencias
    {
        // =============================
        // Encabezado (Tbl_MovimientoBancarioEncabezado)
        // =============================
        public int iPk_Id_movimiento { get; set; }
        public int iFk_Id_cuenta_origen { get; set; }
        public int iFk_Id_operacion { get; set; }
        public DateTime dCmp_fecha_movimiento { get; set; }
        public decimal deCmp_ValorTotal { get; set; }
        public int? iFk_Id_moneda { get; set; }
        public int? iFk_Id_cuenta_destino { get; set; }
        public int? iFk_Id_tipo_pago { get; set; }
        public int? iFk_Id_concepto { get; set; }

        public DateTime dCmp_FechaMovimiento { get; set; }
        public string sCmp_NumeroDocumento { get; set; }
        public string sCmp_Concepto { get; set; }
        public string sCmp_Beneficiario { get; set; }
        public string sCmp_Observaciones { get; set; }
        public int iCmp_Conciliado { get; set; }
        public string sCmp_Estado { get; set; }
        public string sCmp_UsuarioRegistro { get; set; }
        public string sCmp_numero_documento { get; set; }   // Cmp_NumeroDocumento
        public DateTime dCmp_fecha { get; set; }            // Cmp_Fecha
        public string sCmp_concepto { get; set; }           // Cmp_Concepto
        public decimal deCmp_monto_total { get; set; }      // Cmp_MontoTotal
        public string sFk_Id_cuenta_origen { get; set; }     // ej. "2110" o "1.1.01"
        public string sFk_Id_cuenta_destino { get; set; }    // opcional

        public string sCmp_beneficiario { get; set; }       // Cmp_Beneficiario

        public int iCmp_conciliado { get; set; }            // Cmp_Conciliado (0,1,2)
        public string sCmp_estado { get; set; }             // Cmp_Estado
        public string sCmp_usuario_registro { get; set; }   // Cmp_UsuarioRegistro

        // Internos de edición (si los usas para actualizar por PK compuesta)
        private bool bEditando { get; set; }
        private int iMovimientoEditandoId { get; set; }
        private int iCuentaOrigenEditando { get; set; }
        private int iOperacionEditando { get; set; }
        // Alias de compatibilidad para código antiguo:
        public decimal deCmp_valor_total
        {
            get => deCmp_ValorTotal;
            set => deCmp_ValorTotal = value;
        }
        public decimal deCmp_Valor { get; set; }
        public string sFk_Id_cuenta_contable { get; set; }
        public string sCmp_tipo_operacion { get; set; }

        public string sCmp_Descripcion { get; set; } = string.Empty; // descripción del detalle

        // =============================
        // Detalle contable (Tbl_MovimientoBancarioDetalle)
        // =============================
        public class Cls_MovimientoDetalle
        {
            // Clave compuesta (hereda del encabezado + PK detalle)
            public int iFk_Id_movimiento { get; set; }
            public int iFk_Id_cuenta_origen { get; set; }
            public int iFk_Id_operacion { get; set; }
            public int iPk_Id_detalle { get; set; }

            // Contables
            public string sFk_Id_cuenta_contable { get; set; }  // Fk_Id_CuentaContable (VARCHAR(20))
            public string sCmp_tipo_operacion { get; set; }      // 'D' / 'C'
            public decimal deCmp_Valor { get; set; }
            public string sCmp_descripcion { get; set; }         // Cmp_Descripcion
            public int iCmp_orden_detalle { get; set; }          // Cmp_OrdenDetalle (default 1)

            public decimal deCmp_valor
            {
                get => deCmp_Valor;
                set => deCmp_Valor = value;
            }

            public decimal deCmp_Monto
            {
                get => deCmp_Valor;
                set => deCmp_Valor = value;
            }

            public string sCmp_Descripcion { get; set; } = string.Empty;
            public int iCmp_Conciliado { get; set; } = 0;

            // Opcionales / legado (si los usas en algún otro lado)
            public int? iFk_Id_tipo_pago { get; set; }
            public string sCmp_Num_Documento { get; set; }
            // Auditoría 
            public string sCmp_usuario_registro { get; set; }    // Cmp_UsuarioRegistro
            public DateTime? dCmp_fecha_registro { get; set; }   // Cmp_FechaRegistro

            private readonly Cls_Conexion cn = new Cls_Conexion();

            public OdbcDataAdapter fun_llenar_tbl(string sTabla)
            {
                if (string.IsNullOrWhiteSpace(sTabla))
                    throw new ArgumentException("El nombre de la tabla no puede estar vacío.");

                if (sTabla.Equals("Tbl_Movimientos_Bancarios", StringComparison.OrdinalIgnoreCase))
                    sTabla = "Tbl_MovimientoBancarioEncabezado";
                if (sTabla.Equals("Tbl_Detalle_MovBancario", StringComparison.OrdinalIgnoreCase))
                    sTabla = "Tbl_MovimientoBancarioDetalle";

                string sSql;

                switch (sTabla)
                {
                    case "Tbl_MovimientoBancarioEncabezado":
                        sSql = @"
                                SELECT
                                    Pk_Id_Movimiento,
                                    Fk_Id_CuentaOrigen,
                                    Fk_Id_Operacion,
                                    Cmp_NumeroDocumento,
                                    Cmp_Fecha,
                                    Cmp_Concepto,
                                    Cmp_MontoTotal,
                                    Fk_Id_TipoPago,
                                    Fk_Id_CuentaDestino,
                                    Cmp_Beneficiario,
                                    Cmp_Conciliado,
                                    Cmp_Estado,
                                    Cmp_UsuarioRegistro,
                                    Fk_Id_Moneda
                                FROM Tbl_MovimientoBancarioEncabezado
                                ORDER BY Cmp_Fecha DESC, Pk_Id_Movimiento DESC;";
                        break;

                    case "Tbl_MovimientoBancarioDetalle":
                        sSql = @"
                                SELECT
                                    Fk_Id_Movimiento,
                                    Fk_Id_CuentaOrigen,
                                    Fk_Id_Operacion,
                                    Pk_Id_Detalle,
                                    Fk_Id_CuentaContable,
                                    Cmp_TipoOperacion,
                                    Cmp_Valor,
                                    Cmp_Descripcion,
                                    Cmp_OrdenDetalle,
                                    Cmp_UsuarioRegistro,
                                    Cmp_FechaRegistro
                                FROM Tbl_MovimientoBancarioDetalle
                                ORDER BY Fk_Id_Movimiento DESC, Pk_Id_Detalle ASC;";
                        break;

                    case "Vw_MovimientosBancariosCompletos":
                        sSql = @"
                                SELECT 
                                    Pk_Id_Movimiento,
                                    Fk_Id_CuentaOrigen,
                                    Cmp_NumeroCuenta,
                                    Cmp_NombreBanco,
                                    Nombre_Cuenta_Completo,
                                    Fk_Id_Operacion,
                                    Tipo_Operacion,
                                    Cmp_Efecto,
                                    Cmp_NumeroDocumento,
                                    Cmp_Fecha,
                                    Cmp_MontoTotal,
                                    Cmp_Beneficiario,
                                    Cmp_Concepto,
                                    Cmp_Conciliado,
                                    Estado_Movimiento,
                                    Cmp_UsuarioRegistro,
                                    Fk_Id_TipoPago,
                                    Nombre_Tipo_Pago,
                                    Debe,
                                    Haber,
                                    Tipo_Movimiento
                                FROM Vw_MovimientosBancariosCompletos
                                ORDER BY Cmp_Fecha DESC, Pk_Id_Movimiento DESC;";
                        break;

                    default:
                        throw new ArgumentException($"Tabla o vista '{sTabla}' no está permitida para consulta.");
                }

                return new OdbcDataAdapter(sSql, cn.fun_conexion_bd());
            }
        }
    }
}
