using NUnit.Framework;
using System;

namespace Practice9_Tests
{
    [TestFixture, Description("Tests for strings")]
    [Category("ScientificCalcExtended")]
    public class ScientificCalculator_Tests_Extended_String
    {
        private string _initialString;
        [OneTimeSetUp]
        public void Init()
        {
            _initialString = "This is a new string for testing";
        }
        [OneTimeTearDown]
        public void AfterAllTests()
        {
            Console.WriteLine("All tests are completed");
        }

        [Test, Description("Check String contains substring(pass)"), MaxTime(1000), Order(1)]
        public void TestStringContainsPass()
        {
            Assert.That(_initialString, Does.Contain("new"));
        }

        [Test, Description("Check String starts with substring(pass)"), MaxTime(1000), Order(3)]
        public void TestStringStartsWithPass()
        {
            Assert.That(_initialString, Does.StartWith("This"));
        }

        [Test, Description("Check Strings are equal(pass)"), MaxTime(1000), Order(2)]
        public void TestStringsAreEqualPass()
        {
            Assert.That(_initialString, Is.EqualTo("This is a new string for testing"));
        }

        [Test, Description("Check Strings are equal ignoring the case(pass)"), MaxTime(1000), Order(4)]
        public void TestStringsAreEqualIgnoringTheCasePass()
        {
            Assert.IsTrue(string.Equals(_initialString, "this Is a new string for Testing", StringComparison.OrdinalIgnoreCase));
        }
    }
}
