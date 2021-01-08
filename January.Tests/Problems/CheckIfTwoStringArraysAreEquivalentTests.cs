using January.Problems;
using NUnit.Framework;

namespace January.Tests.Problems
{
    public class CheckIfTwoStringArraysAreEquivalentTests
    {
        private CheckIfTwoStringArraysAreEquivalent _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new CheckIfTwoStringArraysAreEquivalent();
        }

        [Test, TestCaseSource(nameof(_testCaseSource))]
        public void FindKthPositive(string[] word1, string[] word2, bool expected)
        {
            var actual = _sut.ArrayStringsAreEqual(word1, word2);
            Assert.AreEqual(actual, expected);
        }

        private static readonly object[] _testCaseSource =
        {
            new object[]
            {
                new[] {"a", "bc"},
                new[] {"ab", "c"},
                true
            },
            new object[]
            {
                new[] {"a", "bc"},
                new[] {"ab", "cd"},
                false
            },
            new object[]
            {
                new[] {"abc", "d", "defg"},
                new[] {"abcddef"},
                false
            },
            new object[]
            {
                new[] {""},
                new[] {"a"},
                false
            }
        };
    }
}
