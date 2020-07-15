using NUnit.Framework;

namespace StringCalculator.Test
{
    public class StringCalculatorService_Should
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ReturnANumber_WhenInputIsAString()
        {
            int number = StringCalculatorService.Add("qualsiasi stringa");

            Assert.Pass();
        }

        [Test]
        public void ReturnZero_WhenInputIsAnEmptyString()
        {
            int number = StringCalculatorService.Add("");

            Assert.That(number, Is.EqualTo(0));
        }
    }
}