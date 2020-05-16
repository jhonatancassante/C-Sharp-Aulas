using System;

namespace ExercicioResolvido09
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double somaAltura, somaIdade, media, percent;
            string[] nome;
            int[] idade;
            double[] altura;

            n = int.Parse(Console.ReadLine());
            nome = new string[n];
            idade = new int[n];
            altura = new double[n];
            somaAltura = 0;
            somaIdade = 0;

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nome[i] = s[0];
                idade[i] = int.Parse(s[1]);
                altura[i] = double.Parse(s[2]);
                somaAltura += altura[i];
                if(idade[i] < 16)
                {
                    somaIdade++;
                }
            }
            media = somaAltura / n;
            percent = (double)(somaIdade * 100 / n);
            Console.WriteLine("Altura média: " + media.ToString("F2"));
            Console.WriteLine("Pessoas com menos de 16 anos: " + percent.ToString("F1") + "%");
        }
    }
}
