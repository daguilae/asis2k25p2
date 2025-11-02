using System;
using System.Data;
using Capa_Modelo_Ordenes;

namespace Capa_Controlador_Ordenes
{
    public class Cls_Controlador_Ordenes
    {
        Cls_Sentencias_Ordenes modelo = new Cls_Sentencias_Ordenes();

        public void Agregar(string idOrden, string idBanco, string fecha, string autorizadoPor, string monto, string idEstado)
        {
            try
            {
                int orden = int.Parse(idOrden);
                int banco = int.Parse(idBanco);

                int estado = int.Parse(idEstado);

                modelo.Insertar(orden, banco,  fecha, autorizadoPor,  monto, estado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al procesar datos: " + ex.Message);
            }
        }


        public void Eliminar(string idAutorizacion)
        {
            modelo.Eliminar(idAutorizacion);
        }

        public DataTable Mostrar()
        {
            return modelo.Mostrar();
        }


        public void Editar(string idAutorizacion, string idOrden, string idBanco, string fecha, string autorizadoPor, string monto, string idEstado)
        {
            try
            {
                int orden = int.Parse(idOrden);
                int banco = int.Parse(idBanco);
                int estado = int.Parse(idEstado);

                modelo.Actualizar(idAutorizacion, orden, banco, fecha, autorizadoPor, monto, estado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al procesar datos: " + ex.Message);
            }
        }





    }
}
