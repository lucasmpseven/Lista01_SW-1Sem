class Agenda
{
    private List<Pessoa> pessoas = new List<Pessoa>();

    public void ArmazenaPessoa(string nome, int idade, float altura)
    {
        pessoas.Add(new Pessoa(nome, idade, altura));
    }

    public void RemovePessoa(string nome)
    {
        pessoas.RemoveAll(p => p.Nome == nome);
    }

    public Pessoa BuscaPessoa(string nome)
    {
        return pessoas.Find(p => p.Nome == nome);
    }

    public void ImprimeAgenda()
    {
        foreach (var pessoa in pessoas)
        {
            Console.WriteLine(pessoa);
        }
    }
}