using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class Assignment4Tests
    {
        private Assignment4 test;

        [SetUp]
        public void SetUp()
        {
            test = new Assignment4();
        }
        [Test]
        [TestCase(15, "детский")]
        [TestCase(20, "взрослый")]
        public void TypeOfTicket_WhenCalled_SetTypeOfTickets(int age, string type)
        {
            test.AgeOfPeople(age);
            Assert.That(test.TypeOfTicket, Is.EqualTo(type));

        }
 
    }
}
