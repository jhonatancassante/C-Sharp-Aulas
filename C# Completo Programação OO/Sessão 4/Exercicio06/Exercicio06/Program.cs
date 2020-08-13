using System;

namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine());
            Console.Write("Quantos dólares você vai comprar? ");
            double quant = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor a ser pago em reais = " + ConversorDeMoeda.Dolar(cotacao, quant).ToString("F2"));
        }
    }
}
