using System;

class Carro
{
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public int Velocidade { get; private set; }

    public Carro(string modelo, int ano)
    {
        Modelo = modelo;
        Ano = ano;
        Velocidade = 0;
    }

    // Método para acelerar o carro (aumentando a velocidade em 10)
    public void Acelerar()
    {
        Velocidade += 10;
        Console.WriteLine($"O carro {Modelo} acelerou. Velocidade atual: {Velocidade} km/h");
    }

    // Método para frear o carro (diminuindo a velocidade em 10, mas nunca deixando a velocidade negativa)
    public void Frear()
    {
        Velocidade -= 10;
        if (Velocidade < 0)
        {
            Velocidade = 0;
        }
        Console.WriteLine($"O carro {Modelo} freou. Velocidade atual: {Velocidade} km/h");
    }
}

