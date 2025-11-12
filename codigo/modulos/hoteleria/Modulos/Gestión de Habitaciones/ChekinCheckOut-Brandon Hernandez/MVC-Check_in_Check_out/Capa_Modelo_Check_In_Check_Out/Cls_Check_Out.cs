using System;


namespace Capa_Modelo_Check_In_Check_Out
{
    public class Cls_Check_Out
    {
        public int iPk_Id_CheckOut { get; set; }
        public int iFk_Id_CheckIn { get; set; }
        public DateTime dCmp_Fecha_CheckOut { get; set; }

        public Cls_Check_Out()
        {

        }
        public Cls_Check_Out(int iPkIdCheckOut, int iFkIdCheckIn, DateTime dCmpFechaCheckOut)
        {
            this.iPk_Id_CheckOut = iPkIdCheckOut;
            this.iFk_Id_CheckIn = iFkIdCheckIn;
            this.dCmp_Fecha_CheckOut = dCmpFechaCheckOut;
        }
    }
}