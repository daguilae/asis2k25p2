/* 
 * Programador: Richard Anthony De León Milian
 * Carné: 0901-22-10245
 * Fecha de modificación: 8/11/2025
 * Archivo: Cls_MovimientosControlador.cs
 */
using System;
using System.Data;
using Capa_Modelo_Percepciones_Nomina;

namespace Capa_Controlador_Percepciones_Nomina
{
    public class Cls_MovimientosControlador
    {
        private readonly Cls_MovimientosModelo modelo = new Cls_MovimientosModelo();

        //Reinicia AUTO_INCREMENT si la tabla está vacía (para ID=1)
        public void proReiniciarAutoIncrementSiVacia()
        {
            modelo.proResetAutoIncrementIfEmptyMovimientos();
        }

        //Insertar movimiento y devolver ID generado
        public int funInsertarMovimiento(int iIdNomina, int iIdConcepto, decimal deMonto)
        {
            return modelo.funInsertarMovimiento(iIdNomina, iIdConcepto, deMonto);
        }

        // Listar movimientos por nómina
        public DataTable funMostrarMovimientosPorNomina(int iIdNomina, bool asc = true)
        {
            return modelo.funObtenerMovimientosPorNomina(iIdNomina, asc);
        }

        // Eliminar por ID (si lo usas)
        public void proEliminarMovimiento(int iIdMovimiento)
        {
            modelo.proEliminarMovimiento(iIdMovimiento);
        }
    }
}
