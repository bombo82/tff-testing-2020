using NUnit.Framework;
using Parity.Library;

namespace ParityUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IsEven_ShouldReturnTrue_WhenNumberIsOne()
        {
            bool isEven = ParityService.IsEven(1);

            Assert.That(isEven, Is.True);
        }

        [Test]
        public void IsEven_ShouldReturnFalse_WhenNumberIsTwo()
        {
            bool isEven = ParityService.IsEven(2);

            Assert.That(isEven, Is.False);
        }
    }
}