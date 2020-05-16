using System;

namespace ExercicioProposto13
{
	class Program
	{
		static void Main(string[] args)
		{
			int N, soma;
			int[,] mat;

			N = int.Parse(Console.ReadLine());
			mat = new int[N, N];
			soma = 0;

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
				for (int j = 0; j < N; j++)
				{
					if (i == j)
					{
						soma += mat[i, j];
					}
				}
			}
			Console.WriteLine(soma);
		}
	}
}