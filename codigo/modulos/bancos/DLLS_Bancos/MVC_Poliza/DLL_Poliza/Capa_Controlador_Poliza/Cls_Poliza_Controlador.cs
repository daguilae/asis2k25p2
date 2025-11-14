using System;
using System.Collections.Generic;
using System.Data.Odbc;
using Capa_Modelo_Poliza;

namespace Capa_Controlador_Poliza
{
    public class Cls_Poliza_Controlador
    {
        private readonly Cls_DAO_Poliza dao = new Cls_DAO_Poliza();

        public OdbcDataReader ObtenerBancos() => dao.ObtenerBancos();

        public OdbcDataReader ObtenerCuentas(int idBanco) => dao.ObtenerCuentasPorBanco(idBanco);

        public OdbcDataReader ObtenerDocumentos(int idCuenta) => dao.ObtenerDocumentosPorCuenta(idCuenta);

        public int ObtenerSiguienteIdEncabezado(DateTime fecha) => dao.ObtenerSiguienteIdEncabezado(fecha);

        public void InsertarPoliza(DateTime fecha, string concepto, List<(string sCodigoCuenta, bool bTipo, decimal dValor)> detalles)
        {
            int nuevoId = dao.ObtenerSiguienteIdEncabezado(fecha);
            decimal total = 0;
            foreach (var det in detalles)
                total += det.dValor;

            dao.InsertarEncabezado(nuevoId, fecha, concepto, total);

            foreach (var det in detalles)
                dao.InsertarDetalle(nuevoId, fecha, det.sCodigoCuenta, det.bTipo, det.dValor);
        }
    }
}
