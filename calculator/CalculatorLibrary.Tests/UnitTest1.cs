using NUnit.Framework;
using CalculatorLibrary;

namespace CalculatorLibrary.Tests
{
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Add_TwoNumbers_ReturnsCorrectSum()
        {
            var result = _calculator.Add(2, 3);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Subtract_TwoNumbers_ReturnsCorrectDifference()
        {
            var result = _calculator.Subtract(5, 3);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Multiply_TwoNumbers_ReturnsCorrectProduct()
        {
            var result = _calculator.Multiply(2, 3);
            Assert.AreEqual(6, result);
        }

        [Test]
        public void Divide_TwoNumbers_ReturnsCorrectQuotient()
        {
            var result = _calculator.Divide(6, 3);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Divide_ByZero_ThrowsDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(6, 0));
        }
    }
}
