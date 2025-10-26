using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Modelo_MB;

namespace Capa_Controldor_MB
{
    public class Controlador
    {
        private readonly Sentencias cn = new Sentencias();

        public DataTable llenarTbl(string tabla)
        {
            var da = cn.llenarTbl(tabla);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        CRUD crud = new CRUD();
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

        public bool RequiereCuentaDestino(string nombreOperacion)
        {
            if (string.IsNullOrWhiteSpace(nombreOperacion))
                return false;

            // Solo habilitar para Transferencia
            return nombreOperacion.Equals("Transferencia", StringComparison.OrdinalIgnoreCase);
        }


    }
}


