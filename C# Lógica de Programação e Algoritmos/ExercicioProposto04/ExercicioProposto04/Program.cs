using System;

namespace ExercicioProposto04
{
	class Program
	{
		static void Main(string[] args)
		{
			int N;
			double[] numeros;
			double media, soma;

			N = int.Parse(Console.ReadLine());
			numeros = new double[N];
			soma = 0.0;

			string[] vet = Console.ReadLine().Split(' ');
			for (int i = 0; i < N; i++)
			{
				numeros[i] = double.Parse(vet[i]);
				soma += (double)numeros[i];
			}

			media = (double)(soma / N);
			Console.WriteLine(media.ToString("F3"));

			for (int i = 0; i < N; i++)
			{
				if (numeros[i] < media)
				{
					Console.WriteLine(numeros[i].ToString("F1"));
				}
			}
		}
	}
}