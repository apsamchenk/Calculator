using NUnit.Framework;

namespace Calculator_HomeWork11_.CalcTests
{
    public class DivisionTests : BaseCalcTest
    {
        [TestCase(1, 2, 2)]
        [TestCase(0, 0, 4)]
        [Category("DivisionTest")]
        [Description("Division positive numbers test")]
        public void DivisionPositiveNumbersTest(int expected, int operand1, int operand2)
        {
            Assert.That(calculator.Division(operand1, operand2), Is.EqualTo(expected));
        }

        [TestCase(-1, -2, 2)]
        [TestCase(3, -6, -2)]
        [Category("DivisionTest")]
        [Description("Division negative numbers test")]
        public void DivisionNegativeNumbersTest(int expected, int operand1, int operand2)
        {
            Assert.That(calculator.Division(operand1, operand2), Is.EqualTo(expected));
        }

        [Test, Category("DivisionTest"), Description("Division by zero")]
        public void DivisionByZeroTest()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Division(5, 0));
        }
    }
}
