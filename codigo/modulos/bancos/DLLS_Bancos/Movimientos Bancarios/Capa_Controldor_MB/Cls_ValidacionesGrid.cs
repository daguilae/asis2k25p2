using System;

namespace Capa_Controldor_MB
{
    public static class Cls_ValidacionesGrid
    {
        public static (bool esValido, decimal valor) ObtenerValorDecimalDeCelda(object valorCelda)
        {
            if (valorCelda == null || valorCelda == DBNull.Value || string.IsNullOrEmpty(valorCelda.ToString()))
                return (false, 0);

            if (decimal.TryParse(valorCelda.ToString(), out decimal valor))
                return (true, valor);

            return (false, 0);
        }
    }
}