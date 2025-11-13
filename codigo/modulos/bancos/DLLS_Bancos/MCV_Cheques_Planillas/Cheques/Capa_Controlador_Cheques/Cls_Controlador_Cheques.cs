using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Odbc;
using Capa_Modelo_Cheques;
//REALIZADO POR ROCIO LOPEZ 


namespace Capa_Controlador_Cheques
{
   public class Cls_Controlador_Cheques
    {
        //Cls_Conexion_Cheque cn = new Cls_Conexion_Cheque();
        // Instancia del modelo para acceder a los metodos
        Cls_Sentencia_Cheque sn = new Cls_Sentencia_Cheque();


        //ejemplo de como podrian venir las nominas


        // Mientras Nómina esté vacía, simulamos datos
        public List<Empleado> ObtenerEmpleadosSimulados()
        {
            return new List<Empleado>
            {
                new Empleado { NumeroCheque = 1001, Nombre = "Ana Pérez", MontoPagar = 2500 },
                new Empleado { NumeroCheque = 1002, Nombre = "Luis López", MontoPagar = 3200 },
                new Empleado { NumeroCheque = 1003, Nombre = "María Gómez", MontoPagar = 2800 }
            };
        }

        // Crear lote
        public int CrearLote(string usuario)
        {
            return sn.InsertarLote(usuario);
        }


        // 🔹 Generar todos los cheques
        public bool GenerarChequesCompletos(string usuario, int idLote, int idBanco, List<Empleado> empleados)
        {
            try
            {
                foreach (var emp in empleados)
                {
                    sn.InsertarCheque(idLote, emp.NumeroCheque, emp.Nombre, emp.MontoPagar, idBanco);
                }

                sn.ActualizarTotal(idLote);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error GenerarChequesCompletos: " + ex.Message);
                return false;
            }
        }
        public DataTable CargarCuentasBancarias()
        {
            return sn.ObtenerCuentasBancarias();
        }

        public DataTable ObtenerListaBancos()
        {
            return sn.ObtenerBancosContabilidad();
        }

        public bool ProbarInsertCheque()
        {
            return sn.InsertarChequePrueba();
        }
        public DataTable ObtenerLotes()
        {
            return sn.ObtenerLotes();
        }

    }
}
