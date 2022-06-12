using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoTesteBE3;

namespace TestMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SomarDoisNumeros()
        {
            //Arrange - Preparaçãõ
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;

            //Act - Ação
            var resultado = Operacoes.Somar(pNum, sNum);

            //Assert - Verificãção
            Assert.AreEqual(rNum, resultado);
        }

        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(2, 2, 4)]
        [DataRow(2, 1, 2)]
        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            //Ação
            var resultado = Operacoes.Somar(pNum, sNum);

            //Assert - Verificação
            Assert.AreEqual(rNum, resultado);
        }
    }
}