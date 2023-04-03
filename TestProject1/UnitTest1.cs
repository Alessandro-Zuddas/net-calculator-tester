

using net_calculator_tester;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        Calculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }

        [Test]
        [TestCase((float)1.5, (float)2.3)]
        [TestCase((float)2.5, (float)3.5)]
        public void TestAdd(float num1, float num2)
        {
            var sum = calc.Add(num1, num2);
            Assert.Pass();
        }

        [Test]
        [TestCase((float)1.5, (float)2.3)]
        [TestCase((float)2.5, (float)3.5)]
        public void TestSubtract(float num1, float num2)
        {
            var subtract = calc.Subtract(num1, num2);
            Assert.Pass();
        }

        [Test]
        [TestCase((float)1.5, (float)2.3)]
        [TestCase((float)2.5, (float)3.5)]
        public void TestDivide(float num1, float num2)
        {
            var divide = calc.Divide(num1, num2);
            Assert.Pass();
        }

        [Test]
        [TestCase((float)1.5, (float)2.3)]
        [TestCase((float)2.5, (float)3.5)]
        public void TestMultiply(float num1, float num2)
        {
            var multiply = calc.Multiply(num1, num2);
            Assert.Pass();
        }
    }
}