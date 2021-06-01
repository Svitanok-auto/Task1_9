using NUnit.Framework;
using Practice_9;
using System;

namespace Practice9_Tests
{
    [TestFixture, Description("Extended Scientific Calculator Tests")]
    [Category("ScientificCalcExtended")]
    public class ScientificCalculator_Tests_Extended
    {
        private ScientificCalculator _scientifiCalc;
        [SetUp] public void Init() 
        {
            _scientifiCalc = new ScientificCalculator();
        }
        [TearDown] public void AfterTest() 
        {
            Console.WriteLine("Test is completed");
        }
        [OneTimeTearDown] public void AfterAllTests()
        {
            Console.WriteLine("All tests are completed");
        }

        [TestCase(6, 6, ExpectedResult = 12), Description ("Scientific Calculator Add(pass)"), MaxTime(1000)]
        [TestCase(1, -3, ExpectedResult = -2)]
        [TestCase(2.5, 100, ExpectedResult = 102.5)]
        [TestCase(0, 2, ExpectedResult = 2)]
        [TestCase(-7.1, -2.2, ExpectedResult = -9.3)]

        public double TestAddPass(double x, double y)
        {
            return _scientifiCalc.Add(x, y);
        }

        [TestCase(6, -6, ExpectedResult = 1), Description("Scientific Calculator Add(fail)"), MaxTime(1000)]
        [TestCase(1, -3, ExpectedResult = 0)]

        public double TestAddFail(double x, double y)
        {
            return _scientifiCalc.Add(x, y);
        }

        [TestCase(10, 2, ExpectedResult = 8), Description("Scientific Calculator Substract(pass)"), MaxTime(1000)]
        [TestCase(-1, -2.2, ExpectedResult = 1.20)]
        [Retry(6)]
        public double TestSubstractPass(double x, double y)
        {
            return _scientifiCalc.Substract(x, y);
        }

        [TestCase(12.4, 23, ExpectedResult = 1), Description("Scientific Calculator Substract(fail)")]
        [Ignore("Ignore this test")]

        public double TestSubstractFail(double x, double y)
        {
            return _scientifiCalc.Substract(x, y);
        }

        [TestCase(40, 2, ExpectedResult = 20), Description("Scientific Calculator Divide(pass)"), MaxTime(1000)]
        [TestCase(-30, -2, ExpectedResult = 15)]
        [Repeat(3)]
        public double TestDividePass(double x, double y)
        {
            return _scientifiCalc.Divide(x, y);
        }

        [TestCase(56, 0, ExpectedResult = 1), Description("Scientific Calculator Divide(fail)")]
        [Ignore("Ignore this test")]

        public double TestDivideFail(double x, double y)
        {
            return _scientifiCalc.Divide(x, y);
        }
    }
}
