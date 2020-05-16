using System;

namespace Prova_05_Estruturas_Repetitivas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite quantos exemplos terão: ");
            int k = int.Parse(Console.ReadLine());
            for (int i = 0; i < k; i++)
            {
                int senha;

                senha = int.Parse(Console.ReadLine());

                while (senha != 2002)
                {
                    Console.WriteLine("Senha Invalida");
                    senha = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Acesso Permitido");
            }
        }
    }
}
