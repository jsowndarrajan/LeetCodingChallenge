using System.Linq;
using April.Problems;
using NUnit.Framework;

namespace April.Tests.Problems
{
    public class LetterCombinationsOfAPhoneNumberTests
    {
        [TestCase("", new string[0])]
        [TestCase("2", new[] { "a", "b", "c" })]
        [TestCase("23", new[] { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" })]
        public void LetterCombinations(string digits, string[] expected)
        {
            var sut = new LetterCombinationsOfAPhoneNumber();
            var actual = sut.LetterCombinations(digits);
            Assert.AreEqual(expected, actual.ToArray());
        }
    }
}
