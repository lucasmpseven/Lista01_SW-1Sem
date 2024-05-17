class Program
{
    static void Main(string[] args)
    {
        GerenciadorDeProdutos gerenciador = new GerenciadorDeProdutos();

        // Adicionar alguns produtos para exemplo
        gerenciador.AdicionarProduto(1, "Camiseta", 29.99, 50);
        gerenciador.AdicionarProduto(2, "Calça Jeans", 79.99, 30);
        gerenciador.AdicionarProduto(3, "Tênis", 99.99, 20);

        gerenciador.ApresentarProdutos();

        // Consultar produto pelo código
        Console.WriteLine("\nConsultar Produto pelo Código:");
        Console.Write("Digite o código do produto: ");
        int codigo = int.Parse(Console.ReadLine());

        Produto produtoConsultado = gerenciador.ConsultarProduto(codigo);
        if (produtoConsultado != null)
        {
            Console.WriteLine($"Produto encontrado: {produtoConsultado.Nome} | Preço: R${produtoConsultado.Preco} | Quantidade em Estoque: {produtoConsultado.QuantidadeEstoque}");
        }
        else
        {
            Console.WriteLine("Produto não encontrado.");
        }
    }
}