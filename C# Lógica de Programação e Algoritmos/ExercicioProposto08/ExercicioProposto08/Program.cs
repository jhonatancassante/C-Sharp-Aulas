using System;

namespace ExercicioProposto08
{
	class Program
	{
		static void Main(string[] args)
		{
			int N, countMulheres, countHomens;
			double[] altura;
			char[] sexo;
			double menorAltura, maiorAltura, mediaMulheres, somaMulheres;

			N = int.Parse(Console.ReadLine());
			altura = new double[N];
			sexo = new char[N];
			somaMulheres = 0;
			countMulheres = 0;
			countHomens = 0;

			for (int i = 0; i < N; i++)
			{
				string[] vet = Console.ReadLine().Split(' ');
				altura[i] = double.Parse(vet[0]);
				sexo[i] = char.Parse(vet[1]);
			}

			menorAltura = altura[0];
			maiorAltura = altura[0];
			for (int i = 1; i < N; i++)
			{
				if (altura[i] < menorAltura)
				{
					menorAltura = altura[i];
				}
				else if (altura[i] > maiorAltura)
				{
					maiorAltura = altura[i];
				}

				if (sexo[i] == 'F')
				{
					somaMulheres += altura[i];
					countMulheres++;
				}
				else if (sexo[i] == 'M')
				{
					countHomens++;
				}
			}
			mediaMulheres = (double)(somaMulheres / countMulheres);

			Console.WriteLine("Menor altura = " + menorAltura.ToString("F2"));
			Console.WriteLine("Maior altura = " + maiorAltura.ToString("F2"));
			Console.WriteLine("Media das alturas das mulheres = " + mediaMulheres.ToString("F2"));
			Console.WriteLine("Numero de homens = " + countHomens);
		}
	}
}