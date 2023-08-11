using System;

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cadastro de Vendedor");
            Console.Write("Identificação do Vendedor: ");
            int vendedorId = int.Parse(Console.ReadLine());
            Console.Write("Nome do Vendedor: ");
            string vendedorNome = Console.ReadLine();
            
            Vendedor vendedor = new Vendedor(vendedorId, vendedorNome);

            Console.WriteLine("\nCadastro de Peça");
            Console.Write("Código da Peça: ");
            int pecaCodigo = int.Parse(Console.ReadLine());
            Console.Write("Descrição da Peça: ");
            string pecaDescricao = Console.ReadLine();
            Console.Write("Preço Unitário da Peça: ");
            double pecaPrecoUnitario = double.Parse(Console.ReadLine());
            Console.Write("Quantidade Vendida: ");
            int pecaQuantidadeVendida = int.Parse(Console.ReadLine());

            Peca peca = new Peca
            {
                Codigo = pecaCodigo,
                Descricao = pecaDescricao,
                PrecoUnitario = pecaPrecoUnitario,
                QuantidadeVendida = pecaQuantidadeVendida
            };

            double totalVenda = peca.CalcularTotal();

            CalculadoraComissao calculadora = new CalculadoraComissao();
            double comissao = calculadora.CalcularComissao(totalVenda);

            Console.WriteLine("\nDetalhes da Venda:");
            Console.WriteLine($"Vendedor: {vendedor.Nome}");
            Console.WriteLine($"Peça: {peca.Descricao}");
            Console.WriteLine($"Total da Venda: R${totalVenda:F2}");
            Console.WriteLine($"Comissão do Vendedor: R${comissao:F2}");
        }
    }
}

