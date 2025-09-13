using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Capa_Modelo_Componente_Consultas
{
    public class Datos
    {
        public class UserQuery
        {
            public string Name { get; set; }
            public string Sql { get; set; }
            public override string ToString() => Name;
        }
    }
}
