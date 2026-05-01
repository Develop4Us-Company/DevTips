using System.Runtime.CompilerServices;

[InlineArray(5)]
public struct NotasAluno
{
    private int primeiraNota;
}

public class Program
{
    public static void Main()
    {
        int[] notasUsandoArrayComum = new int[5];
        notasUsandoArrayComum[0] = 10;
        notasUsandoArrayComum[1] = 9;

        NotasAluno notas = default;

        notas[0] = 8;
        notas[1] = 7;
        notas[2] = 10;
        notas[3] = 6;
        notas[4] = 9;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Nota {i + 1}: {notas[i]}");
        }
    }
}