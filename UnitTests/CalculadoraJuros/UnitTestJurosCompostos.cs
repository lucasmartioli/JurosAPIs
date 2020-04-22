using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculadoraJuros.Domain;

namespace UnitTests
{
    [TestClass]
    public class UnitTestJurosCompostos
    {
        [DataTestMethod]
        [DataRow(100, 5, 105.1d)]
        [DataRow(100, 200, 731.6d)]
        [DataRow(1, 15, 1.16d)]
        public void Calcular_ValorCorreto(double valorInicial, int meses, double valorFinal)
        {
            Assert.AreEqual(valorFinal, JurosCompostos.Calcular(valorInicial, 0.01d, meses));
        }
    }
}
