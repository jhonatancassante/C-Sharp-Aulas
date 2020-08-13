using System;

namespace A42_SegundoProblema
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto a = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            a.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            a.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            a.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Dados do produto: " + a);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int x = int.Parse(Console.ReadLine());
            a.AdicionarProdutos(x);
            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + a);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            x = int.Parse(Console.ReadLine());
            a.RemoverProduto(x);
            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + a);
            Console.WriteLine();
        }
    }
}
