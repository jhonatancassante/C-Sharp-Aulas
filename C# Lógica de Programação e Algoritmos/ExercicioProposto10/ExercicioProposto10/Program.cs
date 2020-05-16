﻿using System;

namespace ExercicioProposto10
{
	class Program
	{
		static void Main(string[] args)
		{
			int M, N;
			int[,] mat;

			string[] s = Console.ReadLine().Split(' ');
			M = int.Parse(s[0]);
			N = int.Parse(s[1]);
			mat = new int[M, N];

			for (int i = 0; i < M; i++)
			{
				s = Console.ReadLine().Split(' ');
				for (int j = 0; j < N; j++)
				{
					mat[i, j] = int.Parse(s[j]);
				}
			}

			Console.WriteLine("VALORES NEGATIVOS:");
			for (int i = 0; i < M; i++)
			{
				for (int j = 0; j < N; j++)
				{
					if (mat[i, j] < 0)
					{
						Console.WriteLine(mat[i, j]);
					}
				}
			}
		}
	}
}