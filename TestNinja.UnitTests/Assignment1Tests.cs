using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class Assignment1Tests
    {
        private Assignment1 test;

        [SetUp]
        public void SetUp()
        {
            test = new Assignment1();
        }

        [Test]
        [TestCase(2)]

        public void PositiveNegativeNumbers_IsNumberPozitive_ReturnPozitive(int arg)
        {
            var result = test.PositiveNegativeNumbers(arg);

            Assert.That(result, Does.StartWith("Число").IgnoreCase);
            Assert.That(result, Does.Contain("2"));
            Assert.That(result, Does.EndWith("Положительное").IgnoreCase);

        }
        [Test]
        [TestCase(-3)]
        public void PositiveNegativeNumbers_IsNumberNegative_ReturnNegative(int arg)
        {
            var result = test.PositiveNegativeNumbers(arg);

            Assert.That(result, Does.StartWith("Число").IgnoreCase);
            Assert.That(result, Does.Contain("-3"));
            Assert.That(result, Does.EndWith("Отрицательное").IgnoreCase);

        }

        [Test]
        [TestCase(0)]
        public void PositiveNegativeNumbers_IsNumberZero_ReturnEqualsZero(int arg)
        {
            var result = test.PositiveNegativeNumbers(arg);

            Assert.That(result, Does.StartWith("Число").IgnoreCase);
            Assert.That(result, Does.Contain("0"));
            Assert.That(result, Does.EndWith("Равно нулю").IgnoreCase);

        }
    }
}
