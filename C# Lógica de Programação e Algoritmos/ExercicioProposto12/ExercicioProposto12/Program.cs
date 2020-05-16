using System;

namespace ExercicioProposto12
{
	class Program
	{
		static void Main(string[] args)
		{
			int N, maior;
			int[,] mat;

			N = int.Parse(Console.ReadLine());
			mat = new int[N, N];

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
				maior = 0;
				for (int j = 0; j < N; j++)
				{
					if (mat[i, j] > maior)
					{
						maior = mat[i, j];
					}
				}
				Console.WriteLine(maior);
			}
		}
	}
}