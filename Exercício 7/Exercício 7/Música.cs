using System;
using System.Collections.Generic;

class Música
{
    public string Nome { get; }
    public string Autor { get; }
    public string Gravadora { get; }

    public Música(string nome, string autor, string gravadora)
    {
        Nome = nome;
        Autor = autor;
        Gravadora = gravadora;
    }
}
