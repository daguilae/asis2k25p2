using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_MB
{
    public class Sentencias
    {
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
