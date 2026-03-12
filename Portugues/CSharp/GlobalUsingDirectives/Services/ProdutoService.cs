using System;

namespace Services;

public class ProdutoService
{
    public void ImprimirProduto(Produto produto)
    {
        Console.WriteLine($"Imprimindo {produto.Nome}...");
    }
}
