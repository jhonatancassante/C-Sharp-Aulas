using System;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] vect = new double[n];

            //Lendo o vetor
            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine());
            }

            //Calculando o vetor
            double media = 0.0;
            for (int i = 0; i < n; i++)
            {
                media += vect[i];
            }
            media /= n;
            Console.WriteLine("Average High = " + media.ToString("F2"));
        }
    }
}
