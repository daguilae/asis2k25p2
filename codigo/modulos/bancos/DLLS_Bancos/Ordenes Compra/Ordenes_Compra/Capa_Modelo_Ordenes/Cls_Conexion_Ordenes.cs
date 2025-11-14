using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;


// Inicio de código de María Alejandra Morales García con carné: 0901-22-1226 con la dFecha de: 07/11/2025

namespace Capa_Modelo_Ordenes
{
    public class Cls_Conexion_Ordenes


    {
        public OdbcConnection conexion()
        {
            //creacion de la conexion via ODBC


            OdbcConnection conn = new OdbcConnection("Dsn=Bd_Hoteleria");


            try
            {
                conn.Open();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No Conectó");
            }
            return conn;
        }

        //metodo para cerrar la conexion
        public void desconexion(OdbcConnection conn)
        {
            try
            {
                conn.Close();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No Conectó");
            }
        }

    }
}

// Fin de código de María Alejandra Morales García con carné: 0901-22-1226 con la dFecha de: 07/11/2025

