using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_MB
{
    public class Cls_Sentencias
    {
        // ENCABEZADO CON PREFIJOS
        public int iPk_Id_movimiento { get; set; }
        public int iFk_Id_cuenta_origen { get; set; }
        public int iFk_Id_operacion { get; set; }
        public int? iFk_Id_cuenta_destino { get; set; }
        public int? iFk_Id_tipo_pago { get; set; }
        public int? iFk_Id_concepto { get; set; }
        public DateTime dCmp_fecha_movimiento { get; set; }
        public string sCmp_numero_documento { get; set; }
        public string sCmp_concepto { get; set; }
        public decimal deCmp_valor_total { get; set; }
        public string sCmp_beneficiario { get; set; }
        public string sCmp_observaciones { get; set; }
        public int iCmp_conciliado { get; set; }
        public string sCmp_estado { get; set; }
        public string sCmp_usuario_registro { get; set; }
        private bool bEditando { get; set; }
        private int iMovimientoEditandoId { get; set; }
        private int iCuentaOrigenEditando { get; set; }
        private int iOperacionEditando { get; set; }



        // Clase para el detalle del movimiento (detalle contable)
        public class Cls_MovimientoDetalle
        {
            public string sFk_Id_cuenta_contable { get; set; }
            public string sCmp_tipo_operacion { get; set; } // 'D' para Débito, 'C' para Crédito
            public decimal deCmp_valor { get; set; }
            public string sCmp_Descripcion { get; set; }
            public int iCmp_Conciliado { get; set; }

            // Campos opcionales para compatibilidad
            public int? iFk_Id_tipo_pago { get; set; }
            public string sCmp_Num_Documento { get; set; }
            public decimal deCmp_Monto { get; set; }

            public class Cls_MovimientoDetalleContable { }

            private readonly Cls_Conexion cn = new Cls_Conexion();

            public OdbcDataAdapter fun_llenar_tbl(string sTabla)
            {
                if (string.IsNullOrWhiteSpace(sTabla))
                    throw new ArgumentException("El nombre de la tabla no puede estar vacío.");

                string sSql;
                switch (sTabla)
                {
                    case "Tbl_Movimientos_Bancarios":
                        sSql = @"SELECT 
                        Pk_Id_movimiento, 
                        Fk_Id_cuenta_origen, 
                        Fk_Id_cuenta_destino,
                        Fk_Id_operacion, 
                        Fk_Id_concepto, 
                        Cmp_fecha_movimiento, 
                        Cmp_valor_total,
                        Cmp_observaciones, 
                        Cmp_conciliado, 
                        Cmp_estado
                    FROM Tbl_Movimientos_Bancarios";
                        break;

                    case "Tbl_Detalle_MovBancario":
                        sSql = @"SELECT 
                        Pk_Id_detalleMB, 
                        Fk_Id_movimiento, 
                        Fk_Id_tipo_pago, 
                        Cmp_Num_Documento, 
                        Cmp_Monto, 
                        Cmp_Descripcion, 
                        Cmp_Conciliado
                    FROM Tbl_Detalle_MovBancario";
                        break;
                    default:
                        throw new ArgumentException($"Tabla '{sTabla}' no está permitida para consulta.");
                }
                return new OdbcDataAdapter(sSql, cn.fun_conexion_bd());
            }
        }
    }
}
