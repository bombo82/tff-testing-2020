using NUnit.Framework;
using StringCalculator;

namespace StringCalculatorTest
{
    public class StringCalculatorService_Should
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ReturnZero_WhenInputIsEmptyString()
        {
            int number = StringCalculatorService.Add("");

            Assert.That(number, Is.EqualTo(0));
        }

        [Test]
        public void ReturnTheNumber_WhenInputStringIsANumber()
        {
            int number = StringCalculatorService.Add("1");

            Assert.That(number, Is.EqualTo(1));
        }
    }
}