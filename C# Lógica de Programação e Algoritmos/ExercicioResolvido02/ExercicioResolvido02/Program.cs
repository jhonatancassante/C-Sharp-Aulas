using System;

namespace ExercicioResolvido02
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, area, perimetro, diagonal;

            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());

            area = A * B;
            perimetro = 2.0 * (A + B);
            diagonal = Math.Sqrt(Math.Pow(A, 2.0) + Math.Pow(B, 2.0));

            Console.WriteLine("AREA = " + area.ToString("F4"));
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4"));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4"));
        }
    }
}
