using System;

namespace Matrizes
{
	class Program
	{
		static void Main(string[] args)
		{
			int M, N;
			int[,] A;

			string[] vet = Console.ReadLine().Split(' ');
			M = int.Parse(vet[0]);
			N = int.Parse(vet[1]);
			A = new int[M, N];

			for (int i = 0; i < M; i++)
			{
				vet = Console.ReadLine().Split(' ');
				for (int j = 0; j < N; j++)
				{
					A[i, j] = int.Parse(vet[j]);
				}
			}

			for (int i = 0; i < M; i++)
			{
				for (int j = 0; j < N; j++)
				{
					Console.Write(A[i, j] + " ");
				}
				Console.WriteLine();
			}
		}
	}
}