using System;

namespace Prova_04_Estrutura_Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int k = 0; k < 4; k++)
            {
                double A, B, C, delta, X1, X2;

                string[] s = Console.ReadLine().Split(' ');
                A = double.Parse(s[0]);
                B = double.Parse(s[1]);
                C = double.Parse(s[2]);

                if (A == 0)
                {
                    Console.WriteLine("Impossivel calcular");
                }
                else
                {
                    delta = Math.Pow(B, 2.0) - (4.0 * A * C);
                    if (delta < 0)
                    {
                        Console.WriteLine("Impossivel calcular");
                    }
                    else
                    {
                        X1 = (-B + Math.Sqrt(delta)) / (2.0 * A);
                        X2 = (-B - Math.Sqrt(delta)) / (2.0 * A);
                        Console.WriteLine("X1 = " + X1.ToString("F5"));
                        Console.WriteLine("X2 = " + X2.ToString("F5"));
                    }
                }
                Console.WriteLine();
            }
        }
    }
}