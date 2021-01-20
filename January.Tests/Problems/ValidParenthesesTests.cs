using January.Problems;
using NUnit.Framework;

namespace January.Tests.Problems
{
    public class ValidParenthesesTests
    {
        [TestCase("(((", false)]
        [TestCase("()[[}", false)]
        [TestCase("()", true)]
        [TestCase("([])", true)]
        [TestCase("()[]{}", true)]
        public void IsValid(string input, bool expected)
        {
            var sut = new ValidParentheses();
            var actual = sut.IsValid(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
