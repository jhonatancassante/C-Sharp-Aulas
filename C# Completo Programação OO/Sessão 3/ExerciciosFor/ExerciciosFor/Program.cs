using System;

namespace ExerciciosFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalExercicios = 2;
            Console.WriteLine("Digite para qual exercício deseja ir (1 - {0}) ou digite 0 para sair:", totalExercicios);
            int escolha = int.Parse(Console.ReadLine());
            while (escolha != 0)
            {
                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Digite um número inteiro entre [1, 1000]:");
                        int n1 = 0;
                        while (n1 < 1 || n1 > 1000)
                        {
                            n1 = int.Parse(Console.ReadLine());
                        }
                        for(int i = 1; i <= n1; i++)
                        {
                            if (i % 2 != 0)
                            {
                                Console.WriteLine(i);
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("Digite um número inteiro:");
                        int n2 = int.Parse(Console.ReadLine());
                        int Nin = 0;
                        int Nout = 0;
                        Console.WriteLine("Digite {0} números inteiros:", n2);
                        for (int i = 0; i < n2; i++)
                        {
                            int x2 = int.Parse(Console.ReadLine());
                            if (x2 >= 10 && x2 <= 20)
                            {
                                Nin++;
                            }
                            else
                            {
                                Nout++;
                            }

                        }
                        Console.WriteLine(Nin + " in");
                        Console.WriteLine(Nout + " out");
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.WriteLine("Digite para qual exercício deseja ir (1 - {0}) ou digite 0 para sair:", totalExercicios);
                escolha = int.Parse(Console.ReadLine());
            }
        }
    }
}
