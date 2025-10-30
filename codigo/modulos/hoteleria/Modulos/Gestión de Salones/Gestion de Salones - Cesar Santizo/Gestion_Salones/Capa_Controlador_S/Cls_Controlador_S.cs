using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using Capa_Modelo_S;

namespace Capa_Controlador_S
{

    public class Cls_Controlador_S
    {

        // ==========================
        // Variables globales
        // ==========================
        Cls_Sentencias_Salones sentencias = new Cls_Sentencias_Salones();

        // ==========================
        // MÉTODOS PARA TBL_SALONES
        // ==========================

        // Insertar salón
        public void GuardarSalon(string nombre, string ubicacion, int capacidad, int disponibilidad)
        {
            sentencias.InsertarSalon(nombre, ubicacion, capacidad, disponibilidad);
        }
        public int VerificarSalon(string sNombreSalon)
        {
            return sentencias.VerificarSalon(sNombreSalon);
        }


        // Consultar salones
        public DataTable ObtenerSalones()
        {
            return sentencias.ObtenerSalones();
        }

        // Modificar salón
        public void ModificarSalon(int id, string nombre, string ubicacion, int capacidad, int disponibilidad)
        {
            sentencias.ModificarSalon(id, nombre, ubicacion, capacidad, disponibilidad);
        }

        // Eliminar salón
        public void EliminarSalon(int id)
        {
            sentencias.EliminarSalon(id);
        }

        // ==========================
        // MÉTODOS PARA TBL_RESERVAS_SALONES
        // ==========================

        // Aquí puedes agregar los métodos para manejar las reservas de salones
        // Ejemplo futuro:
        // public void GuardarReservaSalon(int idHuesped, int idSalon, DateTime fecha, TimeSpan horaInicio, TimeSpan horaFin, int cantidadPersonas, decimal montoTotal)
        // { ... }
    }


}