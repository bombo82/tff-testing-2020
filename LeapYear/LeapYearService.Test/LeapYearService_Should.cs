using NUnit.Framework;
using LeapYear.Service;

namespace LeapYear.UnitTest.Service
{
    public class LeapYearService_Should
    {
        private LeapYearService service;

        [SetUp]
        public void Setup()
        {
            service = new LeapYearService();
        }

        [Test]
        public void ReturnTrue_WhenYearIsMultipleOfFour()
        {
            Assert.That(service.IsLeapYear(8), Is.True);
        }

        [Test]
        public void ReturnFalse_WhenYearIsNotMultipleOfFour()
        {
            Assert.That(service.IsLeapYear(11), Is.False);
        }

        [Test]
        public void ReturnFalse_WhenYearIsACenturyAfter1582()
        {
            Assert.That(service.IsLeapYear(1800), Is.False);
        }

        [Test]
        public void ReturnTrue_WhenYearIsACenturyBefore1582()
        {
            Assert.That(service.IsLeapYear(1500), Is.True);
        }

        [Test]
        public void ReturnTrue_WhenYearIsMultipleOf400()
        {
            Assert.That(service.IsLeapYear(2000), Is.True);
        }

        [TestCase(-4)]
        [TestCase(-8)]
        [TestCase(-1500)]
        [TestCase(-2000)]
        public void ReturnFalse_whenYearIsBefore0(int year)
        {
            Assert.That(service.IsLeapYear(year), Is.False);
        }

        [Test]
        public void ThrowArgumentException_WhenYearIsZero()
        {
            Assert.That(() => service.IsLeapYear(0), Throws.ArgumentException);
        }
    }
}
