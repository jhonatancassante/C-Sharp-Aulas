namespace A42_SegundoProblema
{
    class Produto
    {
        //Atributos privados
        private string _nome;

        //Propriedades autoimplementadas
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        //Construtores
        public Produto()//Construtor padrão, se não tiver nenhum construtor, esse é válido mesmo se não tiver descrito
                        //Caso tenha algum outro construtor, esse não irá funcionar se não for escrito no código
        {
        }
        public Produto(string nome, double preco, int quantidade)//construtor com três argumentos
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }//Sobrecarga é quando você cria mais de um construtor

        //Propriedades customizadas
        public string Nome
        {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        //Outros métodos da classe
        public double ValorTotalEmEstoque()
        {
            return (double)Preco * Quantidade;
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
            return _nome
                + ", $ "
                + Preco.ToString("F2")
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2");
        }
    }
}
