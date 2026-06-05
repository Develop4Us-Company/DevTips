public class Produto
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }

    public void AtualizarPreco(decimal novoPreco)
    {
        if (novoPreco != Preco)
        {
            Console.WriteLine($"Log: A propriedade {nameof(Preco)} foi atualizada de {Preco:C} para {novoPreco:C}");
            Preco = novoPreco;
        }
    }
}

public class Program
{
    public static void Main()
    {
        Produto produto = new Produto{ Nome = "Caneta", Preco = 2.99m};
        produto.AtualizarPreco(3.49m); // Loga a mudança de preço
    }
}