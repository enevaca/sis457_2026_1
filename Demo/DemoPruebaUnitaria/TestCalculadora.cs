using DemoBiblioteca;

namespace DemoPruebaUnitaria
{
    [TestClass]
    public sealed class TestCalculadora
    {
        [TestMethod]
        public void TestSuma()
        {
            // Definimos las variables -> Arrage
            int numero1 = 7;
            int numero2 = 8;

            // Ejecutamos la prueba -> Act
            int resultado = Calculadora.sumar(numero1, numero2);

            // Comprobamos los resultados -> Assert
            int resultadoEsperado = 15;
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void TestResta()
        {
            int numero1 = 10, numero2 = 7;
            int resultado = Calculadora.restar(numero1, numero2);
            Assert.AreEqual(3, resultado);
        }

        [TestMethod]
        public void TestMultiplicacion()
        {
            int numero1 = 10, numero2 = 7;
            int resultado = Calculadora.multiplicar(numero1, numero2);
            Assert.AreEqual(70, resultado);
        }

        [TestMethod]
        public void TestDivision()
        {
            Assert.AreEqual(1, Calculadora.dividir(10, 7));
        }

        [TestMethod]
        public void TestDivisionPorCero()
        {
            int numero1 = 10, numero2 = 0;
            Assert.Throws<DivideByZeroException>(() => Calculadora.dividir(numero1, numero2));
        }

        [TestMethod]
        public void TestModulo()
        {
            int numero1 = 10, numero2 = 7;
            int resultado = Calculadora.modulo(numero1, numero2);
            Assert.AreEqual(3, resultado);
        }
    }
}
