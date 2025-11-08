using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Odbc;

// ==========================================================
// Capa Modelo: Cls_Sentencias_Conciliacion
// AUTORA: Paula Daniela Leonardo Paredes
// ==========================================================

namespace Capa_Modelo_CB
{
    public class Cls_Sentencias_Conciliacion
    {
        Cls_Conexion gConexion = new Cls_Conexion(); // Usa tu conexión original

        // ==========================================================
        // fun_obtener_bancos:
        // Retorna los bancos activos para llenar el combo de banco.
        // ==========================================================
        public OdbcDataAdapter fun_obtener_bancos()
        {
            string sConsulta = "SELECT Pk_Id_Banco, Cmp_NombreBanco " +
                               "FROM Tbl_Bancos WHERE Cmp_Estado = 1;";
            return new OdbcDataAdapter(sConsulta, gConexion.conexion());
        }

        // ==========================================================
        // fun_obtener_cuentas:
        // Retorna las cuentas bancarias de un banco seleccionado.
        // ==========================================================
        public OdbcDataAdapter fun_obtener_cuentas(int iIdBanco)
        {
            string sConsulta = "SELECT Pk_Id_CuentaBancaria, Cmp_NumeroCuenta " +
                               "FROM Tbl_CuentasBancarias " +
                               "WHERE Fk_Id_Banco = " + iIdBanco + " AND Cmp_Estado = 1;";
            return new OdbcDataAdapter(sConsulta, gConexion.conexion());
        }

        // ==========================================================
        // fun_obtener_movimientos:
        // Retorna movimientos bancarios no conciliados (Cmp_Conciliado = 0)
        // para la cuenta seleccionada.
        // ==========================================================
        public OdbcDataAdapter fun_obtener_movimientos(int iIdCuenta)
        {
            string sConsulta = "SELECT mb.Pk_Id_Movimiento, mb.Fk_Id_CuentaOrigen, " +
                               "tb.Cmp_NombreTransaccion, mb.Cmp_NumeroDocumento, " +
                               "mb.Cmp_Fecha, mb.Cmp_MontoTotal, mb.Cmp_Beneficiario, mb.Cmp_Concepto " +
                               "FROM Tbl_MovimientoBancarioEncabezado mb " +
                               "INNER JOIN Tbl_TransaccionesBancarias tb " +
                               "ON mb.Fk_Id_Operacion = tb.Pk_Id_Transaccion " +
                               "WHERE mb.Fk_Id_CuentaOrigen = " + iIdCuenta + " " +
                               "AND mb.Cmp_Conciliado = 0;";
            return new OdbcDataAdapter(sConsulta, gConexion.conexion());
        }

        // ==========================================================
        // pro_insertar_conciliacion:
        // Inserta un nuevo registro de conciliación bancaria.
        // ==========================================================
        public void pro_insertar_conciliacion(
            int iAnio,
            int iMes,
            int iCuenta,
            string dFecha,
            decimal deSaldoBanco,
            decimal deSaldoSistema,
            string sObservaciones,
            int bEstado)
        {
            string sInsert = "INSERT INTO Tbl_ConciliacionBancaria " +
                             "(Cmp_AnioConciliacion, Cmp_MesConciliacion, Fk_Id_CuentaBancaria, " +
                             "Cmp_FechaConciliacion, Cmp_SaldoBanco, Cmp_SaldoSistema, " +
                             "Cmp_Observaciones, Cmp_EstadoConciliacion) VALUES (" +
                             iAnio + ", " + iMes + ", " + iCuenta + ", '" + dFecha + "', " +
                             deSaldoBanco + ", " + deSaldoSistema + ", '" + sObservaciones + "', " + bEstado + ");";

            try
            {
                OdbcCommand cmd = new OdbcCommand(sInsert, gConexion.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (OdbcException e)
            {
                Console.WriteLine("❌ Error al insertar conciliación: " + e.Message);
            }
        }

        // ==========================================================
        // fun_mostrar_conciliaciones:
        // Retorna las conciliaciones registradas (encabezado).
        // ==========================================================
        public OdbcDataAdapter fun_mostrar_conciliaciones()
        {
            string sConsulta = "SELECT c.Pk_Id_Conciliacion, b.Cmp_NombreBanco AS Banco, " +
                               "cb.Cmp_NumeroCuenta AS Cuenta, c.Cmp_MesConciliacion AS Mes, " +
                               "c.Cmp_AnioConciliacion AS Año, c.Cmp_SaldoBanco AS 'Saldo Banco', " +
                               "c.Cmp_SaldoSistema AS 'Saldo Sistema', c.Cmp_Diferencia AS Diferencia " +
                               "FROM Tbl_ConciliacionBancaria c " +
                               "INNER JOIN Tbl_CuentasBancarias cb ON c.Fk_Id_CuentaBancaria = cb.Pk_Id_CuentaBancaria " +
                               "INNER JOIN Tbl_Bancos b ON cb.Fk_Id_Banco = b.Pk_Id_Banco;";
            return new OdbcDataAdapter(sConsulta, gConexion.conexion());
        }

        // ==========================================================
        // pro_actualizar_conciliacion:
        // Actualiza una conciliación bancaria existente.
        // ==========================================================
        public void pro_actualizar_conciliacion(
            int iIdConciliacion,
            int iAnio,
            int iMes,
            string dFecha,
            decimal deSaldoBanco,
            decimal deSaldoSistema,
            string sObservaciones,
            int bEstado)
        {
            string sUpdate = "UPDATE Tbl_ConciliacionBancaria SET " +
                             "Cmp_AnioConciliacion = " + iAnio + ", " +
                             "Cmp_MesConciliacion = " + iMes + ", " +
                             "Cmp_FechaConciliacion = '" + dFecha + "', " +
                             "Cmp_SaldoBanco = " + deSaldoBanco + ", " +
                             "Cmp_SaldoSistema = " + deSaldoSistema + ", " +
                             "Cmp_Observaciones = '" + sObservaciones + "', " +
                             "Cmp_EstadoConciliacion = " + bEstado + " " +
                             "WHERE Pk_Id_Conciliacion = " + iIdConciliacion + ";";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sUpdate, gConexion.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (OdbcException e)
            {
                Console.WriteLine("⚠️ Error al actualizar conciliación: " + e.Message);
            }
        }

        // ==========================================================
        // pro_eliminar_conciliacion:
        // Elimina una conciliación bancaria.
        // ==========================================================
        public void pro_eliminar_conciliacion(int iIdConciliacion)
        {
            string sDelete = "DELETE FROM Tbl_ConciliacionBancaria WHERE Pk_Id_Conciliacion = " + iIdConciliacion + ";";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sDelete, gConexion.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (OdbcException e)
            {
                Console.WriteLine("⚠️ Error al eliminar conciliación: " + e.Message);
            }
        }
    }
}
