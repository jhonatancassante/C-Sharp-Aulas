using System;

namespace EstruturaRepetitivaWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, soma;
            soma = 0;

            x = int.Parse(Console.ReadLine());
            while (x != 0)
            {
                soma += x;
                x = int.Parse(Console.ReadLine());

            }

            Console.WriteLine(soma);
        }
    }
}
