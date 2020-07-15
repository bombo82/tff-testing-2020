using NUnit.Framework;
using System.Collections.Generic;
using PrimeFactor.Service;

namespace PrimeFactorsTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void One_ShouldReturn_NoPrimeFactors()
        {
            List<int> primeFactors = PrimeFactors.calculate(1);

            Assert.That(primeFactors, Is.Empty);
        }

        [Test]
        public void Two_ShouldReturn_Two()
        {
            List<int> primeFactors = PrimeFactors.calculate(2);

            List<int> expectedValue = new List<int>() { 2 };
            Assert.That(primeFactors, Is.EqualTo(expectedValue));
        }

        [Test]
        public void Three_ShouldReturn_Three()
        {
            List<int> primeFactors = PrimeFactors.calculate(3);

            List<int> expectedValue = new List<int>() { 3 };
            Assert.That(primeFactors, Is.EqualTo(expectedValue));
        }

        [Test]
        public void Four_ShouldReturn_TwoTwo()
        {
            List<int> primeFactors = PrimeFactors.calculate(4);

            List<int> expectedValue = new List<int>() { 2, 2 };
            Assert.That(primeFactors, Is.EqualTo(expectedValue));
        }
    }
}