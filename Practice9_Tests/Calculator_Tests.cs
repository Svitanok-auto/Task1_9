using NUnit.Framework;
using Practice_9;

namespace Practice9_Tests
{
    [TestFixture]
    public class Calculator_Tests
    {
        [Test]
        public void TestAddPass()
        {
            double x = 2;
            double y = 2;
            Calculator calc = new Calculator(x, y);
            Assert.AreEqual(4, calc.Add(x, y));
        }

        [Test]
        public void TestAddFail()
        {
            double x = 2;
            double y = 2;
            Calculator calc = new Calculator(x, y);
            Assert.IsNull(calc.Add(x, y));
        }

        [Test]
        public void TestSubstractPass()
        {
            double x = 4.2;
            double y = 2;
            Calculator calc = new Calculator(x, y);
            Assert.AreEqual(2.2, calc.Substract(x, y));
        }

        [Test]
        public void TestSubstractFail()
        {
            double x = 4.2;
            double y = 2;
            Calculator calc = new Calculator(x, y);
            Assert.IsNaN (calc.Substract(x, y));
        }
        [Test]
        public void TestDividePass()
        {
            double x = 144;
            double y = 12;
            Calculator calc = new Calculator(x, y);
            Assert.AreEqual(12, calc.Divide(x, y));
        }

        [Test]
        public void TestDivideFail()
        {
            double x = 1000;
            double y = 20;
            Calculator calc = new Calculator(x, y);
            Assert.AreNotEqual(50, calc.Divide(x, y));
        }

        [Test]
        public void TestMultiplyPass()
        {
            double x = 12.0;
            double y = 12;
            Calculator calc = new Calculator(x, y);
            Assert.AreEqual(144, calc.Multiply(x, y));
        }

        [Test]
        public void TestMyltiplayFail()
        {
            double x = 10;
            double y = 20;
            Calculator calc = new Calculator(x, y);
            Assert.Zero(calc.Divide(x, y));
        }
    }
}
