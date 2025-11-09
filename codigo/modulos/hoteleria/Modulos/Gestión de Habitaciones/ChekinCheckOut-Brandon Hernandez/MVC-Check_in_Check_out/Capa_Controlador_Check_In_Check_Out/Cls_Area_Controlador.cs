using System;
using System.Data;
using System.Windows.Forms;
using Capa_Modelo_Check_In_Check_Out;

namespace Capa_Controlador_Check_In_Check_Out
{
    public class Cls_Area_Controlador
    {
        private readonly Cls_AreaDAO prDao = new Cls_AreaDAO();
        private readonly Cls_Conexion prConexion = new Cls_Conexion();

        // Obtiene folios activos (solo los abiertos)
        public DataTable fun_Obtener_Folios_Abiertos()
        {
            try
            {
                DataTable dtResultado = new DataTable();
                string sQuery = @"
                    SELECT 
                        F.Pk_Id_Folio,
                        F.Cmp_Fecha_Creacion,
                        F.Cmp_Estado,
                        CONCAT(
                            'Folio: ', F.Pk_Id_Folio,
                            ' | Huésped: ', H.Cmp_Nombre, ' ', H.Cmp_Apellido,
                            ' | Habitación: ', HA.Pk_Id_Habitaciones,
                            ' | Fecha Check-In: ', I.Cmp_Fecha_Check_In
                        ) AS DescripcionFolio
                    FROM Tbl_Folio F
                    INNER JOIN Tbl_Check_In I ON F.Fk_Id_Check_In = I.Pk_Id_Check_in
                    INNER JOIN Tbl_Huesped H ON I.Fk_Id_Huesped = H.Pk_Id_Huesped
                    INNER JOIN Tbl_Habitaciones HA ON F.Fk_Id_Habitacion = HA.Pk_Id_Habitaciones
                    WHERE F.Cmp_Estado = 'Abierto'
                    ORDER BY F.Pk_Id_Folio DESC;";

                using (var conn = prConexion.conexion())
                using (var da = new System.Data.Odbc.OdbcDataAdapter(sQuery, conn))
                {
                    da.Fill(dtResultado);
                }

                return dtResultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener folios abiertos: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable();
            }
        }

        // Obtiene las áreas registradas
        public DataTable fun_Obtener_Areas() => prDao.fun_Obtener_Areas();

        // Muestra todas las áreas
        public DataTable fun_Mostrar_Areas() => prDao.fun_Mostrar_Areas();


        // VALIDACIONES

