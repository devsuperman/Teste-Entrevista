using App;
using Xunit;
using System.Collections.Generic;

namespace Tests
{
    public class FormatarArrayTest
    {
        [Fact]
        public void FormatarLista01()
        {
            var lista = new List<int>() { 3, 1, 1, 3 };

            var resultado = Formatador.FormatarLista(lista);

            Assert.Equal("3 = 2; 1 = 2;", resultado);
        }

        [Fact]
        public void FormatarLista02()
        {
            var lista = new List<int>() { 1, 3, 2, 2 };

            var resultado = Formatador.FormatarLista(lista);

            Assert.Equal("2 = 2;", resultado);
        }

        [Fact]
        public void FormatarLista03()
        {
            var lista = new List<int>() { 1, 1, 1, 3, 3, 2 };

            var resultado = Formatador.FormatarLista(lista);

            Assert.Equal("1 = 3; 3 = 2;", resultado);
        }

        [Fact]
        public void FormatarLista04()
        {
            var lista = new List<int>() { 3, 3, 1, 3, 3, 2 };

            var resultado = Formatador.FormatarLista(lista);

            Assert.Equal("3 = 4;", resultado);
        }
    }
}
