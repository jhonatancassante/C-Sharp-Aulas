using System;

namespace A42_SegundoProblema
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Produto p = new Produto(nome, preco, quantidade);

            Console.WriteLine("Nome: " + p.Nome);
            Console.Write("Digite o novo nome do produto: ");
            p.Nome = Console.ReadLine();

            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int x = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(x);
            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            x = int.Parse(Console.ReadLine());
            p.RemoverProduto(x);
            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
        }
    }
}
