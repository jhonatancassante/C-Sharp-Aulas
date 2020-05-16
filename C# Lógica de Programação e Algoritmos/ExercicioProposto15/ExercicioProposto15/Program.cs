using System;

namespace ExercicioProposto15
{
	class Program
	{
		static void Main(string[] args)
		{
			int X;
			double[,] A;

			X = int.Parse(Console.ReadLine());
			A = new double[X, X];

			for (int i = 0; i < X; i++)
			{
				string[] s = Console.ReadLine().Split(' ');
				for (int j = 0; j < X; j++)
				{
					A[i, j] = double.Parse(s[j]);
				}
			}

			//a) SOMA DOS POSITIVOS
			double soma = 0.0;
			for (int i = 0; i < X; i++)
			{
				for (int j = 0; j < X; j++)
				{
					if (A[i, j] >= 0)
					{
						soma += A[i, j];
					}
				}
			}
			Console.WriteLine("SOMA DOS POSITIVOS: " + soma.ToString("F1"));

			//b) LINHA ESCOLHIDA
			int Y = int.Parse(Console.ReadLine());
			Console.Write("LINHA ESCOLHIDA: ");
			for (int j = 0; j < X; j++)
			{
				Console.Write(A[Y, j].ToString("F1") + " ");
			}
			Console.WriteLine();

			//c) COLUNA ESCOLHIDA
			Y = int.Parse(Console.ReadLine());
			Console.Write("COLUNA ESCOLHIDA: ");
			for (int i = 0; i < X; i++)
			{
				Console.Write(A[i, Y].ToString("F1") + " ");
			}
			Console.WriteLine();

			//d) DIAGONAL PRINCIPAL
			Console.Write("DIAGONAL PRINCIPAL: ");
			for (int i = 0; i < X; i++)
			{
				Console.Write(A[i, i].ToString("F1") + " ");
			}
			Console.WriteLine();

			//e) MATRIZ ALTERADA
			Console.WriteLine("MATRIZ ALTERADA:");
			for (int i = 0; i < X; i++)
			{
				for (int j = 0; j < X; j++)
				{
					if (A[i, j] < 0)
					{
						A[i, j] = Math.Pow(A[i, j], 2);
					}
					Console.Write(A[i, j].ToString("F1") + " ");
				}
				Console.WriteLine();
			}
		}
	}
}