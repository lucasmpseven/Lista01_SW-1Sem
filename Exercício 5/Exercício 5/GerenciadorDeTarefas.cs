using System;
using System.Collections.Generic;

class GerenciadorDeTarefas
{
    // Classe interna para representar uma tarefa
    class Tarefa
    {
        public string Descricao { get; }
        public DateTime DataVencimento { get; }

        public Tarefa(string descricao, DateTime dataVencimento)
        {
            Descricao = descricao;
            DataVencimento = dataVencimento;
        }

        // Método para verificar se a tarefa deve ser executada no dia de hoje
        public bool DeveExecutarHoje()
        {
            return DataVencimento.Date == DateTime.Today;
        }
    }

    // Lista de tarefas
    private List<Tarefa> tarefas;

    // Construtor
    public GerenciadorDeTarefas()
    {
        tarefas = new List<Tarefa>();
    }

    // Método para adicionar uma tarefa
    public void AdicionarTarefa(string descricao, DateTime dataVencimento)
    {
        tarefas.Add(new Tarefa(descricao, dataVencimento));
        Console.WriteLine($"Tarefa '{descricao}' adicionada com sucesso.");
    }

    // Método para remover uma tarefa
    public void RemoverTarefa(string descricao)
    {
        for (int i = 0; i < tarefas.Count; i++)
        {
            if (tarefas[i].Descricao.Equals(descricao, StringComparison.OrdinalIgnoreCase))
            {
                tarefas.RemoveAt(i);
                Console.WriteLine($"Tarefa '{descricao}' removida com sucesso.");
                return;
            }
        }
        Console.WriteLine($"Tarefa '{descricao}' não encontrada.");
    }

    // Método para listar todas as tarefas
    public void ListarTarefas()
    {
        Console.WriteLine("Lista de Tarefas:");
        foreach (var tarefa in tarefas)
        {
            Console.WriteLine($"Descrição: {tarefa.Descricao} | Data de Vencimento: {tarefa.DataVencimento.ToShortDateString()}");
        }
    }

    // Método para listar as tarefas que devem ser executadas no dia de hoje
    public void ListarTarefasHoje()
    {
        Console.WriteLine("Tarefas a serem executadas hoje:");
        foreach (var tarefa in tarefas)
        {
            if (tarefa.DeveExecutarHoje())
            {
                Console.WriteLine($"Descrição: {tarefa.Descricao} | Data de Vencimento: {tarefa.DataVencimento.ToShortDateString()}");
            }
        }
    }
}

