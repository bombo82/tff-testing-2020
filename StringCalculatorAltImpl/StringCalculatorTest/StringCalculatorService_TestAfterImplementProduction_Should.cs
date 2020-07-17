using System;
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
        public void ThrowNullReferenceException_WhenInputIsNull()
        {
            Assert.That(() => StringCalculatorService.Add(null), Throws.TypeOf(typeof(NullReferenceException)));
        }

        [Test]
        public void ReturnZero_WhenInputIsEmptyString()
        {
            int number = StringCalculatorService.Add("");
            
            Assert.That(number, Is.EqualTo(0));
        }

        [TestCase("0", 0)]
        [TestCase("1", 1)]
        [TestCase("10", 10)]
        [TestCase("456", 456)]
        [TestCase("1001", 2)]
        public void ReturnTheInputNumberAsInteger(string inputString, int expectedNumber)
        {
            int number = StringCalculatorService.Add(inputString);

            Assert.That(number, Is.EqualTo(expectedNumber));
        }

        [Test]
        public void ReturnTheConvertedNumber_IgnoringPrefixBeforeNewLine()
        {
            int number = StringCalculatorService.Add("//c\n0");
            
            Assert.That(number, Is.EqualTo(0));
        }

        [Test]
        public void CheckNegatives()
        {
            Assert.That(() => StringCalculatorService.Add("-1"), Throws.ArgumentException);
        }
    }
}