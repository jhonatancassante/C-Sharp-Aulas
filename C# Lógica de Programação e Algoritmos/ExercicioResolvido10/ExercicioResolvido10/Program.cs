using System;

namespace ExercicioResolvido10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            n = int.Parse(Console.ReadLine());

            string[] vet = new string[n];

            for (int i = 0; i < n; i++)
            {
                vet[i] = Console.ReadLine();
            }

            Console.WriteLine("Nome lidos: ");
            foreach(string x in vet)
            {
                Console.WriteLine(x);
            }
        }
    }
}
