using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variáveis locais
            int conta;
            string nome;
            double valor;
            char opcao = 'z';

            //Instanciação da Classe
            Conta conta1;

            //Entrando dados
            Console.Write("Entre o número da conta: ");
            conta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");

            //Só aceitar se for digitado uma das opções mostradas
            while (opcao != 's' && opcao != 'n')
            {
                opcao = char.Parse(Console.ReadLine());
            }
            
            //Solicitando saldo inicial e chamando a classe com três variáveis
            if (opcao == 's')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                valor = double.Parse(Console.ReadLine());
                conta1 = new Conta(conta, nome, valor);
            }
            //Chamando a classe com duas variáveis
            else
            {
                conta1 = new Conta(conta, nome);
            }
            Console.WriteLine();

            //Exibindo a conta
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta1);
            Console.WriteLine();

            //Fazendo depósito
            Console.Write("Entre um valor para depósito: ");
            valor = double.Parse(Console.ReadLine());
            conta1.Deposito(valor);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta1);
            Console.WriteLine();

            //Fazendo saque
            Console.Write("Entre um valor para saque: ");
            valor = double.Parse(Console.ReadLine());
            conta1.Saque(valor);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta1);
        }
    }
}
