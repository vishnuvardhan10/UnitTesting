using Xunit;
using Products.Api.Models;

namespace Products.Api.Test.Models
{
    public class CalculatorTests
    {
        Calculator calculator = new Calculator();

        [Fact]
        public void TestAddition(){
            int result = calculator.Add(10, 5);
            Assert.Equal(15, result);
        }

        [Fact]
        public void TestSubtraction(){
            int result = calculator.Subtract(10, 5);
            Assert.Equal(5, result);
        }

        [Fact]
        public void TestMultiplication(){
            int result = calculator.Multiply(4, 6);
            Assert.Equal(24, result);
        }

        [Fact]
        public void TestDivision(){
            int result = calculator.Divide(20, 4);
            Assert.Equal(5, result);
        }

        [Fact]
        public void TestDivisionByZero(){
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));
        }
    }
}
