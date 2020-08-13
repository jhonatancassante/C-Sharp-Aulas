using System;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario x = new Funcionario();

            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();

            Console.Write("Salário bruto: ");
            x.SalarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Imposto: ");
            x.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + x);

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double percent = double.Parse(Console.ReadLine());
            x.AumentarSalario(percent);

            Console.WriteLine();
            Console.Write("Dados atualizados: " + x);
        }
    }
}
