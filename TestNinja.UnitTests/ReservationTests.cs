using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //Arrange
            var reservation = new Reservation();

            //Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            //Assert
            Assert.IsTrue(result);
            Assert.That(result, Is.True);
            Assert.That(result == true);
        }

        [Test]
        public void CanBeCancelledBy_UserMadeBy_ReturnsTrue()
        {
            //Arrange
            var reservation = new Reservation();

            //Act
            var creator = new User();

            reservation.MadeBy = creator;

            var result = reservation.CanBeCancelledBy(creator);

            //Assert
            Assert.IsTrue(result);
            Assert.That(result, Is.True);
            Assert.That(result == true);
        }

        [Test]
        public void CanBeCancelledBy_Others_ReturnsFalse()
        {
            //Arrange
            var reservation = new Reservation();

            //Act
            var creator = new User();

            reservation.MadeBy = creator;

            var user = new User() { IsAdmin = false };

            var result = reservation.CanBeCancelledBy(user);

            //Assert
            Assert.IsFalse(result);
            Assert.That(result, Is.False);
            Assert.That(result == false);
        }
    }
}
