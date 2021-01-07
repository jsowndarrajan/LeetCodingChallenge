using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using January.Problems;
using NUnit.Framework;

namespace January.Tests.Problems
{
    public class LongestSubstringTests
    {
        private LongestSubstring _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new LongestSubstring();
        }

        [TestCase("", 0)]
        [TestCase(" ", 1)]
        [TestCase("dvdf", 3)]
        [TestCase("abcabcbb", 3)]
        [TestCase("bbbbb", 1)]
        [TestCase("pwwkew", 3)]
        [TestCase("tmmzuxt", 5)]
        public void LengthOfLongestSubstringTest(string input, int expected)
        {
            var actual = _sut.LengthOfLongestSubstring(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
