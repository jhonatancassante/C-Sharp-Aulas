using System;

namespace FuncoesMatematicas
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 3.0;
            double y = 4.0;
            double z = -5.0;
            double A, B, C, a, b, c, delta, x1, x2;

            A = Math.Sqrt(x);
            B = Math.Sqrt(y);
            C = Math.Sqrt(25.0);
            Console.WriteLine("Raiz quadrada de " + x + " = " + A);
            Console.WriteLine("Raiz quadrada de " + y + " = " + B);
            Console.WriteLine("Raiz quadrada de 25 = " + C);

            Console.WriteLine();
            A = Math.Pow(x, y);
            B = Math.Pow(x, 2.0);
            C = Math.Pow(5.0, 2.0);
            Console.WriteLine(x + " elevado a " + y + " = " + A);
            Console.WriteLine(x + " elevado ao quadrado = " + B);
            Console.WriteLine("5 elevado ao quadrado = " + C);

            Console.WriteLine();
            A = Math.Abs(x);
            B = Math.Abs(y);
            C = Math.Abs(z);
            Console.WriteLine("Valor absoluto de " + x + " = " + A);
            Console.WriteLine("Valor absoluto de " + y + " = " + B);
            Console.WriteLine("Valor absoluto de " + z + " = " + C);

            Console.WriteLine();
            Console.WriteLine("Bhaskara");
            Console.WriteLine();
            Console.WriteLine("Digite em sequência os valores de a, b e c separados por espaço:");

            string[] vet = Console.ReadLine().Split(' ');
            a = double.Parse(vet[0]);
            b = double.Parse(vet[1]);
            c = double.Parse(vet[2]);

            Console.WriteLine();
            Console.WriteLine("Os números digitados foram: " + a + ", " + b + " e " + c);
            delta = Math.Pow(b, 2.0) - 4 * a * c;
            x1 = ((-1 * b) + Math.Sqrt(delta)) / (2.0 * a);
            x2 = ((-1 * b) - Math.Sqrt(delta)) / (2.0 * a);
            Console.WriteLine("O resultada de delta foi de " + delta + ", o resultado de x1 foi de " + x1 + " e o resultado de x2 foi de " + x2);


            Console.ReadLine();
        }
    }
}
