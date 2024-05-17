class Program
{
    static void Main(string[] args)
    {
        try
        {
            Livro livro = new Livro("Dom Quixote", "Miguel de Cervantes");
            Console.WriteLine($"Livro: {livro.Titulo}");
            Console.WriteLine($"Autor: {livro.Autor}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}