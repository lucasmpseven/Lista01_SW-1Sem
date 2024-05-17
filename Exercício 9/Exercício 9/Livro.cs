using System;

class Livro
{
    private string titulo;
    public string Titulo
    {
        get { return titulo; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("O título do livro não pode ser vazio ou nulo.");
            }
            titulo = value;
        }
    }

    private string autor;
    public string Autor
    {
        get { return autor; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("O autor do livro não pode ser vazio ou nulo.");
            }
            autor = value;
        }
    }

    public Livro(string titulo, string autor)
    {
        Titulo = titulo;
        Autor = autor;
    }
}


