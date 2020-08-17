using System;
using System.Xml;

namespace VetoresExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());
            Estudante[] quarto = new Estudante[10];

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Aluguel #" + i + ":");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int room = int.Parse(Console.ReadLine());

                quarto[room] = new Estudante(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if (quarto[i] != null)
                {
                    Console.WriteLine(i + ": " + quarto[i]);
                }
            }

        }
    }
}
