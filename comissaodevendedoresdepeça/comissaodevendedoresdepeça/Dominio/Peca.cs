class Peca
{
    public int Codigo { get; set; }
    public string Descricao { get; set; }
    public double PrecoUnitario { get; set; }
    public int QuantidadeVendida { get; set; }

    public double CalcularTotal()
    {
        return PrecoUnitario * QuantidadeVendida;
    }
}

