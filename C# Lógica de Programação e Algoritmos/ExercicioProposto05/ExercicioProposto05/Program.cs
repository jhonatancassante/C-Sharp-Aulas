using System;

namespace ExercicioProposto05
{
	class Program
	{
		static void Main(string[] args)
		{
			int N, count, soma;
			int[] numeros;
			double media;

			N = int.Parse(Console.ReadLine());
			numeros = new int[N];
			count = 0;
			soma = 0;

			string[] vet = Console.ReadLine().Split(' ');
			for (int i = 0; i < N; i++)
			{
				numeros[i] = int.Parse(vet[i]);
				if (numeros[i] % 2 == 0)
				{
					soma += numeros[i];
					count++;
				}
			}
			media = (double)soma / count;

			Console.WriteLine(media.ToString("F1"));
		}
	}
}