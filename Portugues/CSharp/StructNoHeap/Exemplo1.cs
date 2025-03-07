namespace Exemplo1
{
    public struct MinhaStruct
    {
        public int Valor;
    }

    public class MinhaClasse
    {
        public MinhaStruct Data; // Armazenado no heap junto com a instância da classe
    }

    public class UsandoMinhaClasse
    {
        public void UsarMinhaClasse()
        {
            var obj = new MinhaClasse();
        }
    }
}