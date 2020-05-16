using System;

namespace ExercicioResolvido12
{
	class Program
	{
		static void Main(string[] args)
		{
			int M, N;
			int[,] A;
			int[] B;

			string[] vet = Console.ReadLine().Split(' ');
			M = int.Parse(vet[0]);
			N = int.Parse(vet[1]);
			A = new int[M, N];
			B = new int[M];

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
				B[i] = 0;
				for (int j = 0; j < N; j++)
				{
					B[i] += A[i, j];
				}
				Console.WriteLine(B[i]);
			}
		}
	}
}