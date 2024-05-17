
class Program
{
    static void Main(string[] args)
    {
        AgendaTelefônica agenda = new AgendaTelefônica();

        // Exemplo de uso
        agenda.AdicionarContato("João", "123456789", "joao@example.com");
        agenda.AdicionarContato("Maria", "987654321", "maria@example.com");
        agenda.AdicionarContato("Ana", "456123789", "ana@example.com");

        agenda.BuscarContato("João");
        agenda.BuscarContato("Carlos");

        agenda.RemoverContato("Maria");
        agenda.BuscarContato("Maria");
    }
}
