using System;

public interface IProcessamento
{
    void Processar();
}

public ref struct Processador : IProcessamento
{
    public void Processar()
    {
        Console.WriteLine("Processamento executado.");
    }
}

class Program
{
    static void Main()
    {
        var processador = new Processador();
        processador.Processar(); // Saída: Processamento executado.
    }
}
