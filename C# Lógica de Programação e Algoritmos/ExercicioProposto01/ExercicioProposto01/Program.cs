using System;

namespace ExercicioProposto01
{
	class Program
	{
		static void Main(string[] args)
		{
			int N, posicao;
			double[] numeros;
			double maior = 0;

			N = int.Parse(Console.ReadLine());
			numeros = new double[N];
			posicao = 0;

			string[] vet = Console.ReadLine().Split(' ');
			for (int i = 0; i < N; i++)
			{
				numeros[i] = double.Parse(vet[i]);
				if (numeros[i] > maior)
				{
					maior = numeros[i];
					posicao = i;
				}
			}
			Console.WriteLine(maior.ToString("F1"));
			Console.WriteLine(posicao);
		}
	}
}