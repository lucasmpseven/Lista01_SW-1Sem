using System;
using System.Collections.Generic;

class CorretoraDeImóveis
{
    // Classe interna para representar um imóvell
    class Imovel
    {
        public string Endereco { get; }
        public double Preco { get; set; }
        public string Tipo { get; }

        public Imovel(string endereco, double preco, string tipo)
        {
            Endereco = endereco;
            Preco = preco;
            Tipo = tipo;
        }
    }

    // Lista de imóveis
    private List<Imovel> imoveis;

    // Construtor
    public CorretoraDeImóveis()
    {
        imoveis = new List<Imovel>();
    }

    // Método para inserir um imóvel
    public void InserirImovel(string endereco, double preco, string tipo)
    {
        imoveis.Add(new Imovel(endereco, preco, tipo));
    }

    // Método para alterar o preço de um imóvel
    public void AlterarPreco(string endereco, double novoPreco)
    {
        foreach (var imovel in imoveis)
        {
            if (imovel.Endereco.Equals(endereco, StringComparison.OrdinalIgnoreCase))
            {
                imovel.Preco = novoPreco;
                Console.WriteLine($"Preço do imóvel no endereço {endereco} alterado para R${novoPreco}.");
                return;
            }
        }
        Console.WriteLine($"Imóvel no endereço {endereco} não encontrado.");
    }

    // Método para listar todos os imóveis
    public void ListarImoveis()
    {
        Console.WriteLine("Lista de Imóveis Disponíveis:");
        foreach (var imovel in imoveis)
        {
            Console.WriteLine($"Endereço: {imovel.Endereco} | Preço: R${imovel.Preco} | Tipo: {imovel.Tipo}");
        }
    }

    // Método para calcular o valor médio dos imóveis
    public double CalcularValorMedio()
    {
        if (imoveis.Count == 0)
        {
            Console.WriteLine("Não há imóveis disponíveis para calcular o valor médio.");
            return 0;
        }

        double somaPrecos = 0;
        foreach (var imovel in imoveis)
        {
            somaPrecos += imovel.Preco;
        }

        return somaPrecos / imoveis.Count;
    }

    // Método para exibir o menu
    private void ExibirMenu()
    {
        Console.WriteLine("\nMenu:");
        Console.WriteLine("1. Inserir Imóvel");
        Console.WriteLine("2. Alterar Preço do Imóvel");
        Console.WriteLine("3. Apresentar todos os Imóveis");
        Console.WriteLine("4. Calcular Valor Médio dos Imóveis");
        Console.WriteLine("5. Sair");
    }

    // Método principal para executar o programa
    public void Executar()
    {
        bool sair = false;
        while (!sair)
        {
            ExibirMenu();
            Console.Write("\nEscolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Endereço do Imóvel: ");
                    string endereco = Console.ReadLine();
                    Console.Write("Preço do Imóvel: ");
                    double preco = double.Parse(Console.ReadLine());
                    Console.Write("Tipo do Imóvel: ");
                    string tipo = Console.ReadLine();
                    InserirImovel(endereco, preco, tipo);
                    break;
                case "2":
                    Console.Write("Endereço do Imóvel para Alterar o Preço: ");
                    string enderecoAlteracao = Console.ReadLine();
                    Console.Write("Novo Preço: ");
                    double novoPreco = double.Parse(Console.ReadLine());
                    AlterarPreco(enderecoAlteracao, novoPreco);
                    break;
                case "3":
                    ListarImoveis();
                    break;
                case "4":
                    Console.WriteLine($"Valor Médio dos Imóveis: R${CalcularValorMedio()}");
                    break;
                case "5":
                    sair = true;
                    break;
                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                    break;
            }
        }
    }
}

