using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_MB
{
    public class Sentencias
    {
        // ENCABEZADO
        public int Pk_Id_movimiento { get; set; }
        public int Fk_Id_cuenta_origen { get; set; }
        public int? Fk_Id_cuenta_destino { get; set; }
        public int Fk_Id_operacion { get; set; }
        public int? Fk_Id_concepto { get; set; }
        public string Cmp_concepto { get; set; }   
        public DateTime Cmp_fecha_movimiento { get; set; }
        public string Cmp_numero_documento { get; set; }
        public decimal Cmp_valor_total { get; set; }
        public string Cmp_observaciones { get; set; }
        public int Cmp_conciliado { get; set; }
        public string Cmp_estado { get; set; }  // 'Activo','Anulado','Pendiente','Trasladado'
        public string TipoLinea { get; set; } // "D" o "H"
        public bool EsDebe { get; set; }
        public bool EsHaber { get; set; }

        public class OpcionCombo
        {
            public string Texto { get; set; }
            public int Valor { get; set; }
        }

        // DETALLE (para usar en listas)
        public class MovimientoDetalle
        {
            public int Pk_Id_detalleMB { get; set; }
            public int Fk_Id_movimiento { get; set; }
            public int? Fk_Id_tipo_pago { get; set; }
            public string Cmp_Num_Documento { get; set; }
            public decimal Cmp_Monto { get; set; }
            public string Cmp_Descripcion { get; set; }
            public int Cmp_Conciliado { get; set; }
        }

        public class MovimientoDetalleContable {}
        private readonly Conexion con = new Conexion();

        public OdbcDataAdapter llenarTbl(string tabla)
        {
            if (string.IsNullOrWhiteSpace(tabla))
                throw new ArgumentException("El nombre de la tabla no puede estar vacío.");
            string sql;
            switch (tabla)
            {
                case "Tbl_Movimientos_Bancarios":
                    sql = @"SELECT 
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
                    sql = @"SELECT 
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
                    throw new ArgumentException($"Tabla '{tabla}' no está permitida para consulta.");
            }
            return new OdbcDataAdapter(sql, con.ConexionBD());
        }
    }
}
