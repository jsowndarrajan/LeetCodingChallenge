using February.Problems;
using NUnit.Framework;
using System.Linq;

namespace February.Tests.Problems
{
    public class LetterCasePermutationTests
    {
        [TestCase("a1b2", new[] { "a1b2", "a1B2", "A1b2", "A1B2" })]
        [TestCase("3z4", new[] { "3z4", "3Z4" })]
        [TestCase("12345", new[] { "12345" })]
        [TestCase("0", new[] { "0" })]
        public void Permute(string input, string[] expected)
        {
            var sut = new LetterCasePermutation();
            var actual = sut.ComputeLetterCasePermutation(input);
            Assert.AreEqual(0, expected.Except(actual).Count());
        }
    }
}
