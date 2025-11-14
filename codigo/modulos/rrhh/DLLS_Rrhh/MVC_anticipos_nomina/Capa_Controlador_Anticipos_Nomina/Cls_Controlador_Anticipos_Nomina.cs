using System;
using System.Data;
using Capa_Modelo_Anticipos_Nomina;
// CARLO ANDREE BARQUERO BOCHE 0901-22-601  29-11-2025



namespace Capa_Controlador_Anticipos_Nomina
{
    public class Cls_Controlador_Anticipos_Nomina
    {
        private readonly Cls_Dao_Anticipos_Nomina dao = new Cls_Dao_Anticipos_Nomina();

        public DataTable funObtenerEmpleados()
        {
            return dao.funObtenerEmpleados();
        }

        public DataTable funObtenerAnticiposPorEmpleado(int idEmpleado)
        {
            return dao.funObtenerAnticiposPorEmpleado(idEmpleado);
        }

        public void funInsertarAnticipo(int idEmpleado, decimal monto, DateTime fecha, string motivo, decimal saldoPendiente)
        {
            dao.funInsertarAnticipo(idEmpleado, monto, fecha, motivo, saldoPendiente);
        }

        public void EditarAnticipo(int idAnticipo, int idEmpleado, decimal monto, DateTime fecha, string motivo, decimal saldoPendiente)
        {
            dao.funEditarAnticipo(idAnticipo, idEmpleado, monto, fecha, motivo, saldoPendiente);
        }

        public void EliminarAnticipo(int idAnticipo)
        {
            dao.funEliminarAnticipo(idAnticipo);
        }


    }
}
