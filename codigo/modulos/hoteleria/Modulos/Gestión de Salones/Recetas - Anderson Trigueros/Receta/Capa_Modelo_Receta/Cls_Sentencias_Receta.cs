using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo_Receta
{
    public class Cls_Sentencias_Receta
    {
        public DataTable fun_ObtenerMenus()
        {
            Cls_Conexion_Receta conexion = new Cls_Conexion_Receta();
            DataTable tabla = new DataTable();
            try
            {
                using (OdbcConnection con = conexion.conexion())
                {
                    string sConsultaMenus = "SELECT m.Pk_Id_Menu AS codigoMenu, m.Cmp_Nombre_Platillo as Platillo FROM Tbl_Menu m";
                    OdbcCommand cmd = new OdbcCommand(sConsultaMenus, con);
                    OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                    da.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los menús: " + ex.Message, ex);
            }
            return tabla;
        }

        public DataTable fun_ObtenerReceta(int iCodigoMenu)
        {
            Cls_Conexion_Receta conexion = new Cls_Conexion_Receta();
            DataTable tabla = new DataTable();
            try
            {
                using (OdbcConnection con = conexion.conexion())
                {
                    string sConsultaReceta = @"SELECT r.Pk_Id_Receta as codigo, mp.Cmp_Materia_Prima AS ingrediente,
                                              r.Cmp_Cantidad as cantidad, r.Cmp_Unidad_Medida AS unidadMedida
                                              FROM Tbl_Receta r
                                              JOIN Tbl_Menu m ON r.Fk_Id_Menu = m.Pk_Id_Menu
                                              JOIN Tbl_Materia_Prima mp ON r.Fk_Id_Materia_Prima = mp.Pk_Id_Materia_Prima
                                              WHERE r.Fk_Id_Menu = ?";
                    OdbcCommand cmd = new OdbcCommand(sConsultaReceta, con);
                    cmd.Parameters.AddWithValue("", iCodigoMenu);
                    OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                    da.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los menús: " + ex.Message, ex);
            }
            return tabla;
        }
        public void pro_GuardarReceta(int iCodigoMenu, string sIngrediente, string sUnidad, double doCantidad)
        {
            try
            {
                using (OdbcConnection con = new Cls_Conexion_Receta().conexion())
                {
                    OdbcTransaction tx = con.BeginTransaction();
                    try
                    {
                        int iIdMateriaPrima = 0;

                        // Verificar si existe la materia prima
                        string sConsultarIngrediente = @"SELECT Pk_Id_Materia_Prima
                                                         FROM Tbl_Materia_Prima
                                                         WHERE Cmp_Materia_Prima = ?";
                        OdbcCommand cmdBuscar = new OdbcCommand(sConsultarIngrediente, con, tx);
                        cmdBuscar.Parameters.AddWithValue("", sIngrediente);
                        object result = cmdBuscar.ExecuteScalar();
                        if (result != null)
                        {
                            iIdMateriaPrima = Convert.ToInt32(result);
                        }
                        else
                        {
                            // Si no existe, ingresar primero el ingrediente
                            string sIngresarMP = @"INSERT INTO Tbl_Materia_Prima (Cmp_Materia_Prima)
                                                 VALUES (?)";
                            OdbcCommand cmdInsertMP = new OdbcCommand(sIngresarMP, con, tx);
                            cmdInsertMP.Parameters.AddWithValue("", sIngrediente);
                            cmdInsertMP.ExecuteNonQuery();
                            // Obtener ID
                            OdbcCommand cmdLastId = new OdbcCommand("SELECT LAST_INSERT_ID();", con, tx);
                            iIdMateriaPrima = Convert.ToInt32(cmdLastId.ExecuteScalar());
                        }

                        // Ingresar registro de receta
                        string sIngresarReceta = @"INSERT INTO Tbl_Receta
                                                (Fk_Id_Menu, Fk_Id_Materia_Prima, Cmp_Cantidad, Cmp_Unidad_Medida)
                                                 VALUES (?, ?, ?, ?)";
                        OdbcCommand cmdInsertReceta = new OdbcCommand(sIngresarReceta, con, tx);
                        cmdInsertReceta.Parameters.AddWithValue("", iCodigoMenu);
                        cmdInsertReceta.Parameters.AddWithValue("", iIdMateriaPrima);
                        cmdInsertReceta.Parameters.AddWithValue("", doCantidad);
                        cmdInsertReceta.Parameters.AddWithValue("", sUnidad);
                        cmdInsertReceta.ExecuteNonQuery();
                        tx.Commit();
                    }
                    catch
                    {
                        tx.Rollback();
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar receta: " + ex.Message);
            }
        }

        public void pro_ActualizarIngrediente(string sIngredienteOriginal, string sIngrediente)
        {
            try
            {
                using (OdbcConnection con = new Cls_Conexion_Receta().conexion())
                {
                    string sActualizar = @"UPDATE Tbl_Materia_Prima 
                                       SET Cmp_Materia_Prima = ? 
                                       WHERE Cmp_Materia_Prima = ?";
                    OdbcCommand cmd = new OdbcCommand(sActualizar, con);
                    cmd.Parameters.AddWithValue("", sIngrediente);
                    cmd.Parameters.AddWithValue("", sIngredienteOriginal);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar: " + ex.Message, ex);
            }
        }

        public void pro_ActualizarReceta(int iCodigoReceta, string sUnidad, double doCantidad)
        {
            try
            {
                using (OdbcConnection con = new Cls_Conexion_Receta().conexion())
                {
                    string sActualizarReceta = @"UPDATE Tbl_Receta
                       SET Cmp_Cantidad = ?, Cmp_Unidad_Medida = ?
                       WHERE Pk_Id_Receta = ?";

                    OdbcCommand cmd = new OdbcCommand(sActualizarReceta, con);
                    cmd.Parameters.AddWithValue("", doCantidad);
                    cmd.Parameters.AddWithValue("", sUnidad);
                    cmd.Parameters.AddWithValue("", iCodigoReceta);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar: " + ex.Message, ex);
            }

        }

        public void pro_EliminarReceta(int iCodigoReceta)
        {
            try
            {
                using (OdbcConnection con = new Cls_Conexion_Receta().conexion())
                {
                    string sEliminar = @"DELETE FROM Tbl_Receta
                                           WHERE Pk_Id_Receta = ?";
                    OdbcCommand cmd = new OdbcCommand(sEliminar, con);
                    cmd.Parameters.AddWithValue("", iCodigoReceta);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar: " + ex.Message, ex);
            }
        }

    }


}
