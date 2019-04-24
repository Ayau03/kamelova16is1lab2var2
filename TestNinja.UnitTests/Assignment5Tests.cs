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
        [TestCase(2015, 7, 20, 25, 30, 25)]
        public void SetDate_InvalidArgumenth_ThrowArgumentException(int y, int m, int d, int h, int mm, int s)
        {
            Assert.That(() => test.SetDate(y, m, d, h, mm, s), Throws.ArgumentException);

        }
    }
}
