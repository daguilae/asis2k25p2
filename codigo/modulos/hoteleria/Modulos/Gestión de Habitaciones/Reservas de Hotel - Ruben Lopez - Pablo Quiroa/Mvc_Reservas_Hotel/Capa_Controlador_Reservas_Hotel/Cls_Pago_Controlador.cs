using System;
using System.Data;
using Capa_Modelo_Reservas_Hotel;

namespace Capa_Controlador_Reservas_Hotel
{
    public class Cls_Pago_Controlador
    {
        private readonly Cls_Sentencia_Pago modelo = new Cls_Sentencia_Pago();

        
        // === OBTENER FOLIOS ===
     
        public DataTable datObtenerFolios()
        {
            return modelo.datObtenerFolios();
        }

      
        // === INSERTAR PAGO PRINCIPAL ===
        
        public int funInsertarPago(int fkFolio, string metodo, DateTime fecha, decimal monto, string estado)
        {
            return modelo.funInsertarPago(fkFolio, metodo, fecha, monto, estado);
        }
    }
}
