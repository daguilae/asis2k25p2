using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Controlador_IE
{
    public class Cls_Conversion_Unidad
    {
        // Unidades equivalentes
        private static readonly Dictionary<string, string> normalizacionUnidades
            = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            // MASA
            { "kg", "kg" },
            { "kgs", "kg" },
            { "kilogramo", "kg" },
            { "kilogramos", "kg" },
            { "kilo", "kg" },
            { "kilos", "kg" },

            { "g", "g" },
            { "gr", "g" },
            { "gramo", "g" },
            { "gramos", "g" },

            { "lb", "lb" },
            { "libras", "lb" },
            { "libra", "lb" },

            { "oz", "oz" },
            { "onza", "oz" },
            { "onzas", "oz" },

            // VOLUMEN
            { "l", "l" },
            { "lt", "l" },
            { "litro", "l" },
            { "litros", "l" },

            { "ml", "ml" },
            { "ml.", "ml" },
            { "mililitro", "ml" },
            { "mililitros", "ml" },

            { "taza", "cup" },
            { "tazas", "cup" },
            { "cup", "cup" },

            { "cucharada", "tbsp" },
            { "cucharadas", "tbsp" },
            { "tbsp", "tbsp" },

            { "cucharadita", "tsp" },
            { "cucharaditas", "tsp" },
            { "tsp", "tsp" },
        };

        // Datos de Conversiones
        private static readonly Dictionary<(string, string), double> conversiones
            = new Dictionary<(string, string), double>
        {
            // MASA
            { ("kg", "g"), 1000.0 },
            { ("g", "kg"), 1.0 / 1000.0 },

            { ("lb", "g"), 453.592 },
            { ("g", "lb"), 1.0 / 453.592 },

            { ("oz", "g"), 28.35 },
            { ("g", "oz"), 1.0 / 28.35 },

            // VOLUMEN
            { ("l", "ml"), 1000.0 },
            { ("ml", "l"), 1.0 / 1000.0 },

            { ("cup", "ml"), 240.0 },
            { ("ml", "cup"), 1.0 / 240.0 },

            { ("tbsp", "ml"), 15.0 },
            { ("ml", "tbsp"), 1.0 / 15.0 },

            { ("tsp", "ml"), 5.0 },
            { ("ml", "tsp"), 1.0 / 5.0 },

            { ("cup", "tbsp"), 16.0 },
            { ("tbsp", "cup"), 1.0 / 16.0 },

            { ("tbsp", "tsp"), 3.0 },
            { ("tsp", "tbsp"), 1.0 / 3.0 },
        };


        // Proceso de estandarizar la unidad
        public static string Normalizar(string sUnidad)
        {
            if (sUnidad == null)
                throw new Exception("Unidad es nula");

            // Filtro para quitar espacios y convertirlo a minusculas
            string sUnidadM = sUnidad.Trim().ToLowerInvariant();

            // Filtro para eliminar parentesis
            int iCaracter = sUnidadM.IndexOf('(');
            if (iCaracter >= 0)
            {
                int iCaracterCierra = sUnidadM.IndexOf(')', iCaracter + 1);
                if (iCaracterCierra > iCaracter)
                    sUnidadM = (sUnidadM.Substring(0, iCaracter) + " " + sUnidadM.Substring(iCaracterCierra + 1)).Trim();
            }

            // Filtro para eliminar puntos, comas y caracteres extras
            sUnidadM = sUnidadM.Replace(".", "").Replace(",", "").Replace("/", " ").Replace("-", " ").Trim();

            // Filtro para quitar múltiples espacios
            while (sUnidadM.Contains("  ")) sUnidadM = sUnidadM.Replace("  ", " ");

            // Comprobar la unidad en el diccionario
            if (normalizacionUnidades.TryGetValue(sUnidadM, out string sUnidadNormalizada))
                return sUnidadNormalizada;

            throw new Exception($"No se reconoce la unidad : '{sUnidad}' -> '{sUnidadM}'");
        }


        public static double Convertir(double doCantidad, string sUnidadOrigen, string sUnidadDestino)
        {
            string sUOrigen = Normalizar(sUnidadOrigen);
            string sUDestino = Normalizar(sUnidadDestino);


            if (sUOrigen == sUDestino)
                return doCantidad;

            if (conversiones.TryGetValue((sUOrigen, sUDestino), out double doFactor))
            {
                double doResultado = doCantidad * doFactor;
                return doResultado;
            }

            throw new Exception($"No existe conversión de {sUnidadOrigen} -> {sUnidadDestino} (normalizados {sUOrigen}->{sUDestino})");
        }

    }
}

