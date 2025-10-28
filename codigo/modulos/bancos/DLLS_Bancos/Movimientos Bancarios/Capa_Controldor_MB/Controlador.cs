using System;
using System.Data;
using System.Linq;
using System.Collections.Generic;
using Capa_Modelo_MB;

namespace Capa_Controldor_MB
{
    public class Controlador
    {
        // Para llenar tablas si estás usando el método llenarTbl del modelo
        private readonly Sentencias cn = new Sentencias();
        // Acceso a BD 
        private readonly CRUD crud = new CRUD();
        // ------- Catálogos / ayudas para combos -------
        public DataTable CargarCuentas()
        {
            return crud.ObtenerCuentas();
        }

        public string ObtenerNombreCuenta(int idCuenta)
        {
            return crud.ObtenerNombreCuenta(idCuenta);
        }

        public DataTable ObtenerOperaciones()
        {
            return crud.ObtenerOperaciones();
        }

        public string ObtenerSignoOperacion(int idOperacion)
        {
            // "+" o "-"
            return crud.ObtenerSignoOperacionPorId(idOperacion);
        }

        public bool RequiereCuentaDestino(string nombreOperacion)
        {
            if (string.IsNullOrWhiteSpace(nombreOperacion))
                return false;
            // Solo habilitar para Transferencia
            return nombreOperacion.Equals("Transferencia", StringComparison.OrdinalIgnoreCase);
        }

        // ------- Validaciones de negocio -------
        // Valida encabezado + detalles. También fija el total desde los detalles.
        public (bool ok, string msg) ValidarMovimiento(
            Sentencias mov,
            List<Sentencias.MovimientoDetalle> detalles,
            string nombreOperacion)
        {
            if (mov.Fk_Id_cuenta_origen <= 0)
                return (false, "Seleccione cuenta ORIGEN.");
            if (mov.Fk_Id_operacion <= 0)
                return (false, "Seleccione la OPERACIÓN.");
            bool esTransferencia = !string.IsNullOrWhiteSpace(nombreOperacion) &&
                                   nombreOperacion.Equals("Transferencia", StringComparison.OrdinalIgnoreCase);
            if (esTransferencia && (mov.Fk_Id_cuenta_destino == null || mov.Fk_Id_cuenta_destino <= 0))
                return (false, "Para Transferencia seleccione cuenta DESTINO.");
            if (detalles == null || detalles.Count == 0)
                return (false, "Debe agregar al menos UNA línea de detalle.");
            if (detalles.Any(d => d.Cmp_Monto <= 0))
                return (false, "Todos los montos de detalle deben ser > 0.");
            decimal suma = detalles.Sum(d => d.Cmp_Monto);
            if (suma <= 0)
                return (false, "El total del movimiento debe ser > 0.");
            // Fijar total al movimiento
            mov.Cmp_valor_total = suma;
            if (string.IsNullOrWhiteSpace(mov.Cmp_estado))
                return (false, "Seleccione el ESTADO del movimiento.");
            return (true, "OK");
        }

        // ------- Guardado -------
        public int GuardarMovimiento(Sentencias mov, List<Sentencias.MovimientoDetalle> detalles)
        {
            // Llama al modelo que guarda en transacción
            return crud.CrearMovimientoConDetalles(mov, detalles);
        }

        public List<string> ValidarMovimiento(Sentencias movimiento, List<Sentencias.MovimientoDetalle> detalles)
        {
            var errores = new List<string>();
            // Validar movimiento principal
            if (movimiento.Fk_Id_cuenta_origen <= 0)
                errores.Add("La cuenta origen es requerida");
            if (movimiento.Fk_Id_operacion <= 0)
                errores.Add("La operación bancaria es requerida");
            if (movimiento.Cmp_valor_total <= 0)
                errores.Add("El monto total debe ser mayor a cero");
            return errores;
        }

        // Método para crear el detalle principal desde Txt_Monto
        public Sentencias.MovimientoDetalle CrearDetallePrincipal(decimal monto, string numeroDocumento = null, string descripcion = null)
        {
            return new Sentencias.MovimientoDetalle
            {
                Fk_Id_tipo_pago = null, // Puedes ajustar esto según tu lógica
                Cmp_Num_Documento = numeroDocumento,
                Cmp_Monto = monto,
                Cmp_Descripcion = descripcion ?? "Movimiento principal",
                Cmp_Conciliado = 0
            };
        }

        public DataTable ObtenerMovimientosBancarios()
        {
            try
            {
                return crud.ObtenerDetallesContablesParaCaptura();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en controlador al obtener movimientos: {ex.Message}");
            }
        }

        public DataTable ObtenerDetallesContables()
        {
            try
            {
                return crud.ObtenerDetallesContables();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en controlador al obtener detalles contables: {ex.Message}");
            }
        }

        public string ValidarDetalles(List<Sentencias.MovimientoDetalle> detalles)
        {
            if (detalles == null || detalles.Count == 0)
                return "Debe agregar al menos un detalle con monto mayor a cero.";

            foreach (var detalle in detalles)
            {
                if (detalle.Cmp_Monto <= 0)
                    return "Cada detalle debe tener un monto mayor a cero.";
            }
            return null;
        }
    }
}