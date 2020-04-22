using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaxaJurosAPI;

namespace UnitTests
{
    [TestClass]
    public class UnitTestTaxasDeJuro
    {
        [TestMethod]
        public void TaxaFixa_ValorCorreto()
        {
            Assert.AreEqual(0.01d, TaxasDeJuro.TaxaFixa);
        }
    }
}
