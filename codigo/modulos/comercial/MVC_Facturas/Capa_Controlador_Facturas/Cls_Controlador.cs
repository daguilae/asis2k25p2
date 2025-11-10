// Capa_Controlador_Facturas/Cls_Controlador.cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using Capa_Modelo_Facturas;

namespace Capa_Controlador_Facturas
{
    // Juan Carlos Sandoval Quej 0901-22-4170 09/11/2025

    public class Cls_Controlador
    {
        private readonly Cls_Sentencias _mdl = new Cls_Sentencias();

        // ===== estado de la venta  =====
        public class Linea
        {
            public string Codigo { get; set; }
            public string Producto { get; set; }
            public decimal Precio { get; set; }
            public int Cantidad { get; set; }
            public decimal Total => Precio * Cantidad;
        }
        public BindingList<Linea> Lineas { get; } = new BindingList<Linea>();

        // ====== FACTURAS LOCALES (persistencia XML) ======
        [Serializable]
        public sealed class FacturaLocal
        {
            public int Numero { get; set; }          // correlativo local
            public int IdVenta { get; set; }         // venta guardada en BD
            public string TipoDoc { get; set; }      // NIT / CF
            public string Documento { get; set; }    // NIT o "CF"
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public DateTime Fecha { get; set; }
            public decimal Total { get; set; }

            // ---- Detalles ----
            [XmlIgnore]
            public DataTable Detalle { get; set; }

            // ---- Detalle plano para persistir (sí serializable) ----
            public List<LineaDet> DetallePlano { get; set; } = new List<LineaDet>();

            [XmlIgnore]
            public string Cliente => $"{Nombre} {Apellido}".Trim();

            // Conversión auxiliar
            public static DataTable ToDataTable(IEnumerable<LineaDet> src)
            {
                var dt = new DataTable();
                dt.Columns.Add("Codigo", typeof(string));
                dt.Columns.Add("Producto", typeof(string));
                dt.Columns.Add("Cantidad", typeof(int));
                dt.Columns.Add("Precio", typeof(decimal));
                dt.Columns.Add("Subtotal", typeof(decimal));

                if (src != null)
                {
                    foreach (var l in src)
                        dt.Rows.Add(l.Codigo, l.Producto, l.Cantidad, l.Precio, l.Subtotal);
                }
                return dt;
            }

            public static List<LineaDet> FromDataTable(DataTable dt)
            {
                var list = new List<LineaDet>();
                if (dt == null) return list;

                foreach (DataRow r in dt.Rows)
                {
                    list.Add(new LineaDet
                    {
                        Codigo = Convert.ToString(r["Codigo"]),
                        Producto = Convert.ToString(r["Producto"]),
                        Cantidad = Convert.ToInt32(r["Cantidad"]),
                        Precio = Convert.ToDecimal(r["Precio"]),
                    });
                }
                return list;
            }
        }

        [Serializable]
        public sealed class LineaDet
        {
            public string Codigo { get; set; }
            public string Producto { get; set; }
            public int Cantidad { get; set; }
            public decimal Precio { get; set; }
            public decimal Subtotal => Precio * Cantidad;
        }

        private static readonly string _carpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
        private static readonly string _archivo = Path.Combine(_carpeta, "facturas-local.xml");

        private static List<FacturaLocal> _facturas;               // respaldo crudo
        public static BindingList<FacturaLocal> Facturas { get; private set; } // data-bind

        private static bool _cargado;

        // ==== Persistencia XML (sin paquetes externos) ====
        private static void GuardarArchivo()
        {
            Directory.CreateDirectory(_carpeta);

            // Aseguramos que todas tengan su DetallePlano listo
            foreach (var f in _facturas)
            {
                if ((f.DetallePlano == null || f.DetallePlano.Count == 0) && f.Detalle != null)
                    f.DetallePlano = FacturaLocal.FromDataTable(f.Detalle);
            }

            var xs = new XmlSerializer(typeof(List<FacturaLocal>));
            using (var fs = File.Create(_archivo))
                xs.Serialize(fs, _facturas);
        }

        private static void CargarArchivo()
        {
            Directory.CreateDirectory(_carpeta);
            if (!File.Exists(_archivo))
            {
                _facturas = new List<FacturaLocal>();
                return;
            }

            var xs = new XmlSerializer(typeof(List<FacturaLocal>));
            using (var fs = File.OpenRead(_archivo))
                _facturas = (List<FacturaLocal>)xs.Deserialize(fs);

            // Reconstruimos los DataTable para la UI
            foreach (var f in _facturas)
                f.Detalle = FacturaLocal.ToDataTable(f.DetallePlano);
        }

        /// Garantiza que las facturas estén cargadas a memoria (una vez por proceso).</summary>
        public static void AsegurarCarga()
        {
            if (_cargado) return;

            CargarArchivo();
            Facturas = new BindingList<FacturaLocal>(_facturas);

            // Cualquier cambio en el BindingList dispara guardado a disco
            Facturas.ListChanged += (s, e) =>
            {
                _facturas = Facturas.ToList();
                GuardarArchivo();
            };

            _cargado = true;
        }

