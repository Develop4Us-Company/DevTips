namespace Exemplo2
{
    struct MinhaStruct
    {
        public int Valor;
    }

    public class UsandoMinhaStruct
    {
        public void UsarMinhaStruct()
        {
            object obj = new MinhaStruct { Valor = 10 }; // Boxing: agora está no heap
        }
    }
}