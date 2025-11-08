using System;
using System.Data;
using Capa_Modelo_Ordenes;

namespace Capa_Controlador_Ordenes
{

    // Inicio de código de María Alejandra Morales García con carné: 0901-22-1226 con la fecha de: 07/11/2025
    public class Cls_Controlador_Ordenes
    {
        private readonly Cls_Sentencias_Ordenes _m = new Cls_Sentencias_Ordenes();

        // Listas
        public DataTable ObtenerOrdenes() => _m.ObtenerOrdenes();
        public DataTable ObtenerBancos() => _m.ObtenerBancos();
        public DataTable ObtenerEmpleados() => _m.ObtenerEmpleados();
        public DataTable ObtenerEstados() => _m.ObtenerEstados();

        // Grid
        public DataTable ObtenerAutorizacionesDetalle() => _m.ObtenerAutorizacionesDetalle();

        // CRUD
        public int Agregar(int idOrden, int idBanco, int? idEmpleado, DateTime fecha, decimal monto, int idEstado, string observ)
            => _m.InsertarAutorizacion(idOrden, idBanco, idEmpleado, fecha, monto, idEstado, observ);

        public int Actualizar(int idAut, int idOrden, int idBanco, int? idEmpleado, DateTime fecha, decimal monto, int idEstado, string observ)
            => _m.ActualizarAutorizacion(idAut, idOrden, idBanco, idEmpleado, fecha, monto, idEstado, observ);

        public int Eliminar(int idAut) => _m.EliminarAutorizacion(idAut);
    }
}

// Fin de código de María Alejandra Morales García con carné: 0901-22-1226 con la fecha de: 07/11/2025
