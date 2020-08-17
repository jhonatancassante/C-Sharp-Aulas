using System;
using System.Transactions;

namespace _66_Struct
{
    class Program
    {
        static void Main(string[] args)
        {

            Point p;
            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p);
            p = new Point();
            Console.WriteLine(p);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("-----------------------");
            Console.WriteLine("Nullable");
            Console.WriteLine("-----------------------");
            Console.WriteLine();
            //Variáveis do tipo valor/struct não podem receber null
            //double x = null; não é possível
            //Para permitir, tem que se fazer um Nullable de double
            //Nullable<double> x = null; Isso já faz com que x aceite null
            //Mas há outro método mais prático para se fazer isso
            double? x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("X is null");
            }
            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("Y is null");
            }
            double z = x ?? 0.0; //Operador de coalescância nula
            //Como z não pode ser nulo, ele testa x, se for nulo atribui o outro valor
            Console.WriteLine(z);
            z = y ?? 0.0;
            Console.WriteLine(z);

        }
    }
}
