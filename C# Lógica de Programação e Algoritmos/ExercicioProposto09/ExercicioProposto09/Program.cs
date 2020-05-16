using System;

namespace ExercicioProposto09
{
	class Program
	{
		static void Main(string[] args)
		{
			int N, lucro10, lucro10e20, lucro20;
			double totalCompra, totalVenda, lucroTotal;
			double[] compra, venda;
			string[] nome;

			N = int.Parse(Console.ReadLine());
			nome = new string[N];
			compra = new double[N];
			venda = new double[N];
			lucro10 = 0;
			lucro10e20 = 0;
			lucro20 = 0;
			totalCompra = 0.0;
			totalVenda = 0.0;

			for (int i = 0; i < N; i++)
			{
				string[] vet = Console.ReadLine().Split(' ');
				nome[i] = vet[0];
				compra[i] = double.Parse(vet[1]);
				venda[i] = double.Parse(vet[2]);
			}

			for (int i = 0; i < N; i++)
			{
				double lucro, porcentagem;
				lucro = (double)(venda[i] - compra[i]);
				porcentagem = (double)((lucro * 100) / compra[i]);


				if (porcentagem < 10)
				{
					lucro10++;
				}
				else if (porcentagem >= 10 && porcentagem <= 20)
				{
					lucro10e20++;
				}
				else
				{
					lucro20++;
				}
			}

			foreach (double x in compra)
			{
				totalCompra += x;
			}
			foreach (double x in venda)
			{
				totalVenda += x;
			}
			lucroTotal = totalVenda - totalCompra;

			Console.WriteLine("Lucro abaixo de 10%: " + lucro10);
			Console.WriteLine("Lucro entre 10% e 20%: " + lucro10e20);
			Console.WriteLine("Lucro acima de 20%: " + lucro20);
			Console.WriteLine("Valor total de compra: " + totalCompra.ToString("F2"));
			Console.WriteLine("Valor total de venda: " + totalVenda.ToString("F2"));
			Console.WriteLine("Lucro total: " + lucroTotal.ToString("F2"));
		}
	}
}