using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoTestesUC12;

namespace OperacoesMsTest
{
    [TestClass]
    public class UnitMsTest1
    {
        [TestMethod]
        public void SomarDoisNumeros_RetornarResultado()
        {
            //Arrange - Organização;

            double primeiroNumero = 1;
            double segundoNumero = 2;
            double resultadoEsperado = 3;

            //Act - Execução;

            var resultado = Operacoes.Somar(primeiroNumero, segundoNumero);

            //Assert - Verificação;

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [DataTestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(2, 2, 4)]
        [DataRow(3, 3, 4)]
        public void SomarDoisNumeros_RetornarResultado_Multiplos(double pNum, double sNum, double rEsp)
        {
            //Act - Execução;
            var resultado = Operacoes.Somar(pNum, sNum);

            //Assert - Verificação;
            Assert.AreEqual(rEsp, resultado);
        }
    }

}