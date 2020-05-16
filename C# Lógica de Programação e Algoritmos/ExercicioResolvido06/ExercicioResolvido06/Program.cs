using System;
using System.Globalization;

namespace ExercicioResolvido06
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, count, soma;
            double media;
            count = 0;
            soma = 0;

            idade = int.Parse(Console.ReadLine());
            if (idade >= 0)
            {
                while (idade >= 0)
                {
                    soma = soma + idade;
                    count += 1;
                    idade = int.Parse(Console.ReadLine());
                }
                media = (double) soma / count;
                Console.WriteLine(media.ToString("F2"), CultureInfo.InvariantCulture);
            }
            else
            {
                Console.WriteLine("Impossível Calcular");
            }
        }
    }
}
