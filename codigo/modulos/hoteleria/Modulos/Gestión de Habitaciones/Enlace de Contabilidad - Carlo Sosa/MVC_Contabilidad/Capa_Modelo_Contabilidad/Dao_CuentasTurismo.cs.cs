using System;
using System.Data;
using System.Data.Odbc;

//inicio del codigo- Carlo Sosa 0901-22-1106- Fecha: 01/11/2025

namespace Capa_Modelo_Contabilidad
{
    public class Dao_CuentasTurismo
    {
        readonly Conexion _cx = new Conexion();

        public DataTable ListarCatalogo()
        {
            var dt = new DataTable();
            var c = _cx.Abrir();
            try
            {
                using (var cmd = new OdbcCommand(
                    "SELECT Pk_Codigo_Cuenta, Cmp_CtaNombre FROM tbl_catalogo_cuentas ORDER BY Cmp_CtaNombre", c))
                using (var da = new OdbcDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
                return dt;
            }
            finally { _cx.Cerrar(c); }
        }

        public (int Debe, string NombreDebe, int Haber, string NombreHaber) LeerConfig()
        {
            var c = _cx.Abrir();
            try
            {
                using (var cmd = new OdbcCommand(
                    "SELECT Fk_Codigo_Cuenta_Debe, Cmp_CtaNombre_Debe, Fk_Codigo_Cuenta_Haber, Cmp_CtaNombre_Haber FROM tbl_config_turismo LIMIT 1", c))
                using (var rd = cmd.ExecuteReader())
                {
                    if (!rd.Read()) return (0, "", 0, "");
                    var debe = rd.IsDBNull(0) ? 0 : rd.GetInt32(0);
                    var nomDebe = rd.IsDBNull(1) ? "" : rd.GetString(1);
                    var haber = rd.IsDBNull(2) ? 0 : rd.GetInt32(2);
                    var nomHaber = rd.IsDBNull(3) ? "" : rd.GetString(3);
                    return (debe, nomDebe, haber, nomHaber);
                }
            }
            finally { _cx.Cerrar(c); }
        }

        public (int Debe, string NombreDebe, int Haber, string NombreHaber) ObtenerConfig()
        {
            return LeerConfig();
        }


        public void Guardar(int codDebe, string nomDebe, int codHaber, string nomHaber)
        {
            var c = _cx.Abrir();
            try
            {
                bool exists;
                using (var existCmd = new OdbcCommand("SELECT COUNT(*) FROM tbl_config_turismo", c))
                {
                    exists = Convert.ToInt32(existCmd.ExecuteScalar()) > 0;
                }

                if (exists)
                {
                    using (var up = new OdbcCommand(
                        "UPDATE tbl_config_turismo SET Fk_Codigo_Cuenta_Debe=?, Cmp_CtaNombre_Debe=?, Fk_Codigo_Cuenta_Haber=?, Cmp_CtaNombre_Haber=? WHERE Pk_Id_Config=(SELECT Pk_Id_Config FROM tbl_config_turismo LIMIT 1)",
                        c))
                    {
                        up.Parameters.AddWithValue("@p1", codDebe);
                        up.Parameters.AddWithValue("@p2", nomDebe);
                        up.Parameters.AddWithValue("@p3", codHaber);
                        up.Parameters.AddWithValue("@p4", nomHaber);
                        up.ExecuteNonQuery();
                    }
                }
                else
                {
                    using (var ins = new OdbcCommand(
                        "INSERT INTO tbl_config_turismo (Fk_Codigo_Cuenta_Debe, Cmp_CtaNombre_Debe, Fk_Codigo_Cuenta_Haber, Cmp_CtaNombre_Haber) VALUES (?,?,?,?)",
                        c))
                    {
                        ins.Parameters.AddWithValue("@p1", codDebe);
                        ins.Parameters.AddWithValue("@p2", nomDebe);
                        ins.Parameters.AddWithValue("@p3", codHaber);
                        ins.Parameters.AddWithValue("@p4", nomHaber);
                        ins.ExecuteNonQuery();
                    }
                }
            }
            finally { _cx.Cerrar(c); }
        }
    }
}

//Fin del codigo- Carlo Sosa 0901-22-1106- Fecha: 01/11/2025
