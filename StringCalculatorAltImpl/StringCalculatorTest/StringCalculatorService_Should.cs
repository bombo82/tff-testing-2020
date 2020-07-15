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
        public void ReturnZero_WhenInputIsAnEmptyString()
        {
            int number = StringCalculatorService.Add("");

            Assert.That(number, Is.EqualTo(0));
        }

        [Test]
        public void ReturnANumber_WhenInputIsANumber()
        {
            int number = StringCalculatorService.Add("1");

            Assert.That(number, Is.EqualTo(1));
        }

        [Test]
        public void ReturnTheSum_WhenInputIsACommaSeparatedList()
        {
            int number = StringCalculatorService.Add("1,2");

            Assert.That(number, Is.EqualTo(3));
        }
    }
}