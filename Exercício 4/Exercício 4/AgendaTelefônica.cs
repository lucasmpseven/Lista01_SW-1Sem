using System;
using System.Collections.Generic;

class AgendaTelefônica
{
    // Classe interna para representar um contato
    class Contato
    {
        public string Nome { get; }
        public string Telefone { get; }
        public string Email { get; }

        public Contato(string nome, string telefone, string email)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }
    }

    // Lista de contatos
    private List<Contato> contatos;

    // Construtor
    public AgendaTelefônica()
    {
        contatos = new List<Contato>();
    }

    // Método para adicionar um contato
    public void AdicionarContato(string nome, string telefone, string email)
    {
        contatos.Add(new Contato(nome, telefone, email));
        Console.WriteLine($"Contato {nome} adicionado com sucesso.");
    }

    // Método para remover um contato
    public void RemoverContato(string nome)
    {
        for (int i = 0; i < contatos.Count; i++)
        {
            if (contatos[i].Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
            {
                contatos.RemoveAt(i);
                Console.WriteLine($"Contato {nome} removido com sucesso.");
                return;
            }
        }
        Console.WriteLine($"Contato {nome} não encontrado.");
    }

    // Método para buscar um contato
    public void BuscarContato(string nome)
    {
        Console.WriteLine($"Buscando pelo contato {nome}:");
        bool encontrado = false;
        foreach (var contato in contatos)
        {
            if (contato.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Nome: {contato.Nome} | Telefone: {contato.Telefone} | Email: {contato.Email}");
                encontrado = true;
            }
        }
        if (!encontrado)
        {
            Console.WriteLine($"Contato {nome} não encontrado.");
        }
    }
}
