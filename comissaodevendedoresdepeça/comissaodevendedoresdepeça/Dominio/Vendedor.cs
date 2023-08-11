class Vendedor
{
    public int Identificacao { get; set; }
    public string Nome { get; set; }
    public double Comissao { get; private set; }

    public Vendedor(int identificacao, string nome)
    {
        Identificacao = identificacao;
        Nome = nome;
    }
}

