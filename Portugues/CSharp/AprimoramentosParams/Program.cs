
Concat("Olá", "mundo", "!");
Concat(1, 2, 3, 4, 5);

static void Concat<T>(params ReadOnlySpan<T> items)
{
    foreach (var item in items)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}