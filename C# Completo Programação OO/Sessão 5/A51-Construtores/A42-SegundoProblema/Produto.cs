namespace A42_SegundoProblema
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto()//Construtor padrão, se não tiver nenhum construtor, esse é válido mesmo se não tiver descrito
                        //Caso tenha algum outro construtor, esse não irá funcionar se não for escrito no código
        {
            Quantidade = 10;
        }
        public Produto(string nome, double preco) : this()//Construtor com dois argumentos
        {
            Nome = nome;
            Preco = preco;
        }
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)//construtor com três argumentos
        {
            Quantidade = quantidade;
        }
        //Sobrecarga é quando você cria mais de um construtor

        public double ValorTotalEmEstoque()
        {
            return (double) Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProduto(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome
                + ", $ "
                + Preco.ToString("F2")
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2");
        }
    }
}
