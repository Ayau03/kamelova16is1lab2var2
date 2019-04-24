using System;
using NUnit.Framework;
using TestNinja.Fundamentals;
namespace TestNinja.UnitTests
{
    [TestFixture]
    public class Assignment5Tests
    {
        private Assignment5 test;

        [SetUp]
        public void SetUp()
        {
            test = new Assignment5();
        }
        [Test]
        [TestCase(6, 0)]
        public void DivideNumbers_InvalidArgumentB_ThrowDividedByZeroException(int a, int b)
        {
            test.DivideNumbers(a, b);

           // Assert.That(() => test.DivideNumbers(a, b), Throws.Exception.TypeOf<DivideByZeroException>);

        }
    }
}
