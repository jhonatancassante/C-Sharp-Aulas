using System;

namespace Prova_01_Estrutura_Sequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            int peca1, quant1, peca2, quant2;
            double preco1, preco2, total;

            string[] s = Console.ReadLine().Split(' ');
            peca1 = int.Parse(s[0]);
            quant1 = int.Parse(s[1]);
            preco1 = double.Parse(s[2]);
            s = Console.ReadLine().Split(' ');
            peca2 = int.Parse(s[0]);
            quant2 = int.Parse(s[1]);
            preco2 = double.Parse(s[2]);
            total = (quant1 * preco1) + (quant2 * preco2);

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2"));
        }
    }
}
