using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Odbc;
using Capa_Modelo_Cheques;

namespace Capa_Controlador_Cheques
{
   public class Cls_Controlador_Cheques
    {
        //Cls_Conexion_Cheque cn = new Cls_Conexion_Cheque();
        // Instancia del modelo para acceder a los metodos
        Cls_Sentencia_Cheque sn = new Cls_Sentencia_Cheque();

    
        //ejemplo de como podrian venir las nominas

        public List<Empleado> ObtenerEmpleadosSimulados()
        {

               return new List<Empleado>
               {
                   new Empleado { NumeroCheque = 1001, Nombre = "Ana Pérez", MontoPagar = 2500 },
                   new Empleado { NumeroCheque = 1002, Nombre = "Luis López", MontoPagar = 3000 },
                   new Empleado { NumeroCheque = 1003, Nombre = "María Gómez", MontoPagar = 2800 }
               };
            
        }






        public bool GenerarLoteConCheques(string usuario, List<Empleado> empleados)
        {
            try
            {
                int idLote = sn.InsertarLote(usuario);

                foreach (var emp in empleados)
                {
                    sn.InsertarCheque(idLote, emp.NumeroCheque.ToString(), emp.Nombre, emp.MontoPagar);
                }
                sn.ActualizarTotalLote(idLote); // <-- actualizar total

                return true;
            }
            catch
            {
                return false;
            }
        }











        public int CrearLote(string usuario)
        {
            return sn.InsertarLote(usuario);
        }
        public int GenerarLoteCheques(string usuario)
        {
            return sn.InsertarLote(usuario);
        }


    }
}
