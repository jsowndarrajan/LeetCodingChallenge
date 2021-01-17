using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using January.Problems;
using NUnit.Framework;

namespace January.Tests.Problems
{
    public class CountSortedVowelStringsTests
    {
        [TestCase(1, 5)]
        [TestCase(2, 15)]
        [TestCase(33, 66045)]
        public void CountVowelStringsByFormingAllCombinations(int n, int expected)
        {
            var sut = new CountSortedVowelStrings();
            var actual = sut.CountVowelStringsByFormingAllCombinations(n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 5)]
        [TestCase(2, 15)]
        [TestCase(33, 66045)]
        public void CountVowelStringsByUsingPatternLogic(int n, int expected)
        {
            var sut = new CountSortedVowelStrings();
            var actual = sut.CountVowelStringsByUsingPatternLogic(n);
            Assert.AreEqual(expected, actual);
        }
    }
}
