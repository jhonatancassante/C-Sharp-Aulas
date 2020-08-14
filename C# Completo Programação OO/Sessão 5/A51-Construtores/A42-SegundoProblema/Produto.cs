namespace A42_SegundoProblema
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto()//Construtor padrão, se não tiver nenhum construtor, esse é válido mesmo se não tiver descrito
                        //Caso tenha algum outro construtor, esse não irá funcionar se não for escrito no código
        {
        }
        public Produto(string nome, double preco, int quantidade)//construtor com três argumentos
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }
        //Sobrecarga é quando você cria mais de um construtor

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
        public double Preco
        {
            get { return _preco; }
        }
        public int Quantidade
        {
            get { return _quantidade; }
        }

        public double ValorTotalEmEstoque()
        {
            return (double)_preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverProduto(int quantidade)
        {
            _quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome
                + ", $ "
                + _preco.ToString("F2")
                + ", "
                + _quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2");
        }
    }
}
