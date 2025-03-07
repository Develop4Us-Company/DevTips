namespace Exemplo4
{
    public ref struct MinhaRefStruct
    {
        public int Valor;

        public MinhaRefStruct(int valor)
        {
            Valor = valor;
        }
    }

    public class MinhaClasse
    {
        // ERRO: 'ref struct' não pode ser um campo de uma classe
        // public MinhaRefStruct Data;
    }
}