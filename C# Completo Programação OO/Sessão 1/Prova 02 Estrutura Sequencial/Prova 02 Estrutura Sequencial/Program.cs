using System;

namespace Prova_02_Estrutura_Sequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, area, pi;
            pi = 3.14159;

            for (int i = 0; i < 3; i++)
            {
                raio = double.Parse(Console.ReadLine());
                area = pi * Math.Pow(raio, 2.0);
                Console.WriteLine("A=" + area.ToString("F4"));
            }
        }
    }
}
