using System;

class Fabricante
{
    private string nome;
    public string Nome
    {
        get { return nome; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("O nome do fabricante não pode ser vazio ou nulo.");
            }
            nome = value;
        }
    }

    public string Endereco { get; set; }
    public string Cidade { get; set; }

    public Fabricante(string nome, string endereco, string cidade)
    {
        Nome = nome;
        Endereco = endereco;
        Cidade = cidade;
    }
}
