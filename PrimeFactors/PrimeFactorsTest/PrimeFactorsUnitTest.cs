using NUnit.Framework;
using System.Collections.Generic;
using PrimeFactor.Service;
using System;

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

        [TestCase(2, 2)]
        [TestCase(3, 3)]
        [TestCase(4, 2, 2)]
        [TestCase(5, 5)]
        [TestCase(6, 2, 3)]
        [TestCase(7, 7)]
        [TestCase(8, 2, 2, 2)]
        [TestCase(2*2*2*2*2*3*3*3*3*3*5*7*19, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 5, 7, 19)]
        public void PrimeFactors_ShouldReturn(int number, params int[] expectedFactors)
        {
            List<int> primeFactors = PrimeFactors.calculate(number);

            Assert.That(primeFactors, Is.EqualTo(expectedFactors));
        }

        [Test]
        public void NegativeNumber_ShouldThrow_InvalidOperationException()
        {
            try
            {
                List<int> primeFactors = PrimeFactors.calculate(-1);
            }
            catch(InvalidOperationException e)
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}