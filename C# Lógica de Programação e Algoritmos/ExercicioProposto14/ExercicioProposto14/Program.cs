﻿using System;

namespace ExercicioProposto14
{
	class Program
	{
		static void Main(string[] args)
		{
			int N, M;
			int[,] A, B, C;

			string[] s = Console.ReadLine().Split(' ');
			M = int.Parse(s[0]);
			N = int.Parse(s[1]);
			A = new int[M, N];
			B = new int[M, N];
			C = new int[M, N];

			for (int i = 0; i < M; i++)
			{
				s = Console.ReadLine().Split(' ');
				for (int j = 0; j < N; j++)
				{
					A[i, j] = int.Parse(s[j]);
				}
			}
			for (int i = 0; i < M; i++)
			{
				s = Console.ReadLine().Split(' ');
				for (int j = 0; j < N; j++)
				{
					B[i, j] = int.Parse(s[j]);
				}
			}

			for (int i = 0; i < M; i++)
			{
				for (int j = 0; j < N; j++)
				{
					C[i, j] = A[i, j] + B[i, j];
					Console.Write(C[i, j] + " ");
				}
				Console.WriteLine();
			}
		}
	}
}