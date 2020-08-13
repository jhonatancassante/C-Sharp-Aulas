using System;

namespace A46_MembrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circ = Calculadora.Circunferencia(raio);
            Console.WriteLine("Circunferencia: " + circ.ToString("F2"));

            double vol = Calculadora.Volume(raio);
            Console.WriteLine("Volume: " + vol.ToString("F2"));
            Console.WriteLine("Valor de Pi: " + Calculadora.Pi.ToString("F2"));
        }
    }
}
