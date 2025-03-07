using System;

struct Ponto
{
    public int X;
    public int Y;

    public Ponto(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Exibir()
    {
        Console.WriteLine($"Ponto: ({X}, {Y})");
    }
}

class Program
{
    static void Main()
    {
        Ponto p = new Ponto(3, 5);
        p.Exibir(); // Saída: Ponto: (3, 5)
    }
}
