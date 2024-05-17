class Program
{
    static void Main(string[] args)
    {
        GerenciadorDeTarefas gerenciador = new GerenciadorDeTarefas();

        // Exemplo de uso
        gerenciador.AdicionarTarefa("Estudar para o exame", new DateTime(2024, 5, 14));
        gerenciador.AdicionarTarefa("Fazer compras", new DateTime(2024, 5, 15));
        gerenciador.AdicionarTarefa("Enviar relatório", new DateTime(2024, 5, 14));

        gerenciador.ListarTarefas();
        gerenciador.ListarTarefasHoje();

        gerenciador.RemoverTarefa("Estudar para o exame");
        gerenciador.ListarTarefas();
    }
}
