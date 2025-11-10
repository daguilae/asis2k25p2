using System;
using System.Data;
using Capa_Modelo_Check_In_Check_Out;
  namespace Capa_Controlador_Check_In_Check_Out
{
    public class Cls_Detalle_Folio_Controlador
    {
        private readonly Cls_Detalle_Folio_DAO dao = new Cls_Detalle_Folio_DAO();

 
 
        public DataTable datObtenerFolios()
        {
            try
            {
                return dao.datObtenerFolios();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener folios: " + ex.Message);
            }
        }


        public DataTable datObtenerDatosCliente(int iIdFolio)
        {
            try
            {
                return dao.datObtenerDatosCliente(iIdFolio);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener datos del cliente: " + ex.Message);
            }
        }

        public DataTable datObtenerMovimientos(int iIdFolio)
        {
            try
            {
                return dao.datObtenerMovimientos(iIdFolio);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener movimientos: " + ex.Message);
            }
        }

        public DataTable datObtenerTotales(int iIdFolio)
        {
            try
            {
                return dao.datObtenerTotales(iIdFolio);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener totales del folio: " + ex.Message);
            }
        }

      
         //Calcular total final como decimal (solo saldo)
      
        public decimal fun_CalcularSaldo(int iIdFolio)
        {
            try
            {
                DataTable dt = dao.datObtenerTotales(iIdFolio);
                if (dt.Rows.Count > 0 && dt.Rows[0]["Saldo"] != DBNull.Value)
                    return Convert.ToDecimal(dt.Rows[0]["Saldo"]);
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al calcular saldo del folio: " + ex.Message);
            }
        }

        public void fun_ActualizarTotalesEnFolio(int iIdFolio)
        {
            try
            {
                dao.funActualizarTotalesEnFolio(iIdFolio);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar totales en el folio: " + ex.Message);
            }
        }
    }
}

