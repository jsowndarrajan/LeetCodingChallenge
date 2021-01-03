using NUnit.Framework;
using System;
using System.Collections.Generic;
using Shared.Helpers;

namespace Shared.Tests.Helpers
{
    internal class DataConverterTests
    {
        [TestCase("[]", new int[] {})]
        [TestCase("[      ]", new int[] { })]
        [TestCase("[1]", new[]{1})]
        [TestCase("[1,   2]", new[]{1, 2})]
        [TestCase("[ 1, 4, 6  ] ", new[]{1, 4, 6})]
        [TestCase(" [10, 23]", new[]{10, 23})]
        public void ShouldReturnValidIntArray(string input, int[] expected)
        {
            var actual = DataConverter.ConvertStringToIntArray(input);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("][")]
        [TestCase("Invalid Input")]
        public void ShouldThrowArgumentException(string input)
        {
            var ex = Assert.Throws<ArgumentException>(() => DataConverter.ConvertStringToIntArray(input));
            Assert.That(ex.Message, Is.EqualTo(Messages.InvalidInput));
        }

        [Test, TestCaseSource(nameof(TestCaseSource))]
        public void ShouldReturnValidNestedArray(string input, List<int[]> expected)
        {
            var actual = DataConverter.ConvertStringToNestedArray(input);
            Assert.AreEqual(expected.ToArray(), actual);
        }

        private static readonly object[] TestCaseSource =
        {
            new object[] { "[[1], [2, 3]]", new List<int[]>{ new[] {1}, new [] {2,3} } },
            new object[] { "[[1], []]", new List<int[]>{ new[] {1}, new int[] {} } },
        };
    }
}
