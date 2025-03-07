class Pessoa
{
    public string Nome;
}

public class UsandoHeap
{
    void Exemplo()
    {
        Pessoa p = new Pessoa(); // Guardado no heap
        p.Nome = "João";
    }
}
