using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Dolar
{
    internal class ConversorDeMoedas
    {
        public static double Iof = 6.0;
        public static double DolarParaReal(double dolar, double quantidade)
        {
            double total = dolar * quantidade;
            return total + total * Iof / 100.0;
        }


    }
}
