using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class Assignment2Tests
    {
        private Assignment2 _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Assignment2();
        }
        [Test]
        [TestCase(5, 3)]
        public void GetNumbers_SummAandBisEven_ReturnNumbersUpToA(int A, int B)
        {
            var result = _math.GetNumbers(A, B);

            Assert.That(result, Is.Not.Empty);

            Assert.That(result, Does.Contain(1));

            Assert.That(result, Does.Contain(2));

            Assert.That(result, Does.Contain(3));

            Assert.That(result, Does.Contain(4));

            Assert.That(result, Does.Contain(5));

            Assert.That(result, Is.Ordered);

            Assert.That(result, Is.Unique);

        }
        [Test]
        [TestCase(4, 3)]
        public void GetNumbers_SummAandBisOdd_ReturnNumbersUpToB(int A, int B)
        {
            var result = _math.GetNumbers(A, B);

            Assert.That(result, Is.Not.Empty);

            Assert.That(result, Does.Contain(1));

            Assert.That(result, Does.Contain(2));

            Assert.That(result, Does.Contain(3));

            Assert.That(result, Is.Ordered);

            Assert.That(result, Is.Unique);

        }
    }
}