        public static int SiguienteNumeroFactura()
        {
            AsegurarCarga();
            return Facturas.Count == 0 ? 1 : Facturas.Max(f => f.Numero) + 1;
        }

        /// Crea y guarda una factura local (en XML) y devuelve su número.</summary>
        public static int CrearFacturaLocal(
            int idVenta, string tipoDoc, string documento,
            string nombre, string apellido, DateTime fecha,
            IEnumerable<Linea> detalleUI, decimal total)
        {
            AsegurarCarga();

            int nuevoNumero = SiguienteNumeroFactura();

            // Construimos DataTable (UI) y lista plana (persistencia)
            var dt = new DataTable();
            dt.Columns.Add("Codigo", typeof(string));
            dt.Columns.Add("Producto", typeof(string));
            dt.Columns.Add("Cantidad", typeof(int));
            dt.Columns.Add("Precio", typeof(decimal));
            dt.Columns.Add("Subtotal", typeof(decimal));

            var plano = new List<LineaDet>();
            foreach (var l in detalleUI ?? Enumerable.Empty<Linea>())
            {
                dt.Rows.Add(l.Codigo, l.Producto, l.Cantidad, l.Precio, l.Total);
                plano.Add(new LineaDet { Codigo = l.Codigo, Producto = l.Producto, Cantidad = l.Cantidad, Precio = l.Precio });
            }

            var fac = new FacturaLocal
            {
                Numero = nuevoNumero,
                IdVenta = idVenta,
                TipoDoc = tipoDoc,
                Documento = documento,
                Nombre = nombre,
                Apellido = apellido,
                Fecha = fecha,
                Total = total,
                Detalle = dt,
                DetallePlano = plano
            };

            Facturas.Add(fac);   // esto a su vez guarda en disco por el ListChanged
            return nuevoNumero;
        }

        public static FacturaLocal ObtenerFacturaLocal(int numero)
        {
            AsegurarCarga();
            return Facturas.FirstOrDefault(f => f.Numero == numero);
        }

        public static DataTable ListadoFacturasLocal(string filtro = "")
        {
            AsegurarCarga();

            var dt = new DataTable();
            dt.Columns.Add("Numero", typeof(int));
            dt.Columns.Add("Cliente", typeof(string));
            dt.Columns.Add("Documento", typeof(string));
            dt.Columns.Add("Fecha", typeof(DateTime));
            dt.Columns.Add("Total", typeof(decimal));

            IEnumerable<FacturaLocal> src = Facturas;
            if (!string.IsNullOrWhiteSpace(filtro))
            {
                filtro = filtro.Trim().ToUpperInvariant();
                src = src.Where(f =>
                    (f.Nombre ?? "").ToUpperInvariant().Contains(filtro) ||
                    (f.Apellido ?? "").ToUpperInvariant().Contains(filtro) ||
                    (f.Documento ?? "").ToUpperInvariant().Contains(filtro) ||
                    f.Numero.ToString().Contains(filtro));
            }

            foreach (var f in src.OrderByDescending(x => x.Numero))
                dt.Rows.Add(f.Numero, f.Cliente, f.Documento, f.Fecha, f.Total);

            return dt;
        }

        // ===== catálogos / consultas BD =====
        public DataTable ObtenerProductos() => _mdl.ObtenerProductosDT();

        // ===== operaciones de líneas (UI) =====
        public void AgregarLinea(string codigo, string nombre, decimal precio, int cantidad)
        {
            if (cantidad <= 0) return;
            var ex = Lineas.FirstOrDefault(l => l.Codigo == codigo);
            if (ex != null)
            {
                ex.Cantidad += cantidad;
                Lineas.ResetItem(Lineas.IndexOf(ex));
            }
            else
            {
                Lineas.Add(new Linea { Codigo = codigo, Producto = nombre, Precio = precio, Cantidad = cantidad });
            }
        }
        public void EliminarLinea(int index)
        {
            if (index >= 0 && index < Lineas.Count) Lineas.RemoveAt(index);
        }
        public decimal TotalVenta() => Lineas.Sum(l => l.Total);
        public decimal Devolucion(decimal efectivo) => efectivo - TotalVenta();
        public void Limpiar() => Lineas.Clear();

        // ===== persistencia real: SOLO VENTAS EN BD =====
        public int GuardarVenta(decimal efectivo, int? idUsuario, int? idMetodoPago)
        {
            if (Lineas.Count == 0) throw new Exception("No hay productos en la venta.");

            var dto = Lineas.Select(l => new Cls_Sentencias.LineaVentaDTO
            {
                CodigoProducto = l.Codigo,
                PrecioUnitario = l.Precio,
                Cantidad = l.Cantidad
            }).ToList();

            var total = TotalVenta();
            var dev = Devolucion(efectivo);

            return _mdl.GuardarVentaConDetalles(total, efectivo, dev, idUsuario, idMetodoPago, dto);
        }
    }
}
