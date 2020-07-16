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

        [Test]
        public void ReturnTheSum_WhenInputIsTwoNumbers()
        {
            int number = StringCalculatorService.Add("1,2");

            Assert.That(number, Is.EqualTo(3));
        }

        [Test]
        public void ReturnTheSum_WhenInputIsAListOfNumbers()
        {
            int number = StringCalculatorService.Add("1,2,5,10");

            Assert.That(number, Is.EqualTo(18));
        }

        [Test]
        public void AcceptCommaAndNewlineAsSeparator()
        {
            int number = StringCalculatorService.Add("1\n2,3");

            Assert.That(number, Is.EqualTo(6));
        }
    }
}