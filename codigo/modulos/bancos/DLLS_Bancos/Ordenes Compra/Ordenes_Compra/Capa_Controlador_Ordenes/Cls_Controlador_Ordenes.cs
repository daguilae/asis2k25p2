using System;
using System.Data;
using Capa_Modelo_Ordenes;

namespace Capa_Controlador_Ordenes
{


    // Inicio de código de María Alejandra Morales García con carné: 0901-22-1226 con la dFecha de: 07/11/2025

    public class Cls_Controlador_Ordenes
    {
        private readonly Cls_Sentencias_Ordenes _m = new Cls_Sentencias_Ordenes();

        // Listas
        public DataTable ObtenerOrdenes() => _m.fun_obtener_ordenes();
        public DataTable ObtenerBancos() => _m.fun_obtener_bancos();
        public DataTable ObtenerEmpleados() => _m.fun_obtener_empleados();
        public DataTable ObtenerEstados() => _m.fun_obtener_estados();


        // Inicio de código de María Alejandra Morales García con carné: 0901-22-1226 con la dFecha de: 09/11/2025

        //Obtener los deMontos del saldo y de la orden de compra
        public decimal fun_obtener_deMonto_orden(int iOrden) => _m.fun_obtener_deMonto_orden(iOrden);
        public decimal ObtenerSaldoBanco(int iBanco) => _m.fun_obtener_saldo_banco(iBanco);

        // Fin de código de María Alejandra Morales García con carné: 0901-22-1226 con la dFecha de: 09/11/2025


        // Grid
        public DataTable ObtenerAutorizacionesDetalle() => _m.fun_obtener_autorizaciones_detalle();

        // CRUD
        public int Agregar(int iOrden, int iBanco, int? iEmpleado, DateTime dFecha, decimal deMonto, int iEstado, string sObserv)
            => _m.proc_insertar_autorizacion(iOrden, iBanco, iEmpleado, dFecha, deMonto, iEstado, sObserv);

        public int Actualizar(int idAut, int iOrden, int iBanco, int? iEmpleado, DateTime dFecha, decimal deMonto, int iEstado, string sObserv)
            => _m.proc_actualizar_autorizacion(idAut, iOrden, iBanco, iEmpleado, dFecha, deMonto, iEstado, sObserv);

        public int Eliminar(int idAut) => _m.proc_eliminar_autorizacion(idAut);
    }
}


// Fin de código de María Alejandra Morales García con carné: 0901-22-1226 con la dFecha de: 07/11/2025
