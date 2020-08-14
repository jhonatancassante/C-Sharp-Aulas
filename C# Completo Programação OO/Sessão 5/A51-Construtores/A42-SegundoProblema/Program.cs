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
            Console.WriteLine();

            Produto a = new Produto(nome, preco);//Instanciar com construtor de dois argumentos
            Produto b = new Produto();//Instanciar pelo construtor padrão
            //Outra forma de instanciar a classe mesmo sem construtores seria:
            //se a caso não tiver o construtor padrão, ele deixa de funcionar.
            Produto c = new Produto()//Pode ser utilizado com ou sem parênteses
            {
                Nome = "TV",
                Preco = 900.00,
                Quantidade = 20
            };

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
