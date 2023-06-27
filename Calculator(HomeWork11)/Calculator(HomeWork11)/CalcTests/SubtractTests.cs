using NUnit.Framework;

namespace Calculator_HomeWork11_.CalcTests
{
    public class SubtractTests : BaseCalcTest
    {
        [TestCase(2, 4, 2)]
        [TestCase(4, 4, 0)]
        [TestCase(0, 4, 4)]
        [Category("SubtractTest")]
        [Description("Subtract positive numbers test")]
        public void SubtractPositiveNumbersTest(double expected, double operand1, double operand2)
        {
            Assert.That(calculator.Subtract(operand1, operand2), Is.EqualTo(expected));
        }

        [TestCase(-4, -2, 2)]
        [TestCase(-4, -6, -2)]
        [Category("SubtractTest")]
        [Description("Subtract negative numbers test")]
        public void SubtractNegativeNumbersTest(double expected, double operand1, double operand2)
        {
            Assert.That(calculator.Subtract(operand1, operand2), Is.EqualTo(expected));
        }

        [Test, Category("SubtractTest"), Description("Subtract range numbers test")]
        public void SubtactRangeNumbersTest(
            [Values(4, 5, 6)] double operand1,
            [Range(0, 5, 1)] double operand2)
        {
            var expected = 3;
            var actual = calculator.Subtract(operand1, operand2);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
