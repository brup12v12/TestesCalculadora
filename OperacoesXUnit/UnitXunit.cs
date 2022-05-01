using ProjetoTestesUC12;
using Xunit;

namespace OperacoesXUnit
{
    public class UnitXunit
    {
        [Fact]
        public void SomarDoisNumeros_RetornarResultado()
        {
            //Arrange - Organização;

            double primeiroNumero = 1;
            double segundoNumero = 2;
            double resultadoEsperado = 3;

            //Act - Execução;

            var resultado = Operacoes.Somar(primeiroNumero, segundoNumero);

            //Assert - Verificação;

            Assert.Equal(resultadoEsperado, resultado);

        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 2, 4)]
        [InlineData(3, 3, 4)]

        public void SomarDoisNumeros_RetornarResultado_Multiplos(double pNum, double sNum, double rEsp)
        {
            //Act - Execução;
            var resultado = Operacoes.Somar(pNum, sNum);

            //Assert - Verificação;
            Assert.Equal(rEsp, resultado);
        }
    }
}