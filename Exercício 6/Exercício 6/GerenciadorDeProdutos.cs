class GerenciadorDeProdutos
{
    private List<Produto> produtos;

    public GerenciadorDeProdutos()
    {
        produtos = new List<Produto>();
    }

    public void AdicionarProduto(int codigo, string nome, double preco, int quantidadeEstoque)
    {
        produtos.Add(new Produto(codigo, nome, preco, quantidadeEstoque));
    }

    public void ApresentarProdutos()
    {
        Console.WriteLine("Lista de Produtos:");
        foreach (var produto in produtos)
        {
            Console.WriteLine($"Código: {produto.Codigo} | Nome: {produto.Nome} | Preço: R${produto.Preco} | Quantidade em Estoque: {produto.QuantidadeEstoque}");
        }
    }

    public Produto ConsultarProduto(int codigo)
    {
        foreach (var produto in produtos)
        {
            if (produto.Codigo == codigo)
            {
                return produto;
            }
        }
        return null;
    }
}