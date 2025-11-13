using System;
using System.Data;
using Capa_Modelo_Percepciones_Nomina;

namespace Capa_Controlador_Percepciones_Nomina
{
    public class Cls_MovimientosControlador
    {
        private readonly Cls_MovimientosModelo modelo = new Cls_MovimientosModelo();

        public void proReiniciarAutoIncrementSiVacia()
        {
            modelo.proResetAutoIncrementIfEmptyMovimientos();
        }
        public int funInsertarMovimiento(int iIdNomina, int iIdEmpleado, int iIdConcepto, decimal deMonto)
        {
            return modelo.funInsertarMovimiento(iIdNomina, iIdEmpleado, iIdConcepto, deMonto);
        }

        public DataTable funMostrarMovimientosPorNomina(int iIdNomina, bool asc = true)
        {
            return modelo.funObtenerMovimientosPorNomina(iIdNomina, asc);
        }

        public void proEliminarMovimiento(int iIdMovimiento)
        {
            modelo.proEliminarMovimiento(iIdMovimiento);
        }
    }
}
