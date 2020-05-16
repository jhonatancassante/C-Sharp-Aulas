using System;
using System.Globalization;

namespace ExercicioResolvido01
{
    class Program
    {
        static void Main(string[] args)
        {
            double larg, comp, valor, area, preco;

            Console.WriteLine("Digite a medida da largura do terreno:");
            larg = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a medida do comprimento do terreno:");
            comp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor por metro quadrado do terreno:");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = larg * comp;
            preco = area * valor;

            Console.WriteLine();
            Console.WriteLine("Largura: " + larg.ToString("F1", CultureInfo.InvariantCulture) + " metros");
            Console.WriteLine("Comprimento: " + comp.ToString("F1", CultureInfo.InvariantCulture) + " metros");
            Console.WriteLine("Valor: R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Área: " + area.ToString("F2", CultureInfo.InvariantCulture) + " metros quadrados");
            Console.WriteLine("Preço: R$ " + preco.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
