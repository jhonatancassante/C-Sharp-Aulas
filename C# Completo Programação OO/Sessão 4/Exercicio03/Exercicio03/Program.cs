using System;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo x = new Retangulo();

            Console.WriteLine("Entre a largura e altura de um retângulo:");
            x.Altura = double.Parse(Console.ReadLine());
            x.Largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Área = " + x.Area().ToString("F2"));
            Console.WriteLine("Perímetro = " + x.Perimetro().ToString("F2"));
            Console.WriteLine("Diagonal = " + x.Diagonal().ToString("F2"));
        }
    }
}
