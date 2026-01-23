using System;

class Program
{
    static void Main()
    {
        UsandoSubstring();
        UsandoSpanAoInvesDeSubstring();

        ManipulandoArraySemSpan();
        ManipulandoArrayComSpan();
    }

    static void UsandoSubstring()
    {
        string texto = "Aprender C# é muito divertido!";

        // Pegando parte da string com Substring
        string parte = texto.Substring(9, 2); // Cria uma nova string "C#"

        Console.WriteLine(parte); // Saída: C#
    }

    static void UsandoSpanAoInvesDeSubstring()
    {
        ReadOnlySpan<char> texto = "Aprender C# é muito divertido!".AsSpan();

        // Pegando parte da string sem criar uma nova
        ReadOnlySpan<char> parte = texto.Slice(9, 2); // Referencia "C#"

        Console.WriteLine(parte.ToString()); // Saída: C#
    }

    static void ManipulandoArraySemSpan()
    {
        int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        // Criando um novo array apenas com os números do índice 2 ao 6
        int[] fatia = numeros.Skip(2).Take(5).ToArray();

        // Somando os valores da fatia
        int soma = fatia.Sum();

        Console.WriteLine($"Soma da fatia: {soma}"); // Saída: 25
    }

    static void ManipulandoArrayComSpan()
    {
        int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        // Criando uma fatia do array sem copiar dados
        Span<int> fatia = new Span<int>(numeros, 2, 5);

        // Somando os valores da fatia
        int soma = 0;
        foreach (var numero in fatia)
        {
            soma += numero;
        }

        Console.WriteLine($"Soma da fatia: {soma}"); // Saída: 25
    }
}
