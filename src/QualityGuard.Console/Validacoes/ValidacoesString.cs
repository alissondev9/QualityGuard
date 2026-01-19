namespace QualityGuard.Console.Validacoes
{
    public class ValidacoesString
    {
        public int RetornarQuantidadeCaracteres(string texto)
        {
            return texto.Length;
        }

        public bool ContemCaractere(string texto, string trechoProcurado)
        {
            return texto.Contains(trechoProcurado);
        }

        public bool TextoTerminaCom(string texto, string trechoProcurado)
        {
            return texto.EndsWith(trechoProcurado);
        }
    }
}
