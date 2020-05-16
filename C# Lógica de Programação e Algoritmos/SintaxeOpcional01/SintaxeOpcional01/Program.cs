using System;

namespace SintaxeOpcional01
{
    class Program
    {
        static void Main(string[] args)
        {
            int consumo;
            double conta;

            consumo = int.Parse(Console.ReadLine());

            conta = 50.0;

            if (consumo > 100)
            {
                conta += (consumo - 100) * 2.0;
            }

            /*
             * a += b == a = a + b;
             * a -= b == a = a - b;
             * a *= b == a = a * b;
             * a /= b == a = a / b;
             * a %= b == a = a % b;
             */

            Console.WriteLine("Valor a pagar: R$ " + conta.ToString("F2"));
        }
    }
}
