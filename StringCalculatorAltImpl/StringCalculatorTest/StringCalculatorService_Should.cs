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
    }
}