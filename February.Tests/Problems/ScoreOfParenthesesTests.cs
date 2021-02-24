using February.Problems;
using NUnit.Framework;

namespace February.Tests.Problems
{
    public class ScoreOfParenthesesTests
    {
        [TestCase("()", 1)]
        [TestCase("(())", 2)]
        [TestCase("()()", 2)]
        [TestCase("(()(()))", 6)]
        public void ScoreOfParentheses(string input, int expected)
        {
            var sut = new ScoreOfParentheses();
            var actual = sut.Compute(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
