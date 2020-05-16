using System;

namespace ExercicioProposto16
{
	class Program
	{
		static void Main(string[] args)
		{
			int M, N, X;
			int[,] pelotao;

			M = int.Parse(Console.ReadLine());
			N = int.Parse(Console.ReadLine());
			pelotao = new int[M, N];

			for (int i = 0; i < M; i++)
			{
				string[] s = Console.ReadLine().Split(' ');
				for (int j = 0; j < N; j++)
				{
					pelotao[i, j] = int.Parse(s[j]);
				}
			}

			X = int.Parse(Console.ReadLine());
			X--;

			int Y = pelotao[X, (N-1)];
			for (int j = (N-1); j > 0; j--)
			{
				pelotao[X, j] = pelotao[X, (j-1)];
			}
			pelotao[X, 0] = Y;

			for (int i = 0; i < M; i++)
			{
				for (int j = 0; j < N; j++)
				{
					Console.Write(pelotao[i, j] + " ");
				}
				Console.WriteLine();
			}
		}
	}
}