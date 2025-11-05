using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Percepciones_Nomina
{
    public class CatalogosModelo
    {
        public DataTable Ejecutar(string sql)
        {
            DataTable dt = new DataTable();
            Conexion cn = new Conexion();
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

        /// <summary>
        /// ComboBox Concepto de Nómina:
        /// DisplayMember = nombre_concepto_nomina
        /// ValueMember   = id_concepto_nomina
        /// (Mapea desde Tbl_ConceptosNomina de la nueva BD)
        /// </summary>
        public DataTable ObtenerConceptosNomina()
        {
            string sql = @"
        SELECT
            Cmp_iId_ConceptoNomina     AS id_concepto_nomina,
            Cmp_sNombre_ConceptoNomina AS nombre_concepto_nomina
        FROM Tbl_ConceptosNomina
        WHERE Cmp_sTipo_ConceptoNomina = 'PERCEPCION'
        ORDER BY Cmp_sNombre_ConceptoNomina;";
            return Ejecutar(sql);
        }


        /// <summary>
        /// ComboBox Empleados:
        /// DisplayMember = nombre_empleado
        /// ValueMember   = id_empleado
        /// (Concatena nombre + apellido desde Tbl_Empleados)
        /// </summary>
        public DataTable ObtenerEmpleados()
        {
            string sql = @"
                SELECT
                    e.`Cmp_iId_Empleado` AS id_empleado,
                    CONCAT_WS(' ', e.`Cmp_sNombre_Empleado`, e.`Cmp_sApellido_Empleado`) AS nombre_empleado
                FROM `Tbl_Empleados` e
                ORDER BY nombre_empleado;";
            return Ejecutar(sql);
        }

        /// <summary>
        /// ComboBox No. Nómina:
        /// DisplayMember = numero_nomina
        /// ValueMember   = id_nomina
        /// (En el esquema nuevo usamos el Id como número de nómina)
        /// </summary>
        public DataTable ObtenerNumerosNomina()
        {
            string sql = @"
                SELECT
                    n.`Cmp_iId_Nomina`                  AS id_nomina,
                    CAST(n.`Cmp_iId_Nomina` AS CHAR)    AS numero_nomina
                FROM `Tbl_Nomina` n
                ORDER BY n.`Cmp_iId_Nomina`;";
            return Ejecutar(sql);
        }

        // ===== (Opcional útiles, por si los quieres ya listos) =================

        /// <summary>
        /// Conceptos filtrados por tipo (ej. 'Percepcion' o 'Deduccion')
        /// </summary>
        public DataTable ObtenerConceptosPorTipo(string tipo)
        {
            // OJO: como no usamos parámetros en OdbcCommand aquí, sanitiza 'tipo' si viene del UI;
            // idealmente usa parámetros. Te dejo una versión parametrizada:
            DataTable dt = new DataTable();
            Conexion cn = new Conexion();
            using (var con = cn.conexionDB())
            using (var cmd = new OdbcCommand(@"
                SELECT
                    `Cmp_iId_ConceptoNomina`     AS id_concepto_nomina,
                    `Cmp_sNombre_ConceptoNomina` AS nombre_concepto_nomina
                FROM `Tbl_ConceptosNomina`
                WHERE `Cmp_sTipo_ConceptoNomina` = ?
                ORDER BY `Cmp_sNombre_ConceptoNomina`;", con))
            {
                cmd.Parameters.Add("p1", OdbcType.VarChar).Value = tipo;
                using (var da = new OdbcDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            cn.cerrarConexion();
            return dt;
        }

        /// <summary>
        /// Lista de Puestos (útil para combos): Display = nombre_puesto, Value = id_puesto
        /// </summary>
        public DataTable ObtenerPuestos()
        {
            string sql = @"
                SELECT
                    `Cmp_iId_Puesto`     AS id_puesto,
                    `Cmp_sNombre_Puesto` AS nombre_puesto
                FROM `Tbl_Puestos`
                ORDER BY `Cmp_sNombre_Puesto`;";
            return Ejecutar(sql);
        }
        private DataTable ObtenerDetalleNomina(int idNomina)
        {
            DataTable dt = new DataTable();
            Conexion cn = new Conexion();

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

        public string ObtenerEstadoNomina(int idNomina)
        {
            string estado = string.Empty;
            Conexion cn = new Conexion();

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
