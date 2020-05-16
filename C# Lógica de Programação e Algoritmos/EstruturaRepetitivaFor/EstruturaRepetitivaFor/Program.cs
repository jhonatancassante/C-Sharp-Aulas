using System;

namespace EstruturaRepetitivaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, x, soma;

            soma = 0;

            N = int.Parse(Console.ReadLine());

            for(int i=1; i <= N; i++)
            {
                x = int.Parse(Console.ReadLine());
                soma += x;
            }
            Console.WriteLine(soma);
        }
    }
}
