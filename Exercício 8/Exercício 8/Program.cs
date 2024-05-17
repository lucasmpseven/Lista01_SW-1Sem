
class Program
{
    static void Main(string[] args)
    {
        Fabricante fabricante = new Fabricante("Empresa ABC", "Rua A, 123", "Cidade XPTO");
        Produto produto = new Produto("Notebook", fabricante, 2500.00);

        Console.WriteLine($"Produto: {produto.Nome}");
        Console.WriteLine($"Fabricante: {produto.Fabricante.Nome}");
        Console.WriteLine($"Preço: R${produto.Preco}");
    }
}
