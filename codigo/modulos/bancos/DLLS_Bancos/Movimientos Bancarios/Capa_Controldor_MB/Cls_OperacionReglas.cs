using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Controldor_MB
{
    public static class Cls_OperacionReglas
    {
        public static bool fun_requiere_cuenta_destino(string sNombre_Operacion)
        {
            if (string.IsNullOrWhiteSpace(sNombre_Operacion))
                return false;

            string sNombre_Normalizado = sNombre_Operacion
                .Trim()
                .ToUpperInvariant()
                .Replace("_", " ")
                .Replace("-", " ");

            return sNombre_Normalizado.Contains("TRANSFERENCIA ENVIADA") ||
                   sNombre_Normalizado.Contains("TRANSFERENCIA RECIBIDA");
        }

        public static string fun_normalizar_signo(string sSigno)
        {
            return (sSigno == "+" || sSigno == "-") ? sSigno : null;
        }
    }
}
