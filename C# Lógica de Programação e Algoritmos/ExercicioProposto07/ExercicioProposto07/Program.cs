using System;

namespace ExercicioProposto07
{
	class Program
	{
		static void Main(string[] args)
		{
			int N;
			double[] nota1, nota2, media;
			string[] nome;

			N = int.Parse(Console.ReadLine());
			nota1 = new double[N];
			nota2 = new double[N];
			media = new double[N];
			nome = new string[N];

			for (int i = 0; i < N; i++)
			{
				string[] vet = Console.ReadLine().Split(' ');
				nome[i] = vet[0];
				nota1[i] = double.Parse(vet[1]);
				nota2[i] = double.Parse(vet[2]);
				media[i] = (double)((nota1[i] + nota2[i]) / 2.0);
			}
			Console.WriteLine("Alunos aprovados:");
			for (int i = 0; i < N; i++)
			{
				if (media[i] >= 6.0)
				{
					Console.WriteLine(nome[i]);
				}
			}
		}
	}
}