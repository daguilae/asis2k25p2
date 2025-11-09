using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_Poliza;
using System.Data;


namespace Capa_Controlador_Poliza
{
    //========================== Kevin Natareno 0901-21-635 : Controlador Poliza, 26/10/2025 ===================================================
    public class Cls_Poliza_Controlador
    {
        Cls_DAO_Poliza modelo = new Cls_DAO_Poliza();

        public DataTable ObtenerMovimientosFiltrados(int banco, string tipo, int docIni, int docFin, DateTime fechaIni, DateTime fechaFin)
        {
            return modelo.ObtenerMovimientos(banco, tipo, docIni, docFin, fechaIni, fechaFin);
        }

        // Crea una póliza y la envía a Contabilidad
        public void CrearPolizaDesdeFiltros(int banco, string tipo, int docIni, int docFin,
                                            DateTime fechaIni, DateTime fechaFin,
                                            DateTime fechaPoliza, string concepto)
        {
            var movimientos = modelo.ObtenerMovimientos(banco, tipo, docIni, docFin, fechaIni, fechaFin);

            if (movimientos.Rows.Count == 0)
                throw new Exception("No se encontraron movimientos bancarios con los filtros especificados.");

            var detalles = new List<(string cuenta, bool tipo, decimal valor)>();

            foreach (DataRow mov in movimientos.Rows)
            {
                string cuenta = mov["Fk_Id_CuentaContable"].ToString();
                bool tipoCargo = mov["Cmp_TipoOperacion"].ToString() == "D"; // D = Cargo
                decimal valor = Convert.ToDecimal(mov["Cmp_Valor"]);

                detalles.Add((cuenta, tipoCargo, valor));
            }

            modelo.GenerarPoliza(fechaPoliza, concepto, detalles);
        }

        public DataTable CargarBancos()
        {
            return modelo.ObtenerBancos();
        }

        public DataTable CargarTipos()
        {
            return modelo.ObtenerTipos();
        }

        public (int min, int max) ObtenerDocumentos(int banco, int tipo)
        {
            return modelo.ObtenerRangoDocumentos(banco, tipo);
        }

        public (DateTime min, DateTime max) ObtenerFechas(int banco, int tipo)
        {
            return modelo.ObtenerRangoFechas(banco, tipo);
        }

    }
}
