public class Produto_JeitoAntigo
{
    private decimal _preco;

    public decimal Preco
    {
        get => _preco;
        set => _preco = value >= 0 ? value : throw new ArgumentOutOfRangeException(nameof(value), "O preço não pode ser negativo.");
    }
}

public class Produto
{
    public decimal Preco
    {
        get => field;
        set => field = value >= 0 ? value : throw new ArgumentOutOfRangeException(nameof(value), "O preço não pode ser negativo.");
    }
}

public class Program
{
    static void Main()
    {
        var produto = new Produto { Preco = 50 };
        Console.WriteLine($"Preço do produto: {produto.Preco}");

        // Produto com preço inválido
        try
        {
            produto.Preco = -10;
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}