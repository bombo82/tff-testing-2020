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
        public void AcceptAStringAsInputAndReturnANumber()
        {
            StringCalculatorService.Add("qualsiasi stringa");

            Assert.Pass();
        }

        [Test]
        public void ReturnZero_WhenInputIsEmptyString()
        {
            int number = StringCalculatorService.Add("");

            Assert.That(number, Is.EqualTo(0));
        }
    }
}