using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio06
{
    class ConversorDeMoeda
    {
        public static double Iof = 6.0;
        public static double Dolar(double reais, double quantidade)
        {
            double dolar = reais * quantidade;
            return dolar += dolar * Iof / 100.0;
        }
    }
}
