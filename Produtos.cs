
using System.Globalization;


namespace TrabalhandoComClassesMelhoria
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        //Construtor a baixo
        public Produto(string nome,double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;

        }
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        //void significa vazio
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }
        //sobreposição
        public override string ToString()
        {
            return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}