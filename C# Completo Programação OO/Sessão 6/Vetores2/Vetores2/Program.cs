using System;

namespace Vetores2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Product[] produto = new Product[n];

            for (int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine());
                produto[i] = new Product { Nome = nome, Preco = preco };
            }

            double media = 0.0;
            for (int i = 0; i < n; i++)
            {
                media += produto[i].Preco;
            }
            media /= n;
            Console.WriteLine("Preço médio = " + media.ToString("F2"));
        }
    }
}
