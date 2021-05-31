using NUnit.Framework;
using Practice_9;
using System.Collections.Generic;

namespace Practice9_Tests
{
    [TestFixture]
    class ScientificCalculator_Tests
    {
       [Test]
        public void TestPowPass()
        {
            double x = 6;
            double y = 2;
            ScientificCalculator scientificCalc = new ScientificCalculator(x, y);
            Assert.AreEqual(36, scientificCalc.Pow(x, y));
        }

        [Test]
        public void TestPowFail()
        {
            double x = 6;
            double y = 2;
            ScientificCalculator scientificCalc = new ScientificCalculator(x, y);
            Assert.Equals(35, scientificCalc.Pow(x, y));
        }

        [Test]
        public void TestPercentsPass()
        {
            double x = 2;
            double y = 150;
            ScientificCalculator scientificCalc = new ScientificCalculator(x, y);
            Assert.AreEqual(1.33, scientificCalc.Percents(x, y));
        }

        [Test]
        public void TestModPass()
        {
            double x = 16.80;
            double y = 4.10;
            ScientificCalculator scientificCalc = new ScientificCalculator(x, y);
            Assert.AreEqual(0.40, scientificCalc.Mod(x, y));
        }

        [Test]
        public void TestListSum()
        {
            List<int> listValues = new List<int>() { 1, 2, 3, 45};
            ScientificCalculator scientificCalc = new ScientificCalculator(listValues);
            Assert.AreEqual(51, scientificCalc.ListValuesSum(listValues));
        }

        [Test]
        public void ListMinValue()
        {
            List<int> listValues = new List<int>() { 1, 2, 3, 45 };
            ScientificCalculator scientificCalc = new ScientificCalculator(listValues);
            Assert.AreEqual(1, scientificCalc.ListMinValue(listValues));
        }

        [Test]
        public void ListMaxValuePass()
        {
            List<int> listValues = new List<int>() { 1, 2, 3, 45 };
            ScientificCalculator scientificCalc = new ScientificCalculator(listValues);
            Assert.AreEqual(45, scientificCalc.ListMaxValue(listValues));
        }

        [Test]
        public void ListMaxValueFail()
        {
            List<int> listValues = new List<int>() { 1, 2, 3, 45 };
            ScientificCalculator scientificCalc = new ScientificCalculator(listValues);
            Assert.AreNotEqual(45, scientificCalc.ListMaxValue(listValues));
        }

    }
}