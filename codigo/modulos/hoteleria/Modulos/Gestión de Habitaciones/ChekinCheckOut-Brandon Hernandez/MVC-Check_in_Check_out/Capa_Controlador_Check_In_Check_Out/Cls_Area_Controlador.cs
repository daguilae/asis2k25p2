using System;
using System.Data;
using System.Windows.Forms;
using Capa_Modelo_Check_In_Check_Out;

namespace Capa_Controlador_Check_In_Check_Out
{
    public class Cls_Area_Controlador
    {
        private readonly Cls_AreaDAO dao = new Cls_AreaDAO();
        private readonly Cls_Conexion conexion = new Cls_Conexion();

 
        public DataTable datObtenerFolio()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = @"
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
                    INNER JOIN Tbl_Check_in I ON F.Fk_Id_Check_In = I.Pk_Id_Check_in
                    INNER JOIN Tbl_Huesped H ON I.Fk_Id_Huesped = H.Pk_Id_Huesped
                    INNER JOIN Tbl_Habitaciones HA ON F.Fk_Id_Habitacion = HA.Pk_Id_Habitaciones
                    WHERE F.Cmp_Estado = 'Abierto'
                    ORDER BY F.Pk_Id_Folio DESC;";

                using (var conn = conexion.conexion())
                using (var da = new System.Data.Odbc.OdbcDataAdapter(sql, conn))
                {
                    da.Fill(dt);
                }

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener folios abiertos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable();
            }
        }

        public DataTable datObtenerAreas() => dao.datObtenerAreas();
        public DataTable datMostrarAreas() => dao.bMostrarAreas();

       

        private bool ValidarFechaArea(int fkFolio, DateTime fechaMovimiento)
        {
            try
            {
                using (var conn = conexion.conexion())
                {
                    string query = "SELECT Cmp_Fecha_Creacion FROM Tbl_Folio WHERE Pk_Id_Folio = ?";
                    using (var cmd = new System.Data.Odbc.OdbcCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", fkFolio);
                        object result = cmd.ExecuteScalar();

                        if (result == null || result == DBNull.Value)
                        {
                            MessageBox.Show("No se encontró la fecha de creación del folio seleccionado.",
                                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }

                        DateTime fechaFolio = Convert.ToDateTime(result);

                        // 🔹 Validar que la fecha del área no sea anterior
                        if (fechaMovimiento < fechaFolio)
                        {
                            MessageBox.Show(
                                $"⚠️ La fecha del movimiento ({fechaMovimiento:dd/MM/yyyy}) no puede ser anterior a la fecha de creación del folio ({fechaFolio:dd/MM/yyyy}).",
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


        public bool bInsertarArea(int fkFolio, string nombre, string descripcion, string tipoMovimiento, string montoTexto, DateTime fecha)
        {
            try
            {
                
                if (fkFolio <= 0)
                {
                    MessageBox.Show("Debe seleccionar un folio válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (string.IsNullOrWhiteSpace(nombre))
                {
                    MessageBox.Show("El nombre del área es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (string.IsNullOrWhiteSpace(tipoMovimiento))
                {
                    MessageBox.Show("Debe seleccionar el tipo de movimiento (Cargo o Abono).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (!decimal.TryParse(montoTexto, out decimal monto))
                {
                    MessageBox.Show("El monto ingresado no es válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

            
                if (!ValidarFechaArea(fkFolio, fecha))
                    return false;

             
                var area = new Cls_Area
                {
                    iFk_Id_Folio = fkFolio,
                    sCmp_Nombre_Area = nombre,
                    sCmp_Descripcion = descripcion,
                    sCmp_Tipo_Movimiento = tipoMovimiento,
                    dCmp_Monto = monto,
                    dCmp_Fecha_Movimiento = fecha
                };

               
                bool resultado = dao.bInsertarArea(area);

                if (resultado)
                    MessageBox.Show(" Área registrada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(" No se pudo registrar el área.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar o registrar el área:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public bool bActualizarArea(int id, int fkFolio, string nombre, string descripcion, string tipoMovimiento, string montoTexto, DateTime fecha)
        {
            if (id <= 0)
            {
                MessageBox.Show("Debe seleccionar un área válida para actualizar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (fkFolio <= 0)
            {
                MessageBox.Show("Debe seleccionar un folio válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(montoTexto, out decimal monto))
            {
                MessageBox.Show("El monto ingresado no es válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!ValidarFechaArea(fkFolio, fecha))
                return false;

            var area = new Cls_Area
            {
                iPk_Id_Area = id,
                iFk_Id_Folio = fkFolio,
                sCmp_Nombre_Area = nombre,
                sCmp_Descripcion = descripcion,
                sCmp_Tipo_Movimiento = tipoMovimiento,
                dCmp_Monto = monto,
                dCmp_Fecha_Movimiento = fecha
            };

            bool resultado = dao.bActualizarArea(area);

            if (resultado)
                MessageBox.Show("Área actualizada correctamente ", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo actualizar el área.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return resultado;
        }

        public bool bEliminarArea(int id)
        {
            if (id <= 0)
            {
                MessageBox.Show("Debe seleccionar un área válida para eliminar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (MessageBox.Show("¿Está seguro de eliminar esta área?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return false;

            string msg;
            bool resultado = dao.bEliminarArea(id, out msg);

            if (resultado)
                MessageBox.Show("Área eliminada correctamente ", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Error al eliminar área:\n" + msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return resultado;
        }
    }
}
