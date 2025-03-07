namespace Exemplo3
{
    struct MinhaStruct
    {
        public int Valor;
    }

    public class MinhaClasse
    {
        Func<int> CriarLambda()
        {
            MinhaStruct s = new MinhaStruct { Valor = 42 };
            return () => s.Valor; // Pode levar à alocação no heap
        }
    }
}