using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using Capa_Modelo_MB;

namespace Capa_Controldor_MB
{
    public class Cls_Controlador
    {
        // =============================================
        // Dependencias (modelo / CRUD)
        // =============================================
        private readonly Cls_Sentencias cn = new Cls_Sentencias();
        private readonly Cls_CRUD crud = new Cls_CRUD();

        // =============================================
        // Reglas / requerimientos por operación
        // =============================================
        public bool fun_RequiereCuentaDestino(string sNombreOperacion)
        {
            if (string.IsNullOrWhiteSpace(sNombreOperacion))
                return false;

            return sNombreOperacion.Equals("TRANSFERENCIA_ENVIADA", StringComparison.OrdinalIgnoreCase) ||
                   sNombreOperacion.Equals("TRANSFERENCIA_RECIBIDA", StringComparison.OrdinalIgnoreCase);
        }

        // =============================================
        // Validación compuesta de movimiento (con nombre op)
        // =============================================
        public (bool bOk, string sMensaje) fun_ValidarMovimiento(
            Cls_Sentencias mov_Movimiento,
            List<Cls_Sentencias.Cls_MovimientoDetalle> lst_Detalles,
            string sNombreOperacion)
        {
            if (mov_Movimiento.iFk_Id_cuenta_origen <= 0)
                return (false, "Seleccione cuenta ORIGEN.");

            if (mov_Movimiento.iFk_Id_operacion <= 0)
                return (false, "Seleccione la OPERACIÓN.");

            bool bEsTransferencia = !string.IsNullOrWhiteSpace(sNombreOperacion) &&
                                    sNombreOperacion.Equals("Transferencia", StringComparison.OrdinalIgnoreCase);

            if (bEsTransferencia && (mov_Movimiento.iFk_Id_cuenta_destino == null || mov_Movimiento.iFk_Id_cuenta_destino <= 0))
                return (false, "Para Transferencia seleccione cuenta DESTINO.");

            if (lst_Detalles == null || lst_Detalles.Count == 0)
                return (false, "Debe agregar al menos UNA línea de detalle.");

            if (lst_Detalles.Any(d => d.deCmp_Monto <= 0))
                return (false, "Todos los montos de detalle deben ser > 0.");

            decimal deSuma = lst_Detalles.Sum(d => d.deCmp_Monto);
            if (deSuma <= 0)
                return (false, "El total del movimiento debe ser > 0.");

            mov_Movimiento.deCmp_valor_total = deSuma;

            if (string.IsNullOrWhiteSpace(mov_Movimiento.sCmp_estado))
                return (false, "Seleccione el ESTADO del movimiento.");

            return (true, "OK");
        }

        // =============================================
        // Persistencia
        // =============================================
        public int fun_GuardarMovimiento(Cls_Sentencias mov_Movimiento, List<Cls_Sentencias.Cls_MovimientoDetalle> lst_Detalles)
        {
            // Estandarizado al nombre usado en Capa_Modelo_MB.Cls_CRUD
            return crud.fun_crear_movimiento_con_detalles(mov_Movimiento, lst_Detalles);
        }

        // =============================================
        // Validación básica (lista de errores)
        // =============================================
        public List<string> fun_ValidarMovimiento(Cls_Sentencias mov_Movimiento, List<Cls_Sentencias.Cls_MovimientoDetalle> lst_Detalles)
        {
            List<string> lst_Errores = new List<string>();

            if (mov_Movimiento.iFk_Id_cuenta_origen <= 0)
                lst_Errores.Add("La cuenta origen es requerida.");

            if (mov_Movimiento.iFk_Id_operacion <= 0)
                lst_Errores.Add("La operación bancaria es requerida.");

            if (mov_Movimiento.deCmp_valor_total <= 0)
                lst_Errores.Add("El monto total debe ser mayor a cero.");

            return lst_Errores;
        }

        // =============================================
        // Helpers para construir detalles
        // =============================================
        public Cls_Sentencias.Cls_MovimientoDetalle fun_CrearDetallePrincipal(decimal deMonto, string sNumeroDocumento = null, string sDescripcion = null)
        {
            return new Cls_Sentencias.Cls_MovimientoDetalle
            {
                iFk_Id_tipo_pago = null,
                sCmp_Num_Documento = sNumeroDocumento,
                deCmp_Monto = deMonto,
                sCmp_Descripcion = sDescripcion ?? "Movimiento principal",
                iCmp_Conciliado = 0
            };
        }

        public string fun_ValidarDetalles(List<Cls_Sentencias.Cls_MovimientoDetalle> lst_Detalles)
        {
            if (lst_Detalles == null || lst_Detalles.Count == 0)
                return "Debe agregar al menos un detalle con monto mayor a cero.";

            foreach (var det in lst_Detalles)
            {
                if (det.deCmp_Monto <= 0)
                    return "Cada detalle debe tener un monto mayor a cero.";
            }

            return null;
        }
    }
}
