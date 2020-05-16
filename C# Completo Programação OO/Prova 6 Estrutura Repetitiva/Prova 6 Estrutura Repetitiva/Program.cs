using System;

namespace Prova_6_Estrutura_Repetitiva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite quantos exemplos terão: ");
            int k = int.Parse(Console.ReadLine());
            for (int i = 0; i < k; i++)
            {
                int N, X, xIn, xOut;
                xIn = 0;
                xOut = 0;

                N = int.Parse(Console.ReadLine());

                for (int j = 0; j < N; j++)
                {
                    X = int.Parse(Console.ReadLine());
                    if (X >= 10 && X <= 20)
                    {
                        xIn++;
                    }
                    else
                    {
                        xOut++;
                    }
                }
                Console.WriteLine(xIn + " in");
                Console.WriteLine(xOut + " out");
            }
        }
    }
}
