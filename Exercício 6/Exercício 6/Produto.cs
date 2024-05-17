using System;
using System.Collections.Generic;

class Produto
{
    public int Codigo { get; }
    public string Nome { get; }
    public double Preco { get; }
    public int QuantidadeEstoque { get; }

    public Produto(int codigo, string nome, double preco, int quantidadeEstoque)
    {
        Codigo = codigo;
        Nome = nome;
        Preco = preco;
        QuantidadeEstoque = quantidadeEstoque;
    }
}




