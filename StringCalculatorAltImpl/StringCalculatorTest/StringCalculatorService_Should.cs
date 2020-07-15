using NUnit.Framework;
using NUnit.Framework.Constraints;

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

        [TestCase("1,2", 3)]
        [TestCase("1,2,3", 6)]
        [TestCase("1, 1000", 1001)]
        public void ReturnTheSum_WhenInputIsACommaSeparatedList(string text, int expectedNumber)
        {
            int number = StringCalculatorService.Add(text);

            Assert.That(number, Is.EqualTo(expectedNumber));
        }

        [Test]
        public void AcceptCommaAndNewLineAsSeparator()
        {
            int number = StringCalculatorService.Add("1/n2,3");

            Assert.That(number, Is.EqualTo(6));
        }

        [Test]
        public void AcceptCustomDelimiters()
        {
            int number = StringCalculatorService.Add("//;\n1;2");

            Assert.That(number, Is.EqualTo(3));
        }

        [Test]
        public void ThrowAnException_WhenInputContainsNegativeNumbers()
        {
            Assert.That(() => StringCalculatorService.Add("-1,-3"), Throws.ArgumentException.With
                .Property("Message").EqualTo("Negatives not allowed: -1, -3"));
        }

        [Test]
        public void SumTwo_WhenNumberIsGreaterThanAThousand()
        {
            int number = StringCalculatorService.Add("1,1001");

            Assert.That(number, Is.EqualTo(3));
        }
    }
}