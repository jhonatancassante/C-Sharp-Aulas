using System;

namespace ExercicioProposto02
{
	class Program
	{
		static void Main(string[] args)
		{
			int N, quantidade;
			int[] numeros;

			N = int.Parse(Console.ReadLine());
			numeros = new int[N];
			quantidade = 0;

			string[] vet = Console.ReadLine().Split(' ');
			for (int i = 0; i < N; i++)
			{
				numeros[i] = int.Parse(vet[i]);
				if (numeros[i] % 2 == 0)
				{
					Console.Write(numeros[i] + " ");
					quantidade++;
				}
			}
			Console.WriteLine();
			Console.WriteLine(quantidade);
		}
	}
}