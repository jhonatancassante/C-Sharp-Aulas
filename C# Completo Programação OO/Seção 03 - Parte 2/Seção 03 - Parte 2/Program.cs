
using System;
using System.Dynamic;

namespace Seção_03___Parte_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase, x, y, z, a, b, c;
            string[] vet;

            Console.WriteLine("Digite uma frase:");
            frase = Console.ReadLine();
            Console.WriteLine("Digite um nome:");
            x = Console.ReadLine();
            Console.WriteLine("Digite um nome:");
            y = Console.ReadLine();
            Console.WriteLine("Digite um nome:");
            z = Console.ReadLine();

            Console.WriteLine("Digite três nomes separados com espaço:");
            vet = Console.ReadLine().Split(' ');

            a = vet[0];
            b = vet[1];
            c = vet[2];

            Console.WriteLine();
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.WriteLine("Digite um inteiro:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Você digitou: " + n1);

            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Funções");
            Console.WriteLine();

            Console.WriteLine("Digite três números inteiros: ");
            int z1 = int.Parse(Console.ReadLine());
            int z2 = int.Parse(Console.ReadLine());
            int z3 = int.Parse(Console.ReadLine());

            int resultado = Maior(z1, z2, z3);

            Console.WriteLine("O maior é: " + resultado);

        }

        static int Maior(int x1, int x2, int x3)
        {
            int m;
            if (x1 > x2 && x1 > x3)
            {
                m = x1;
            }
            else if (x2 > x3)
            {
                m = x2;
            }
            else
            {
                m = x3;
            }
            return m;
        }
    }
}
