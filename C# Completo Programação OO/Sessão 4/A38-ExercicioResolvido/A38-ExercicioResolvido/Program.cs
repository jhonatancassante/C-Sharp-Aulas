using System;

namespace A38_ExercicioResolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            double areaX, areaY;
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo x:");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triângulo y:");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            areaX = x.Area();
            areaY = y.Area();

            Console.WriteLine("Área de x = " + areaX.ToString("F4"));
            Console.WriteLine("Área de y = " + areaY.ToString("F4"));

            Console.Write("Maior área: ");
            if (areaX > areaY)
            {
                Console.WriteLine("X");
            }
            else
            {
                Console.WriteLine("Y");
            }
        }
    }
}
