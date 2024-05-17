class Program
{
    static void Main(string[] args)
    {
        Carro meuCarro = new Carro("Fusca", 1985);

        // Acelerando o carro
        meuCarro.Acelerar();
        meuCarro.Acelerar();

        // Freando o carro
        meuCarro.Frear();
        meuCarro.Frear();
        meuCarro.Frear(); // Freando mais uma vez para garantir que a velocidade não seja negativa
    }
}
