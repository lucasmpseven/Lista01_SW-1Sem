
class Produto
{
    private string nome;
    public string Nome
    {
        get { return nome; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("O nome do produto não pode ser vazio ou nulo.");
            }
            nome = value;
        }
    }

    private Fabricante fabricante;
    public Fabricante Fabricante
    {
        get { return fabricante; }
        set { fabricante = value; }
    }

    private double preco;
    public double Preco
    {
        get { return preco; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("O preço do produto deve ser positivo.");
            }
            preco = value;
        }
    }

    public Produto(string nome, Fabricante fabricante, double preco)
    {
        Nome = nome;
        Fabricante = fabricante;
        Preco = preco;
    }
}
