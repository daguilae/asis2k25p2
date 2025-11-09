/* 
 * Programador: Richard Anthony De León Milian
 * Carné: 0901-22-10245
 * Fecha de modificación: 8/11/2025
 * Archivo: Cls_CatalogosModelo.cs
 * Descripción: Obtención de los valores de las tablas hacia los combobox
 */
using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Percepciones_Nomina
{
    public class Cls_CatalogosModelo
    {
        //Ejecutar los scripts SQL
        public DataTable funEjecutar(string sql)
        {
            DataTable dt = new DataTable();
            Cls_Conexion cn = new Cls_Conexion();
            OdbcConnection con = null;

            try
            {
                con = cn.conexionDB(); // abre
                using (var cmd = new OdbcCommand(sql, con))
                using (var da = new OdbcDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar consulta: " + ex.Message, ex);
            }
            finally
            {
                cn.cerrarConexion(); // cierra
            }

            return dt;
        }

        //obtención de los valores de conceptos de nómina
        public DataTable funObtenerConceptosNomina()
        {
            string sql = @"
        SELECT
            Cmp_iId_ConceptoNomina     AS id_concepto_nomina,
            Cmp_sNombre_ConceptoNomina AS nombre_concepto_nomina
        FROM Tbl_ConceptosNomina
        WHERE Cmp_sTipo_ConceptoNomina = 'PERCEPCION'
        ORDER BY Cmp_sNombre_ConceptoNomina;";
            return funEjecutar(sql);
        }

        public DataTable funObtenerEmpleados()
        {
            string sql = @"
                SELECT
                    e.`Cmp_iId_Empleado` AS id_empleado,
                    CONCAT_WS(' ', e.`Cmp_sNombre_Empleado`, e.`Cmp_sApellido_Empleado`) AS nombre_empleado
                FROM `Tbl_Empleados` e
                ORDER BY nombre_empleado;";
            return funEjecutar(sql);
        }

        //Obtención de los números de nómina
        public DataTable funObtenerNumerosNomina()
        {
            string sql = @"
                SELECT
                    n.`Cmp_iId_Nomina`                  AS id_nomina,
                    CAST(n.`Cmp_iId_Nomina` AS CHAR)    AS numero_nomina
                FROM `Tbl_Nomina` n
                ORDER BY n.`Cmp_iId_Nomina`;";
            return funEjecutar(sql);
        }


        //Obtención de conceptos de nómina por tipo
        public DataTable funObtenerConceptosNominaPorTipo(string sTipo)
        {
            string sSql = @"
        SELECT 
            Cmp_iId_ConceptoNomina     AS id_concepto_nomina,
            Cmp_sNombre_ConceptoNomina AS nombre_concepto_nomina
        FROM Tbl_ConceptosNomina
        WHERE LOWER(TRIM(Cmp_sTipo_ConceptoNomina)) = LOWER(TRIM(?))
        ORDER BY Cmp_sNombre_ConceptoNomina;";

            var dt = new DataTable();
            var cn = new Cls_Conexion();
            using (var con = cn.conexionDB())
            using (var cmd = new OdbcCommand(sSql, con))
            using (var da = new OdbcDataAdapter(cmd))
            {
                cmd.Parameters.Add("p1", OdbcType.VarChar).Value = sTipo;
                da.Fill(dt);
            }
            cn.cerrarConexion();
            return dt;
        }

       //Obtención de puestos del empleado
        public DataTable funObtenerPuestos()
        {
            string sql = @"
                SELECT
                    `Cmp_iId_Puesto`     AS id_puesto,
                    `Cmp_sNombre_Puesto` AS nombre_puesto
                FROM `Tbl_Puestos`
                ORDER BY `Cmp_sNombre_Puesto`;";
            return funEjecutar(sql);
        }

        //Obtención de los detalles de nómina 
        private DataTable funObtenerDetalleNomina(int idNomina)
        {
            DataTable dt = new DataTable();
            Cls_Conexion cn = new Cls_Conexion();

            using (OdbcConnection con = cn.conexionDB())
            using (OdbcCommand cmd = new OdbcCommand(@"
        SELECT
            d.`Cmp_iId_DetalleNomina`              AS id_detalle,
            d.`Cmp_iId_Nomina`                     AS id_nomina,
            d.`Cmp_iId_Empleado`                   AS id_empleado,
            CONCAT_WS(' ', e.`Cmp_sNombre_Empleado`, e.`Cmp_sApellido_Empleado`) AS empleado,
            d.`Cmp_iDiasLaborados_DetalleNomina`   AS dias_laborados,
            d.`Cmp_iAusencias_DetalleNomina`       AS ausencias,
            d.`Cmp_dePercepciones_DetalleNomina`   AS percepciones,
            d.`Cmp_deDeducciones_DetalleNomina`    AS deducciones,
            d.`Cmp_deSueldoLiquido_DetalleNomina`  AS sueldo_liquido
        FROM `Tbl_DetallesNomina` d
        INNER JOIN `Tbl_Empleados` e
            ON e.`Cmp_iId_Empleado` = d.`Cmp_iId_Empleado`
        WHERE d.`Cmp_iId_Nomina` = ?
        ORDER BY d.`Cmp_iId_DetalleNomina` DESC;", con))
            {
                cmd.Parameters.Add("p1", OdbcType.Int).Value = idNomina;
                using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }

            cn.cerrarConexion();
            return dt;
        }

        //Obtención del estado de nómina ya que una generada no permitirá ingreso de percepción
        public string funObtenerEstadoNomina(int idNomina)
        {
            string estado = string.Empty;
            Cls_Conexion cn = new Cls_Conexion();

            using (OdbcConnection con = cn.conexionDB())
            {
                try
                {
                    using (OdbcCommand cmd = new OdbcCommand(
                        "SELECT Cmp_sEstado_Nomina FROM Tbl_Nomina WHERE Cmp_iId_Nomina = ?",
                        con))
                    {
                        cmd.Parameters.Add("p1", OdbcType.Int).Value = idNomina;
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                            estado = result.ToString();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener estado de nómina: " + ex.Message);
                }
                finally
                {
                    cn.cerrarConexion();
                }
            }

            return estado;
        }
        

    }

}
