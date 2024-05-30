using CalculadoraClasses;
namespace Testes
{
    public class UnitTest1
    {
        Calculadora calc = new Calculadora();
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(3, 2, 5)]
        [InlineData(7, 1, 8)]
        public void Somar(int valor1, int valor2, int resultado)
        {
            int resultadoCalculadora = calc.Somar(valor1, valor2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(3, 2, 1)]
        [InlineData(7, 1, 6)]
        public void Subtração(int valor1, int valor2, int resultado)
        {
            int resultadoCalculadora = calc.Subtrair(valor1, valor2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(3, 2, 6)]
        [InlineData(7, 1, 7)]
        public void Multiplicação(int valor1, int valor2, int resultado)
        {
            int resultadoCalculadora = calc.Multiplicar(valor1, valor2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(2, 2, 1)]
        [InlineData(6, 3, 2)]
        [InlineData(7, 1, 7)]
        public void Divisão(int valor1, int valor2, int resultado)
        {
            int resultadoCalculadora = calc.Dividir(valor1, valor2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void DividirPorZero()
        {
            Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));
        }

        [Fact]
        public void MostrarHistorico()
        {
            int valor1 = 1;
            int valor2 = 2;
            int valor3 = 3;

            calc.AdicionarNoHistorico(valor1);
            calc.AdicionarNoHistorico(valor2);
            calc.AdicionarNoHistorico(valor3);
            List<int> resultadoCalculadora = calc.MostrarHistorico();

            Assert.Equal(3, resultadoCalculadora.Count);
        }
        [Fact]
        public void ValoresHistorico()
        {
            int valor1 = 1;
            int valor2 = 2;
            int valor3 = 3;
            int valor4 = 4;

            calc.AdicionarNoHistorico(valor1);
            calc.AdicionarNoHistorico(valor2);
            calc.AdicionarNoHistorico(valor3);
            calc.AdicionarNoHistorico(valor4);
            List<int> resultadoCalculadora = calc.MostrarHistorico();

            Assert.Equal(2, resultadoCalculadora[0]);
        }
    }
}