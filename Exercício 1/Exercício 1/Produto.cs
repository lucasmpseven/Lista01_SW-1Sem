using System;

class Produto
{
    // Atributos
    private string nome;
    private double preco;
    private int quantidadeEstoque;

    // Construtor
    public Produto(string nome, double preco, int quantidadeEstoque)
    {
        this.nome = nome;
        this.preco = preco;
        this.quantidadeEstoque = quantidadeEstoque;
    }

    // Método para adicionar itens ao estoque
    public void AdicionarEstoque(int quantidade)
    {
        quantidadeEstoque += quantidade;
        Console.WriteLine($"{quantidade} unidades de {nome} adicionadas ao estoque.");
    }

    // Método para remover itens do estoque
    public void RemoverEstoque(int quantidade)
    {
        if (quantidade <= quantidadeEstoque)
        {
            quantidadeEstoque -= quantidade;
            Console.WriteLine($"{quantidade} unidades de {nome} removidas do estoque.");
        }
        else
        {
            Console.WriteLine($"Não há {quantidade} unidades de {nome} suficientes no estoque.");
        }
    }

    // Método para exibir informações do produto
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Preço: R${preco}");
        Console.WriteLine($"Quantidade em estoque: {quantidadeEstoque} unidades\n");
    }
}