/* 
 * Programador: Richard Anthony De León Milian
 * Carné: 0901-22-10245
 * Fecha de modificación: 11/11/2025
 * Archivo: Cls_DetalleLineaVm.cs
 * Descripción: Clase usada como modelo de vista para mostrar los detalles 
 * de una póliza en la grilla, incluyendo tipo de movimiento y valor.
 */

using System;

public sealed class Cls_DetalleLineaVm
{
    // Propiedades visibles en la grilla
    public string sCodigoCuenta { get; set; } = "";
    public string sNombreCuenta { get; set; } = "";
    public string sTipoTexto { get; set; } = ""; // Cargo o Abono
    public decimal deValor { get; set; }

    // Propiedad de soporte interno (no se muestra en la grilla)
    public bool bTipo { get; set; } // true = cargo, false = abono
}
