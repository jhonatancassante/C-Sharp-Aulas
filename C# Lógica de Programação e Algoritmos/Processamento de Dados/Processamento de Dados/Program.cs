using System;

namespace Processamento_de_Dados
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, a, c, b2;
            double z, b, B, h, area, resultado, a2;

            x = 5;
            y = 2 * x;
            z = 2 * x;

            b = 6.0;
            B = 8.0;
            h = 5.0;

            area = (b + B) / 2.0 * h;

            a = 5;
            c = 2;

            resultado = (double) a / c;

            a2 = 5.0;
            b2 = (int) a;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.WriteLine();
            Console.WriteLine(area);

            Console.WriteLine();
            Console.WriteLine(resultado);

            Console.WriteLine();
            Console.WriteLine(b2);

            Console.ReadLine();
        }
    }
}
