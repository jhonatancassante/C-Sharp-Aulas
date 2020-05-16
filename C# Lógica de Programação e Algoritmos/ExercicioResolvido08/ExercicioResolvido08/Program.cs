using System;

namespace ExercicioResolvido08
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double soma, media;
            double[] vet;
            soma = 0;

            n = int.Parse(Console.ReadLine());
            vet = new double[n];

            string[] s = Console.ReadLine().Split(' ');

            for(int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(s[i]);
                soma += vet[i];
            }
            media = soma / n;

            for (int i = 0; i < n; i++)
            {
                Console.Write(vet[i].ToString("F1") + " ");
            }
            Console.WriteLine();
            Console.WriteLine(soma.ToString("F2"));
            Console.WriteLine(media.ToString("F2"));
        }
    }
}
