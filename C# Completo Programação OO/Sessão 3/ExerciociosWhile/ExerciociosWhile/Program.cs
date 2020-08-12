using System;
using System.Numerics;

namespace ExerciociosWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalExercicios = 3;
            Console.WriteLine("Digite para qual exercício deseja ir (1 - {0}) ou digite 0 para sair:", totalExercicios);
            int escolha = int.Parse(Console.ReadLine());
            string[] vet;
            while (escolha != 0)
            {
                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Digite a senha:");
                        int senha1 = int.Parse(Console.ReadLine());
                        while (senha1 != 2002)
                        {
                            Console.WriteLine("Senha inválida!");
                            Console.WriteLine("Digite a senha:");
                            senha1 = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("Acesso permitido!");
                        break;
                    case 2:
                        Console.WriteLine("Digite 2 coordenadas do plano cartesiano:");
                        vet = Console.ReadLine().Split(' ');
                        int x2 = int.Parse(vet[0]);
                        int y2 = int.Parse(vet[1]);
                        while (x2 != 0 && y2 != 0)
                        {
                            if (x2 > 0 && y2 > 0)
                            {
                                Console.WriteLine("primeiro");
                            }
                            else if (x2 < 0 && y2 > 0)
                            {
                                Console.WriteLine("segundo");
                            }
                            else if (x2 < 0 && y2 < 0)
                            {
                                Console.WriteLine("terceiro");
                            }
                            else
                            {
                                Console.WriteLine("quarto");
                            }
                            vet = Console.ReadLine().Split(' ');
                            x2 = int.Parse(vet[0]);
                            y2 = int.Parse(vet[1]);
                        }
                        break;
                    case 3:
                        int codigo = 0;
                        int alcool = 0;
                        int gasolina = 0;
                        int diesel = 0;
                        while (codigo != 4)
                        {
                            codigo = 0;
                            while (codigo < 1 || codigo > 4)
                            {
                                Console.WriteLine("Digite o código do combustível (1.Álcool 2.Gasolina 3.Diesel 4.Fim):");
                                codigo = int.Parse(Console.ReadLine());
                            }
                            if (codigo == 1)
                            {
                                alcool++;
                            }
                            else if (codigo == 2)
                            {
                                gasolina++;
                            }
                            else if (codigo == 3)
                            {
                                diesel++;
                            }
                            else
                            {
                                Console.WriteLine("MUITO OBRIGADO");
                            }
                        }
                        Console.WriteLine("Alcool: {0}", alcool);
                        Console.WriteLine("Gasolina: {0}", gasolina);
                        Console.WriteLine("Diesel: {0}", diesel);
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
