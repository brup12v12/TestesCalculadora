using ProjetoTestesUC12;
using Xunit;

namespace OperacoesXUnit
{
    public class UnitXunitTest1
    {
        [Fact]
        public void SomarDoisNumeros_RetornarResultado()
        {
            //Arrange - Organiza��o;

            double primeiroNumero = 1;
            double segundoNumero = 2;
            double resultadoEsperado = 3;

            //Act - Execu��o;

            var resultado = Operacoes.Somar(primeiroNumero, segundoNumero);

            //Assert - Verifica��o;

            Assert.Equal(resultadoEsperado, resultado);

        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 2, 4)]
        [InlineData(3, 3, 4)]

        public void SomarDoisNumeros_RetornarResultado_Multiplos(double pNum, double sNum, double rEsp)
        {
            //Act - Execu��o;
            var resultado = Operacoes.Somar(pNum, sNum);

            //Assert - Verifica��o;
            Assert.Equal(rEsp, resultado);
        }
    }
}