using System;
using System.Globalization;

namespace EntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            string x, y;
            int x2, z;
            double x3, x4, w;
            char x5;

            Console.Write("Digite uma string: ");
            x = Console.ReadLine();
            Console.Write("Digite um int: ");
            x2 = int.Parse(Console.ReadLine());
            Console.Write("Digite um double com vígula: ");
            x3 = double.Parse(Console.ReadLine());
            Console.Write("Digite um double com ponto: ");
            x4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite um char: ");
            x5 = char.Parse(Console.ReadLine());

            Console.WriteLine("Digite na ordem uma string, um int e um double com ponto, separados por espaço:");
            string[] vet = Console.ReadLine().Split(' ');

            y = vet[0];
            z = int.Parse(vet[1]);
            w = double.Parse(vet[2], CultureInfo.InvariantCulture);
            
            Console.WriteLine();
            Console.WriteLine(x);
            Console.WriteLine(x2);
            Console.WriteLine(x3);
            Console.WriteLine(x4.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine(x5);

            Console.WriteLine();
            Console.WriteLine(y + " " + z + " " + w);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(w.ToString(CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
