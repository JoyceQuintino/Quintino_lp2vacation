using System;
using Xunit;

namespace unittests
{
    public class UnitTest1
    {
        //private string nomeEsperado = "Joyce";

        [Fact]
        public void TestarNome()
        {
            Primeira p = new Primeira();
            Assert.Equal(p.imprimeNome(), "Joyce");
        }
    }
}
