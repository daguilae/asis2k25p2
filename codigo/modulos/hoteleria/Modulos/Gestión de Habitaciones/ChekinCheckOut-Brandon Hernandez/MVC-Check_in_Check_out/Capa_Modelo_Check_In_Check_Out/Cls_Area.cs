using System;


namespace Capa_Modelo_Check_In_Check_Out
{
    public class Cls_Area
    {
        public int iPk_Id_Area { get; set; }
        public int iFk_Id_Folio { get; set; }
        public string sCmp_Nombre_Area { get; set; }
        public string sCmp_Descripcion { get; set; }
        public string sCmp_Tipo_Movimiento { get; set; }
        public decimal dCmp_Monto { get; set; }
        public DateTime dCmp_Fecha_Movimiento { get; set; }

        public Cls_Area() { }

        public Cls_Area(int iPkIdArea, int iFkIdFolio, string sNombre, string sDescripcion, string sTipoMov, decimal dMonto, DateTime dFecha)
        {
            this.iPk_Id_Area = iPkIdArea;
            this.iFk_Id_Folio = iFkIdFolio;
            this.sCmp_Nombre_Area = sNombre;
            this.sCmp_Descripcion = sDescripcion;
            this.sCmp_Tipo_Movimiento = sTipoMov;
            this.dCmp_Monto = dMonto;
            this.dCmp_Fecha_Movimiento = dFecha;
        }
    }
}
