using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa A, B;
            A = new Pessoa();
            B = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            A.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            A.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            B.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            B.Idade = int.Parse(Console.ReadLine());

            if (A.Idade > B.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + A.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + B.Nome);
            }
        }
    }
}
