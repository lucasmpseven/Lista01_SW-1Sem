class Program
{
    static void Main(string[] args)
    {
        // Exemplo de uso da classe RegistroDeComprass
        RegistroDeCompras registro = new RegistroDeCompras();
        registro.AdicionarCompra(DateTime.Now, "Camiseta", 29.99);
        registro.AdicionarCompra(DateTime.Now.AddDays(-1), "Calça", 59.99);
        registro.AdicionarCompra(DateTime.Now.AddDays(-2), "Meia", 9.99);

        registro.ListarCompras();
    }
}
