using System;
using System.Collections.Generic;
using System.Data.Odbc;

namespace Capa_Modelo_Poliza
{
    public class Cls_DAO_Poliza
    {
        private readonly Cls_Conexion conexion = new Cls_Conexion();

        // Obtener todos los bancos
        public OdbcDataReader ObtenerBancos()
        {
            string sql = "SELECT Pk_Id_Banco, Cmp_NombreBanco FROM Tbl_Bancos WHERE Cmp_Estado = 1;";
            OdbcConnection con = conexion.AbrirConexion();
            OdbcCommand cmd = new OdbcCommand(sql, con);
            return cmd.ExecuteReader(); // la vista debe cerrar la conexión después de usarlo
        }

        // Obtener las cuentas según el banco seleccionado
        public OdbcDataReader ObtenerCuentasPorBanco(int idBanco)
        {
            string sql = "SELECT Pk_Id_CuentaBancaria, Cmp_NumeroCuenta FROM Tbl_CuentasBancarias WHERE Fk_Id_Banco = ? AND Cmp_Estado = 1;";
            OdbcConnection con = conexion.AbrirConexion();
            OdbcCommand cmd = new OdbcCommand(sql, con);
            cmd.Parameters.AddWithValue("@idBanco", idBanco);
            return cmd.ExecuteReader();
        }

        // Obtener documentos según cuenta seleccionada
        public OdbcDataReader ObtenerDocumentosPorCuenta(int idCuenta)
        {
            string sql = "SELECT Pk_Id_Movimiento, Cmp_NumeroDocumento FROM Tbl_MovimientoBancarioEncabezado WHERE Fk_Id_CuentaOrigen = ?;";
            OdbcConnection con = conexion.AbrirConexion();
            OdbcCommand cmd = new OdbcCommand(sql, con);
            cmd.Parameters.AddWithValue("@idCuenta", idCuenta);
            return cmd.ExecuteReader();
        }

        // Obtener el siguiente ID disponible para una fecha específica
        public int ObtenerSiguienteIdEncabezado(DateTime fecha)
        {
            int nuevoId = 1;
            string sql = "SELECT IFNULL(MAX(Pk_EncCodigo_Poliza), 0) + 1 FROM Tbl_EncabezadoPoliza WHERE Pk_Fecha_Poliza = ?;";
            using (OdbcConnection con = conexion.AbrirConexion())
            {
                OdbcCommand cmd = new OdbcCommand(sql, con);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                var result = cmd.ExecuteScalar();
                if (result != null)
                    nuevoId = Convert.ToInt32(result);
            }
            return nuevoId;
        }

        // Insertar encabezado de póliza
        public void InsertarEncabezado(int id, DateTime fecha, string concepto, decimal valorTotal)
        {
            string sql = "INSERT INTO Tbl_EncabezadoPoliza (Pk_EncCodigo_Poliza, Pk_Fecha_Poliza, Cmp_Concepto_Poliza, Cmp_Valor_Poliza, Cmp_Estado_Poliza) VALUES (?, ?, ?, ?, 1);";
            using (OdbcConnection con = conexion.AbrirConexion())
            {
                OdbcCommand cmd = new OdbcCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@concepto", concepto);
                cmd.Parameters.AddWithValue("@valor", valorTotal);
                cmd.ExecuteNonQuery();
            }
        }

        // Insertar detalle de póliza
        public void InsertarDetalle(int id, DateTime fecha, string codigoCuenta, bool tipo, decimal valor)
        {
            string sql = "INSERT INTO Tbl_DetallePoliza (PkFk_EncCodigo_Poliza, PkFk_Fecha_Poliza, PkFk_Codigo_Cuenta, Cmp_Tipo_Poliza, Cmp_Valor_Poliza) VALUES (?, ?, ?, ?, ?);";
            using (OdbcConnection con = conexion.AbrirConexion())
            {
                OdbcCommand cmd = new OdbcCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@cuenta", codigoCuenta);
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.Parameters.AddWithValue("@valor", valor);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
