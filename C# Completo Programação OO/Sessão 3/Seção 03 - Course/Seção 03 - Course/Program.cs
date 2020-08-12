using System;
using System.Globalization;

namespace Seção_03___Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("----------------------------");
            Console.WriteLine("Tipos básicos de dados:");
            Console.WriteLine("----------------------------");
            
            sbyte x = 100;

            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';

            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L; //Recomenda-se quando for escrever o número diretamente colocar "L" no final.
            float n5 = 4.5f; //É necessário colocar o "f" no final para deixar explícito que é tipo float
            double n6 = 4.5;
            string nome = "Maria Green"; //String é imutável;
            object obj1 = "Mario do Armário"; //Variável genérica
            object obj2 = 4.5f;

            Console.WriteLine(x);
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1); //Colocar "cw" e dar tab x2 ajudar a completar o código.
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

            int x1 = int.MinValue;
            int x2 = int.MaxValue;

            Console.WriteLine(x1);
            Console.WriteLine(x2);

            Console.WriteLine();
            Console.WriteLine("----------------------------");
            Console.WriteLine("Saída de dados");
            Console.WriteLine("----------------------------");
            

            int idade = 32;
            double saldo = 10.35784;
            string nome2 = "Maria";

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2} reais", nome2, idade, saldo.ToString("F2", CultureInfo.InvariantCulture)); //Placeholder
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome2, idade, saldo); //Placeholder
            Console.WriteLine($"{nome2} tem {idade} anos e tem saldo igual a {saldo.ToString("F2", CultureInfo.InvariantCulture)} reais"); //Interpolação
            Console.WriteLine($"{nome2} tem {idade} anos e tem saldo igual a {saldo:F2} reais"); //Interpolação
            Console.WriteLine(nome2 + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais"); //Concatenação

            Console.WriteLine();
            Console.WriteLine("----------------------------");
            Console.WriteLine("Operadores de atribuição");
            Console.WriteLine("----------------------------");

            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);

            a -= 6;
            Console.WriteLine(a);

            a /= 15;
            Console.WriteLine(a);

            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF";
            Console.WriteLine(s);

            a++;
            Console.WriteLine(a);

            a--;
            Console.WriteLine(a);

            a = 10;
            int b = a++;
            Console.WriteLine(a);
            Console.WriteLine(b);

            a = 10;
            b = ++a;
            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.WriteLine();
            Console.WriteLine("----------------------------");
            Console.WriteLine("Conversão Implícita e Casting");
            Console.WriteLine("----------------------------");

            double a1;
            int b1;

            a1 = 5.1;
            b1 = (int)a1; //Casting conversão explícita

            Console.WriteLine(a1 + " " + b1);

            a1 = b1; //conversão implícita
            Console.WriteLine(a1 + " " + b1);

            int b2 = 2;
            b1 = 5;

            double resultado1 = (double) b1 / b2; //Necessário fazer o casting quando for fazer operações de duas variáveis que são diferentes do resultado
            Console.WriteLine(resultado1);

        }
    }
}
