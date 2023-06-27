using NUnit.Framework;

namespace Calculator_HomeWork11_.CalcTests
{
    public class SumTests : BaseCalcTest
    {
        [TestCase(4, 2, 2)]
        [TestCase(4, 4, 0)]
        [Category("SumTest")]
        [Description("Sum positive numbers test")]
        public void SumPositiveNumbersTest(double expected, double operand1, double operand2)
        {
            Assert.That(calculator.Add(operand1, operand2), Is.EqualTo(expected));
        }

        [TestCase(0, -2, 2)]
        [TestCase(-8, -6, -2)]
        [Category("SumTest")]
        [Description("Sum negative numbers test")]
        public void SumNegativeNumbersTest(double expected, double operand1, double operand2)
        {
            Assert.That(calculator.Add(operand1, operand2), Is.EqualTo(expected));
        }

        [Test, Category("SumTest"), Description("Sum random numbers test")]
        public void SumRandomNumbersTest(
            [Values(1, 2, 3)] double operand1,
            [Random(0, 5, 5)] double operand2)
        {
            var expected = 4;
            var actual = calculator.Add(operand1, operand2);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
