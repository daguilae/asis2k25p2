using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Capa_Modelo_Poliza
{
    //========================== Kevin Natareno 0901-21-635 : DAO Poliza, 26/10/2025 ===================================================
    public class Cls_DAO_Poliza
    {
        Cls_Conexion conexion = new Cls_Conexion();

        public void GuardarPoliza(string banco, string tipo, string docto, DateTime fecha, string concepto)
        {
            try
            {
                using (OdbcConnection conn = conexion.conexion())
                {
                    conn.Open();
                    string sql = "INSERT INTO Poliza_Encabezado (Pk_Poliza_Fecha, Poliza_Concepto, Poliza_Valor, Poliza_Estado) VALUES (?, ?, 0, 'Activo')";
                    using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@fecha", fecha);
                        cmd.Parameters.AddWithValue("@concepto", concepto);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar póliza: " + ex.Message);
            }
        }
    }
}
