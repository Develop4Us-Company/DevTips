public class Program
{
    public static void Main()
    {
        /*int[] numeros = new int[] { 1, 2, 3 };
        List<string> nomes = new List<string>()
        {
            "Ana", 
            "Bruno", 
            "Carlos"
        };*/

        // Podemos criar coleções de um jeito mais curto e fácil de ler
        int[] numeros = [1, 2, 3];
        List<string> nomes = ["Ana", "Bruno", "Carlos"];

        // Podemos juntar coleções
        int[] primeiros = [1, 2, 3];
        int[] ultimos = [7, 8, 9];

        int[] todos = [.. primeiros, 4, 5, 6, .. ultimos];

        foreach (var numero in todos)
        {
            Console.WriteLine(numero);
        }
    }
}