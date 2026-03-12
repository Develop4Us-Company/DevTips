public class Program
{
    public static void Main()
    {
        var produto = new Produto()
        {
            Id = 1,
            Nome = "Caneta"
        };

        var produtoService = new ProdutoService();
        produtoService.ImprimirProduto(produto);
    }
}