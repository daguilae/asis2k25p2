using System.Data;
using Capa_Modelo_Contabilidad;
//inicio del codigo- Carlo Sosa 0901-22-1106- Fecha: 01/11/2025

namespace Capa_Controlador_Contabilidad
{
    public class Ctr_CuentasTurismo
    {
        readonly Dao_CuentasTurismo _dao = new Dao_CuentasTurismo();

        public DataTable ListarCatalogo() => _dao.ListarCatalogo();

        public (int Debe, string NombreDebe, int Haber, string NombreHaber) LeerConfig() => _dao.LeerConfig();

        public void Guardar(int codDebe, string nomDebe, int codHaber, string nomHaber) =>
            _dao.Guardar(codDebe, nomDebe, codHaber, nomHaber);
    }
}

//Fin del codigo- Carlo Sosa 0901-22-1106- Fecha: 01/11/2025
