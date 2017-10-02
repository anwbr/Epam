using NUnit.Framework;

namespace AppTest
{
    [TestFixture]
    public class TestMethods
    {
        [Test]
        public void AdditionTest()
        {
            double result = Calculator.Addition(1, 1);
            Assert.AreEqual(2, result);
            result = Calculator.Addition(1, -1);
            Assert.AreEqual(0, result);
            result = Calculator.Addition(-1, 1);
            Assert.AreEqual(0, result);
            result = Calculator.Addition(-1, -1);
            Assert.AreEqual(-2, result);
        }

        [Test]
        public void SubtractionTest()
        {
            double result = Calculator.Subtraction(1, 1);
            Assert.AreEqual(0, result);
            result = Calculator.Subtraction(1, -1);
            Assert.AreEqual(2, result);
            result = Calculator.Subtraction(-1, 1);
            Assert.AreEqual(-2, result);
            result = Calculator.Subtraction(-1, -1);
            Assert.AreEqual(0, result);
            result = Calculator.Subtraction(-1, 1);
            Assert.AreEqual(-2, result);
        }
        [Test]
        public void MultiplicationTest()
        {
            double result = Calculator.Multiplication(1, 1);
            Assert.AreEqual(1, result);
            result = Calculator.Multiplication(1, -1);
            Assert.AreEqual(-1, result);
            result = Calculator.Multiplication(-1, 1);
            Assert.AreEqual(-1, result);
            result = Calculator.Multiplication(-1, -1);
            Assert.AreEqual(1, result);
            result = Calculator.Multiplication(-1, 1);
            Assert.AreEqual(-1, result);
        }
        [Test]
        public void DivisionTest()
        {
            double result = Calculator.Division(1, 1);
            Assert.AreEqual(1, result);
            result = Calculator.Division(1, -1);
            Assert.AreEqual(-1, result);
            result = Calculator.Division(-1, 1);
            Assert.AreEqual(-1, result);
            result = Calculator.Division(-1, -1);
            Assert.AreEqual(1, result);
            result = Calculator.Division(-1, 1);
            Assert.AreEqual(-1, result);
        }

    }
}
