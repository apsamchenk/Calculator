using Calculator_HomeWork11_.Calc;
using NUnit.Framework;

namespace Calculator_HomeWork11_.CalcTests
{
    public class BaseCalcTest
    {
        public Calculator calculator;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            calculator = new Calculator();
        }

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
        }

        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("TearDown");
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Console.WriteLine("OneTimeTearDown");
        }
    }
}
