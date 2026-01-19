using QualityGuard.Console.Validacoes;
using Xunit;

namespace QualityGuard.Tests
{
    public class ValidacoesListaTests
    {
        private readonly ValidacoesLista _validacoesLista;

        public ValidacoesListaTests()
        {
            _validacoesLista = new ValidacoesLista();
        }

        [Fact]
        public void DeveRemoverNumerosNegativosDeUmaLista()
        {
            var lista = new List<int> { -5, 0, 3, -2, 8 };

            var resultado = _validacoesLista.RemoverNumerosNegativos(lista);

            Assert.DoesNotContain(resultado, n => n < 0);
        }

        [Fact]
        public void DeveConterONumero9NaLista()
        {
            var lista = new List<int> { 1, 3, 5, 9, 7 };

            var resultado = _validacoesLista.ListaContemDeterminadoNumero(lista, 9);

            Assert.True(resultado);
        }

        [Fact]
        public void NaoDeveConterONumero10NaLista()
        {
            var lista = new List<int> { 1, 3, 5, 9, 7 };

            var resultado = _validacoesLista.ListaContemDeterminadoNumero(lista, 10);

            Assert.False(resultado);
        }

        [Fact]
        public void DeveMultiplicarOsElementosDaListaPor2()
        {
            var lista = new List<int> { 1, 2, 3 };

            var resultado = _validacoesLista.MultiplicarNumerosLista(lista, 2);

            Assert.Equal(new List<int> { 2, 4, 6 }, resultado);
        }

        [Fact]
        public void DeveRetornar9ComoMaiorNumeroDaLista()
        {
            var lista = new List<int> { 1, 3, 9, 4 };

            var resultado = _validacoesLista.RetornarMaiorNumeroLista(lista);

            Assert.Equal(9, resultado);
        }

        [Fact]
        public void DeveRetornarOitoNegativoComoMenorNumeroDaList()
        {
            var lista = new List<int> { -8, -3, 0, 5 };

            var resultado = _validacoesLista.RetornarMenorNumeroLista(lista);

            Assert.Equal(-8, resultado);
        }
    }
}
