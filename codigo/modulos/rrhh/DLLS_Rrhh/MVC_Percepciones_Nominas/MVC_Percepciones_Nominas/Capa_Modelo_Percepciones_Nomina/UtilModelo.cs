using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Capa_Modelo_Percepciones_Nomina
{
    public class UtilModelo
    {
        // 🔁 Reinicia el AUTO_INCREMENT solo si la tabla está vacía
        public void ResetAutoIncrementIfEmpty(string tableName, string idColumn)
        {
            Conexion cn = new Conexion();
            using (OdbcConnection con = cn.conexionDB())
            {
                int count = 0;
                using (OdbcCommand cmd = new OdbcCommand($"SELECT COUNT(*) FROM `{tableName}`;", con))
                {
                    count = Convert.ToInt32(cmd.ExecuteScalar());
                }

                if (count == 0)
                {
                    using (OdbcCommand cmd = new OdbcCommand($"ALTER TABLE `{tableName}` AUTO_INCREMENT = 1;", con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            cn.cerrarConexion();
        }

        // 🧨 Método para vaciar una tabla completamente y reiniciar el contador
        public void TruncarTabla(string tableName)
        {
            Conexion cn = new Conexion();
            using (OdbcConnection con = cn.conexionDB())
            using (OdbcCommand cmd = new OdbcCommand($"TRUNCATE TABLE `{tableName}`;", con))
            {
                cmd.ExecuteNonQuery();
            }
            cn.cerrarConexion();
        }
    }
}

