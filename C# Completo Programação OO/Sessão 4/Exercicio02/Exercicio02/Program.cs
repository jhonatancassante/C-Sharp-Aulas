using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario A, B;
            A = new Funcionario();
            B = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            A.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            A.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            B.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            B.Salario = double.Parse(Console.ReadLine());

            double media = (A.Salario + B.Salario) / 2;

            Console.WriteLine("Salário médio: " + media.ToString("F2"));
        }
    }
}
