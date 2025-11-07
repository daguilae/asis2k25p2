using System;
using System.Data;
using System.Data.Odbc;
// CARLO ANDREE BARQUERO BOCHE 0901-22-601  29-11-2025
namespace Capa_Modelo_Anticipos_Nomina
{
    public class Cls_Dao_Anticipos_Nomina
    {
        private readonly Cls_Conexion_Anticipos_Nomina conexion = new Cls_Conexion_Anticipos_Nomina();

        
        //  FUNCION PARA OBTENER EMPLEADOS ACTIVOS
  
        public DataTable funObtenerEmpleados()
        {
            DataTable dt = new DataTable();
            try
            {
                using (OdbcConnection conn = conexion.conexion())
                {
                    string query = @"
                SELECT 
                    Cmp_iId_Empleado, 
                    CONCAT(Cmp_sNombre_Empleado, ' ', Cmp_sApellido_Empleado) AS Nombre
                FROM Tbl_Empleados
                WHERE Cmp_bEstado_Empleado = 1;";

                    OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error al obtener empleados: {ex.Message}");
            }
            return dt;
        }



        //  FUNCION PARA OBTENER ANTICIPOS POR EMPLEADO
    
        public DataTable funObtenerAnticiposPorEmpleado(int idEmpleado)
        {
            string query = @"
        SELECT 
            Cmp_iId_Anticipo,
            Cmp_iId_Empleado,
            Cmp_deMonto_Anticipo,
            Cmp_dFecha_Anticipo,
            Cmp_sMotivo_Anticipo,
            Cmp_deSaldoPendiente_Anticipo
        FROM tbl_anticipos
        WHERE Cmp_iId_Empleado = ?;";

            using (OdbcConnection conn = conexion.conexion())
            {
                conn.Open();
                OdbcCommand cmd = new OdbcCommand(query, conn);

                // ⚠️ Solo el orden importa en ODBC, no el nombre
                cmd.Parameters.AddWithValue("", idEmpleado);

                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }


        // FUNCION PARA INSERTAR NUEVO ANTICIPO


        public void funInsertarAnticipo(int idEmpleado, decimal monto, DateTime fecha, string motivo, decimal saldoPendiente)
        {
            string query = @"
        INSERT INTO Tbl_Anticipos
        (Cmp_iId_Empleado, Cmp_deMonto_Anticipo, Cmp_dFecha_Anticipo, Cmp_sMotivo_Anticipo, Cmp_deSaldoPendiente_Anticipo)
        VALUES (?, ?, ?, ?, ?)";

            try
            {
                using (OdbcConnection conn = conexion.conexion())
                {
                    conn.Open();
                    Console.WriteLine($"Estado conexión: {conn.State}");

                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        // 🚀 Ojo con los tipos: Double y VarChar funcionan mejor con MySQL ODBC
                        cmd.Parameters.Add("?", OdbcType.Int).Value = idEmpleado;
                        cmd.Parameters.Add("?", OdbcType.Double).Value = Convert.ToDouble(monto);
                        cmd.Parameters.Add("?", OdbcType.DateTime).Value = fecha;
                        cmd.Parameters.Add("?", OdbcType.VarChar, 255).Value = motivo;
                        cmd.Parameters.Add("?", OdbcType.Double).Value = Convert.ToDouble(saldoPendiente);

                        Console.WriteLine("Insertando anticipo...");
                        int filas = cmd.ExecuteNonQuery();
                        Console.WriteLine($"✅ Filas insertadas: {filas}");
                    }
                }
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("❌ Error de MySQL/ODBC detectado:");
                foreach (OdbcError error in ex.Errors)
                {
                    Console.WriteLine($"SQLState: {error.SQLState}");
                    Console.WriteLine($"Message: {error.Message}");
                    Console.WriteLine($"Source: {error.Source}");
                }
                Console.WriteLine($"Mensaje general: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Error general:");
                Console.WriteLine(ex.Message);
            }
        }

        // FUNCION PARA PODER EDITAR LOS ANTICIPOS

        public void funEditarAnticipo(int idAnticipo, int idEmpleado, decimal monto, DateTime fecha, string motivo, decimal saldoPendiente)
        {
            string query = @"
        UPDATE Tbl_Anticipos
        SET 
            Cmp_iId_Empleado = ?, 
            Cmp_deMonto_Anticipo = ?, 
            Cmp_dFecha_Anticipo = ?, 
            Cmp_sMotivo_Anticipo = ?, 
            Cmp_deSaldoPendiente_Anticipo = ?
        WHERE Cmp_iId_Anticipo = ?";

            using (OdbcConnection conn = conexion.conexion())
            {
                conn.Open();
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    cmd.Parameters.Add("?", OdbcType.Int).Value = idEmpleado;
                    cmd.Parameters.Add("?", OdbcType.Double).Value = Convert.ToDouble(monto);
                    cmd.Parameters.Add("?", OdbcType.DateTime).Value = fecha;
                    cmd.Parameters.Add("?", OdbcType.VarChar, 255).Value = motivo;
                    cmd.Parameters.Add("?", OdbcType.Double).Value = Convert.ToDouble(saldoPendiente);
                    cmd.Parameters.Add("?", OdbcType.Int).Value = idAnticipo;

                    cmd.ExecuteNonQuery();
                }
            }
        }


        // FUNCION PARA PODER ELIMINAR  LOS ANTICIPOS
        public void funEliminarAnticipo(int idAnticipo)
        {
            string query = "DELETE FROM Tbl_Anticipos WHERE Cmp_iId_Anticipo = ?";

            using (OdbcConnection conn = conexion.conexion())
            {
                conn.Open();
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    cmd.Parameters.Add("?", OdbcType.Int).Value = idAnticipo;
                    cmd.ExecuteNonQuery();
                }
            }
        }





    }
}