        private bool fun_Validar_Fecha_Area(int iFkFolio, DateTime dFechaMovimiento)
        {
            try
            {
                using (var conn = prConexion.conexion())
                {
                    string sQuery = "SELECT Cmp_Fecha_Creacion FROM Tbl_Folio WHERE Pk_Id_Folio = ?";
                    using (var cmd = new System.Data.Odbc.OdbcCommand(sQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("?", iFkFolio);
                        object oResultado = cmd.ExecuteScalar();

                        if (oResultado == null || oResultado == DBNull.Value)
                        {
                            MessageBox.Show("No se encontró la fecha de creación del folio seleccionado.",
                                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }

                        DateTime dFechaFolio = Convert.ToDateTime(oResultado);

                        if (dFechaMovimiento < dFechaFolio)
                        {
                            MessageBox.Show(
                                $"La fecha del movimiento ({dFechaMovimiento:dd/MM/yyyy}) no puede ser anterior a la creación del folio ({dFechaFolio:dd/MM/yyyy}).",
                                "Validación de Fecha",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                            return false;
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar la fecha del área: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        private int fun_ObtenerUltimoIdArea()
        {
            try
            {
                using (var conn = prConexion.conexion())
                using (var cmd = new System.Data.Odbc.OdbcCommand("SELECT MAX(Pk_Id_Area) FROM Tbl_Area;", conn))
                {
                    object result = cmd.ExecuteScalar();
                    return result != DBNull.Value ? Convert.ToInt32(result) : 0;
                }
            }
            catch
            {
                return 0;
            }
        }


        public bool bInsertar_Area(int iFkFolio, string sNombre, string sDescripcion, string sTipoMovimiento, string sMontoTexto, DateTime dFecha)
        {
            try
            {
                if (iFkFolio <= 0)
                {
                    MessageBox.Show("Debe seleccionar un folio válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (string.IsNullOrWhiteSpace(sNombre))
                {
                    MessageBox.Show("El nombre del área es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (string.IsNullOrWhiteSpace(sTipoMovimiento))
                {
                    MessageBox.Show("Debe seleccionar el tipo de movimiento (Cargo o Abono).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (!decimal.TryParse(sMontoTexto, out decimal dMonto))
                {
                    MessageBox.Show("El monto ingresado no es válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (!fun_Validar_Fecha_Area(iFkFolio, dFecha))
                    return false;

                var clsArea = new Cls_Area
                {
                    iFk_Id_Folio = iFkFolio,
                    sCmp_Nombre_Area = sNombre,
                    sCmp_Descripcion = sDescripcion,
                    sCmp_Tipo_Movimiento = sTipoMovimiento,
                    dCmp_Monto = dMonto,
                    dCmp_Fecha_Movimiento = dFecha
                };

                bool bResultado = prDao.bInsertar_Area(clsArea);

                if (bResultado)
                {
                    // Obtener el último ID de área insertado
                    int idAreaNuevo = fun_ObtenerUltimoIdArea();

                    //  Registrar en detalle folio
                    fun_Insertar_Detalle_Folio(iFkFolio, idAreaNuevo, sDescripcion);

                    MessageBox.Show("Área y detalle registrados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el área.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return bResultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el área: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        // ACTUALIZACIÓN


        public bool bActualizar_Area(int iIdArea, int iFkFolio, string sNombre, string sDescripcion, string sTipoMovimiento, string sMontoTexto, DateTime dFecha)
        {
            if (iIdArea <= 0)
            {
                MessageBox.Show("Debe seleccionar un área válida para actualizar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (iFkFolio <= 0)
            {
                MessageBox.Show("Debe seleccionar un folio válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(sMontoTexto, out decimal dMonto))
            {
                MessageBox.Show("El monto ingresado no es válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!fun_Validar_Fecha_Area(iFkFolio, dFecha))
                return false;

            var clsArea = new Cls_Area
            {
                iPk_Id_Area = iIdArea,
                iFk_Id_Folio = iFkFolio,
                sCmp_Nombre_Area = sNombre,
                sCmp_Descripcion = sDescripcion,
                sCmp_Tipo_Movimiento = sTipoMovimiento,
                dCmp_Monto = dMonto,
                dCmp_Fecha_Movimiento = dFecha
            };

            bool bResultado = prDao.bActualizar_Area(clsArea);

            if (bResultado)
                MessageBox.Show("Área actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo actualizar el área.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return bResultado;
        }


        // ELIMINACIÓN

        public bool bEliminar_Area(int iIdArea)
        {
            if (iIdArea <= 0)
            {
                MessageBox.Show("Debe seleccionar un área válida para eliminar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (MessageBox.Show("¿Está seguro de eliminar esta área?", "Confirmar eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return false;

            bool bResultado = prDao.bEliminar_Area(iIdArea, out string sMensajeError);

            if (bResultado)
                MessageBox.Show("Área eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Error al eliminar el área: " + sMensajeError,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return bResultado;
        }

        private void fun_Insertar_Detalle_Folio(int idFolio, int idArea, string descripcion)
        {
            try
            {
                using (var conn = prConexion.conexion())
                {
                    string sQuery = @"
                INSERT INTO Tbl_Detalle_Folio (Fk_Id_Folio, Fk_Id_Area, Cmp_Descripciones, Cmp_Estado)
                VALUES (?, ?, ?, 'Activo');";

                    using (var cmd = new System.Data.Odbc.OdbcCommand(sQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("?", idFolio);
                        cmd.Parameters.AddWithValue("?", idArea);
                        cmd.Parameters.AddWithValue("?", descripcion ?? "Movimiento de área");

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar en Tbl_Detalle_Folio: " + ex.Message,
                                "Error Detalle_Folio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
