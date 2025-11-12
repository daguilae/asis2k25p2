using System;


namespace Capa_Modelo_Check_In_Check_Out
{
    public class Cls_CheckIn
    {
        public int iPk_Id_CheckIn { get; set; }
        public int iFk_Id_Huesped { get; set; }
        public int iFk_Id_Reserva { get; set; }
        public DateTime dCmp_Fecha_CheckIn { get; set; }
        public string sCmp_Estado { get; set; }

     
        public Cls_CheckIn() { }

  
        public Cls_CheckIn(int iPkIdCheckIn, int iFkIdHuesped, int iFkIdReserva, DateTime dCmpFechaCheckIn, string sCmpEstado)
        {
            this.iPk_Id_CheckIn = iPkIdCheckIn;
            this.iFk_Id_Huesped = iFkIdHuesped;
            this.iFk_Id_Reserva = iFkIdReserva;
            this.dCmp_Fecha_CheckIn = dCmpFechaCheckIn;
            this.sCmp_Estado = sCmpEstado;
        }
    }
}
