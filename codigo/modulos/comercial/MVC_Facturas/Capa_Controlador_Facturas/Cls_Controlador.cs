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
    // Juan Carlos Sandoval Quej 0901-22-4170 12/11/2025
    public partial class Cls_Controlador
    {
        // Evento global para avisar cuando se guarda una factura en BD.
        // Pasa: idFactura (Tbl_Factura) y idVenta (Tbl_Venta).
        public static event Action<int, int> FacturaGuardada;

        // Acceso al modelo (sentencias ODBC / consultas)
        private readonly Cls_Sentencias _mdl = new Cls_Sentencias();

 
        // ESTADO DE LA VENTA 
 
        public class Linea
        {
            public string Codigo { get; set; }   // Código del producto
            public string Producto { get; set; } // Nombre del producto
            public decimal Precio { get; set; }  // Precio unitario
            public int Cantidad { get; set; }    // Cantidad en la venta
            public decimal Total => Precio * Cantidad; // Subtotal de la línea
        }

        // Lista enlazable al DataGridView (soporta notificaciones)
        public BindingList<Linea> Lineas { get; } = new BindingList<Linea>();


        // FACTURAS LOCALES (persistidas en archivo XML)
  
        [Serializable]
        public sealed class FacturaLocal
        {
            public int Numero { get; set; }       // Correlativo local (no BD)
            public int IdVenta { get; set; }      // Id de Tbl_Venta en BD
            public string TipoDoc { get; set; }   // NIT o CF
            public string Documento { get; set; } // Valor del NIT o "CF"
            public string Nombre { get; set; }    // Nombres del cliente
            public string Apellido { get; set; }  // Apellidos del cliente
            public DateTime Fecha { get; set; }   // Fecha de la factura
            public decimal Total { get; set; }    // Total de la factura

            // Detalle en DataTable solo para pantalla (no se serializa)
            [XmlIgnore]
            public DataTable Detalle { get; set; }

            // Detalle en lista plana para guardar en XML (sí se serializa)
            public List<LineaDet> DetallePlano { get; set; } = new List<LineaDet>();

            // Campo calculado para mostrar cliente (no afecta archivo)
            [XmlIgnore]
            public string Cliente => $"{Nombre} {Apellido}".Trim();

            // Convierte lista plana a DataTable (uso en UI)
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

            // Convierte DataTable a lista plana (para guardar)
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

        // Estructura simple para una línea del detalle local
        [Serializable]
        public sealed class LineaDet
        {
            public string Codigo { get; set; }
            public string Producto { get; set; }
            public int Cantidad { get; set; }
            public decimal Precio { get; set; }
            public decimal Subtotal => Precio * Cantidad;
        }

        // Rutas del archivo XML
        private static readonly string _carpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
        private static readonly string _archivo = Path.Combine(_carpeta, "facturas-local.xml");

        // Copia cruda y lista enlazada para la UI
        private static List<FacturaLocal> _facturas;
        public static BindingList<FacturaLocal> Facturas { get; private set; }

        private static bool _cargado; // Bandera de carga única por proceso

 
        // GUARDAR ARCHIVO XML
        private static void GuardarArchivo()
        {
            // Asegura que la carpeta exista
            Directory.CreateDirectory(_carpeta);

            // Si faltan los detalles planos, los genera desde el DataTable
            foreach (var f in _facturas)
            {
                if ((f.DetallePlano == null || f.DetallePlano.Count == 0) && f.Detalle != null)
                    f.DetallePlano = FacturaLocal.FromDataTable(f.Detalle);
            }

            // Serializa la lista completa al archivo XML
            var xs = new XmlSerializer(typeof(List<FacturaLocal>));
            using (var fs = File.Create(_archivo))
                xs.Serialize(fs, _facturas);
        }

        // CARGAR ARCHIVO XML
        private static void CargarArchivo()
        {
            Directory.CreateDirectory(_carpeta);

            // Si aún no existe el archivo, inicia vacío
            if (!File.Exists(_archivo))
            {
                _facturas = new List<FacturaLocal>();
                return;
            }

            // Deserializa desde el archivo
            var xs = new XmlSerializer(typeof(List<FacturaLocal>));
            using (var fs = File.OpenRead(_archivo))
                _facturas = (List<FacturaLocal>)xs.Deserialize(fs);

            // Reconstruye DataTable para usar en pantalla
            foreach (var f in _facturas)
                f.Detalle = FacturaLocal.ToDataTable(f.DetallePlano);
        }

        // Carga la lista de facturas en memoria una sola vez y
        // conecta el guardado automático cuando cambie la lista.
        public static void AsegurarCarga()
        {
            if (_cargado) return;

            CargarArchivo();
            Facturas = new BindingList<FacturaLocal>(_facturas);

            // Cada cambio en la lista dispara guardado a disco
            Facturas.ListChanged += (s, e) =>
            {
                _facturas = Facturas.ToList();
                GuardarArchivo();
            };

            _cargado = true;
        }

        // Devuelve el siguiente correlativo local
        public static int SiguienteNumeroFactura()
        {
            AsegurarCarga();
            return Facturas.Count == 0 ? 1 : Facturas.Max(f => f.Numero) + 1;
        }

   
        // Crea una factura local, agrega a la lista y retorna su número.
        public static int CrearFacturaLocal(
            int idVenta, string tipoDoc, string documento,
            string nombre, string apellido, DateTime fecha,
            IEnumerable<Linea> detalleUI, decimal total)
        {
            AsegurarCarga();

            int nuevoNumero = SiguienteNumeroFactura();

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
                plano.Add(new LineaDet
                {
                    Codigo = l.Codigo,
                    Producto = l.Producto,
                    Cantidad = l.Cantidad,
                    Precio = l.Precio
                });
            }

            // Construye la factura local y la agrega a la lista enlazada
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

            Facturas.Add(fac);
            return nuevoNumero;
        }

        // Busca una factura local por su número
        public static FacturaLocal ObtenerFacturaLocal(int numero)
        {
            AsegurarCarga();
            return Facturas.FirstOrDefault(f => f.Numero == numero);
        }

        // Arma un DataTable para listar facturas locales, con filtro opcional
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

            // Aplica filtro por nombre, apellido, documento o número
            if (!string.IsNullOrWhiteSpace(filtro))
            {
                filtro = filtro.Trim().ToUpperInvariant();
                src = src.Where(f =>
                    (f.Nombre ?? "").ToUpperInvariant().Contains(filtro) ||
                    (f.Apellido ?? "").ToUpperInvariant().Contains(filtro) ||
                    (f.Documento ?? "").ToUpperInvariant().Contains(filtro) ||
                    f.Numero.ToString().Contains(filtro));
            }

            // Llena el DataTable ordenado por número descendente
            foreach (var f in src.OrderByDescending(x => x.Numero))
                dt.Rows.Add(f.Numero, f.Cliente, f.Documento, f.Fecha, f.Total);

            return dt;
        }

     
        // CATÁLOGOS / CONSULTAS A BD
    
        public DataTable ObtenerProductos() => _mdl.ObtenerProductosDT();

 
        // OPERACIONES 

        public void AgregarLinea(string codigo, string nombre, decimal precio, int cantidad)
        {
            if (cantidad <= 0) return;

            // Si ya existe la línea con ese código, solo suma la cantidad
            var ex = Lineas.FirstOrDefault(l => l.Codigo == codigo);
            if (ex != null)
            {
                ex.Cantidad += cantidad;
                Lineas.ResetItem(Lineas.IndexOf(ex)); // Notifica al grid
            }
            else
            {
                Lineas.Add(new Linea
                { Codigo = codigo, Producto = nombre, Precio = precio, Cantidad = cantidad });
            }
        }

        public void EliminarLinea(int index)
        {
            if (index >= 0 && index < Lineas.Count) Lineas.RemoveAt(index);
        }

        public decimal TotalVenta() => Lineas.Sum(l => l.Total);           // Suma subtotales
        public decimal Devolucion(decimal efectivo) => efectivo - TotalVenta(); // Efectivo - Total
        public void Limpiar() => Lineas.Clear();                            // Limpia la lista

 
        // PERSISTENCIA REAL: GUARDAR VENTA EN LA BD
        public int GuardarVenta(decimal efectivo, int? idUsuario, int? idMetodoPago)
        {
            if (Lineas.Count == 0) throw new Exception("No hay productos en la venta.");

            // Convierte líneas de la UI al DTO usado por el modelo
            var dto = Lineas.Select(l => new Cls_Sentencias.LineaVentaDTO
            {
                CodigoProducto = l.Codigo,
                PrecioUnitario = l.Precio,
                Cantidad = l.Cantidad
            }).ToList();

            var total = TotalVenta();
            var dev = Devolucion(efectivo);

            // Inserta venta + detalles (transacción) y devuelve IdVenta
            return _mdl.GuardarVentaConDetalles(total, efectivo, dev, idUsuario, idMetodoPago, dto);
        }

        // Listado de facturas (vista en BD)
        public DataTable ListadoFacturas() => _mdl.ListadoFacturasDT();

    
        // Devuelve el detalle de una venta (vista Vw_Venta_Detalle) para el formulario de detalle.
   
        public DataTable DetallePorVenta(int idVenta) => _mdl.DetalleFacturaPorVenta(idVenta);
    }
}
