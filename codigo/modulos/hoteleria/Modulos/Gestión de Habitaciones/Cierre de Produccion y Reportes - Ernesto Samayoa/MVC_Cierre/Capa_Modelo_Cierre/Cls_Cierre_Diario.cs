using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace Capa_Modelo_Cierre
    {
        //CLASE MODELO: Representa un registro de Tbl_Cierre_Diario
        public class Cls_Cierre_Diario
        {
            // Clave primaria
            public int Pk_Id_Cierre { get; set; }

            // Fecha del proceso contable (ya no del huésped)
            public DateTime Cmp_Fecha_Corte { get; set; }

            // Descripción del cierre (por ejemplo “Cierre general del día domingo”)
            public string Cmp_Descripcion { get; set; }

            // Totales
            public double Cmp_Total_Ingresos { get; set; }
            public double Cmp_Total_Egresos { get; set; }
            public double Cmp_Saldo_Final { get; set; }

            //Constructor vacío (para instancias vacías)
            public Cls_Cierre_Diario() { }

            //Constructor con parámetros (útil al crear nuevos cierres)
            public Cls_Cierre_Diario(DateTime dFechaCorte, string sDescripcion, double doIngresos, double doEgresos)
            {
                Cmp_Fecha_Corte = dFechaCorte;
                Cmp_Descripcion = sDescripcion;
                Cmp_Total_Ingresos = doIngresos;
                Cmp_Total_Egresos = doEgresos;
                Cmp_Saldo_Final = doIngresos - doEgresos;
            }

            // 🔹 Método auxiliar: Calcular saldo final
            public void fun_CalcularSaldoFinal()
            {
                Cmp_Saldo_Final = Cmp_Total_Ingresos - Cmp_Total_Egresos;
            }

            // Método auxiliar: Mostrar información legible (debug)
            public override string ToString()
            {
                return $"Cierre #{Pk_Id_Cierre} - Fecha: {Cmp_Fecha_Corte:dd/MM/yyyy} | Ingresos: Q{Cmp_Total_Ingresos:N2} | Egresos: Q{Cmp_Total_Egresos:N2} | Saldo: Q{Cmp_Saldo_Final:N2}";
            }
        }
    }
