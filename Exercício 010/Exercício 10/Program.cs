class Program
{
    static void Main(string[] args)
    {
        Animal cachorro = new Animal("Rex", "Cachorro", 5);
        Animal gato = new Animal("Mimi", "Gato", 3);
        Animal vaca = new Animal("Mimosa", "Vaca", 4);
        Animal pato = new Animal("Donald", "Pato", 2);

        cachorro.EmitirSom();
        gato.EmitirSom();
        vaca.EmitirSom();
        pato.EmitirSom();
    }
}