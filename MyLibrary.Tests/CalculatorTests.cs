using NUnit.Framework;
using MyLibrary.Tests;
namespace MyLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests : BaseTest
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void Add_WhenCalled_ReturnsCorrectResult()
        {
            int result = calculator.Add(3, 5);
            Assert.AreEqual(8, result);
        }

        [Test]
        public void Subtract_WhenCalled_ReturnsCorrectResult()
        {
            int result = calculator.Subtract(10, 3);
            Assert.AreEqual(7, result);
        }

        [Test]
        public void Subtract_WhenResultIsNegative_ReturnsCorrectResult()
        {
            int result = calculator.Subtract(3, 5);
            Assert.AreEqual(-2, result);
        }
    }
}