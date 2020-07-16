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
    }
}