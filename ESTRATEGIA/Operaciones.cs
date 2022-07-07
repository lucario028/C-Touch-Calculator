using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ccalc
{
    public class Operaciones
    {
        static public decimal valor1;
        static public decimal valor2;
        static public decimal operacion;
        static public decimal result;
        public static void Calcular()
        {
            if (operacion == 1)
            {
                result = valor1 + valor2;
            }
            else if (operacion == 2)
            {
                result = valor1 - valor2;
            }
            else if (operacion == 3)
            {
                result = valor1 * valor2;
            }
            else if (operacion == 4)
            {
                result = valor1 / valor2;
            }
            else
            {
                result = 0;
            }

        }
    }
    
    
    

        
}
