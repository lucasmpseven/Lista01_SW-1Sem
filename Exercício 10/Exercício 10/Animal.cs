using System;

class Animal
{
    public string Nome { get; set; }
    public string Especie { get; set; }
    public int Idade { get; set; }

    public Animal(string nome, string especie, int idade)
    {
        Nome = nome;
        Especie = especie;
        Idade = idade;
    }

    // Método que imprime na tela o som do animal
    public void EmitirSom()
    {
        switch (Especie.ToLower())
        {
            case "cachorro":
                Console.WriteLine($"{Nome} (Cachorro): Au Au!");
                break;
            case "gato":
                Console.WriteLine($"{Nome} (Gato): Miau!");
                break;
            case "vaca":
                Console.WriteLine($"{Nome} (Vaca): Muu!");
                break;
            case "pato":
                Console.WriteLine($"{Nome} (Pato): Quack!");
                break;
            default:
                Console.WriteLine($"{Nome} (Espécie desconhecida): Som desconhecido.");
                break;
        }
    }
}


