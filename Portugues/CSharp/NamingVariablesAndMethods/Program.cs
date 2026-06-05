public class ItemVenda
{
    public int Quantidade { get; set; }
    public decimal ValorUnitario { get; set; }
    public decimal ValorTotal { get; set; }
}

public class PedidoVenda
{
    public string NomeCliente { get; set; }
    public List<ItemVenda> ItensVenda { get; } = new List<ItemVenda>();

    public void AdicionarItem(int quantidade, decimal valorUnitario)
    {
        ItemVenda itemVenda = new ItemVenda
        {
            Quantidade = quantidade,
            ValorUnitario = valorUnitario,
            ValorTotal = quantidade * valorUnitario
        };

        ItensVenda.Add(itemVenda);
    }
}

public class Program
{
    public static void Main()
    {
        PedidoVenda pedidoVenda1 = new PedidoVenda
        {
            NomeCliente = "João"
        };

        pedidoVenda1.AdicionarItem(2, 50.00m);
        pedidoVenda1.AdicionarItem(3, 30.00m);
    }
}