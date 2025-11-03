using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Controldor_MB
{
    public static class Cls_OperacionReglas
    {
        public static bool RequiereCuentaDestino(string nombreOperacion)
        {
            if (string.IsNullOrWhiteSpace(nombreOperacion)) return false;
            var n = nombreOperacion.Trim().ToUpperInvariant().Replace("_", " ").Replace("-", " ");
            return n.Contains("TRANSFERENCIA ENVIADA") || n.Contains("TRANSFERENCIA RECIBIDA");
        }

        public static string NormalizarSigno(string s) => (s == "+" || s == "-") ? s : null;
    }

}
