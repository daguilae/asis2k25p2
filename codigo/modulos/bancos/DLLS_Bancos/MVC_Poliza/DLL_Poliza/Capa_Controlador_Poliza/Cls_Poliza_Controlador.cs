using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_Poliza;


namespace Capa_Controlador_Poliza
{
    //========================== Kevin Natareno 0901-21-635 : Controlador Poliza, 26/10/2025 ===================================================
    public class Cls_Poliza_Controlador
    {
        Cls_DAO_Poliza modelo = new Cls_DAO_Poliza();

        public void InsertarPoliza(string banco, string tipo, string docto, DateTime fecha, string concepto)
        {
            // Ejemplo simple de envío a modelo (se puede ampliar con lógica)
            modelo.GuardarPoliza(banco, tipo, docto, fecha, concepto);
        }
    }
}
