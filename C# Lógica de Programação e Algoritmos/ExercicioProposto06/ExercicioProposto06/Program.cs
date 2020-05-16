using System;

namespace ExercicioProposto06
{
	class Program
	{
		static void Main(string[] args)
		{
			int N, indice, maior;
			int[] idade;
			string[] nome;

			N = int.Parse(Console.ReadLine());
			idade = new int[N];
			nome = new string[N];
			indice = 0;
			maior = 0;

			for (int i = 0; i < N; i++)
			{
				string[] vet = Console.ReadLine().Split(' ');
				nome[i] = vet[0];
				idade[i] = int.Parse(vet[1]);
				if (idade[i] > maior)
				{
					maior = idade[i];
					indice = i;
				}
			}
			Console.WriteLine("Pessoa mais velha: " + nome[indice]);
		}
	}
}