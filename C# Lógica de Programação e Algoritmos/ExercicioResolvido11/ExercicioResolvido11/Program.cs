using System;

namespace ExercicioResolvido11
{
	class Program
	{
		static void Main(string[] args)
		{
			int N, neg;
			int[,] mat;

			N = int.Parse(Console.ReadLine());
			mat = new int[N, N];
			neg = 0;

			for (int i = 0; i < N; i++)
			{
				string[] vet = Console.ReadLine().Split(' ');
				for (int j = 0; j < N; j++)
				{
					mat[i, j] = int.Parse(vet[j]);
				}
			}

			Console.WriteLine("DIAGONAL PRINCIPAL:");
			for (int i = 0; i < N; i++)
			{
				for (int j = 0; j < N; j++)
				{
					if (i == j)
					{
						Console.Write(mat[i, j] + " ");
					}
					if (mat[i, j] < 0)
					{
						neg++;
					}
				}
			}
			Console.WriteLine();
			Console.WriteLine("QUANTIDADE DE NEGATIVOS = " + neg);
		}
	}
}