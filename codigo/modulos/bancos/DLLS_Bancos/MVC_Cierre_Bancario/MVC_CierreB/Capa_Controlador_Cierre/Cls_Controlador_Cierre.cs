using System.Data;
using Capa_Modelo_Cierre;

namespace Capa_Controlador_Cierre
{
    //================================= KEVIN NATARENO, 0901-21-635 =================================================
    public class Cls_Controlador_Cierre
    {
        private Cls_CRUD_Cierre objCRUD = new Cls_CRUD_Cierre();

        public DataTable fun_obtener_cuentas()
        {
            return objCRUD.fun_obtener_cuentas();
        }

        public DataTable fun_obtener_cierres(int iCuenta, int iAnio, int iMes)
        {
            return objCRUD.fun_obtener_cierres(iCuenta, iAnio, iMes);
        }
        public DataTable fun_obtener_todos_cierres()
        {
            return objCRUD.fun_obtener_todos_cierres();
        }


        public void fun_guardar_cierre(
            int iCuenta,
            int iAnio,
            int iMes,
            decimal dSaldoIni,
            decimal dSaldoFin,
            decimal dSaldoConc,
            string sEstado,
            string sObs,
            string sUsuario
        )
        {
            Cls_Modelo_Cierre obj = new Cls_Modelo_Cierre();

            obj.iIdCuentaBancaria = iCuenta;
            obj.iAnioCierre = iAnio;   
            obj.iMesCierre = iMes;     
            obj.dSaldoInicial = dSaldoIni;
            obj.dSaldoFinal = dSaldoFin;
            obj.dSaldoConciliado = dSaldoConc;
            obj.sEstado = sEstado;
            obj.sObservaciones = sObs;
            obj.sUsuarioRegistro = sUsuario;

            objCRUD.fun_guardar_cierre(obj);
        }

        public void fun_cerrar_cierre(int iIdCierre, string sUsuario)
        {
            objCRUD.fun_cerrar_cierre(iIdCierre, sUsuario);
        }

        public void fun_anular_cierre(int iIdCierre, string sUsuario)
        {
            objCRUD.fun_anular_cierre(iIdCierre, sUsuario);
        }
    }
}
