using System;

namespace Prova_03_Estrutura_Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int indice = 0; indice < 2; indice++)
            {
                int cod, quant;
                double precoUnit, precoTotal;

                string[] s = Console.ReadLine().Split(' ');
                cod = int.Parse(s[0]);
                quant = int.Parse(s[1]);
                precoUnit = 0.00;

                switch(cod)
                {
                    case 1:
                        precoUnit = 4.00;
                        break;
                    case 2:
                        precoUnit = 4.50;
                        break;
                    case 3:
                        precoUnit = 5.00;
                        break;
                    case 4:
                        precoUnit = 2.00;
                        break;
                    case 5:
                        precoUnit = 1.50;
                        break;
                    default:
                        break;
                }
                precoTotal = (double)(precoUnit * quant);

                Console.WriteLine("Total: R$ " + precoTotal.ToString("F2"));
            }
        }
    }
}
