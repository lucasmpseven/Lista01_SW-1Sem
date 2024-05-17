class Program
{
    static void Main(string[] args)
    {
        // Exemplo de uso da classe Produto
        Produto p1 = new Produto("Teclados", 80.00, 50);
        p1.ExibirInformacoes();

        p1.AdicionarEstoque(20);
        p1.ExibirInformacoes();

        p1.RemoverEstoque(10);
        p1.ExibirInformacoes();

        p1.RemoverEstoque(100);
        p1.ExibirInformacoes();
    }
}
