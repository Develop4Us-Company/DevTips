public class Exemplo
{
    public const int TempoMaximo = 30;

    public Exemplo(int tempoMaximo)
    {
        // Dá erro
        // this.TempoMaximo = tempoMaximo;
    }
}

public class ExemploReadonly
{
    public readonly int TempoMaximo;

    public ExemploReadonly(int tempoMaximo)
    {
        this.TempoMaximo = tempoMaximo;
    }

    public void AlterarTempoMaximo(int tempoMaximo)
    {
        // Dá erro
        // this.TempoMaximo = tempoMaximo;
    }
}

public class Program
{
    public static void Main()
    {
        ExemploReadonly exemploReadonly = new ExemploReadonly(30);
    }
}