using System;
using System.Collections.Generic;

class RegistroDeCompras
{
    // Classe interna para representar uma compraa
    class Compra
    {
        public DateTime Data { get; }
        public string Produto { get; }
        public double Valor { get; }

        public Compra(DateTime data, string produto, double valor)
        {
            Data = data;
            Produto = produto;
            Valor = valor;
        }
    }

    // Lista de compras
    private List<Compra> compras;

    // Construtor
    public RegistroDeCompras()
    {
        compras = new List<Compra>();
    }

    // Método para adicionar uma compra
    public void AdicionarCompra(DateTime data, string produto, double valor)
    {
        compras.Add(new Compra(data, produto, valor));
    }

    // Método para listar as compras
    public void ListarCompras()
    {
        Console.WriteLine("Lista de Compras:");
        foreach (var compra in compras)
        {
            Console.WriteLine($"Data: {compra.Data.ToShortDateString()} | Produto: {compra.Produto} | Valor: R${compra.Valor}");
        }
    }
}