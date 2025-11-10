using System;
using System.Data;
using Capa_Modelo_CxP;

namespace Capa_Controlador_CxP
{
    public class Cls_Controlador_CxP
    {
        private readonly Cls_Sentencias_CxP _mdl = new Cls_Sentencias_CxP();

        public DataTable Proveedores() => _mdl.Proveedores_ListarActivos();
        public DataTable Gestion_Listar() => _mdl.Gestion_Listar();

        public void RegistrarFactura(int idProveedor, string serie, string numero,
            DateTime fEmi, DateTime fVen, decimal total, string descripcion, int idUsuarioCrea)
        {
            if (idProveedor <= 0) throw new ArgumentException("Seleccione un proveedor.");
            if (string.IsNullOrWhiteSpace(numero)) throw new ArgumentException("El número de factura es obligatorio.");
            if (total <= 0) throw new ArgumentException("El total debe ser mayor a 0.");
            if (fVen < fEmi) throw new ArgumentException("La fecha de vencimiento no puede ser menor a la de emisión.");

            _mdl.DocCxP_Insertar(idProveedor, serie ?? "", numero.Trim(), fEmi, fVen, total, descripcion ?? "", idUsuarioCrea);
        }
    }
}
