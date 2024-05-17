class Program
{
    static void Main(string[] args)
    {
        Agenda agenda = new Agenda();

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Armazenar Pessoa");
            Console.WriteLine("2. Remover Pessoa");
            Console.WriteLine("3. Buscar Pessoa");
            Console.WriteLine("4. Imprimir Agenda");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite o nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Digite a idade: ");
                    int idade = int.Parse(Console.ReadLine());
                    Console.Write("Digite a altura (em metros): ");
                    float altura = float.Parse(Console.ReadLine());
                    agenda.ArmazenaPessoa(nome, idade, altura);
                    break;
                case "2":
                    Console.Write("Digite o nome da pessoa a remover: ");
                    nome = Console.ReadLine();
                    agenda.RemovePessoa(nome);
                    break;
                case "3":
                    Console.Write("Digite o nome da pessoa a buscar: ");
                    nome = Console.ReadLine();
                    Pessoa pessoa = agenda.BuscaPessoa(nome);
                    if (pessoa != null)
                    {
                        Console.WriteLine("Pessoa encontrada: " + pessoa);
                    }
                    else
                    {
                        Console.WriteLine("Pessoa não encontrada.");
                    }
                    break;
                case "4":
                    agenda.ImprimeAgenda();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}