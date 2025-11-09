/* 
 * Programador: Richard Anthony De León Milian
 * Carné: 0901-22-10245
 * Fecha de modificación: 8/11/2025
 * Archivo: Cls_UtilModelo
 * Descripción: Resetear el autoincrement cuando la tabla esté vacía
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Capa_Modelo_Percepciones_Nomina
{
    public class Cls_UtilModelo
    {
        //Reinicia el AUTO_INCREMENT solo si la tabla está vacía
        public void funResetAutoIncrementIfEmpty(string tableName, string idColumn)
        {
            Cls_Conexion cn = new Cls_Conexion();
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


    }
}

