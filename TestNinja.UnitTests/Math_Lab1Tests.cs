using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class Math_Lab1Tests
    {
        private Math_Lab1 _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Math_Lab1();
        }

        [Test]
        [TestCase(5, 10, true)]
        [TestCase(10, 5, false)]
        [TestCase(10, 6, true)]
        [TestCase(10, 10, true)]
        public void AlessThanB_WhenCalled_ReturnTheLessArgument(int a, int b, bool expectedResult)
        {

            var result = _math.AlessThanB(a, b);

            Assert.That(result, Is.EqualTo(expectedResult));

        }
    }
}
