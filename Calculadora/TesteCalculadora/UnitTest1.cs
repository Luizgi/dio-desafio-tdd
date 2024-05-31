using Xunit;
using System;
using Calculadora;

namespace TesteCalculadora
{
    public class UnitTest1
    {
        public Calculator GetCalc()
        {
            string data = "02/02/2020";
            Calculator calculator = new Calculator();

            return calculator;
        }

        [Theory]
        [InlineData(1, 2, 3)]
        public void TestPlus(int num1, int num2, int result)
        {
            Calculator calc = GetCalc();

            int resultCalc = calc.Plus(num1, num2);

            Assert.Equal(result, resultCalc);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(2, 2, 4)]
        public void TestMultiply(int num1, int num2, int result)
        {
            Calculator calc = GetCalc();

            int resultCalc = calc.Multiply(num1, num2);

            Assert.Equal(result, resultCalc);
        }

        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(3, 2, 1)]
        public void TestMinus(int num1, int num2, int result)
        {
            Calculator calc = GetCalc();

            int resultCalc = calc.Minus(num1, num2);

            Assert.Equal(result, resultCalc);
        }
        
        [Theory]
        [InlineData(6, 3, 2)]
        [InlineData(3, 3, 1)]
        public void TestDivide(int num1, int num2, int result)
        {
            Calculator calc = GetCalc();  

            int resultCalc = calc.Divide(num1, num2);

            Assert.Equal(result, resultCalc);
        }

        [Fact]
        public void TryDivideBy0()
        {
            Calculator calc = GetCalc();

            Assert.Throws<DivideByZeroException>(() => calc.Divide(3, 0)
            );
        }

        [Fact]
        public void TryHistoric()
        {
            Calculator calc = GetCalc();

            calc.Plus(1, 2);
            calc.Plus(2, 4);
            calc.Plus(3, 4);
            calc.Plus(4, 5);

            var list = calc.History();

            Assert.NotEmpty(calc.History());
            Assert.Equal(3, list.Count);

        }
    }
}