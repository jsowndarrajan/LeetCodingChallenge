using System;
using February.Problems;
using NUnit.Framework;
using Shared.Helpers;

namespace February.Tests.Problems
{
    public class NumberOfStepsToReduceANumberToZeroTests
    {
        [TestCase(123, 12)]
        [TestCase(14, 6)]
        [TestCase(8, 4)]
        [TestCase(0, 0)]
        public void GivenPositiveValue_WhenCallNumberOfSteps_ThenShouldReturnNumberOfSteps(int num, int expected)
        {
            var sut = new NumberOfStepsToReduceANumberToZero();
            var actual = sut.NumberOfSteps(num);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-1, 0)]
        [TestCase(-1000, 0)]
        public void GivenNegativeValue_WhenCallNumberOfSteps_ThenShouldThrowException(int num, int expected)
        {
            var sut = new NumberOfStepsToReduceANumberToZero();
            var ex = Assert.Throws<ArgumentException>(() => sut.NumberOfSteps(num));
            Assert.That(ex.Message, Is.EqualTo(Messages.InvalidInput));
        }
    }
}
