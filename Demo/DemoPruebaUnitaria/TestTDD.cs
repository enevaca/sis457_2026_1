using DemoBiblioteca;

namespace DemoPruebaUnitaria
{
    [TestClass]
    public sealed class TestTDD
    {
        [TestMethod]
        public void TestFactorial()
        {
            Assert.AreEqual(24, Calculadora.factorial(4));
        }

        [TestMethod]
        public void TestFactorialNumeroNegativo()
        {
            Assert.AreEqual(-24, Calculadora.factorial(-4));
        }
    }
}
