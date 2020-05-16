using System;

namespace ExercicioProposto11
{
	class Program
	{
		static void Main(string[] args)
		{
			int N;
			int[,] mat;
			int[] vet;

			N = int.Parse(Console.ReadLine());
			mat = new int[N, N];
			vet = new int[N];

			for (int i = 0; i < N; i++)
			{
				string[] s = Console.ReadLine().Split(' ');
				for (int j = 0; j < N; j++)
				{
					mat[i, j] = int.Parse(s[j]);
				}
			}

			for (int i = 0; i < N; i++)
			{
				vet[i] = 0;
				for (int j = 0; j < N; j++)
				{
					vet[i] += mat[i, j];
				}
				Console.WriteLine(vet[i]);
			}
		}
	}
}