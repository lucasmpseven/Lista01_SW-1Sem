using System;
using System.Collections.Generic;

class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public float Altura { get; set; }

    public Pessoa(string nome, int idade, float altura)
    {
        Nome = nome;
        Idade = idade;
        Altura = altura;
    }

    public override string ToString()
    {
        return $"Nome: {Nome}, Idade: {Idade}, Altura: {Altura}m";
    }
}




