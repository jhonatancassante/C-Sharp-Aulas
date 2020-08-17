using System;
using System.Collections.Concurrent;
using System.Xml;

namespace ModificadorParams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----params-----");
            int result1 = Calculator.Sum(10, 20, 30, 40 );
            int result2 = Calculator.Sum(11, 22, 33, 44, 55, 66);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine();

            Console.WriteLine("-----ref-----");
            int a1 = 10;
            int a2 = 143;
            Calculator.Triple(ref a1);
            Calculator.Triple(ref a2);
            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.WriteLine();

            Console.WriteLine("-----out-----");
            int x1 = 10;
            int x2 = 9;
            int double1;
            int double2;
            Calculator.Double(x1, out result1);
            Calculator.Double(x2, out result2);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine();

            Console.WriteLine("-----foreach-----");
            string[] vect = new string[] { "Maria", "Bob", "José", "Alex" };

            foreach (string obj in vect)
            {
                Console.WriteLine(obj);
            }


        }
    }
}
