using System;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno x = new Aluno();
            
            Console.Write("Nome do aluno: ");
            x.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno:");
            x.Nota1 = double.Parse(Console.ReadLine());
            x.Nota2 = double.Parse(Console.ReadLine());
            x.Nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota Final: " + x.NotaFinal().ToString("F2"));
            if (x.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM "
                + x.NotaRestante().ToString("F2")
                + " PONTOS");
            }
        }
    }
}
