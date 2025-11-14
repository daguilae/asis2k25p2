using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo_Cierre
{
   public class Cls_Modelo_Cierre
    {
        public int iIdCierre { get; set; }                     // Pk_Id_Cierre
        public int iIdCuentaBancaria { get; set; }             // Fk_Id_CuentaBancaria
        public int iAnioCierre { get; set; }                   // Cmp_AnioCierre
        public int iMesCierre { get; set; }                    // Cmp_MesCierre
        public decimal dSaldoInicial { get; set; }             // Cmp_SaldoInicial
        public decimal dSaldoFinal { get; set; }               // Cmp_SaldoFinal
        public decimal dSaldoConciliado { get; set; }          // Cmp_SaldoConciliado
        public string sEstado { get; set; }                    // Cmp_Estado
        public DateTime? dtFechaCierre { get; set; }           // Cmp_FechaCierre
        public string sObservaciones { get; set; }             // Cmp_Observaciones
        public string sUsuarioRegistro { get; set; }           // Cmp_UsuarioRegistro
        public DateTime? dtFechaRegistro { get; set; }         // Cmp_FechaRegistro
        public string sUsuarioModifico { get; set; }           // Cmp_UsuarioModifico
        public DateTime? dtFechaModificacion { get; set; }     // Cmp_FechaModificacion


    }
}
