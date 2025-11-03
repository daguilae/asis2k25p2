using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace Capa_Modelo_CPR
{
    public class Cls_Cierre_Produccion
    {
        // ==============================
        // Propiedades (campos principales)
        // ==============================
        public int iPkIdCierre { get; set; }
        public DateTime dFechaCierre { get; set; }
        public decimal deTotalIngresos { get; set; }
        public decimal deTotalEgresos { get; set; }
        public decimal deCierreTotal { get; set; }
        public string sDescripcionCierre { get; set; }
        public int iFkIdTipoCierre { get; set; }

        // ==============================
        // Constructores
        // ==============================
        public Cls_Cierre_Produccion() { }

        public Cls_Cierre_Produccion(
            int iPkIdCierre,
            DateTime dFechaCierre,
            decimal dTotalIngresos,
            decimal dTotalEgresos,
            decimal dCierreTotal,
            string sDescripcionCierre,
            int iFkIdTipoCierre
        )
        {
            this.iPkIdCierre = iPkIdCierre;
            this.dFechaCierre = dFechaCierre;
            this.deTotalIngresos = dTotalIngresos;
            this.deTotalEgresos = dTotalEgresos;
            this.deCierreTotal = dCierreTotal;
            this.sDescripcionCierre = sDescripcionCierre;
            this.iFkIdTipoCierre = iFkIdTipoCierre;
        }


    }
}
