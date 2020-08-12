using System;

namespace ExercicioSequencial01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite para qual exercício deseja ir (1 - 8) ou digite 0 para sair:");
            int escolha = int.Parse(Console.ReadLine());
            string[] vet;
            while (escolha != 0)
            {
                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Digite um número inteiro:");
                        int x1 = int.Parse(Console.ReadLine());
                        if (x1 < 0)
                        {
                            Console.WriteLine("NEGATIVO");
                        }
                        else
                        {
                            Console.WriteLine("NÃO NEGATIVO");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Digite um número inteiro:");
                        int x2 = int.Parse(Console.ReadLine());
                        if (x2 % 2 == 0)
                        {
                            Console.WriteLine("PAR");
                        }
                        else
                        {
                            Console.WriteLine("ÍMPAR");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Digite 2 valores inteiros:");
                        vet = Console.ReadLine().Split(' ');
                        int a, b, c, d;
                        a = int.Parse(vet[0]);
                        b = int.Parse(vet[1]);
                        if (a > b)
                        {
                            c = b;
                            d = a;
                        }
                        else
                        {
                            c = a;
                            d = b;
                        }
                        if (d % c == 0)
                        {
                            Console.WriteLine("São múltiplos");
                        }
                        else
                        {
                            Console.WriteLine("Não são múltiplos");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Digite a hora inicial e final do jogo:");
                        vet = Console.ReadLine().Split(' ');
                        int x4 = int.Parse(vet[0]);
                        int y4 = int.Parse(vet[1]);
                        int tempo4 = y4 - x4;
                        if (x4 >= y4)
                        {
                            tempo4 += 24;
                        }
                        Console.WriteLine("O JOGO DUROU {0} HORA(S)", tempo4);
                        break;
                    case 5:
                        Console.WriteLine("Digite o código do item e a quantidade:");
                        vet = Console.ReadLine().Split(' ');
                        int cod5 = int.Parse(vet[0]);
                        int quant5 = int.Parse(vet[1]);
                        double preco5 = 0.0;
                        double total = 0.0;

                        switch (cod5)
                        {
                            case 1:
                                preco5 = 4.0;
                                break;
                            case 2:
                                preco5 = 4.5;
                                break;
                            case 3:
                                preco5 = 5.0;
                                break;
                            case 4:
                                preco5 = 2.0;
                                break;
                            case 5:
                                preco5 = 1.5;
                                break;
                            default:
                                Console.WriteLine("Código não encontrado!");
                                break;
                        }
                        total = (double) preco5 * quant5;
                        Console.WriteLine("Total: R$ {0:F2}", total);
                        break;
                    case 6:
                        Console.WriteLine("Digite um valor:");
                        double x6 = double.Parse(Console.ReadLine());
                        if (x6 >= 0 && x6 <= 25)
                        {
                            Console.WriteLine("Intervalo [0,25]");
                        }
                        else if (x6 > 25 && x6 <= 50)
                        {
                            Console.WriteLine("Intervalo (25,50]");
                        }
                        else if (x6 > 50 && x6 <= 75)
                        {
                            Console.WriteLine("Intervalo (50,75]");
                        }
                        else if (x6 > 75 && x6 <= 100)
                        {
                            Console.WriteLine("Intervalo (75,100]");
                        }
                        else
                        {
                            Console.WriteLine("Fora do intervalo");
                        }
                        break;
                    case 7:
                        Console.WriteLine("Digite 2 valores com casas decimais:");
                        vet = Console.ReadLine().Split(' ');
                        double x7 = double.Parse(vet[0]);
                        double y7 = double.Parse(vet[1]);

                        if (x7 == 0 && y7 == 0)
                        {
                            Console.WriteLine("Origem");
                        }
                        else if (x7 > 0 && y7 > 0)
                        {
                            Console.WriteLine("Q1");
                        }
                        else if (x7 < 0 && y7 > 0)
                        {
                            Console.WriteLine("Q2");
                        }
                        else if (x7 < 0 && y7 < 0)
                        {
                            Console.WriteLine("Q3");
                        }
                        else
                        {
                            Console.WriteLine("Q4");
                        }
                        break;
                    case 8:
                        Console.WriteLine("Digite o salário:");
                        double salario = double.Parse(Console.ReadLine());
                        double imposto = 0.0;
                        if (salario <= 2000.0)
                        {
                            imposto = 0.00;
                        }
                        else if (salario <= 3000.0)
                        {
                            imposto = (salario - 2000.0) * 0.08;
                        }
                        else if (salario <= 4500.0)
                        {
                            imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
                        }
                        else
                        {
                            imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
                        }

                        if (imposto == 0.0)
                        {
                            Console.WriteLine("Isento");
                        }
                        else
                        {
                            Console.WriteLine("R$ {0:F2}", imposto);
                        }
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;

                }
                Console.WriteLine("Digite para qual exercício deseja ir (1 - 8) ou digite 0 para sair:");
                escolha = int.Parse(Console.ReadLine());
            }
        }
    }
}
