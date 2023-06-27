using NUnit.Framework;

namespace Calculator_HomeWork11_.CalcTests
{
    public class MultiplyTests : BaseCalcTest
    {
        [TestCase(4, 2, 2)]
        [TestCase(0, 4, 0)]
        [Category("MultiplyTest")]
        [Description("Multiply positive numbers test")]
        public void MultiplyPositiveNumbersTest(double expected, double operand1, double operand2)
        {
            Assert.That(calculator.Multiply(operand1, operand2), Is.EqualTo(expected));
        }

        [TestCase(-4, -2, 2)]
        [TestCase(10, -5, -2)]
        [Category("MultiplyTest")]
        [Description("Multiply negative numbers test")]
        public void MultiplyNegativeNumbersTest(double expected, double operand1, double operand2)
        {
            Assert.That(calculator.Multiply(operand1, operand2), Is.EqualTo(expected));
        }

        [Test, Category("MultiplyTest"), Description("Multiply retry test")]
        [Retry(5)]
        public void MultiplyRetryNumbersTest()
        {
            var rand = new Random();
            var expected = 6;
            var actual = calculator.Multiply(2, rand.Next(0, 5));

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
