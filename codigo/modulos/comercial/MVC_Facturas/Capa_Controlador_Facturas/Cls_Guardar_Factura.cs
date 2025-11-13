using System;
using System.Data;
using System.Linq;
using Capa_Modelo_Facturas;

namespace Capa_Controlador_Facturas
{
    // Juan Carlos Sandoval Quej 0901-22-4170 11/11/2025
    public partial class Cls_Controlador
    {
        // Objeto del modelo para ejecutar las sentencias SQL
        private readonly Cls_Sentencias _mdlBD = new Cls_Sentencias();

        // Modo de persistencia (solo BD, solo XML, o ambos)
        public enum ModoFactura { SoloBD, SoloLocal, Mixta }

        // Propiedad que define cómo se guardarán las facturas
        public ModoFactura PersistenciaFactura { get; set; } = ModoFactura.SoloBD;

        // 1) GUARDAR FACTURA EN BASE DE DATOS Y NOTIFICAR EVENTO
        public int GuardarFacturaEnBD(int idVenta, string tipoDoc, string documento,
                                      string nombre, string apellido, DateTime fecha, decimal total,
                                      bool tambienLocalXml = false)
        {
            // Guarda factura en la tabla Tbl_Factura
            int idFactura = _mdlBD.GuardarFactura(idVenta, tipoDoc, documento, nombre, apellido, fecha, total);

            // Si el modo lo requiere o se pidió, también crea copia XML local
            if (tambienLocalXml || PersistenciaFactura == ModoFactura.Mixta)
                CrearFacturaLocal(idVenta, tipoDoc, documento, nombre, apellido, fecha, this.Lineas, total);

            // Notifica a quien esté suscrito (por ejemplo, el Listado de Facturas)
            FacturaGuardada?.Invoke(idFactura, idVenta);

            return idFactura;
        }

        // 2) LISTADO DE FACTURAS 
 
        public DataTable ListadoFacturasBD(string filtro = "")
        {
            // Obtiene todas las facturas desde la BD
            var dt = _mdlBD.ListadoFacturasDT();

            // Si no hay filtro, retorna todo el listado
            if (string.IsNullOrWhiteSpace(filtro)) return dt;

            // Normaliza el filtro a mayúsculas
            filtro = filtro.Trim().ToUpperInvariant();

            // Aplica filtro por nombre del cliente, documento o número de factura
            var rows = dt.AsEnumerable().Where(r =>
                   ($"{r.Field<string>("Cliente")}".ToUpperInvariant().Contains(filtro)) ||
                   ($"{r.Field<string>("Documento")}".ToUpperInvariant().Contains(filtro)) ||
                   (r.Field<int>("Numero").ToString().Contains(filtro))
            );

            // Retorna la tabla filtrada o vacía si no hay coincidencias
            return rows.Any() ? rows.CopyToDataTable() : dt.Clone();
        }

        // 3) DETALLE POR VENTA (vista Vw_Venta_Detalle)
 
        public DataTable DetallePorVentaBD(int idVenta)
            => _mdlBD.DetalleFacturaPorVenta(idVenta);

        // Alias compatible con otros formularios
        public DataTable DetalleFacturaPorVentaBD(int idVenta)
            => DetallePorVentaBD(idVenta);
    }
}
