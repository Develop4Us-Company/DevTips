// Declaração da propriedade parcial
public partial class Produto
{
    public partial decimal Preco { get; set; }
}

// Implementação da propriedade parcial
public partial class Produto
{
    private decimal preco;

    public partial decimal Preco
    {
        get => preco;
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value), "O preço não pode ser negativo.");
            preco = value;
        }
    }
}

public class Program
{
    public static void Main()
    {
        var produto = new Produto();
        produto.Preco = 10;

        Console.WriteLine("O preço do produto é: " + produto.Preco);
    }
}