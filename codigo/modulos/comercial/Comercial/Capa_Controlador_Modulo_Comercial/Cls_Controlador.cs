using System.Collections.Generic;
using System.ComponentModel;

namespace Capa_Controlador_Modulo_Comercial
{
    // Juan Carlos Sandoval Quej 0901-22-4170 25/10/2025
    public class Cls_Controlador
    {
        private class LineaInterna
        {
            public string CodigoProducto { get; set; }
            public string DescripcionProducto { get; set; }
            public decimal Cantidad { get; set; }
            public decimal CostoUnitario { get; set; }
            public decimal PrecioUnitario { get; set; }

            public decimal TotalCosto => Cantidad * CostoUnitario;
            public decimal TotalPrecio => Cantidad * PrecioUnitario;
        }

        // Lista en memoria de las líneas ingresadas
        private BindingList<LineaInterna> _lineas;

        public Cls_Controlador()
        {
            _lineas = new BindingList<LineaInterna>();
        }

        // Agregar una nueva línea y devolver datos listos para ingresar en el grid
        public (string codigo,
                string descripcion,
                decimal cantidad,
                decimal totalCosto,
                decimal totalPrecio)
            AgregarLinea(
                string codigo,
                string medida,
                decimal cantidad,
                decimal costoUnitario,
                decimal precioUnitario
            )
        {
            var nueva = new LineaInterna
            {
                CodigoProducto = codigo,
                DescripcionProducto = $"Prod {codigo} ({medida})",
                Cantidad = cantidad,
                CostoUnitario = costoUnitario,
                PrecioUnitario = precioUnitario
            };

            _lineas.Add(nueva);

            return (
                nueva.CodigoProducto,
                nueva.DescripcionProducto,
                nueva.Cantidad,
                nueva.TotalCosto,
                nueva.TotalPrecio
            );
        }

        // Quitar una línea según índice
        public void QuitarLinea(int index)
        {
            if (index >= 0 && index < _lineas.Count)
            {
                _lineas.RemoveAt(index);
            }
        }

        public List<(string Codigo,
                     string Descripcion,
                     decimal Cantidad,
                     decimal CostoUnitario,
                     decimal PrecioUnitario,
                     decimal TotalCosto,
                     decimal TotalPrecio)>
            ObtenerLineas()
        {
            var result = new List<(string, string, decimal, decimal, decimal, decimal, decimal)>();
            foreach (var l in _lineas)
            {
                result.Add((
                    l.CodigoProducto,
                    l.DescripcionProducto,
                    l.Cantidad,
                    l.CostoUnitario,
                    l.PrecioUnitario,
                    l.TotalCosto,
                    l.TotalPrecio
                ));
            }
            return result;
        }
    }
}
