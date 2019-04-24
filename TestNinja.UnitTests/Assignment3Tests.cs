using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]

    public class Assignment3Tests
    {
        private Assignment3 test;

        [SetUp]
        public void SetUp()
        {
            test = new Assignment3();
        }

        [Test]
        public void GetDay_DayIsWeekend_ReturnWeekends()
        {
            var result = test.GetDay("sunday");

            Assert.That(result, Is.TypeOf<Weekends>());

        }

        [Test]
        public void GetDay_DayIsWeekday_ReturnWeekday()
        {
            var result = test.GetDay("monday");

            Assert.That(result, Is.TypeOf<Weekdays>());

        }
    }
}
