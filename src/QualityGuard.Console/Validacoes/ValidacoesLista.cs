namespace QualityGuard.Console.Validacoes
{
    public class ValidacoesLista
    {
        public List<int> RemoverNumerosNegativos(List<int> numeros)
        {
            return numeros.Where(n => n >= 0).ToList();
        }

        public bool ListaContemDeterminadoNumero(List<int> numeros, int numero)
        {
            return numeros.Contains(numero);
        }

        public List<int> MultiplicarNumerosLista(List<int> numeros, int multiplicador)
        {
            return numeros.Select(n => n * multiplicador).ToList();
        }

        public int RetornarMaiorNumeroLista(List<int> numeros)
        {
            return numeros.Max();
        }

        public int RetornarMenorNumeroLista(List<int> numeros)
        {
            return numeros.Min();
        }
    }
}
